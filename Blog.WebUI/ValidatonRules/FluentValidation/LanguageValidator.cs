using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class LanguageValidator : AbstractValidator<Language>
    {
        public LanguageValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("Lütfen dil adını giriniz.");
            RuleFor(t => t.Culture).NotEmpty().WithMessage("Lütfen kültür kodunu giriniz.");
        }
    }
}
