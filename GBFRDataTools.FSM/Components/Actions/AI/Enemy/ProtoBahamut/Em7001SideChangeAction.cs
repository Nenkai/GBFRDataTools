using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SideChangeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SideChangeAction);

    [JsonPropertyName("startPosType_")]
    public int StartPosType { get; set; } = 0; 

    [JsonPropertyName("endPosType_")]
    public int EndPosType { get; set; } = 0; 

    [JsonPropertyName("motionIdName_")]
    public string? MotionIdName { get; set; } 

    [JsonPropertyName("sideChangeLightBulletType_")]
    public int SideChangeLightBulletType { get; set; } = 0; 

    [JsonPropertyName("isSetInitPos_")]
    public bool IsSetInitPos { get; set; } = true; 
}
