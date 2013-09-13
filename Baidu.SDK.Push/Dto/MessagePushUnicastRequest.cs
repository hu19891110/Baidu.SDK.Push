using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Baidu.SDK.Push.Dto
{
    /// <summary>
    /// push_msg(Unicast) 请求参数
    /// </summary>
    public class MessagePushUnicastRequest : ClientRequestBase
    {
        /// <summary>
        /// push_msg(Unicast) 请求参数
        /// Push to Special user by channelId and UserId
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="channelId"></param>
        /// <param name="userId"></param>
        /// <param name="messageType"></param>
        /// <param name="messages"></param>
        /// <param name="msgKeyses"></param>
        public MessagePushUnicastRequest(
            DeviceTypes? deviceType,
            ulong channelId,
            string userId,
            MessageTypes? messageType,
            IList<string> messages,
            IList<string> msgKeyses
           )
        {
            Method = Methods.push_msg;
            PushType = PushTypes.Unicast;

            DeviceType = deviceType;

            ChannelId = channelId;
            UserId = userId;

            MessageType = messageType;
            MessageList = messages;
            MessageKeyList = msgKeyses;
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
        /// 推送类型，取值范围为：1～3
        /// 1：单个人，必须指定user_id 和 channel_id （指定用户的指定设备）或者user_id（指定用户的所有设备）
        /// 2：一群人，必须指定 tag
        /// 3：所有人，无需指定tag、user_id、channel_id 
        /// </summary>
        [RequestKeyAttribute("push_type", true)]
        public PushTypes? PushType { get; set; }

        /// <summary>
        /// 设备类型，取值范围为：1～5
        /// 云推送支持多种设备，各种设备的类型编号如下：
        /// 1：浏览器设备；
        /// 2：PC设备；
        /// 3：Andriod设备；
        /// 4：iOS设备；
        /// 5：Windows Phone设备；
        /// 如果存在此字段，则向指定的设备类型推送消息。 默认为android设备类型。 
        /// </summary>
        [RequestKeyAttribute("device_type", false)]
        public DeviceTypes? DeviceType { get; set; }

        /// <summary>
        /// 通道标识 
        /// </summary>
        [RequestKeyAttribute("channel_id", true)]
        public ulong? ChannelId { get; set; }


        /// <summary>
        /// 用户标识，在Android里，channel_id + userid指定某一个特定client。不超过256字节，如果存在此字段，则只推送给此用户
        /// </summary>
        [RequestKeyAttribute("user_id", true)]
        public string UserId { get; set; }

        /// <summary>
        /// 消息类型
        /// 0：消息（透传给应用的消息体）
        /// 1：通知（对应设备上的消息通知）
        /// 默认值为0。 
        /// </summary>
        [RequestKeyAttribute("message_type", false)]
        public MessageTypes? MessageType { get; set; }

        /// <summary>
        /// 指定消息内容，单个消息为单独字符串。如果有二进制的消息内容，请先做 BASE64 的编码。
        /// 当message_type为1 （通知类型），请按以下格式指定消息内容。
        /// 注意：
        ///     当description与alert同时存在时，ios推送以alert内容作为通知内容
        ///     当custom_content与 ios的自定义字段"key":"value"同时存在时，ios推送的自定义字段内容会将以上两个内容合并，但推送内容整体长度不能大于256B，否则有被截断的风险。
        ///     此格式兼容Android和ios原生通知格式的推送。 
        /// </summary>
        public IList<string> MessageList { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [RequestKeyAttribute("messages", true)]
        public string Messages
        {
            get
            {
                return JsonConvert.SerializeObject(MessageList);
            }
        }

        /// <summary>
        /// 消息标识。
        /// 指定消息标识，必须和messages一一对应。相同消息标识的消息会自动覆盖。特别提醒：该功能只支持android、browser、pc三种设备类型。 
        /// </summary>
        public IList<string> MessageKeyList { get; set; }

        /// <summary>
        /// 消息标识
        /// </summary>
        [RequestKeyAttribute("msg_keys", true)]
        public string MessageKeys
        {
            get
            {
                return JsonConvert.SerializeObject(MessageKeyList);
            }
        }

        /// <summary>
        /// 指定消息的过期时间，默认为86400秒。必须和messages一一对应。
        /// </summary>
        [RequestKeyAttribute("message_expires", false)]
        public uint? MessageExpires { get; set; }

        /// <summary>
        /// 部署状态。指定应用当前的部署状态，可取值：
        /// 1：开发状态
        /// 2：生产状态
        /// 若不指定，则默认设置为生产状态。特别提醒：该功能只支持ios设备类型。 
        /// </summary>
        [RequestKeyAttribute("deploy_status", false)]
        public DeployStatus? DeployStatus { get; set; }
    }
}
