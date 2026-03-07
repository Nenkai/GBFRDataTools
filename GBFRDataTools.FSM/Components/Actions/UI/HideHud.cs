using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class HideHud : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(HideHud);

    [JsonPropertyName("isHideHud_")]
    public bool IsHideHud { get; set; } = false;

    public override string GetCaption()
    {
        return $"Hide: {IsHideHud}";
    }
}
