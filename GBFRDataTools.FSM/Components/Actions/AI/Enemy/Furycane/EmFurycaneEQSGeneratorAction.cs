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

public class EmFurycaneEQSGeneratorAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFurycaneEQSGeneratorAction);

    [JsonPropertyName("centerPattern_")]
    public int CenterPattern { get; set; } = 0; 

    [JsonPropertyName("eqsItemRandomRange_")]
    public float EqsItemRandomRange { get; set; } = 0f; 

    [JsonPropertyName("eqsItemArray_")]
    public BindingList<EQSItemPosition> EqsItemArray { get; set; } = []; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EQSItemPosition
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }
}