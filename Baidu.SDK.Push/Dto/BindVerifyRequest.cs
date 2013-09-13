using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// verify_bind 请求参数
    /// </summary>
    public class BindVerifyRequest : ClientRequestBase
    {
        /// <summary>
        /// verify_bind 请求参数
        /// </summary>
        /// <param name="userId"></param>
        public BindVerifyRequest(string userId)
        {
            Method = Methods.verify_bind;

            UserId = userId;

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
        /// 用户标识，在Android里，channel_id + userid指定某一个特定client。不超过256字节，如果存在此字段，则只推送给此用户
        /// </summary>
        [RequestKeyAttribute("user_id", true)]
        public string UserId { get; set; }

        /// <summary>
        /// 设备类型，取值范围为：1～5
        /// 云推送支持多种设备，各种设备的类型编号如下：
        /// 1：浏览器设备；
        /// 2：PC设备；
        /// 3：Andriod设备；
        /// 4：iOS设备；
        /// 5：Windows Phone设备；
        /// </summary>
        [RequestKeyAttribute("device_type", false)]
        public DeviceTypes? DeviceType { get; set; }
    }
}
