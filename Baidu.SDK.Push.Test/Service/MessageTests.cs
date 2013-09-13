using System;
using System.Collections.Generic;
using System.Configuration;
using Baidu.SDK.Push.Dto;
using NUnit.Framework;

namespace Baidu.SDK.Push.Test.Service
{
    [TestFixture]
    public class MessageTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

        [Test]
        public void PushMesssageBroadcastSingleTest()
        {
            var messageList = new List<string>
            {
                Guid.NewGuid().ToString()
            };
            var messageKeyList = new List<string>
            {
                Guid.NewGuid().ToString()
            };

            var request = new MessagePushBroadcastRequest(
                DeviceTypes.Android,
                MessageTypes.Message,
                messageList,
                messageKeyList
                );

            Console.WriteLine("Push Message:" + request.Messages);

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.PushMessageBroadcast(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void PushMesssageBroadcastMultiTest()
        {
            var messageList = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
            };
            var messageKeyList = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
            };

            var request = new MessagePushBroadcastRequest(
                DeviceTypes.Android,
                MessageTypes.Message,
                messageList,
                messageKeyList
                );

            Console.WriteLine("Push Message:" + request.Messages);

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.PushMessageBroadcast(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void PushMesssageTagSingleTest()
        {
            var messageList = new List<string>
            {
                Guid.NewGuid().ToString()
            };
            var messageKeyList = new List<string>
            {
                Guid.NewGuid().ToString()
            };

            var request = new MessagePushTagRequest(
                DeviceTypes.Android,
                "TAG_TEST",
                MessageTypes.Message,
                messageList,
                messageKeyList
                );

            Console.WriteLine("Push Message:" + request.Messages);

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.PushMessageTag(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void PushMesssageTagMultiTest()
        {
            var messageList = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
            };
            var messageKeyList = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
            };

            var request = new MessagePushTagRequest(
                DeviceTypes.Android,
                 "TAG_TEST",
                MessageTypes.Message,
                messageList,
                messageKeyList
                );

            Console.WriteLine("Push Message:" + request.Messages);

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.PushMessageTag(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void PushMesssageUnicastSingleTest()
        {
            var messageList = new List<string>
            {
                Guid.NewGuid().ToString()
            };
            var messageKeyList = new List<string>
            {
                Guid.NewGuid().ToString()
            };

            var request = new MessagePushUnicastRequest(
                DeviceTypes.Android,
                3789323588078526627,
                "945124040446040348",
                MessageTypes.Message,
                messageList,
                messageKeyList
                );

            Console.WriteLine("Push Message:" + request.Messages);

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.PushMessageUnicast(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void PushMesssageUnicastMultiTest()
        {
            var messageList = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
            };
            var messageKeyList = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
            };

            var request = new MessagePushUnicastRequest(
                DeviceTypes.Android,
                3789323588078526627,
                "945124040446040348",
                MessageTypes.Message,
                messageList,
                messageKeyList
                );

            Console.WriteLine("Push Message:" + request.Messages);

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.PushMessageUnicast(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void FetchMesssageTest()
        {
            var request = new MessageFetchRequest("945124040446040348");
            request.ChannelId = 3789323588078526627;

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.FetchMessage(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }

        [Test]
        public void FetchMesssageCountTest()
        {
            var request = new MessageCountFetchRequest("945124040446040348");
            request.ChannelId = 3789323588078526627;

            var pushService = new Client(_apiKey, _secretKey);
            var response = pushService.FetchMessageCount(request);

            Assert.NotNull(response);
            Assert.Greater(response.RequestId, 0);
        }
    }
}
