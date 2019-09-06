using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.WebUI.ValidatonRules.FluentValidation
{
    public class BannerValidator : AbstractValidator<Banner>
    {
        public BannerValidator()
        {
            RuleFor(t => t.ListId).NotEmpty().WithMessage("Lütfen banner yeri seçiniz.");
        }
    }
}
