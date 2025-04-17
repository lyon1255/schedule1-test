using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E3 RID: 739
	[Serializable]
	public class NPCAction : NetworkBehaviour
	{
		// Token: 0x06003743 RID: 14147 RVA: 0x001231EC File Offset: 0x001213EC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAction()
		{
			Il2CppClassPointerStore<NPCAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAction>.NativeClassPtr);
			NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			NPCAction.NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "<IsActive>k__BackingField");
			NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "<HasStarted>k__BackingField");
			NPCAction.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "priority");
			NPCAction.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "StartTime");
			NPCAction.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "npc");
			NPCAction.NativeFieldInfoPtr_schedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "schedule");
			NPCAction.NativeFieldInfoPtr_onEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "onEnded");
			NPCAction.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "consecutivePathingFailures");
			NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted");
			NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted");
			NPCAction.NativeMethodInfoPtr_get_ActionName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669641);
			NPCAction.NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669642);
			NPCAction.NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669643);
			NPCAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669644);
			NPCAction.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669645);
			NPCAction.NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669646);
			NPCAction.NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669647);
			NPCAction.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669648);
			NPCAction.NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669649);
			NPCAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669650);
			NPCAction.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669651);
			NPCAction.NativeMethodInfoPtr_GetReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669652);
			NPCAction.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669653);
			NPCAction.NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669654);
			NPCAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669655);
			NPCAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669656);
			NPCAction.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669657);
			NPCAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669658);
			NPCAction.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669659);
			NPCAction.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669660);
			NPCAction.NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669661);
			NPCAction.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669662);
			NPCAction.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669663);
			NPCAction.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669664);
			NPCAction.NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669665);
			NPCAction.NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669666);
			NPCAction.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669667);
			NPCAction.NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669668);
			NPCAction.NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669669);
			NPCAction.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669670);
			NPCAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669671);
			NPCAction.NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669672);
			NPCAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669673);
			NPCAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669674);
			NPCAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669675);
			NPCAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669676);
			NPCAction.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669677);
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x001235DC File Offset: 0x001217DC
		public unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140228, XrefRangeEnd = 140230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_ActionName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x00123614 File Offset: 0x00121814
		public unsafe bool IsEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140230, XrefRangeEnd = 140231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x00123650 File Offset: 0x00121850
		public unsafe bool IsSignal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 140232, RefRangeEnd = 140233, XrefRangeStart = 140231, XrefRangeEnd = 140232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x0012368C File Offset: 0x0012188C
		// (set) Token: 0x06003748 RID: 14152 RVA: 0x001236C8 File Offset: 0x001218C8
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x00123708 File Offset: 0x00121908
		// (set) Token: 0x0600374A RID: 14154 RVA: 0x00123744 File Offset: 0x00121944
		public unsafe bool HasStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x00123784 File Offset: 0x00121984
		public unsafe virtual int Priority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x001237CC File Offset: 0x001219CC
		public unsafe NPCMovement movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr3) : null;
			}
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0012380C File Offset: 0x00121A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140234, RefRangeEnd = 140236, XrefRangeStart = 140233, XrefRangeEnd = 140234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00123848 File Offset: 0x00121A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140236, XrefRangeEnd = 140238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00123884 File Offset: 0x00121A84
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 140253, RefRangeEnd = 140280, XrefRangeStart = 140238, XrefRangeEnd = 140253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_GetReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x001238B8 File Offset: 0x00121AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140296, RefRangeEnd = 140297, XrefRangeStart = 140280, XrefRangeEnd = 140296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x001238F4 File Offset: 0x00121AF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140306, RefRangeEnd = 140311, XrefRangeStart = 140297, XrefRangeEnd = 140306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00123930 File Offset: 0x00121B30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140320, RefRangeEnd = 140325, XrefRangeStart = 140311, XrefRangeEnd = 140320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0012396C File Offset: 0x00121B6C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 140334, RefRangeEnd = 140342, XrefRangeStart = 140325, XrefRangeEnd = 140334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001239A8 File Offset: 0x00121BA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 140351, RefRangeEnd = 140359, XrefRangeStart = 140342, XrefRangeEnd = 140351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x001239E4 File Offset: 0x00121BE4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 140374, RefRangeEnd = 140386, XrefRangeStart = 140359, XrefRangeEnd = 140374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00123A20 File Offset: 0x00121C20
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 140401, RefRangeEnd = 140411, XrefRangeStart = 140386, XrefRangeEnd = 140401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00123A5C File Offset: 0x00121C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140411, XrefRangeEnd = 140425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResumeFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00123A98 File Offset: 0x00121C98
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 140435, RefRangeEnd = 140445, XrefRangeStart = 140425, XrefRangeEnd = 140435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00123AD4 File Offset: 0x00121CD4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00123B10 File Offset: 0x00121D10
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00123B4C File Offset: 0x00121D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140445, XrefRangeEnd = 140449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PendingMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00123B88 File Offset: 0x00121D88
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00123BC4 File Offset: 0x00121DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140449, XrefRangeEnd = 140451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00123C0C File Offset: 0x00121E0C
		[CallerCount(0)]
		public unsafe virtual string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00123C50 File Offset: 0x00121E50
		[CallerCount(0)]
		public unsafe virtual string GetTimeDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00123C94 File Offset: 0x00121E94
		[CallerCount(0)]
		public unsafe virtual int GetEndTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00123CDC File Offset: 0x00121EDC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 140464, RefRangeEnd = 140495, XrefRangeStart = 140451, XrefRangeEnd = 140464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00123D28 File Offset: 0x00121F28
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 140506, RefRangeEnd = 140517, XrefRangeStart = 140495, XrefRangeEnd = 140506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00123D74 File Offset: 0x00121F74
		[CallerCount(0)]
		public unsafe virtual void SetStartTime(int startTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00123DC0 File Offset: 0x00121FC0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x00123DFC File Offset: 0x00121FFC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00123E38 File Offset: 0x00122038
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00123E74 File Offset: 0x00122074
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00123EB0 File Offset: 0x001220B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140517, XrefRangeEnd = 140518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x0001CC84 File Offset: 0x0001AE84
		public NPCAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x00123EEC File Offset: 0x001220EC
		// (set) Token: 0x0600376B RID: 14187 RVA: 0x0001CC8D File Offset: 0x0001AE8D
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x00123F08 File Offset: 0x00122108
		// (set) Token: 0x0600376D RID: 14189 RVA: 0x0001CC9B File Offset: 0x0001AE9B
		public unsafe bool _IsActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__IsActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__IsActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x00123F30 File Offset: 0x00122130
		// (set) Token: 0x0600376F RID: 14191 RVA: 0x0001CCB6 File Offset: 0x0001AEB6
		public unsafe bool _HasStarted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField)) = value;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x00123F58 File Offset: 0x00122158
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x0001CCD1 File Offset: 0x0001AED1
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x00123F80 File Offset: 0x00122180
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x0001CCEC File Offset: 0x0001AEEC
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x00123FA8 File Offset: 0x001221A8
		// (set) Token: 0x06003775 RID: 14197 RVA: 0x0001CD07 File Offset: 0x0001AF07
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x00123FD8 File Offset: 0x001221D8
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x0001CD26 File Offset: 0x0001AF26
		public unsafe NPCScheduleManager schedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_schedule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_schedule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x00124008 File Offset: 0x00122208
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x0001CD45 File Offset: 0x0001AF45
		public unsafe Action onEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_onEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_onEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x00124038 File Offset: 0x00122238
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x0001CD64 File Offset: 0x0001AF64
		public unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x00124060 File Offset: 0x00122260
		// (set) Token: 0x0600377D RID: 14205 RVA: 0x0001CD7F File Offset: 0x0001AF7F
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x00124088 File Offset: 0x00122288
		// (set) Token: 0x0600377F RID: 14207 RVA: 0x0001CD9A File Offset: 0x0001AF9A
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeFieldInfoPtr__HasStarted_k__BackingField;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeFieldInfoPtr_schedule;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeFieldInfoPtr_onEnded;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Protected_get_String_0;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_GetReferences_Private_Void_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_New_Void_0;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
