using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// fetch_tag 请求响应
    /// </summary>
    public class TagFetchResponse : ClientResponseBase
    {
        /// <summary>
        /// fetch_tag 请求响应
        /// </summary>
        [JsonProperty("response_params")]
        public FetchTagResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// fetch_tag 请求响应明细
    /// </summary>
    public class FetchTagResponseParam
    {
        /// <summary>
        /// 系统返回的消息总数
        /// </summary>
        [JsonProperty("total_num")]
        public uint? TotalNumber { get; set; }

        /// <summary>
        /// 本次查询绑定数量
        /// </summary>
        [JsonProperty("amount")]
        public uint? Amount { get; set; }

        /// <summary>
        /// 标签数组
        /// </summary>
        [JsonProperty("tags")]
        public IList<TagInfo> Tags { get; set; }
    }
}
