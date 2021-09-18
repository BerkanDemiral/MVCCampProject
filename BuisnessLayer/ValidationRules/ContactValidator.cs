using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.UserMail).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.Message).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.UserMail).EmailAddress().WithMessage("Lütfen mail formatında giriniz");
        }
    }
}
