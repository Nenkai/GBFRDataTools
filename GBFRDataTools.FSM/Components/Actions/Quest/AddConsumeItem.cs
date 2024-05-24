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

public class AddConsumeItem : QuestActionComponent
{
    [JsonPropertyName("curePortion_")]
    public int CurePortion { get; set; }

    [JsonPropertyName("megaPortion_")]
    public int MegaPortion { get; set; }

    [JsonPropertyName("allPortion_")]
    public int AllPortion { get; set; }

    [JsonPropertyName("resuscitationPortion_")]
    public int ResuscitationPortion { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
