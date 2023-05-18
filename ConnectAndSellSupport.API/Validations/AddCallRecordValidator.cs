using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Models.Payload.Call;
using FluentValidation;

namespace ConnectAndSellSupport.API.Validations
{
    public class AddCallRecordValidator : AbstractValidator<AddCallRecordPayload>
    {
        public AddCallRecordValidator()
        {
            RuleFor(x => x.TalktimeInSeconds)
                .NotNull().WithMessage(Messages.InvalidTalktime)
                .GreaterThanOrEqualTo(0).WithMessage(Messages.InvalidTalktime)
                .LessThanOrEqualTo(ValidationConstants.MaxTalktimeInSeconds).WithMessage(Messages.InvalidTalktime);

            RuleFor(x => x.DispositionId)
                .NotNull().WithMessage(Messages.InvalidDispositionId)
                .GreaterThan(0).WithMessage(Messages.InvalidDispositionId);
        }
    }
}
