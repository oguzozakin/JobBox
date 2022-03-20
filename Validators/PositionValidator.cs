using FluentValidation;

public class PositionValidator : AbstractValidator<Position>
{
    public PositionValidator()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("Pozisyon adı boş bırakılamaz!");
        RuleFor(x => x.Name).MaximumLength(50).WithMessage("Pozisyon adı 50 karakterden uzun olamaz.");
        RuleFor(x => x.Name).MinimumLength(2).WithMessage("Pozisyon adı 2 karakterden kısa olamaz.");
    }
}