using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class IsPlayableCamera : QuestConditionComponent
{
    public override string ToString()
    {
        string str = $"{ComponentName}:\n";

        return str;
    }
}
