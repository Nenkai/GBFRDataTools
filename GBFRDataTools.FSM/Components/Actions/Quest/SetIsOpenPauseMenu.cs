using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetIsOpenPauseMenu : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetIsOpenPauseMenu);

    [JsonPropertyName("enableOpenFlag_")]
    public bool EnableOpenFlag { get; set; } = false;

    public override string GetCaption()
    {
        return $"EnableOpen: {EnableOpenFlag}";
    }
}
