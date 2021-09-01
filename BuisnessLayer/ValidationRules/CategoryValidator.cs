using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("En fazla 25 karakter giriniz");
            RuleFor(x => x.CategoryDetail).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");

            
        }
    }
}
