﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class AIEm7001ShakeGroundAction : ActionComponent
{
    [Obsolete("Not used by the game")]
    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }
}