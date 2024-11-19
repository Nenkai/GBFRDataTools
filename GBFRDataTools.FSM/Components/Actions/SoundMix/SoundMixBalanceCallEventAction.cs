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
    public BindingList<EventInfo> EventList { get; set; }

    public class EventInfo // SoundMixBalanceCallEventAction::EventInfo
    {
        [JsonPropertyName("eventID_")]
        public uint EventID { get; set; }

        [JsonPropertyName("startDelaySec_")]
        public float StartDelaySec { get; set; }

        [JsonPropertyName("loopDelaySec_")]
        public float LoopDelaySec { get; set; }

        [JsonPropertyName("isLoop_")]
        public bool IsLoop { get; set; }

        [JsonPropertyName("isCallAtEnd_")]
        public bool IsCallAtEnd { get; set; }

        [JsonPropertyName("isCancelAtEnd_")]
        public bool IsCancelAtEnd { get; set; }

        [JsonPropertyName("isEnableMusicSync_")]
        public bool IsEnableMusicSync { get; set; }

        [JsonPropertyName("isDisable_")]
        public bool IsDisable { get; set; }
    }
}
