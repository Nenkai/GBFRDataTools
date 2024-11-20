using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.DroitaSentinel;

public class Em1301ElectricFiledAttackSignAction : ActionComponent
{
    [JsonPropertyName("size_")]
    public float Size { get; set; }

    [JsonPropertyName("dispSec_")]
    public float DispSec { get; set; }

    [JsonPropertyName("posOffset_")]
    public cVec4 PosOffset { get; set; }
}
