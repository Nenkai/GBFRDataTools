using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetDrawWorldMapIslandInfo : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDrawWorldMapIslandInfo);

    [JsonPropertyName("draw_")]
    public bool Draw { get; set; } = true; // Offset 0x30

    public SetDrawWorldMapIslandInfo()
    {
    }
}
