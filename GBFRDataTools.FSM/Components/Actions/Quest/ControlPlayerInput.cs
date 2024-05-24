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

public class ControlPlayerInput : QuestActionComponent
{
    [JsonPropertyName("enableMove_")]
    public bool EnableMove { get; set; }

    [JsonPropertyName("enableAttack_")]
    public bool EnableAttack { get; set; }

    [JsonPropertyName("enableCamera_")]
    public bool EnableCamera { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}(move: {EnableMove}, atk: {EnableAttack}, camera: {EnableCamera})";

        return str;
    }
}
