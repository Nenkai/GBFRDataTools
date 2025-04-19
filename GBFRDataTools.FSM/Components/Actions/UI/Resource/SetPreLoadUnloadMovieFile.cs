using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Resource;

[Description("Preloads/Unloads worldmap_quest_all_1.bk2")]
public class SetPreLoadUnloadMovieFile : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPreLoadUnloadMovieFile);

    [JsonPropertyName("modeEnum_")]
    public EnumString<SetPreLoadUnloadMovieFileMode> ModeEnum { get; set; } // Offset 0x30

    [JsonPropertyName("unload_")]
    public bool Unload { get; set; } = false; // Offset 0x60
}

public enum SetPreLoadUnloadMovieFileMode
{
    QuestWworldMap = 0,
}
