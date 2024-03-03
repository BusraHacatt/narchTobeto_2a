using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Transmissions.Commands.Create;
public class CreateTransmissionValidator : AbstractValidator<CreateTransmissionCommand>
{

    public CreateTransmissionValidator()
    {
        RuleFor(t => t.Name).NotEmpty().NotNull();
                    
    } 


}