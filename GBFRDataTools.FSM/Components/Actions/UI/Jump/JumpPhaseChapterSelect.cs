using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Jump;

public class JumpPhaseChapterSelect : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(JumpPhaseChapterSelect);

    [JsonPropertyName("restert_")]
    public bool Restert { get; set; } = false; // Offset 0x30
}
