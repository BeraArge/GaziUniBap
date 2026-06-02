using FluentValidation;
using FluentValidation.Results;

namespace UI.Exceptions
{
    public class CustomValidationException : ValidationException
    {
        public int IsRedirect { get; set; }

        public CustomValidationException(string message, List<ValidationFailure> errors) : base(message, errors) { }

        public CustomValidationException(int isRedirect = 0, string? message = null, List<ValidationFailure> errors = null) : base(message, errors)
        {
            IsRedirect = isRedirect;
        }
    }
}