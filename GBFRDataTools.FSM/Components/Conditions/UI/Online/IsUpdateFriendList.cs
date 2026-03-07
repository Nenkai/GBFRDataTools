using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class IsUpdateFriendList : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsUpdateFriendList);

    public IsUpdateFriendList()
    {
    }
}
