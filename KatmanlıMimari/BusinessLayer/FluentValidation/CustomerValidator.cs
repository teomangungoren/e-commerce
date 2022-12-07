using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez!");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("Adres alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            
        }
    }
}
