using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopNpcPlayVoice : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShopNpcPlayVoice);

    [JsonPropertyName("voiceType_")]
    public EnumString<ShopNpcPlayVoiceType> VoiceType { get; set; } = new();
}

public enum ShopNpcPlayVoiceType
{
    // インタラクト = 1,
    // 詳細表示 = 2,
    // 画面終了 = 3,
    // クエスト受注 = 6,
    // リクエスト受注 = 7,
    // TOPから武器クラフトを選択 = 8,
    // TOPから武器強化を選択 = 10,
    // TOPからジーン強化を選択 = 11,
    // 加護付与を選択 = 12,
    // TOPから売却を選択 = 13,
    // メニューから武器強化を選択 = 14,
    // メニューからミラージュ付与選択 = 15,
    // メニューから上限解放を選択 = 16,
    // 合成が完了 = 17,
    // 上限解放が完了 = 18,
    // 鑑定中 = 21,
    // トレジャー交換選択 = 25,
    // ダリア章交換選択 = 33,
    // お楽しみ券交換選択 = 34,
    // ジーン錬成選択 = 35,
    // キャラ解放選択 = 39,
    // 覚醒武器選択 = 40,
    // 武器覚醒完了 = 41,
    // アイテム売却完了 = 42,
    // セーブ完了 = 43,
    // インタラクト(セーブポイント) = 47,
    // 画面終了(セーブポイント) = 48,
    // クエスト受注選択時 = 50,
    // シャッフルクエスト選択時 = 51,
    // オンラインパーティに招待 = 52,
    // 受注クエスト確認からクエスト選択 = 54,
    // オンラインパーティを探す = 55,
    // ジーン合成選択 = 56,
    Interact = 1,
    ShowDetails = 2,
    ExitScreen = 3,
    Type4 = 4,
    Type5 = 5,
    AcceptQuest = 6,
    AcceptRequest = 7,
    SelectWeaponCraftFromTopMenu = 8,
    Type9 = 9,
    SelectWeaponUpgradeFromTopMenu = 10,
    SelectGeenUpgradeFromTopMenu = 11,
    SelectPendulum = 12,
    SelectSellingFromTopMenu = 13,
    SelectWeaponUpgradeTheMenu = 14,
    SelectMirageFromTheMenu = 15,
    SelectLimitReleasefromTheMenu = 16,
    SynthesisCompleted = 17,
    LimitReleaseCompleted = 18,
    Type19 = 19, 
    Type20 = 20,
    AppraisalInProgress = 21,
    Type22 = 22,
    Type23 = 23,
    Type24 = 24,
    TreasureExchangeSelection = 25,
    Type26 = 26,
    Type27 = 27,
    Type28 = 28,
    Type29 = 29,
    Type30 = 30,
    Type31 = 31,
    Type32 = 32,
    DahliaChapterExchangeSelection = 33,
    FunTicketExchangeSelection = 34,
    GeenAlchemySelection = 35,
    Type36 = 36,
    Type37 = 37,
    Type38 = 38,
    CharacterReleaseSelection = 39,
    AwakeningWeaponSelection = 40,
    WeaponAwakeningCompleted = 41,
    ItemSold = 42,
    SaveCompleted = 43,
    Type44 = 44,
    Type45 = 45,
    Type46 = 46,
    InteractSavePoint = 47,
    ScreenExitSavePoint = 48,
    Type49 = 49,
    QuestAccept = 50,
    ShuffleQuestSelection = 51,
    InviteToOnlineParty = 52,
    Type53 = 53,
    SelectQuestFromAcceptedQuestConfirmation = 54,
    SearchOnlineParty = 55,
    GeenSynthesisSelection = 56,
}
