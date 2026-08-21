using GBFRDataTools.FSM.Components.Actions.Battle;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802BeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802BeamAction);

    [JsonPropertyName("iceSheetRadius_")]
    public float IceSheetRadius { get; set; } = 18.6f; 

    [JsonPropertyName("aiLevel4AttackSec_")]
    public float AiLevel4AttackSec { get; set; } = 10f; 

    [JsonPropertyName("aiLevel3AttackSec_")]
    public float AiLevel3AttackSec { get; set; } = 7f; 

    [JsonPropertyName("firstAngle_")]
    public float FirstAngle { get; set; } = 35f; 

    [JsonPropertyName("expansionAngle_")]
    public float ExpansionAngle { get; set; } = 70f; 

    [JsonPropertyName("expansionTime_")]
    public float ExpansionTime { get; set; } = 2f; 

    [JsonPropertyName("isRightRotation_")]
    public bool IsRightRotation { get; set; } = false; 

    [JsonPropertyName("iceSheetOffset_")]
    public Vector4 IceSheetOffset { get; set; } = new Vector4(2.55f, 0f, -5.825f, 1f); 

    [JsonPropertyName("attackResetSec_")]
    public float AttackResetSec { get; set; } = 1f; 

    [JsonPropertyName("attackSec_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float AttackSec { get; set; }
}
