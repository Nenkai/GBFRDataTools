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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Elusious;

#pragma warning disable IDE1006 // Naming Styles
public class em1804WindInhaleBleathAction : ActionComponent
#pragma warning restore IDE1006 // Naming Styles
{
    [JsonIgnore]
    public override string ComponentName => nameof(em1804WindInhaleBleathAction);

    [JsonPropertyName("inhaleOffset_")]
    public Vector4 InhaleOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("inhaleAngle_")]
    public float InhaleAngle { get; set; } = 220f; 

    [JsonPropertyName("inhaleRadius_")]
    public float InhaleRadius { get; set; } = 35f; 

    [JsonPropertyName("inhalePower_")]
    public float InhalePower { get; set; } = 0.08f; 

    [JsonPropertyName("cycloneOffset_")]
    public Vector4 CycloneOffset { get; set; } = new Vector4(2f, 0f, 8f, 1f); 

    [JsonPropertyName("twisterNum_")]
    public int TwisterNum { get; set; } = 4; 

    [JsonPropertyName("twisterOffset0_")]
    public Vector4 TwisterOffset0 { get; set; } = new Vector4(7.071f, 0f, 7.071f, 1f); 

    [JsonPropertyName("twisterOffset1_")]
    public Vector4 TwisterOffset1 { get; set; } = new Vector4(7.071f, 0f, -7.071f, 1f); 

    [JsonPropertyName("twisterOffset2_")]
    public Vector4 TwisterOffset2 { get; set; } = new Vector4(-7.071f, 0f, -7.071f, 1f); 

    [JsonPropertyName("twisterOffset3_")]
    public Vector4 TwisterOffset3 { get; set; } = new Vector4(-7.071f, 0f, 7.071f, 1f); 

    [JsonPropertyName("twisterOffset4_")]
    public Vector4 TwisterOffset4 { get; set; } = new Vector4(0f, 0f, 10f, 1f); 

    [JsonPropertyName("twisterOffset5_")]
    public Vector4 TwisterOffset5 { get; set; } = new Vector4(10f, 0f, 0f, 1f); 

    [JsonPropertyName("twisterOffset6_")]
    public Vector4 TwisterOffset6 { get; set; } = new Vector4(-10f, 0f, 0f, 1f); 

    [JsonPropertyName("twisterRotY0_")]
    public float TwisterRotY0 { get; set; } = 45f; 

    [JsonPropertyName("twisterRotY1_")]
    public float TwisterRotY1 { get; set; } = 135f; 

    [JsonPropertyName("twisterRotY2_")]
    public float TwisterRotY2 { get; set; } = 225f; 

    [JsonPropertyName("twisterRotY3_")]
    public float TwisterRotY3 { get; set; } = 315f; 

    [JsonPropertyName("twisterRotY4_")]
    public float TwisterRotY4 { get; set; } = 0f; 

    [JsonPropertyName("twisterRotY5_")]
    public float TwisterRotY5 { get; set; } = 90f; 

    [JsonPropertyName("twisterRotY6_")]
    public float TwisterRotY6 { get; set; } = 270f; 
}

