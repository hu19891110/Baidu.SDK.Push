﻿using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// delete_app_ioscert 请求参数
    /// </summary>
    public class AppIOSCertDeleteRequest : ClientRequestBase
    {
        /// <summary>
        /// delete_app_ioscert 请求参数
        /// </summary>
        public AppIOSCertDeleteRequest()
        {
            Method = Methods.delete_app_ioscert;

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
