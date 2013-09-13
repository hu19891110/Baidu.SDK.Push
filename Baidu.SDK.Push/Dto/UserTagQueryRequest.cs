using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// query_user_tags 请求参数
    /// </summary>
    public class UserTagQueryRequest : ClientRequestBase
    {
        /// <summary>
        /// query_user_tags 请求参数
        /// </summary>
        /// <param name="userId"></param>
        public UserTagQueryRequest(
            string userId
           )
        {
            Method = Methods.query_user_tags;

            UserId = userId;

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
        /// 用户标识，最长256字节
        /// </summary>
        [RequestKeyAttribute("user_id", true)]
        public string UserId { get; set; }
    }
}
