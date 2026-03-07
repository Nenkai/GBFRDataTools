using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706IceShotSignAction : ShotAttackSignAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706IceShotSignAction);

    public Em0706IceShotSignAction()
    {
        Shape = ShapeType.Circle;
        Size = Vector4.UnitW;
        Time = 1f;
        PosType = 0;
        PosOffset = Vector4.UnitW;
        LineEndOffset = Vector4.UnitW;
        IsUpdateAttach = false;
        IsUpdateLineEnd = true;
        IsApplyScale = false;
        IsAdjustScaleY = false;
        SignScaleY = 1f;
        IsChangeEffect = false;
        EffectObjId = -1;
        EffectUseParentObjId = false;
        EffectBaseId = -1;
        EffectFillId = -1;
        EffectVanishId = -1;
    }
}
