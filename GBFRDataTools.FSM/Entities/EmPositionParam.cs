using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

public class EmPositionParam
{
    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; }
}
