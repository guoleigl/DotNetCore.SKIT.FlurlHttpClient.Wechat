﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.component_verify_ticket 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/component_verify_ticket.html </para>
    /// </summary>
    public class ComponentVerifyTicketEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方平台 AppId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AppId")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置信息类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("InfoType")]
        public string InfoType { get; set; } = default!;

        /// <summary>
        /// 获取或设置验证票据。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ComponentVerifyTicket")]
        public string ComponentVerifyTicket { get; set; } = default!;
    }
}