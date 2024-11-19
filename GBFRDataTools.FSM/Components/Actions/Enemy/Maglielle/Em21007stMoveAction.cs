using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Maglielle;

public class Em21007stMoveAction : ActionComponent
{
    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; }
}