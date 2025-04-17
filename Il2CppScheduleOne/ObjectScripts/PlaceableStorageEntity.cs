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
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000751 RID: 1873
	public class PlaceableStorageEntity : GridItem
	{
		// Token: 0x0600B1D0 RID: 45520 RVA: 0x002C5D20 File Offset: 0x002C3F20
		// Note: this type is marked as 'beforefieldinit'.
		static PlaceableStorageEntity()
		{
			Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "PlaceableStorageEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr);
			PlaceableStorageEntity.NativeFieldInfoPtr__storedItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "_storedItemContainer");
			PlaceableStorageEntity.NativeFieldInfoPtr_StorageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "StorageEntity");
			PlaceableStorageEntity.NativeFieldInfoPtr_storageGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "storageGrids");
			PlaceableStorageEntity.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "accessPoints");
			PlaceableStorageEntity.NativeFieldInfoPtr__reservedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "_reservedItems");
			PlaceableStorageEntity.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "<InputSlots>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "<OutputSlots>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "<Selectable>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr_completedJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "completedJobs");
			PlaceableStorageEntity.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			PlaceableStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted");
			PlaceableStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted");
			PlaceableStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685202);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685203);
			PlaceableStorageEntity.NativeMethodInfoPtr_set_reservedItems_Public_set_Void_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685204);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685205);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685206);
			PlaceableStorageEntity.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685207);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685208);
			PlaceableStorageEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685209);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685210);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685211);
			PlaceableStorageEntity.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685212);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685213);
			PlaceableStorageEntity.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685214);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685215);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685216);
			PlaceableStorageEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685217);
			PlaceableStorageEntity.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685218);
			PlaceableStorageEntity.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685219);
			PlaceableStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685220);
			PlaceableStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685221);
			PlaceableStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685222);
			PlaceableStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685223);
			PlaceableStorageEntity.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685224);
			PlaceableStorageEntity.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685225);
			PlaceableStorageEntity.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685226);
			PlaceableStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685227);
			PlaceableStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685228);
			PlaceableStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685229);
			PlaceableStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685230);
			PlaceableStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685231);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685232);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685233);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685234);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685235);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685236);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685237);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685238);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685239);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685240);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685241);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685242);
			PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685243);
			PlaceableStorageEntity.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685244);
			PlaceableStorageEntity.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685245);
			PlaceableStorageEntity.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_PlaceableStorageEntity_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685246);
			PlaceableStorageEntity.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685247);
			PlaceableStorageEntity.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685248);
			PlaceableStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr, 100685249);
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x002C6250 File Offset: 0x002C4450
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600B1D2 RID: 45522 RVA: 0x002C6290 File Offset: 0x002C4490
		// (set) Token: 0x0600B1D3 RID: 45523 RVA: 0x002C62D0 File Offset: 0x002C44D0
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306546, XrefRangeEnd = 306547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_set_reservedItems_Public_set_Void_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x002C6314 File Offset: 0x002C4514
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600B1D5 RID: 45525 RVA: 0x002C634C File Offset: 0x002C454C
		// (set) Token: 0x0600B1D6 RID: 45526 RVA: 0x002C638C File Offset: 0x002C458C
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306547, XrefRangeEnd = 306548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x002C63D0 File Offset: 0x002C45D0
		// (set) Token: 0x0600B1D8 RID: 45528 RVA: 0x002C6410 File Offset: 0x002C4610
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x002C6454 File Offset: 0x002C4654
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600B1DA RID: 45530 RVA: 0x002C6494 File Offset: 0x002C4694
		// (set) Token: 0x0600B1DB RID: 45531 RVA: 0x002C64D4 File Offset: 0x002C46D4
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306556, RefRangeEnd = 306558, XrefRangeStart = 306548, XrefRangeEnd = 306556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600B1DC RID: 45532 RVA: 0x002C6518 File Offset: 0x002C4718
		// (set) Token: 0x0600B1DD RID: 45533 RVA: 0x002C6558 File Offset: 0x002C4758
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306566, RefRangeEnd = 306568, XrefRangeStart = 306558, XrefRangeEnd = 306566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x002C659C File Offset: 0x002C479C
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600B1DF RID: 45535 RVA: 0x002C65DC File Offset: 0x002C47DC
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600B1E0 RID: 45536 RVA: 0x002C6618 File Offset: 0x002C4818
		// (set) Token: 0x0600B1E1 RID: 45537 RVA: 0x002C6654 File Offset: 0x002C4854
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x002C6694 File Offset: 0x002C4894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306585, RefRangeEnd = 306586, XrefRangeStart = 306568, XrefRangeEnd = 306585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x002C66D0 File Offset: 0x002C48D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306586, XrefRangeEnd = 306595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x002C6710 File Offset: 0x002C4910
		[CallerCount(0)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr3) : null;
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x002C6750 File Offset: 0x002C4950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306595, XrefRangeEnd = 306621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x002C67C0 File Offset: 0x002C49C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306621, XrefRangeEnd = 306634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x002C6824 File Offset: 0x002C4A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306634, XrefRangeEnd = 306656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x002C6868 File Offset: 0x002C4A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306656, XrefRangeEnd = 306678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x002C68AC File Offset: 0x002C4AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306678, XrefRangeEnd = 306689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x002C6910 File Offset: 0x002C4B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306689, XrefRangeEnd = 306698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x002C6954 File Offset: 0x002C4B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306732, RefRangeEnd = 306733, XrefRangeStart = 306698, XrefRangeEnd = 306732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaceableStorageEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceableStorageEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x002C6990 File Offset: 0x002C4B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306783, RefRangeEnd = 306784, XrefRangeStart = 306733, XrefRangeEnd = 306783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x002C69CC File Offset: 0x002C4BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306785, RefRangeEnd = 306786, XrefRangeStart = 306784, XrefRangeEnd = 306785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x002C6A08 File Offset: 0x002C4C08
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x002C6A44 File Offset: 0x002C4C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306786, XrefRangeEnd = 306800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x002C6AB4 File Offset: 0x002C4CB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 306859, RefRangeEnd = 306863, XrefRangeStart = 306800, XrefRangeEnd = 306859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x002C6B24 File Offset: 0x002C4D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306863, XrefRangeEnd = 306870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x002C6B74 File Offset: 0x002C4D74
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x002C6BD8 File Offset: 0x002C4DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306870, XrefRangeEnd = 306895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x002C6C3C File Offset: 0x002C4E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306895, XrefRangeEnd = 306925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x002C6CA0 File Offset: 0x002C4EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306925, XrefRangeEnd = 306944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x002C6CE4 File Offset: 0x002C4EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306566, RefRangeEnd = 306568, XrefRangeStart = 306566, XrefRangeEnd = 306568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x002C6D28 File Offset: 0x002C4F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306944, XrefRangeEnd = 306948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x002C6D8C File Offset: 0x002C4F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306948, XrefRangeEnd = 306967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x002C6DD0 File Offset: 0x002C4FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306556, RefRangeEnd = 306558, XrefRangeStart = 306556, XrefRangeEnd = 306558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x002C6E14 File Offset: 0x002C5014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306967, XrefRangeEnd = 306971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x002C6E78 File Offset: 0x002C5078
		// (set) Token: 0x0600B1FC RID: 45564 RVA: 0x002C6EB8 File Offset: 0x002C50B8
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306980, RefRangeEnd = 306982, XrefRangeStart = 306971, XrefRangeEnd = 306980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x002C6F08 File Offset: 0x002C5108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306982, XrefRangeEnd = 306993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_PlaceableStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_PlaceableStorageEntity_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600B1FE RID: 45566 RVA: 0x002C6F7C File Offset: 0x002C517C
		// (set) Token: 0x0600B1FF RID: 45567 RVA: 0x002C6FBC File Offset: 0x002C51BC
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 307002, RefRangeEnd = 307003, XrefRangeStart = 306993, XrefRangeEnd = 307002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageEntity.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x002C700C File Offset: 0x002C520C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290619, RefRangeEnd = 290620, XrefRangeStart = 290619, XrefRangeEnd = 290620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceableStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x00057417 File Offset: 0x00055617
		public PlaceableStorageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600B202 RID: 45570 RVA: 0x002C7048 File Offset: 0x002C5248
		// (set) Token: 0x0600B203 RID: 45571 RVA: 0x00057420 File Offset: 0x00055620
		public unsafe Transform _storedItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__storedItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__storedItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600B204 RID: 45572 RVA: 0x002C7078 File Offset: 0x002C5278
		// (set) Token: 0x0600B205 RID: 45573 RVA: 0x0005743F File Offset: 0x0005563F
		public unsafe StorageEntity StorageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_StorageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_StorageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600B206 RID: 45574 RVA: 0x002C70A8 File Offset: 0x002C52A8
		// (set) Token: 0x0600B207 RID: 45575 RVA: 0x0005745E File Offset: 0x0005565E
		public unsafe List<StorageGrid> storageGrids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_storageGrids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_storageGrids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600B208 RID: 45576 RVA: 0x002C70D8 File Offset: 0x002C52D8
		// (set) Token: 0x0600B209 RID: 45577 RVA: 0x0005747D File Offset: 0x0005567D
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600B20A RID: 45578 RVA: 0x002C7108 File Offset: 0x002C5308
		// (set) Token: 0x0600B20B RID: 45579 RVA: 0x0005749C File Offset: 0x0005569C
		public unsafe Dictionary<StoredItem, Employee> _reservedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__reservedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__reservedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600B20C RID: 45580 RVA: 0x002C7138 File Offset: 0x002C5338
		// (set) Token: 0x0600B20D RID: 45581 RVA: 0x000574BB File Offset: 0x000556BB
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600B20E RID: 45582 RVA: 0x002C7168 File Offset: 0x002C5368
		// (set) Token: 0x0600B20F RID: 45583 RVA: 0x000574DA File Offset: 0x000556DA
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600B210 RID: 45584 RVA: 0x002C7198 File Offset: 0x002C5398
		// (set) Token: 0x0600B211 RID: 45585 RVA: 0x000574F9 File Offset: 0x000556F9
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600B212 RID: 45586 RVA: 0x002C71C8 File Offset: 0x002C53C8
		// (set) Token: 0x0600B213 RID: 45587 RVA: 0x00057518 File Offset: 0x00055718
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600B214 RID: 45588 RVA: 0x002C71F8 File Offset: 0x002C53F8
		// (set) Token: 0x0600B215 RID: 45589 RVA: 0x00057537 File Offset: 0x00055737
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600B216 RID: 45590 RVA: 0x002C7220 File Offset: 0x002C5420
		// (set) Token: 0x0600B217 RID: 45591 RVA: 0x00057552 File Offset: 0x00055752
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600B218 RID: 45592 RVA: 0x002C7248 File Offset: 0x002C5448
		// (set) Token: 0x0600B219 RID: 45593 RVA: 0x0005756D File Offset: 0x0005576D
		public unsafe List<string> completedJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_completedJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_completedJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x002C7278 File Offset: 0x002C5478
		// (set) Token: 0x0600B21B RID: 45595 RVA: 0x0005758C File Offset: 0x0005578C
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600B21C RID: 45596 RVA: 0x002C72A8 File Offset: 0x002C54A8
		// (set) Token: 0x0600B21D RID: 45597 RVA: 0x000575AB File Offset: 0x000557AB
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600B21E RID: 45598 RVA: 0x002C72D8 File Offset: 0x002C54D8
		// (set) Token: 0x0600B21F RID: 45599 RVA: 0x000575CA File Offset: 0x000557CA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600B220 RID: 45600 RVA: 0x002C7300 File Offset: 0x002C5500
		// (set) Token: 0x0600B221 RID: 45601 RVA: 0x000575E5 File Offset: 0x000557E5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040077E3 RID: 30691
		private static readonly IntPtr NativeFieldInfoPtr__storedItemContainer;

		// Token: 0x040077E4 RID: 30692
		private static readonly IntPtr NativeFieldInfoPtr_StorageEntity;

		// Token: 0x040077E5 RID: 30693
		private static readonly IntPtr NativeFieldInfoPtr_storageGrids;

		// Token: 0x040077E6 RID: 30694
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x040077E7 RID: 30695
		private static readonly IntPtr NativeFieldInfoPtr__reservedItems;

		// Token: 0x040077E8 RID: 30696
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x040077E9 RID: 30697
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x040077EA RID: 30698
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x040077EB RID: 30699
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x040077EC RID: 30700
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x040077ED RID: 30701
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x040077EE RID: 30702
		private static readonly IntPtr NativeFieldInfoPtr_completedJobs;

		// Token: 0x040077EF RID: 30703
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x040077F0 RID: 30704
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x040077F1 RID: 30705
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040077F2 RID: 30706
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040077F3 RID: 30707
		private static readonly IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040077F4 RID: 30708
		private static readonly IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x040077F5 RID: 30709
		private static readonly IntPtr NativeMethodInfoPtr_set_reservedItems_Public_set_Void_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x040077F6 RID: 30710
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040077F7 RID: 30711
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040077F8 RID: 30712
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040077F9 RID: 30713
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040077FA RID: 30714
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040077FB RID: 30715
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040077FC RID: 30716
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040077FD RID: 30717
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040077FE RID: 30718
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040077FF RID: 30719
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007800 RID: 30720
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04007801 RID: 30721
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007802 RID: 30722
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007803 RID: 30723
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04007804 RID: 30724
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007805 RID: 30725
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0;

		// Token: 0x04007806 RID: 30726
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0;

		// Token: 0x04007807 RID: 30727
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x04007808 RID: 30728
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x04007809 RID: 30729
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400780A RID: 30730
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400780B RID: 30731
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x0400780C RID: 30732
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400780D RID: 30733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400780E RID: 30734
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400780F RID: 30735
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007810 RID: 30736
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007811 RID: 30737
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x04007812 RID: 30738
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x04007813 RID: 30739
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007814 RID: 30740
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x04007815 RID: 30741
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x04007816 RID: 30742
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007817 RID: 30743
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007818 RID: 30744
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007819 RID: 30745
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400781A RID: 30746
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400781B RID: 30747
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400781C RID: 30748
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400781D RID: 30749
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400781E RID: 30750
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400781F RID: 30751
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_PlaceableStorageEntity_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04007820 RID: 30752
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04007821 RID: 30753
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04007822 RID: 30754
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
