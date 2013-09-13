namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 设备类型
    /// 如果存在此字段，则向指定的设备类型推送消息。 默认为android设备类型
    /// </summary>
    public enum DeviceTypes
    {
        /// <summary>
        /// 浏览器设备
        /// </summary>
        Browser = 1,

        /// <summary>
        /// PC设备
        /// </summary>
        PC = 2,

        /// <summary>
        /// Andriod设备
        /// </summary>
        Android = 3,

        /// <summary>
        /// iOS设备
        /// </summary>
        IOS = 4,

        /// <summary>
        /// Windows Phone设备
        /// </summary>
        WindowsPhone = 5
    }
}
