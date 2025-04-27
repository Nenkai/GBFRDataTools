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
    public SettingsParam DamageEnableParam { get; set; } = new(); // Offset 0x30

    [JsonPropertyName("objHitEnableParam_")]
    public SettingsParam ObjHitEnableParam { get; set; } = new(); // Offset 0x40

    [JsonPropertyName("collisionEnableParam_")]
    public SettingsParam CollisionEnableParam { get; set; } = new(); // Offset 0x50

    [JsonPropertyName("lockOnEnableParam_")]
    public SettingsParam LockOnEnableParam { get; set; } = new(); // Offset 0x60

    [JsonPropertyName("gravityEnableParam_")]
    public SettingsParam GravityEnableParam { get; set; } = new(); // Offset 0x70

    public Em2100SetWatchingAction()
    {
    }

    public class SettingsParam
    {
        [JsonPropertyName("use_")]
        public bool Use { get; set; } // Offset 0x8

        [JsonPropertyName("enable_")]
        public bool Enable { get; set; } // Offset 0x9

        [JsonPropertyName("isSetTimingStart_")]
        public bool IsSetTimingStart { get; set; } // Offset 0xA

        [JsonPropertyName("isSetTimingUpdate_")]
        public bool IsSetTimingUpdate { get; set; } // Offset 0xB

        [JsonPropertyName("isSetTimingEnd_")]
        public bool IsSetTimingEnd { get; set; } // Offset 0xC

        [JsonPropertyName("isUndoEnd_")]
        public bool IsUndoEnd { get; set; } // Offset 0xD

        public SettingsParam()
        {
        }
    }
}