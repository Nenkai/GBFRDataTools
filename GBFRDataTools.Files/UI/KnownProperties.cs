﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Files.UI.Controllers.Blacksmith;
using GBFRDataTools.Files.UI.Controllers.Common.CursorAction01;
using GBFRDataTools.Files.UI.Controllers.Common.CursorMission;
using GBFRDataTools.Files.UI.Controllers.Common.Entrance;
using GBFRDataTools.Files.UI.Controllers.Common.InfoCmn;
using GBFRDataTools.Files.UI.Controllers.Common.Subtitle01;
using GBFRDataTools.Files.UI.Controllers.Common.WinCut;
using GBFRDataTools.Files.UI.Controllers.Common.Window;
using GBFRDataTools.Files.UI.Controllers.Common.WinTalk;
using GBFRDataTools.Files.UI.Controllers.EndCredit;
using GBFRDataTools.Files.UI.Controllers.Hud.EmParameter;
using GBFRDataTools.Files.UI.Controllers.Hud.ExCharacter;
using GBFRDataTools.Files.UI.Controllers.Hud.GaugeContents;
using GBFRDataTools.Files.UI.Controllers.Mission;
using GBFRDataTools.Files.UI.Controllers.Pause;
using GBFRDataTools.Files.UI.Controllers.Popup;
using GBFRDataTools.Files.UI.Controllers.Shop;
using GBFRDataTools.Files.UI.Controllers.Title;
using GBFRDataTools.Files.UI.IconSetters;
using GBFRDataTools.Files.UI.Infos;
using GBFRDataTools.Files.UI.Items;
using GBFRDataTools.Files.UI.LayoutGroups;
using GBFRDataTools.Files.UI.Menu;
using GBFRDataTools.Files.UI.Setters;

namespace GBFRDataTools.Files.UI;

