using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401EarthShotAttackSignAction : ShotAttackSignAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401EarthShotAttackSignAction);

    public Em8401EarthShotAttackSignAction()
    {
        Shape = ShapeType.Circle;
        Size = Vector4.UnitW;
        Time = 1f;
        PosType = 0;
        PosOffset = Vector4.UnitW;
        LineEndOffset = Vector4.UnitW;
        IsUpdateAttach = false;
        IsUpdateLineEnd = true;
        IsVanishOnActionEnd = false;
        IsApplyScale = false;
        IsAdjustScaleY = false;
        SignScaleY = 1f;
        IsAdjustGroundPos = false;
        IsChangeEffect = false;
        EffectObjId = -1;
        EffectUseParentObjId = false;
        EffectBaseId = -1;
        EffectFillId = -1;
        EffectVanishId = -1;
    }
}
