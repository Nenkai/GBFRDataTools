using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200AtkComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkComboAction);

    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0;

    [JsonPropertyName("isAlone_")]
    public bool IsAlone { get; set; } = false;
}

