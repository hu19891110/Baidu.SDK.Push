using System;
using System.Globalization;
using Baidu.SDK.Push.Utility;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 自定义类型转换为提交百度的String数据
    /// </summary>
    internal class RequestKeyConverter
    {
        /// <summary>
        /// 数据转换
        /// </summary>
        /// <param name="value">自定义类型数据，包括需转换的DateTime</param>
        /// <returns></returns>
        public static string ConvertDataToString(object value)
        {
            var type = value.GetType();
            switch (type.Name)
            {
                case "DateTime":
                    return ((DateTime) value).ToUnixTime().ToString(CultureInfo.InvariantCulture);
                case "DeployStatus":
                    var obj = (DeployStatus)value;
                    return ((int)obj).ToString(CultureInfo.InvariantCulture);
                case "DeviceTypes":
                    var deviceType = (DeviceTypes)value;
                    return ((int)deviceType).ToString(CultureInfo.InvariantCulture);
                case "MessageTypes":
                    var msgType = (MessageTypes)value;
                    return ((int)msgType).ToString(CultureInfo.InvariantCulture);
                case "PushTypes":
                    var pushType = (PushTypes)value;
                    return ((int)pushType).ToString(CultureInfo.InvariantCulture);
                case "Methods":
                    return value.ToString();
                default:
                    return value.ToString();
            }
        }
    }
}
