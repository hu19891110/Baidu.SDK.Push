using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_app_ioscert 请求响应
    /// </summary>
    public class AppIOSCertQueryResponse : ClientResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_params")]
        public AppIOSCertQueryResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// query_app_ioscert 证书明细
    /// </summary>
    public class AppIOSCertQueryResponseParam
    {
        /// <summary>
        /// 证书名称，最长128字节
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证书描述，最长256字节
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 正式版证书内容
        /// </summary>
        [JsonProperty("release_cert ")]
        public string ReleaseCert { get; set; }

        /// <summary>
        /// 开发版证书内容
        /// </summary>
        [JsonProperty("dev_cert ")]
        public string DevCert { get; set; }
    }
}
