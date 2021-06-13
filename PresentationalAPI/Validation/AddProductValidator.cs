using Application.Commands.ProductCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationalAPI.Validation
{
    public class AddProductValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .Length(8, 50);

            RuleFor(p => p.Image)
                .NotEmpty();

            RuleFor(p => p.Price)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(p => p.Amount)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(p => p.CategoryId)
                .NotEmpty()
                .InclusiveBetween(1, 5);

        }
    }
}