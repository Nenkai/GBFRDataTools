using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SuperLightBulletAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SuperLightBulletAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x70

    [JsonPropertyName("ownerPhase_")]
    public int OwnerPhase { get; set; } = 0; // Offset 0x74

    [JsonPropertyName("lightBulletIndex_")]
    public int LightBulletIndex { get; set; } = 0; // Offset 0x78

    [JsonPropertyName("isOD_")]
    public bool IsOD { get; set; } = false; // Offset 0x7C

    [JsonPropertyName("isCancelEnd_")]
    public bool IsCancelEnd { get; set; } = false; // Offset 0x7D

    public Em7001SuperLightBulletAction()
    {
    }
}
