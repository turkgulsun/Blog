using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class ClassLanguageValidator : AbstractValidator<ClassLanguage>
    {
        public ClassLanguageValidator()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("Lütfen sınıf adını giriniz.");
        }
    }
}
