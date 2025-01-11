using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmAttackWall_Param // EmAttackWall::Param
{
    [JsonPropertyName("multiHitIntervalSec_")]
    public float MultiHitIntervalSec { get; set; }

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; }

    [JsonPropertyName("atkFlag_")]
    public ulong AtkFlag { get; set; }

    [JsonPropertyName("isSetPartsEffect_")]
    public bool IsSetPartsEffect { get; set; }

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("isUseParentObjId_")]
    public bool IsUseParentObjId { get; set; }

    [JsonPropertyName("omenEffectId_")]
    public int OmenEffectId { get; set; }

    [JsonPropertyName("wellEffectId_")]
    public int WallEffectId { get; set; }

    [JsonPropertyName("vanishEffectId_")]
    public int VanishEffectId { get; set; }

    [JsonPropertyName("waitWallSec_")]
    public float WaitWallSec { get; set; }

    [JsonPropertyName("omenSec_")]
    public float OmenSec { get; set; }

    [JsonPropertyName("wallSec_")]
    public float WallSec { get; set; }

    [JsonPropertyName("omenSeDefineName_")]
    public string OmenSeDefineName { get; set; }

    [JsonPropertyName("wallSeDefineName_")]
    public string WallSeDefineName { get; set; }

    [JsonPropertyName("vanishSeDefineName_")]
    public string VanishSeDefineName { get; set; }

    [JsonPropertyName("isPointSe_")]
    public bool IsPointSe { get; set; }

    [JsonPropertyName("isSetPartsSe_")]
    public bool IsSetPartsSe { get; set; }

    [JsonPropertyName("seLineRange_")]
    public float SeLineRange { get; set; }

    [JsonPropertyName("beginHeight_")]
    public float BeginHeight { get; set; }

    [JsonPropertyName("endHeight_")]
    public float EndHeight { get; set; }

    [JsonPropertyName("partsWallInfo_")]
    public BindingList<EmAttackWall_Param_PartsWallInfo> FireWallParam { get; set; } // EmAttackWall::Param::PartsWallInfo
}

public class EmAttackWall_Param_PartsWallInfo // EmAttackWall::Param::PartsWallInfo
{
    [JsonPropertyName("offsetDeg_")]
    public /* cVec4 */ Vector4 OffsetDeg { get; set; }

    [JsonPropertyName("offsetPos_")]
    public /* cVec4 */ Vector4 OffsetPos { get; set; }

    [JsonPropertyName("ignoreLanding_")]
    public bool IgnoreLanding { get; set; }

    [JsonPropertyName("atkShapeType_")]
    public int AtkShapeType { get; set; }

    [JsonPropertyName("atkSize_")]
    public /* cVec4 */ Vector4 AtkSize { get; set; }

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; }

    [JsonPropertyName("omenSec_")]
    public float OmenSec { get; set; }

    [JsonPropertyName("atkSec_")]
    public float AtkSec { get; set; }
}

