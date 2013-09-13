using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 响应基础信息
    /// 所有REST请求共用
    /// </summary>
    public class ClientResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_id")]
        public long RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
