using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// delete_msg 请求响应
    /// </summary>
    public class MessageDeleteResponse : ClientResponseBase
    {
        /// <summary>
        /// delete_msg 请求响应明细
        /// </summary>
        [JsonProperty("response_params")]
        public MessageDeleteResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// delete_msg 请求响应明细
    /// </summary>
    public class MessageDeleteResponseParam
    {
        /// <summary>
        /// 成功删除条数
        /// </summary>
        [JsonProperty("success_amount ")]
        public uint? SuccessAmount { get; set; }

        /// <summary>
        /// 删除消息列表
        /// </summary>
        [JsonProperty("messages")]
        public IList<MessageFetchResponseMessage> Messages { get; set; }
    }

    /// <summary>
    /// 删除消息详细信息
    /// </summary>
    public class MessageFetchResponseParamDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("msg_id ")]
        public uint? MessageID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result ")]
        public bool Result { get; set; }
    }

}
