using AccountTryCatch;
using AccountTryCatch.SuccessorsOfExceptions;

namespace Account_try_catch_
{
    public class Account
    {
        public Account()
        {

        }

        public static bool IsAccountDate(string login, string password, string confirmPassword)
        {
            try
            {
                if (login == null || password == null || confirmPassword == null)
                    throw new ArgumentNullException("Нулевая строка не принимается!");
                if (LineCorrectFormat(login) == false)
                    throw new WrongLoginException("Логин или Пароль имеют не правильный формат!");
                if (LineCorrectFormat(password) == false)
                    throw new WrongPasswordException("Логин или Пароль имеют не правильный формат!");
                if (password != confirmPassword)
                    throw new PasswordMatchException("Пароли не равны!");
                return true;

            }
            catch (ArgumentNullException error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
            catch (WrongLoginException error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
            catch (WrongPasswordException error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
            catch (PasswordMatchException error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
        }

        private static bool LineCorrectFormat(string line)
        {
            if (line.Length >= 20)
                return false;
            foreach (var element in line)
            {
                if (char.IsLetter(element) || char.IsNumber(element) || element == '_')
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
