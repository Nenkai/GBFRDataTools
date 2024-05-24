using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class EndFinishSlow : QuestConditionComponent
{
    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
