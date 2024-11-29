using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIBattleSelectComboAction : ActionComponent
{
    [JsonPropertyName("playerAICombos_")]
    public BindingList<PlayerAICombo> PlayerAICombos { get; set; } = [];

    public class PlayerAICombo // BT::AIBattleSelectComboAction::PlayerAICombo
    {
        [JsonPropertyName("rangeMax_")]
        public float RangeMax { get; set; } = 0.0f;

        [JsonPropertyName("rangeMin_")]
        public float RangeMin { get; set; } = 0.0f;

    }
}
