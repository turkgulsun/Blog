using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class BannerLanguageValidator : AbstractValidator<BannerLanguage>
    {
        public BannerLanguageValidator()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("Lütfen banner adını giriniz.");
        }
    }
}
