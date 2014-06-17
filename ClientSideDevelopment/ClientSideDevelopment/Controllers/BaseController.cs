namespace ClientSideDevelopment.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using ClientSideDevelopment.ActionResults;

    public class BaseController : Controller
    {
        [Obsolete("Do not use the standard Json helpers to return JSON data to the client, use JsonSuccess or JsonError instead.")]
        protected JsonResult Json<T>(T data)
        {
            throw new InvalidOperationException("Do not use the standard Json helpers to return JSON data to the client, use JsonSuccess or JsonError instead.");
        }

        [Obsolete("Do not use the standard Json helpers to return JSON data to the client, use JsonSuccess or JsonError instead.")]
        protected JsonResult Json<T>(T data, JsonRequestBehavior behavior)
        {
            throw new InvalidOperationException("Do not use the standard Json helpers to return JSON data to the client, use JsonSuccess or JsonError instead.");
        }

        protected StandardJsonResult JsonValidationError()
        {
            var result = new StandardJsonResult();
            foreach (var validationError in ModelState.Values.SelectMany(v => v.Errors))
            {
                result.AddError(validationError.ErrorMessage);
            }
            return result;
        }

        protected StandardJsonResult JsonError(string errorMessage)
        {
            var result = new StandardJsonResult();
            result.AddError(errorMessage);
            return result;
        }

        protected StandardJsonResult<TData> JsonSuccess<TData>(TData data, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
        {
            return new StandardJsonResult<TData> { Data = data, JsonRequestBehavior = behavior };
        }

        protected StandardJsonResult<object> JsonSuccess()
        {
            return this.JsonSuccess<object>(null);
        }
    }
}