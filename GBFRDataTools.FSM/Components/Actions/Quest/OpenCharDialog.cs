using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class OpenCharDialog : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenCharDialog);

    [JsonPropertyName("dialogId_")]
    public string? DialogId { get; set; } 

    [JsonPropertyName("textId_")]
    public string? TextId { get; set; }

    [JsonPropertyName("charId_")]
    public EnumString<OpenCharDialogType> CharId { get; set; } = new();

    [JsonPropertyName("checkAtClose_")]
    public bool CheckAtClose { get; set; } = false;

    public override string? GetCaption()
    {
        return $"DialogId: {DialogId}";
    }

    public enum OpenCharDialogType
    {
        PL0000, // 2A26B1B2
        PL0100, // A4ACBA76 
        PL0200, // 18E2F9F9 
        PL0300, // 79DF0CCh 
        PL0400, // 4D0A60C3
        PL0500, // DD7A151E
        PL0600, // C8616284
        PL0700, // C3FFD418 
        PL0800, // 22E437E5 
        PL0900, // 2EBE91D5
        PL1000, // BDEF7181 
        PL1100, // 627BCB0D
        PL1200, // FD3BE362
        PL1300, // FC6CDF7B
        PL1400, // E7053919
        PL1500, // 978E4B18 
        PL1600, // 0D21B430
        PL1700, // F0EB77EF
        PL1800, // AA66178A
        PL1900, // A3A3CB2F
        NP0000, // 3529CC90
        NP0300, // 28A87C8A
    }
}
