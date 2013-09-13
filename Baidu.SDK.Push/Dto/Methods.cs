namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 推送服务的方法名
    /// </summary>
    public enum Methods
    {
        /// <summary>
        /// 查询设备、应用、用户与百度Channel的绑定关系
        /// </summary>
        query_bindlist,

        /// <summary>
        /// 推送消息，该接口可用于推送单个人、一群人、所有人以及固定设备的使用场景。
        /// </summary>
        push_msg,

        /// <summary>
        /// 上传iOS apns证书，使channel系统支持apns服务。
        /// </summary>
        init_app_ioscert,

        /// <summary>
        /// 更新iOS设备的推送证书相关内容。
        /// </summary>
        update_app_ioscert,

        /// <summary>
        /// 删除iOS设备的推送证书，使得App server不再支持apns服务。
        /// </summary>
        delete_app_ioscert,

        /// <summary>
        /// 查询该App server对应的iOS证书。
        /// </summary>
        query_app_ioscert,

        /// <summary>
        /// 判断设备、应用、用户与Channel的绑定关系是否存在。
        /// </summary>
        verify_bind,

        /// <summary>
        /// 查询离线消息。
        /// </summary>
        fetch_msg,

        /// <summary>
        /// 查询离线消息的个数。
        /// </summary>
        fetch_msgcount,

        /// <summary>
        /// 删除离线消息。
        /// </summary>
        delete_msg,

        /// <summary>
        /// 服务器端设置用户标签。当该标签不存在时，服务端将会创建该标签。特别地，当user_id被提交时，服务端将会完成用户和tag的绑定操作。
        /// </summary>
        set_tag,

        /// <summary>
        /// App Server查询应用标签。
        /// </summary>
        fetch_tag,

        /// <summary>
        /// 服务端删除用户标签。特别地，当user_id被提交时，服务端将只会完成解除该用户与tag绑定关系的操作。
        /// 注意：该操作不可恢复，请谨慎使用。
        /// </summary>
        delete_tag,

        /// <summary>
        /// App Server查询用户所属的标签列表。
        /// </summary>
        query_user_tags,

        /// <summary>
        /// 根据channel_id查询设备类型。
        /// </summary>
        query_device_type
    }
}
