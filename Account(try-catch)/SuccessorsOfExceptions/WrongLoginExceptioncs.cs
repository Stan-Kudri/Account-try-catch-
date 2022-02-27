namespace AccountTryCatch.SuccessorsOfExceptions
{
    public class WrongLoginExceptioncs : Exception
    {
        public WrongLoginExceptioncs()
        {

        }

        public WrongLoginExceptioncs(string message) : base(message)
        {

        }
    }
}
