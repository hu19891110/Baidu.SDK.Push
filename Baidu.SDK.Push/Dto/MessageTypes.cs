namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 推送消息类型 
    /// </summary>
    public enum MessageTypes
    {
        /// <summary>
        /// 消息（透传给应用的消息体） 
        /// </summary>
        Message = 0,

        /// <summary>
        /// 通知（对应设备上的消息通知） 
        /// </summary>
        Notification = 1
    }
}
