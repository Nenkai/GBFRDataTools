using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

[Description("Returns whether a lobby has been joined and currently is in the lobby.")]
public class IsJoinLobby : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsJoinLobby);
}
