using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AddCurePotionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddCurePotionAction);

    [JsonPropertyName("addCurePotionValue_")]
    public int AddCurePotionValue { get; set; } = 1;
}
