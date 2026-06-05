namespace UI.Extensions
{
    public class FileDetails
    {
        public int width { get; set; }
        public int height { get; set; }
        public double size { get; set; }
        public string address { get; set; }
        public string extention { get; set; }
        public string fullpathname { get; set; }
        public string? fileName { get; set; }
        internal FileDetails() { }
        internal FileDetails(string fpn, int w, int h, int s, string a, string ex)
        {
            width = w;
            height = h;
            address = a;
            size = s;
            extention = ex;
            fullpathname = fpn;
        }
    }
}
