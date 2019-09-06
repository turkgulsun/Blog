using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class MenuLanguageValidator : AbstractValidator<MenuLanguage>
    {
        public MenuLanguageValidator()
        {
            RuleFor(t => t.Menu).NotEmpty().WithMessage("Lütfen menü adını giriniz.");
        }
    }
}
