using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0502MagmaVomit : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0502MagmaVomit);

    [JsonPropertyName("shotNumStart_")]
    public int ShotNumStart { get; set; } = 3; 

    [JsonPropertyName("shotNumAfterOD1st_")]
    public int ShotNumAfterOD1st { get; set; } = 4; 

    [JsonPropertyName("shotNumAfterOD2nd_")]
    public int ShotNumAfterOD2nd { get; set; } = 5; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 2f; 
}