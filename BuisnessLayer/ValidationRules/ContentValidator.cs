using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class ContentValidator : AbstractValidator<Content>
    {
        public ContentValidator()
        {
            RuleFor(x => x.ContentValue).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.HeadingId).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.WriterId).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");

        }
    }
}
