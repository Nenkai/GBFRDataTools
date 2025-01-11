using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmWeakPointParam
{
    [JsonPropertyName("weakInfoList_")]
    public /* WeakInfoVector*/ BindingList<WeakInfo> WeakInfoList { get; set; }

    public class WeakInfo // EmWeakPointParam::WeakInfo
    {
        [JsonPropertyName("isWeakPoint_")]
        public bool IsWeakPoint { get; set; }

        [JsonPropertyName("hardValue_")]
        public float HardValue { get; set; }

        [JsonPropertyName("damageWorkUniqueId_")]
        public int DamageWorkUniqueId { get; set; }
    }
}
