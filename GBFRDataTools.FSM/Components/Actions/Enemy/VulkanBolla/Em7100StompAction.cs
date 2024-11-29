using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.VulkanBolla;

public class Em7100StompAction : EmDamageMotionPlayAction
{
    [JsonPropertyName("comboCountMax_")]
    public int ComboCountMax { get; set; } = 0;

    [JsonPropertyName("isBeginRightAttack_")]
    public bool IsBeginRightAttack { get; set; } = false;

    [JsonPropertyName("startSec_")]
    public float StartSec { get; set; } = -1.0f;

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = -1.0f;

}
