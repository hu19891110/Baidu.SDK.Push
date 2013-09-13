using System.Collections.Generic;
using System.Configuration;
using Baidu.SDK.Push.Didest;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Digest
{
    [TestFixture]
    public class SignatureDigestTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void DigestTest()
        {
            const string httpMethod = "POST";
            const string url = "http://channel.api.duapp.com/rest/2.0/channel/channel";

            var paramDic = new Dictionary<string, string>
            {
                {"device_type", "3"},
                {"messages", "{\"title\":\"123\",\"description\":\"123abc\"}"},
                {"msg_keys", "channel_msg_key"},
                {"method", "push_msg"},
                {"timestamp", "1376050316"},
                {"push_type", "3"},
                {"message_type", "0"}
            };

            string sign = SignatureDigest.Digest(httpMethod, url, paramDic, _apiKey, _secretKey);

            Assert.NotNull(sign);
            //Assert.AreEqual("0313347b73fcbe71bf6f48e4154dac9f", sign);
        }

        [Test]
        public void DigestWithApiKeyTest()
        {
            const string httpMethod = "POST";
            const string url = "http://channel.api.duapp.com/rest/2.0/channel/channel";
            var paramDic = new Dictionary<string, string>
            {
                {"device_type", "3"},
                {"messages", "{\"title\":\"123\",\"description\":\"123abc\"}"},
                {"msg_keys", "channel_msg_key"},
                {"method", "push_msg"},
                {"timestamp", "1376050316"},
                {"push_type", "3"},
                {"message_type", "0"},
                {"apikey", "Q7rF8EqTV03w4W1fM8gdF0pn"}
            };
            
            string sign = SignatureDigest.Digest(httpMethod, url, paramDic, _apiKey, _secretKey);

            Assert.NotNull(sign);
            //Assert.AreEqual("0313347b73fcbe71bf6f48e4154dac9f", sign);
        }
    }
}
