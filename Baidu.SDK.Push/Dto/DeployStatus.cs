namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// 部署状态。指定应用当前的部署状态
    /// 特别提醒：该功能只支持ios设备类型。 
    /// </summary>
    public enum DeployStatus
    {
        /// <summary>
        /// 开发状态
        /// </summary>
        Development = 1,

        /// <summary>
        /// 生产状态 
        /// </summary>
        Production = 2
    }
}
