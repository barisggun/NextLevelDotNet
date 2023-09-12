using _10_CustomModelBinder.CustomBinders;
using Microsoft.AspNetCore.Mvc;

namespace _10_CustomModelBinder.Models
{
    [ModelBinder(typeof(ProductCustomBinder),Name =nameof(ProductID))]  
    //ID üzerinden özelleştirme yaptığımız için Name property'sine değer atadık. Böyle olmasaydı DateTime'daki gibi yapabilridik.
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
