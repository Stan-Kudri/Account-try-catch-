namespace AccountTryCatch.SuccessorsOfExceptions
{
    public class PasswordMatchException : Exception
    {
        public PasswordMatchException()
        {

        }

        public PasswordMatchException(string message) : base(message)
        {

        }
    }
}
