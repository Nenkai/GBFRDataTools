using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000VortexAreaShotAttackSignAction : ShotAttackSignAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000VortexAreaShotAttackSignAction);

    [JsonPropertyName("attackSignEndBeforeSec_")]
    public float AttackSignEndBeforeSec { get; set; } = 0.25f;

    public Em8000VortexAreaShotAttackSignAction()
    {
        Shape = ShapeType.Circle;
        Size = new Vector4(0f, 0f, 0f, 1f);
        Time = 1f;
        PosType = 0;
        PosOffset = new Vector4(0f, 0f, 0f, 1f);
        LineEndOffset = new Vector4(0f, 0f, 0f, 1f);
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