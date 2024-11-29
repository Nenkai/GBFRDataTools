using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

public class BootPhaseLanguageChange : ActionComponent
{
    [JsonPropertyName("languageChange_")]
    public bool LanguageChange { get; set; } = false;
}
