﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/subsidy/return-receipts 接口的响应。</para>
    /// </summary>
    public class CreateMarketingBusifavorSubsidyReturnReceiptResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置补差回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy_return_receipt_id")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy_return_receipt_id")]
        public string SubsidyReturnReceiptId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家券批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置营销补差扣款商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_merchant")]
        public string PayerMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置营销补差入账商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_merchant")]
        public string PayeeMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置补差回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置补差回退描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置补差付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy_receipt_id")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy_receipt_id")]
        public string SubsidyReceiptId { get; set; } = default!;

        /// <summary>
        /// 获取或设置业务请求唯一单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_subsidy_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_subsidy_return_no")]
        public string OutSubsidyReturnNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置补差回退单据状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置补差回退失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置补差回退完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_done_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("return_done_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置补差回退发起时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("return_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
