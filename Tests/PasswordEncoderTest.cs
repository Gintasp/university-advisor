using Advisor.Service.Auth;
using Xunit;

namespace Advisor.Tests
{
    public class PasswordEncoderTest
    {
        [Fact]
        public void EncodeReturnsValidHashTest()
        {
            PasswordEncoder encoder = new PasswordEncoder();
            var hash = encoder.Encode("password");

            Assert.IsType<string>(hash);
            Assert.Contains("$HASH$V1$", hash);
            Assert.Contains("$HASH$V1$10000$", hash);
            Assert.DoesNotContain("password", hash);
        }

        [Fact]
        public void EncodeReturnsHashWithGivenIterationCount()
        {
            PasswordEncoder encoder = new PasswordEncoder();
            var hash100 = encoder.Encode("password", 100);
            var hash6969 = encoder.Encode("password", 6969);

            Assert.Contains("$HASH$V1$100$", hash100);
            Assert.Contains("$HASH$V1$6969$", hash6969);

            Assert.DoesNotContain("$HASH$V1$6969$", hash100);
            Assert.DoesNotContain("$HASH$V1$100$", hash6969);
        }

        [Fact]
        public void VerifyTest()
        {
            PasswordEncoder encoder = new PasswordEncoder();
            string pass = "password";
            string wrongPass = "fewefw";
            var hash = encoder.Encode(pass);

            Assert.True(encoder.Verify(pass, hash));
            Assert.False(encoder.Verify(wrongPass, hash));
        }
    }
}
