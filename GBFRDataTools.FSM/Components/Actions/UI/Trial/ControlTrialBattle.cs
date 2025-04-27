using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Trial;

public class ControlTrialBattle : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlTrialBattle);

    [JsonPropertyName("mode_")]
    public EnumString<ControlTrialBattleMode> Mode { get; set; } // Offset 0x30

    [JsonPropertyName("interact_")]
    public bool Interact { get; set; } = false; // Offset 0x60

    public ControlTrialBattle()
    {
    }
}

public enum ControlTrialBattleMode
{
    // アクションチュートリアル開始 = 0
    // 終了 = 1
    // スタート = 2
    StartActionTutorial = 0,
    End = 1,
    Start = 2,
    Type3 = 3,
}