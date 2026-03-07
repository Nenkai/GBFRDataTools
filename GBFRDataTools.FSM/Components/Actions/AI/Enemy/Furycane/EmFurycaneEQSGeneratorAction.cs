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
    public int CenterPattern { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("eqsItemRandomRange_")]
    public float EqsItemRandomRange { get; set; } = 0f; // Offset 0x34

    [JsonPropertyName("eqsItemArray_")]
    public BindingList<EQSItemPosition> EqsItemArray { get; set; } = []; // Offset 0x38

    public EmFurycaneEQSGeneratorAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EQSItemPosition
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public EQSItemPosition()
        {
        }
    }
}