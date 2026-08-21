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
    public int MoveNum { get; set; } = 4; 

    [JsonPropertyName("moveInfoNum_")]
    public int MoveInfoNum { get; set; } = 10; 

    [JsonPropertyName("moveSpd_")]
    public float MoveSpd { get; set; } = 60f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 4.5f; 

    [JsonPropertyName("outMinDistance_")]
    public float OutMinDistance { get; set; } = 4f; 

    [JsonPropertyName("goalMinDistance_")]
    public float GoalMinDistance { get; set; } = 1f; 

    [JsonPropertyName("pathSize_")]
    public float PathSize { get; set; } = 4f; 

    [JsonPropertyName("moveHeight1st_")]
    public float MoveHeight1st { get; set; } = 50f; 

    [JsonPropertyName("moveHeight1stRate_")]
    public float MoveHeight1stRate { get; set; } = 1.4f; 

    [JsonPropertyName("changeTargetTurnRate_")]
    public float ChangeTargetTurnRate { get; set; } = 0.3f; 

    [JsonPropertyName("loopRoundGoalTurnRate_")]
    public float LoopRoundGoalTurnRate { get; set; } = 0.65f; 

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 2.5f; 

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 2.5f; 

    [JsonPropertyName("attackSize_")]
    public float AttackSize { get; set; } = 7f; 

    [JsonPropertyName("windAttackSize_")]
    public float WindAttackSize { get; set; } = 6f; 

    [JsonPropertyName("windAttackOffset_")]
    public Vector4 WindAttackOffset { get; set; } = new Vector4(0f, 1.8f, -4f, 1f); 

    [JsonPropertyName("eventMoveSpd_")]
    public float EventMoveSpd { get; set; } = 30f; 

    [JsonPropertyName("eventOutMinDistance_")]
    public float EventOutMinDistance { get; set; } = 16f;

    [JsonPropertyName("eventFSMId_")]
    public string? EventFSMId { get; set; } = "1st_barrier";

    [JsonPropertyName("eventDamageMotionId_")]
    public string? EventDamageMotionId { get; set; } = "0523";

    [JsonPropertyName("startMotionId_")]
    public string? StartMotionId { get; set; } = "1a50";

    [JsonPropertyName("skillText_")]
    public string? SkillText { get; set; }

    [JsonPropertyName("loopScenarioMotionId_")]
    public string? LoopScenarioMotionId { get; set; } = "700b";

    [JsonPropertyName("loopQuestMotionId_")]
    public string? LoopQuestMotionId { get; set; } = "700a";

    [JsonPropertyName("goalPos_")]
    public Vector4 GoalPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("moveTargetInfoArray_")]
    [Editable(false)]
    public BindingList<MoveTargetInfo> MoveTargetInfoArray { get; set; } = [.. Enumerable.Repeat(new MoveTargetInfo(), 21)]; 

    [JsonPropertyName("attackOffset_")]
    public Vector4 AttackOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MoveTargetInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("galeSignTime_")]
        public float GaleSignTime { get; set; } 

        [JsonPropertyName("galeRadius_")]
        public float GaleRadius { get; set; } 

        [JsonPropertyName("galeNum_")]
        public int GaleNum { get; set; } 

        [JsonPropertyName("galeLifeTime_")]
        public float GaleLifeTime { get; set; } 

        [JsonPropertyName("galeMinDist_")]
        public float GaleMinDist { get; set; } 

        [JsonPropertyName("galeInterval_")]
        public float GaleInterval { get; set; } 
    }
}




