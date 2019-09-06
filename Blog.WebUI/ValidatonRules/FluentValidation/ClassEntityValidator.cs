using Blog.Entities.Concrete;
using FluentValidation;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class ClassEntityValidator : AbstractValidator<ClassEntity>
    {
        public ClassEntityValidator()
        {
            RuleFor(t => t.Sort).NotEmpty();
        }
    }
}
