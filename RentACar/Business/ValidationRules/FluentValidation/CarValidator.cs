using Entities.Concrete;
using FluentValidation;
using System.Collections.Generic;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(1500).When(c => c.BrandId == 1);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
        }
    }
}