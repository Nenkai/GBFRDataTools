using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetAgreementDialogKind : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetAgreementDialogKind);

    [JsonPropertyName("dialogKind_")]
    public EnumString<SetAgreementDialogKindEnum> DialogKind { get; set; } // Offset 0x30

    public SetAgreementDialogKind()
    {
    }
}

public enum SetAgreementDialogKindEnum
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    PSNOnlineID = 3,
}
