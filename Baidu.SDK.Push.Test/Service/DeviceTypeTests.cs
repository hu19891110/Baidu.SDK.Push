using System.Configuration;
using Baidu.SDK.Push.Dto;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Service
{
    [TestFixture]
    public class DeviceTypeTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void QueryDeviceTypeTest()
        {
            var request = new DeviceTypeQueryRequest(3789323588078526627);

            var client = new Client(_apiKey, _secretKey);
            var response = client.QueryDeviceType(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }
    }
}
