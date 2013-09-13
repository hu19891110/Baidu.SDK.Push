using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// fetch_msg 请求响应 
    /// </summary>
    public class MessageFetchResponse : ClientResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_params")]
        public MessageFetchResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// fetch_msg 请求响应明细
    /// </summary>
    public class MessageFetchResponseParam
    {
        /// <summary>
        /// 系统返回的消息个数
        /// </summary>
        [JsonProperty("total_num")]
        public ulong? TotalNumber { get; set; }

        /// <summary>
        /// 消息列表
        /// </summary>
        [JsonProperty("messages")]
        public IList<MessageFetchResponseMessage> Messages { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MessageFetchResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel_id")]
        public ulong? ChannelID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("msg_id")]
        public ulong? MessageID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("msg_key")]
        public string MessageKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mssage_length")]
        public ulong? MssageLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message_type")]
        public MessageTypes MessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message_expires")]
        public DateTime MessageExpires { get; set; }
    }
}
