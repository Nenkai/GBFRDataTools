using GBFRDataTools.FSM.Components.Actions.Battle;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Elemental;

public class Em0902IceShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0902IceShotAction);

    [JsonPropertyName("iceShotParams_")]
    public BindingList<IceShotParam> IceShotParams { get; set; } = []; // Offset 0x38

    [JsonPropertyName("allShotSec_")]
    public float AllShotSec { get; set; } = 0.8f; // Offset 0x50

    [JsonPropertyName("attackSignLength_")]
    public float AttackSignLength { get; set; } = 53f; // Offset 0x54

    public Em0902IceShotAction()
    {
    }

    public class IceShotParam
    {
        [JsonPropertyName("createOffset_")]
        public Vector4 CreateOffset { get; set; } // Offset 0x20

        [JsonPropertyName("shotOffsetWidth_")]
        public float ShotOffsetWidth { get; set; } // Offset 0x30

        [JsonPropertyName("shotOffsetHeight_")]
        public float ShotOffsetHeight { get; set; } // Offset 0x34

        [JsonPropertyName("isShotBlur_")]
        public bool IsShotBlur { get; set; } // Offset 0x38

        [JsonPropertyName("shotRandBlurHeight_")]
        public float ShotRandBlurHeight { get; set; } // Offset 0x3C

        [JsonPropertyName("showParamInfo_")]
        [Obsolete("Not used by the game")]
        [Description("Not used by the game")]
        public bool ShowParamInfo { get; set; }

        public IceShotParam()
        {
        }
    }
}
