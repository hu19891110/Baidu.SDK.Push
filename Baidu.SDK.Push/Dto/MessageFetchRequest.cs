using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// fetch_msg 请求参数
    /// </summary>
    public class MessageFetchRequest : ClientRequestBase
    {
        /// <summary>
        /// fetch_msg 请求参数
        /// </summary>
        /// <param name="userId"></param>
        public MessageFetchRequest(string userId)
        {
            Method = Methods.fetch_msg;

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
                return ChannelId.HasValue ? base.ServiceUrl + ChannelId.ToString() : base.ServiceUrl + "channel";
            }
        }

        /// <summary>
        /// 查询的绑定关系相关channel_id
        /// </summary>
        public ulong? ChannelId { get; set; }

        /// <summary>
        /// 用户标识，不超过256字节
        /// </summary>
        [RequestKeyAttribute("user_id", true)]
        public string UserId { get; set; }

        /// <summary>
        /// 查询页码，默认为0。 
        /// </summary>
        [RequestKeyAttribute("start", false)]
        public uint? Start { get; set; }

        /// <summary>
        /// 一次查询条数，默认为10
        /// </summary>
        [RequestKeyAttribute("limit", false)]
        public uint? Limit { get; set; }
    }
}
