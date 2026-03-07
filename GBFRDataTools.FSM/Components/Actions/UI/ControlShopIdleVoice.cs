using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ControlShopIdleVoice : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlShopIdleVoice);

    [JsonPropertyName("controlType_")]
    public EnumString<ControlShopIdleControlType> ControlType { get; set; } = new();
}

public enum ControlShopIdleControlType
{
    // 開始 = 0,
    // 停止 = 1,
    // タイマーリセット = 2,
    // ノードにいる間停止 = 3,
    Start = 0,
    Stop = 1,
    TimerReset = 2,
    StopWhileInNode = 3,
}