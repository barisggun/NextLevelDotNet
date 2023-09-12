using _10_CustomModelBinder.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _10_CustomModelBinder.CustomBinders
{
    public class ProductCustomBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string modelName = bindingContext.ModelName;
            ValueProviderResult result = bindingContext.ValueProvider.GetValue(modelName);

            if (result == ValueProviderResult.None)
            {
                bindingContext.ModelState.AddModelError(modelName, "Hatalı değer");
            }

            int productID = int.Parse(result.FirstValue);

            Product product = new Product()
            {
                ProductID = productID,
                Name = "Laptop",
                Price = 2000
            };

            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}
