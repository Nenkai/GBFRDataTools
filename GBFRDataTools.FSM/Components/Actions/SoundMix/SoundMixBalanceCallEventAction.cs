using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceCallEventAction : ActionComponent
{
    [JsonPropertyName("eventList_")]
    public BindingList<EventInfo> EventList { get; set; } = [];

    public class EventInfo // SoundMixBalanceCallEventAction::EventInfo
    {
        [JsonPropertyName("eventID_")]
        public uint EventID { get; set; } = 0;

        [JsonPropertyName("startDelaySec_")]
        public float StartDelaySec { get; set; } = 0.0f;

        [JsonPropertyName("loopDelaySec_")]
        public float LoopDelaySec { get; set; } = 1.0f;

        [JsonPropertyName("isLoop_")]
        public bool IsLoop { get; set; } = false;

        [JsonPropertyName("isCallAtEnd_")]
        public bool IsCallAtEnd { get; set; } = false;

        [JsonPropertyName("isCancelAtEnd_")]
        public bool IsCancelAtEnd { get; set; } = true;

        [JsonPropertyName("isEnableMusicSync_")]
        public bool IsEnableMusicSync { get; set; } = false;

        [JsonPropertyName("isDisable_")]
        public bool IsDisable { get; set; } = true;
    }
}
