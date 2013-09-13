using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_bindlist 请求响应
    /// </summary>
    public class BindListQueryResponse : ClientResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_params")]
        public QueryBindListResponseParam ResponseParams { get; set; }
    }

    /// <summary>
    /// query_bindlist 绑定
    /// </summary>
    public class QueryBindListResponseParam
    {
        /// <summary>
        /// 绑定数据总数
        /// </summary>
        [JsonProperty("total_num")]
        public ulong? TotalNumber { get; set; }

        /// <summary>
        /// 本次查询绑定数量
        /// </summary>
        [JsonProperty("amount")]
        public ulong? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("binds")]
        public IList<QueryBindListResponseBindInfo> Binds { get; set; }
    }

    /// <summary>
    /// query_bindlist 绑定明细
    /// </summary>
    public class QueryBindListResponseBindInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel_id")]
        public ulong? ChannelId { get; set; }

        /// <summary>
        /// channel绑定的user标识
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// channel绑定的设备编号
        /// </summary>
        [JsonProperty("device_id")]
        public ulong? DeviceId { get; set; }

        /// <summary>
        /// channel绑定的设备类型
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceTypes? DeviceType { get; set; }

        /// <summary>
        /// channel绑定的设备描述
        /// </summary>
        [JsonProperty("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// channel绑定名称
        /// </summary>
        [JsonProperty("bind_name")]
        public string BindName { get; set; }

        /// <summary>
        /// channel绑定时间
        /// </summary>
        [JsonProperty("bind_time")]
        public DateTime? BindTime { get; set; }

        /// <summary>
        /// channel绑定附加信息
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }

        /// <summary>
        /// 绑定状态，0：绑定在线； 1：绑定离线
        /// </summary>
        [JsonProperty("bind_status")]
        public BindStatus? BindStatus { get; set; }

        /// <summary>
        /// 应用在线状态，on:在线；off:离线
        /// </summary>
        [JsonProperty("online_status")]
        public string OnlineStatus { get; set; }

        /// <summary>
        /// 连接创建时间，仅在在线状态时返回
        /// Unix时间格式
        /// </summary>
        [JsonProperty("online_timestamp")]
        public DateTime? OnlineTimestamp { get; set; }

        /// <summary>
        /// 连接超时时，仅在在线状态时返回
        /// Unix时间格式
        /// </summary>
        [JsonProperty("online_expires")]
        public DateTime? OnlineExpires { get; set; }
    }
}
