﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/get_list 接口的请求。</para>
    /// </summary>
    public class ProductOrderGetListRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置指定创建时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartCreateTime { get; set; }

        /// <summary>
        /// 获取或设置指定创建时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndCreateTime { get; set; }

        /// <summary>
        /// 获取或设置指定更新时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartUpdateTime { get; set; }

        /// <summary>
        /// 获取或设置指定更新时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndUpdateTime { get; set; }

        /// <summary>
        /// 获取或设置指定订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置指定订单来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public int? Source { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
