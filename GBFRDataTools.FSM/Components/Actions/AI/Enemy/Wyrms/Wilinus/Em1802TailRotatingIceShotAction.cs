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

public class Em1802TailRotatingIceShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802TailRotatingIceShotAction);

    [JsonPropertyName("isTailOnly_")]
    public bool IsTailOnly { get; set; } = false; // Offset 0x60

    [JsonPropertyName("iceSheetRadius_")]
    public float IceSheetRadius { get; set; } = 18.6f; // Offset 0x64

    [JsonPropertyName("attackSec_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float AttackSec { get; set; }

    [JsonPropertyName("aiLevel4AttackSec_")]
    public float AiLevel4AttackSec { get; set; } = 10f; // Offset 0x68

    [JsonPropertyName("aiLevel3AttackSec_")]
    public float AiLevel3AttackSec { get; set; } = 7f; // Offset 0x6C

    [JsonPropertyName("firstAngle_")]
    public float FirstAngle { get; set; } = 180f; // Offset 0x70

    [JsonPropertyName("expansionAngle_")]
    public float ExpansionAngle { get; set; } = 360f; // Offset 0x74

    [JsonPropertyName("expansionTime_")]
    public float ExpansionTime { get; set; } = 2f; // Offset 0x78

    [JsonPropertyName("isRightRotation_")]
    public bool IsRightRotation { get; set; } = false; // Offset 0x7C

    [JsonPropertyName("iceSheetOffset_")]
    public Vector4 IceSheetOffset { get; set; } = new Vector4(2.55f, 0f, -5.825f, 1f); // Offset 0x80

    [JsonPropertyName("attackResetSec_")]
    public float AttackResetSec { get; set; } = 1f; // Offset 0x90

    public Em1802TailRotatingIceShotAction()
    {
    }
}
