# GBFRDataTools.Entities

General game entities.

Currently handles:

* All scene hierarchy files in `layout/` as `Scene/SceneHierarchyFile.cs`
* All top level player files in `system/player`
* Equip Preset files `system/preset/*.msg` as `Preset/EquipPresetFile.cs`
* Quest BaseInfo files `quest/<quest_id>/baseinfo.msg` as `Quest/BaseInfo.cs`
* Scenario files `system/scenario` as `Scenario/*.cs`
* Serious Voice file `system/table/voice/serious_voice.msg` as `Table/SeriousVoiceCheckDataFile.cs`
* Text files in `system/table` as `TextDataFile.cs`
