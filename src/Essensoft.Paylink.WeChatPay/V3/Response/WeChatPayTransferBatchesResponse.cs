﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response;

public class WeChatPayTransferBatchesResponse : WeChatPayResponse
{
    /// <summary>
    /// 商家批次单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部的商家批次单号
    /// <para>示例值：plfk2020042013</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }

    /// <summary>
    /// 微信批次单号
    /// </summary>
    /// <remarks>
    /// 微信批次单号，微信商家转账系统返回的唯一标识
    /// <para>示例值：1030000071100999991182020050700019480001</para>
    /// </remarks>
    [JsonPropertyName("batch_id")]
    public string BatchId { get; set; }

    /// <summary>
    /// 批次创建时间
    /// </summary>
    /// <remarks>
    /// 批次受理成功时返回，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
    /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
    /// </remarks>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }
}
