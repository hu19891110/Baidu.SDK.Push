using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_user_tags 响应
    /// </summary>
    public class UserTagQueryResponse : ClientResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_params")]
        public UserTagQueryResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// query_user_tags 响应明细
    /// </summary>
    public class UserTagQueryResponseParam
    {
        /// <summary>
        /// Tag总数
        /// </summary>
        [JsonProperty("tag_num")]
        public uint? TagNumber { get; set; }

        /// <summary>
        /// Tag列表
        /// </summary>
        [JsonProperty("tags")]
        public IList<TagInfo> Tags { get; set; }
    }
}
