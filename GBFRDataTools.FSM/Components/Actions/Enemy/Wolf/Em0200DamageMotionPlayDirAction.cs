using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wolf;

public class Em0200DamageMotionPlayDirAction : EmDamageMotionPlayDirAction
{
    [JsonPropertyName("riderAnimIdList_")]
    public BindingList<int> RiderAnimIdList { get; set; }
}
