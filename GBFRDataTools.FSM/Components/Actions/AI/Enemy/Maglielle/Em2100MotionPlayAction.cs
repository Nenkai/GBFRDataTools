using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100MotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100MotionPlayAction);

    [JsonPropertyName("ownerMotionId_")]
    public string OwnerMotionId { get; set; } = "0000";

    [JsonPropertyName("swordMotionId_")]
    public string SwordMotionId { get; set; } = "0000";

    [JsonPropertyName("swordType_")]
    public int SwordType { get; set; } = 0;

    [JsonPropertyName("customSwordNum_")]
    public int CustomSwordNum { get; set; } = 0;

    [JsonPropertyName("isSetSwordPos_")]
    public bool IsSetSwordPos { get; set; } = false;

    [JsonPropertyName("setSwordPos_")]
    public /* cVec4 */ Vector4 SetSwordPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isSetOwnerPos_")]
    public bool IsSetOwnerPos { get; set; } = false;

    [JsonPropertyName("setOwnerPos_")]
    public /* cVec4 */ Vector4 SetOwnerPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; } = true;

    [JsonPropertyName("motionInterSec_")]
    public float MotionInterSec { get; set; } = -1.0f;

    [JsonPropertyName("swordScale_")]
    public float SwordScale { get; set; } = 1.0f;
}