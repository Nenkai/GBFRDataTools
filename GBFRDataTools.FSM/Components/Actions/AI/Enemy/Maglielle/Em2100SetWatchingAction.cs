using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SetWatchingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SetWatchingAction);

    [JsonPropertyName("damageEnableParam_")]
    public SettingsParam DamageEnableParam { get; set; } = new(); 

    [JsonPropertyName("objHitEnableParam_")]
    public SettingsParam ObjHitEnableParam { get; set; } = new(); 

    [JsonPropertyName("collisionEnableParam_")]
    public SettingsParam CollisionEnableParam { get; set; } = new(); 

    [JsonPropertyName("lockOnEnableParam_")]
    public SettingsParam LockOnEnableParam { get; set; } = new(); 

    [JsonPropertyName("gravityEnableParam_")]
    public SettingsParam GravityEnableParam { get; set; } = new(); 

    public class SettingsParam
    {
        [JsonPropertyName("use_")]
        public bool Use { get; set; } 

        [JsonPropertyName("enable_")]
        public bool Enable { get; set; } 

        [JsonPropertyName("isSetTimingStart_")]
        public bool IsSetTimingStart { get; set; } 

        [JsonPropertyName("isSetTimingUpdate_")]
        public bool IsSetTimingUpdate { get; set; } 

        [JsonPropertyName("isSetTimingEnd_")]
        public bool IsSetTimingEnd { get; set; } 

        [JsonPropertyName("isUndoEnd_")]
        public bool IsUndoEnd { get; set; } 
    }
}