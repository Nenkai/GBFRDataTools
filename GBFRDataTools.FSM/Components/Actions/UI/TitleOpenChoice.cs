using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class TitleOpenChoice : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TitleOpenChoice);

    [JsonPropertyName("isPlayInAnime_")]
    public bool IsPlayInAnime { get; set; } = true; // Offset 0x30

    public TitleOpenChoice()
    {
    }
}
