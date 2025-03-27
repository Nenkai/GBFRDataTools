using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.Entities.Parameters.Base
{
    public class EmAttackWallParam // EmAttackWall::Param
    {
        [JsonPropertyName("multiHitIntervalSec_")]
        public float MultiHitIntervalSec { get; set; } // Offset 0x8

        [JsonPropertyName("reaction_")]
        public int Reaction { get; set; } // Offset 0xC

        [JsonPropertyName("atkFlag_")]
        public ulong AtkFlag { get; set; } // Offset 0x10

        [JsonPropertyName("isSetPartsEffect_")]
        public bool IsSetPartsEffect { get; set; } // Offset 0x18

        [JsonPropertyName("effectObjId_")]
        [eObjId]
        public int EffectObjId { get; set; } // Offset 0x1C

        [JsonPropertyName("isUseParentObjId_")]
        public bool IsUseParentObjId { get; set; } // Offset 0x20

        [JsonPropertyName("omenEffectId_")]
        public int OmenEffectId { get; set; } // Offset 0x24

        [JsonPropertyName("wallEffectId_")]
        public int WallEffectId { get; set; } // Offset 0x28

        [JsonPropertyName("vanishEffectId_")]
        public int VanishEffectId { get; set; } // Offset 0x2C

        [JsonPropertyName("waitWallSec_")]
        public float WaitWallSec { get; set; } // Offset 0x30

        [JsonPropertyName("omenSec_")]
        public float OmenSec { get; set; } // Offset 0x34

        [JsonPropertyName("wallSec_")]
        public float WallSec { get; set; } // Offset 0x38

        [JsonPropertyName("omenSeDefineName_")]
        public string OmenSeDefineName { get; set; } // Offset 0x48

        [JsonPropertyName("wallSeDefineName_")]
        public string WallSeDefineName { get; set; } // Offset 0x68

        [JsonPropertyName("vanishSeDefineName_")]
        public string VanishSeDefineName { get; set; } // Offset 0x88

        [JsonPropertyName("isPointSe_")]
        public bool IsPointSe { get; set; } // Offset 0x3D

        [JsonPropertyName("isSetPartsSe_")]
        public bool IsSetPartsSe { get; set; } // Offset 0x3C

        [JsonPropertyName("seLineRange_")]
        public float SeLineRange { get; set; } // Offset 0x40

        [JsonPropertyName("beginHeight_")]
        public float BeginHeight { get; set; } // Offset 0xA8

        [JsonPropertyName("endHeight_")]
        public float EndHeight { get; set; } // Offset 0xAC

        [JsonPropertyName("partsWallInfo_")]
        public BindingList<PartsWallInfo> PartsWallInfo { get; set; } // Offset 0xB0

        public EmAttackWallParam() // EmAttackWall::Param
        {
        }
    }


    public class PartsWallInfo // EmAttackWall::Param::PartsWallInfo
    {
        [JsonPropertyName("offsetDeg_")]
        public Vector4 OffsetDeg { get; set; } // Offset 0x10

        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } // Offset 0x20

        [JsonPropertyName("ignoreLanding_")]
        public bool IgnoreLanding { get; set; } // Offset 0x30

        [JsonPropertyName("atkShapeType_")]
        public int AtkShapeType { get; set; } // Offset 0x34

        [JsonPropertyName("atkSize_")]
        public Vector4 AtkSize { get; set; } // Offset 0x40

        [JsonPropertyName("waitSec_")]
        public float WaitSec { get; set; } // Offset 0x50

        [JsonPropertyName("omenSec_")]
        public float OmenSec { get; set; } // Offset 0x54

        [JsonPropertyName("atkSec_")]
        public float AtkSec { get; set; } // Offset 0x58

        public PartsWallInfo()
        {
        }
    }
}
