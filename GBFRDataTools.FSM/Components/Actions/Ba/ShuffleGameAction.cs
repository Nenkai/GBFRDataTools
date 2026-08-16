using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShuffleGameAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShuffleGameAction);

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1f;

    [JsonPropertyName("indexOrderList_")]
    public BindingList<int> IndexOrderList { get; set; } = [.. Enumerable.Repeat(0, 3)];
}