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

public class We7003ShockWaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7003ShockWaveAction);

    [JsonPropertyName("isRagnarokBuff_")]
    public bool IsRagnarokBuff { get; set; } = false; // Offset 0x50

    public We7003ShockWaveAction()
    {
    }
}