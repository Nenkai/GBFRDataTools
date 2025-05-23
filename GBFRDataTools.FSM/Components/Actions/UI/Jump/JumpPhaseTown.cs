﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Jump;

public class JumpPhaseTown : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(JumpPhaseTown);

    [JsonPropertyName("jumpType_")]
    public EnumString<JumpPhaseTownType> JumpType { get; set; } // Offset 0x30
}

public enum JumpPhaseTownType
{
    // 街に戻る = 0,
    // オンラインに遷移 = 1,
    // オフラインに遷移 = 2,
    // リザルトから街に戻る = 3,
    ReturnToTown = 0,
    GoOnline = 1,
    GoOffline = 2,
    ReturnToTownFromResults = 3,
}
