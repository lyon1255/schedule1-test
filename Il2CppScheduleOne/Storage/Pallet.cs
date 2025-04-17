using System;
using Il2CppFishNet.Component.Transforming;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056E RID: 1390
	public class Pallet : NetworkBehaviour
	{
		// Token: 0x06007A19 RID: 31257 RVA: 0x0020DDA0 File Offset: 0x0020BFA0
		// Note: this type is marked as 'beforefieldinit'.
		static Pallet()
		{
			Il2CppClassPointerStore<Pallet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "Pallet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pallet>.NativeClassPtr);
			Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "palletsOwnedByLocalPlayer");
			Pallet.NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "sizeX");
			Pallet.NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "sizeY");
			Pallet.NativeFieldInfoPtr__storedItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "_storedItemContainer");
			Pallet.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb");
			Pallet.NativeFieldInfoPtr_storageGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "storageGrid");
			Pallet.NativeFieldInfoPtr_networkTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "networkTransform");
			Pallet.NativeFieldInfoPtr_forkliftsInContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "forkliftsInContact");
			Pallet.NativeFieldInfoPtr_currentSlotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "currentSlotGUID");
			Pallet.NativeFieldInfoPtr_currentSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "currentSlot");
			Pallet.NativeFieldInfoPtr_timeSinceSlotCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "timeSinceSlotCheck");
			Pallet.NativeFieldInfoPtr_timeBoundToSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "timeBoundToSlot");
			Pallet.NativeFieldInfoPtr_rb_Mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_Mass");
			Pallet.NativeFieldInfoPtr_rb_Drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_Drag");
			Pallet.NativeFieldInfoPtr_rb_AngularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_AngularDrag");
			Pallet.NativeFieldInfoPtr__reservedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "_reservedItems");
			Pallet.NativeFieldInfoPtr_completedJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "completedJobs");
			Pallet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted");
			Pallet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted");
			Pallet.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678579);
			Pallet.NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678580);
			Pallet.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678581);
			Pallet.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678582);
			Pallet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678583);
			Pallet.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678584);
			Pallet.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678585);
			Pallet.NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678586);
			Pallet.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678587);
			Pallet.NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678588);
			Pallet.NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678589);
			Pallet.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678590);
			Pallet.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678591);
			Pallet.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678592);
			Pallet.NativeMethodInfoPtr_UpdateOwnership_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678593);
			Pallet.NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678594);
			Pallet.NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678595);
			Pallet.NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678596);
			Pallet.NativeMethodInfoPtr_ExitSlot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678597);
			Pallet.NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678598);
			Pallet.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678599);
			Pallet.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678600);
			Pallet.NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678601);
			Pallet.NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678602);
			Pallet.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678603);
			Pallet.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678604);
			Pallet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678605);
			Pallet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678607);
			Pallet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678608);
			Pallet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678609);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678610);
			Pallet.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678611);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678612);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678613);
			Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678614);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678615);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678616);
			Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678617);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678618);
			Pallet.NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678619);
			Pallet.NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678620);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678621);
			Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678622);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678623);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678624);
			Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678625);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678626);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678627);
			Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678628);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678629);
			Pallet.NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678630);
			Pallet.NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678631);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678632);
			Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678633);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678634);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678635);
			Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678636);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678637);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678638);
			Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678639);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678640);
			Pallet.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678641);
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06007A1A RID: 31258 RVA: 0x0020E424 File Offset: 0x0020C624
		public unsafe bool isEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233628, XrefRangeEnd = 233629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x0020E460 File Offset: 0x0020C660
		public unsafe bool carriedByForklift
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233629, XrefRangeEnd = 233630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06007A1C RID: 31260 RVA: 0x0020E49C File Offset: 0x0020C69C
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x0020E4DC File Offset: 0x0020C6DC
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr3) : null;
			}
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x0020E51C File Offset: 0x0020C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233630, XrefRangeEnd = 233634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x0020E558 File Offset: 0x0020C758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233634, XrefRangeEnd = 233641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x0020E594 File Offset: 0x0020C794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233641, XrefRangeEnd = 233660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x0020E5E4 File Offset: 0x0020C7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233660, XrefRangeEnd = 233684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnOwnershipClient(NetworkConnection prevOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevOwner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x0020E634 File Offset: 0x0020C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233684, XrefRangeEnd = 233691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x0020E684 File Offset: 0x0020C884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233709, RefRangeEnd = 233710, XrefRangeStart = 233691, XrefRangeEnd = 233709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemsToClient(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x0020E6C8 File Offset: 0x0020C8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233710, XrefRangeEnd = 233711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyPallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x0020E704 File Offset: 0x0020C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233711, XrefRangeEnd = 233717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x0020E740 File Offset: 0x0020C940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233717, XrefRangeEnd = 233811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x0020E77C File Offset: 0x0020C97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233811, XrefRangeEnd = 233813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x0020E7BC File Offset: 0x0020C9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233830, RefRangeEnd = 233831, XrefRangeStart = 233813, XrefRangeEnd = 233830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOwnership()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_UpdateOwnership_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0020E7F0 File Offset: 0x0020C9F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233853, RefRangeEnd = 233855, XrefRangeStart = 233831, XrefRangeEnd = 233853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindToSlot_Server(Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x0020E830 File Offset: 0x0020CA30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 233888, RefRangeEnd = 233892, XrefRangeStart = 233855, XrefRangeEnd = 233888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindToSlot(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0020E880 File Offset: 0x0020CA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233892, XrefRangeEnd = 233913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlot_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0020E8B4 File Offset: 0x0020CAB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233931, RefRangeEnd = 233934, XrefRangeStart = 233913, XrefRangeEnd = 233931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_ExitSlot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0020E8E8 File Offset: 0x0020CAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233963, RefRangeEnd = 233964, XrefRangeStart = 233934, XrefRangeEnd = 233963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x0020E92C File Offset: 0x0020CB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233964, XrefRangeEnd = 233973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0020E96C File Offset: 0x0020CB6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233982, RefRangeEnd = 233984, XrefRangeStart = 233973, XrefRangeEnd = 233982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr3) : null;
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x0020E9AC File Offset: 0x0020CBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233984, XrefRangeEnd = 233985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x0020EA4C File Offset: 0x0020CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233985, XrefRangeEnd = 234010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x0020EACC File Offset: 0x0020CCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234010, XrefRangeEnd = 234036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x0020EB3C File Offset: 0x0020CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234036, XrefRangeEnd = 234049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x0020EBA0 File Offset: 0x0020CDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234049, XrefRangeEnd = 234071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pallet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pallet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x0020EBDC File Offset: 0x0020CDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234071, XrefRangeEnd = 234139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x0020EC18 File Offset: 0x0020CE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234139, RefRangeEnd = 234140, XrefRangeStart = 234139, XrefRangeEnd = 234139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x0020EC54 File Offset: 0x0020CE54
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x0020EC90 File Offset: 0x0020CE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0020ECD4 File Offset: 0x0020CED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234184, RefRangeEnd = 234185, XrefRangeStart = 234140, XrefRangeEnd = 234184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x0020ED24 File Offset: 0x0020CF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234185, XrefRangeEnd = 234188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x0020ED88 File Offset: 0x0020CF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234188, XrefRangeEnd = 234199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BindToSlot_Server_1272046255(Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x0020EDC8 File Offset: 0x0020CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234199, XrefRangeEnd = 234200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BindToSlot_Server_1272046255(Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x0020EE08 File Offset: 0x0020D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234200, XrefRangeEnd = 234204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x0020EE6C File Offset: 0x0020D06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234204, XrefRangeEnd = 234215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x0020EEBC File Offset: 0x0020D0BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234284, RefRangeEnd = 234286, XrefRangeStart = 234215, XrefRangeEnd = 234284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x0020EF0C File Offset: 0x0020D10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234286, XrefRangeEnd = 234289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x0020EF5C File Offset: 0x0020D15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234289, XrefRangeEnd = 234300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x0020EFAC File Offset: 0x0020D1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234300, XrefRangeEnd = 234304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x0020EFFC File Offset: 0x0020D1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234304, XrefRangeEnd = 234322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExitSlot_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x0020F030 File Offset: 0x0020D230
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233931, RefRangeEnd = 233934, XrefRangeStart = 233931, XrefRangeEnd = 233934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitSlot_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x0020F064 File Offset: 0x0020D264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234322, XrefRangeEnd = 234325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x0020F0C8 File Offset: 0x0020D2C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233931, RefRangeEnd = 233934, XrefRangeStart = 233931, XrefRangeEnd = 233934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitSlot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x0020F0FC File Offset: 0x0020D2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234365, RefRangeEnd = 234366, XrefRangeStart = 234325, XrefRangeEnd = 234365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitSlot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x0020F130 File Offset: 0x0020D330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234366, XrefRangeEnd = 234368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0020F180 File Offset: 0x0020D380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234394, RefRangeEnd = 234397, XrefRangeStart = 234368, XrefRangeEnd = 234394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x0020F220 File Offset: 0x0020D420
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 234436, RefRangeEnd = 234441, XrefRangeStart = 234397, XrefRangeEnd = 234436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x0020F2C0 File Offset: 0x0020D4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234441, XrefRangeEnd = 234451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x0020F310 File Offset: 0x0020D510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234468, RefRangeEnd = 234470, XrefRangeStart = 234451, XrefRangeEnd = 234468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0020F3B0 File Offset: 0x0020D5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234470, XrefRangeEnd = 234480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x0020F400 File Offset: 0x0020D600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234480, XrefRangeEnd = 234505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x0020F480 File Offset: 0x0020D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234505, XrefRangeEnd = 234507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x0020F500 File Offset: 0x0020D700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234507, XrefRangeEnd = 234517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x0020F564 File Offset: 0x0020D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234517, XrefRangeEnd = 234531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x0020F5D4 File Offset: 0x0020D7D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234591, RefRangeEnd = 234595, XrefRangeStart = 234531, XrefRangeEnd = 234591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x0020F644 File Offset: 0x0020D844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234595, XrefRangeEnd = 234602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x0020F694 File Offset: 0x0020D894
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x0020F6F8 File Offset: 0x0020D8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234602, XrefRangeEnd = 234627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0020F75C File Offset: 0x0020D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234627, XrefRangeEnd = 234657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x0020F7C0 File Offset: 0x0020D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234657, XrefRangeEnd = 234660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0003A1C6 File Offset: 0x000383C6
		public Pallet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06007A59 RID: 31321 RVA: 0x0020F7FC File Offset: 0x0020D9FC
		// (set) Token: 0x06007A5A RID: 31322 RVA: 0x0003A1CF File Offset: 0x000383CF
		public unsafe static List<Pallet> palletsOwnedByLocalPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pallet>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06007A5B RID: 31323 RVA: 0x0020F824 File Offset: 0x0020DA24
		// (set) Token: 0x06007A5C RID: 31324 RVA: 0x0003A1E1 File Offset: 0x000383E1
		public unsafe static int sizeX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_sizeX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_sizeX, (void*)(&value));
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x06007A5D RID: 31325 RVA: 0x0020F840 File Offset: 0x0020DA40
		// (set) Token: 0x06007A5E RID: 31326 RVA: 0x0003A1EF File Offset: 0x000383EF
		public unsafe static int sizeY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_sizeY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_sizeY, (void*)(&value));
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x06007A5F RID: 31327 RVA: 0x0020F85C File Offset: 0x0020DA5C
		// (set) Token: 0x06007A60 RID: 31328 RVA: 0x0003A1FD File Offset: 0x000383FD
		public unsafe Transform _storedItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__storedItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__storedItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x06007A61 RID: 31329 RVA: 0x0020F88C File Offset: 0x0020DA8C
		// (set) Token: 0x06007A62 RID: 31330 RVA: 0x0003A21C File Offset: 0x0003841C
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06007A63 RID: 31331 RVA: 0x0020F8BC File Offset: 0x0020DABC
		// (set) Token: 0x06007A64 RID: 31332 RVA: 0x0003A23B File Offset: 0x0003843B
		public unsafe StorageGrid storageGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_storageGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_storageGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06007A65 RID: 31333 RVA: 0x0020F8EC File Offset: 0x0020DAEC
		// (set) Token: 0x06007A66 RID: 31334 RVA: 0x0003A25A File Offset: 0x0003845A
		public unsafe NetworkTransform networkTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_networkTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_networkTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x06007A67 RID: 31335 RVA: 0x0020F91C File Offset: 0x0020DB1C
		// (set) Token: 0x06007A68 RID: 31336 RVA: 0x0003A279 File Offset: 0x00038479
		public unsafe List<Forklift> forkliftsInContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_forkliftsInContact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Forklift>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_forkliftsInContact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x06007A69 RID: 31337 RVA: 0x0020F94C File Offset: 0x0020DB4C
		// (set) Token: 0x06007A6A RID: 31338 RVA: 0x0003A298 File Offset: 0x00038498
		public unsafe Guid currentSlotGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlotGUID)) = value;
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x06007A6B RID: 31339 RVA: 0x0020F974 File Offset: 0x0020DB74
		// (set) Token: 0x06007A6C RID: 31340 RVA: 0x0003A2B3 File Offset: 0x000384B3
		public unsafe PalletSlot currentSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PalletSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x0020F9A4 File Offset: 0x0020DBA4
		// (set) Token: 0x06007A6E RID: 31342 RVA: 0x0003A2D2 File Offset: 0x000384D2
		public unsafe float timeSinceSlotCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeSinceSlotCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeSinceSlotCheck)) = value;
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x0020F9CC File Offset: 0x0020DBCC
		// (set) Token: 0x06007A70 RID: 31344 RVA: 0x0003A2ED File Offset: 0x000384ED
		public unsafe float timeBoundToSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeBoundToSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeBoundToSlot)) = value;
			}
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x0020F9F4 File Offset: 0x0020DBF4
		// (set) Token: 0x06007A72 RID: 31346 RVA: 0x0003A308 File Offset: 0x00038508
		public unsafe float rb_Mass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Mass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Mass)) = value;
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06007A73 RID: 31347 RVA: 0x0020FA1C File Offset: 0x0020DC1C
		// (set) Token: 0x06007A74 RID: 31348 RVA: 0x0003A323 File Offset: 0x00038523
		public unsafe float rb_Drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Drag)) = value;
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x0020FA44 File Offset: 0x0020DC44
		// (set) Token: 0x06007A76 RID: 31350 RVA: 0x0003A33E File Offset: 0x0003853E
		public unsafe float rb_AngularDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_AngularDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_AngularDrag)) = value;
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x0020FA6C File Offset: 0x0020DC6C
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x0003A359 File Offset: 0x00038559
		public unsafe Dictionary<StoredItem, Employee> _reservedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__reservedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__reservedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x0020FA9C File Offset: 0x0020DC9C
		// (set) Token: 0x06007A7A RID: 31354 RVA: 0x0003A378 File Offset: 0x00038578
		public unsafe List<string> completedJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_completedJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_completedJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x0020FACC File Offset: 0x0020DCCC
		// (set) Token: 0x06007A7C RID: 31356 RVA: 0x0003A397 File Offset: 0x00038597
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06007A7D RID: 31357 RVA: 0x0020FAF4 File Offset: 0x0020DCF4
		// (set) Token: 0x06007A7E RID: 31358 RVA: 0x0003A3B2 File Offset: 0x000385B2
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005310 RID: 21264
		private static readonly IntPtr NativeFieldInfoPtr_palletsOwnedByLocalPlayer;

		// Token: 0x04005311 RID: 21265
		private static readonly IntPtr NativeFieldInfoPtr_sizeX;

		// Token: 0x04005312 RID: 21266
		private static readonly IntPtr NativeFieldInfoPtr_sizeY;

		// Token: 0x04005313 RID: 21267
		private static readonly IntPtr NativeFieldInfoPtr__storedItemContainer;

		// Token: 0x04005314 RID: 21268
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04005315 RID: 21269
		private static readonly IntPtr NativeFieldInfoPtr_storageGrid;

		// Token: 0x04005316 RID: 21270
		private static readonly IntPtr NativeFieldInfoPtr_networkTransform;

		// Token: 0x04005317 RID: 21271
		private static readonly IntPtr NativeFieldInfoPtr_forkliftsInContact;

		// Token: 0x04005318 RID: 21272
		private static readonly IntPtr NativeFieldInfoPtr_currentSlotGUID;

		// Token: 0x04005319 RID: 21273
		private static readonly IntPtr NativeFieldInfoPtr_currentSlot;

		// Token: 0x0400531A RID: 21274
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceSlotCheck;

		// Token: 0x0400531B RID: 21275
		private static readonly IntPtr NativeFieldInfoPtr_timeBoundToSlot;

		// Token: 0x0400531C RID: 21276
		private static readonly IntPtr NativeFieldInfoPtr_rb_Mass;

		// Token: 0x0400531D RID: 21277
		private static readonly IntPtr NativeFieldInfoPtr_rb_Drag;

		// Token: 0x0400531E RID: 21278
		private static readonly IntPtr NativeFieldInfoPtr_rb_AngularDrag;

		// Token: 0x0400531F RID: 21279
		private static readonly IntPtr NativeFieldInfoPtr__reservedItems;

		// Token: 0x04005320 RID: 21280
		private static readonly IntPtr NativeFieldInfoPtr_completedJobs;

		// Token: 0x04005321 RID: 21281
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005322 RID: 21282
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005323 RID: 21283
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		// Token: 0x04005324 RID: 21284
		private static readonly IntPtr NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0;

		// Token: 0x04005325 RID: 21285
		private static readonly IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04005326 RID: 21286
		private static readonly IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x04005327 RID: 21287
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005328 RID: 21288
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04005329 RID: 21289
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x0400532A RID: 21290
		private static readonly IntPtr NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400532B RID: 21291
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400532C RID: 21292
		private static readonly IntPtr NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0;

		// Token: 0x0400532D RID: 21293
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0;

		// Token: 0x0400532E RID: 21294
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400532F RID: 21295
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04005330 RID: 21296
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0;

		// Token: 0x04005331 RID: 21297
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Private_Void_0;

		// Token: 0x04005332 RID: 21298
		private static readonly IntPtr NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0;

		// Token: 0x04005333 RID: 21299
		private static readonly IntPtr NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x04005334 RID: 21300
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0;

		// Token: 0x04005335 RID: 21301
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlot_Private_Void_0;

		// Token: 0x04005336 RID: 21302
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0;

		// Token: 0x04005337 RID: 21303
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0;

		// Token: 0x04005338 RID: 21304
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0;

		// Token: 0x04005339 RID: 21305
		private static readonly IntPtr NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x0400533A RID: 21306
		private static readonly IntPtr NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x0400533B RID: 21307
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x0400533C RID: 21308
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x0400533D RID: 21309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400533E RID: 21310
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400533F RID: 21311
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005340 RID: 21312
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005341 RID: 21313
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04005342 RID: 21314
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005343 RID: 21315
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005344 RID: 21316
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0;

		// Token: 0x04005345 RID: 21317
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0;

		// Token: 0x04005346 RID: 21318
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005347 RID: 21319
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x04005348 RID: 21320
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x04005349 RID: 21321
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400534A RID: 21322
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x0400534B RID: 21323
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400534C RID: 21324
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0;

		// Token: 0x0400534D RID: 21325
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0;

		// Token: 0x0400534E RID: 21326
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400534F RID: 21327
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0;

		// Token: 0x04005350 RID: 21328
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0;

		// Token: 0x04005351 RID: 21329
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005352 RID: 21330
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005353 RID: 21331
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005354 RID: 21332
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005355 RID: 21333
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005356 RID: 21334
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005357 RID: 21335
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x04005358 RID: 21336
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x04005359 RID: 21337
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400535A RID: 21338
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x0400535B RID: 21339
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x0400535C RID: 21340
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400535D RID: 21341
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x0400535E RID: 21342
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x0400535F RID: 21343
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005360 RID: 21344
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
