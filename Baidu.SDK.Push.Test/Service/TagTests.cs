using System;
using System.Configuration;
using Baidu.SDK.Push.Dto;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Service
{
    [TestFixture]
    public class TagTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void SetTagTest()
        {
            var request = new TagSetRequest
                (
                "TAG_TEST"
                );

            Console.WriteLine("Set Tag:" + request.Tag);

            var client = new Client(_apiKey, _secretKey);
            var response = client.SetTag(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void FetchTagTest()
        {
            var request = new TagFetchRequest();

            var client = new Client(_apiKey, _secretKey);
            var response = client.FetchTag(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
            Assert.NotNull(response.ResponseParams);
            Assert.Greater(response.ResponseParams.Amount, 0);
        }

        [Test]
        public void DeleteTagTest()
        {
            var requestSet = new TagSetRequest
                (
                "TAG_TEST_DELETE"
                );

            Console.WriteLine("Set Tag:" + requestSet.Tag);

            var clientSet = new Client(_apiKey, _secretKey);
            var responseSet = clientSet.SetTag(requestSet);

            Assert.NotNull(responseSet);
            Assert.Greater(responseSet.RequestId, 0);

            var request = new TagDeleteRequest
                (
                "TAG_TEST_DELETE"
                );

            Console.WriteLine("Set Tag:" + requestSet.Tag);

            var client = new Client(_apiKey, _secretKey);
            var response = client.DeleteTag(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void QueryUserTagsTest()
        {
            var request = new UserTagQueryRequest("945124040446040348");

            var client = new Client(_apiKey, _secretKey);
            var response = client.QueryUserTags(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }
    }
}
