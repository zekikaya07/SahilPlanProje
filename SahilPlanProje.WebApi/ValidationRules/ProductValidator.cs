using FluentValidation;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.ValidationRules
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.product_name).NotEmpty().WithMessage("Ürün adını boş geçmeyin.");
            RuleFor(x => x.product_name).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapın.");
            RuleFor(x => x.product_name).MaximumLength(200).WithMessage("En fazla 200 karakter veri girişi yapın.");

        }
    }
}
