using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201ExSpecialArtsFinishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExSpecialArtsFinishAction);

    [JsonPropertyName("shotOffset_")]
    public Vector4 ShotOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x170

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x78

    [JsonPropertyName("stormUse_")]
    public bool StormUse { get; set; } = false; // Offset 0x180

    [JsonPropertyName("stormSetPositions_")]
    public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = []; // Offset 0x188

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; // Offset 0x1A0

    [JsonPropertyName("stageBaseMoveSpd_")]
    public float StageBaseMoveSpd { get; set; } = 15f; // Offset 0x1A4

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x1A8

    [JsonPropertyName("endMotionId_")]
    public string EndMotionId { get; set; } // Offset 0x1C8

    public Em7201ExSpecialArtsFinishAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10
    }


    public class DependAILevelParam
    {
        [JsonPropertyName("shotCount_")]
        public int ShotCount { get; set; } // Offset 0x8

        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } // Offset 0xC

        [JsonPropertyName("shotLifeTime_")]
        public float ShotLifeTime { get; set; } // Offset 0x10

        [JsonPropertyName("galeToOutsideAddSpd_")]
        public float GaleToOutsideAddSpd { get; set; } // Offset 0x14

        [JsonPropertyName("galeToOutsideDist_")]
        public float GaleToOutsideDist { get; set; } // Offset 0x18

        [JsonPropertyName("galeToOutsideTime_")]
        public float GaleToOutsideTime { get; set; } // Offset 0x1C

        [JsonPropertyName("galeToSelfAddSpd_")]
        public float GaleToSelfAddSpd { get; set; } // Offset 0x20

        [JsonPropertyName("galeToSelfDist_")]
        public float GaleToSelfDist { get; set; } // Offset 0x24

        [JsonPropertyName("galeToSelfTime_")]
        public float GaleToSelfTime { get; set; } // Offset 0x28
    }
}

