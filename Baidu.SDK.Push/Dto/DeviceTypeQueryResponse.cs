using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_user_tags 响应
    /// </summary>
    public class DeviceTypeQueryResponse : ClientResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_params")]
        public DeviceTypeQueryResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceTypeQueryResponseParam
    {
        /// <summary>
        /// 设备类型，取值范围为：1～5
        /// 云推送支持多种设备，各种设备的类型编号如下：
        /// 1：浏览器设备；
        /// 2：PC设备；
        /// 3：Andriod设备；
        /// 4：iOS设备；
        /// 5：Windows Phone设备；
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceTypes? DeviceType { get; set; }
    }
}
