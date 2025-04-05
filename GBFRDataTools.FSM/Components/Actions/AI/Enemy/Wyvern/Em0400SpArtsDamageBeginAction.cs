﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyvern;

public class Em0400SpArtsDamageBeginAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0400SpArtsDamageBeginAction);
}
