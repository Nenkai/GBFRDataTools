using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckManualPlayerCharacter : QuestConditionComponent
{
    [JsonPropertyName("objId_")]
    [eObjId]
    public int ObjId { get; set; } = 0;
}
