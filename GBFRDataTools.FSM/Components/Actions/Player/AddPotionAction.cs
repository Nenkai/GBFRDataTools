using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AddPotionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddPotionAction);

    [JsonPropertyName("potionType_")]
    public PotionType_ PotionType { get; set; } = 0;

    [JsonPropertyName("addPotionValue_")]
    public int AddPotionValue { get; set; } = 1;

    public enum PotionType_
    {
        GreenPotion = 0,
        MegaPotion = 1,
        RevivePotion = 2,
        BluePotion = 3,
    }
}
