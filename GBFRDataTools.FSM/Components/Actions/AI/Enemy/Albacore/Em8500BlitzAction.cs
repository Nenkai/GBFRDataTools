using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Albacore;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8500BlitzAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8500BlitzAction);

    [JsonPropertyName("blitzType_")]
    public int BlitzType { get; set; } = 0;

    public enum BlitzActionType
    {
        Type0 = 0,
        Type1 = 1,
        Type2 = 2,
        Type3 = 3,
        Type4 = 4,
        Type5 = 5,
    }
}