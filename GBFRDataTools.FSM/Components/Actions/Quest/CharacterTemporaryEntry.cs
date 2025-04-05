using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CharacterTemporaryEntry : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CharacterTemporaryEntry);

    [JsonPropertyName("characterID_")]
    public uint CharacterID { get; set; }

    [JsonPropertyName("parameterID_")]
    public int ParameterID { get; set; }
}
