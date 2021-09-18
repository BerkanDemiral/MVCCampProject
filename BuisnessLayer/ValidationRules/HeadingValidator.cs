using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.HeadingName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.HeadingDate).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.WriterId).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");


             

        }
    }
}
