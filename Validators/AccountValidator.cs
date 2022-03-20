using FluentValidation;

public class AccountValidator : AbstractValidator<AccountDTO>
{
    public AccountValidator()
    {
        RuleFor(x => x.Email).EmailAddress(FluentValidation.Validators.EmailValidationMode.Net4xRegex).WithMessage("Email formati hatalıdır");
        RuleFor(x => x.Password).NotNull().WithMessage("Şifre kurallara uygun bir şekilde oluşturulmalıdır.");

    }
}