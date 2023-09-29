using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CalibrationValidator : AbstractValidator<Calibration>
    {
        public CalibrationValidator()
        {
            RuleFor(c => c.ResultFactor).GreaterThanOrEqualTo(0).WithMessage("Result Factor değeri geçersiz");
        }
    }
}
