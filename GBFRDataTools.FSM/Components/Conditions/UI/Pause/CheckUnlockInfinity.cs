using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Pause;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckUnlockInfinity : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckUnlockInfinity);

    [JsonPropertyName("resultType_")]
    public EnumString<CheckUnlockInfinityType> ResultType { get; set; } // Offset 0x38

    public enum CheckUnlockInfinityType
    {
        OnlyMe = 0, // 自分のみ
        Type1 = 1,
    }
}

