using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Skeleton;

public class Em0102StepSlashAttackAction : ActionComponent
{
    [JsonPropertyName("stepDir_")]
    public int StepDir { get; set; }
}
