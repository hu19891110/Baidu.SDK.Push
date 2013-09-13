using System;
using System.Configuration;
using Baidu.SDK.Push.Dto;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Service
{
    [TestFixture]
    public class AppIOSCertTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void InitIOSCertTest()
        {
            var request = new AppIOSCertInitRequest
                (
                "testCert",
                "test cert operate by unit test init",
                "releaseCertContent",
                "DevCertContent"
                );

            Console.WriteLine("InitAppIOSCert:" + request.Name);

            var client = new Client(_apiKey, _secretKey);
            var response = client.InitAppIOSCert(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void UpdateIOSCertTest()
        {
            var request = new AppIOSCertUpdateRequest
            {
                Description = "test cert operate by unit test update"
            };

            var client = new Client(_apiKey, _secretKey);
            var response = client.UpdateAppIOSCert(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void QueryIOSCertTest()
        {
            var request = new AppIOSCertQueryRequest();

            var client = new Client(_apiKey, _secretKey);
            var response = client.QueryAppIOSCert(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void DeleteIOSCertTest()
        {
            var request = new AppIOSCertDeleteRequest();

            var client = new Client(_apiKey, _secretKey);
            var response = client.DeleteAppIOSCert(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }
    }
}
