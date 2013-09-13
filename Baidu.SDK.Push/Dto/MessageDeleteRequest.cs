using System;
using System.Collections.Generic;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// delete_msg 请求参数
    /// </summary>
    public class MessageDeleteRequest : ClientRequestBase
    {
        /// <summary>
        /// delete_msg 请求参数
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="messageIds"></param>
        public MessageDeleteRequest(
            string userId,
            IList<string> messageIds)
        {
            Method = Methods.delete_msg;

            UserId = userId;
            MessageIds = messageIds;

            Timestamp = DateTime.Now;
        }

        /// <summary>
        /// 如果查询的绑定关系与channel_id无关，则{channel_id}部分直接填写channel即可
        /// </summary>
        public override string ServiceUrl
        {
            get
            {
                return ChannelId.HasValue ? base.ServiceUrl + ChannelId.ToString() : base.ServiceUrl + "channel";
            }
        }

        /// <summary>
        /// 查询的绑定关系相关channel_id
        /// </summary>
        public ulong? ChannelId { get; set; }

        /// <summary>
        /// 用户标识。不超过256字节
        /// </summary>
        [RequestKeyAttribute("user_id", true)]
        public string UserId { get; set; }

        /// <summary>
        /// 删除的消息id列表，由一个或多个msg_id组成，多个用json数组表示。如：123 或 [123, 456]
        /// </summary>
        [RequestKeyAttribute("msg_ids", true)]
        public IList<string> MessageIds { get; set; }
    }
}
