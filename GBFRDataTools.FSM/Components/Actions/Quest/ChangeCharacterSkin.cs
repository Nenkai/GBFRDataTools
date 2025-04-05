using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ChangeCharacterSkin : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeCharacterSkin);

    [JsonPropertyName("characterID_")]
    public uint CharacterID { get; set; } = 0;

    [JsonPropertyName("costumeNo_")]
    public int CostumeNo { get; set; } = 0;
}
