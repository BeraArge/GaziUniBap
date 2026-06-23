using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.Paging;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataTransferObject.SmsModel;
using DataTransferObject.User;
using DataTransferObject.User.KullaniciIslemleri;
using DataTransferObject.User.Mobil;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Security.Hashing;

namespace BusinessLogicLayer.Concretes
{
    public class UserBL : IUserBL
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserBL(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public Result<UserModel> GetByPhone(SendSmsModel model)
        {
            Result<UserModel> result;

            if (string.IsNullOrEmpty(model.Phone))
            {
                result = new Result<UserModel>(false, "Lütfen sms gönderilecek telefon numarasının girişini yapınız.");
                return result;
            }
            User user = _userRepository.GetAsync(w => w.Phone == model.Phone).GetAwaiter().GetResult();
            if (user == null)
            {
                result = new Result<UserModel>(false, "Kullanıcı bulunamadı");
                return result;
            }
            UserModel usermodel = _mapper.Map<UserModel>(user);
            result = new Result<UserModel>(true, usermodel, "İşlem başarılı");
            return result;
        }
        public Result<UserModel> UpdatePasswordForSms(string newPass, int userId)
        {
            Result<UserModel> result;
            try
            {
                User admin = _userRepository.Get(w => w.Id == userId);
                if (admin != null)
                {
                    UserModel UserModel = _mapper.Map<User, UserModel>(admin);
                    byte[] passwordHash, passwordSalt;
                    HashingHelper.CreatePasswordHash(newPass, out passwordHash, out passwordSalt);
                    admin.PasswordHash = passwordHash;
                    admin.PasswordSalt = passwordSalt;
                    _userRepository.Update(admin);
                    result = new Result<UserModel>(true, UserModel, "Şifreniz başarıyla güncellendi");

                }
                else
                {
                    result = new Result<UserModel>(false, null, "Kullanıcı bulunamadı");
                }
            }
            catch (Exception ex)
            {
                result = new Result<UserModel>(false, null, "Güncelleme sırasında bir hata meydana geldi " + ex.Message);
            }
            return result;
        }
        public async Task<Result<bool>> UpdateProfileAsync(UpdateProfileDTO dto)
        {
            var user = await _userRepository.GetAsync(a => a.Id == dto.UserId);

            if (user == null)
                return new Result<bool>(false, "Kullanıcı Bulunamadı");

            user.UserName = dto.UserName;
            user.Phone = dto.Phone;

            await _userRepository.UpdateAsync(user);
            return new Result<bool>(true, "Güncelleme Başarılı"); ;
        }

        public async Task<Result<bool>> UpdatePasswordAsync(UpdatePasswordDTO dto)
        {
            var user = await _userRepository.GetAsync(a => a.Id == dto.UserId);

            if (user == null)
                return new Result<bool>(false, "Kullanıcı Bulunamadı");

            var oldPasswordValid = HashingHelper.VerifyPasswordHash(
                dto.OldPassword,
                user.PasswordHash,
                user.PasswordSalt
            );

            if (!oldPasswordValid)
                return new Result<bool>(false, "Eski Şifre Hatalı");

            HashingHelper.CreatePasswordHash(dto.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _userRepository.UpdateAsync(user);
            return new Result<bool>(true, "Güncelleme Başarılı"); ;
        }
        public Result<UserModel> GetById(int id)
        {
            Result<UserModel> result;

            User user = _userRepository.GetAsync(w => w.Id == id).GetAwaiter().GetResult();
            if (user == null)
            {
                result = new Result<UserModel>(false, "Kullanıcı bulunamadı");
                return result;
            }
            UserModel model = _mapper.Map<UserModel>(user);
            result = new Result<UserModel>(true, model, "İşlem başarılı");
            return result;
        }

        public async Task<Result<List<UserListDto>>> GetAllAsync()
        {
            var users = await _userRepository.GetAsListAsync(
                x => x.RoleId != 1,
                include: x => x.Include(y => y.Role)
            );

            var result = users.Select(x => new UserListDto
            {
                Id = x.Id,

                Name = x.Name,
                Surname = x.Surname,
                UserName = x.UserName,

                Phone = x.Phone,

                RoleId = x.RoleId,
                RoleName = x.Role != null ? x.Role.Name : null,

                OgrenciNo = x.RoleId == 3 ? x.OgrenciNo : null,
                SimulasyonTamamlandiMi = x.RoleId == 3 && x.SimulasyonTamamlandiMi,
                CozumlemeTamamlandiMi = x.RoleId == 3 && x.CozumlemeTamamlandiMi,
                ToplamPuan = x.RoleId == 3 ? x.ToplamPuan : null,
                KvkkApproved = x.KvkkApproved,
                OnamApproved = x.OnamApproved,
                IlkGiris = x.IlkGiris
            }).ToList();

            return new Result<List<UserListDto>>(true, result);
        }
        public async Task<Result<IPaginate<UserListDto>>> GetAllAsync(UserListRequestDto request)
        {
            var query = _userRepository.Query()
                .Include(x => x.Role)
                .Where(x => x.RoleId != 1);

            if (!string.IsNullOrWhiteSpace(request.Search))
            {
                var search = request.Search.ToLower();

                query = query.Where(x =>
                    (x.UserName != null && x.UserName.ToLower().Contains(search)) ||
                    (x.Name != null && x.Name.ToLower().Contains(search)) ||
                    (x.Surname != null && x.Surname.ToLower().Contains(search)) ||
                    (x.UserName != null && x.UserName.ToLower().Contains(search)) ||
                    (x.Phone != null && x.Phone.ToLower().Contains(search)) ||
                    (x.OgrenciNo != null && x.OgrenciNo.ToLower().Contains(search)) ||
                    (x.Role != null && x.Role.Name.ToLower().Contains(search))
                );
            }

            if (request.RoleId.HasValue && request.RoleId.Value > 0)
            {
                query = query.Where(x => x.RoleId == request.RoleId.Value);
            }

            var dtoQuery = query
                .OrderByDescending(x => x.Id)
                .Select(x => new UserListDto
                {
                    Id = x.Id,

                    Name = x.Name,
                    Surname = x.Surname,
                    UserName = x.UserName,

                    Phone = x.Phone,

                    RoleId = x.RoleId,
                    RoleName = x.Role != null ? x.Role.Name : null,

                    OgrenciNo = x.RoleId == 2 ? x.OgrenciNo : null,

                    SimulasyonTamamlandiMi = x.RoleId == 2 && x.SimulasyonTamamlandiMi,
                    CozumlemeTamamlandiMi = x.RoleId == 2 && x.CozumlemeTamamlandiMi,

                    ToplamPuan = x.RoleId == 2 ? x.ToplamPuan : null,

                    KvkkApproved = x.KvkkApproved,
                    OnamApproved = x.OnamApproved,
                    IlkGiris = x.IlkGiris
                });

            var pagedData = dtoQuery.ToPaginate(
                index: request.Page,
                size: request.Size,
                from:0
            );

            return new Result<IPaginate<UserListDto>>(true, pagedData);
        }
        public async Task<Result<UserListDto>> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetAsync(a => a.Id == id);

            if (user == null)
                return new Result<UserListDto>(false, "Kullanıcı bulunamadı.");

            var dto = new UserListDto
            {
                Id = user.Id,
                Phone = user.Phone,
                RoleId = user.RoleId,
                RoleName = user.Role?.Name,
                KvkkApproved = user.KvkkApproved,
                OnamApproved = user.OnamApproved,
                IlkGiris = user.IlkGiris
            };

            return new Result<UserListDto>(true, dto);
        }

        public async Task<Result<UserCreateDto>> CreateAsync(UserCreateDto dto)
        {
            var normalizedPhone = NormalizePhone(dto.Phone);

            if (!IsValidPhone(normalizedPhone))
                return new Result<UserCreateDto>(false, "Telefon numarası geçersiz. 5XXXXXXXXX formatında giriniz.");


            var existingUser = await _userRepository.GetAsync(a => a.Phone == normalizedPhone);

            if (existingUser != null)
                return new Result<UserCreateDto>(false, "Bu telefon numarası ile kayıtlı kullanıcı zaten var.");

            var user = new User
            {
                Phone = normalizedPhone,

                UserName = dto.UserName,

                Name = dto.Name,
                Surname = dto.Surname,

                OgrenciNo = dto.RoleId == 2
                    ? dto.OgrenciNo
                    : null,

                RoleId = dto.RoleId,


                ToplamPuan = 0,

                SimulasyonTamamlandiMi = false,
                CozumlemeTamamlandiMi = false,

                KvkkApproved = false,
                OnamApproved = false,
                IlkGiris = false,

                DeviceToken = null
            };
            if (dto.Password == dto.PasswordRepeat)
            {
                HashingHelper.CreatePasswordHash(dto.Password, out byte[] hash, out byte[] salt);
                user.PasswordHash = hash;
                user.PasswordSalt = salt;
            }

            await _userRepository.AddAsync(user);

            return new Result<UserCreateDto>(
                true,
                "Kullanıcı başarıyla oluşturuldu."
            );
        }
        public async Task<Result<UserUpdateDto>> UpdateAsync(UserUpdateDto dto)
        {
            var user = await _userRepository.GetAsync(x => x.Id == dto.Id);

            if (user == null)
                return new Result<UserUpdateDto>(
                    false,
                    "Kullanıcı bulunamadı."
                );

            var normalizedPhone = NormalizePhone(dto.Phone);

            if (!IsValidPhone(normalizedPhone))
                return new Result<UserUpdateDto>(
                    false,
                    "Telefon numarası geçersiz."
                );

            var phoneOwner = await _userRepository.GetAsync(x =>
                x.Phone == normalizedPhone &&
                x.Id != dto.Id);

            if (phoneOwner != null)
                return new Result<UserUpdateDto>(
                    false,
                    "Bu telefon numarası başka bir kullanıcı tarafından kullanılmaktadır."
                );

            user.Phone = normalizedPhone;

            user.UserName = dto.UserName;

            user.Name = dto.Name;
            user.Surname = dto.Surname;

            user.RoleId = dto.RoleId;

            if (dto.RoleId == 2)
            {
                user.OgrenciNo = dto.OgrenciNo;
            }
            else
            {
                user.OgrenciNo = null;
            }

            /*
             * AŞAĞIDAKİLER DOKUNULMUYOR
             *
             * ToplamPuan
             * SimulasyonTamamlandiMi
             * CozumlemeTamamlandiMi
             * DeviceToken
             * KvkkApproved
             * OnamApproved
             * IlkGiris
             * PasswordHash
             * PasswordSalt
             */

            await _userRepository.UpdateAsync(user);

            return new Result<UserUpdateDto>(
                true,
                "Kullanıcı güncellendi."
            );
        }

        public async Task<Result<UserModel>> DeleteAsync(int id)
        {
            var user = await _userRepository.GetAsync(a => a.Id == id);

            if (user == null)
                return new Result<UserModel>(false, "Kullanıcı bulunamadı.");

            await _userRepository.DeleteAsync(user);

            return new Result<UserModel>(true, "Kullanıcı silindi.");
        }

        public async Task<Result<UserPasswordResetDto>> ResetPasswordAsync(UserPasswordResetDto dto)
        {
            var user = await _userRepository.GetAsync(a => a.Id == dto.Id);

            if (user == null)
                return new Result<UserPasswordResetDto>(false, "Kullanıcı bulunamadı.");

            HashingHelper.CreatePasswordHash(dto.NewPassword, out byte[] hash, out byte[] salt);

            user.PasswordHash = hash;
            user.PasswordSalt = salt;

            await _userRepository.UpdateAsync(user);

            return new Result<UserPasswordResetDto>(true, "Şifre başarıyla sıfırlandı.");
        }

        private string NormalizePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return null;

            phone = new string(phone.Where(char.IsDigit).ToArray());

            if (phone.StartsWith("0"))
                phone = phone.Substring(1);

            if (!phone.StartsWith("90"))
                phone = "90" + phone;

            return phone;
        }
        private bool IsValidPhone(string phone)
        {
            return phone != null && phone.Length == 12 && phone.StartsWith("90");
        }




