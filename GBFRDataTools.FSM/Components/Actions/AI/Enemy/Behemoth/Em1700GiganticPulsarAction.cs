using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700GiganticPulsarAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700GiganticPulsarAction);

    [JsonPropertyName("animMovementRate_")]
    public float AnimMovementRate { get; set; } = 1f;

    [JsonPropertyName("isCreateThunder_")]
    public bool IsCreateThunder { get; set; } = false;

    [JsonPropertyName("isCutMotion_")]
    public bool IsCutMotion { get; set; } = false;

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 3;
}
