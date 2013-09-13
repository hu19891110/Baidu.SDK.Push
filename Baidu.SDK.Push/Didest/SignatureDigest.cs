using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Baidu.SDK.Push.Utility;

namespace Baidu.SDK.Push.Didest
{
    /// <summary>
    /// 签名
    /// </summary>
    public class SignatureDigest
    {
        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="httpMethod"></param>
        /// <param name="url"></param>
        /// <param name="paramDic"></param>
        /// <param name="apiKey"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public static string Digest(string httpMethod, string url, Dictionary<string, string> paramDic, string apiKey, string secretKey)
        {
            var paramList = new List<string>(paramDic.Count);
            paramList.AddRange(paramDic.Select(paramKv => string.Format("{0}={1}", paramKv.Key, paramKv.Value)));
            if (!paramDic.ContainsKey("apikey"))
                paramList.Add(string.Format("{0}={1}", "apikey", apiKey));
            paramList.Sort();

            var paramData = new StringBuilder();
            foreach (var param in paramList)
            {
                paramData.Append(param);
            }

            string signData = httpMethod.ToUpper() + url + paramData + secretKey;
            var baseString = Uri.EscapeDataString(signData);

            var sign = MD5.GetHashString(baseString).ToLower();

            return sign;
        }
    }
}
