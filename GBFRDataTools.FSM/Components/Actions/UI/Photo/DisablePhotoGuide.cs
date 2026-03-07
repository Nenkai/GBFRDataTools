using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Photo;

public class DisablePhotoGuide : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DisablePhotoGuide);

    public DisablePhotoGuide()
    {
    }
}
