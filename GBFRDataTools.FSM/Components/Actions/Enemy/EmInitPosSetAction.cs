using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmInitPosSetAction : ActionComponent
{
    [JsonPropertyName("initPos_")]
    public cVec4 InitPos { get; set; }

    [JsonPropertyName("initRotDegY_")]
    public float InitRotDegY { get; set; }
}
