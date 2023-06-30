using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
	public class ProductValidator:AbstractValidator<Product>
	{
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2,50);
            RuleFor(p => p.UnitInStock).NotEmpty();
            RuleFor(p => p.UnitInStock).GreaterThan(0);
            RuleFor(p => p.UnitInPrice).GreaterThan(0);
            RuleFor(p => p.UnitInPrice).NotEmpty();
        }
    }
}
