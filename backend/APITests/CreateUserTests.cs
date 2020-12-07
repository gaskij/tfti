using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;
using TFTI.Contracts;
using APITests.Extensions;
using FluentAssertions;
using System.Net.Http;
using Kalandear.Data;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace APITests
{
    [TestClass]
    public class CreateUserTests : TestBase
    {
        [TestMethod]
        [Fact(DisplayName = "Create user positive test" )]
        public async Task CreateUserPositiveTest()
        {

            // Create host
            NewUser user = new NewUser();
            user.email = "useremail@test.com";
            user.first_name = "first name";
            user.last_name = "last name";
            user.pass_hash = "hash";
            user.salt = "salt";
            user.phone_number = "(123) 456-7890";
            user.user_summary = "This is a new user for testing";

            // Call API endpoint with mock client
            HttpStatusCode statusCode = 
                await Client.PostAndReturnStatusCodeAsync(
                    CreateClientUrl,
                    user
                );

            // Ensure that the API returned the correct result
            statusCode.Should().Be(HttpStatusCode.OK);
        }

        [TestMethod]
        [Fact(DisplayName = "Create user negative test - invalid id" )]
        public async Task CreateUserNegativeTest()
        {
            Assert.Inconclusive();
            // Create host
            NewUser user = new NewUser();
            user.email = "useremail@test.com";
            user.first_name = "first name";
            user.last_name = "last name";
            user.pass_hash = "hash";
            user.salt = "salt";
            user.phone_number = "(123) 456-7890";
            user.user_summary = "This is a new user for testing";

            // Call API endpoint with mock client
            HttpStatusCode statusCode =
                await Client.PostAndReturnStatusCodeAsync(
                    CreateClientUrl,
                    user
                );

            // Ensure that the API returned the correct result
            statusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
