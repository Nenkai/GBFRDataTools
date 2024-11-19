using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageMotionPlayMiddleAction : EmDamageMotionPlayDirAction
{
    [JsonPropertyName("frontAnimIdList_")]
    public BindingList<string> FrontAnimIdList { get; set; }
}
