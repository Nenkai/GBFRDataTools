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

public class Em7200RushWithWindAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200RushWithWindAction);

    [JsonPropertyName("moveNum_")]
    public int MoveNum { get; set; } = 4; // Offset 0x1EC

    [JsonPropertyName("moveInfoNum_")]
    public int MoveInfoNum { get; set; } = 10; // Offset 0x1F0

    [JsonPropertyName("moveSpd_")]
    public float MoveSpd { get; set; } = 60f; // Offset 0x1F4

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 4.5f; // Offset 0x1F8

    [JsonPropertyName("outMinDistance_")]
    public float OutMinDistance { get; set; } = 4f; // Offset 0x1FC

    [JsonPropertyName("goalMinDistance_")]
    public float GoalMinDistance { get; set; } = 1f; // Offset 0x200

    [JsonPropertyName("pathSize_")]
    public float PathSize { get; set; } = 4f; // Offset 0x204

    [JsonPropertyName("moveHeight1st_")]
    public float MoveHeight1st { get; set; } = 50f; // Offset 0x208

    [JsonPropertyName("moveHeight1stRate_")]
    public float MoveHeight1stRate { get; set; } = 1.4f; // Offset 0x20C

    [JsonPropertyName("changeTargetTurnRate_")]
    public float ChangeTargetTurnRate { get; set; } = 0.3f; // Offset 0x210

    [JsonPropertyName("loopRoundGoalTurnRate_")]
    public float LoopRoundGoalTurnRate { get; set; } = 0.65f; // Offset 0x214

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 2.5f; // Offset 0x218

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 2.5f; // Offset 0x21C

    [JsonPropertyName("attackSize_")]
    public float AttackSize { get; set; } = 7f; // Offset 0x220

    [JsonPropertyName("windAttackSize_")]
    public float WindAttackSize { get; set; } = 6f; // Offset 0x224

    [JsonPropertyName("windAttackOffset_")]
    public Vector4 WindAttackOffset { get; set; } = new Vector4(0f, 1.8f, -4f, 1f); // Offset 0x230

    [JsonPropertyName("eventMoveSpd_")]
    public float EventMoveSpd { get; set; } = 30f; // Offset 0x240

    [JsonPropertyName("eventOutMinDistance_")]
    public float EventOutMinDistance { get; set; } = 16f; // Offset 0x244

    [JsonPropertyName("eventFSMId_")]
    public string EventFSMId { get; set; } // Offset 0x248

    [JsonPropertyName("eventDamageMotionId_")]
    public string EventDamageMotionId { get; set; } // Offset 0x268

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x2B0

    [JsonPropertyName("skillText_")]
    public string SkillText { get; set; } // Offset 0x288

    [JsonPropertyName("loopScenarioMotionId_")]
    public string LoopScenarioMotionId { get; set; } // Offset 0x2D0

    [JsonPropertyName("loopQuestMotionId_")]
    public string LoopQuestMotionId { get; set; } // Offset 0x2F0

    [JsonPropertyName("goalPos_")]
    public Vector4 GoalPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x310

    [JsonPropertyName("moveTargetInfoArray_")]
    [Editable(false)]
    public BindingList<MoveTargetInfo> MoveTargetInfoArray { get; set; } = [.. Enumerable.Repeat(new MoveTargetInfo(), 21)]; // Offset 0x320

    [JsonPropertyName("attackOffset_")]
    public Vector4 AttackOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x5C0

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x5D0

    public Em7200RushWithWindAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MoveTargetInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public MoveTargetInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("galeSignTime_")]
        public float GaleSignTime { get; set; } // Offset 0x10

        [JsonPropertyName("galeRadius_")]
        public float GaleRadius { get; set; } // Offset 0xC

        [JsonPropertyName("galeNum_")]
        public int GaleNum { get; set; } // Offset 0x8

        [JsonPropertyName("galeLifeTime_")]
        public float GaleLifeTime { get; set; } // Offset 0x14

        [JsonPropertyName("galeMinDist_")]
        public float GaleMinDist { get; set; } // Offset 0x18

        [JsonPropertyName("galeInterval_")]
        public float GaleInterval { get; set; } // Offset 0x1C

        public DependAILevelParam()
        {
        }
    }
}




