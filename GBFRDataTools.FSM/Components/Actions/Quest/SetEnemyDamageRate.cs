using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetEnemyDamageRate : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetEnemyDamageRate);

    [JsonPropertyName("damageRates_")]
    [Editable(false)]
    public BindingList<float> DamageRates { get; set; } = [.. Enumerable.Repeat(0, 5)]; // Offset 0x48
}
