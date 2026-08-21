using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceSetStateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceSetStateAction);

    [JsonPropertyName("stateList_")]
    public BindingList<StateInfo> StateList { get; set; } = [];

    public override string? GetCaption()
    {
        return $"{StateList.Count} state(s)";
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StateInfo // SoundMixBalanceSetStateAction::StateInfo
    {
        [JsonPropertyName("groupID_")]
        public uint GroupID { get; set; } = 0;

        [JsonPropertyName("stateID_")]
        public uint StateID { get; set; } = 0;

        [JsonPropertyName("isSetAtEnd_")]
        public bool IsSetAtEnd { get; set; } = false;

        [JsonPropertyName("isDisable_")]
        public bool IsDisable { get; set; } = false;
    }
}
