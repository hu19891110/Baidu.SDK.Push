namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 推送类型
    /// </summary>
    public enum PushTypes
    {
        /// <summary>
        /// 单个人，必须指定user_id 和 channel_id （指定用户的指定设备）或者user_id（指定用户的所有设备） 
        /// </summary>
        Unicast = 1,
        
        /// <summary>
        /// 一群人，必须指定 tag 
        /// </summary>
        Tag = 2,

        /// <summary>
        /// 所有人，无需指定tag、user_id、channel_id 
        /// </summary>
        Broadcast= 3
    }
}
