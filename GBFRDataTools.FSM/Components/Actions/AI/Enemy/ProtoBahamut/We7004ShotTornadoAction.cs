using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class We7004ShotTornadoAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7004ShotTornadoAction);

    [JsonPropertyName("isRagnarokBuff_")]
    public bool IsRagnarokBuff { get; set; } = true; // Offset 0x40

    public We7004ShotTornadoAction()
    {
    }
}