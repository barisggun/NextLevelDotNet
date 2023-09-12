using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace _09_CustomModelBinder.CustomBinder
{
    public class HeisenbergDateTimeBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
          //IQueryCollection queryStrings =   bindingContext.HttpContext.Request.Query;

          //  bool result = int.TryParse(queryStrings["year"], out int year);
          //  if(!result)
          //  {
          //      bindingContext.Result = ModelBindingResult.Failed();
          //      return Task.CompletedTask;
          //  }

          //  result = int.TryParse(queryStrings["month"], out int month);
          //  if (!result)
          //  {
          //      bindingContext.Result = ModelBindingResult.Failed();
          //      return Task.CompletedTask;
          //  }

          //  result = int.TryParse(queryStrings["day"], out int day);
          //  if (!result)
          //  {
          //      bindingContext.Result = ModelBindingResult.Failed();
          //      return Task.CompletedTask;
          //  }

          //  DateTime date = new DateTime(year, month, day);

          //  bindingContext.Result = ModelBindingResult.Success(date);
          //  return Task.CompletedTask;

            int year = int.Parse(bindingContext.HttpContext.Request.Query["year"]);
            int month = int.Parse(bindingContext.HttpContext.Request.Query["month"]);

            HttpRequest request = bindingContext.HttpContext.Request;
            request.EnableBuffering();
            byte[] buffer = new byte[(int)request.ContentLength];
            request.Body.ReadAsync(buffer,0,buffer.Length);
            string dayStr = Encoding.UTF8.GetString(buffer);
            int day = int.Parse(dayStr);

            DateTime dateTime = new DateTime(year, month, day);
            bindingContext.Result = ModelBindingResult.Success(dateTime);

            return Task.CompletedTask;
        }
    }
}
