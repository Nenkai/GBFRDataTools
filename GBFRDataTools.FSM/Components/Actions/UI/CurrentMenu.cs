using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class CurrentMenu : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CurrentMenu);

    [JsonPropertyName("menuID_")]
    public string MenuID { get; set; } = string.Empty;

    [JsonPropertyName("title_")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("info_")]
    public string Info { get; set; } = string.Empty;

    [JsonPropertyName("setCachedHeader_")]
    public bool SetCachedHeader { get; set; } = false;

    [JsonPropertyName("type_")]
    public EnumString<CurrentMenuType> Type { get; set; } = new();

    public override string GetCaption()
    {
        string str = string.Empty;
        if (!string.IsNullOrEmpty(MenuID))
            str += $"Id: {MenuID}\n";

        if (!string.IsNullOrEmpty(Title))
            str += $"Title: {Title}\n";

        if (!string.IsNullOrEmpty(Info))
            str += $"Info: {Info}";
        return str;
    }
}

public enum CurrentMenuType
{
    TrialMenu = 0,
    QuestCounterMenu = 1,
}