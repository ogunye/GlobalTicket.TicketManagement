using FluentValidation.Results;

namespace GlobalTicket.TicketManagement.Application.Exceptions
{
    public class ValidationException: Exception
    {
        public List<string> ValidationError {  get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            ValidationError = new List<String>();

            foreach(var validationError in validationResult.Errors)
            {
                ValidationError.Add(validationError.ErrorMessage);
            }
        }
    }
}
