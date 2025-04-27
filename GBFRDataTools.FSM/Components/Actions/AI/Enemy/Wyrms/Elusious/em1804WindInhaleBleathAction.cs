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
    public Vector4 InhaleOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x70

    [JsonPropertyName("inhaleAngle_")]
    public float InhaleAngle { get; set; } = 220f; // Offset 0x80

    [JsonPropertyName("inhaleRadius_")]
    public float InhaleRadius { get; set; } = 35f; // Offset 0x84

    [JsonPropertyName("inhalePower_")]
    public float InhalePower { get; set; } = 0.08f; // Offset 0x88

    [JsonPropertyName("cycloneOffset_")]
    public Vector4 CycloneOffset { get; set; } = new Vector4(2f, 0f, 8f, 1f); // Offset 0x40

    [JsonPropertyName("twisterNum_")]
    public int TwisterNum { get; set; } = 4; // Offset 0xA8

    [JsonPropertyName("twisterOffset0_")]
    public Vector4 TwisterOffset0 { get; set; } = new Vector4(7.071f, 0f, 7.071f, 1f); // Offset 0xB0

    [JsonPropertyName("twisterOffset1_")]
    public Vector4 TwisterOffset1 { get; set; } = new Vector4(7.071f, 0f, -7.071f, 1f); // Offset 0xC0

    [JsonPropertyName("twisterOffset2_")]
    public Vector4 TwisterOffset2 { get; set; } = new Vector4(-7.071f, 0f, -7.071f, 1f); // Offset 0xD0

    [JsonPropertyName("twisterOffset3_")]
    public Vector4 TwisterOffset3 { get; set; } = new Vector4(-7.071f, 0f, 7.071f, 1f); // Offset 0xE0

    [JsonPropertyName("twisterOffset4_")]
    public Vector4 TwisterOffset4 { get; set; } = new Vector4(0f, 0f, 10f, 1f); // Offset 0xF0

    [JsonPropertyName("twisterOffset5_")]
    public Vector4 TwisterOffset5 { get; set; } = new Vector4(10f, 0f, 0f, 1f); // Offset 0x100

    [JsonPropertyName("twisterOffset6_")]
    public Vector4 TwisterOffset6 { get; set; } = new Vector4(-10f, 0f, 0f, 1f); // Offset 0x110

    [JsonPropertyName("twisterRotY0_")]
    public float TwisterRotY0 { get; set; } = 45f; // Offset 0x120

    [JsonPropertyName("twisterRotY1_")]
    public float TwisterRotY1 { get; set; } = 135f; // Offset 0x124

    [JsonPropertyName("twisterRotY2_")]
    public float TwisterRotY2 { get; set; } = 225f; // Offset 0x128

    [JsonPropertyName("twisterRotY3_")]
    public float TwisterRotY3 { get; set; } = 315f; // Offset 0x12C

    [JsonPropertyName("twisterRotY4_")]
    public float TwisterRotY4 { get; set; } = 0f; // Offset 0x130

    [JsonPropertyName("twisterRotY5_")]
    public float TwisterRotY5 { get; set; } = 90f; // Offset 0x134

    [JsonPropertyName("twisterRotY6_")]
    public float TwisterRotY6 { get; set; } = 270f; // Offset 0x138

    public em1804WindInhaleBleathAction()
    {
    }
}

