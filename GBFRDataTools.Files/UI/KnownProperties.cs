using System;
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
using GBFRDataTools.Files.UI.Controllers.Common.Mission;
using GBFRDataTools.Files.UI.Controllers.Common.Subtitle01;
using GBFRDataTools.Files.UI.Controllers.Common.WinCut;
using GBFRDataTools.Files.UI.Controllers.Common.Window;
using GBFRDataTools.Files.UI.Controllers.Common.WinTalk;
using GBFRDataTools.Files.UI.Controllers.EndCredit;
using GBFRDataTools.Files.UI.Controllers.Hud.Bonus;
using GBFRDataTools.Files.UI.Controllers.Hud.Compass;
using GBFRDataTools.Files.UI.Controllers.Hud.ChainChance;
using GBFRDataTools.Files.UI.Controllers.Hud.EmParameter;
using GBFRDataTools.Files.UI.Controllers.Hud.EmMode;
using GBFRDataTools.Files.UI.Controllers.Hud.ExCharacter;
using GBFRDataTools.Files.UI.Controllers.Hud.Mission;
using GBFRDataTools.Files.UI.Controllers.Hud.GaugeContents;
using GBFRDataTools.Files.UI.Controllers.Hud.GuideAction;
using GBFRDataTools.Files.UI.Controllers.Hud.GuideAbility;
using GBFRDataTools.Files.UI.Controllers.Hud.GuideCommand;
using GBFRDataTools.Files.UI.Controllers.Hud.ObjectEm;
using GBFRDataTools.Files.UI.Controllers.Hud.TrialBattle;
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
using GBFRDataTools.Hashing;


namespace GBFRDataTools.Files.UI;

public class KnownProperties
{
    public static Dictionary<uint, string> HashToSpriteName = [];

    static KnownProperties()
    {
        using var fs = new StreamReader("UI/sprite_names.txt");
        while (!fs.EndOfStream)
        {
            var line = fs.ReadLine();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                continue;

            HashToSpriteName.Add(XXHash32Custom.Hash(line), line);
        }
    }

