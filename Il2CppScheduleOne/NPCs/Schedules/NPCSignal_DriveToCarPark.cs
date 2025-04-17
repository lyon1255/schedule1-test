using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E7 RID: 743
	public class NPCSignal_DriveToCarPark : NPCSignal
	{
		// Token: 0x060037B7 RID: 14263 RVA: 0x00124D44 File Offset: 0x00122F44
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSignal_DriveToCarPark()
		{
			Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCSignal_DriveToCarPark");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr);
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_ParkingLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "ParkingLot");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "Vehicle");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_OverrideParkingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "OverrideParkingType");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_ParkingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "ParkingType");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_isAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "isAtDestination");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_timeInVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "timeInVehicle");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_timeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "timeAtDestination");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted");
			NPCSignal_DriveToCarPark.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted");
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669709);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669710);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669711);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669712);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669713);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669714);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_CheckValidForStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669715);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669716);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669717);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669718);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669719);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669720);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669721);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669722);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_GetWalkDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669723);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_DriveCallback_Private_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669724);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Park_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669725);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_GetParkingType_Private_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669726);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669727);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669728);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669729);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669730);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669731);
			NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, 100669732);
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x00125008 File Offset: 0x00123208
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140649, XrefRangeEnd = 140651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00125040 File Offset: 0x00123240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140651, XrefRangeEnd = 140665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00125084 File Offset: 0x00123284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140665, XrefRangeEnd = 140667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x001250C0 File Offset: 0x001232C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140667, XrefRangeEnd = 140669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x001250FC File Offset: 0x001232FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140669, XrefRangeEnd = 140674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00125138 File Offset: 0x00123338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140674, XrefRangeEnd = 140676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00125174 File Offset: 0x00123374
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140680, RefRangeEnd = 140683, XrefRangeStart = 140676, XrefRangeEnd = 140680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckValidForStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_CheckValidForStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x001251A8 File Offset: 0x001233A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140683, XrefRangeEnd = 140688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x001251E4 File Offset: 0x001233E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140688, XrefRangeEnd = 140690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00125220 File Offset: 0x00123420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140690, XrefRangeEnd = 140692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x0012525C File Offset: 0x0012345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140692, XrefRangeEnd = 140708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResumeFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00125298 File Offset: 0x00123498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140708, XrefRangeEnd = 140709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x001252D4 File Offset: 0x001234D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140709, XrefRangeEnd = 140755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00125310 File Offset: 0x00123510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140755, XrefRangeEnd = 140757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x0012535C File Offset: 0x0012355C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140765, RefRangeEnd = 140768, XrefRangeStart = 140757, XrefRangeEnd = 140765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWalkDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_GetWalkDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00125398 File Offset: 0x00123598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140768, XrefRangeEnd = 140776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DriveCallback(VehicleAgent.ENavigationResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_DriveCallback_Private_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x001253D8 File Offset: 0x001235D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 140787, RefRangeEnd = 140791, XrefRangeStart = 140776, XrefRangeEnd = 140787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Park_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x0012540C File Offset: 0x0012360C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140791, XrefRangeEnd = 140792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EParkingAlignment GetParkingType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_GetParkingType_Private_EParkingAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00125448 File Offset: 0x00123648
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140574, RefRangeEnd = 140579, XrefRangeStart = 140574, XrefRangeEnd = 140579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSignal_DriveToCarPark() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00125484 File Offset: 0x00123684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140792, XrefRangeEnd = 140797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x001254C4 File Offset: 0x001236C4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00125500 File Offset: 0x00123700
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0012553C File Offset: 0x0012373C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00125578 File Offset: 0x00123778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140797, XrefRangeEnd = 140798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_DriveToCarPark.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0001CEC7 File Offset: 0x0001B0C7
		public NPCSignal_DriveToCarPark(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x001255B4 File Offset: 0x001237B4
		// (set) Token: 0x060037D2 RID: 14290 RVA: 0x0001CED0 File Offset: 0x0001B0D0
		public unsafe ParkingLot ParkingLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_ParkingLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_ParkingLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x001255E4 File Offset: 0x001237E4
		// (set) Token: 0x060037D4 RID: 14292 RVA: 0x0001CEEF File Offset: 0x0001B0EF
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x00125614 File Offset: 0x00123814
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x0001CF0E File Offset: 0x0001B10E
		public unsafe bool OverrideParkingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_OverrideParkingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_OverrideParkingType)) = value;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x0012563C File Offset: 0x0012383C
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x0001CF29 File Offset: 0x0001B129
		public unsafe EParkingAlignment ParkingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_ParkingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_ParkingType)) = value;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x00125664 File Offset: 0x00123864
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x0001CF44 File Offset: 0x0001B144
		public unsafe bool isAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_isAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_isAtDestination)) = value;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x0012568C File Offset: 0x0012388C
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x0001CF5F File Offset: 0x0001B15F
		public unsafe float timeInVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_timeInVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_timeInVehicle)) = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x001256B4 File Offset: 0x001238B4
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x0001CF7A File Offset: 0x0001B17A
		public unsafe float timeAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_timeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_timeAtDestination)) = value;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x001256DC File Offset: 0x001238DC
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0001CF95 File Offset: 0x0001B195
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x00125704 File Offset: 0x00123904
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeFieldInfoPtr_ParkingLot;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeFieldInfoPtr_OverrideParkingType;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeFieldInfoPtr_ParkingType;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeFieldInfoPtr_isAtDestination;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeFieldInfoPtr_timeInVehicle;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeFieldInfoPtr_timeAtDestination;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_CheckValidForStart_Private_Void_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeMethodInfoPtr_ResumeFailed_Public_Virtual_Void_0;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_GetWalkDestination_Private_Vector3_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_DriveCallback_Private_Void_ENavigationResult_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_Park_Private_Void_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_GetParkingType_Private_EParkingAlignment_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000930 RID: 2352
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarPark+<<DriveCallback>g__Wait|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C6E2 RID: 50914 RVA: 0x00304558 File Offset: 0x00302758
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique()
			{
				Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSignal_DriveToCarPark>.NativeClassPtr, "<<DriveCallback>g__Wait|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr);
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, "<>1__state");
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, "<>2__current");
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, "<>4__this");
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669733);
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669734);
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669735);
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669736);
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669737);
				NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669738);
			}

			// Token: 0x0600C6E3 RID: 50915 RVA: 0x00304638 File Offset: 0x00302838
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6E4 RID: 50916 RVA: 0x00304680 File Offset: 0x00302880
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6E5 RID: 50917 RVA: 0x003046B4 File Offset: 0x003028B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140639, XrefRangeEnd = 140644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003DFA RID: 15866
			// (get) Token: 0x0600C6E6 RID: 50918 RVA: 0x003046F0 File Offset: 0x003028F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C6E7 RID: 50919 RVA: 0x00304730 File Offset: 0x00302930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140644, XrefRangeEnd = 140649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003DFB RID: 15867
			// (get) Token: 0x0600C6E8 RID: 50920 RVA: 0x00304764 File Offset: 0x00302964
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C6E9 RID: 50921 RVA: 0x00060CFD File Offset: 0x0005EEFD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DF7 RID: 15863
			// (get) Token: 0x0600C6EA RID: 50922 RVA: 0x003047A4 File Offset: 0x003029A4
			// (set) Token: 0x0600C6EB RID: 50923 RVA: 0x00060D06 File Offset: 0x0005EF06
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DF8 RID: 15864
			// (get) Token: 0x0600C6EC RID: 50924 RVA: 0x003047CC File Offset: 0x003029CC
			// (set) Token: 0x0600C6ED RID: 50925 RVA: 0x00060D21 File Offset: 0x0005EF21
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF9 RID: 15865
			// (get) Token: 0x0600C6EE RID: 50926 RVA: 0x003047FC File Offset: 0x003029FC
			// (set) Token: 0x0600C6EF RID: 50927 RVA: 0x00060D40 File Offset: 0x0005EF40
			public unsafe NPCSignal_DriveToCarPark __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_DriveToCarPark>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_DriveToCarPark.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008697 RID: 34455
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008698 RID: 34456
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008699 RID: 34457
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400869A RID: 34458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400869B RID: 34459
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400869C RID: 34460
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400869D RID: 34461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400869E RID: 34462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400869F RID: 34463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
