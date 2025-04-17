using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EE RID: 1262
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x06006F42 RID: 28482 RVA: 0x001EB030 File Offset: 0x001E9230
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleLights()
		{
			Il2CppClassPointerStore<VehicleLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleLights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr);
			VehicleLights.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "vehicle");
			VehicleLights.NativeFieldInfoPtr_hasHeadLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasHeadLights");
			VehicleLights.NativeFieldInfoPtr_headLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMeshes");
			VehicleLights.NativeFieldInfoPtr_headLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightSources");
			VehicleLights.NativeFieldInfoPtr_headlightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headlightMat_On");
			VehicleLights.NativeFieldInfoPtr_headLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMat_Off");
			VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "<headLightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_headLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasBrakeLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasBrakeLights");
			VehicleLights.NativeFieldInfoPtr_brakeLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMeshes");
			VehicleLights.NativeFieldInfoPtr_brakeLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightSources");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_On");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Ambient");
			VehicleLights.NativeFieldInfoPtr_brakeLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsOn");
			VehicleLights.NativeFieldInfoPtr_brakeLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasReverseLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasReverseLights");
			VehicleLights.NativeFieldInfoPtr_reverseLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMeshes");
			VehicleLights.NativeFieldInfoPtr_reverseLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightSources");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_On");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_reverseLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsOn");
			VehicleLights.NativeFieldInfoPtr_reverseLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsApplied");
			VehicleLights.NativeFieldInfoPtr_onHeadlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "onHeadlightsOn");
			VehicleLights.NativeFieldInfoPtr_onHeadlightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "onHeadlightsOff");
			VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakesAppliedHistory");
			VehicleLights.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "agent");
			VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "syncVar___<headLightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677340);
			VehicleLights.NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677341);
			VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677342);
			VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677343);
			VehicleLights.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677344);
			VehicleLights.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677345);
			VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677346);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677347);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677348);
			VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677349);
			VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677350);
			VehicleLights.NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677351);
			VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677352);
			VehicleLights.NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677353);
			VehicleLights.NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677354);
			VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677355);
			VehicleLights.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677356);
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x001EB40C File Offset: 0x001E960C
		// (set) Token: 0x06006F44 RID: 28484 RVA: 0x001EB448 File Offset: 0x001E9648
		public unsafe bool headLightsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 220697, RefRangeEnd = 220699, XrefRangeStart = 220675, XrefRangeEnd = 220697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x001EB488 File Offset: 0x001E9688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220699, XrefRangeEnd = 220703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x001EB4C4 File Offset: 0x001E96C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220703, XrefRangeEnd = 220729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x001EB500 File Offset: 0x001E9700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220729, XrefRangeEnd = 220747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x001EB53C File Offset: 0x001E973C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220747, XrefRangeEnd = 220769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x001EB578 File Offset: 0x001E9778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220769, XrefRangeEnd = 220777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleLights() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x001EB5B4 File Offset: 0x001E97B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220777, XrefRangeEnd = 220800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x001EB5F0 File Offset: 0x001E97F0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x001EB62C File Offset: 0x001E982C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x001EB668 File Offset: 0x001E9868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220800, XrefRangeEnd = 220819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_headLightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x001EB6A8 File Offset: 0x001E98A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220826, RefRangeEnd = 220829, XrefRangeStart = 220819, XrefRangeEnd = 220826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x001EB6E8 File Offset: 0x001E98E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220829, XrefRangeEnd = 220832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06006F50 RID: 28496 RVA: 0x001EB74C File Offset: 0x001E994C
		// (set) Token: 0x06006F51 RID: 28497 RVA: 0x001EB788 File Offset: 0x001E9988
		public unsafe bool SyncAccessor_<headLightsOn>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 220840, RefRangeEnd = 220841, XrefRangeStart = 220832, XrefRangeEnd = 220840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x001EB7D4 File Offset: 0x001E99D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220841, XrefRangeEnd = 220844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x001EB848 File Offset: 0x001E9A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220844, XrefRangeEnd = 220848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x00034AA7 File Offset: 0x00032CA7
		public VehicleLights(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06006F55 RID: 28501 RVA: 0x001EB884 File Offset: 0x001E9A84
		// (set) Token: 0x06006F56 RID: 28502 RVA: 0x00034AB0 File Offset: 0x00032CB0
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06006F57 RID: 28503 RVA: 0x001EB8B4 File Offset: 0x001E9AB4
		// (set) Token: 0x06006F58 RID: 28504 RVA: 0x00034ACF File Offset: 0x00032CCF
		public unsafe bool hasHeadLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasHeadLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasHeadLights)) = value;
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06006F59 RID: 28505 RVA: 0x001EB8DC File Offset: 0x001E9ADC
		// (set) Token: 0x06006F5A RID: 28506 RVA: 0x00034AEA File Offset: 0x00032CEA
		public unsafe Il2CppReferenceArray<MeshRenderer> headLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06006F5B RID: 28507 RVA: 0x001EB90C File Offset: 0x001E9B0C
		// (set) Token: 0x06006F5C RID: 28508 RVA: 0x00034B09 File Offset: 0x00032D09
		public unsafe Il2CppReferenceArray<OptimizedLight> headLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06006F5D RID: 28509 RVA: 0x001EB93C File Offset: 0x001E9B3C
		// (set) Token: 0x06006F5E RID: 28510 RVA: 0x00034B28 File Offset: 0x00032D28
		public unsafe Material headlightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06006F5F RID: 28511 RVA: 0x001EB96C File Offset: 0x001E9B6C
		// (set) Token: 0x06006F60 RID: 28512 RVA: 0x00034B47 File Offset: 0x00032D47
		public unsafe Material headLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06006F61 RID: 28513 RVA: 0x001EB99C File Offset: 0x001E9B9C
		// (set) Token: 0x06006F62 RID: 28514 RVA: 0x00034B66 File Offset: 0x00032D66
		public unsafe bool _headLightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06006F63 RID: 28515 RVA: 0x001EB9C4 File Offset: 0x001E9BC4
		// (set) Token: 0x06006F64 RID: 28516 RVA: 0x00034B81 File Offset: 0x00032D81
		public unsafe bool headLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied)) = value;
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06006F65 RID: 28517 RVA: 0x001EB9EC File Offset: 0x001E9BEC
		// (set) Token: 0x06006F66 RID: 28518 RVA: 0x00034B9C File Offset: 0x00032D9C
		public unsafe bool hasBrakeLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasBrakeLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasBrakeLights)) = value;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06006F67 RID: 28519 RVA: 0x001EBA14 File Offset: 0x001E9C14
		// (set) Token: 0x06006F68 RID: 28520 RVA: 0x00034BB7 File Offset: 0x00032DB7
		public unsafe Il2CppReferenceArray<MeshRenderer> brakeLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06006F69 RID: 28521 RVA: 0x001EBA44 File Offset: 0x001E9C44
		// (set) Token: 0x06006F6A RID: 28522 RVA: 0x00034BD6 File Offset: 0x00032DD6
		public unsafe Il2CppReferenceArray<Light> brakeLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06006F6B RID: 28523 RVA: 0x001EBA74 File Offset: 0x001E9C74
		// (set) Token: 0x06006F6C RID: 28524 RVA: 0x00034BF5 File Offset: 0x00032DF5
		public unsafe Material brakeLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x001EBAA4 File Offset: 0x001E9CA4
		// (set) Token: 0x06006F6E RID: 28526 RVA: 0x00034C14 File Offset: 0x00032E14
		public unsafe Material brakeLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06006F6F RID: 28527 RVA: 0x001EBAD4 File Offset: 0x001E9CD4
		// (set) Token: 0x06006F70 RID: 28528 RVA: 0x00034C33 File Offset: 0x00032E33
		public unsafe Material brakeLightMat_Ambient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06006F71 RID: 28529 RVA: 0x001EBB04 File Offset: 0x001E9D04
		// (set) Token: 0x06006F72 RID: 28530 RVA: 0x00034C52 File Offset: 0x00032E52
		public unsafe bool brakeLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsOn)) = value;
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06006F73 RID: 28531 RVA: 0x001EBB2C File Offset: 0x001E9D2C
		// (set) Token: 0x06006F74 RID: 28532 RVA: 0x00034C6D File Offset: 0x00032E6D
		public unsafe bool brakeLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied)) = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06006F75 RID: 28533 RVA: 0x001EBB54 File Offset: 0x001E9D54
		// (set) Token: 0x06006F76 RID: 28534 RVA: 0x00034C88 File Offset: 0x00032E88
		public unsafe bool hasReverseLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights)) = value;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06006F77 RID: 28535 RVA: 0x001EBB7C File Offset: 0x001E9D7C
		// (set) Token: 0x06006F78 RID: 28536 RVA: 0x00034CA3 File Offset: 0x00032EA3
		public unsafe Il2CppReferenceArray<MeshRenderer> reverseLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06006F79 RID: 28537 RVA: 0x001EBBAC File Offset: 0x001E9DAC
		// (set) Token: 0x06006F7A RID: 28538 RVA: 0x00034CC2 File Offset: 0x00032EC2
		public unsafe Il2CppReferenceArray<Light> reverseLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06006F7B RID: 28539 RVA: 0x001EBBDC File Offset: 0x001E9DDC
		// (set) Token: 0x06006F7C RID: 28540 RVA: 0x00034CE1 File Offset: 0x00032EE1
		public unsafe Material reverseLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06006F7D RID: 28541 RVA: 0x001EBC0C File Offset: 0x001E9E0C
		// (set) Token: 0x06006F7E RID: 28542 RVA: 0x00034D00 File Offset: 0x00032F00
		public unsafe Material reverseLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06006F7F RID: 28543 RVA: 0x001EBC3C File Offset: 0x001E9E3C
		// (set) Token: 0x06006F80 RID: 28544 RVA: 0x00034D1F File Offset: 0x00032F1F
		public unsafe bool reverseLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsOn)) = value;
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06006F81 RID: 28545 RVA: 0x001EBC64 File Offset: 0x001E9E64
		// (set) Token: 0x06006F82 RID: 28546 RVA: 0x00034D3A File Offset: 0x00032F3A
		public unsafe bool reverseLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied)) = value;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06006F83 RID: 28547 RVA: 0x001EBC8C File Offset: 0x001E9E8C
		// (set) Token: 0x06006F84 RID: 28548 RVA: 0x00034D55 File Offset: 0x00032F55
		public unsafe UnityEvent onHeadlightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06006F85 RID: 28549 RVA: 0x001EBCBC File Offset: 0x001E9EBC
		// (set) Token: 0x06006F86 RID: 28550 RVA: 0x00034D74 File Offset: 0x00032F74
		public unsafe UnityEvent onHeadlightsOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06006F87 RID: 28551 RVA: 0x001EBCEC File Offset: 0x001E9EEC
		// (set) Token: 0x06006F88 RID: 28552 RVA: 0x00034D93 File Offset: 0x00032F93
		public unsafe List<bool> brakesAppliedHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06006F89 RID: 28553 RVA: 0x001EBD1C File Offset: 0x001E9F1C
		// (set) Token: 0x06006F8A RID: 28554 RVA: 0x00034DB2 File Offset: 0x00032FB2
		public unsafe VehicleAgent agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06006F8B RID: 28555 RVA: 0x001EBD4C File Offset: 0x001E9F4C
		// (set) Token: 0x06006F8C RID: 28556 RVA: 0x00034DD1 File Offset: 0x00032FD1
		public unsafe SyncVar<bool> syncVar____headLightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06006F8D RID: 28557 RVA: 0x001EBD7C File Offset: 0x001E9F7C
		// (set) Token: 0x06006F8E RID: 28558 RVA: 0x00034DF0 File Offset: 0x00032FF0
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06006F8F RID: 28559 RVA: 0x001EBDA4 File Offset: 0x001E9FA4
		// (set) Token: 0x06006F90 RID: 28560 RVA: 0x00034E0B File Offset: 0x0003300B
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004C11 RID: 19473
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004C12 RID: 19474
		private static readonly IntPtr NativeFieldInfoPtr_hasHeadLights;

		// Token: 0x04004C13 RID: 19475
		private static readonly IntPtr NativeFieldInfoPtr_headLightMeshes;

		// Token: 0x04004C14 RID: 19476
		private static readonly IntPtr NativeFieldInfoPtr_headLightSources;

		// Token: 0x04004C15 RID: 19477
		private static readonly IntPtr NativeFieldInfoPtr_headlightMat_On;

		// Token: 0x04004C16 RID: 19478
		private static readonly IntPtr NativeFieldInfoPtr_headLightMat_Off;

		// Token: 0x04004C17 RID: 19479
		private static readonly IntPtr NativeFieldInfoPtr__headLightsOn_k__BackingField;

		// Token: 0x04004C18 RID: 19480
		private static readonly IntPtr NativeFieldInfoPtr_headLightsApplied;

		// Token: 0x04004C19 RID: 19481
		private static readonly IntPtr NativeFieldInfoPtr_hasBrakeLights;

		// Token: 0x04004C1A RID: 19482
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMeshes;

		// Token: 0x04004C1B RID: 19483
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightSources;

		// Token: 0x04004C1C RID: 19484
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_On;

		// Token: 0x04004C1D RID: 19485
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Off;

		// Token: 0x04004C1E RID: 19486
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Ambient;

		// Token: 0x04004C1F RID: 19487
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsOn;

		// Token: 0x04004C20 RID: 19488
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsApplied;

		// Token: 0x04004C21 RID: 19489
		private static readonly IntPtr NativeFieldInfoPtr_hasReverseLights;

		// Token: 0x04004C22 RID: 19490
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMeshes;

		// Token: 0x04004C23 RID: 19491
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightSources;

		// Token: 0x04004C24 RID: 19492
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_On;

		// Token: 0x04004C25 RID: 19493
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_Off;

		// Token: 0x04004C26 RID: 19494
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsOn;

		// Token: 0x04004C27 RID: 19495
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsApplied;

		// Token: 0x04004C28 RID: 19496
		private static readonly IntPtr NativeFieldInfoPtr_onHeadlightsOn;

		// Token: 0x04004C29 RID: 19497
		private static readonly IntPtr NativeFieldInfoPtr_onHeadlightsOff;

		// Token: 0x04004C2A RID: 19498
		private static readonly IntPtr NativeFieldInfoPtr_brakesAppliedHistory;

		// Token: 0x04004C2B RID: 19499
		private static readonly IntPtr NativeFieldInfoPtr_agent;

		// Token: 0x04004C2C RID: 19500
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField;

		// Token: 0x04004C2D RID: 19501
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004C2E RID: 19502
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004C2F RID: 19503
		private static readonly IntPtr NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0;

		// Token: 0x04004C30 RID: 19504
		private static readonly IntPtr NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0;

		// Token: 0x04004C31 RID: 19505
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004C32 RID: 19506
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004C33 RID: 19507
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004C34 RID: 19508
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004C35 RID: 19509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C36 RID: 19510
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004C37 RID: 19511
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004C38 RID: 19512
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004C39 RID: 19513
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004C3A RID: 19514
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0;

		// Token: 0x04004C3B RID: 19515
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004C3C RID: 19516
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004C3D RID: 19517
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004C3E RID: 19518
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004C3F RID: 19519
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
