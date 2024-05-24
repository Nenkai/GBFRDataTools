using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class EndFsm : QuestActionUseFsmBase
{
    public override string ToString()
    {
        string str = $"{ComponentName}(no: {FsmDataNo}, progressHash: {FsmProgressHash})";
        return str;
    }
}
