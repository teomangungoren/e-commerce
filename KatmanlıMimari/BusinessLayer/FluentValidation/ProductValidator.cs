using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Ürün stok adeti boş geçilemez!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez!");
           
        }
    }
}
