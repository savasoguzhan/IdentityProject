using FluentValidation;
using IdentityProject.DTO.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProject.BusinessLayer.Validation.AppUserValidation
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Can Not Empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname can not empy");
            RuleFor(x => x.Username).NotEmpty().WithMessage("username can not empy");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname can not empy");

            RuleFor(x=>x.ConfirmPassword).Equal(x =>x.Password).WithMessage("Password");

            RuleFor(x => x.Email).EmailAddress().WithMessage("not valid email adress");


        }
    }
}
