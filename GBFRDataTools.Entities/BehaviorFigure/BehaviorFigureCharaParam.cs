using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.BehaviorFigure;

public class BehaviorFigureCharaParam
{
    [JsonPropertyName("details_")]
    public Map<uint, Detail> Details { get; set; } = new();

    [JsonPropertyName("rebuildWeaponVfxChangeObjIds_")]
    [eObjId]
    public BindingList<uint> RebuildWeaponVfxChangeObjIds { get; set; } = [];

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Detail /* BehaviorFigureCharaParam::Detail */
    {
        [JsonPropertyName("baseId_")]
        [eObjId]
        public uint BaseId { get; set; }

        [JsonPropertyName("scale_")]
        public float Scale { get; set; }

        [JsonPropertyName("wpId0_")]
        [eObjId]
        public uint WpId0 { get; set; }

        [JsonPropertyName("wpId1_")]
        [eObjId]
        public uint WpId1 { get; set; }

        [JsonPropertyName("wpParts0_")]
        public ushort WpParts0 { get; set; }

        [JsonPropertyName("wpParts1_")]
        public ushort WpParts1 { get; set; }

        [JsonPropertyName("varMax_")]
        public short VarMax { get; set; }

        [JsonPropertyName("vfxId_")]
        public ushort VfxId { get; set; }

        [JsonPropertyName("vfx_")]
        public short Vfx { get; set; }

        [JsonPropertyName("odId_")]
        public ushort OdId { get; set; }

        [JsonPropertyName("odVfx_")]
        public short OdVfx { get; set; }

        [JsonPropertyName("parOdVfx_")]
        public bool ParOdVfx { get; set; }

        [JsonPropertyName("face_")]
        public bool Face { get; set; }

        [JsonPropertyName("mot_")]
        public string? Mot { get; set; }

        [JsonPropertyName("wpMot_")]
        public string? WpMot { get; set; }

        [JsonPropertyName("emoMot_")]
        public string? EmoMot { get; set; }
    }
}
