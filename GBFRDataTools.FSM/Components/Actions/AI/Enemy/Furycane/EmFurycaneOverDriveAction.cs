using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class EmFurycaneOverDriveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFurycaneOverDriveAction);

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x50

    public EmFurycaneOverDriveAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("animRateOD_")]
        public float AnimRateOD { get; set; } // Offset 0x8

        public DependAILevelParam()
        {
        }
    }
}





