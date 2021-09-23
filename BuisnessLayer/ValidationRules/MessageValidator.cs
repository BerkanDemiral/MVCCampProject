using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.RecieverMail).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            //RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            //RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");

            RuleFor(x => x.RecieverMail).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            //RuleFor(x => x.SenderMail).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            //RuleFor(x => x.MessageContent).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");


            RuleFor(x => x.RecieverMail).EmailAddress().WithMessage("Lütfen mail formatında giriniz");
            //RuleFor(x => x.SenderMail).EmailAddress().WithMessage("Lütfen mail formatında giriniz");
        }
    }
}
