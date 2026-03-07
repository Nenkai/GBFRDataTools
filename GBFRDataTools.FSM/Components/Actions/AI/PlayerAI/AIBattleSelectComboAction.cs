using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Randomly chooses one of the numbers established in a array, or chooses based off of distance conditions")]
public class AIBattleSelectComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleSelectComboAction);

    [JsonPropertyName("playerAICombos_")]
    public BindingList<PlayerAICombo> PlayerAICombos { get; set; } = []; // std::vector<BT::AIBattleSelectComboAction::PlayerAICombo>

    public override string GetCaption()
    {
        return $"{PlayerAICombos.Count} combo(s)";
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlayerAICombo // BT::AIBattleSelectComboAction::PlayerAICombo
    {
        [JsonPropertyName("rangeMax_")]
        public float RangeMax { get; set; } = 0.0f;

        [JsonPropertyName("rangeMin_")]
        public float RangeMin { get; set; } = 0.0f;
    }
}
