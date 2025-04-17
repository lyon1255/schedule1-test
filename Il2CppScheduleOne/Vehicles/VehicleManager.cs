using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EF RID: 1263
	public class VehicleManager : NetworkSingleton<VehicleManager>
	{
		// Token: 0x06006F91 RID: 28561 RVA: 0x001EBDCC File Offset: 0x001E9FCC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleManager()
		{
			Il2CppClassPointerStore<VehicleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr);
			VehicleManager.NativeFieldInfoPtr_AllVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "AllVehicles");
			VehicleManager.NativeFieldInfoPtr_VehiclePrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "VehiclePrefabs");
			VehicleManager.NativeFieldInfoPtr_PlayerOwnedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "PlayerOwnedVehicles");
			VehicleManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "loader");
			VehicleManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			VehicleManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			VehicleManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted");
			VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted");
			VehicleManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677357);
			VehicleManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677358);
			VehicleManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677359);
			VehicleManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677360);
			VehicleManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677361);
			VehicleManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677362);
			VehicleManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677363);
			VehicleManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677364);
			VehicleManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677365);
			VehicleManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677366);
			VehicleManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677367);
			VehicleManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677368);
			VehicleManager.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677369);
			VehicleManager.NativeMethodInfoPtr_SpawnAndReturnVehicle_Public_LandVehicle_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677370);
			VehicleManager.NativeMethodInfoPtr_GetVehiclePrefab_Public_LandVehicle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677371);
			VehicleManager.NativeMethodInfoPtr_SpawnAndLoadVehicle_Public_LandVehicle_VehicleData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677372);
			VehicleManager.NativeMethodInfoPtr_LoadVehicle_Public_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677373);
			VehicleManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677374);
			VehicleManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677375);
			VehicleManager.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677376);
			VehicleManager.NativeMethodInfoPtr_EnableLoanSharkVisuals_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677377);
			VehicleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677378);
			VehicleManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677379);
			VehicleManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677380);
			VehicleManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677381);
			VehicleManager.NativeMethodInfoPtr_RpcWriter___Server_SpawnVehicle_3323115898_Private_Void_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677382);
			VehicleManager.NativeMethodInfoPtr_RpcLogic___SpawnVehicle_3323115898_Public_Void_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677383);
			VehicleManager.NativeMethodInfoPtr_RpcReader___Server_SpawnVehicle_3323115898_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677384);
			VehicleManager.NativeMethodInfoPtr_RpcWriter___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677385);
			VehicleManager.NativeMethodInfoPtr_RpcLogic___EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677386);
			VehicleManager.NativeMethodInfoPtr_RpcReader___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677387);
			VehicleManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100677388);
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06006F92 RID: 28562 RVA: 0x001EC130 File Offset: 0x001EA330
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220852, XrefRangeEnd = 220854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06006F93 RID: 28563 RVA: 0x001EC168 File Offset: 0x001EA368
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220854, XrefRangeEnd = 220856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06006F94 RID: 28564 RVA: 0x001EC1A0 File Offset: 0x001EA3A0
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06006F95 RID: 28565 RVA: 0x001EC1E0 File Offset: 0x001EA3E0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06006F96 RID: 28566 RVA: 0x001EC21C File Offset: 0x001EA41C
		// (set) Token: 0x06006F97 RID: 28567 RVA: 0x001EC25C File Offset: 0x001EA45C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x001EC2A0 File Offset: 0x001EA4A0
		// (set) Token: 0x06006F99 RID: 28569 RVA: 0x001EC2E0 File Offset: 0x001EA4E0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93781, RefRangeEnd = 93782, XrefRangeStart = 93781, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x001EC324 File Offset: 0x001EA524
		// (set) Token: 0x06006F9B RID: 28571 RVA: 0x001EC360 File Offset: 0x001EA560
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x001EC3A0 File Offset: 0x001EA5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220856, XrefRangeEnd = 220859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x001EC3DC File Offset: 0x001EA5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220859, XrefRangeEnd = 220865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x001EC418 File Offset: 0x001EA618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220866, RefRangeEnd = 220867, XrefRangeStart = 220865, XrefRangeEnd = 220866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x001EC484 File Offset: 0x001EA684
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220907, RefRangeEnd = 220913, XrefRangeStart = 220867, XrefRangeEnd = 220907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnAndReturnVehicle_Public_LandVehicle_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x001EC500 File Offset: 0x001EA700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220928, RefRangeEnd = 220931, XrefRangeStart = 220913, XrefRangeEnd = 220928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_GetVehiclePrefab_Public_LandVehicle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x001EC550 File Offset: 0x001EA750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220932, RefRangeEnd = 220933, XrefRangeStart = 220931, XrefRangeEnd = 220932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnAndLoadVehicle_Public_LandVehicle_VehicleData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x001EC5C0 File Offset: 0x001EA7C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220946, RefRangeEnd = 220947, XrefRangeStart = 220933, XrefRangeEnd = 220946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVehicle(VehicleData data, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_LoadVehicle_Public_Void_VehicleData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x001EC614 File Offset: 0x001EA814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220947, XrefRangeEnd = 220949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x001EC658 File Offset: 0x001EA858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220949, XrefRangeEnd = 220976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x001EC6B4 File Offset: 0x001EA8B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221005, RefRangeEnd = 221007, XrefRangeStart = 220976, XrefRangeEnd = 221005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x001EC700 File Offset: 0x001EA900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221007, XrefRangeEnd = 221029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLoanSharkVisuals(NetworkObject veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_EnableLoanSharkVisuals_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x001EC744 File Offset: 0x001EA944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221029, XrefRangeEnd = 221066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x001EC780 File Offset: 0x001EA980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221066, XrefRangeEnd = 221083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x001EC7BC File Offset: 0x001EA9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221083, XrefRangeEnd = 221086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x001EC7F8 File Offset: 0x001EA9F8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x001EC834 File Offset: 0x001EAA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221131, RefRangeEnd = 221132, XrefRangeStart = 221086, XrefRangeEnd = 221131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcWriter___Server_SpawnVehicle_3323115898_Private_Void_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x001EC8A0 File Offset: 0x001EAAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221132, XrefRangeEnd = 221133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcLogic___SpawnVehicle_3323115898_Public_Void_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x001EC90C File Offset: 0x001EAB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221133, XrefRangeEnd = 221141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcReader___Server_SpawnVehicle_3323115898_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x001EC970 File Offset: 0x001EAB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221141, XrefRangeEnd = 221160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcWriter___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x001EC9B4 File Offset: 0x001EABB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221176, RefRangeEnd = 221179, XrefRangeStart = 221160, XrefRangeEnd = 221176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcLogic___EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x001EC9F8 File Offset: 0x001EABF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221179, XrefRangeEnd = 221183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcReader___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x001ECA48 File Offset: 0x001EAC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221183, XrefRangeEnd = 221186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00034E26 File Offset: 0x00033026
		public VehicleManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06006FB3 RID: 28595 RVA: 0x001ECA84 File Offset: 0x001EAC84
		// (set) Token: 0x06006FB4 RID: 28596 RVA: 0x00034E2F File Offset: 0x0003302F
		public unsafe List<LandVehicle> AllVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_AllVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_AllVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x001ECAB4 File Offset: 0x001EACB4
		// (set) Token: 0x06006FB6 RID: 28598 RVA: 0x00034E4E File Offset: 0x0003304E
		public unsafe List<LandVehicle> VehiclePrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_VehiclePrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_VehiclePrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06006FB7 RID: 28599 RVA: 0x001ECAE4 File Offset: 0x001EACE4
		// (set) Token: 0x06006FB8 RID: 28600 RVA: 0x00034E6D File Offset: 0x0003306D
		public unsafe List<LandVehicle> PlayerOwnedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_PlayerOwnedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_PlayerOwnedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06006FB9 RID: 28601 RVA: 0x001ECB14 File Offset: 0x001EAD14
		// (set) Token: 0x06006FBA RID: 28602 RVA: 0x00034E8C File Offset: 0x0003308C
		public unsafe VehiclesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06006FBB RID: 28603 RVA: 0x001ECB44 File Offset: 0x001EAD44
		// (set) Token: 0x06006FBC RID: 28604 RVA: 0x00034EAB File Offset: 0x000330AB
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06006FBD RID: 28605 RVA: 0x001ECB74 File Offset: 0x001EAD74
		// (set) Token: 0x06006FBE RID: 28606 RVA: 0x00034ECA File Offset: 0x000330CA
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06006FBF RID: 28607 RVA: 0x001ECBA4 File Offset: 0x001EADA4
		// (set) Token: 0x06006FC0 RID: 28608 RVA: 0x00034EE9 File Offset: 0x000330E9
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x001ECBCC File Offset: 0x001EADCC
		// (set) Token: 0x06006FC2 RID: 28610 RVA: 0x00034F04 File Offset: 0x00033104
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06006FC3 RID: 28611 RVA: 0x001ECBF4 File Offset: 0x001EADF4
		// (set) Token: 0x06006FC4 RID: 28612 RVA: 0x00034F1F File Offset: 0x0003311F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004C40 RID: 19520
		private static readonly IntPtr NativeFieldInfoPtr_AllVehicles;

		// Token: 0x04004C41 RID: 19521
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePrefabs;

		// Token: 0x04004C42 RID: 19522
		private static readonly IntPtr NativeFieldInfoPtr_PlayerOwnedVehicles;

		// Token: 0x04004C43 RID: 19523
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004C44 RID: 19524
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004C45 RID: 19525
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004C46 RID: 19526
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004C47 RID: 19527
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004C48 RID: 19528
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004C49 RID: 19529
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004C4A RID: 19530
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004C4B RID: 19531
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004C4C RID: 19532
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004C4D RID: 19533
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004C4E RID: 19534
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004C4F RID: 19535
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004C50 RID: 19536
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004C51 RID: 19537
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004C52 RID: 19538
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004C53 RID: 19539
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004C54 RID: 19540
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004C55 RID: 19541
		private static readonly IntPtr NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04004C56 RID: 19542
		private static readonly IntPtr NativeMethodInfoPtr_SpawnAndReturnVehicle_Public_LandVehicle_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04004C57 RID: 19543
		private static readonly IntPtr NativeMethodInfoPtr_GetVehiclePrefab_Public_LandVehicle_String_0;

		// Token: 0x04004C58 RID: 19544
		private static readonly IntPtr NativeMethodInfoPtr_SpawnAndLoadVehicle_Public_LandVehicle_VehicleData_String_Boolean_0;

		// Token: 0x04004C59 RID: 19545
		private static readonly IntPtr NativeMethodInfoPtr_LoadVehicle_Public_Void_VehicleData_String_0;

		// Token: 0x04004C5A RID: 19546
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004C5B RID: 19547
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004C5C RID: 19548
		private static readonly IntPtr NativeMethodInfoPtr_SpawnLoanSharkVehicle_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004C5D RID: 19549
		private static readonly IntPtr NativeMethodInfoPtr_EnableLoanSharkVisuals_Private_Void_NetworkObject_0;

		// Token: 0x04004C5E RID: 19550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C5F RID: 19551
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004C60 RID: 19552
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004C61 RID: 19553
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004C62 RID: 19554
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SpawnVehicle_3323115898_Private_Void_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04004C63 RID: 19555
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SpawnVehicle_3323115898_Public_Void_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04004C64 RID: 19556
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SpawnVehicle_3323115898_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004C65 RID: 19557
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004C66 RID: 19558
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004C67 RID: 19559
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004C68 RID: 19560
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A6A RID: 2666
		[ObfuscatedName("ScheduleOne.Vehicles.VehicleManager+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D11C RID: 53532 RVA: 0x003219F4 File Offset: 0x0031FBF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<VehicleManager.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass28_0>.NativeClassPtr);
				VehicleManager.__c__DisplayClass28_0.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass28_0>.NativeClassPtr, "vehicleCode");
				VehicleManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass28_0>.NativeClassPtr, 100677389);
				VehicleManager.__c__DisplayClass28_0.NativeMethodInfoPtr__GetVehiclePrefab_b__0_Internal_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass28_0>.NativeClassPtr, 100677390);
			}

			// Token: 0x0600D11D RID: 53533 RVA: 0x00321A5C File Offset: 0x0031FC5C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D11E RID: 53534 RVA: 0x00321A98 File Offset: 0x0031FC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220848, XrefRangeEnd = 220852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetVehiclePrefab_b__0(LandVehicle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.__c__DisplayClass28_0.NativeMethodInfoPtr__GetVehiclePrefab_b__0_Internal_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D11F RID: 53535 RVA: 0x00065CCC File Offset: 0x00063ECC
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040EF RID: 16623
			// (get) Token: 0x0600D120 RID: 53536 RVA: 0x00321AE8 File Offset: 0x0031FCE8
			// (set) Token: 0x0600D121 RID: 53537 RVA: 0x00065CD5 File Offset: 0x00063ED5
			public unsafe string vehicleCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.__c__DisplayClass28_0.NativeFieldInfoPtr_vehicleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.__c__DisplayClass28_0.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008D15 RID: 36117
			private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

			// Token: 0x04008D16 RID: 36118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D17 RID: 36119
			private static readonly IntPtr NativeMethodInfoPtr__GetVehiclePrefab_b__0_Internal_Boolean_LandVehicle_0;
		}
	}
}
