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
    public float IceSheetRadius { get; set; } = 18.6f; // Offset 0x78

    [JsonPropertyName("aiLevel4AttackSec_")]
    public float AiLevel4AttackSec { get; set; } = 10f; // Offset 0x7C

    [JsonPropertyName("aiLevel3AttackSec_")]
    public float AiLevel3AttackSec { get; set; } = 7f; // Offset 0x80

    [JsonPropertyName("firstAngle_")]
    public float FirstAngle { get; set; } = 35f; // Offset 0x84

    [JsonPropertyName("expansionAngle_")]
    public float ExpansionAngle { get; set; } = 70f; // Offset 0x88

    [JsonPropertyName("expansionTime_")]
    public float ExpansionTime { get; set; } = 2f; // Offset 0x8C

    [JsonPropertyName("isRightRotation_")]
    public bool IsRightRotation { get; set; } = false; // Offset 0x90

    [JsonPropertyName("iceSheetOffset_")]
    public Vector4 IceSheetOffset { get; set; } = new Vector4(2.55f, 0f, -5.825f, 1f); // Offset 0xA0

    [JsonPropertyName("attackResetSec_")]
    public float AttackResetSec { get; set; } = 1f; // Offset 0xB0

    [JsonPropertyName("attackSec_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float AttackSec { get; set; }

    public Em1802BeamAction()
    {
    }
}
