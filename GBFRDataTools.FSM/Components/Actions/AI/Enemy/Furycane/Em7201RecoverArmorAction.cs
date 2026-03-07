using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201RecoverArmorAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201RecoverArmorAction);

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x30

    public Em7201RecoverArmorAction()
    {
    }
}





