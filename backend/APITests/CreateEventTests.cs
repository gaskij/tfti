using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;
using TFTI.Contracts;
using APITests.Extensions;
using FluentAssertions;
using System;
using Xunit;

namespace APITests
{
    [TestClass]
    public class CreateEventTests : TestBase
    {
        [TestMethod]
        [Fact(DisplayName = "Create event positive test")]
        public async Task CreateEventPositiveTest()
        {
            // Create event
            Event TFTIevent = new Event();
            TFTIevent.addtional_links = "https://test.com";
            TFTIevent.event_date = DateTime.Now;
            TFTIevent.event_name = "TFTI event name";
            TFTIevent.event_summary = "The summary of the event";
            TFTIevent.host_id = 1;
            TFTIevent.is_private = true;
            TFTIevent.location = "1 Main street, New York, New York";


            // Call API endpoint with mock client
            HttpStatusCode statusCode =
                await Client.PostAndReturnStatusCodeAsync(
                    CreateEventUrl,
                    TFTIevent
                );

            // Ensure that the API returned the correct result
            statusCode.Should().Be(HttpStatusCode.OK);
        }

        [TestMethod]
        [Fact(DisplayName = "Create event negative test - invalid host id")]
        public async Task CreateUserNegativeTest()
        {
            // Create event
            Event TFTIevent = new Event();
            TFTIevent.addtional_links = "https://test.com";
            TFTIevent.event_date = DateTime.Now;
            TFTIevent.event_name = "TFTI event name";
            TFTIevent.event_summary = "The summary of the event";
            TFTIevent.host_id = -1;
            TFTIevent.is_private = true;
            TFTIevent.location = "1 Main street, New York, New York";


            // Call API endpoint with mock client
            HttpStatusCode statusCode =
                await Client.PostAndReturnStatusCodeAsync(
                    CreateEventUrl,
                    TFTIevent
                );

            // Ensure that the API returned the correct result
            statusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
