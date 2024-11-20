using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Converters;
using GBFRDataTools.Entities.Preset;

using MessagePack;

namespace GBFRDataTools.Entities.Scene.Objects;

public class EffectEmitterSceneObject : ISceneObject
{
    [JsonPropertyName("_category")]
    public int Category { get; set; }

    [JsonPropertyName("_categoryExtNo")]
    public int CategoryExtNo { get; set; }

    [JsonPropertyName("_estIndex")]
    public int EstIndex { get; set; }

    [JsonPropertyName("_objType")]
    public int ObjType { get; set; }

    [JsonPropertyName("_objNo")]
    public int ObjNo { get; set; }

    [JsonPropertyName("_timeScale")]
    public float TimeScale { get; set; }

    [JsonPropertyName("_color")]
    public GuiColor Color { get; set; }

    [JsonPropertyName("_isLooping")]
    public bool IsLooping { get; set; }

    [JsonPropertyName("_useTrigger")]
    public bool UseTrigger { get; set; }

    [JsonPropertyName("_useTriggerParent")]
    public bool UseTriggerParent { get; set; }

    [JsonPropertyName("_withoutPosSet")]
    public bool WithoutPosSet { get; set; }

    [JsonPropertyName("effectParentEntity_")]
    public EffectParentEntity EffectParentEntity { get; set; }

    [JsonPropertyName("opacityInterpolateSec_")]
    public float OpacityInterpolateSec { get; set; }

    [JsonPropertyName("opacityInterpolateSecUseArea_")]
    public bool OpacityInterpolateSecUseArea { get; set; }
}

public class EffectParentEntity
{
    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; }

    [JsonPropertyName("targetEntity_")]
    public uint TargetEntity { get; set; }
}