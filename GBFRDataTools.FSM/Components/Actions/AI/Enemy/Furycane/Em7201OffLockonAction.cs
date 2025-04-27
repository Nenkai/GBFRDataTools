using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201OffLockonAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201OffLockonAction);

    [JsonPropertyName("lockonParts_")]
    [Editable(false)]
    public BindingList<bool> LockonParts { get; set; } = [.. Enumerable.Repeat(false, 7)]; // Offset 0x30

    public Em7201OffLockonAction()
    {
    }
}





