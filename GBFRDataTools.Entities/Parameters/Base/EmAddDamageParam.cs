using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmAddDamageParam
{
    [JsonPropertyName("playInfoList_")]
    public /* PlayInfoVector */ BindingList<PlayInfo> PlayInfoList { get; set; } = [];

    public class PlayInfo // EmAddDamageParam::PlayInfo
    {
        [JsonPropertyName("motionName_")]
        public string MotionName { get; set; }

        [JsonPropertyName("damageWorkUniqueId_")]
        public int DamageWorkUniqueId { get; set; }

        [JsonPropertyName("slotNumber_")]
        public int SlotNumber { get; set; }

        [JsonPropertyName("weight_")]
        public float Weight { get; set; }
    }
}
