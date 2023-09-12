using _10_CustomModelBinder.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _10_CustomModelBinder.CustomBinders
{
    public class ProductCustomBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if(context.Metadata.ModelType == typeof(Product))
            {
                return new ProductCustomBinder();
            }

            return null;
        }
    }
}
