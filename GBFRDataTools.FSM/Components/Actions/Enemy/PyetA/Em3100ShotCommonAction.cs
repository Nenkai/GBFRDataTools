using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.PyetA;

public class Em3100ShotCommonAction : ActionComponent
{
    [JsonPropertyName("shotType_")]
    public int ShotType { get; set; } = 0;
}
