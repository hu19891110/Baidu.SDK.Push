using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Baidu.SDK.Push.Didest;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 请求基础信息
    /// 所有REST请求共用
    /// </summary>
    public class ClientRequestBase
    {
        /// <summary>
        /// ServiceUrl
        /// </summary>
        public virtual string ServiceUrl
        {
            get { return "http://channel.api.duapp.com/rest/2.0/channel/"; }
        }

        /// <summary>
        /// 方法名，必须存在
        ///     如：push_msg
        /// </summary>
        [RequestKeyAttribute("method", true)]
        public Methods? Method { get; set; }

        //         /// <summary>
        //         /// 调用参数签名值，与apikey成对出现。详细用法，请参考：签名计算算法
        //         /// </summary>
        //         [RequestKeyAttribute("sign", true)]
        //         public string Sign { get; set; }

        /// <summary>
        /// 用户发起请求时的unix时间戳。本次请求签名的有效时间为该时间戳+10分钟。
        /// </summary>
        [RequestKeyAttribute("timestamp", true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// 用户指定本次请求签名的失效时间。格式为unix时间戳形式。
        /// </summary>
        [RequestKeyAttribute("expires", false)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// API版本号，默认使用最高版本。
        /// </summary>
        [RequestKeyAttribute("v", false)]
        public uint? Version { get; set; }

        /// <summary>
        /// 生成待POST的数据
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public virtual string GeneratePostData(string apiKey, string secretKey)
        {
            if(string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException("apiKey", "ApiKey MUST set");
            if (string.IsNullOrEmpty(secretKey))
                throw new ArgumentNullException("secretKey", "SecretKey MUST set");

            var paramDic = new Dictionary<string, string>();

            var propertyInfos = GetType().GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                var value = propertyInfo.GetValue(this, null);
                var customAttres = propertyInfo.GetCustomAttributes(typeof(RequestKeyAttribute), true);
                if (customAttres.Length > 1)
                    throw new ArgumentNullException(propertyInfo.Name, "Can NOT set multi RequestKeyAttribute");
                if (customAttres.Length == 1)
                {
                    var customAttribute = customAttres[0];
                    var requestKeyAttribute = customAttribute as RequestKeyAttribute;
                    if (requestKeyAttribute == null)
                        throw new ArgumentNullException(propertyInfo.Name, "Use as convert to RequestKeyAttribute Fail");
                    if (requestKeyAttribute.IsReqired && value == null)
                        throw new ArgumentNullException(propertyInfo.Name);
                    if (value != null)
                        paramDic.Add(requestKeyAttribute.KeyName, RequestKeyConverter.ConvertDataToString(value));
                }
            }

            var sign = SignatureDigest.Digest("POST", ServiceUrl, paramDic, apiKey, secretKey);
            if (string.IsNullOrEmpty(sign))
                throw new Exception("sign is null, may Compute sign Digest Fail");

            paramDic.Add("apikey", apiKey);
            paramDic.Add("sign", sign);
            var paramList = new List<string>(paramDic.Count);
            paramList.AddRange(paramDic.Select(paramKv => string.Format("{0}={1}&", paramKv.Key, Uri.EscapeDataString(paramKv.Value))));
            paramList.Sort();
            var baseData = new StringBuilder();
            foreach (var param in paramList)
            {
                baseData.Append(param);
            }
            if (baseData[baseData.Length - 1] == '&')
                baseData.Remove(baseData.Length - 1, 1);

            string result = baseData.ToString();

            return result;
        }
    }
}