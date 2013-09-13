using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// fetch_msgcount 请求响应
    /// </summary>
    public class MessageCountFetchResponse : ClientResponseBase
    {
        /// <summary>
        /// fetch_msgcount 请求响应明细
        /// </summary>
        [JsonProperty("response_params")]
        public MessageCountFetchResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// fetch_msgcount 请求响应明细
    /// </summary>
    public class MessageCountFetchResponseParam
    {
        /// <summary>
        /// 系统返回的消息总数
        /// </summary>
        [JsonProperty("total_num")]
        public uint? TotalNumber { get; set; }
    }
}
