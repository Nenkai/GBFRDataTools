using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmLockOnParam
{
    [JsonPropertyName("partsInfoList_")]
    public BindingList<PartsInfo> PartsInfoList { get; set; } = []; // std::vector<EmLockOnParam::PartsInfo>

    [JsonPropertyName("spArtsPrioLayer_")]
    public int SpArtsPrioLayer { get; set; }

    [JsonPropertyName("spArtsPrioOffset_")]
    public int SpArtsPrioOffset { get; set; }

    [JsonPropertyName("spArtsWarpOffset_")]
    public /* cVec4 */ Vector4 SpArtsWarpOffset { get; set; }

    [JsonPropertyName("spArtsWarpPartsNumber_")]
    public int SpArtsWarpPartsNumber { get; set; }

    [JsonPropertyName("spArtsWarpDist_")]
    public float SpArtsWarpDist { get; set; }

    [JsonPropertyName("rangeType_")]
    public int RangeType { get; set; }

    public class PartsInfo
    {
        [JsonPropertyName("offset_")]
        public /* cVec4 */ Vector4 Offset { get; set; }

        [JsonPropertyName("partsNumber_")]
        public int PartsNumber { get; set; }

        [JsonPropertyName("camRot_")]
        public float CamRot { get; set; }

        [JsonPropertyName("collisionOffset_")]
        public float CollisionOffset { get; set; }

        [JsonPropertyName("disableWallCheck_")]
        public bool DisableWallCheck { get; set; }

        [JsonPropertyName("canManualLockOn_")]
        public bool CanManualLockOn { get; set; }

        [JsonPropertyName("canLinkTarget_")]
        public bool CanLinkTarget { get; set; }
    }
}
