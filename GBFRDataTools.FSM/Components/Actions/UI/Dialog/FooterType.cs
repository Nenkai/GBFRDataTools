using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

[Description("Note: Seems to use PauseFooter")]
public class FooterType : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FooterType);

    [JsonPropertyName("type_")]
    public EnumString<FooterTypeEnum> Type { get; set; } = new();

    public override string GetCaption()
    {
        return Utils.GetEnumDescription(Type.Index);
    }
}

public enum FooterTypeEnum
{
    MainMenu = 0,
    Entrance = 1,
    TrialBattle = 2,
    Note = 4,
    QuestCounter = 5,
    FateEpisode = 6,
    Title = 7,
    Shop = 8,
    Setup = 9,
    Blacksmith = 10,
}
