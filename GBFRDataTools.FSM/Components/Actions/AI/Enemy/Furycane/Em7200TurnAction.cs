using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200TurnAction : EmTurnAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200TurnAction);

    [JsonPropertyName("cancelTurnAngle_")]
    public float CancelTurnAngle { get; set; } = 30f; // Offset 0x9C

    [JsonPropertyName("cancelAnim_")]
    public bool CancelAnim { get; set; } = false; // Offset 0xA0

    public Em7200TurnAction()
    {
    }
}




