using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class EmCultSoldierLeaderEmberComboAction : EmCultSoldierBaseComboAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCultSoldierLeaderEmberComboAction);

    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0; // Offset 0x70

    public EmCultSoldierLeaderEmberComboAction()
    {
    }
}