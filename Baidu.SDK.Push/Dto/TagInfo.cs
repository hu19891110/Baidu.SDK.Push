using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// Tag 信息
    /// </summary>
    public class TagInfo
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("tid")]
        public uint? Tid { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 标签创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }
    }
}
