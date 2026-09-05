using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable.")]
public class Em0006OverDriveAttackTypeSet : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0006OverDriveAttackTypeSet);

    [JsonPropertyName("valueMin_")]
    public int ValueMin { get; set; }

    [JsonPropertyName("valueMax_")]
    public int ValueMax { get; set; }
}