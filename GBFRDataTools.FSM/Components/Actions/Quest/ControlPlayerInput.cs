using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ControlPlayerInput : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlPlayerInput);

    [JsonPropertyName("enableMove_")]
    public bool EnableMove { get; set; } = true;

    [JsonPropertyName("enableAttack_")]
    public bool EnableAttack { get; set; } = true;

    [JsonPropertyName("enableCamera_")]
    public bool EnableCamera { get; set; } = true;

    public override string ToString()
    {
        string str = $"{ComponentName}(move: {EnableMove}, atk: {EnableAttack}, camera: {EnableCamera})";

        return str;
    }
}
