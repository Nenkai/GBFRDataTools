using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class SeqLayerSetTemporaryAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SeqLayerSetTemporaryAction);

    [JsonPropertyName("seqLayerNext_")]
    public uint SeqLayerNext { get; set; } = 0;
}
