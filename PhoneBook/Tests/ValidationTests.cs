using FluentAssertions;
using PhoneBook;
using PhoneBook.AddContact.User;
using PhoneBook.ContactHandler.Inputs;
using Xunit;

namespace Tests
{
    public class ValidationTests
    {
        [Fact]
        public void ValidateCorrectEmailSuccessfully()
        {
            var email = "example@gmail.com";
            var result = email.isEmail();

            var expected = true;

            expected.Should().Be(result);
        }

        [Fact]
        public void ValidateWrongEmailSuccessfully()
        {
            var email = "emample.com";
            var result = email.isEmail();

            var expected = false;

            expected.Should().Be(result);
        }

        [Fact]
        public void ValidateCorrectNationalCodeSuccessfully()
        {
            //replcae your own national code if you wish:
            var nationalCode = "2283888888";
            var result = MelliLogic.ValidateMelliCode(nationalCode);

            var expected = true;

            expected.Should().Be(result);
        }

        [Fact]
        public void ValidateWrongNationalCodeSuccessfully()
        {
            //replcae your own national code if you wish:
            var nationalCode = "2283876422";
            var result = MelliLogic.ValidateMelliCode(nationalCode);

            var expected = false;

            expected.Should().Be(result);
        }

        [Fact]
        public void GenerateFileNameSuccessfully()
        {
            var user = new User
            {
                NationalCode = "2283888888"
            };

            var fileName = user.GenerateAddress();

            var expected = "2283888888.json";

            expected.Should().BeEquivalentTo(fileName);
        }

        [Fact]
        public void ValidateCorrectPhoneNumberWithCountryCodeSuccessfully()
        {
            var mobileNumber = "+989397136888";
            var result = PhoneValidation.CheckPhoneNumber(mobileNumber);

            var expected = true;

            expected.Should().Be(result);
        }

        [Fact]
        public void ValidateCorrectPhoneNumberWithZeroSccessfully()
        {
            var mobileNumber = "09397136888";
            var result = PhoneValidation.CheckPhoneNumber(mobileNumber);

            var expected = true;

            expected.Should().Be(result);
        }

        [Fact]
        public void ValidateWrongPhoneNumberWithWrongLenghtSuccessfully()
        {
            var mobileNumber = "09397136888123";
            var result = PhoneValidation.CheckPhoneNumber(mobileNumber);

            var expected = false;

            expected.Should().Be(result);
        }
    }
}