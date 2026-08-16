using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.EndlessConflux;

[GameSupport(GameVersion.EndlessRagnarok)]
public class IsEndlessPointCheck : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsEndlessPointCheck);

    [JsonPropertyName("type_")]
    public EnumString<EndlessPointCheckType> Type { get; set; } = new();

    public enum EndlessPointCheckType
    {
        CanPullBuffs = 0, // バフを引くことができるか
        CanBuyBuffs = 1, // バフ購入できるか
        BuffsAcquired = 2, // 獲得予定のバフが存在するか
        Type3 = 3, // 救済変化が予約されているか
        RPObtained = 4, // RPを取得しているか
    }
}
