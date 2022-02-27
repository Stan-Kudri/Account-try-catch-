namespace AccountTryCatch.SuccessorsOfExceptions
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException()
        {

        }

        public WrongPasswordException(string message) : base(message)
        {

        }
    }
}
