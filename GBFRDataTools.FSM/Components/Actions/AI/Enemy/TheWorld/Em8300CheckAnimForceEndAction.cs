using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300CheckAnimForceEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300CheckAnimForceEndAction);

    [JsonPropertyName("flagNum_")]
    public int FlagNum { get; set; } = 1;

    [JsonPropertyName("isComboContinueCheck_")]
    public bool IsComboContinueCheck { get; set; } = false;

    [JsonPropertyName("minDistance_")]
    public float MinDistance { get; set; } = 0f;

    [JsonPropertyName("maxDistance_")]
    public float MaxDistance { get; set; } = 10f;
}
