using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300TransformAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300TransformAction);

    [JsonPropertyName("isChangeWingMode_")]
    public bool IsChangeWingMode { get; set; } = false;

    [JsonPropertyName("playerSetPositions_")]
    public BindingList<PlayerSetPosInfo> PlayerSetPositions { get; set; }

    public class PlayerSetPosInfo /* Em8300TransformAction::PlayerSetPosInfo */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    }
}
