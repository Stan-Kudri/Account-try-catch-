using AccountTryCatch;
using Xunit;

namespace TestProject
{
    public class AccountDetalsTest
    {
        [Theory]
        [InlineData("dima", "123456789")]
        [InlineData("sergey", "987456321")]
        public void Entering_the_correct_password_and_login(string login, string password)
        {
            var numberAccount = new Account(login, password, password);
            Assert.True(numberAccount.CorrectAccount);
        }

        [Theory]
        [InlineData("dima", null, "123456789")]
        [InlineData("dima", "123456789", "123")]
        [InlineData("dima", "123456789----", "123456789----")]
        [InlineData("sergeyddddddddddddddddddddddddddddddddddddd", "987456321", "987456321")]
        public void Failed_the_correct_password_or_login(string login, string password, string confirmPassword)
        {
            var numberAccount = new Account(login, password, confirmPassword);
            Assert.False(numberAccount.CorrectAccount);
        }
    }
}