using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000757 RID: 1879
	public class SurfaceStorageEntity : SurfaceItem
	{
		// Token: 0x0600B2D2 RID: 45778 RVA: 0x002C9988 File Offset: 0x002C7B88
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceStorageEntity()
		{
			Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "SurfaceStorageEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr);
			SurfaceStorageEntity.NativeFieldInfoPtr__storedItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "_storedItemContainer");
			SurfaceStorageEntity.NativeFieldInfoPtr_StorageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "StorageEntity");
			SurfaceStorageEntity.NativeFieldInfoPtr_storageGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "storageGrids");
			SurfaceStorageEntity.NativeFieldInfoPtr__reservedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "_reservedItems");
			SurfaceStorageEntity.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			SurfaceStorageEntity.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			SurfaceStorageEntity.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "<Selectable>k__BackingField");
			SurfaceStorageEntity.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			SurfaceStorageEntity.NativeFieldInfoPtr_completedJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "completedJobs");
			SurfaceStorageEntity.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			SurfaceStorageEntity.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			SurfaceStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted");
			SurfaceStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted");
			SurfaceStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685345);
			SurfaceStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685346);
			SurfaceStorageEntity.NativeMethodInfoPtr_set_reservedItems_Public_set_Void_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685347);
			SurfaceStorageEntity.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685348);
			SurfaceStorageEntity.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685349);
			SurfaceStorageEntity.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685350);
			SurfaceStorageEntity.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685351);
			SurfaceStorageEntity.NativeMethodInfoPtr_get_Selectable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685352);
			SurfaceStorageEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685353);
			SurfaceStorageEntity.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685354);
			SurfaceStorageEntity.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685355);
			SurfaceStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685356);
			SurfaceStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685357);
			SurfaceStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685358);
			SurfaceStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685359);
			SurfaceStorageEntity.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685360);
			SurfaceStorageEntity.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685361);
			SurfaceStorageEntity.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685362);
			SurfaceStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685363);
			SurfaceStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685364);
			SurfaceStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685365);
			SurfaceStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685366);
			SurfaceStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685367);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685368);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685369);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685370);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685371);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685372);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685373);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685374);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685375);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685376);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685377);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685378);
			SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685379);
			SurfaceStorageEntity.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685380);
			SurfaceStorageEntity.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685381);
			SurfaceStorageEntity.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_SurfaceStorageEntity_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685382);
			SurfaceStorageEntity.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685383);
			SurfaceStorageEntity.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685384);
			SurfaceStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr, 100685385);
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x002C9DF0 File Offset: 0x002C7FF0
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 166204, RefRangeEnd = 166213, XrefRangeStart = 166204, XrefRangeEnd = 166213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x002C9E30 File Offset: 0x002C8030
		// (set) Token: 0x0600B2D5 RID: 45781 RVA: 0x002C9E70 File Offset: 0x002C8070
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 224434, RefRangeEnd = 224436, XrefRangeStart = 224434, XrefRangeEnd = 224436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_set_reservedItems_Public_set_Void_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x002C9EB4 File Offset: 0x002C80B4
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x002C9EF4 File Offset: 0x002C80F4
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 307813, RefRangeEnd = 307815, XrefRangeStart = 307805, XrefRangeEnd = 307813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x002C9F38 File Offset: 0x002C8138
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x002C9F78 File Offset: 0x002C8178
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 307823, RefRangeEnd = 307825, XrefRangeStart = 307815, XrefRangeEnd = 307823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x002C9FBC File Offset: 0x002C81BC
		public unsafe bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_get_Selectable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600B2DB RID: 45787 RVA: 0x002C9FF8 File Offset: 0x002C81F8
		// (set) Token: 0x0600B2DC RID: 45788 RVA: 0x002CA034 File Offset: 0x002C8234
		public unsafe bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x002CA074 File Offset: 0x002C8274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307825, XrefRangeEnd = 307826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x002CA0B0 File Offset: 0x002C82B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307826, XrefRangeEnd = 307835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x0600B2DF RID: 45791 RVA: 0x002CA0F0 File Offset: 0x002C82F0
		[CallerCount(0)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr3) : null;
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x002CA130 File Offset: 0x002C8330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307835, XrefRangeEnd = 307861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x002CA1A0 File Offset: 0x002C83A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307861, XrefRangeEnd = 307874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x002CA204 File Offset: 0x002C8404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307874, XrefRangeEnd = 307896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x002CA248 File Offset: 0x002C8448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307896, XrefRangeEnd = 307918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x002CA28C File Offset: 0x002C848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307918, XrefRangeEnd = 307929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x002CA2F0 File Offset: 0x002C84F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307929, XrefRangeEnd = 307938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x002CA334 File Offset: 0x002C8534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307938, XrefRangeEnd = 307960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceStorageEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceStorageEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x002CA370 File Offset: 0x002C8570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307960, XrefRangeEnd = 308010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x002CA3AC File Offset: 0x002C85AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308010, XrefRangeEnd = 308011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x002CA3E8 File Offset: 0x002C85E8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x002CA424 File Offset: 0x002C8624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308011, XrefRangeEnd = 308025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x002CA494 File Offset: 0x002C8694
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308084, RefRangeEnd = 308088, XrefRangeStart = 308025, XrefRangeEnd = 308084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x002CA504 File Offset: 0x002C8704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308088, XrefRangeEnd = 308095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x002CA554 File Offset: 0x002C8754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x002CA5B8 File Offset: 0x002C87B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308095, XrefRangeEnd = 308120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x002CA61C File Offset: 0x002C881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308120, XrefRangeEnd = 308150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x002CA680 File Offset: 0x002C8880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308150, XrefRangeEnd = 308169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x002CA6C4 File Offset: 0x002C88C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307823, RefRangeEnd = 307825, XrefRangeStart = 307823, XrefRangeEnd = 307825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x002CA708 File Offset: 0x002C8908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308169, XrefRangeEnd = 308173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x002CA76C File Offset: 0x002C896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308173, XrefRangeEnd = 308192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x002CA7B0 File Offset: 0x002C89B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307813, RefRangeEnd = 307815, XrefRangeStart = 307813, XrefRangeEnd = 307815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x002CA7F4 File Offset: 0x002C89F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308192, XrefRangeEnd = 308196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x002CA858 File Offset: 0x002C8A58
		// (set) Token: 0x0600B2F7 RID: 45815 RVA: 0x002CA898 File Offset: 0x002C8A98
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 308205, RefRangeEnd = 308207, XrefRangeStart = 308196, XrefRangeEnd = 308205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x002CA8E8 File Offset: 0x002C8AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308207, XrefRangeEnd = 308218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_SurfaceStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_SurfaceStorageEntity_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600B2F9 RID: 45817 RVA: 0x002CA95C File Offset: 0x002C8B5C
		// (set) Token: 0x0600B2FA RID: 45818 RVA: 0x002CA99C File Offset: 0x002C8B9C
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308227, RefRangeEnd = 308228, XrefRangeStart = 308218, XrefRangeEnd = 308227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceStorageEntity.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x002CA9EC File Offset: 0x002C8BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308228, XrefRangeEnd = 308229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x00057AEA File Offset: 0x00055CEA
		public SurfaceStorageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600B2FD RID: 45821 RVA: 0x002CAA28 File Offset: 0x002C8C28
		// (set) Token: 0x0600B2FE RID: 45822 RVA: 0x00057AF3 File Offset: 0x00055CF3
		public unsafe Transform _storedItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__storedItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__storedItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600B2FF RID: 45823 RVA: 0x002CAA58 File Offset: 0x002C8C58
		// (set) Token: 0x0600B300 RID: 45824 RVA: 0x00057B12 File Offset: 0x00055D12
		public unsafe StorageEntity StorageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_StorageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_StorageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600B301 RID: 45825 RVA: 0x002CAA88 File Offset: 0x002C8C88
		// (set) Token: 0x0600B302 RID: 45826 RVA: 0x00057B31 File Offset: 0x00055D31
		public unsafe List<StorageGrid> storageGrids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_storageGrids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_storageGrids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600B303 RID: 45827 RVA: 0x002CAAB8 File Offset: 0x002C8CB8
		// (set) Token: 0x0600B304 RID: 45828 RVA: 0x00057B50 File Offset: 0x00055D50
		public unsafe Dictionary<StoredItem, Employee> _reservedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__reservedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__reservedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600B305 RID: 45829 RVA: 0x002CAAE8 File Offset: 0x002C8CE8
		// (set) Token: 0x0600B306 RID: 45830 RVA: 0x00057B6F File Offset: 0x00055D6F
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x002CAB18 File Offset: 0x002C8D18
		// (set) Token: 0x0600B308 RID: 45832 RVA: 0x00057B8E File Offset: 0x00055D8E
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600B309 RID: 45833 RVA: 0x002CAB48 File Offset: 0x002C8D48
		// (set) Token: 0x0600B30A RID: 45834 RVA: 0x00057BAD File Offset: 0x00055DAD
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600B30B RID: 45835 RVA: 0x002CAB70 File Offset: 0x002C8D70
		// (set) Token: 0x0600B30C RID: 45836 RVA: 0x00057BC8 File Offset: 0x00055DC8
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600B30D RID: 45837 RVA: 0x002CAB98 File Offset: 0x002C8D98
		// (set) Token: 0x0600B30E RID: 45838 RVA: 0x00057BE3 File Offset: 0x00055DE3
		public unsafe List<string> completedJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_completedJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_completedJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600B30F RID: 45839 RVA: 0x002CABC8 File Offset: 0x002C8DC8
		// (set) Token: 0x0600B310 RID: 45840 RVA: 0x00057C02 File Offset: 0x00055E02
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600B311 RID: 45841 RVA: 0x002CABF8 File Offset: 0x002C8DF8
		// (set) Token: 0x0600B312 RID: 45842 RVA: 0x00057C21 File Offset: 0x00055E21
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600B313 RID: 45843 RVA: 0x002CAC28 File Offset: 0x002C8E28
		// (set) Token: 0x0600B314 RID: 45844 RVA: 0x00057C40 File Offset: 0x00055E40
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600B315 RID: 45845 RVA: 0x002CAC50 File Offset: 0x002C8E50
		// (set) Token: 0x0600B316 RID: 45846 RVA: 0x00057C5B File Offset: 0x00055E5B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400789F RID: 30879
		private static readonly IntPtr NativeFieldInfoPtr__storedItemContainer;

		// Token: 0x040078A0 RID: 30880
		private static readonly IntPtr NativeFieldInfoPtr_StorageEntity;

		// Token: 0x040078A1 RID: 30881
		private static readonly IntPtr NativeFieldInfoPtr_storageGrids;

		// Token: 0x040078A2 RID: 30882
		private static readonly IntPtr NativeFieldInfoPtr__reservedItems;

		// Token: 0x040078A3 RID: 30883
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x040078A4 RID: 30884
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x040078A5 RID: 30885
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x040078A6 RID: 30886
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x040078A7 RID: 30887
		private static readonly IntPtr NativeFieldInfoPtr_completedJobs;

		// Token: 0x040078A8 RID: 30888
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x040078A9 RID: 30889
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x040078AA RID: 30890
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040078AB RID: 30891
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040078AC RID: 30892
		private static readonly IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040078AD RID: 30893
		private static readonly IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x040078AE RID: 30894
		private static readonly IntPtr NativeMethodInfoPtr_set_reservedItems_Public_set_Void_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x040078AF RID: 30895
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040078B0 RID: 30896
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040078B1 RID: 30897
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040078B2 RID: 30898
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040078B3 RID: 30899
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_get_Boolean_0;

		// Token: 0x040078B4 RID: 30900
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_get_Boolean_0;

		// Token: 0x040078B5 RID: 30901
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x040078B6 RID: 30902
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040078B7 RID: 30903
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0;

		// Token: 0x040078B8 RID: 30904
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0;

		// Token: 0x040078B9 RID: 30905
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x040078BA RID: 30906
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x040078BB RID: 30907
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040078BC RID: 30908
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040078BD RID: 30909
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x040078BE RID: 30910
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x040078BF RID: 30911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040078C0 RID: 30912
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040078C1 RID: 30913
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040078C2 RID: 30914
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040078C3 RID: 30915
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x040078C4 RID: 30916
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x040078C5 RID: 30917
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0;

		// Token: 0x040078C6 RID: 30918
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x040078C7 RID: 30919
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x040078C8 RID: 30920
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040078C9 RID: 30921
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040078CA RID: 30922
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040078CB RID: 30923
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040078CC RID: 30924
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040078CD RID: 30925
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040078CE RID: 30926
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040078CF RID: 30927
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040078D0 RID: 30928
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040078D1 RID: 30929
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_SurfaceStorageEntity_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040078D2 RID: 30930
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040078D3 RID: 30931
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040078D4 RID: 30932
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
