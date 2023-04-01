namespace ProductApp.Application.Exceptions
{
    internal class ValidationException : Exception
    {
        public ValidationException() : base("Validation error occured")
        {

        }

        public ValidationException(string message) : base(message)
        {

        }

        public ValidationException(Exception ex) : this(ex.Message)
        {

        }
    }
}
