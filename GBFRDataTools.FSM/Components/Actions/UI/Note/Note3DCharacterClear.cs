using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Note;

public class Note3DCharacterClear : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Note3DCharacterClear);

    public Note3DCharacterClear()
    {
    }
}
