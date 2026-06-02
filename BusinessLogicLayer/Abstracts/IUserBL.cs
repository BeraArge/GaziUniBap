using Core.ResultType;
using DataTransferObject.SmsModel;
using DataTransferObject.User;
using DataTransferObject.User.KullaniciIslemleri;
using DataTransferObject.User.Mobil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstracts
{
    public interface IUserBL
    {
        Result<UserModel> GetById(int id);
        Task<Result<List<UserListDto>>> GetAllAsync();
        Result<List<UserModel>> GetAllHasta();
        Task<Result<UserListDto>> GetByIdAsync(int id);
        Task<Result<UserCreateDto>> CreateAsync(UserCreateDto dto);
        Task<Result<UserUpdateDto>> UpdateAsync(UserUpdateDto dto);
        Task<Result<UserModel>> DeleteAsync(int id);
        Task<Result<UserPasswordResetDto>> ResetPasswordAsync(UserPasswordResetDto dto);





        Task<Result<bool>> UpdateProfileAsync(UpdateProfileDTO dto);
        Task<Result<bool>> UpdatePasswordAsync(UpdatePasswordDTO dto);



        //sms şifre sıfırlama
        Result<UserModel> GetByPhone(SendSmsModel model);
        Result<UserModel> UpdatePasswordForSms(string newPass, int userId);


        //profil
        Result<UserModel> UpdateDetailed(UserModel model);
        Result<UserModel> UpdatePasswordProfile(PasswordModel model);
    }
}
