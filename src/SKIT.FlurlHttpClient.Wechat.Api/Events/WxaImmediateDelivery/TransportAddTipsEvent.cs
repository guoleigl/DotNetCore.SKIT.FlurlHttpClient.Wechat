﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.transport_add_tips 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onOrderAddTips.html </para>
    /// </summary>
    public class TransportAddTipsEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        public string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        public string ShopOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string ShopNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置校验串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_sign")]
        public string DeliverySignature { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置小费金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tips")]
        [System.Text.Json.Serialization.JsonPropertyName("tips")]
        public double TipValue { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string Remark { get; set; } = default!;
    }
}
