using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreCreateShotMultipleAction : Em8400ElementCoreCreateShotBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreCreateShotMultipleAction);

    [JsonPropertyName("shotParamList_")]
    public BindingList<Em8400ElementCoreCreateShotParam> ShotParamList { get; set; } = []; // std::vector<BT::Em8400ElementCoreCreateShotParam>

    [JsonPropertyName("isUseOwnerPos_")]
    public bool IsUseOwnerPos { get; set; } = true;

    [JsonPropertyName("isUseOwnerRotY_")]
    public bool IsUseOwnerRotY { get; set; } = true;

    [JsonPropertyName("isUseOwnerScale_")]
    public bool IsUseOwnerScale { get; set; } = false;

    [JsonPropertyName("isUseOwnerParts_")]
    public bool IsUseOwnerParts { get; set; } = false;

    [JsonPropertyName("ownerPratsNo_")]
    public int OwnerPratsNo { get; set; } = -1;

    [JsonPropertyName("isUseShotIndex_")]
    public bool IsUseShotIndex { get; set; } = false;

    public class Em8400ElementCoreCreateShotParam
    {
        [JsonPropertyName("shotSlot_")]
        public int ShotSlot { get; set; } = 0;

        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; } = 0f;

        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("offsetRotY_")]
        public float OffsetRotY { get; set; } = 0f;

        [JsonPropertyName("createShotOffsetRot_")]
        public Vector4 CreateShotOffsetRot { get; set; } = Vector4.UnitW;

        [JsonPropertyName("userCustomType_")]
        public int UserCustomType { get; set; } = 0;
    }
}
