using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E2 RID: 738
	public class NPCEvent_StayInBuilding : NPCEvent
	{
		// Token: 0x06003718 RID: 14104 RVA: 0x00122710 File Offset: 0x00120910
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_StayInBuilding()
		{
			Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_StayInBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr);
			NPCEvent_StayInBuilding.NativeFieldInfoPtr_Building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "Building");
			NPCEvent_StayInBuilding.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "Door");
			NPCEvent_StayInBuilding.NativeFieldInfoPtr_IsEntering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "IsEntering");
			NPCEvent_StayInBuilding.NativeFieldInfoPtr_enterRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "enterRoutine");
			NPCEvent_StayInBuilding.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted");
			NPCEvent_StayInBuilding.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted");
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669606);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_get_InBuilding_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669607);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669608);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669609);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669610);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669611);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669612);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669613);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669614);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669615);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669616);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669617);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669618);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_PlayEnterAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669619);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_CancelEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669620);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_EnterBuilding_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669621);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_ExitBuilding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669622);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_GetEntryPoint_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669623);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_GetDoor_Private_StaticDoor_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669624);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669625);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669626);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr__PlayEnterAnimation_b__19_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669627);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669628);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669629);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669630);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_RpcWriter___Observers_PlayEnterAnimation_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669631);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_RpcLogic___PlayEnterAnimation_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669632);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_RpcReader___Observers_PlayEnterAnimation_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669633);
			NPCEvent_StayInBuilding.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, 100669634);
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x001229FC File Offset: 0x00120BFC
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139996, XrefRangeEnd = 139998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x00122A34 File Offset: 0x00120C34
		public unsafe bool InBuilding
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 140003, RefRangeEnd = 140008, XrefRangeStart = 139998, XrefRangeEnd = 140003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_get_InBuilding_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00122A70 File Offset: 0x00120C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140008, XrefRangeEnd = 140009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00122AAC File Offset: 0x00120CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140009, XrefRangeEnd = 140021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00122AF0 File Offset: 0x00120CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140021, XrefRangeEnd = 140030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00122B2C File Offset: 0x00120D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140030, XrefRangeEnd = 140070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00122B68 File Offset: 0x00120D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140070, XrefRangeEnd = 140079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00122BA4 File Offset: 0x00120DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140079, XrefRangeEnd = 140084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x00122BE0 File Offset: 0x00120DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140084, XrefRangeEnd = 140088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x00122C1C File Offset: 0x00120E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140088, XrefRangeEnd = 140092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00122C58 File Offset: 0x00120E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140092, XrefRangeEnd = 140093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00122C94 File Offset: 0x00120E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140093, XrefRangeEnd = 140099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00122CD0 File Offset: 0x00120ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140099, XrefRangeEnd = 140102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00122D1C File Offset: 0x00120F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140123, RefRangeEnd = 140125, XrefRangeStart = 140102, XrefRangeEnd = 140123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayEnterAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_PlayEnterAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00122D50 File Offset: 0x00120F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140125, XrefRangeEnd = 140126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_CancelEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00122D84 File Offset: 0x00120F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140135, RefRangeEnd = 140136, XrefRangeStart = 140126, XrefRangeEnd = 140135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterBuilding(int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_EnterBuilding_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00122DC4 File Offset: 0x00120FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140136, XrefRangeEnd = 140140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitBuilding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_ExitBuilding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00122DF8 File Offset: 0x00120FF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 140153, RefRangeEnd = 140159, XrefRangeStart = 140140, XrefRangeEnd = 140153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetEntryPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_GetEntryPoint_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00122E38 File Offset: 0x00121038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140175, RefRangeEnd = 140176, XrefRangeStart = 140159, XrefRangeEnd = 140175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor GetDoor(out int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_GetDoor_Private_StaticDoor_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr3) : null;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00122E84 File Offset: 0x00121084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_StayInBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00122EC0 File Offset: 0x001210C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140176, XrefRangeEnd = 140181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00122F00 File Offset: 0x00121100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140181, XrefRangeEnd = 140184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayEnterAnimation_b__19_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr__PlayEnterAnimation_b__19_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00122F3C File Offset: 0x0012113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140184, XrefRangeEnd = 140192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00122F78 File Offset: 0x00121178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140192, XrefRangeEnd = 140193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00122FB4 File Offset: 0x001211B4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00122FF0 File Offset: 0x001211F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140193, XrefRangeEnd = 140211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayEnterAnimation_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_RpcWriter___Observers_PlayEnterAnimation_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00123024 File Offset: 0x00121224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140222, RefRangeEnd = 140224, XrefRangeStart = 140211, XrefRangeEnd = 140222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayEnterAnimation_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_RpcLogic___PlayEnterAnimation_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00123058 File Offset: 0x00121258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140224, XrefRangeEnd = 140227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayEnterAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.NativeMethodInfoPtr_RpcReader___Observers_PlayEnterAnimation_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x001230A8 File Offset: 0x001212A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140227, XrefRangeEnd = 140228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_StayInBuilding.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x0001CBCD File Offset: 0x0001ADCD
		public NPCEvent_StayInBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x001230E4 File Offset: 0x001212E4
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x0001CBD6 File Offset: 0x0001ADD6
		public unsafe NPCEnterableBuilding Building
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_Building);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_Building), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x00123114 File Offset: 0x00121314
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x0001CBF5 File Offset: 0x0001ADF5
		public unsafe StaticDoor Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x00123144 File Offset: 0x00121344
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x0001CC14 File Offset: 0x0001AE14
		public unsafe bool IsEntering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_IsEntering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_IsEntering)) = value;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x0012316C File Offset: 0x0012136C
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x0001CC2F File Offset: 0x0001AE2F
		public unsafe Coroutine enterRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_enterRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_enterRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x0012319C File Offset: 0x0012139C
		// (set) Token: 0x06003740 RID: 14144 RVA: 0x0001CC4E File Offset: 0x0001AE4E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x001231C4 File Offset: 0x001213C4
		// (set) Token: 0x06003742 RID: 14146 RVA: 0x0001CC69 File Offset: 0x0001AE69
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeFieldInfoPtr_Building;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeFieldInfoPtr_IsEntering;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeFieldInfoPtr_enterRoutine;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr_get_InBuilding_Private_get_Boolean_0;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_PlayEnterAnimation_Private_Void_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_CancelEnter_Private_Void_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_EnterBuilding_Private_Void_Int32_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_ExitBuilding_Private_Void_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryPoint_Private_Transform_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_GetDoor_Private_StaticDoor_byref_Int32_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr__PlayEnterAnimation_b__19_1_Private_Boolean_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayEnterAnimation_2166136261_Private_Void_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayEnterAnimation_2166136261_Private_Void_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayEnterAnimation_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200092F RID: 2351
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.NPCEvent_StayInBuilding+<<PlayEnterAnimation>g__Enter|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C6CE RID: 50894 RVA: 0x003041C8 File Offset: 0x003023C8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique()
			{
				Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEvent_StayInBuilding>.NativeClassPtr, "<<PlayEnterAnimation>g__Enter|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr);
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, "<>1__state");
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, "<>2__current");
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, "<>4__this");
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__doorIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, "<doorIndex>5__2");
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__faceDir_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, "<faceDir>5__3");
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, "<t>5__4");
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, 100669635);
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, 100669636);
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, 100669637);
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, 100669638);
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, 100669639);
				NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr, 100669640);
			}

			// Token: 0x0600C6CF RID: 50895 RVA: 0x003042E4 File Offset: 0x003024E4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6D0 RID: 50896 RVA: 0x0030432C File Offset: 0x0030252C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6D1 RID: 50897 RVA: 0x00304360 File Offset: 0x00302560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139959, XrefRangeEnd = 139991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003DF5 RID: 15861
			// (get) Token: 0x0600C6D2 RID: 50898 RVA: 0x0030439C File Offset: 0x0030259C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C6D3 RID: 50899 RVA: 0x003043DC File Offset: 0x003025DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139991, XrefRangeEnd = 139996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003DF6 RID: 15862
			// (get) Token: 0x0600C6D4 RID: 50900 RVA: 0x00304410 File Offset: 0x00302610
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C6D5 RID: 50901 RVA: 0x00060C46 File Offset: 0x0005EE46
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DEF RID: 15855
			// (get) Token: 0x0600C6D6 RID: 50902 RVA: 0x00304450 File Offset: 0x00302650
			// (set) Token: 0x0600C6D7 RID: 50903 RVA: 0x00060C4F File Offset: 0x0005EE4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DF0 RID: 15856
			// (get) Token: 0x0600C6D8 RID: 50904 RVA: 0x00304478 File Offset: 0x00302678
			// (set) Token: 0x0600C6D9 RID: 50905 RVA: 0x00060C6A File Offset: 0x0005EE6A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF1 RID: 15857
			// (get) Token: 0x0600C6DA RID: 50906 RVA: 0x003044A8 File Offset: 0x003026A8
			// (set) Token: 0x0600C6DB RID: 50907 RVA: 0x00060C89 File Offset: 0x0005EE89
			public unsafe NPCEvent_StayInBuilding __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_StayInBuilding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF2 RID: 15858
			// (get) Token: 0x0600C6DC RID: 50908 RVA: 0x003044D8 File Offset: 0x003026D8
			// (set) Token: 0x0600C6DD RID: 50909 RVA: 0x00060CA8 File Offset: 0x0005EEA8
			public unsafe int _doorIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__doorIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__doorIndex_5__2)) = value;
				}
			}

			// Token: 0x17003DF3 RID: 15859
			// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x00304500 File Offset: 0x00302700
			// (set) Token: 0x0600C6DF RID: 50911 RVA: 0x00060CC3 File Offset: 0x0005EEC3
			public unsafe Transform _faceDir_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__faceDir_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__faceDir_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF4 RID: 15860
			// (get) Token: 0x0600C6E0 RID: 50912 RVA: 0x00304530 File Offset: 0x00302730
			// (set) Token: 0x0600C6E1 RID: 50913 RVA: 0x00060CE2 File Offset: 0x0005EEE2
			public unsafe float _t_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__t_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_StayInBuilding.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPTrInSiObObUnique.NativeFieldInfoPtr__t_5__4)) = value;
				}
			}

			// Token: 0x0400868B RID: 34443
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400868C RID: 34444
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400868D RID: 34445
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400868E RID: 34446
			private static readonly IntPtr NativeFieldInfoPtr__doorIndex_5__2;

			// Token: 0x0400868F RID: 34447
			private static readonly IntPtr NativeFieldInfoPtr__faceDir_5__3;

			// Token: 0x04008690 RID: 34448
			private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

			// Token: 0x04008691 RID: 34449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008692 RID: 34450
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008693 RID: 34451
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008694 RID: 34452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008695 RID: 34453
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008696 RID: 34454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
