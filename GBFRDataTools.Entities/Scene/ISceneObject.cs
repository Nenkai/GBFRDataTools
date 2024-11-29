using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Converters;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Scene;

public class ISceneObject
{
    [JsonPropertyName("mName")]
    public SceneObjectName Name { get; set; }

    [JsonPropertyName("mLocalMatrix")]
    public /* ManipulatableMatrix */ Matrix4x4 LocalMatrix { get; set; }

    // TODO: Parse this as actual enum flags. Example input: InheritTranslate|InheritScale
    [JsonPropertyName("mInheritanceTransform")]
    public /* cy::InheritanceTransform */ string InheritanceTransform { get; set; }

    [JsonPropertyName("mpChild")]
    [JsonConverter(typeof(ObjectTypeListConverter))]
    public BindingList<ISceneObject> Child { get; set; }

    [JsonPropertyName("mActive")]
    public bool Active { get; set; }

    [JsonPropertyName("mUuid")]
    public /* cy::ISceneObject::UUID */ UUID Uuid { get; set; }

    [JsonPropertyName("mAttachModelJoint")]
    [Obsolete("Not used by the game.")]
    public AttachModelJoint AttachModelJoint { get; set; }

    [JsonPropertyName("isBrokenDisppear_")]
    public bool IsBrokenDisppear { get; set; }

    [JsonPropertyName("disappearCurve_")]
    public GuiImportableCurve<float> DisappearCurve { get; set; }

    [JsonPropertyName("curvePlayer_")]
    public /* cy::CurvePlayer */ float[] CurvePlayer { get; set; }

    [JsonPropertyName("disappearTime_")]
    public float DisappearTime { get; set; }

    [JsonPropertyName("disappearLv_")]
    public int DisappearLv { get; set; }

    [JsonPropertyName("attachDefaultActive_")]
    public bool AttachDefaultActive { get; set; }

    [JsonPropertyName("isUseModelOpacity_")]
    public bool IsUseModelOpacity { get; set; }

    [JsonPropertyName("useModelOpacityToChildren_")]
    public bool UseModelOpacityToChildren { get; set; }

    [JsonPropertyName("forPS4_")]
    public bool ForPS4 { get; set; }

    [JsonPropertyName("forPS5_")]
    public bool ForPS5 { get; set; }

    [JsonPropertyName("forPC_")]
    public bool ForPC { get; set; }

    [JsonPropertyName("isDelayAttach_")]
    public bool IsDelayAttach { get; set; }

    [JsonPropertyName("isBrokenCheckHP_")]
    public bool IsBrokenCheckHP { get; set; }

    [JsonPropertyName("isBrokenCheckBhTrans_")]
    public bool IsBrokenCheckBhTrans { get; set; }
}


public class AttachModelJoint
{
    [JsonPropertyName("mIsEnable")]
    public bool IsEnable { get; set; }

    [JsonPropertyName("mTargetEntity")]
    public uint TargetEntity { get; set; }

    [JsonPropertyName("mTargetJoint")]
    public int TargetJoint { get; set; }
}


public enum InheritanceTransform
{
    InheritAll,
}
