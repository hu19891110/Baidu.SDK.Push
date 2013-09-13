using System;
using System.Configuration;
using Baidu.SDK.Push.Dto;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Service
{
    [TestFixture]
    public class ClientRequestBaseTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];

        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void GeneratePostData_Base_Test()
        {
            var dto = new ClientRequestBase
            {
                Method = Methods.delete_tag,
                Expires = DateTime.Now,
                Timestamp = DateTime.Now,
                Version = 1
            };

            string data = dto.GeneratePostData(_apiKey, _secretKey);

            Assert.IsNotNullOrEmpty(data);
        }

        [Test]
        public void GeneratePostData_Base_NullProperty_Test()
        {
            var dto = new ClientRequestBase { Method = null };

            Assert.Throws<ArgumentNullException>(() => dto.GeneratePostData(_apiKey, _secretKey));
        }
    }
}
