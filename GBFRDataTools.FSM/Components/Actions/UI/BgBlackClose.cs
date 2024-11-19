using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class BgBlackClose : ActionComponent
{
    [JsonPropertyName("bgID_")]
    public string BgID { get; set; }
}
