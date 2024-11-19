using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcJumpAction : BehaviorJumpAction
{
    [JsonPropertyName("secondFromLandToEnd_")]
    public float SecondFromLandToEnd { get; set; }

    [JsonPropertyName("rotateToLangPos_")]
    public bool RotateToLangPos { get; set; }
}
