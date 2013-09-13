using System.Configuration;
using Baidu.SDK.Push.Dto;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Service
{
    [TestFixture]
    public class BindTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void VerifyBindTest()
        {
            var request = new BindVerifyRequest("945124040446040348");
            //request.ChannelId = 3789323588078526627;

            var client = new Client(_apiKey, _secretKey);
            var response = client.VerifyBind(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
            //Assert.Greater(response.ResponseParams.Amount, 0);
        }

        [Test]
        public void QueryBindTest()
        {
            var request = new BindListQueryRequest();
            //request.ChannelId = 3789323588078526627;

            var client = new Client(_apiKey, _secretKey);
            var response = client.QueryBindList(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
            Assert.NotNull(response.ResponseParams);
            //Assert.Greater(response.ResponseParams.Amount, 0);
        }
    }
}
