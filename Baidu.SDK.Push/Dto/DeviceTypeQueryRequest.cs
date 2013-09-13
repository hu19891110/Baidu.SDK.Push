using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_device_type 请求参数
    /// </summary>
    public class DeviceTypeQueryRequest : ClientRequestBase
    {
        /// <summary>
        /// query_device_type 请求参数
        /// </summary>
        public DeviceTypeQueryRequest(ulong channelId)
        {
            Method = Methods.query_device_type;

            ChannelId = channelId;

            Timestamp = DateTime.Now;
        }

        /// <summary>
        /// 如果查询的绑定关系与channel_id无关，则{channel_id}部分直接填写channel即可
        /// </summary>
        public override string ServiceUrl
        {
            get
            {
                return ChannelId.HasValue ? base.ServiceUrl + ChannelId.ToString() : base.ServiceUrl + "channel";
            }
        }

        /// <summary>
        /// 查询的绑定关系相关channel_id
        /// </summary>
        public ulong? ChannelId { get; set; }
    }
}
