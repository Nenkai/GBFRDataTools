using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetIsOpenPauseMenu : QuestActionComponent
{
    [JsonPropertyName("enableOpenFlag_")]
    public bool EnableOpenFlag { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}(flag: {EnableOpenFlag})";

        return str;
    }
}
