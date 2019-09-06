using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class ContentLanguageValidator : AbstractValidator<ContentLanguage>
    {
        public ContentLanguageValidator()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("Lütfen başlık giriniz.");
        }
    }
}
