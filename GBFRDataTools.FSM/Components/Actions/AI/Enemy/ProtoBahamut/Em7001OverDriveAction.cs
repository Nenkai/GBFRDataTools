using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001OverDriveAction : EmBossOverDriveAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001OverDriveAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x54

    [JsonPropertyName("isRide_")]
    public bool IsRide { get; set; } = false; // Offset 0x58

    [JsonPropertyName("idlePosType_")]
    public int IdlePosType { get; set; } = 0; // Offset 0x50

    public Em7001OverDriveAction()
    {
    }
}
