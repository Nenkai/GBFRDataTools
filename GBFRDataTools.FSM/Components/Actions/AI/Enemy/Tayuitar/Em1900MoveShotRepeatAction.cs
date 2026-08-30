using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em1900MoveShotRepeatAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900MoveShotRepeatAction);

    [JsonPropertyName("shotWaitSec_")]
    public float ShotWaitSec { get; set; } = 1f;

    [JsonPropertyName("shotAttackSec_")]
    public float ShotAttackSec { get; set; } = 2f;

    [JsonPropertyName("shotRepeatMax_")]
    public int ShotRepeatMax { get; set; } = 3;

    [JsonPropertyName("bodyPartsCtrlAngleWidth_")]
    public float BodyPartsCtrlAngleWidth { get; set; } = 1.5707964f;

    [JsonPropertyName("rightArmPartsCtrlAngleWidth_")]
    public float RightArmPartsCtrlAngleWidth { get; set; } = 0.6981317f;

    [JsonPropertyName("leftArmPartsCtrlAngleWidth_")]
    public float LeftArmPartsCtrlAngleWidth { get; set; } = 0.6981317f;

    [JsonPropertyName("missileLoopSec_")]
    public float MissileLoopSec { get; set; } = 10f;
}