    public static Dictionary<string, List<UIPropertyTypeDef>> ComponentList = new()
    {
        { nameof(AnimationHandle), AnimationHandle.GetAllProperties() },
        { nameof(Animator), Animator.GetAllProperties() },
        { nameof(AnimationEvent), AnimationEvent.GetAllProperties() },
        { nameof(ArrowOffsetTarget), ArrowOffsetTarget.GetAllProperties() },
        { nameof(Button), Button.GetAllProperties() },
        { nameof(ButtonGuide), ButtonGuide.GetAllProperties() },
        { nameof(ButtonLabel), ButtonLabel.GetAllProperties() },
        { nameof(ButtonSwap), ButtonSwap.GetAllProperties() },
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
        { nameof(InputTextButton), InputTextButton.GetAllProperties() },
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
        { nameof(SubMenuButton), SubMenuButton.GetAllProperties() },
        { nameof(SwitchButton), SwitchButton.GetAllProperties() },
        { nameof(Text), Text.GetAllProperties() },
        { nameof(TextAutoLineFeed), TextAutoLineFeed.GetAllProperties() },
        { nameof(TextRuby), TextRuby.GetAllProperties() },
        { nameof(TextSetter), TextSetter.GetAllProperties() },
        { nameof(VerticalLayoutGroup), VerticalLayoutGroup.GetAllProperties() },
        { nameof(UpdateIcon), UpdateIcon.GetAllProperties() },
        { nameof(UpdateIconControl), UpdateIconControl.GetAllProperties() },
        { nameof(Window), Window.GetAllProperties() },

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
        { nameof(QuestInfo), QuestInfo.GetAllProperties() },
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
        { nameof(ItemContinuouslyAbilityCount), ItemContinuouslyAbilityCount.GetAllProperties() },
        { nameof(ItemDefensiveTargetGauge), ItemDefensiveTargetGauge.GetAllProperties() },
        { nameof(ItemDemoReward), ItemDemoReward.GetAllProperties() },
        { nameof(ItemDial), ItemDial.GetAllProperties() },
        { nameof(ItemDispCount), ItemDispCount.GetAllProperties() },
        { nameof(ItemExchangeData), ItemExchangeData.GetAllProperties() },
        { nameof(ItemExChr23Aim), ItemExChr23Aim.GetAllProperties() },
        { nameof(ItemExChr23Arrow), ItemExChr23Arrow.GetAllProperties() },
        { nameof(ItemGemMixSelect), ItemGemMixSelect.GetAllProperties() },
        { nameof(ItemGuideCommand), ItemGuideCommand.GetAllProperties() },
        { nameof(ItemIconAbility), ItemIconAbility.GetAllProperties() },
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
        { nameof(ItemSettingDetail), ItemSettingDetail.GetAllProperties() },
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
        { nameof(MenuSettingDetailList), MenuSettingDetailList.GetAllProperties() },
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
        { nameof(ControllerBadgeAllRewardDialog), ControllerBadgeAllRewardDialog.GetAllProperties() },
        { nameof(ControllerBelowSubGuide), ControllerBelowSubGuide.GetAllProperties() },
        { nameof(ControllerBg), ControllerBg.GetAllProperties() },
        { nameof(ControllerBgBlack), ControllerBgBlack.GetAllProperties() },
        { nameof(ControllerBgWhite), ControllerBgWhite.GetAllProperties() },
        { nameof(ControllerBonusHud), ControllerBonusHud.GetAllProperties() },
        { nameof(ControllerBlacksmithMaterialNumSelectDialog), ControllerBlacksmithMaterialNumSelectDialog.GetAllProperties() },
        { nameof(ControllerBlacksmithResult), ControllerBlacksmithResult.GetAllProperties() },
        { nameof(ControllerBlacksmithTop), ControllerBlacksmithTop.GetAllProperties() },
        { nameof(ControllerBlacksmithWeaponList), ControllerBlacksmithWeaponList.GetAllProperties() },
        { nameof(ControllerChallengeMissionIcon), ControllerChallengeMissionIcon.GetAllProperties() },
        { nameof(ControllerChainChance), ControllerChainChance.GetAllProperties() },
        { nameof(ControllerCompass), ControllerCompass.GetAllProperties() },
        { nameof(ControllerCompassIcon), ControllerCompassIcon.GetAllProperties() },
        { nameof(ControllerCursorAction), ControllerCursorAction.GetAllProperties() },
        { nameof(ControllerCursorLockOn), ControllerCursorLockOn.GetAllProperties() },
        { nameof(ControllerCursorMission01), ControllerCursorMission01.GetAllProperties() },
        { nameof(ControllerDataSave), ControllerDataSave.GetAllProperties() },
        { nameof(ControllerDialogSerialCodeDisp), ControllerDialogSerialCodeDisp.GetAllProperties() },
        { nameof(ControllerDefenseHp), ControllerDefenseHp.GetAllProperties() },
        { nameof(ControllerDemoReward), ControllerDemoReward.GetAllProperties() },
        { nameof(ControllerDialog), ControllerDialog.GetAllProperties() },
        { nameof(ControllerEndingLyrics), ControllerEndingLyrics.GetAllProperties() },
        { nameof(ControllerEmParam), ControllerEmParam.GetAllProperties() },
        { nameof(ControllerEmHp), ControllerEmHp.GetAllProperties() },
        { nameof(ControllerEmStun), ControllerEmStun.GetAllProperties() },
        { nameof(ControllerEm7700Trial), ControllerEm7700Trial.GetAllProperties() },
        { nameof(ControllerEnemySkill), ControllerEnemySkill.GetAllProperties() },
        { nameof(ControllerEpisodeDifficulty), ControllerEpisodeDifficulty.GetAllProperties() },
        { nameof(ControllerEquipWeaponInfo), ControllerEquipWeaponInfo.GetAllProperties() },
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
        { nameof(ControllerGuideAbility), ControllerGuideAbility.GetAllProperties() },
        { nameof(ControllerGuideAction), ControllerGuideAction.GetAllProperties() },
        { nameof(ControllerGuideCommand), ControllerGuideCommand.GetAllProperties() },
        { nameof(ControllerGuideContinuouslyAbility), ControllerGuideContinuouslyAbility.GetAllProperties() },
        { nameof(ControllerGuideInteract), ControllerGuideInteract.GetAllProperties() },
        { nameof(ControllerGuideSp), ControllerGuideSp.GetAllProperties() },
        { nameof(ControllerGuessCharaSelectSkin), ControllerGuessCharaSelectSkin.GetAllProperties() },
        { nameof(ControllerHudQuestReady), ControllerHudQuestReady.GetAllProperties() },
        { nameof(ControllerInformationToast), ControllerInformationToast.GetAllProperties() },
        { nameof(ControllerInventoryInfo), ControllerInventoryInfo.GetAllProperties() },
        { nameof(ControllerItemDialogGacha), ControllerItemDialogGacha.GetAllProperties() },
        { nameof(ControllerMission), ControllerMission.GetAllProperties() },
        { nameof(ControllerMysetRename), ControllerMysetRename.GetAllProperties() },
        { nameof(ControllerMysetSymbolSeparate), ControllerMysetSymbolSeparate.GetAllProperties() },
        { nameof(ControllerNoteFateEpisodeDetail), ControllerNoteFateEpisodeDetail.GetAllProperties() },
        { nameof(ControllerPendulumDetail), ControllerPendulumDetail.GetAllProperties() },
        { nameof(ControllerOverdrive), ControllerOverdrive.GetAllProperties() },
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
        { nameof(ControllerSpRemainingTimer), ControllerSpRemainingTimer.GetAllProperties() },
        { nameof(ControllerSubGuide), ControllerSubGuide.GetAllProperties() },
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
        { nameof(ControllerTrialInfo), ControllerTrialInfo.GetAllProperties() },
        { nameof(ControllerTrialSettingList), ControllerTrialSettingList.GetAllProperties() },
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
        // note: files:
        // - 38726B07D5C46210
        // - 45398097E6451A84
        // - 49B50479B0C88573
        // - 5D1405DEDDD277CF
        // - 5E24A1AD2845A142
        // - 607B60A5AF8AB64A
        // - 980E92DA545B6C6A
        // - B4318E784D3EC0E7
        // - E6AA6952D620558F
        // has it in msg format
        new("Objects", UIFieldType.ObjectArray,
        [
            new("Id", UIFieldType.S32),
            new("Name", UIFieldType.String),
            new("Children", UIFieldType.S32Vector),
            new("Components", UIFieldType.ObjectArray,
            [
                new("ComponentName", UIFieldType.String),
                new("Component", UIFieldType.Object, []),
            ]),

            // ui::component::Object
            new("Active", UIFieldType.Bool),
            new("Position", UIFieldType.CVec3),
            new("Rotation", UIFieldType.CVec4),
            new("Scale", UIFieldType.CVec3),
            new("Pivot", UIFieldType.CVec2),
            new("AnchorPoint", UIFieldType.CVec2),
            new("AnchorMin", UIFieldType.CVec2),
            new("AnchorMax", UIFieldType.CVec2),
            new("OffsetMin", UIFieldType.CVec2),
            new("OffsetMax", UIFieldType.CVec2),
            new("SizeDelta", UIFieldType.CVec2),

            // Not part of it?
        ]),

        // matb
        // (thanks file 0C009F42BA90B0DD for having a list of most properties as a .msg file)
        new("Blend", UIFieldType.F32),
        new("ScaleRatioA", UIFieldType.F32),
        new("ScaleRatioB", UIFieldType.F32),
        new("ScaleRatioC", UIFieldType.F32),
        new("GradiantScale", UIFieldType.F32),
        new("FaceColor", UIFieldType.CVec4),
        new("FaceDilate", UIFieldType.F32),
        new("OutlineColor", UIFieldType.CVec3),
        new("OutlineWidth", UIFieldType.F32),
        new("OutlineSoftness", UIFieldType.F32),
        new("UnderlayEnable", UIFieldType.Bool),
        new("UnderlayColor", UIFieldType.CVec4),
        new("UnderlayOffsetX", UIFieldType.F32),
        new("UnderlayOffsetY", UIFieldType.F32),
        new("UnderlayDilate", UIFieldType.F32),
        new("UnderlaySoftness", UIFieldType.F32),
        new("GlowEnable", UIFieldType.Bool),
        new("GlowColor", UIFieldType.CVec4),
        new("GlowInner", UIFieldType.F32),
        new("GlowOffset", UIFieldType.F32),
        new("GlowOuter", UIFieldType.F32),
        new("GlowPower", UIFieldType.F32),
        new("ShaderPath", UIFieldType.String),
        new(0x259D1272, UIFieldType.F32),

        // texb
        // note: file DCEA5CBA05A6E3BB has it in msg format
        new("Wrap", UIFieldType.Bool),
        new("Filter", UIFieldType.Bool),
        new("Size", UIFieldType.CVec2),
        new("Sprites", UIFieldType.ObjectArray,
        [
            new("Name", UIFieldType.String),
            new("Rect", UIFieldType.CVec4),
            new("Border", UIFieldType.CVec4),
            new("Padding", UIFieldType.CVec4),
            new("Uv", UIFieldType.CVec4),
            new("MinSize", UIFieldType.CVec2),
        ]),

        // listb
        // note: file D62165EDB7CB75D3 & more has it in msg format
        new("TextureData", UIFieldType.Object,
        [
            new("Common", UIFieldType.StringVector),
            new("Eng", UIFieldType.StringVector),
            new("Jpn", UIFieldType.StringVector),
            new("Deu", UIFieldType.StringVector),
            new("Fra", UIFieldType.StringVector),
            new("Esp", UIFieldType.StringVector),
            new("Ita", UIFieldType.StringVector),
            new("Por", UIFieldType.StringVector),
            new("Kor", UIFieldType.StringVector),
            new("Cht", UIFieldType.StringVector),
            new("Chs", UIFieldType.StringVector),
        ]),
        new("AtlasData", UIFieldType.Object,
        [
            new("Common", UIFieldType.StringVector),
            new("Eng", UIFieldType.StringVector),
            new("Jpn", UIFieldType.StringVector),
            new("Deu", UIFieldType.StringVector),
            new("Fra", UIFieldType.StringVector),
            new("Esp", UIFieldType.StringVector),
            new("Ita", UIFieldType.StringVector),
            new("Por", UIFieldType.StringVector),
            new("Kor", UIFieldType.StringVector),
            new("Cht", UIFieldType.StringVector),
            new("Chs", UIFieldType.StringVector),
        ]),

        new("Materials", UIFieldType.StringVector),
        new("Animations", UIFieldType.StringVector),
        new("ImageData", UIFieldType.StringVector),
        new("LanguageData", UIFieldType.StringVector),
        new(0x9029CEE4, UIFieldType.StringVector),

        // viewb
        // note: file 49891858950C901A has it in msg format
        new("Layouts", UIFieldType.ObjectArray,
        [
            new("Rotation", UIFieldType.CVec4),
            new("Scale", UIFieldType.CVec3),
            new("Pivot", UIFieldType.CVec2),
            new("AnchorPoint", UIFieldType.CVec2),
            new("AnchorMin", UIFieldType.CVec2),
            new("AnchorMax", UIFieldType.CVec2),
            new("SizeDelta", UIFieldType.CVec2),
            new("OffsetMin", UIFieldType.CVec2),
            new("OffsetMax", UIFieldType.CVec2),
            new("Active", UIFieldType.Bool),
            new("AssetPath", UIFieldType.String),
        ]),

        // langb
        // note: file 43286F3E023A5B1D has it in msg format
        new("FontSettings", UIFieldType.ObjectArray,
        [
            new("Language", UIFieldType.String),
            new("Font", UIFieldType.String),
            new("Material", UIFieldType.String),
            new("FontSizeOffset", UIFieldType.S32),
            new("CharacterSpacingOffset", UIFieldType.F32),
            new("LineSpacingOffset", UIFieldType.F32),
            new("Force", UIFieldType.Bool),
        ]),

        // animb
        new("Curves", UIFieldType.ObjectArray,  // ui::component::AnimationCurve
        [
            new("Attribute", UIFieldType.String),
            new("ObjectRef", UIFieldType.String),
            new("ComponentName", UIFieldType.String),

            // default = ui::asset::AnimationKey
            // 11 = ui::asset::AnimationSpriteKey
            // 12 = ui::asset::AnimationSoundKey
            // 13 = ui::asset::AnimationEventKey
            new("KeyType", UIFieldType.S32),
            new("Elements", UIFieldType.ObjectArray, // ui::component::AnimationElement
            [
                new("Keys", UIFieldType.ObjectArray, // ui::component::AnimationKey
                [
                    new("Time", UIFieldType.F32),
                    new("Value", UIFieldType.F32),
                    new("InSlope", UIFieldType.F32),
                    new("OutSlope", UIFieldType.F32),
                    new("CurveType", UIFieldType.S8),
                    new("InConstant", UIFieldType.Bool),
                    new("OutConstant", UIFieldType.Bool),

                    // Type 11 (ui::asset::AnimationSpriteKey)
                    new("Sprite", UIFieldType.Object,
                    [
                        // ui::SpriteRef
                        new("TexturePath", UIFieldType.String),
                        new("SpriteName", UIFieldType.CyanStringHash),
                    ]),

                    // Type 12 (ui::asset::AnimationSoundKey)
                    new("Id", UIFieldType.S32),

                    // Type 13 (ui::asset::AnimationEventKey)
                    new("Event", UIFieldType.S32),
                ]),
            ])
        ]),
        new("Loop", UIFieldType.Bool),
        new("Time", UIFieldType.F32),
    ];
}
