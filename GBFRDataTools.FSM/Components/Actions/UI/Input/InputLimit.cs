using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace GBFRDataTools.FSM.Components.Actions.UI.Input;

public class InputLimit : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(InputLimit);

    [JsonPropertyName("limits_")]
    [Editable(false)]
    public BindingList<bool> Limits { get; set; } = [.. Enumerable.Repeat(false, 18).ToList()]; // Offset 0x30 - std::array<bool, 18>

    public InputLimit()
    {
    }
}
