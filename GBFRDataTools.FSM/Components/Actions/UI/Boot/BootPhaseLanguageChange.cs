using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Boot;

public class BootPhaseLanguageChange : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootPhaseLanguageChange);

    [JsonPropertyName("languageChange_")]
    public bool LanguageChange { get; set; } = false;
}
