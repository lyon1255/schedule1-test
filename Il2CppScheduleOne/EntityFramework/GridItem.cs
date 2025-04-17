using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x020003FD RID: 1021
	public class GridItem : BuildableItem
	{
		// Token: 0x06005570 RID: 21872 RVA: 0x0018F648 File Offset: 0x0018D848
		// Note: this type is marked as 'beforefieldinit'.
		static GridItem()
		{
			Il2CppClassPointerStore<GridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "GridItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem>.NativeClassPtr);
			GridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			GridItem.NativeFieldInfoPtr_GridType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "GridType");
			GridItem.NativeFieldInfoPtr__OwnerGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<OwnerGrid>k__BackingField");
			GridItem.NativeFieldInfoPtr_OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "OwnerGridGUID");
			GridItem.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "OriginCoordinate");
			GridItem.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "Rotation");
			GridItem.NativeFieldInfoPtr_CoordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "CoordinatePairs");
			GridItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted");
			GridItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted");
			GridItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673930);
			GridItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673931);
			GridItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673932);
			GridItem.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673933);
			GridItem.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673934);
			GridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673935);
			GridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673936);
			GridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673937);
			GridItem.NativeMethodInfoPtr_SendGridItemData_Public_Void_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673938);
			GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673939);
			GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673940);
			GridItem.NativeMethodInfoPtr_SetGridData_Protected_Void_Guid_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673941);
			GridItem.NativeMethodInfoPtr_ValidateRotation_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673942);
			GridItem.NativeMethodInfoPtr_ProcessGridData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673943);
			GridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673944);
			GridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673945);
			GridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673946);
			GridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673947);
			GridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673948);
			GridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673949);
			GridItem.NativeMethodInfoPtr_GetParentTileAtFootprintCoordinate_Public_Tile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673950);
			GridItem.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_New_Boolean_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673951);
			GridItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673952);
			GridItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673953);
			GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673954);
			GridItem.NativeMethodInfoPtr__OnStartClient_b__18_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673955);
			GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673956);
			GridItem.NativeMethodInfoPtr__ProcessGridData_b__25_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673957);
			GridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673958);
			GridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673959);
			GridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673960);
			GridItem.NativeMethodInfoPtr_RpcWriter___Server_SendGridItemData_2821640832_Private_Void_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673961);
			GridItem.NativeMethodInfoPtr_RpcLogic___SendGridItemData_2821640832_Public_Void_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673962);
			GridItem.NativeMethodInfoPtr_RpcReader___Server_SendGridItemData_2821640832_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673963);
			GridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673964);
			GridItem.NativeMethodInfoPtr_RpcLogic___InitializeGridItem_1883577149_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673965);
			GridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673966);
			GridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673967);
			GridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673968);
			GridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100673969);
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x0018FA4C File Offset: 0x0018DC4C
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 181282, RefRangeEnd = 181286, XrefRangeStart = 181279, XrefRangeEnd = 181282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06005572 RID: 21874 RVA: 0x0018FA8C File Offset: 0x0018DC8C
		public unsafe int FootprintX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181286, XrefRangeEnd = 181307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x0018FAC8 File Offset: 0x0018DCC8
		public unsafe int FootprintY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181307, XrefRangeEnd = 181328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06005574 RID: 21876 RVA: 0x0018FB04 File Offset: 0x0018DD04
		// (set) Token: 0x06005575 RID: 21877 RVA: 0x0018FB44 File Offset: 0x0018DD44
		public unsafe Grid OwnerGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x0018FB88 File Offset: 0x0018DD88
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 181341, RefRangeEnd = 181360, XrefRangeStart = 181328, XrefRangeEnd = 181341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x0018FBC4 File Offset: 0x0018DDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181360, XrefRangeEnd = 181367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x0018FC00 File Offset: 0x0018DE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181367, XrefRangeEnd = 181369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0018FC50 File Offset: 0x0018DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181369, XrefRangeEnd = 181394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendGridItemData(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_SendGridItemData_Public_Void_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x0018FCD4 File Offset: 0x0018DED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181394, XrefRangeEnd = 181448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeGridItem(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x0018FD74 File Offset: 0x0018DF74
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 181465, RefRangeEnd = 181475, XrefRangeStart = 181448, XrefRangeEnd = 181465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x0018FE04 File Offset: 0x0018E004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181475, XrefRangeEnd = 181495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGridData(Guid gridGUID, Vector2 originCoordinate, int rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_SetGridData_Protected_Void_Guid_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x0018FE60 File Offset: 0x0018E060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181510, RefRangeEnd = 181512, XrefRangeStart = 181495, XrefRangeEnd = 181510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ValidateRotation(int rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_ValidateRotation_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0018FEAC File Offset: 0x0018E0AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181602, RefRangeEnd = 181604, XrefRangeStart = 181512, XrefRangeEnd = 181602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessGridData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_ProcessGridData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0018FEE0 File Offset: 0x0018E0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181604, XrefRangeEnd = 181631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x0018FF14 File Offset: 0x0018E114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181647, RefRangeEnd = 181648, XrefRangeStart = 181631, XrefRangeEnd = 181647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0018FF48 File Offset: 0x0018E148
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 181650, RefRangeEnd = 181660, XrefRangeStart = 181648, XrefRangeEnd = 181650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x0018FF94 File Offset: 0x0018E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181660, XrefRangeEnd = 181665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x0018FFD0 File Offset: 0x0018E1D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181671, RefRangeEnd = 181674, XrefRangeStart = 181665, XrefRangeEnd = 181671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00190010 File Offset: 0x0018E210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181681, RefRangeEnd = 181683, XrefRangeStart = 181674, XrefRangeEnd = 181681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00190060 File Offset: 0x0018E260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181683, XrefRangeEnd = 181699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetParentTileAtFootprintCoordinate(Coordinate footprintCoord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprintCoord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_GetParentTileAtFootprintCoordinate_Public_Tile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x001900B0 File Offset: 0x0018E2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181699, XrefRangeEnd = 181706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanShareTileWith(List<GridItem> obstacles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_New_Boolean_List_1_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00190108 File Offset: 0x0018E308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181706, XrefRangeEnd = 181711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0019014C File Offset: 0x0018E34C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 181726, RefRangeEnd = 181744, XrefRangeStart = 181711, XrefRangeEnd = 181726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00190188 File Offset: 0x0018E388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181744, XrefRangeEnd = 181749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x001901C8 File Offset: 0x0018E3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181749, XrefRangeEnd = 181751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnStartClient_b__18_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr__OnStartClient_b__18_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00190204 File Offset: 0x0018E404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181751, XrefRangeEnd = 181756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00190244 File Offset: 0x0018E444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ProcessGridData_b__25_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr__ProcessGridData_b__25_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00190280 File Offset: 0x0018E480
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 181777, RefRangeEnd = 181794, XrefRangeStart = 181756, XrefRangeEnd = 181777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x001902BC File Offset: 0x0018E4BC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 181794, RefRangeEnd = 181812, XrefRangeStart = 181794, XrefRangeEnd = 181794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x001902F8 File Offset: 0x0018E4F8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00190334 File Offset: 0x0018E534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181812, XrefRangeEnd = 181837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcWriter___Server_SendGridItemData_2821640832_Private_Void_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x001903B8 File Offset: 0x0018E5B8
		[CallerCount(0)]
		public unsafe void RpcLogic___SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcLogic___SendGridItemData_2821640832_Public_Void_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x0019043C File Offset: 0x0018E63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181837, XrefRangeEnd = 181845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendGridItemData_2821640832(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcReader___Server_SendGridItemData_2821640832_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x001904A0 File Offset: 0x0018E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181845, XrefRangeEnd = 181861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x00190538 File Offset: 0x0018E738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181868, RefRangeEnd = 181871, XrefRangeStart = 181861, XrefRangeEnd = 181868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_RpcLogic___InitializeGridItem_1883577149_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x001905D8 File Offset: 0x0018E7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181871, XrefRangeEnd = 181881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00190628 File Offset: 0x0018E828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181881, XrefRangeEnd = 181906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x001906C0 File Offset: 0x0018E8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181906, XrefRangeEnd = 181916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x00190710 File Offset: 0x0018E910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181916, XrefRangeEnd = 181928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x00028F59 File Offset: 0x00027159
		public GridItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600559A RID: 21914 RVA: 0x0019074C File Offset: 0x0018E94C
		// (set) Token: 0x0600559B RID: 21915 RVA: 0x00028F62 File Offset: 0x00027162
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x0600559C RID: 21916 RVA: 0x0019077C File Offset: 0x0018E97C
		// (set) Token: 0x0600559D RID: 21917 RVA: 0x00028F81 File Offset: 0x00027181
		public unsafe GridItem.EGridType GridType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_GridType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_GridType)) = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600559E RID: 21918 RVA: 0x001907A4 File Offset: 0x0018E9A4
		// (set) Token: 0x0600559F RID: 21919 RVA: 0x00028F9C File Offset: 0x0002719C
		public unsafe Grid _OwnerGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr__OwnerGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr__OwnerGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060055A0 RID: 21920 RVA: 0x001907D4 File Offset: 0x0018E9D4
		// (set) Token: 0x060055A1 RID: 21921 RVA: 0x00028FBB File Offset: 0x000271BB
		public unsafe Guid OwnerGridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OwnerGridGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OwnerGridGUID)) = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060055A2 RID: 21922 RVA: 0x001907FC File Offset: 0x0018E9FC
		// (set) Token: 0x060055A3 RID: 21923 RVA: 0x00028FD6 File Offset: 0x000271D6
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060055A4 RID: 21924 RVA: 0x00190824 File Offset: 0x0018EA24
		// (set) Token: 0x060055A5 RID: 21925 RVA: 0x00028FF1 File Offset: 0x000271F1
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x060055A6 RID: 21926 RVA: 0x0019084C File Offset: 0x0018EA4C
		// (set) Token: 0x060055A7 RID: 21927 RVA: 0x0002900C File Offset: 0x0002720C
		public unsafe List<CoordinatePair> CoordinatePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinatePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x060055A8 RID: 21928 RVA: 0x0019087C File Offset: 0x0018EA7C
		// (set) Token: 0x060055A9 RID: 21929 RVA: 0x0002902B File Offset: 0x0002722B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x001908A4 File Offset: 0x0018EAA4
		// (set) Token: 0x060055AB RID: 21931 RVA: 0x00029046 File Offset: 0x00027246
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040039DE RID: 14814
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x040039DF RID: 14815
		private static readonly IntPtr NativeFieldInfoPtr_GridType;

		// Token: 0x040039E0 RID: 14816
		private static readonly IntPtr NativeFieldInfoPtr__OwnerGrid_k__BackingField;

		// Token: 0x040039E1 RID: 14817
		private static readonly IntPtr NativeFieldInfoPtr_OwnerGridGUID;

		// Token: 0x040039E2 RID: 14818
		private static readonly IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x040039E3 RID: 14819
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x040039E4 RID: 14820
		private static readonly IntPtr NativeFieldInfoPtr_CoordinatePairs;

		// Token: 0x040039E5 RID: 14821
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040039E6 RID: 14822
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040039E7 RID: 14823
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x040039E8 RID: 14824
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x040039E9 RID: 14825
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x040039EA RID: 14826
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0;

		// Token: 0x040039EB RID: 14827
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0;

		// Token: 0x040039EC RID: 14828
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040039ED RID: 14829
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040039EE RID: 14830
		private static readonly IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x040039EF RID: 14831
		private static readonly IntPtr NativeMethodInfoPtr_SendGridItemData_Public_Void_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x040039F0 RID: 14832
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x040039F1 RID: 14833
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x040039F2 RID: 14834
		private static readonly IntPtr NativeMethodInfoPtr_SetGridData_Protected_Void_Guid_Vector2_Int32_0;

		// Token: 0x040039F3 RID: 14835
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRotation_Private_Int32_Int32_0;

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeMethodInfoPtr_ProcessGridData_Private_Void_0;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTileAtFootprintCoordinate_Public_Tile_Coordinate_0;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_New_Boolean_List_1_GridItem_0;

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeMethodInfoPtr__OnStartClient_b__18_1_Private_Boolean_0;

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeMethodInfoPtr__ProcessGridData_b__25_1_Private_Boolean_0;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendGridItemData_2821640832_Private_Void_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendGridItemData_2821640832_Public_Void_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendGridItemData_2821640832_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A09 RID: 14857
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003A0A RID: 14858
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitializeGridItem_1883577149_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003A0B RID: 14859
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A0C RID: 14860
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003A0D RID: 14861
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A0E RID: 14862
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009BB RID: 2491
		[OriginalName("Assembly-CSharp.dll", "", "EGridType")]
		public enum EGridType
		{
			// Token: 0x040089F8 RID: 35320
			All,
			// Token: 0x040089F9 RID: 35321
			IndoorOnly,
			// Token: 0x040089FA RID: 35322
			OutdoorOnly
		}

		// Token: 0x020009BC RID: 2492
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<<OnStartClient>g__WaitForDataSend|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC12 RID: 52242 RVA: 0x00313ACC File Offset: 0x00311CCC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<<OnStartClient>g__WaitForDataSend|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100673970);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100673971);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100673972);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100673973);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100673974);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100673975);
			}

			// Token: 0x0600CC13 RID: 52243 RVA: 0x00313BAC File Offset: 0x00311DAC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC14 RID: 52244 RVA: 0x00313BF4 File Offset: 0x00311DF4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC15 RID: 52245 RVA: 0x00313C28 File Offset: 0x00311E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181247, XrefRangeEnd = 181258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F96 RID: 16278
			// (get) Token: 0x0600CC16 RID: 52246 RVA: 0x00313C64 File Offset: 0x00311E64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC17 RID: 52247 RVA: 0x00313CA4 File Offset: 0x00311EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181258, XrefRangeEnd = 181263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F97 RID: 16279
			// (get) Token: 0x0600CC18 RID: 52248 RVA: 0x00313CD8 File Offset: 0x00311ED8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC19 RID: 52249 RVA: 0x0006344E File Offset: 0x0006164E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F93 RID: 16275
			// (get) Token: 0x0600CC1A RID: 52250 RVA: 0x00313D18 File Offset: 0x00311F18
			// (set) Token: 0x0600CC1B RID: 52251 RVA: 0x00063457 File Offset: 0x00061657
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F94 RID: 16276
			// (get) Token: 0x0600CC1C RID: 52252 RVA: 0x00313D40 File Offset: 0x00311F40
			// (set) Token: 0x0600CC1D RID: 52253 RVA: 0x00063472 File Offset: 0x00061672
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F95 RID: 16277
			// (get) Token: 0x0600CC1E RID: 52254 RVA: 0x00313D70 File Offset: 0x00311F70
			// (set) Token: 0x0600CC1F RID: 52255 RVA: 0x00063491 File Offset: 0x00061691
			public unsafe GridItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089FB RID: 35323
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089FC RID: 35324
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089FD RID: 35325
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089FE RID: 35326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089FF RID: 35327
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A00 RID: 35328
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A01 RID: 35329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A02 RID: 35330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A03 RID: 35331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009BD RID: 2493
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<<ProcessGridData>g__Routine|25_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600CC20 RID: 52256 RVA: 0x00313DA0 File Offset: 0x00311FA0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<<ProcessGridData>g__Routine|25_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100673976);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100673977);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100673978);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100673979);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100673980);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100673981);
			}

			// Token: 0x0600CC21 RID: 52257 RVA: 0x00313E80 File Offset: 0x00312080
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC22 RID: 52258 RVA: 0x00313EC8 File Offset: 0x003120C8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC23 RID: 52259 RVA: 0x00313EFC File Offset: 0x003120FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181263, XrefRangeEnd = 181274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F9B RID: 16283
			// (get) Token: 0x0600CC24 RID: 52260 RVA: 0x00313F38 File Offset: 0x00312138
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC25 RID: 52261 RVA: 0x00313F78 File Offset: 0x00312178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181274, XrefRangeEnd = 181279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F9C RID: 16284
			// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x00313FAC File Offset: 0x003121AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC27 RID: 52263 RVA: 0x000634B0 File Offset: 0x000616B0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F98 RID: 16280
			// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x00313FEC File Offset: 0x003121EC
			// (set) Token: 0x0600CC29 RID: 52265 RVA: 0x000634B9 File Offset: 0x000616B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F99 RID: 16281
			// (get) Token: 0x0600CC2A RID: 52266 RVA: 0x00314014 File Offset: 0x00312214
			// (set) Token: 0x0600CC2B RID: 52267 RVA: 0x000634D4 File Offset: 0x000616D4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9A RID: 16282
			// (get) Token: 0x0600CC2C RID: 52268 RVA: 0x00314044 File Offset: 0x00312244
			// (set) Token: 0x0600CC2D RID: 52269 RVA: 0x000634F3 File Offset: 0x000616F3
			public unsafe GridItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A04 RID: 35332
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A05 RID: 35333
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A06 RID: 35334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A07 RID: 35335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A08 RID: 35336
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A09 RID: 35337
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A0A RID: 35338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A0B RID: 35339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A0C RID: 35340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009BE RID: 2494
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CC2E RID: 52270 RVA: 0x00314074 File Offset: 0x00312274
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr);
				GridItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, "<>9");
				GridItem.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, "<>9__5_0");
				GridItem.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, "<>9__7_0");
				GridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, 100673983);
				GridItem.__c.NativeMethodInfoPtr__get_FootprintX_b__5_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, 100673984);
				GridItem.__c.NativeMethodInfoPtr__get_FootprintY_b__7_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, 100673985);
			}

			// Token: 0x0600CC2F RID: 52271 RVA: 0x00314118 File Offset: 0x00312318
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC30 RID: 52272 RVA: 0x00314154 File Offset: 0x00312354
			[CallerCount(0)]
			public unsafe int _get_FootprintX_b__5_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c.NativeMethodInfoPtr__get_FootprintX_b__5_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC31 RID: 52273 RVA: 0x003141A8 File Offset: 0x003123A8
			[CallerCount(0)]
			public unsafe int _get_FootprintY_b__7_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c.NativeMethodInfoPtr__get_FootprintY_b__7_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC32 RID: 52274 RVA: 0x00063512 File Offset: 0x00061712
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F9D RID: 16285
			// (get) Token: 0x0600CC33 RID: 52275 RVA: 0x003141FC File Offset: 0x003123FC
			// (set) Token: 0x0600CC34 RID: 52276 RVA: 0x0006351B File Offset: 0x0006171B
			public unsafe static GridItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GridItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GridItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9E RID: 16286
			// (get) Token: 0x0600CC35 RID: 52277 RVA: 0x00314224 File Offset: 0x00312424
			// (set) Token: 0x0600CC36 RID: 52278 RVA: 0x0006352D File Offset: 0x0006172D
			public unsafe static Func<CoordinateFootprintTilePair, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GridItem.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GridItem.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9F RID: 16287
			// (get) Token: 0x0600CC37 RID: 52279 RVA: 0x0031424C File Offset: 0x0031244C
			// (set) Token: 0x0600CC38 RID: 52280 RVA: 0x0006353F File Offset: 0x0006173F
			public unsafe static Func<CoordinateFootprintTilePair, int> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GridItem.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GridItem.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A0D RID: 35341
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A0E RID: 35342
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04008A0F RID: 35343
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04008A10 RID: 35344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A11 RID: 35345
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintX_b__5_0_Internal_Int32_CoordinateFootprintTilePair_0;

			// Token: 0x04008A12 RID: 35346
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintY_b__7_0_Internal_Int32_CoordinateFootprintTilePair_0;
		}

		// Token: 0x020009BF RID: 2495
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC39 RID: 52281 RVA: 0x00314274 File Offset: 0x00312474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr);
				GridItem.__c__DisplayClass32_0.NativeFieldInfoPtr_footprintCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr, "footprintCoord");
				GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr, 100673986);
				GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__GetParentTileAtFootprintCoordinate_b__0_Internal_Boolean_CoordinatePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr, 100673987);
			}

			// Token: 0x0600CC3A RID: 52282 RVA: 0x003142DC File Offset: 0x003124DC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC3B RID: 52283 RVA: 0x00314318 File Offset: 0x00312518
			[CallerCount(0)]
			public unsafe bool _GetParentTileAtFootprintCoordinate_b__0(CoordinatePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__GetParentTileAtFootprintCoordinate_b__0_Internal_Boolean_CoordinatePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC3C RID: 52284 RVA: 0x00063551 File Offset: 0x00061751
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA0 RID: 16288
			// (get) Token: 0x0600CC3D RID: 52285 RVA: 0x00314368 File Offset: 0x00312568
			// (set) Token: 0x0600CC3E RID: 52286 RVA: 0x0006355A File Offset: 0x0006175A
			public unsafe Coordinate footprintCoord
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.__c__DisplayClass32_0.NativeFieldInfoPtr_footprintCoord);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.__c__DisplayClass32_0.NativeFieldInfoPtr_footprintCoord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A13 RID: 35347
			private static readonly IntPtr NativeFieldInfoPtr_footprintCoord;

			// Token: 0x04008A14 RID: 35348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A15 RID: 35349
			private static readonly IntPtr NativeMethodInfoPtr__GetParentTileAtFootprintCoordinate_b__0_Internal_Boolean_CoordinatePair_0;
		}
	}
}
