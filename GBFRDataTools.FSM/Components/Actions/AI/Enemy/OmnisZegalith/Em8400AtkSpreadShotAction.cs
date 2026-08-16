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
public class Em8400AtkSpreadShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkSpreadShotAction);

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 3;

    [JsonPropertyName("bulletsPerShot_")]
    public int BulletsPerShot { get; set; } = 2;

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 20;

    [JsonPropertyName("shotPosOffset_")]
    public Vector4 ShotPosOffset { get; set; } = new Vector4(0f, 5f, 5f, 1f);

    [JsonPropertyName("fsmNameSpread_")]
    public string FsmNameSpread { get; set; } = "shot_before_split";

    [JsonPropertyName("fsmNameBeforeSpread_")]
    public string FsmNameBeforeSpread { get; set; } = "shot_split";

    [JsonPropertyName("spreadRandomRotParam_")]
    public BindingList<SpreadRandomParameter> SpreadRandomRotParam { get; set; } = [.. Enumerable.Repeat(new SpreadRandomParameter(), 2)]; // std::array<BT::Em8400AtkSpreadShotAction::SpreadRandomParameter,2>

    public class SpreadRandomParameter /* Em8400AtkSpreadShotAction::SpreadRandomParameter */
    {
        [JsonPropertyName("randMin_")]
        public int RandMin { get; set; }
    
        [JsonPropertyName("randMax_")]
        public int RandMax { get; set; }
    
        [JsonPropertyName("stepValue_")]
        public float StepValue { get; set; }
    }
}
