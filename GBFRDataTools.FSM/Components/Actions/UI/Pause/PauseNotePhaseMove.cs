using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Fate;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseNotePhaseMove : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseNotePhaseMove);

    public PauseNotePhaseMove()
    {
    }
}
