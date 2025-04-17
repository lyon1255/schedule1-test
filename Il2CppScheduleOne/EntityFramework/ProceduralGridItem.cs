using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000400 RID: 1024
	public class ProceduralGridItem : BuildableItem
	{
		// Token: 0x060055D0 RID: 21968 RVA: 0x001911F4 File Offset: 0x0018F3F4
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItem()
		{
			Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "ProceduralGridItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr);
			ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "ProceduralTileType");
			ProceduralGridItem.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "Rotation");
			ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "footprintTileMatches");
			ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "syncVar___Rotation");
			ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "syncVar___footprintTileMatches");
			ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted");
			ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted");
			ProceduralGridItem.NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674010);
			ProceduralGridItem.NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674011);
			ProceduralGridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674012);
			ProceduralGridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674013);
			ProceduralGridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674014);
			ProceduralGridItem.NativeMethodInfoPtr_SendProceduralGridItemData_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674015);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674016);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674017);
			ProceduralGridItem.NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674018);
			ProceduralGridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674019);
			ProceduralGridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674020);
			ProceduralGridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674021);
			ProceduralGridItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674022);
			ProceduralGridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674023);
			ProceduralGridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674024);
			ProceduralGridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674025);
			ProceduralGridItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674026);
			ProceduralGridItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674027);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674028);
			ProceduralGridItem.NativeMethodInfoPtr__OnStartClient_b__10_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674029);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674030);
			ProceduralGridItem.NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674031);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674032);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674033);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674034);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Server_SendProceduralGridItemData_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674035);
			ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___SendProceduralGridItemData_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674036);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Server_SendProceduralGridItemData_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674037);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674038);
			ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674039);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674040);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674041);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674042);
			ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674043);
			ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674044);
			ProceduralGridItem.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674045);
			ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674046);
			ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674047);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674048);
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x001915D0 File Offset: 0x0018F7D0
		public unsafe int FootprintXSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182119, XrefRangeEnd = 182140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x0019160C File Offset: 0x0018F80C
		public unsafe int FootprintYSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182140, XrefRangeEnd = 182161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00191648 File Offset: 0x0018F848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182168, RefRangeEnd = 182169, XrefRangeStart = 182161, XrefRangeEnd = 182168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00191684 File Offset: 0x0018F884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182169, XrefRangeEnd = 182176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x001916C0 File Offset: 0x0018F8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182176, XrefRangeEnd = 182177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00191710 File Offset: 0x0018F910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182177, XrefRangeEnd = 182191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendProceduralGridItemData(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_SendProceduralGridItemData_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00191788 File Offset: 0x0018F988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182191, XrefRangeEnd = 182240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeProceduralGridItem(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x0019181C File Offset: 0x0018FA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182257, RefRangeEnd = 182258, XrefRangeStart = 182240, XrefRangeEnd = 182257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x0019189C File Offset: 0x0018FA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182258, XrefRangeEnd = 182290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x001918F8 File Offset: 0x0018FAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182290, XrefRangeEnd = 182313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x0019192C File Offset: 0x0018FB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182313, XrefRangeEnd = 182323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00191960 File Offset: 0x0018FB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182335, RefRangeEnd = 182336, XrefRangeStart = 182323, XrefRangeEnd = 182335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x001919AC File Offset: 0x0018FBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182336, XrefRangeEnd = 182348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00191A08 File Offset: 0x0018FC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182348, XrefRangeEnd = 182353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00191A44 File Offset: 0x0018FC44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182359, RefRangeEnd = 182362, XrefRangeStart = 182353, XrefRangeEnd = 182359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00191A84 File Offset: 0x0018FC84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 182369, RefRangeEnd = 182373, XrefRangeStart = 182362, XrefRangeEnd = 182369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00191AD4 File Offset: 0x0018FCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182373, XrefRangeEnd = 182405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00191B18 File Offset: 0x0018FD18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182420, RefRangeEnd = 182421, XrefRangeStart = 182405, XrefRangeEnd = 182420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00191B54 File Offset: 0x0018FD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182421, XrefRangeEnd = 182426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00191B94 File Offset: 0x0018FD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnStartClient_b__10_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__OnStartClient_b__10_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00191BD0 File Offset: 0x0018FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182426, XrefRangeEnd = 182431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00191C10 File Offset: 0x0018FE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetProceduralGridData_b__15_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00191C4C File Offset: 0x0018FE4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182477, RefRangeEnd = 182478, XrefRangeStart = 182431, XrefRangeEnd = 182477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00191C88 File Offset: 0x0018FE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182478, RefRangeEnd = 182479, XrefRangeStart = 182478, XrefRangeEnd = 182478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x00191CC4 File Offset: 0x0018FEC4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x00191D00 File Offset: 0x0018FF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Server_SendProceduralGridItemData_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00191D78 File Offset: 0x0018FF78
		[CallerCount(0)]
		public unsafe void RpcLogic___SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___SendProceduralGridItemData_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00191DF0 File Offset: 0x0018FFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182479, XrefRangeEnd = 182485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendProceduralGridItemData_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Server_SendProceduralGridItemData_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x00191E54 File Offset: 0x00190054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182485, XrefRangeEnd = 182499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00191EDC File Offset: 0x001900DC
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00191F70 File Offset: 0x00190170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182499, XrefRangeEnd = 182506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x00191FC0 File Offset: 0x001901C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182506, XrefRangeEnd = 182529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x00192048 File Offset: 0x00190248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182529, XrefRangeEnd = 182536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x00192098 File Offset: 0x00190298
		// (set) Token: 0x060055F3 RID: 22003 RVA: 0x001920D4 File Offset: 0x001902D4
		public unsafe int SyncAccessor_Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 182544, RefRangeEnd = 182546, XrefRangeStart = 182536, XrefRangeEnd = 182544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00192120 File Offset: 0x00190320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182546, XrefRangeEnd = 182559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x00192194 File Offset: 0x00190394
		// (set) Token: 0x060055F6 RID: 22006 RVA: 0x001921D4 File Offset: 0x001903D4
		public unsafe List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 182568, RefRangeEnd = 182569, XrefRangeStart = 182559, XrefRangeEnd = 182568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00192224 File Offset: 0x00190424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182569, XrefRangeEnd = 182575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00029131 File Offset: 0x00027331
		public ProceduralGridItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x060055F9 RID: 22009 RVA: 0x00192260 File Offset: 0x00190460
		// (set) Token: 0x060055FA RID: 22010 RVA: 0x0002913A File Offset: 0x0002733A
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x060055FB RID: 22011 RVA: 0x00192290 File Offset: 0x00190490
		// (set) Token: 0x060055FC RID: 22012 RVA: 0x00029159 File Offset: 0x00027359
		public unsafe ProceduralTile.EProceduralTileType ProceduralTileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType)) = value;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x001922B8 File Offset: 0x001904B8
		// (set) Token: 0x060055FE RID: 22014 RVA: 0x00029174 File Offset: 0x00027374
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x060055FF RID: 22015 RVA: 0x001922E0 File Offset: 0x001904E0
		// (set) Token: 0x06005600 RID: 22016 RVA: 0x0002918F File Offset: 0x0002738F
		public unsafe List<CoordinateProceduralTilePair> footprintTileMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06005601 RID: 22017 RVA: 0x00192310 File Offset: 0x00190510
		// (set) Token: 0x06005602 RID: 22018 RVA: 0x000291AE File Offset: 0x000273AE
		public unsafe SyncVar<int> syncVar___Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x00192340 File Offset: 0x00190540
		// (set) Token: 0x06005604 RID: 22020 RVA: 0x000291CD File Offset: 0x000273CD
		public unsafe SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<List<CoordinateProceduralTilePair>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06005605 RID: 22021 RVA: 0x00192370 File Offset: 0x00190570
		// (set) Token: 0x06005606 RID: 22022 RVA: 0x000291EC File Offset: 0x000273EC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06005607 RID: 22023 RVA: 0x00192398 File Offset: 0x00190598
		// (set) Token: 0x06005608 RID: 22024 RVA: 0x00029207 File Offset: 0x00027407
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A2A RID: 14890
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04003A2B RID: 14891
		private static readonly IntPtr NativeFieldInfoPtr_ProceduralTileType;

		// Token: 0x04003A2C RID: 14892
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04003A2D RID: 14893
		private static readonly IntPtr NativeFieldInfoPtr_footprintTileMatches;

		// Token: 0x04003A2E RID: 14894
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___Rotation;

		// Token: 0x04003A2F RID: 14895
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___footprintTileMatches;

		// Token: 0x04003A30 RID: 14896
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003A31 RID: 14897
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003A32 RID: 14898
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0;

		// Token: 0x04003A33 RID: 14899
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0;

		// Token: 0x04003A34 RID: 14900
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003A35 RID: 14901
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003A36 RID: 14902
		private static readonly IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003A37 RID: 14903
		private static readonly IntPtr NativeMethodInfoPtr_SendProceduralGridItemData_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A38 RID: 14904
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A39 RID: 14905
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A3A RID: 14906
		private static readonly IntPtr NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0;

		// Token: 0x04003A3B RID: 14907
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04003A3C RID: 14908
		private static readonly IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x04003A3D RID: 14909
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003A3E RID: 14910
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0;

		// Token: 0x04003A3F RID: 14911
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0;

		// Token: 0x04003A40 RID: 14912
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04003A41 RID: 14913
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04003A42 RID: 14914
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003A43 RID: 14915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A44 RID: 14916
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003A45 RID: 14917
		private static readonly IntPtr NativeMethodInfoPtr__OnStartClient_b__10_1_Private_Boolean_0;

		// Token: 0x04003A46 RID: 14918
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04003A47 RID: 14919
		private static readonly IntPtr NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0;

		// Token: 0x04003A48 RID: 14920
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A49 RID: 14921
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A4A RID: 14922
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A4B RID: 14923
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendProceduralGridItemData_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A4C RID: 14924
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendProceduralGridItemData_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A4D RID: 14925
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendProceduralGridItemData_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A4E RID: 14926
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A4F RID: 14927
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0;

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009C0 RID: 2496
		public class FootprintTileMatch : Il2CppSystem.Object
		{
			// Token: 0x0600CC3F RID: 52287 RVA: 0x00314398 File Offset: 0x00312598
			// Note: this type is marked as 'beforefieldinit'.
			static FootprintTileMatch()
			{
				Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "FootprintTileMatch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr);
				ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, "footprint");
				ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, "matchedTile");
				ProceduralGridItem.FootprintTileMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, 100674049);
			}

			// Token: 0x0600CC40 RID: 52288 RVA: 0x00314400 File Offset: 0x00312600
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FootprintTileMatch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.FootprintTileMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC41 RID: 52289 RVA: 0x00063579 File Offset: 0x00061779
			public FootprintTileMatch(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA1 RID: 16289
			// (get) Token: 0x0600CC42 RID: 52290 RVA: 0x0031443C File Offset: 0x0031263C
			// (set) Token: 0x0600CC43 RID: 52291 RVA: 0x00063582 File Offset: 0x00061782
			public unsafe FootprintTile footprint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA2 RID: 16290
			// (get) Token: 0x0600CC44 RID: 52292 RVA: 0x0031446C File Offset: 0x0031266C
			// (set) Token: 0x0600CC45 RID: 52293 RVA: 0x000635A1 File Offset: 0x000617A1
			public unsafe ProceduralTile matchedTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A16 RID: 35350
			private static readonly IntPtr NativeFieldInfoPtr_footprint;

			// Token: 0x04008A17 RID: 35351
			private static readonly IntPtr NativeFieldInfoPtr_matchedTile;

			// Token: 0x04008A18 RID: 35352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009C1 RID: 2497
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<<OnStartClient>g__WaitForDataSend|10_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC46 RID: 52294 RVA: 0x0031449C File Offset: 0x0031269C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<<OnStartClient>g__WaitForDataSend|10_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674050);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674051);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674052);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674053);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674054);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674055);
			}

			// Token: 0x0600CC47 RID: 52295 RVA: 0x0031457C File Offset: 0x0031277C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC48 RID: 52296 RVA: 0x003145C4 File Offset: 0x003127C4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC49 RID: 52297 RVA: 0x003145F8 File Offset: 0x003127F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182086, XrefRangeEnd = 182097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FA6 RID: 16294
			// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x00314634 File Offset: 0x00312834
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC4B RID: 52299 RVA: 0x00314674 File Offset: 0x00312874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182097, XrefRangeEnd = 182102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FA7 RID: 16295
			// (get) Token: 0x0600CC4C RID: 52300 RVA: 0x003146A8 File Offset: 0x003128A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC4D RID: 52301 RVA: 0x000635C0 File Offset: 0x000617C0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA3 RID: 16291
			// (get) Token: 0x0600CC4E RID: 52302 RVA: 0x003146E8 File Offset: 0x003128E8
			// (set) Token: 0x0600CC4F RID: 52303 RVA: 0x000635C9 File Offset: 0x000617C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FA4 RID: 16292
			// (get) Token: 0x0600CC50 RID: 52304 RVA: 0x00314710 File Offset: 0x00312910
			// (set) Token: 0x0600CC51 RID: 52305 RVA: 0x000635E4 File Offset: 0x000617E4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA5 RID: 16293
			// (get) Token: 0x0600CC52 RID: 52306 RVA: 0x00314740 File Offset: 0x00312940
			// (set) Token: 0x0600CC53 RID: 52307 RVA: 0x00063603 File Offset: 0x00061803
			public unsafe ProceduralGridItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A19 RID: 35353
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A1A RID: 35354
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A1B RID: 35355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A1C RID: 35356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A1D RID: 35357
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A1E RID: 35358
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A1F RID: 35359
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A20 RID: 35360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A21 RID: 35361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009C2 RID: 2498
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<<SetProceduralGridData>g__Routine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600CC54 RID: 52308 RVA: 0x00314770 File Offset: 0x00312970
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<<SetProceduralGridData>g__Routine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674056);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674057);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674058);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674059);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674060);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674061);
			}

			// Token: 0x0600CC55 RID: 52309 RVA: 0x00314850 File Offset: 0x00312A50
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC56 RID: 52310 RVA: 0x00314898 File Offset: 0x00312A98
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC57 RID: 52311 RVA: 0x003148CC File Offset: 0x00312ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182102, XrefRangeEnd = 182114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FAB RID: 16299
			// (get) Token: 0x0600CC58 RID: 52312 RVA: 0x00314908 File Offset: 0x00312B08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC59 RID: 52313 RVA: 0x00314948 File Offset: 0x00312B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182114, XrefRangeEnd = 182119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FAC RID: 16300
			// (get) Token: 0x0600CC5A RID: 52314 RVA: 0x0031497C File Offset: 0x00312B7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC5B RID: 52315 RVA: 0x00063622 File Offset: 0x00061822
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA8 RID: 16296
			// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x003149BC File Offset: 0x00312BBC
			// (set) Token: 0x0600CC5D RID: 52317 RVA: 0x0006362B File Offset: 0x0006182B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FA9 RID: 16297
			// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x003149E4 File Offset: 0x00312BE4
			// (set) Token: 0x0600CC5F RID: 52319 RVA: 0x00063646 File Offset: 0x00061846
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAA RID: 16298
			// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x00314A14 File Offset: 0x00312C14
			// (set) Token: 0x0600CC61 RID: 52321 RVA: 0x00063665 File Offset: 0x00061865
			public unsafe ProceduralGridItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A22 RID: 35362
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A23 RID: 35363
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A24 RID: 35364
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A25 RID: 35365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A26 RID: 35366
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A27 RID: 35367
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A28 RID: 35368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A29 RID: 35369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A2A RID: 35370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009C3 RID: 2499
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CC62 RID: 52322 RVA: 0x00314A44 File Offset: 0x00312C44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr);
				ProceduralGridItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9");
				ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9__4_0");
				ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9__6_0");
				ProceduralGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100674063);
				ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100674064);
				ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100674065);
			}

			// Token: 0x0600CC63 RID: 52323 RVA: 0x00314AE8 File Offset: 0x00312CE8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC64 RID: 52324 RVA: 0x00314B24 File Offset: 0x00312D24
			[CallerCount(0)]
			public unsafe int _get_FootprintXSize_b__4_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC65 RID: 52325 RVA: 0x00314B78 File Offset: 0x00312D78
			[CallerCount(0)]
			public unsafe int _get_FootprintYSize_b__6_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC66 RID: 52326 RVA: 0x00063684 File Offset: 0x00061884
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FAD RID: 16301
			// (get) Token: 0x0600CC67 RID: 52327 RVA: 0x00314BCC File Offset: 0x00312DCC
			// (set) Token: 0x0600CC68 RID: 52328 RVA: 0x0006368D File Offset: 0x0006188D
			public unsafe static ProceduralGridItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAE RID: 16302
			// (get) Token: 0x0600CC69 RID: 52329 RVA: 0x00314BF4 File Offset: 0x00312DF4
			// (set) Token: 0x0600CC6A RID: 52330 RVA: 0x0006369F File Offset: 0x0006189F
			public unsafe static Func<CoordinateFootprintTilePair, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAF RID: 16303
			// (get) Token: 0x0600CC6B RID: 52331 RVA: 0x00314C1C File Offset: 0x00312E1C
			// (set) Token: 0x0600CC6C RID: 52332 RVA: 0x000636B1 File Offset: 0x000618B1
			public unsafe static Func<CoordinateFootprintTilePair, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A2B RID: 35371
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A2C RID: 35372
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04008A2D RID: 35373
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04008A2E RID: 35374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A2F RID: 35375
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0;

			// Token: 0x04008A30 RID: 35376
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0;
		}
	}
}
