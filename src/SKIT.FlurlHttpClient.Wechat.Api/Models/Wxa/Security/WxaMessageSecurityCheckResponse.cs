﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/msg_sec_check 接口的响应。</para>
    /// </summary>
    public class WxaMessageSecurityCheckResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置建议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggest")]
                [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                public string SuggestType { get; set; } = default!;

                /// <summary>
                /// 获取或设置命中标签枚举值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("label")]
                [System.Text.Json.Serialization.JsonPropertyName("label")]
                public int Label { get; set; }
            }

            public class Detail
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置策略类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy")]
                public string Strategy { get; set; } = default!;

                /// <summary>
                /// 获取或设置建议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggest")]
                [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                public string? SuggestType { get; set; }

                /// <summary>
                /// 获取或设置命中标签枚举值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("label")]
                [System.Text.Json.Serialization.JsonPropertyName("label")]
                public int? Label { get; set; }

                /// <summary>
                /// 获取或设置级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int? Level { get; set; }

                /// <summary>
                /// 获取或设置置信度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prob")]
                [System.Text.Json.Serialization.JsonPropertyName("prob")]
                public int? Probability { get; set; }

                /// <summary>
                /// 获取或设置命中的自定义关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置综合结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }

        /// <summary>
        /// 获取或设置详细结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail[]? DetailList { get; set; }
    }
}
