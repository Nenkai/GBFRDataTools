using GBFRDataTools.Entities.Parameters.Player;

using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.NPC;

public class NPCConfig
{
    [JsonPropertyName("densityParamList_")]
    public BindingList<DensityParam> DensityParamList { get; set; } = []; // Offset 0x8

    [JsonPropertyName("playerCost_")]
    public float PlayerCost { get; set; } // Offset 0x20

    [JsonPropertyName("npcCost_")]
    public float NpcCost { get; set; } // Offset 0x24

    [JsonPropertyName("objCost_")]
    public float ObjCost { get; set; } // Offset 0x28

    [JsonPropertyName("playerLength_")]
    public float PlayerLength { get; set; } // Offset 0x2C

    [JsonPropertyName("npcLength_")]
    public float NpcLength { get; set; } // Offset 0x30

    [JsonPropertyName("objLength_")]
    public float ObjLength { get; set; } // Offset 0x34

    public NPCConfig()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DensityParam // NPCConfig::DensityParam
    {
        [JsonPropertyName("centerPos_")]
        public Vector4 CenterPos { get; set; } // Offset 0x10

        [JsonPropertyName("rotY_")]
        public float RotY { get; set; } // Offset 0x20

        [JsonPropertyName("density_")]
        public float Density { get; set; } // Offset 0x24

        [JsonPropertyName("xyzSize_")]
        public Vector4 XyzSize { get; set; } // Offset 0x30
    }
}



