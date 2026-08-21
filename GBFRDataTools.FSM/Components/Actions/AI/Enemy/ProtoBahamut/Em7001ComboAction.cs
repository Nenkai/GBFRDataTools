using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001ComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ComboAction);

    [JsonPropertyName("timing_")]
    public int Timing { get; set; } = 0; 

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; 

    [JsonPropertyName("motionIdName_")]
    public string? MotionIdName { get; set; } 

    [JsonPropertyName("isCancel_")]
    public bool IsCancel { get; set; } = true; 

    [JsonPropertyName("isCancelCheckAttackArea_")]
    public bool IsCancelCheckAttackArea { get; set; } = false; 

    [JsonPropertyName("isCancelDecrementAction_")]
    public bool IsCancelDecrementAction { get; set; } = false; 

    [JsonPropertyName("attackAreaIndex_")]
    public int AttackAreaIndex { get; set; } = 0; 

    [JsonPropertyName("isShotLightBullet_")]
    public bool IsShotLightBullet { get; set; } = false; 

    [JsonPropertyName("lightBulletType_")]
    public int LightBulletType { get; set; } = 0; 

    [JsonPropertyName("isEtherCannonSwitch_")]
    public bool IsEtherCannonSwitch { get; set; } = false; 
}

