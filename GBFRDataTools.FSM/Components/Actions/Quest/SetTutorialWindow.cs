using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetTutorialWindow : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetTutorialWindow);

    [JsonPropertyName("windowID_")]
    public string WindowID { get; set; } = string.Empty;

    [JsonPropertyName("displayAlsoInNetworkPlay_")]
    public bool DisplayAlsoInNetworkPlay { get; set; } = false;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("repeat_")]
    public bool Repeat { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}('{WindowID}', displayAlsoInNetworkPlay: {DisplayAlsoInNetworkPlay})";

        return str;
    }
}
