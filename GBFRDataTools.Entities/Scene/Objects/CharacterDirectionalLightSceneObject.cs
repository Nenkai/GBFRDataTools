using GBFRDataTools.Entities.Base;

using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Scene.Objects;

public class CharacterDirectionalLightSceneObject : ISceneObject
{
    [JsonPropertyName("lightColor_")]
    public GuiColor LightColor { get; set; }

    [JsonPropertyName("lightIntensity_")]
    public float LightIntensity { get; set; }

    [JsonPropertyName("lightAngle_")]
    public /* cVec4 */ Vector4 LightAngle { get; set; }

    [JsonPropertyName("diffuseIntensityOffset_")]
    public float DiffuseIntensityOffset { get; set; }

    [JsonPropertyName("specularIntensityOffset_")]
    public float SpecularIntensityOffset { get; set; }

    [JsonPropertyName("targetList_")]
    public BindingList<MaterialsHashInfo> TargetList { get; set; } = [];
}