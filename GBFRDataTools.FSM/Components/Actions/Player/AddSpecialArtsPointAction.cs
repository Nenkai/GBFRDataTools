using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.FSM.Components.Actions.Player.AddPotionAction;

namespace GBFRDataTools.FSM.Components.Actions.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AddSpecialArtsPointAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddSpecialArtsPointAction);

    [JsonPropertyName("addSpecialArtsPointValue_")]
    public float AddSpecialArtsPointValue { get; set; } = 10f;

    public override string? GetCaption()
    {
        return $"SBA: {AddSpecialArtsPointValue:F2}";
    }
}
