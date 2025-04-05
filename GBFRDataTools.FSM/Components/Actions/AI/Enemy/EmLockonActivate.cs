using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmLockonActivate : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLockonActivate);

    [JsonPropertyName("activateTiming_")]
    public int ActivateTiming { get; set; } = 0;

    [JsonPropertyName("isActivate_")]
    public bool IsActivate { get; set; } = false;

    [JsonPropertyName("isCheckAttachWeapon_")]
    public bool IsCheckAttachWeapon { get; set; } = false;
}
