using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// set_tag 请求参数
    /// </summary>
    public class TagSetRequest : ClientRequestBase
    {
        /// <summary>
        /// set_tag 请求参数
        /// </summary>
        /// <param name="tag"></param>
        public TagSetRequest(
            string tag
           )
        {
            Method = Methods.set_tag;

            Tag = tag;

            Timestamp = DateTime.Now;
        }

        /// <summary>
        /// ServiceUrl
        /// </summary>
        public override string ServiceUrl
        {
            get
            {
                return base.ServiceUrl + "channel";
            }
        }

        /// <summary>
        /// 标签名称，不超过128字节
        /// </summary>
        [RequestKeyAttribute("tag", true)]
        public string Tag { get; set; }

        /// <summary>
        /// 用户标识，最长256字节
        /// </summary>
        [RequestKeyAttribute("user_id", false)]
        public string UserId { get; set; }
    }
}
