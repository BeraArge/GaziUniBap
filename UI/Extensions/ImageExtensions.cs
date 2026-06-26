using BusinessLogicLayer.Abstracts;
using DataTransferObject.SoruUser.Excel;
using DataTransferObject.User;
using Entity;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.ComponentModel;
using System.Drawing;
using System.Net.Http.Headers;

namespace UI.Extensions
{
    public class ImageExtensions
    {
        private static string slashed = Path.DirectorySeparatorChar.ToString();
        IWebHostEnvironment _hostingEnvironment;
        int row = 0;
        public ImageExtensions(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task DocDelete(string docname)
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath + slashed + docname);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        //public async Task<FileDetails> FileUpload(IFormFile file, string path)
        //{
        //    var fileName = string.Empty;
        //    string PathDB = string.Empty;
        //    var newFileName = string.Empty;
        //    var newFileName1 = string.Empty;

        //    FileDetails filedetail = new FileDetails();
        //    if (file.Length > 0)
        //    {
        //        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        //        newFileName1 = fileName;
        //        var myUniqueFileName = Convert.ToString(Guid.NewGuid());

        //        var FileExtension = Path.GetExtension(fileName);
        //        var uploads = Path.Combine(_hostingEnvironment.WebRootPath, path);
        //        newFileName = path + slashed + myUniqueFileName + FileExtension;

        //        fileName = Path.Combine(uploads + slashed + myUniqueFileName + FileExtension);
        //        filedetail.address = newFileName;
        //        filedetail.size = file.Length;
        //        filedetail.extention = FileExtension;
        //        filedetail.fullpathname = newFileName1;
        //        //await using (FileStream fs = System.IO.File.Create(fileName))
        //        await using (var fs = new FileStream(
        //            Path.Combine(uploads, myUniqueFileName + FileExtension),
        //            FileMode.Create,
        //            FileAccess.Write,
        //            FileShare.None,
        //            bufferSize: 81920,
        //            useAsync: true))
        //        {
        //            await file.CopyToAsync(fs);
        //            fs.Flush();
        //        }


        //    }
        //    return filedetail;
        //}
        public async Task<FileDetails> FileUpload(IFormFile file, string path)
        {
            FileDetails filedetail = new FileDetails();

            if (file == null || file.Length == 0)
                return filedetail;

            // ⚡ Daha hızlı: ContentDisposition parse yerine direkt FileName
            var originalFileName = file.FileName;
            var fileExtension = Path.GetExtension(originalFileName);

            var myUniqueFileName = Guid.NewGuid().ToString();

            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, path);

            // ⚡ Klasör yoksa oluştur (IO lock önler)
            if (!Directory.Exists(uploads))
                Directory.CreateDirectory(uploads);

            var physicalPath = Path.Combine(uploads, myUniqueFileName + fileExtension);

            // DB için relative path aynı formatta kalıyor
            var relativePath = path + slashed + myUniqueFileName + fileExtension;

            filedetail.address = relativePath;
            filedetail.size = file.Length;
            filedetail.extention = fileExtension;
            filedetail.fullpathname = originalFileName;

            // ⚡ Gerçek performanslı async file write
            await using (var fs = new FileStream(
                physicalPath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                bufferSize: 131072, // 128KB buffer (daha hızlı)
                useAsync: true))
            {
                await file.CopyToAsync(fs);
            }

            return filedetail;
        }
        public MemoryStream UserAnswerReportsExcelDocument(UserAnswerExcelExportDTO data)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                AddWorksheet(package, data.Summary, "Özet");
                AddWorksheet(package, data.UserReports, "Kullanıcı Bazlı Rapor");
                AddWorksheet(package, data.Details, "Cevap Detayları");

                var memoryStream = new MemoryStream();

                package.SaveAs(memoryStream);

                memoryStream.Seek(0, SeekOrigin.Begin);

                return memoryStream;
            }
        }
        private void AddWorksheet<TModel>(
            ExcelPackage package,
            List<TModel> models,
            string worksheetName) where TModel : class, new()
        {
            var worksheet = package.Workbook.Worksheets.Add(worksheetName);
            var properties = typeof(TModel).GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                worksheet.Cells[1, i + 1].Value = properties[i].Name;
                worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                worksheet.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(8, 124, 143));
                worksheet.Cells[1, i + 1].Style.Font.Color.SetColor(System.Drawing.Color.White);
            }

            int row = 2;

            foreach (var model in models)
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    var value = properties[i].GetValue(model);

                    worksheet.Cells[row, i + 1].Value = value;

                    if (value is DateTime)
                    {
                        worksheet.Cells[row, i + 1].Style.Numberformat.Format = "dd.MM.yyyy HH:mm";
                    }
                }

                row++;
            }

            if (worksheet.Dimension != null)
            {
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                worksheet.View.FreezePanes(2, 1);
                worksheet.Cells[worksheet.Dimension.Address].AutoFilter = true;
            }
        }
    }
}
