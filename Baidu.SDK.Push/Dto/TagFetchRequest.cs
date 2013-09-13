using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// fetch_tag 请求参数
    /// </summary>
    public class TagFetchRequest : ClientRequestBase
    {
        /// <summary>
        /// fetch_tag 请求参数
        /// </summary>
        public TagFetchRequest()
        {
            Method = Methods.fetch_tag;

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
        [RequestKeyAttribute("name", false)]
        public string Name { get; set; }

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
