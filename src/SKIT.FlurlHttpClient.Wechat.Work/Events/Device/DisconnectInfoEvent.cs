﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.disconnect_info 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90751 </para>
    /// </summary>
    public class DisconnectInfoEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备与企业微信后台网络连接断开时的时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DisconnectTime")]
        public long DiconnectTimestamp { get; set; }

        /// <summary>
        /// 获取或设置设备连接断开原因。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Reason")]
        public string DisconnectReason { get; set; } = default!;
    }
}
