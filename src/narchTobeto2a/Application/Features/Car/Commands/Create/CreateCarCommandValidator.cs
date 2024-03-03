using FluentValidation;

namespace Application.Features.Cars.Commands.Create;
public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(c => c.CarState).NotEmpty().NotNull();
       
        RuleFor(c => c.Plate).NotNull().NotEmpty();
        RuleFor(c => c.Price)
           .GreaterThan(0)
           .WithMessage("Araç fiyatı 0'dan büyük olmalı.");

        //RuleFor(c => c.Color)
        //   .NotEmpty()
        //   .NotNull()
        //   .MaximumLength(15)
        //   .WithMessage("Araç rengi en fazla 15 karakter olmalı.");
    }
}