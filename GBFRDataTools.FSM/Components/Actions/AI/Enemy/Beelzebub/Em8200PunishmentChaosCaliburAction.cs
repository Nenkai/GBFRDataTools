using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200PunishmentChaosCaliburAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200PunishmentChaosCaliburAction);

    [JsonPropertyName("isConnectRagingChain_")]
    public bool IsConnectRagingChain { get; set; } = false;

    [JsonPropertyName("isWarp_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public bool IsWarp { get; set; }

    [JsonPropertyName("warpOffsetPos_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public Vector4 WarpOffsetPos { get; set; } = Vector4.UnitW;
}

