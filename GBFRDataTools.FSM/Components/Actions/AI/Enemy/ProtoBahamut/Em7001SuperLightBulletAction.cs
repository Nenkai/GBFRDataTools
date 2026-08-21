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
    public int Side { get; set; } = 0; 

    [JsonPropertyName("ownerPhase_")]
    public int OwnerPhase { get; set; } = 0; 

    [JsonPropertyName("lightBulletIndex_")]
    public int LightBulletIndex { get; set; } = 0; 

    [JsonPropertyName("isOD_")]
    public bool IsOD { get; set; } = false; 

    [JsonPropertyName("isCancelEnd_")]
    public bool IsCancelEnd { get; set; } = false; 
}
