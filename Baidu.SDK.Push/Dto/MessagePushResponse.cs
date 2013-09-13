using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// push_msg 请求响应
    /// Broadcast/tag/Unicast共用
    /// </summary>
    public class MessagePushResponse : ClientResponseBase
    {
        /// <summary>
        /// 响应明细
        /// </summary>
        [JsonProperty("response_params")]
        public PushMessageResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class PushMessageResponseParam
    {
        /// <summary>
        /// push_msg 请求响应明细
        /// </summary>
        [JsonProperty("success_amount")]
        public long SuccessAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel_token")]
        public string ChannelToken { get; set; }
    }
}
