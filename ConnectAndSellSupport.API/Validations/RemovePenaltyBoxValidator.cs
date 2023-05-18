using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Models.Payload.PenaltyBox;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using FluentValidation;

namespace ConnectAndSellSupport.API.Validations
{
    public class RemovePenaltyBoxValidator : AbstractValidator<RemovePenaltyBoxEntityPayload>
    {
        public RemovePenaltyBoxValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(x => x.FromDate)
                .NotEmpty().WithMessage(Messages.InvalidFromDate)
                .LessThanOrEqualTo(x => TimeZoneHelper.GetPstTime()).WithMessage(Messages.FromDateLessThanCurrentDate);

            RuleFor(x => x.ToDate)
                .NotNull().WithMessage(Messages.InvalidToDate)
                .GreaterThanOrEqualTo(x => x.FromDate).WithMessage(Messages.ToDateLessThanFromDate)
                .LessThanOrEqualTo(x=>TimeZoneHelper.GetPstTime()).WithMessage(Messages.ToDateLessThanCurrentDate);

            RuleFor(x => x)
                .Must(IsValidDateRange).WithMessage(string.Format(Messages.InvalidDateRange, ValidationConstants.MaxDateRangeInDays));
        }

        private bool IsValidDateRange(RemovePenaltyBoxEntityPayload context)
        {
            return context.FromDate.AddDays(ValidationConstants.MaxDateRangeInDays) >= context.ToDate;
        }
    }
}
