using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600CauseTornadoAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600CauseTornadoAction);

    [JsonPropertyName("turningSpeed_")]
    public float TurningSpeed { get; set; } = 1f; 

    [JsonPropertyName("maxTurningAngle_")]
    public float MaxTurningAngle { get; set; } = 45f; 

    [JsonPropertyName("offsetPos_")]
    [Editable(false)]
    public BindingList<Vector4> OffsetPos { get; set; } = [.. Enumerable.Repeat(new Vector4(), 3)]; 

    [JsonPropertyName("shotRotY_")]
    [Editable(false)]
    public BindingList<float> ShotRotY { get; set; } = [.. Enumerable.Repeat(0, 3)]; 
}
