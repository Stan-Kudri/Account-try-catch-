using AccountTryCatch;
using Xunit;

namespace TestProject
{
    public class AccountDetalsTest
    {
        [Theory]
        [InlineData("dima", "123456789")]
        [InlineData("sergey", "987456321")]
        [InlineData("stan_k_u_d_r_i", "1_2_3_4_5_6_7_8_9")]
        public void Entering_the_correct_password_and_login(string login, string password)
        {
            var account = Account.IsValidAccountDate(login, password, password);
            Assert.True(account);
        }

        [Theory]
        [InlineData("dima", null, "123456789")]
        [InlineData("dima", "123456789", "123")]
        [InlineData("dima", "123456789----", "123456789----")]
        [InlineData("sergeyddddddddddddddddddddddddddddddddddddd", "987456321", "987456321")]
        public void Failed_the_correct_password_or_login(string login, string password, string confirmPassword)
        {
            var account = Account.IsValidAccountDate(login, password, confirmPassword);
            Assert.False(account);
        }
    }
}