using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069B RID: 1691
	public class JournalApp : App<JournalApp>
	{
		// Token: 0x0600967F RID: 38527 RVA: 0x00268994 File Offset: 0x00266B94
		// Note: this type is marked as 'beforefieldinit'.
		static JournalApp()
		{
			Il2CppClassPointerStore<JournalApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "JournalApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalApp>.NativeClassPtr);
			JournalApp.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "EntryContainer");
			JournalApp.NativeFieldInfoPtr_NoTasksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoTasksLabel");
			JournalApp.NativeFieldInfoPtr_NoDetailsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoDetailsLabel");
			JournalApp.NativeFieldInfoPtr_DetailsPanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "DetailsPanelContainer");
			JournalApp.NativeFieldInfoPtr_GenericEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericEntry");
			JournalApp.NativeFieldInfoPtr_GenericDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericDetailsPanel");
			JournalApp.NativeFieldInfoPtr_GenericQuestEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericQuestEntry");
			JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestEntryHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanelQuest");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanel");
			JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681900);
			JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681901);
			JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681902);
			JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681903);
			JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681904);
			JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681905);
			JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681906);
			JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681907);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x00268B40 File Offset: 0x00266D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269726, XrefRangeEnd = 269729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x00268B7C File Offset: 0x00266D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269729, XrefRangeEnd = 269748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x00268BB8 File Offset: 0x00266DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269748, XrefRangeEnd = 269758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x00268C04 File Offset: 0x00266E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269758, XrefRangeEnd = 269774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00268C40 File Offset: 0x00266E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269788, RefRangeEnd = 269789, XrefRangeStart = 269774, XrefRangeEnd = 269788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDetailsPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x00268C74 File Offset: 0x00266E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269789, XrefRangeEnd = 269808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x00268CB0 File Offset: 0x00266EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269808, XrefRangeEnd = 269809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x00268CEC File Offset: 0x00266EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269809, XrefRangeEnd = 269815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JournalApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x000490AC File Offset: 0x000472AC
		public JournalApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x06009689 RID: 38537 RVA: 0x00268D28 File Offset: 0x00266F28
		// (set) Token: 0x0600968A RID: 38538 RVA: 0x000490B5 File Offset: 0x000472B5
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600968B RID: 38539 RVA: 0x00268D58 File Offset: 0x00266F58
		// (set) Token: 0x0600968C RID: 38540 RVA: 0x000490D4 File Offset: 0x000472D4
		public unsafe Text NoTasksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x00268D88 File Offset: 0x00266F88
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x000490F3 File Offset: 0x000472F3
		public unsafe Text NoDetailsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x00268DB8 File Offset: 0x00266FB8
		// (set) Token: 0x06009690 RID: 38544 RVA: 0x00049112 File Offset: 0x00047312
		public unsafe RectTransform DetailsPanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x00268DE8 File Offset: 0x00266FE8
		// (set) Token: 0x06009692 RID: 38546 RVA: 0x00049131 File Offset: 0x00047331
		public unsafe GameObject GenericEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x00268E18 File Offset: 0x00267018
		// (set) Token: 0x06009694 RID: 38548 RVA: 0x00049150 File Offset: 0x00047350
		public unsafe GameObject GenericDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x00268E48 File Offset: 0x00267048
		// (set) Token: 0x06009696 RID: 38550 RVA: 0x0004916F File Offset: 0x0004736F
		public unsafe GameObject GenericQuestEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x06009697 RID: 38551 RVA: 0x00268E78 File Offset: 0x00267078
		// (set) Token: 0x06009698 RID: 38552 RVA: 0x0004918E File Offset: 0x0004738E
		public unsafe QuestHUDUI QuestHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x06009699 RID: 38553 RVA: 0x00268EA8 File Offset: 0x002670A8
		// (set) Token: 0x0600969A RID: 38554 RVA: 0x000491AD File Offset: 0x000473AD
		public unsafe QuestEntryHUDUI QuestEntryHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600969B RID: 38555 RVA: 0x00268ED8 File Offset: 0x002670D8
		// (set) Token: 0x0600969C RID: 38556 RVA: 0x000491CC File Offset: 0x000473CC
		public unsafe Quest currentDetailsPanelQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600969D RID: 38557 RVA: 0x00268F08 File Offset: 0x00267108
		// (set) Token: 0x0600969E RID: 38558 RVA: 0x000491EB File Offset: 0x000473EB
		public unsafe RectTransform currentDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006573 RID: 25971
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04006574 RID: 25972
		private static readonly IntPtr NativeFieldInfoPtr_NoTasksLabel;

		// Token: 0x04006575 RID: 25973
		private static readonly IntPtr NativeFieldInfoPtr_NoDetailsLabel;

		// Token: 0x04006576 RID: 25974
		private static readonly IntPtr NativeFieldInfoPtr_DetailsPanelContainer;

		// Token: 0x04006577 RID: 25975
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntry;

		// Token: 0x04006578 RID: 25976
		private static readonly IntPtr NativeFieldInfoPtr_GenericDetailsPanel;

		// Token: 0x04006579 RID: 25977
		private static readonly IntPtr NativeFieldInfoPtr_GenericQuestEntry;

		// Token: 0x0400657A RID: 25978
		private static readonly IntPtr NativeFieldInfoPtr_QuestHUDUIPrefab;

		// Token: 0x0400657B RID: 25979
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryHUDUIPrefab;

		// Token: 0x0400657C RID: 25980
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanelQuest;

		// Token: 0x0400657D RID: 25981
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanel;

		// Token: 0x0400657E RID: 25982
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400657F RID: 25983
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006580 RID: 25984
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006581 RID: 25985
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006582 RID: 25986
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0;

		// Token: 0x04006583 RID: 25987
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006584 RID: 25988
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006585 RID: 25989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
