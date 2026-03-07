using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class EmCultSoldierBaseAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCultSoldierBaseAppearAction);

    [JsonPropertyName("objHitScaleSec_")]
    public float ObjHitScaleSec { get; set; } = 1f; // Offset 0x98

    [JsonPropertyName("isRight_")]
    public bool IsRight { get; set; } = true; // Offset 0x9C

    public EmCultSoldierBaseAppearAction()
    {
    }
}