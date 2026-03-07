using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckCharacterEndFsm : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckCharacterEndFsm);

    [JsonPropertyName("characterIndex_")]
    public int CharacterIndex { get; set; } = 0; // Offset 0x58

    public CheckCharacterEndFsm()
    {
    }
}
