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
public class IsEndlessCityEvent : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsEndlessCityEvent);

    [JsonPropertyName("type_")]
    public EnumString<EndlessCityEventType> Type { get; set; }

    public enum EndlessCityEventType
    {
        Type0 = 0, // 街のマロース僧兵の移動先がトルダーム宮に固定されているか - Is the destination of the town's Maros warrior-monk fixed to Tuldarm Palace?
        Type1 = 1, // 街のザスバの手下の移動先が路地裏に固定されているか - Is the location of Zasba's henchman in the city fixed to the back alley?
        Type2 = 2, // 称号受け取り可能なバフコレクション称号が1つでも存在するか - Is there at least one buff collection title available to be claimed?
        Type3 = 3, // パッケージ報酬の追加通知が必要か(トルダーム宮) - Is a notification regarding the addition of package rewards required? (Toldam Palace)
        Type4 = 4, // パッケージ報酬の追加通知が必要か(路地裏) - Is a notification required for the addition of package rewards? (Back Alley)
    }
}
