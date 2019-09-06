using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(t => t.ListId).NotEmpty().WithMessage("Lütfen menü yerini seçiniz.");
        }
    }
}
