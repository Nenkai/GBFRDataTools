using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CallVFXDeformationAction : CallVFXAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallVFXDeformationAction);

    public CallVFXDeformationAction()
    {
        Id = 0;
        IsUseCoreEff = false;
        IsParentSetting = false;
        EffectObjId = -1;
        IsOwnerSlowRate = false;
    }
}
