using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Party;

public class PushPartyKeep : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PushPartyKeep);

    [JsonPropertyName("modeEnum_")]
    public EnumString<PushPartyKeepMode> ModeEnum { get; set; } = new();
}

public enum PushPartyKeepMode
{
    Normal = 0,
    Formation = 1,
}