using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    ///  update_app_ioscert 请求参数
    /// </summary>
    public class AppIOSCertUpdateRequest : ClientRequestBase
    {
        /// <summary>
        /// update_app_ioscert 请求参数
        /// </summary>
        public AppIOSCertUpdateRequest()
        {
            Method = Methods.update_app_ioscert;

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
        /// 证书名称，最长128字节
        /// </summary>
        [RequestKeyAttribute("name", false)]
        public string Name { get; set; }

        /// <summary>
        /// 证书描述，最长256字节
        /// </summary>
        [RequestKeyAttribute("description", false)]
        public string Description { get; set; }

        /// <summary>
        /// 正式版证书内容
        /// </summary>
        [RequestKeyAttribute("release_cert ", false)]
        public string ReleaseCert { get; set; }

        /// <summary>
        /// 开发版证书内容
        /// </summary>
        [RequestKeyAttribute("dev_cert ", false)]
        public string DevCert { get; set; }
    }
}
