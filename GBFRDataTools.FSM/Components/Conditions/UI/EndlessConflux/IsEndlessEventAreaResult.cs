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
public class IsEndlessEventAreaResult : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsEndlessEventAreaResult);

    [JsonPropertyName("type_")]
    public EnumString<EndlessEventAreaResultType> Type { get; set; }

    public enum EndlessEventAreaResultType
    {
        Type0 = 0,
        Roulette_GuideDisplayed = 1, // ルーレット：ガイドが表示されているか
        Roulette_RewardsSetForResults = 2, // ルーレット：リザルトに報酬が設定されているか
        Roulette_BonusAnimationStopped = 3, // ルーレット：ボーナスアニメーション停止したか
        Roulette_FinishedState = 4, // ルーレット：終了状態になったか
        Roulette_WinningSlotAnimFinished = 5, // ルーレット：当選枠決定アニメーションが停止したか
        AreaResults_NoDisplayResults = 6, // エリア内リザルト：リザルトを表示しない
        AreaResults_DisplayResultsForBoss = 7, // エリア内リザルト：ボス用のリザルトを表示する
        AreaResults_DisplayResultsForEventsEliteChallenges = 8, // エリア内リザルト：イベント/精鋭用のリザルトを表示する
        Roulette_ReadyToSpin = 9, // ルーレット：回転する準備が整ったか
        Roulette_BonusRoundTriggered = 10, // ルーレット：ボーナスが発生するラウンドか
        Roulette_NextRoundExists = 11, // ルーレット：次のラウンドが存在するか
        Roulette_RewardSlotDisplayStandby = 12, // ルーレット：報酬枠の表示が待機状態になっているか
        Roulette_FirstRoundOr = 13, // ルーレット：初回のラウンドか
        Roulette_InitialBonusWait = 14, // ルーレット：初回のボーナス演出開始前の待機時間待ち
        Roulette_WaitingForPauseBeforeBonusAfterSecondTime = 15, // ルーレット：２回目以降のボーナス演出開始前の待機時間待ち
        FirstClearDifficulty5 = 16, // 難易度LV5をプレイ中の初回クリアか
        AreaCleared = 17, // エリアクリア状態か
        BossAreaAddedToFlow = 18, // ボスエリアの追加フロー中か
    }
}