        public Result<UserModel> UpdateDetailed(UserModel model)
        {
            if (model == null)
                return new Result<UserModel>(false, "Model boş geldi.");

            if (model.Id <= 0)
                return new Result<UserModel>(false, "Kullanıcı id boş.");

            var existing = _userRepository.Get(w => w.Id == model.Id);
            if (existing == null)
                return new Result<UserModel>(false, "Kullanıcı bulunamadı.");

            // Sadece gönderilen alanları güncelle
            if (!string.IsNullOrWhiteSpace(model.Username))
                existing.UserName = model.Username.Trim();
            if (!string.IsNullOrWhiteSpace(model.Name))
                existing.Name = model.Name.Trim();
            if (!string.IsNullOrWhiteSpace(model.Surname))
                existing.Surname = model.Surname.Trim();

            if (!string.IsNullOrWhiteSpace(model.Phone))
                existing.Phone = model.Phone.Trim();


            if (!string.IsNullOrWhiteSpace(existing.Phone))
            {
                var userNameControl = _userRepository.Get(x => x.Phone == existing.Phone && x.Id != existing.Id);
                if (userNameControl != null)
                    return new Result<UserModel>(false, "Bu telefon numarası başka bir kullanıcıda kayıtlı.");
            }


            existing.UpdatedAt = DateTime.Now;

            var res = _userRepository.Update(existing);
            var resultModel = _mapper.Map<UserModel>(existing);
            return new Result<UserModel>(true, resultModel, "Güncellendi.");
        }
        public Result<UserModel> UpdatePasswordProfile(PasswordModel model)
        {
            Result<UserModel> result;
            User admin = _userRepository.Get(w => w.Id == model.Id);

            if (!string.IsNullOrWhiteSpace(model.OldPassword) && HashingHelper.VerifyPasswordHash(model.OldPassword, admin.PasswordHash, admin.PasswordSalt))
            {
                if (model.NewPassword != model.NewPasswordRepeat || model.NewPassword.Length < 5)
                {
                    return result = new Result<UserModel>(false, "Yeni Şifre İle Yeni Şifre Tekrarı Uyuşmalıdır ve Şifreniz Minimum 6 Harf Uzunluğunda Olmalıdır.");
                }
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(model.NewPassword, out passwordHash, out passwordSalt);
                admin.PasswordHash = passwordHash;
                admin.PasswordSalt = passwordSalt;
                admin.UpdatedAt = DateTime.Now;
                _userRepository.Update(admin);
                return result = new Result<UserModel>(true, null, "Şifreniz başarıyla güncellendi");
            }
            return result = new Result<UserModel>(false, Message: "Girmiş olduğunuz eski şifreniz şifreniz ile eşleşmemiştir", ResultType: ResultTypeEnum.Error);
        }

        public Result<List<UserModel>> GetAllHasta()
        {
            Result<List<UserModel>> result;

            List<User> users = _userRepository.GetAsList(x => x.RoleId == 3);
            if (users != null && users.Count > 0)
            {
                List<UserModel> usersModel = _mapper.Map<List<UserModel>>(users);
                result = new Result<List<UserModel>>(true, usersModel, "Kullanıcılar Getirildi.");
                return result;
            }
            result = new Result<List<UserModel>>(false, "Kullanıcı Bulunamadı.");
            return result;


        }
    }
}
