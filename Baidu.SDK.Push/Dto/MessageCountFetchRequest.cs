using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// fetch_msgcount 请求参数
    /// </summary>
    public class MessageCountFetchRequest : ClientRequestBase
    {
        /// <summary>
        /// 设置 fetch_msgcount 请求参数
        /// </summary>
        /// <param name="userId"></param>
        public MessageCountFetchRequest(string userId)
        {
            Method = Methods.fetch_msgcount;

            UserId = userId;

            Timestamp = DateTime.Now;
        }

        /// <summary>
        /// 如果查询的绑定关系与channel_id无关，则{channel_id}部分直接填写channel即可
        /// </summary>
        public override string ServiceUrl
        {
            get
            {
                return ChannelId.HasValue ? base.ServiceUrl + ChannelId : base.ServiceUrl + "channel";
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
    }
}
