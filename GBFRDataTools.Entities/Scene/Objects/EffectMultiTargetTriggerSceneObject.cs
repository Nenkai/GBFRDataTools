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

namespace GBFRDataTools.Entities.Scene.Objects;

public class EffectMultiTargetTriggerSceneObject : ISceneObject
{
    [JsonPropertyName("_maniRadius")]
    public /* ManipulatableFloat */ float ManiRadius { get; set; }

    [JsonPropertyName("_shapeType")]
    public uint ShapeType { get; set; }

    [JsonPropertyName("_shapeColor")]
    public GuiColor ShapeColor { get; set; }

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; }

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; }

    [JsonPropertyName("estIndex_")]
    public int EstIndex { get; set; }

    [JsonPropertyName("seStartEventName_")]
    public string SeStartEventName { get; set; }

    [JsonPropertyName("seEndEventName_")]
    public string SeEndEventName { get; set; }

    [JsonPropertyName("soundCallCategory_")]
    public int SoundCallCategory { get; set; }

    [JsonPropertyName("soundPartsNo_")]
    public int SoundPartsNo { get; set; }
}