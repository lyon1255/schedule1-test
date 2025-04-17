using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DC RID: 732
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x06003600 RID: 13824 RVA: 0x0011E444 File Offset: 0x0011C644
		// Note: this type is marked as 'beforefieldinit'.
		static NPCScheduleManager()
		{
			Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCScheduleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr);
			NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ScheduleEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<CurfewModeEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "DEBUG_MODE");
			NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActiveAction>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<PendingActions>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<Npc>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringNoCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_ActionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "ActionList");
			NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActionsAwaitingStart>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "lastProcessedTime");
			NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669429);
			NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669430);
			NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669431);
			NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669432);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669433);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669434);
			NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669435);
			NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669436);
			NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669437);
			NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669438);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669439);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669440);
			NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669441);
			NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669442);
			NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669443);
			NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669444);
			NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669445);
			NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669446);
			NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669447);
			NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669448);
			NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669449);
			NPCScheduleManager.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669450);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669451);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669452);
			NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669453);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669454);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669455);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669456);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669457);
			NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669458);
			NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669459);
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x0011E7BC File Offset: 0x0011C9BC
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x0011E7F8 File Offset: 0x0011C9F8
		public unsafe bool ScheduleEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x0011E838 File Offset: 0x0011CA38
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x0011E874 File Offset: 0x0011CA74
		public unsafe bool CurfewModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x0011E8B4 File Offset: 0x0011CAB4
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x0011E8F4 File Offset: 0x0011CAF4
		public unsafe NPCAction ActiveAction
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x0011E938 File Offset: 0x0011CB38
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x0011E978 File Offset: 0x0011CB78
		public unsafe List<NPCAction> PendingActions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x0011E9BC File Offset: 0x0011CBBC
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x0011E9FC File Offset: 0x0011CBFC
		public unsafe NPC Npc
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x0011EA40 File Offset: 0x0011CC40
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x0011EA80 File Offset: 0x0011CC80
		public unsafe List<NPCAction> ActionsAwaitingStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x0011EAC4 File Offset: 0x0011CCC4
		public unsafe TimeManager Time
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 138182, RefRangeEnd = 138186, XrefRangeStart = 138179, XrefRangeEnd = 138182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0011EB04 File Offset: 0x0011CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138186, XrefRangeEnd = 138191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x0011EB40 File Offset: 0x0011CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138191, XrefRangeEnd = 138279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0011EB7C File Offset: 0x0011CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138279, XrefRangeEnd = 138281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x0011EBB0 File Offset: 0x0011CDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138281, XrefRangeEnd = 138285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x0011EBE4 File Offset: 0x0011CDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138285, XrefRangeEnd = 138289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0011EC20 File Offset: 0x0011CE20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138289, RefRangeEnd = 138291, XrefRangeStart = 138289, XrefRangeEnd = 138289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0011EC54 File Offset: 0x0011CE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138295, RefRangeEnd = 138297, XrefRangeStart = 138291, XrefRangeEnd = 138295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0011EC88 File Offset: 0x0011CE88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138350, RefRangeEnd = 138353, XrefRangeStart = 138297, XrefRangeEnd = 138350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x0011ECBC File Offset: 0x0011CEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138353, XrefRangeEnd = 138445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0011ECF8 File Offset: 0x0011CEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138495, RefRangeEnd = 138497, XrefRangeStart = 138445, XrefRangeEnd = 138495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsOccurringAt(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0011ED44 File Offset: 0x0011CF44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138543, RefRangeEnd = 138545, XrefRangeStart = 138497, XrefRangeEnd = 138543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkShouldStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x0011EDAC File Offset: 0x0011CFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138566, RefRangeEnd = 138567, XrefRangeStart = 138545, XrefRangeEnd = 138566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction(NPCAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0011EDF0 File Offset: 0x0011CFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138567, XrefRangeEnd = 138573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0011EE24 File Offset: 0x0011D024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138675, RefRangeEnd = 138677, XrefRangeStart = 138573, XrefRangeEnd = 138675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState(bool initial = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0011EE64 File Offset: 0x0011D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138677, XrefRangeEnd = 138678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0011EEA0 File Offset: 0x0011D0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138678, XrefRangeEnd = 138679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0011EEDC File Offset: 0x0011D0DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138685, RefRangeEnd = 138688, XrefRangeStart = 138679, XrefRangeEnd = 138685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurfewModeEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0011EF1C File Offset: 0x0011D11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138688, XrefRangeEnd = 138706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCScheduleManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0001C58D File Offset: 0x0001A78D
		public NPCScheduleManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x0011EF58 File Offset: 0x0011D158
		// (set) Token: 0x06003622 RID: 13858 RVA: 0x0001C596 File Offset: 0x0001A796
		public unsafe bool _ScheduleEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x0011EF80 File Offset: 0x0011D180
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x0001C5B1 File Offset: 0x0001A7B1
		public unsafe bool _CurfewModeEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x0011EFA8 File Offset: 0x0011D1A8
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x0011EFD0 File Offset: 0x0011D1D0
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x0001C5E7 File Offset: 0x0001A7E7
		public unsafe NPCAction _ActiveAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x0011F000 File Offset: 0x0011D200
		// (set) Token: 0x0600362A RID: 13866 RVA: 0x0001C606 File Offset: 0x0001A806
		public unsafe List<NPCAction> _PendingActions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x0011F030 File Offset: 0x0011D230
		// (set) Token: 0x0600362C RID: 13868 RVA: 0x0001C625 File Offset: 0x0001A825
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x0011F060 File Offset: 0x0011D260
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x0001C644 File Offset: 0x0001A844
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x0011F090 File Offset: 0x0011D290
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x0001C663 File Offset: 0x0001A863
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringNoCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x0011F0C0 File Offset: 0x0011D2C0
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x0001C682 File Offset: 0x0001A882
		public unsafe List<NPCAction> ActionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_ActionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_ActionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x0011F0F0 File Offset: 0x0011D2F0
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x0001C6A1 File Offset: 0x0001A8A1
		public unsafe List<NPCAction> _ActionsAwaitingStart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x0011F120 File Offset: 0x0011D320
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		public unsafe int lastProcessedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime)) = value;
			}
		}

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr__ScheduleEnabled_k__BackingField;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAction_k__BackingField;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeFieldInfoPtr__PendingActions_k__BackingField;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeFieldInfoPtr_EnabledDuringCurfew;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeFieldInfoPtr_EnabledDuringNoCurfew;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeFieldInfoPtr_ActionList;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeFieldInfoPtr_lastProcessedTime;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_EnableSchedule_Public_Void_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_DisableSchedule_Public_Void_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_InitializeActions_Public_Void_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_EnforceState_Private_Void_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092A RID: 2346
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C695 RID: 50837 RVA: 0x00303744 File Offset: 0x00301944
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr);
				NPCScheduleManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__38_0");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__40_0");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__41_0");
				NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669461);
				NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669462);
				NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669463);
				NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669464);
			}

			// Token: 0x0600C696 RID: 50838 RVA: 0x00303810 File Offset: 0x00301A10
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C697 RID: 50839 RVA: 0x0030384C File Offset: 0x00301A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138171, XrefRangeEnd = 138173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitializeActions_b__38_0(NPCAction a, NPCAction b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C698 RID: 50840 RVA: 0x003038AC File Offset: 0x00301AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138173, XrefRangeEnd = 138174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActionsOccurringAt_b__40_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C699 RID: 50841 RVA: 0x003038FC File Offset: 0x00301AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActionsTotallyOccurringWithinRange_b__41_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C69A RID: 50842 RVA: 0x00060AA2 File Offset: 0x0005ECA2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDE RID: 15838
			// (get) Token: 0x0600C69B RID: 50843 RVA: 0x0030394C File Offset: 0x00301B4C
			// (set) Token: 0x0600C69C RID: 50844 RVA: 0x00060AAB File Offset: 0x0005ECAB
			public unsafe static NPCScheduleManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DDF RID: 15839
			// (get) Token: 0x0600C69D RID: 50845 RVA: 0x00303974 File Offset: 0x00301B74
			// (set) Token: 0x0600C69E RID: 50846 RVA: 0x00060ABD File Offset: 0x0005ECBD
			public unsafe static Comparison<NPCAction> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE0 RID: 15840
			// (get) Token: 0x0600C69F RID: 50847 RVA: 0x0030399C File Offset: 0x00301B9C
			// (set) Token: 0x0600C6A0 RID: 50848 RVA: 0x00060ACF File Offset: 0x0005ECCF
			public unsafe static Func<NPCAction, int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCAction, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE1 RID: 15841
			// (get) Token: 0x0600C6A1 RID: 50849 RVA: 0x003039C4 File Offset: 0x00301BC4
			// (set) Token: 0x0600C6A2 RID: 50850 RVA: 0x00060AE1 File Offset: 0x0005ECE1
			public unsafe static Func<NPCAction, int> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCAction, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400866B RID: 34411
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400866C RID: 34412
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x0400866D RID: 34413
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x0400866E RID: 34414
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400866F RID: 34415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008670 RID: 34416
			private static readonly IntPtr NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0;

			// Token: 0x04008671 RID: 34417
			private static readonly IntPtr NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0;

			// Token: 0x04008672 RID: 34418
			private static readonly IntPtr NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0;
		}

		// Token: 0x0200092B RID: 2347
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C6A3 RID: 50851 RVA: 0x003039EC File Offset: 0x00301BEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr);
				NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, "actionsOccurringThisFrame");
				NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, "skippedActionOrder");
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669465);
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669466);
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669467);
			}

			// Token: 0x0600C6A4 RID: 50852 RVA: 0x00303A7C File Offset: 0x00301C7C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6A5 RID: 50853 RVA: 0x00303AB8 File Offset: 0x00301CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138174, XrefRangeEnd = 138175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnforceState_b__0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6A6 RID: 50854 RVA: 0x00303B08 File Offset: 0x00301D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138175, XrefRangeEnd = 138179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _EnforceState_b__1(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6A7 RID: 50855 RVA: 0x00060AF3 File Offset: 0x0005ECF3
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE2 RID: 15842
			// (get) Token: 0x0600C6A8 RID: 50856 RVA: 0x00303B58 File Offset: 0x00301D58
			// (set) Token: 0x0600C6A9 RID: 50857 RVA: 0x00060AFC File Offset: 0x0005ECFC
			public unsafe List<NPCAction> actionsOccurringThisFrame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE3 RID: 15843
			// (get) Token: 0x0600C6AA RID: 50858 RVA: 0x00303B88 File Offset: 0x00301D88
			// (set) Token: 0x0600C6AB RID: 50859 RVA: 0x00060B1B File Offset: 0x0005ED1B
			public unsafe Dictionary<NPCAction, float> skippedActionOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPCAction, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008673 RID: 34419
			private static readonly IntPtr NativeFieldInfoPtr_actionsOccurringThisFrame;

			// Token: 0x04008674 RID: 34420
			private static readonly IntPtr NativeFieldInfoPtr_skippedActionOrder;

			// Token: 0x04008675 RID: 34421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008676 RID: 34422
			private static readonly IntPtr NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0;

			// Token: 0x04008677 RID: 34423
			private static readonly IntPtr NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0;
		}
	}
}
