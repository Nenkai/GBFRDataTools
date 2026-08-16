using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100SpArtsMotionParam;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkShotAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkShotAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("shotParams_")]
    public BindingList<ShotParam> ShotParams { get; set; } = []; // std::vector<BT::Em8300AtkShotAction::ShotParam>

    [JsonPropertyName("isEndClearShot_")]
    public bool IsEndClearShot { get; set; } = false;

    public class ShotParam /* Em8300AtkShotAction::ShotParam */
    {
        [JsonPropertyName("fsmName_")]
        public string FsmName { get; set; }
    
        [JsonPropertyName("shotType_")]
        public int ShotType { get; set; }
    
        [JsonPropertyName("shotTime_")]
        public float ShotTime { get; set; }
    
        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; }
    }
}