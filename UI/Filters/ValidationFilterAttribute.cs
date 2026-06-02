using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using FluentValidation;
using UI.Exceptions;

namespace UI.Filters
{
    public class ValidationFilterAttribute : TypeFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"> Kullanılacak Validator </param>
        /// <param name="returnType"> return Edilecek Obj tipi = { 0 ise json, 1 ise redirect result olacak} </param>
        public ValidationFilterAttribute(Type type, int returnType = 0) : base(typeof(ValidationFilter))
        {
            Arguments = new object[] { type, returnType };
        }


        private class ValidationFilter : IAsyncActionFilter
        {
            private Type _validatorType;
            private int _returnType;
            public ValidationFilter(Type validatorType, int returnType = 0)
            {
                if (!typeof(IValidator).IsAssignableFrom(validatorType))
                    throw new Exception("Doğru verileri girmelisiniz.");

                _validatorType = validatorType;
                _returnType = returnType;
            }
            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                var validator = (IValidator)Activator.CreateInstance(_validatorType);
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = context.ActionArguments.Values.Where(t => t.GetType() == entityType);
                foreach (var entity in entities)
                {
                    //var tmp_err = Validate(validator, entity);
                    var fluent_context = new ValidationContext<object>(entity);
                    var result = validator.Validate(fluent_context);
                    if (!result.IsValid)
                        throw new CustomValidationException(_returnType, "", result.Errors);
                }
                await next();
            }
        }
    }
}