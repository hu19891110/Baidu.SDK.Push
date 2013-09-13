using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_bindlist 请求参数
    /// </summary>
    public class BindListQueryRequest : ClientRequestBase
    {
        /// <summary>
        /// query_bindlist 请求参数
        /// </summary>
        public BindListQueryRequest()
        {
            Method = Methods.query_bindlist;

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

        /// <summary>
        /// 用户标识。不超过256字节
        /// 如果存在此字段，则只返回与该用户相关的绑定关系 
        /// </summary>
        [RequestKeyAttribute("user_id ", false)]
        public string UserId { get; set; }

        /// <summary>
        /// 百度Channel支持多种设备
        /// 如果存在此字段，则只返回该设备类型的绑定关系。 默认不区分设备类型
        /// </summary>
        [RequestKeyAttribute("device_type ", false)]
        public DeviceTypes? DeviceType { get; set; }

        /// <summary>
        /// 查询页码，默认为0。 
        /// </summary>
        [RequestKeyAttribute("start", false)]
        public uint? Start { get; set; }

        /// <summary>
        /// 一次查询条数，默认为10
        /// </summary>
        [RequestKeyAttribute("limit", false)]
        public uint? Limit { get; set; }
    }
}
