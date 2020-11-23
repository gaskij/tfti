using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFTI.Contracts;
using Xunit;

namespace APITests
{
    [TestClass]
    public class HostTests
    {
        [TestMethod]
        [InlineData(1)]
        public void RetrieveHostValidTest(int hostId)
        {
            Assert.Inconclusive();

            // Create host
            User host = new User();
            host.Id = hostId;

            // Mock Database connection
        }
    }
}
