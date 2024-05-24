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

public class CharacterTemporaryEntry : QuestActionComponent
{
    [JsonPropertyName("characterID_")]
    public uint CharacterID { get; set; }

    [JsonPropertyName("parameterID_")]
    public int ParameterID { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
