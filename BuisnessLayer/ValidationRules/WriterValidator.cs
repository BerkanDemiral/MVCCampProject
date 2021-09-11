using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.NickName).NotEmpty().WithMessage("Nick name adı boş bırakılamaz");
            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Email boş bırakılamaz");
            RuleFor(x => x.NickName).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.WriterEmail).EmailAddress().WithMessage("Lütfen mail formatında giriniz");
            RuleFor(x => x.AboutWriter).MaximumLength(200).WithMessage("En fazla 200 karakter giriniz");
            RuleFor(x => x.AboutWriter).NotEmpty().WithMessage("En fazla 200 karakter giriniz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password alanı boş bırakılamaz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        }
    }
}