public class KnownProperties
{
    public static Dictionary<string, List<UIPropertyTypeDef>> ComponentList = new()
    {
        { nameof(AnimationHandle), AnimationHandle.GetAllProperties() },
        { nameof(Animator), Animator.GetAllProperties() },
        { nameof(AnimationEvent), AnimationEvent.GetAllProperties() },
        { nameof(ArrowOffsetTarget), ArrowOffsetTarget.GetAllProperties() },
        { nameof(Button), Button.GetAllProperties() },
        { nameof(ButtonGuide), ButtonGuide.GetAllProperties() },
        { nameof(ButtonLabel), ButtonLabel.GetAllProperties() },
        { nameof(Canvas), Canvas.GetAllProperties() },
        { nameof(CanvasGroup), CanvasGroup.GetAllProperties() },
        { nameof(ChangeSkillDispMode), ChangeSkillDispMode.GetAllProperties() },
        { nameof(ContentSizeFitter), ContentSizeFitter.GetAllProperties() },
        { nameof(Dissolve), Dissolve.GetAllProperties() },
        { nameof(Gauss), Gauss.GetAllProperties() },
        { nameof(GaugeFill), GaugeFill.GetAllProperties() },
        { nameof(GaugeMask), GaugeMask.GetAllProperties() },
        { nameof(HorizontalLayoutGroup), HorizontalLayoutGroup.GetAllProperties() },
        { nameof(Highlight), Highlight.GetAllProperties() },
        { nameof(Image), Image.GetAllProperties() },
        { nameof(ItemWinCutChoice), ItemWinCutChoice.GetAllProperties() },
        { nameof(LayoutElement), LayoutElement.GetAllProperties() },
        { nameof(ListScrollArrow), ListScrollArrow.GetAllProperties() },
        { nameof(ListTabInfo), ListTabInfo.GetAllProperties() },
        { nameof(Mask), Mask.GetAllProperties() },
        { nameof(Movie), Movie.GetAllProperties() },
        { nameof(ScrollBar), ScrollBar.GetAllProperties() },
        { nameof(ScrollBg), ScrollBg.GetAllProperties() },
        { nameof(SelectEntranceMenu), SelectEntranceMenu.GetAllProperties() },
        { nameof(SetupEntrance), SetupEntrance.GetAllProperties() },
        { nameof(Shortcut), Shortcut.GetAllProperties() },
        { nameof(SimpleSizeFitter), SimpleSizeFitter.GetAllProperties() },
        { nameof(SoundContainer), SoundContainer.GetAllProperties() },
        { nameof(Text), Text.GetAllProperties() },
        { nameof(TextAutoLineFeed), TextAutoLineFeed.GetAllProperties() },
        { nameof(TextRuby), TextRuby.GetAllProperties() },
        { nameof(TextSetter), TextSetter.GetAllProperties() },
        { nameof(VerticalLayoutGroup), VerticalLayoutGroup.GetAllProperties() },
        { nameof(UpdateIcon), UpdateIcon.GetAllProperties() },
        { nameof(UpdateIconControl), UpdateIconControl.GetAllProperties() },

        // Icon Setters
        { nameof(AbilityIconSetter), AbilityIconSetter.GetAllProperties() },
        { nameof(CharaIconSetter), CharaIconSetter.GetAllProperties() },
        { nameof(GemIconSetter), GemIconSetter.GetAllProperties() },
        { nameof(GemIconEffectSetter), GemIconEffectSetter.GetAllProperties() },
        { nameof(ItemIconSetter), ItemIconSetter.GetAllProperties() },
        { nameof(IconSetter), IconSetter.GetAllProperties() },
        { nameof(LogoIconSetter), LogoIconSetter.GetAllProperties() },
        { nameof(SkillIconSetter), SkillIconSetter.GetAllProperties() },
        { nameof(StampIconSetter), StampIconSetter.GetAllProperties() },
        { nameof(StatusIconSetter), StatusIconSetter.GetAllProperties() },
        { nameof(WeaponIconSetter), WeaponIconSetter.GetAllProperties() },

        // Setters
        { nameof(KeyboardBtnSetter), KeyboardBtnSetter.GetAllProperties() },
        { nameof(ImageButtonSetter), ImageButtonSetter.GetAllProperties() },
        { nameof(ImageMultiSetter), ImageMultiSetter.GetAllProperties() },
        { nameof(ImageSetter), ImageSetter.GetAllProperties() },
        { nameof(KeyConfigSetter), KeyConfigSetter.GetAllProperties() },
        { nameof(LanguageObjSetter), LanguageObjSetter.GetAllProperties() },
        { nameof(LanguageSetter), LanguageSetter.GetAllProperties() },
        { nameof(MaterialSetter), MaterialSetter.GetAllProperties() },
        { nameof(NoteIconSetter), NoteIconSetter.GetAllProperties() },
        { nameof(NumSetter), NumSetter.GetAllProperties() },
        { nameof(NumTextSetter), NumTextSetter.GetAllProperties() },
        { nameof(OnlineNameColorSetter), OnlineNameColorSetter.GetAllProperties() },
        { nameof(PivotScaleSetter), PivotScaleSetter.GetAllProperties() },

        // Infos
        { nameof(AbilityInfo), AbilityInfo.GetAllProperties() },
        { nameof(AutoFixedPhraseInfo), AutoFixedPhraseInfo.GetAllProperties() },
        { nameof(AwakeWeaponInfo), AwakeWeaponInfo.GetAllProperties() },
        { nameof(BadgeInfo), BadgeInfo.GetAllProperties() },
        { nameof(CharaInfo), CharaInfo.GetAllProperties() },
        { nameof(CharaColorInfo), CharaColorInfo.GetAllProperties() },
        { nameof(ElementInfo), ElementInfo.GetAllProperties() },
        { nameof(EpisodeDifficultyInfo), EpisodeDifficultyInfo.GetAllProperties() },
        { nameof(FavoriteInfo), FavoriteInfo.GetAllProperties() },
        { nameof(FilterSortInfo), FilterSortInfo.GetAllProperties() },
        { nameof(FixedPhraseInfo), FixedPhraseInfo.GetAllProperties() },
        { nameof(GachaFeverInfo), GachaFeverInfo.GetAllProperties() },
        { nameof(GemEffectInfo), GemEffectInfo.GetAllProperties() },
        { nameof(GemInfo), GemInfo.GetAllProperties() },
        { nameof(MaterialInfo), MaterialInfo.GetAllProperties() },
        { nameof(MspUsedItemInfo), MspUsedItemInfo.GetAllProperties() },
        { nameof(NeedMaterialInfo), NeedMaterialInfo.GetAllProperties() },
        { nameof(PendulumInfo), PendulumInfo.GetAllProperties() },
        { nameof(PlayerCardInfo), PlayerCardInfo.GetAllProperties() },
        { nameof(RupiInfo), RupiInfo.GetAllProperties() },
        { nameof(ShopSellInfo), ShopSellInfo.GetAllProperties() },
        { nameof(SkillInfo), SkillInfo.GetAllProperties() },
        { nameof(SkinInfo), SkinInfo.GetAllProperties() },
        { nameof(StampInfo), StampInfo.GetAllProperties() },
        { nameof(StatusInfo), StatusInfo.GetAllProperties() },
        { nameof(EmotionInfo), EmotionInfo.GetAllProperties() },
        { nameof(ValueInfo), ValueInfo.GetAllProperties() },
        { nameof(WeaponInfo), WeaponInfo.GetAllProperties() },

        // Items
        { nameof(ItemAbilityList), ItemAbilityList.GetAllProperties() },
        { nameof(ItemBadgeOne), ItemBadgeOne.GetAllProperties() },
        { nameof(ItemBadgeRewardList), ItemBadgeRewardList.GetAllProperties() },
        { nameof(ItemBlacksmithSubMenu), ItemBlacksmithSubMenu.GetAllProperties() },
        { nameof(ItemButton), ItemButton.GetAllProperties() },
        { nameof(ItemButtonText), ItemButtonText.GetAllProperties() },
        { nameof(ItemConditionGroup), ItemConditionGroup.GetAllProperties() },
        { nameof(ItemCursor), ItemCursor.GetAllProperties() },
        { nameof(ItemDefensiveTargetGauge), ItemDefensiveTargetGauge.GetAllProperties() },
        { nameof(ItemDemoReward), ItemDemoReward.GetAllProperties() },
        { nameof(ItemDial), ItemDial.GetAllProperties() },
        { nameof(ItemDispCount), ItemDispCount.GetAllProperties() },
        { nameof(ItemExchangeData), ItemExchangeData.GetAllProperties() },
        { nameof(ItemExChr23Aim), ItemExChr23Aim.GetAllProperties() },
        { nameof(ItemExChr23Arrow), ItemExChr23Arrow.GetAllProperties() },
        { nameof(ItemGemMixSelect), ItemGemMixSelect.GetAllProperties() },
        { nameof(ItemIconStatus), ItemIconStatus.GetAllProperties() },
        { nameof(ItemIconStatusSet), ItemIconStatusSet.GetAllProperties() },
        { nameof(ItemLevel), ItemLevel.GetAllProperties() },
        { nameof(ItemList), ItemList.GetAllProperties() },
        { nameof(ItemListText), ItemListText.GetAllProperties() },
        { nameof(ItemListShopText), ItemListShopText.GetAllProperties() },
        { nameof(ItemMissionCondition), ItemMissionCondition.GetAllProperties() },
        { nameof(ItemMysetRename), ItemMysetRename.GetAllProperties() },
        { nameof(ItemNew), ItemNew.GetAllProperties() },
        { nameof(ItemNoteFateDetailButton), ItemNoteFateDetailButton.GetAllProperties() },
        { nameof(ItemNoteRelationTipsButton), ItemNoteRelationTipsButton.GetAllProperties() },
        { nameof(ItemNoteViewerSelectButton), ItemNoteViewerSelectButton.GetAllProperties() },
        { nameof(ItemOnlineCharaDetailButton), ItemOnlineCharaDetailButton.GetAllProperties() },
        { nameof(ItemOnlinePlayerListDetailButton), ItemOnlinePlayerListDetailButton.GetAllProperties() },
        { nameof(ItemOnlineStateIconSetting), ItemOnlineStateIconSetting.GetAllProperties() },
        { nameof(ItemPushStick), ItemPushStick.GetAllProperties() },
        { nameof(ItemQuestCounterTop), ItemQuestCounterTop.GetAllProperties() },
        { nameof(ItemShopSellCheck), ItemShopSellCheck.GetAllProperties() },
        { nameof(ItemShopTop), ItemShopTop.GetAllProperties() },
        { nameof(ItemStar), ItemStar.GetAllProperties() },
        { nameof(ItemStatusUpNum), ItemStatusUpNum.GetAllProperties() },
        { nameof(ItemSteamLobbyTarget), ItemSteamLobbyTarget.GetAllProperties() },
        { nameof(ItemSubMission), ItemSubMission.GetAllProperties() },
        { nameof(ItemWeaponAwakenBar), ItemWeaponAwakenBar.GetAllProperties() },
        { nameof(ItemWinCutLog), ItemWinCutLog.GetAllProperties() },
        { nameof(ItemWinCutWordlist), ItemWinCutWordlist.GetAllProperties() },

        // Menus
        { nameof(MenuAbilityList), MenuAbilityList.GetAllProperties() },
        { nameof(MenuBadgeList), MenuBadgeList.GetAllProperties() },
        { nameof(MenuBadgeRewardList), MenuBadgeRewardList.GetAllProperties() },
        { nameof(MenuBlacksmithTop), MenuBlacksmithTop.GetAllProperties() },
        { nameof(MenuDemoReward), MenuDemoReward.GetAllProperties() },
        { nameof(MenuDial), MenuDial.GetAllProperties() },
        { nameof(MenuDialog), MenuDialog.GetAllProperties() },
        { nameof(MenuEntrance), MenuEntrance.GetAllProperties() },
        { nameof(MenuEpisodeDifficulty), MenuEpisodeDifficulty.GetAllProperties() },
        { nameof(MenuExchangeData), MenuExchangeData.GetAllProperties() },
        { nameof(MenuGeenList), MenuGeenList.GetAllProperties() },
        { nameof(MenuGemMixSelect), MenuGemMixSelect.GetAllProperties() },
        { nameof(MenuList), MenuList.GetAllProperties() },
        { nameof(MenuMaterialList), MenuMaterialList.GetAllProperties() },
        { nameof(MenuMysetRename), MenuMysetRename.GetAllProperties() },
        { nameof(MenuMysetSymbol), MenuMysetSymbol.GetAllProperties() },
        { nameof(MenuNeedMaterialChoice), MenuNeedMaterialChoice.GetAllProperties() },
        { nameof(MenuNeedMaterialList), MenuNeedMaterialList.GetAllProperties() },
        { nameof(MenuNoteFateEpisodeDetail), MenuNoteFateEpisodeDetail.GetAllProperties() },
        { nameof(MenuNotePictureBookViewerSelect), MenuNotePictureBookViewerSelect.GetAllProperties() },
        { nameof(MenuNoteRelationTips), MenuNoteRelationTips.GetAllProperties() },
        { nameof(MenuObject), MenuObject.GetAllProperties() },
        { nameof(MenuOnlineCharaDetailList), MenuOnlineCharaDetailList.GetAllProperties() },
        { nameof(MenuOnlinePlayerListDetail), MenuOnlinePlayerListDetail.GetAllProperties() },
        { nameof(MenuPartyList), MenuPartyList.GetAllProperties() },
        { nameof(MenuPauseOnlineCommuShortcutType), MenuPauseOnlineCommuShortcutType.GetAllProperties() },
        { nameof(MenuPauseOnlineCommuShortcutStampList), MenuPauseOnlineCommuShortcutStampList.GetAllProperties() },
        { nameof(MenuPauseOnlineCommuShortcutEmotionList), MenuPauseOnlineCommuShortcutEmotionList.GetAllProperties() },
        { nameof(MenuPauseOnlineCommuShortcutFixedPhraseList), MenuPauseOnlineCommuShortcutFixedPhraseList.GetAllProperties() },
        { nameof(MenuPressAny), MenuPressAny.GetAllProperties() },
        { nameof(MenuQuestCounter), MenuQuestCounter.GetAllProperties() },
        { nameof(MenuSettingSubWindow), MenuSettingSubWindow.GetAllProperties() },
        { nameof(MenuShortcutMenu), MenuShortcutMenu.GetAllProperties() },
        { nameof(MenuSkin), MenuSkin.GetAllProperties() },
        { nameof(MenuSteamLobbyTarget), MenuSteamLobbyTarget.GetAllProperties() },
        { nameof(MenuShopSellCheckList), MenuShopSellCheckList.GetAllProperties() },
        { nameof(MenuWeaponList), MenuWeaponList.GetAllProperties() },
        { nameof(MenuWinCutChoice), MenuWinCutChoice.GetAllProperties() },
        { nameof(MenuWinCutWordlist), MenuWinCutWordlist.GetAllProperties() },

        // Controllers
        { nameof(ControllerAbilityDetail), ControllerAbilityDetail.GetAllProperties() },
        { nameof(ControllerAbilityList), ControllerAbilityList.GetAllProperties() },
        { nameof(ControllerApTreeBg), ControllerApTreeBg.GetAllProperties() },
        { nameof(ControllerBadgeList), ControllerBadgeList.GetAllProperties() },
        { nameof(ControllerBg), ControllerBg.GetAllProperties() },
        { nameof(ControllerBgBlack), ControllerBgBlack.GetAllProperties() },
        { nameof(ControllerBgWhite), ControllerBgWhite.GetAllProperties() },
        { nameof(ControllerBadgeAllRewardDialog), ControllerBadgeAllRewardDialog.GetAllProperties() },
        { nameof(ControllerBlacksmithMaterialNumSelectDialog), ControllerBlacksmithMaterialNumSelectDialog.GetAllProperties() },
        { nameof(ControllerBlacksmithResult), ControllerBlacksmithResult.GetAllProperties() },
        { nameof(ControllerBlacksmithTop), ControllerBlacksmithTop.GetAllProperties() },
        { nameof(ControllerBlacksmithWeaponList), ControllerBlacksmithWeaponList.GetAllProperties() },
        { nameof(ControllerChallengeMissionIcon), ControllerChallengeMissionIcon.GetAllProperties() },
        { nameof(ControllerCursorAction), ControllerCursorAction.GetAllProperties() },
        { nameof(ControllerCursorMission01), ControllerCursorMission01.GetAllProperties() },
        { nameof(ControllerDataSave), ControllerDataSave.GetAllProperties() },
        { nameof(ControllerDialogSerialCodeDisp), ControllerDialogSerialCodeDisp.GetAllProperties() },
        { nameof(ControllerDefenseHp), ControllerDefenseHp.GetAllProperties() },
        { nameof(ControllerDemoReward), ControllerDemoReward.GetAllProperties() },
        { nameof(ControllerDialog), ControllerDialog.GetAllProperties() },
        { nameof(ControllerEndingLyrics), ControllerEndingLyrics.GetAllProperties() },
        { nameof(ControllerEmParam), ControllerEmParam.GetAllProperties() },
        { nameof(ControllerEnemySkill), ControllerEnemySkill.GetAllProperties() },
        { nameof(ControllerEquipWeaponInfo), ControllerEquipWeaponInfo.GetAllProperties() },
        { nameof(ControllerEm7700Trial), ControllerEm7700Trial.GetAllProperties() },
        { nameof(ControllerEpisodeDifficulty), ControllerEpisodeDifficulty.GetAllProperties() },
        { nameof(ControllerExchangeData), ControllerExchangeData.GetAllProperties() },
        { nameof(ControllerExChara), ControllerExChara.GetAllProperties() },
        { nameof(ControllerExChr02), ControllerExChr02.GetAllProperties() },
        { nameof(ControllerExChr03), ControllerExChr03.GetAllProperties() },
        { nameof(ControllerExChr04), ControllerExChr04.GetAllProperties() },
        { nameof(ControllerExChr0501), ControllerExChr0501.GetAllProperties() },
        { nameof(ControllerExChr0502), ControllerExChr0502.GetAllProperties() },
        { nameof(ControllerExChr07), ControllerExChr07.GetAllProperties() },
        { nameof(ControllerExChr09), ControllerExChr09.GetAllProperties() },
        { nameof(ControllerExChr13), ControllerExChr13.GetAllProperties() },
        { nameof(ControllerExChr14), ControllerExChr14.GetAllProperties() },
        { nameof(ControllerExChr15), ControllerExChr15.GetAllProperties() },
        { nameof(ControllerExChr17), ControllerExChr17.GetAllProperties() },
        { nameof(ControllerExChr19), ControllerExChr19.GetAllProperties() },
        { nameof(ControllerExChr22), ControllerExChr22.GetAllProperties() },
        { nameof(ControllerExChr23), ControllerExChr23.GetAllProperties() },
        { nameof(ControllerExChr23Lockon), ControllerExChr23Lockon.GetAllProperties() },
        { nameof(ControllerFavDetail), ControllerFavDetail.GetAllProperties() },
        { nameof(ControllerFavListRemove), ControllerFavListRemove.GetAllProperties() },
        { nameof(ControllerFrameHeader), ControllerFrameHeader.GetAllProperties() },
        { nameof(ControllerGaugeBattleNotice), ControllerGaugeBattleNotice.GetAllProperties() },
        { nameof(ControllerGeenDetail), ControllerGeenDetail.GetAllProperties() },
        { nameof(ControllerGemMixImportantConfirm), ControllerGemMixImportantConfirm.GetAllProperties() },
        { nameof(ControllerGemMixResult), ControllerGemMixResult.GetAllProperties() },
        { nameof(ControllerGemMixSelect), ControllerGemMixSelect.GetAllProperties() },
        { nameof(ControllerGuessCharaSelectSkin), ControllerGuessCharaSelectSkin.GetAllProperties() },
        { nameof(ControllerInformationToast), ControllerInformationToast.GetAllProperties() },
        { nameof(ControllerInventoryInfo), ControllerInventoryInfo.GetAllProperties() },
        { nameof(ControllerItemDialogGacha), ControllerItemDialogGacha.GetAllProperties() },
        { nameof(ControllerMission), ControllerMission.GetAllProperties() },
        { nameof(ControllerMysetRename), ControllerMysetRename.GetAllProperties() },
        { nameof(ControllerMysetSymbolSeparate), ControllerMysetSymbolSeparate.GetAllProperties() },
        { nameof(ControllerNoteFateEpisodeDetail), ControllerNoteFateEpisodeDetail.GetAllProperties() },
        { nameof(ControllerPendulumDetail), ControllerPendulumDetail.GetAllProperties() },
        { nameof(ControllerQuestCounterMenu), ControllerQuestCounterMenu.GetAllProperties() },
        { nameof(ControllerPauseOnlineCharaDetail), ControllerPauseOnlineCharaDetail.GetAllProperties() },
        { nameof(ControllerPauseOnlineCommuShortcutType), ControllerPauseOnlineCommuShortcutType.GetAllProperties() },
        { nameof(ControllerPauseOnlineCommuShortcutDetail), ControllerPauseOnlineCommuShortcutDetail.GetAllProperties() },
        { nameof(ControllerPauseOnlinePlayerListDetail), ControllerPauseOnlinePlayerListDetail.GetAllProperties() },
        { nameof(ControllerPopup), ControllerPopup.GetAllProperties() },
        { nameof(ControllerPopupQuestReadyError), ControllerPopupQuestReadyError.GetAllProperties() },
        { nameof(ControllerNoteSubWindow), ControllerNoteSubWindow.GetAllProperties() },
        { nameof(ControllerSaveCaution), ControllerSaveCaution.GetAllProperties() },
        { nameof(ControllerSavePointTips), ControllerSavePointTips.GetAllProperties() },
        { nameof(ControllerSettingSubMenu), ControllerSettingSubMenu.GetAllProperties() },
        { nameof(ControllerShopCharaTicket), ControllerShopCharaTicket.GetAllProperties() },
        { nameof(ControllerShortcutMenu), ControllerShortcutMenu.GetAllProperties() },
        { nameof(ControllerStaffBase), ControllerStaffBase.GetAllProperties() },
        { nameof(ControllerStaffCast), ControllerStaffCast.GetAllProperties() },
        { nameof(ControllerStaffLogo), ControllerStaffLogo.GetAllProperties() },
        { nameof(ControllerStaffMini), ControllerStaffMini.GetAllProperties() },
        { nameof(ControllerStaffMovie), ControllerStaffMovie.GetAllProperties() },
        { nameof(ControllerStaffPosition), ControllerStaffPosition.GetAllProperties() },
        { nameof(ControllerStaffText), ControllerStaffText.GetAllProperties() },
        { nameof(ControllerSubList), ControllerSubList.GetAllProperties() },
        { nameof(ControllerSubListGem), ControllerSubListGem.GetAllProperties() },
        { nameof(ControllerSubtitleSkip), ControllerSubtitleSkip.GetAllProperties() },
        { nameof(ControllerSubtitleSkipGuide), ControllerSubtitleSkipGuide.GetAllProperties() },
        { nameof(ControllerSubtitleSkipWait), ControllerSubtitleSkipWait.GetAllProperties() },
        { nameof(ControllerSubTitle01), ControllerSubTitle01.GetAllProperties() },
        { nameof(ControllerTrialPTList), ControllerTrialPTList.GetAllProperties() },
        { nameof(ControllerTitleTop), ControllerTitleTop.GetAllProperties() },
        { nameof(ControllerTrialTop), ControllerTrialTop.GetAllProperties() },
        { nameof(ControllerTrialTips), ControllerTrialTips.GetAllProperties() },
        { nameof(ControllerWinCut), ControllerWinCut.GetAllProperties() },
        { nameof(ControllerWinCutChoice), ControllerWinCutChoice.GetAllProperties() },
        { nameof(ControllerWinCutLog), ControllerWinCutLog.GetAllProperties() },
        { nameof(ControllerWinCutWordList), ControllerWinCutWordList.GetAllProperties() },
        { nameof(ControllerWinCutWordListButton), ControllerWinCutWordListButton.GetAllProperties() },
        { nameof(ControllerWinCutWordListInfo01), ControllerWinCutWordListInfo01.GetAllProperties() },
        { nameof(ControllerWinCutWordListInfo02), ControllerWinCutWordListInfo02.GetAllProperties() },
        { nameof(ControllerWinTalk), ControllerWinTalk.GetAllProperties() },
        { nameof(ControllerWinVoice01), ControllerWinVoice01.GetAllProperties() },
    };

