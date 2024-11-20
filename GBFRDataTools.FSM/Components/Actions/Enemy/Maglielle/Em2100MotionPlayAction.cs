using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Maglielle;

public class Em2100MotionPlayAction : ActionComponent
{
    [JsonPropertyName("ownerMotionId_")]
    public string OwnerMotionId { get; set; }

    [JsonPropertyName("swordMotionId_")]
    public string SwordMotionId { get; set; }

    [JsonPropertyName("swordType_")]
    public int SwordType { get; set; }

    [JsonPropertyName("customSwordNum_")]
    public int CustomSwordNum { get; set; }

    [JsonPropertyName("isSetSwordPos_")]
    public bool IsSetSwordPos { get; set; }

    [JsonPropertyName("setSwordPos_")]
    public cVec4 SetSwordPos { get; set; }

    [JsonPropertyName("isSetOwnerPos_")]
    public bool IsSetOwnerPos { get; set; }

    [JsonPropertyName("setOwnerPos_")]
    public cVec4 SetOwnerPos { get; set; }

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; }

    [JsonPropertyName("motionInterSec_")]
    public float MotionInterSec { get; set; }

    [JsonPropertyName("swordScale_")]
    public float SwordScale { get; set; }
}