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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkBuffModeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkBuffModeAction);

    [JsonPropertyName("isAttackBuff_")]
    public bool IsAttackBuff { get; set; } = true; // Offset 0x70

    [JsonPropertyName("buffParam_")]
    public BindingList<BuffParam> BuffParam_ { get; set; } = []; // Offset 0x78

    public Em7700AtkBuffModeAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BuffParam
    {
        [JsonPropertyName("use_")]
        public bool Use { get; set; }

        [JsonPropertyName("time_")]
        public float Time { get; set; }

        [JsonPropertyName("rate_")]
        public float Rate { get; set; }

    }
}


