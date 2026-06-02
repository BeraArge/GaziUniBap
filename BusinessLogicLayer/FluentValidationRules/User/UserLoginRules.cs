using DataTransferObject.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.FluentValidationRules.User
{
    public class UserLoginRules : AbstractValidator<UserLoginDTO>
    {
        public UserLoginRules()
        {
            RuleFor(p => p.Phone)
                .NotNull().WithMessage("Telefon numarası alanı boş bırakılamaz")
                .NotEmpty().WithMessage("Telefon numarası alanı boş bırakılamaz")
                .MaximumLength(100).WithMessage("Telefon numarası veya şifre yanlış.");
            RuleFor(p => p.Password)
               .NotNull().WithMessage("Parola alanı boş bırakılamaz.")
               .NotEmpty().WithMessage("Parola alanı boş bırakılamaz")
               .MaximumLength(50).WithMessage("Kullanıcı adı veya şifre yanlış.");


        }
    }
}
