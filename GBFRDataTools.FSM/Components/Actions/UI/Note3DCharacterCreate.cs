using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class Note3DCharacterCreate : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Note3DCharacterCreate);

    public Note3DCharacterCreate()
    {
    }
}
