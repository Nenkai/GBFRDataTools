using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DisplayStaff : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DisplayStaff);

    [JsonPropertyName("id_")]
    public string Id { get; set; } // Offset 0x48

    public DisplayStaff()
    {
    }
}
