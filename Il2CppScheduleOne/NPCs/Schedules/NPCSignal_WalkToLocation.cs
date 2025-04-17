using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002EC RID: 748
	public class NPCSignal_WalkToLocation : NPCSignal
	{
		// Token: 0x0600386D RID: 14445 RVA: 0x001278CC File Offset: 0x00125ACC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSignal_WalkToLocation()
		{
			Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCSignal_WalkToLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr);
			NPCSignal_WalkToLocation.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, "Destination");
			NPCSignal_WalkToLocation.NativeFieldInfoPtr_FaceDestinationDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, "FaceDestinationDir");
			NPCSignal_WalkToLocation.NativeFieldInfoPtr_DestinationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, "DestinationThreshold");
			NPCSignal_WalkToLocation.NativeFieldInfoPtr_WarpIfSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, "WarpIfSkipped");
			NPCSignal_WalkToLocation.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted");
			NPCSignal_WalkToLocation.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted");
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669845);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669846);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669847);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669848);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669849);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669850);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669851);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669852);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669853);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669854);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_ReachedDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669855);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669856);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669857);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669858);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669859);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_RpcWriter___Observers_ReachedDestination_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669860);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_RpcLogic___ReachedDestination_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669861);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_RpcReader___Observers_ReachedDestination_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669862);
			NPCSignal_WalkToLocation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr, 100669863);
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x00127AF0 File Offset: 0x00125CF0
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141336, XrefRangeEnd = 141338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00127B28 File Offset: 0x00125D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141338, XrefRangeEnd = 141346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00127B6C File Offset: 0x00125D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141346, XrefRangeEnd = 141349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00127BA8 File Offset: 0x00125DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141349, XrefRangeEnd = 141359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x00127BE4 File Offset: 0x00125DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00127C20 File Offset: 0x00125E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141359, XrefRangeEnd = 141362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x00127C5C File Offset: 0x00125E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00127C98 File Offset: 0x00125E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141362, XrefRangeEnd = 141365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00127CD4 File Offset: 0x00125ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141365, XrefRangeEnd = 141372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x00127D10 File Offset: 0x00125F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141372, XrefRangeEnd = 141398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x00127D5C File Offset: 0x00125F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141398, XrefRangeEnd = 141416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReachedDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr_ReachedDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00127D90 File Offset: 0x00125F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141416, XrefRangeEnd = 141417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSignal_WalkToLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal_WalkToLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00127DCC File Offset: 0x00125FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141417, XrefRangeEnd = 141424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00127E08 File Offset: 0x00126008
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00127E44 File Offset: 0x00126044
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00127E80 File Offset: 0x00126080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReachedDestination_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr_RpcWriter___Observers_ReachedDestination_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00127EB4 File Offset: 0x001260B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141424, XrefRangeEnd = 141426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReachedDestination_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr_RpcLogic___ReachedDestination_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00127EE8 File Offset: 0x001260E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141426, XrefRangeEnd = 141429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReachedDestination_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WalkToLocation.NativeMethodInfoPtr_RpcReader___Observers_ReachedDestination_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00127F38 File Offset: 0x00126138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WalkToLocation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0001D227 File Offset: 0x0001B427
		public NPCSignal_WalkToLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x00127F74 File Offset: 0x00126174
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x0001D230 File Offset: 0x0001B430
		public unsafe Transform Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x00127FA4 File Offset: 0x001261A4
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x0001D24F File Offset: 0x0001B44F
		public unsafe bool FaceDestinationDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_FaceDestinationDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_FaceDestinationDir)) = value;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x00127FCC File Offset: 0x001261CC
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x0001D26A File Offset: 0x0001B46A
		public unsafe float DestinationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_DestinationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_DestinationThreshold)) = value;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x00127FF4 File Offset: 0x001261F4
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x0001D285 File Offset: 0x0001B485
		public unsafe bool WarpIfSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_WarpIfSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_WarpIfSkipped)) = value;
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x0012801C File Offset: 0x0012621C
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x00128044 File Offset: 0x00126244
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x0001D2BB File Offset: 0x0001B4BB
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WalkToLocation.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeFieldInfoPtr_FaceDestinationDir;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeFieldInfoPtr_DestinationThreshold;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeFieldInfoPtr_WarpIfSkipped;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr_ReachedDestination_Private_Void_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReachedDestination_2166136261_Private_Void_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReachedDestination_2166136261_Private_Void_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReachedDestination_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
