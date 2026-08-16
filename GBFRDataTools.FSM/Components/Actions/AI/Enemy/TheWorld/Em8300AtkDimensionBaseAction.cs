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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkDimensionBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkDimensionBaseAction);

    [JsonPropertyName("dimensionInfo_")]
    public BindingList<DimensionInfo_> DimensionInfo { get; set; } = []; // std::vector<BT::Em8300AtkDimensionBaseAction::DimensionInfo>

    [JsonPropertyName("dimensionType_")]
    public int DimensionType { get; set; } = 0;

    public class DimensionInfo_ /* Em8300AtkDimensionBaseAction::DimensionInfo */
    {
        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } // Offset 0x10
    
        [JsonPropertyName("rotY_")]
        public float RotY { get; set; } // Offset 0x20
    
        [JsonPropertyName("shotType_")]
        public int ShotType { get; set; } // Offset 0x24
    
        [JsonPropertyName("baseType_")]
        public int BaseType { get; set; } // Offset 0x28
    }
}