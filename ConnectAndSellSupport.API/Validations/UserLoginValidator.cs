using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Models.Payload.User;
using FluentValidation;

namespace ConnectAndSellSupport.API.Validations
{
    public class UserLoginValidator : AbstractValidator<UserLoginPayload>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage(Messages.InvalidUserName);
            RuleFor(x => x.Password).NotEmpty().WithMessage(Messages.InvalidPassword);
        }
    }
}
