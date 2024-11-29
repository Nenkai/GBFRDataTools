using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallIslandMoveAction : QuestActionComponent
{
    [JsonPropertyName("moveAnimType_")]
    public int MoveAnimType { get; set; } = 0;
}
