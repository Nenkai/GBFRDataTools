using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806SchwarzSchildAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806SchwarzSchildAction);

    [JsonPropertyName("isUseOd2Param_")]
    public bool IsUseOd2Param { get; set; } = false; // Offset 0xD0

    [JsonPropertyName("isUseChaseMagicCircle_")]
    public bool IsUseChaseMagicCircle { get; set; } = false; // Offset 0xD1

    public Em1806SchwarzSchildAction()
    {
    }
}