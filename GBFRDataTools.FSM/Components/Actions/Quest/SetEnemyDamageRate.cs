using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetEnemyDamageRate : QuestActionComponent
{
    [JsonPropertyName("damageRates_")]
    public BindingList<float> DamageRates { get; set; } = []; // 5 elems
}
