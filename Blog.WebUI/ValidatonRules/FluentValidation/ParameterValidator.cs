using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class ParameterValidator : AbstractValidator<Parameter>
    {
        public ParameterValidator()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("Lütfen parametre adını giriniz.");
            RuleFor(t => t.Value).NotEmpty().WithMessage("Lütfn parametre değerini giriniz.");
        }
    }
}
