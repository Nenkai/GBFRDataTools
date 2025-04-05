using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001WideAreaAttackCameraAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001WideAreaAttackCameraAction);

    [JsonPropertyName("isSetEnable_")]
    public bool IsSetEnable { get; set; } = true;
}
