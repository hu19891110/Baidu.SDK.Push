using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// delete_tag 请求参数
    /// </summary>
    /// <remarks>
    /// 服务端删除用户标签。
    /// 特别地，当user_id被提交时，服务端将只会完成解除该用户与tag绑定关系的操作。
    /// 注意：该操作不可恢复，请谨慎使用。
    /// </remarks>
    public class TagDeleteRequest : ClientRequestBase
    {
        /// <summary>
        /// delete_tag 请求参数
        /// </summary>
        /// <param name="tag"></param>
        /// <remarks>
        /// 服务端删除用户标签。
        /// 特别地，当user_id被提交时，服务端将只会完成解除该用户与tag绑定关系的操作。
        /// 注意：该操作不可恢复，请谨慎使用。
        /// </remarks>
        public TagDeleteRequest(
            string tag
           )
        {
            Method = Methods.delete_tag;

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
