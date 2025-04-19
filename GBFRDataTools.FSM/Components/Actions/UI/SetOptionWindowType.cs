using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

[Description("""
    Unknown.
    Returns events:
    - ToNext - Ok
    """)]
public class SetOptionWindowType : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetOptionWindowType);

    [JsonPropertyName("type_")]
    public EnumString<SetOptionWindowTypeEnum> Type { get; set; } = new();
}

public enum SetOptionWindowTypeEnum
{
    Language = 0,
    InitialAudio = 1,
    PlayerSession = 2,
    ShortcutPlayerSession = 3,
    GameSession = 4,
    InvitePlayerSession = 5,
    Type6 = 6,
    SearchLobby = 7,
    Type8 = 8,
    EnvironmentalSetting = 9,
    Type10 = 10,
}