using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Models.Payload.Call;
using FluentValidation;

namespace ConnectAndSellSupport.API.Validations
{
    public class UpdateCallRecordValidator : AbstractValidator<UpdateCallRecordPayload>
    {
        public UpdateCallRecordValidator()
        {
            RuleFor(x => x.TalktimeInSeconds)
                .GreaterThanOrEqualTo(0).WithMessage(Messages.InvalidTalktime)
                .LessThanOrEqualTo(ValidationConstants.MaxTalktimeInSeconds).WithMessage(Messages.InvalidTalktime);

            RuleFor(x => x.DispositionId)
                .GreaterThan(0).WithMessage(Messages.InvalidDispositionId);
        }
    }
}