    public static List<UIPropertyTypeDef> List { get; set; } =
    [
        // prfb
        // note: file E6AA6952D620558F & more has it in msg format
        new("Objects", FieldType.ObjectArray,
        [
            new("Name", FieldType.String),
            // ui::component::Object
            new("Position", FieldType.CVec3),
            new("Rotation", FieldType.CVec4),
            new("Scale", FieldType.CVec3),
            new("Pivot", FieldType.CVec2),
            new("AnchorPoint", FieldType.CVec2),
            new("AnchorMin", FieldType.CVec2),
            new("AnchorMax", FieldType.CVec2),
            new("OffsetMin", FieldType.CVec2),
            new("OffsetMax", FieldType.CVec2),
            new("SizeDelta", FieldType.CVec2),
            new("Active", FieldType.Bool),
            new("Id", FieldType.S32),

            // Not part of it?
            new UIPropertyTypeDef("Children", FieldType.S32Vector),
            new UIPropertyTypeDef("Components", FieldType.ObjectArray,
            [
                new UIPropertyTypeDef("ComponentName", FieldType.String),
                new UIPropertyTypeDef("Component", FieldType.Object, []),
            ])
        ]),

        // matb
        // (thanks file 0C009F42BA90B0DD for having a list of most properties as a .msg file)
        new("ScaleRatioA", FieldType.F32),
        new("ScaleRatioB", FieldType.F32),
        new("ScaleRatioC", FieldType.F32),
        new("GradiantScale", FieldType.F32),
        new("FaceColor", FieldType.CVec4),
        new("FaceDilate", FieldType.F32),
        new("OutlineWidth", FieldType.F32),
        new("OutlineSoftness", FieldType.F32),
        new("UnderlayEnable", FieldType.Bool),
        new("UnderlayColor", FieldType.CVec4),
        new("UnderlayOffsetX", FieldType.F32),
        new("UnderlayOffsetY", FieldType.F32),
        new("UnderlayDilate", FieldType.F32),
        new("UnderlaySoftness", FieldType.F32),
        new("GlowColor", FieldType.CVec4),
        new("GlowInner", FieldType.F32),
        new("GlowOffset", FieldType.F32),
        new("GlowOuter", FieldType.F32),
        new("GlowPower", FieldType.F32),
        new("ShaderPath", FieldType.String),
        new("Blend", FieldType.F32),
        new(0x259D1272, FieldType.F32),
        new(0x4A7281DC, FieldType.S32),
        new(0xB9CB0755, FieldType.CVec3),

        // texb
        // note: file DCEA5CBA05A6E3BB has it in msg format
        new("Filter", FieldType.Bool),
        new("Wrap", FieldType.Bool),
        new("Size", FieldType.CVec2),
        new("Sprites", FieldType.ObjectArray,
        [
            new("MinSize", FieldType.CVec2),
            new("Rect", FieldType.CVec4),
            new("Name", FieldType.String),
            new("Padding", FieldType.CVec4),
            new("Uv", FieldType.CVec4),
            new("Border", FieldType.CVec4),
        ]),

        // listb
        // note: file D62165EDB7CB75D3 & more has it in msg format
        new("Materials", FieldType.StringVector),
        new("Animations", FieldType.StringVector),
        new("AtlasData", FieldType.Object,
        [
            new("Ita", FieldType.StringVector),
            new("Common", FieldType.StringVector),
            new("Eng", FieldType.StringVector),
            new("Kor", FieldType.StringVector),
            new("Cht", FieldType.StringVector),
            new("Esp", FieldType.StringVector),
            new("Deu", FieldType.StringVector),
            new("Fra", FieldType.StringVector),
            new("Chs", FieldType.StringVector),
            new("Por", FieldType.StringVector),
            new("Jpn", FieldType.StringVector),
        ]),
        new(0x9029CEE4, FieldType.StringVector),
        new("TextureData", FieldType.Object,
        [
            new("Ita", FieldType.StringVector),
            new("Common", FieldType.StringVector),
            new("Eng", FieldType.StringVector),
            new("Kor", FieldType.StringVector),
            new("Cht", FieldType.StringVector),
            new("Esp", FieldType.StringVector),
            new("Deu", FieldType.StringVector),
            new("Fra", FieldType.StringVector),
            new("Chs", FieldType.StringVector),
            new("Por", FieldType.StringVector),
            new("Jpn", FieldType.StringVector),
        ]),
        new("LanguageData", FieldType.StringVector),
        new("ImageData", FieldType.StringVector),

        // viewb
        // note: file 49891858950C901A has it in msg format
        new("Layouts", FieldType.ObjectArray,
        [
            new("Scale", FieldType.CVec3),
            new("AnchorMin", FieldType.CVec2),
            new("AssetPath", FieldType.String),
            new("OffsetMax", FieldType.CVec2),
            new("OffsetMin", FieldType.CVec2),
            new("Rotation", FieldType.CVec4),
            new("SizeDelta", FieldType.CVec2),
            new("Active", FieldType.Bool),
            new("Pivot", FieldType.CVec2),
            new("AnchorMax", FieldType.CVec2),
            new("AnchorPoint", FieldType.CVec2),
        ]),

        // langb
        // note: file 43286F3E023A5B1D has it in msg format
        new("FontSettings", FieldType.ObjectArray,
        [
            new("Language", FieldType.String),
            new("Font", FieldType.String),
            new("Material", FieldType.String),
            new("FontSizeOffset", FieldType.S32),
            new("CharacterSpacingOffset", FieldType.F32),
            new("LineSpacingOffset", FieldType.F32),
            new("Force", FieldType.Bool),
        ]),
    ];
}
