using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(180).When(c => c.ModelYear == 2016);
            RuleFor(c => c.Description).Must(StartWithA).WithMessage("Açıklama A harfi ile başlamalı!");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
