using System;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 对服务端请求的属性，指定百度推送参数名称以及是否必需
    /// </summary>
    internal class RequestKeyAttribute : Attribute
    {
        /// <summary>
        /// 设置参数名称和是否必需
        /// </summary>
        /// <param name="keyName">参数名称</param>
        /// <param name="requied">是否必需</param>
        public RequestKeyAttribute(string keyName, bool requied)
        {
            KeyName = keyName;
            IsReqired = requied;
        }

        /// <summary>
        /// 百度 REST API要求的参数名称
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// 是否必需
        /// </summary>
        public bool IsReqired { get; set; }

    }
}
