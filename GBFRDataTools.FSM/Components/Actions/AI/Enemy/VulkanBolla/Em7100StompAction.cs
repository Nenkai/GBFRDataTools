using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.VulkanBolla;

public class Em7100StompAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100StompAction);

    [JsonPropertyName("comboCountMax_")]
    public int ComboCountMax { get; set; } = 0;

    [JsonPropertyName("isBeginRightAttack_")]
    public bool IsBeginRightAttack { get; set; } = false;

    [JsonPropertyName("startSec_")]
    public float StartSec { get; set; } = -1.0f;

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = -1.0f;

}
