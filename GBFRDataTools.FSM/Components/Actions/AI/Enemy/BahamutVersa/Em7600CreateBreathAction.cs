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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600CreateBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600CreateBreathAction);

    [JsonPropertyName("className_")]
    public string ClassName { get; set; } // Offset 0x60

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } // Offset 0x80

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1f; // Offset 0x30

    [JsonPropertyName("atkRate_")]
    public float AtkRate { get; set; } = 1f; // Offset 0x34

    [JsonPropertyName("velocity_")]
    public float Velocity { get; set; } = 1f; // Offset 0x38

    [JsonPropertyName("shotFrame_")]
    public int ShotFrame { get; set; } = 0; // Offset 0xA8

    [JsonPropertyName("isAimTartget_")]
    public bool IsAimTartget { get; set; } = true; // Offset 0xA0

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x40

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; } = 0f; // Offset 0x50

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; } = 0f; // Offset 0x54

    [JsonPropertyName("degreeZ_")]
    public float DegreeZ { get; set; } = 0f; // Offset 0x58

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1; // Offset 0x5C

    public Em7600CreateBreathAction()
    {
    }
}
