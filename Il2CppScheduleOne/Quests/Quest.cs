using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Compass;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class Quest : MonoBehaviour
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x000E2408 File Offset: 0x000E0608
		// Note: this type is marked as 'beforefieldinit'.
		static Quest()
		{
			Il2CppClassPointerStore<Quest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest>.NativeClassPtr);
			Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "MAX_HUD_ENTRY_LABELS");
			Quest.NativeFieldInfoPtr_CriticalExpiryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CriticalExpiryThreshold");
			Quest.NativeFieldInfoPtr_Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Quests");
			Quest.NativeFieldInfoPtr_HoveredQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "HoveredQuest");
			Quest.NativeFieldInfoPtr_ActiveQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ActiveQuests");
			Quest.NativeFieldInfoPtr__QuestState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<QuestState>k__BackingField");
			Quest.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<GUID>k__BackingField");
			Quest.NativeFieldInfoPtr__IsTracked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<IsTracked>k__BackingField");
			Quest.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "title");
			Quest.NativeFieldInfoPtr_Subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Subtitle");
			Quest.NativeFieldInfoPtr_onSubtitleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onSubtitleChanged");
			Quest.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Description");
			Quest.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "StaticGUID");
			Quest.NativeFieldInfoPtr_TrackOnBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "TrackOnBegin");
			Quest.NativeFieldInfoPtr_ExpiryVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ExpiryVisibility");
			Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoCompleteOnAllEntriesComplete");
			Quest.NativeFieldInfoPtr_PlayQuestCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PlayQuestCompleteSound");
			Quest.NativeFieldInfoPtr_CompletionXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CompletionXP");
			Quest.NativeFieldInfoPtr__Expires_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expires>k__BackingField");
			Quest.NativeFieldInfoPtr__Expiry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expiry>k__BackingField");
			Quest.NativeFieldInfoPtr_AutoStartFirstEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoStartFirstEntry");
			Quest.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Entries");
			Quest.NativeFieldInfoPtr_IconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "IconPrefab");
			Quest.NativeFieldInfoPtr_PoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PoIPrefab");
			Quest.NativeFieldInfoPtr_onQuestBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestBegin");
			Quest.NativeFieldInfoPtr_onQuestEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestEnd");
			Quest.NativeFieldInfoPtr_onActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onActiveState");
			Quest.NativeFieldInfoPtr_onTrackChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onTrackChange");
			Quest.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onComplete");
			Quest.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onInitialComplete");
			Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiryReminder");
			Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiredNotification");
			Quest.NativeFieldInfoPtr_journalEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "journalEntry");
			Quest.NativeFieldInfoPtr_entryTitleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTitleRect");
			Quest.NativeFieldInfoPtr_trackedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "trackedRect");
			Quest.NativeFieldInfoPtr_entryTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTimeLabel");
			Quest.NativeFieldInfoPtr_criticalTimeBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "criticalTimeBackground");
			Quest.NativeFieldInfoPtr_detailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "detailPanel");
			Quest.NativeFieldInfoPtr__hudUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<hudUI>k__BackingField");
			Quest.NativeFieldInfoPtr_onHudUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onHudUICreated");
			Quest.NativeFieldInfoPtr_expiryReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "expiryReminderSent");
			Quest.NativeFieldInfoPtr_compassElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "compassElement");
			Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Quest.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<HasChanged>k__BackingField");
			Quest.NativeFieldInfoPtr_autoInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "autoInitialize");
			Quest.NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667352);
			Quest.NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667353);
			Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667354);
			Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667355);
			Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667356);
			Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667357);
			Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667358);
			Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667359);
			Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667360);
			Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667361);
			Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667362);
			Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667363);
			Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667364);
			Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667365);
			Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667366);
			Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667367);
			Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667368);
			Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667369);
			Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667370);
			Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667371);
			Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667372);
			Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667373);
			Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667374);
			Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667375);
			Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667376);
			Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667377);
			Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667378);
			Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667379);
			Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667380);
			Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667381);
			Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667382);
			Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667383);
			Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667384);
			Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667385);
			Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667386);
			Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667387);
			Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667388);
			Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667389);
			Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667390);
			Quest.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667391);
			Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667392);
			Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667393);
			Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667394);
			Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667395);
			Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667396);
			Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667397);
			Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667398);
			Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667399);
			Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667400);
			Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667401);
			Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667402);
			Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667403);
			Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667404);
			Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667405);
			Quest.NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667406);
			Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667407);
			Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667408);
			Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667409);
			Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667410);
			Quest.NativeMethodInfoPtr_DestroyHudUI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667411);
			Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667412);
			Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667413);
			Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667414);
			Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667415);
			Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667416);
			Quest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667417);
			Quest.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667419);
			Quest.NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667420);
			Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667421);
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000E2D34 File Offset: 0x000E0F34
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x000E2D70 File Offset: 0x000E0F70
		public unsafe EQuestState QuestState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20566, RefRangeEnd = 20567, XrefRangeStart = 20566, XrefRangeEnd = 20567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29975, RefRangeEnd = 29976, XrefRangeStart = 29975, XrefRangeEnd = 29976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000E2DB0 File Offset: 0x000E0FB0
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x000E2DEC File Offset: 0x000E0FEC
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000E2E2C File Offset: 0x000E102C
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x000E2E68 File Offset: 0x000E1068
		public unsafe bool IsTracked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x000E2EA8 File Offset: 0x000E10A8
		public unsafe int ActiveEntryCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 113705, RefRangeEnd = 113706, XrefRangeStart = 113687, XrefRangeEnd = 113705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x000E2EE4 File Offset: 0x000E10E4
		public unsafe string Title
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 113706, RefRangeEnd = 113707, XrefRangeStart = 113706, XrefRangeEnd = 113706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x000E2F1C File Offset: 0x000E111C
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x000E2F58 File Offset: 0x000E1158
		public unsafe bool Expires
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x000E2F98 File Offset: 0x000E1198
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x000E2FD4 File Offset: 0x000E11D4
		public unsafe GameDateTime Expiry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x000E3014 File Offset: 0x000E1214
		public unsafe bool hudUIExists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113707, XrefRangeEnd = 113711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000E3050 File Offset: 0x000E1250
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x000E3090 File Offset: 0x000E1290
		public unsafe QuestHUDUI hudUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000E30D4 File Offset: 0x000E12D4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113711, XrefRangeEnd = 113716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x000E310C File Offset: 0x000E130C
		public unsafe virtual string SaveFileName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 113721, RefRangeEnd = 113723, XrefRangeStart = 113716, XrefRangeEnd = 113721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000E3144 File Offset: 0x000E1344
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x000E3184 File Offset: 0x000E1384
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000E31C0 File Offset: 0x000E13C0
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000E3200 File Offset: 0x000E1400
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113723, XrefRangeEnd = 113724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000E3244 File Offset: 0x000E1444
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x000E3284 File Offset: 0x000E1484
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000E32C8 File Offset: 0x000E14C8
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x000E3304 File Offset: 0x000E1504
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000E3344 File Offset: 0x000E1544
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000E3380 File Offset: 0x000E1580
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 113763, RefRangeEnd = 113769, XrefRangeStart = 113724, XrefRangeEnd = 113763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x000E33BC File Offset: 0x000E15BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113830, RefRangeEnd = 113831, XrefRangeStart = 113769, XrefRangeEnd = 113830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeQuest(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000E3440 File Offset: 0x000E1640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113831, XrefRangeEnd = 113837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000E347C File Offset: 0x000E167C
		[CallerCount(0)]
		public unsafe void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expires;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000E34C8 File Offset: 0x000E16C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113848, RefRangeEnd = 113852, XrefRangeStart = 113837, XrefRangeEnd = 113848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x000E3514 File Offset: 0x000E1714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113878, RefRangeEnd = 113879, XrefRangeStart = 113852, XrefRangeEnd = 113878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x000E3560 File Offset: 0x000E1760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113879, XrefRangeEnd = 113885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fail(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000E35AC File Offset: 0x000E17AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113885, XrefRangeEnd = 113890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Expire(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000E35F8 File Offset: 0x000E17F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113890, XrefRangeEnd = 113896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000E3644 File Offset: 0x000E1844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113937, RefRangeEnd = 113939, XrefRangeStart = 113896, XrefRangeEnd = 113937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000E3680 File Offset: 0x000E1880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113987, RefRangeEnd = 113990, XrefRangeStart = 113939, XrefRangeEnd = 113987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x000E36D8 File Offset: 0x000E18D8
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000E3720 File Offset: 0x000E1920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114001, RefRangeEnd = 114002, XrefRangeStart = 113990, XrefRangeEnd = 114001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000E3788 File Offset: 0x000E1988
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 114013, RefRangeEnd = 114027, XrefRangeStart = 114002, XrefRangeEnd = 114013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000E37C4 File Offset: 0x000E19C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114027, XrefRangeEnd = 114029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000E3800 File Offset: 0x000E1A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114029, XrefRangeEnd = 114034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAutoComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000E3834 File Offset: 0x000E1A34
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000E387C File Offset: 0x000E1A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114034, XrefRangeEnd = 114045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000E38B8 File Offset: 0x000E1AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114045, XrefRangeEnd = 114056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000E38F4 File Offset: 0x000E1AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114056, XrefRangeEnd = 114060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000E3934 File Offset: 0x000E1B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubtitle(string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000E3978 File Offset: 0x000E1B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114060, XrefRangeEnd = 114084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsTracked(bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000E39C4 File Offset: 0x000E1BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114084, XrefRangeEnd = 114181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000E3A00 File Offset: 0x000E1C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114181, XrefRangeEnd = 114190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000E3A34 File Offset: 0x000E1C34
		[CallerCount(0)]
		public unsafe void JournalEntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000E3A68 File Offset: 0x000E1C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114190, XrefRangeEnd = 114196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JournalEntryHoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000E3A9C File Offset: 0x000E1C9C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 114202, RefRangeEnd = 114209, XrefRangeStart = 114196, XrefRangeEnd = 114202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMinsUntilExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000E3AD8 File Offset: 0x000E1CD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114215, RefRangeEnd = 114218, XrefRangeStart = 114209, XrefRangeEnd = 114215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExpiryText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000E3B10 File Offset: 0x000E1D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114218, XrefRangeEnd = 114243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual QuestHUDUI SetupHudUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr3) : null;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000E3B5C File Offset: 0x000E1D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114243, XrefRangeEnd = 114244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000E3B90 File Offset: 0x000E1D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114244, XrefRangeEnd = 114249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000E3BC4 File Offset: 0x000E1DC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetQuestTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000E3C08 File Offset: 0x000E1E08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114256, RefRangeEnd = 114258, XrefRangeStart = 114249, XrefRangeEnd = 114256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry GetFirstActiveEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr3) : null;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000E3C48 File Offset: 0x000E1E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114258, XrefRangeEnd = 114266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHudUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyHudUI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000E3C7C File Offset: 0x000E1E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114266, XrefRangeEnd = 114387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000E3CD8 File Offset: 0x000E1ED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114397, RefRangeEnd = 114399, XrefRangeStart = 114387, XrefRangeEnd = 114397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDetailDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000E3D0C File Offset: 0x000E1F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114399, XrefRangeEnd = 114431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000E3D50 File Offset: 0x000E1F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114431, XrefRangeEnd = 114453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(QuestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x000E3DA0 File Offset: 0x000E1FA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 114472, RefRangeEnd = 114477, XrefRangeStart = 114453, XrefRangeEnd = 114472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quest GetQuest(string questName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr3) : null;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x000E3DE4 File Offset: 0x000E1FE4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 114506, RefRangeEnd = 114528, XrefRangeStart = 114477, XrefRangeEnd = 114506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x000E3E20 File Offset: 0x000E2020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114567, RefRangeEnd = 114568, XrefRangeStart = 114528, XrefRangeEnd = 114567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x000E3E54 File Offset: 0x000E2054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114568, XrefRangeEnd = 114574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupJournalEntry_b__110_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000E3E98 File Offset: 0x000E2098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114574, XrefRangeEnd = 114603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x000148E2 File Offset: 0x00012AE2
		public Quest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x000E3ECC File Offset: 0x000E20CC
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x000148EB File Offset: 0x00012AEB
		public unsafe static int MAX_HUD_ENTRY_LABELS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&value));
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000E3EE8 File Offset: 0x000E20E8
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x000148F9 File Offset: 0x00012AF9
		public unsafe static int CriticalExpiryThreshold
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000E3F04 File Offset: 0x000E2104
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00014907 File Offset: 0x00012B07
		public unsafe static List<Quest> Quests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_Quests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_Quests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000E3F2C File Offset: 0x000E212C
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x00014919 File Offset: 0x00012B19
		public unsafe static Quest HoveredQuest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_HoveredQuest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_HoveredQuest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x000E3F54 File Offset: 0x000E2154
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x0001492B File Offset: 0x00012B2B
		public unsafe static List<Quest> ActiveQuests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_ActiveQuests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_ActiveQuests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000E3F7C File Offset: 0x000E217C
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x0001493D File Offset: 0x00012B3D
		public unsafe EQuestState _QuestState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__QuestState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__QuestState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000E3FA4 File Offset: 0x000E21A4
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x00014958 File Offset: 0x00012B58
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000E3FCC File Offset: 0x000E21CC
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x00014973 File Offset: 0x00012B73
		public unsafe bool _IsTracked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000E3FF4 File Offset: 0x000E21F4
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x0001498E File Offset: 0x00012B8E
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000E401C File Offset: 0x000E221C
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x000149AD File Offset: 0x00012BAD
		public unsafe string Subtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000E4044 File Offset: 0x000E2244
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x000149CC File Offset: 0x00012BCC
		public unsafe Action onSubtitleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000E4074 File Offset: 0x000E2274
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x000149EB File Offset: 0x00012BEB
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000E409C File Offset: 0x000E229C
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x00014A0A File Offset: 0x00012C0A
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000E40C4 File Offset: 0x000E22C4
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x00014A29 File Offset: 0x00012C29
		public unsafe bool TrackOnBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin)) = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x000E40EC File Offset: 0x000E22EC
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x00014A44 File Offset: 0x00012C44
		public unsafe EExpiryVisibility ExpiryVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000E4114 File Offset: 0x000E2314
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x00014A5F File Offset: 0x00012C5F
		public unsafe bool AutoCompleteOnAllEntriesComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete)) = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000E413C File Offset: 0x000E233C
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x00014A7A File Offset: 0x00012C7A
		public unsafe bool PlayQuestCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound)) = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000E4164 File Offset: 0x000E2364
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x00014A95 File Offset: 0x00012C95
		public unsafe int CompletionXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP)) = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x000E418C File Offset: 0x000E238C
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x00014AB0 File Offset: 0x00012CB0
		public unsafe bool _Expires_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000E41B4 File Offset: 0x000E23B4
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x00014ACB File Offset: 0x00012CCB
		public unsafe GameDateTime _Expiry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000E41DC File Offset: 0x000E23DC
		// (set) Token: 0x06002514 RID: 9492 RVA: 0x00014AE6 File Offset: 0x00012CE6
		public unsafe bool AutoStartFirstEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry)) = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x000E4204 File Offset: 0x000E2404
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x00014B01 File Offset: 0x00012D01
		public unsafe List<QuestEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000E4234 File Offset: 0x000E2434
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x00014B20 File Offset: 0x00012D20
		public unsafe RectTransform IconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000E4264 File Offset: 0x000E2464
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x00014B3F File Offset: 0x00012D3F
		public unsafe GameObject PoIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x000E4294 File Offset: 0x000E2494
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x00014B5E File Offset: 0x00012D5E
		public unsafe UnityEvent onQuestBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x000E42C4 File Offset: 0x000E24C4
		// (set) Token: 0x0600251E RID: 9502 RVA: 0x00014B7D File Offset: 0x00012D7D
		public unsafe UnityEvent<EQuestState> onQuestEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuestState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600251F RID: 9503 RVA: 0x000E42F4 File Offset: 0x000E24F4
		// (set) Token: 0x06002520 RID: 9504 RVA: 0x00014B9C File Offset: 0x00012D9C
		public unsafe UnityEvent onActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000E4324 File Offset: 0x000E2524
		// (set) Token: 0x06002522 RID: 9506 RVA: 0x00014BBB File Offset: 0x00012DBB
		public unsafe UnityEvent<bool> onTrackChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x000E4354 File Offset: 0x000E2554
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x00014BDA File Offset: 0x00012DDA
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000E4384 File Offset: 0x000E2584
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x00014BF9 File Offset: 0x00012DF9
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x000E43B4 File Offset: 0x000E25B4
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x00014C18 File Offset: 0x00012E18
		public unsafe bool ShouldSendExpiryReminder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder)) = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000E43DC File Offset: 0x000E25DC
		// (set) Token: 0x0600252A RID: 9514 RVA: 0x00014C33 File Offset: 0x00012E33
		public unsafe bool ShouldSendExpiredNotification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification)) = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x000E4404 File Offset: 0x000E2604
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x00014C4E File Offset: 0x00012E4E
		public unsafe RectTransform journalEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x000E4434 File Offset: 0x000E2634
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x00014C6D File Offset: 0x00012E6D
		public unsafe RectTransform entryTitleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x000E4464 File Offset: 0x000E2664
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x00014C8C File Offset: 0x00012E8C
		public unsafe RectTransform trackedRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x000E4494 File Offset: 0x000E2694
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x00014CAB File Offset: 0x00012EAB
		public unsafe Text entryTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000E44C4 File Offset: 0x000E26C4
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x00014CCA File Offset: 0x00012ECA
		public unsafe Image criticalTimeBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x000E44F4 File Offset: 0x000E26F4
		// (set) Token: 0x06002536 RID: 9526 RVA: 0x00014CE9 File Offset: 0x00012EE9
		public unsafe RectTransform detailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x000E4524 File Offset: 0x000E2724
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x00014D08 File Offset: 0x00012F08
		public unsafe QuestHUDUI _hudUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x000E4554 File Offset: 0x000E2754
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x00014D27 File Offset: 0x00012F27
		public unsafe Action onHudUICreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x000E4584 File Offset: 0x000E2784
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x00014D46 File Offset: 0x00012F46
		public unsafe bool expiryReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent)) = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000E45AC File Offset: 0x000E27AC
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x00014D61 File Offset: 0x00012F61
		public unsafe CompassManager.Element compassElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_compassElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_compassElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000E45DC File Offset: 0x000E27DC
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x00014D80 File Offset: 0x00012F80
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x000E460C File Offset: 0x000E280C
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x00014D9F File Offset: 0x00012F9F
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000E463C File Offset: 0x000E283C
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x00014DBE File Offset: 0x00012FBE
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x000E4664 File Offset: 0x000E2864
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x00014DD9 File Offset: 0x00012FD9
		public unsafe bool autoInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize)) = value;
			}
		}

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeFieldInfoPtr_CriticalExpiryThreshold;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_Quests;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_HoveredQuest;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr_ActiveQuests;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr__QuestState_k__BackingField;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr__IsTracked_k__BackingField;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_Subtitle;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr_onSubtitleChanged;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr_TrackOnBegin;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryVisibility;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeFieldInfoPtr_PlayQuestCompleteSound;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeFieldInfoPtr_CompletionXP;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeFieldInfoPtr__Expires_k__BackingField;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeFieldInfoPtr__Expiry_k__BackingField;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeFieldInfoPtr_AutoStartFirstEntry;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr_IconPrefab;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr_PoIPrefab;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeFieldInfoPtr_onQuestBegin;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeFieldInfoPtr_onQuestEnd;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeFieldInfoPtr_onActiveState;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeFieldInfoPtr_onTrackChange;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSendExpiryReminder;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSendExpiredNotification;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr_journalEntry;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeFieldInfoPtr_entryTitleRect;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeFieldInfoPtr_trackedRect;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeFieldInfoPtr_entryTimeLabel;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeFieldInfoPtr_criticalTimeBackground;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeFieldInfoPtr_detailPanel;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeFieldInfoPtr__hudUI_k__BackingField;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeFieldInfoPtr_onHudUICreated;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeFieldInfoPtr_expiryReminderSent;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeFieldInfoPtr_compassElement;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeFieldInfoPtr_autoInitialize;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_GetExpiryText_Public_String_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_BopHUDUI_Public_Void_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHudUI_Private_Void_1;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x020008CD RID: 2253
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C3F4 RID: 50164 RVA: 0x002FC1C4 File Offset: 0x002FA3C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr);
				Quest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9");
				Quest.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9__18_0");
				Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667423);
				Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667424);
			}

			// Token: 0x0600C3F5 RID: 50165 RVA: 0x002FC240 File Offset: 0x002FA440
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3F6 RID: 50166 RVA: 0x002FC27C File Offset: 0x002FA47C
			[CallerCount(0)]
			public unsafe bool _get_ActiveEntryCount_b__18_0(QuestEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3F7 RID: 50167 RVA: 0x0005F62E File Offset: 0x0005D82E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2C RID: 15660
			// (get) Token: 0x0600C3F8 RID: 50168 RVA: 0x002FC2CC File Offset: 0x002FA4CC
			// (set) Token: 0x0600C3F9 RID: 50169 RVA: 0x0005F637 File Offset: 0x0005D837
			public unsafe static Quest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D2D RID: 15661
			// (get) Token: 0x0600C3FA RID: 50170 RVA: 0x002FC2F4 File Offset: 0x002FA4F4
			// (set) Token: 0x0600C3FB RID: 50171 RVA: 0x0005F649 File Offset: 0x0005D849
			public unsafe static Func<QuestEntry, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084CE RID: 33998
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084CF RID: 33999
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x040084D0 RID: 34000
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084D1 RID: 34001
			private static readonly IntPtr NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0;
		}

		// Token: 0x020008CE RID: 2254
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c__DisplayClass126_0")]
		public sealed class __c__DisplayClass126_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3FC RID: 50172 RVA: 0x002FC31C File Offset: 0x002FA51C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass126_0()
			{
				Il2CppClassPointerStore<Quest.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c__DisplayClass126_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c__DisplayClass126_0>.NativeClassPtr);
				Quest.__c__DisplayClass126_0.NativeFieldInfoPtr_questName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c__DisplayClass126_0>.NativeClassPtr, "questName");
				Quest.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass126_0>.NativeClassPtr, 100667425);
				Quest.__c__DisplayClass126_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass126_0>.NativeClassPtr, 100667426);
			}

			// Token: 0x0600C3FD RID: 50173 RVA: 0x002FC384 File Offset: 0x002FA584
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass126_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c__DisplayClass126_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3FE RID: 50174 RVA: 0x002FC3C0 File Offset: 0x002FA5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113683, XrefRangeEnd = 113687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetQuest_b__0(Quest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass126_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3FF RID: 50175 RVA: 0x0005F65B File Offset: 0x0005D85B
			public __c__DisplayClass126_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2E RID: 15662
			// (get) Token: 0x0600C400 RID: 50176 RVA: 0x002FC410 File Offset: 0x002FA610
			// (set) Token: 0x0600C401 RID: 50177 RVA: 0x0005F664 File Offset: 0x0005D864
			public unsafe string questName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass126_0.NativeFieldInfoPtr_questName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass126_0.NativeFieldInfoPtr_questName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040084D2 RID: 34002
			private static readonly IntPtr NativeFieldInfoPtr_questName;

			// Token: 0x040084D3 RID: 34003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084D4 RID: 34004
			private static readonly IntPtr NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0;
		}
	}
}
