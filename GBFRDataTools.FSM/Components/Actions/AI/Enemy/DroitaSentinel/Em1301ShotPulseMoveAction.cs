using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.DroitaSentinel;

public class Em1301ShotPulseMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301ShotPulseMoveAction);

    [JsonPropertyName("pulseAdjustY_")]
    public float PulseAdjustY { get; set; }

    [JsonPropertyName("floorCheckHeightHalf_")]
    public float FloorCheckHeightHalf { get; set; }

    [JsonPropertyName("moveLimitFloorAngle_")]
    public float MoveLimitFloorAngle { get; set; }
}
