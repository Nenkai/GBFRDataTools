using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

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
public class Em8200AtkChaosCaliburAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkChaosCaliburAction);

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("chaosCaliburType_")]
    public int ChaosCaliburType { get; set; } = 0;
}