using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class Message
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region android特有字段，可选

        [JsonProperty("notification_builder_id")]
        public uint? NotificationBuilderID { get; set; }

        [JsonProperty("notification_basic_style")]
        public uint? NotificationBasicStyle { get; set; }

        [JsonProperty("open_type")]
        public uint? OpenType { get; set; }

        [JsonProperty("net_support")]
        public uint? NetSupport { get; set; }

        [JsonProperty("user_confirm")]
        public uint? UserConfirm { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("pkg_content")]
        public string PkgContent { get; set; }

        [JsonProperty("pkg_name")]
        public string PkgName { get; set; }

        [JsonProperty("pkg_version")]
        public string PkgVersion { get; set; }

        #endregion

        #region android自定义字段

        [JsonProperty("custom_content")]
        public Dictionary<string, string> CustomContent { get; set; }

        #endregion

        #region ios特有字段，可选
        [JsonProperty("aps")]
        public string Aps { get; set; }
        #endregion

        #region ios的自定义字段

        #endregion
    }
}
