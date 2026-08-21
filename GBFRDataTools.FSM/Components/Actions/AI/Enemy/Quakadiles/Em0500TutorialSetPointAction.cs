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

public class Em0500TutorialSetPointAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500TutorialSetPointAction);

    [JsonPropertyName("set_")]
    public bool Set { get; set; } = false; 

    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; } = Vector4.UnitW; 
}