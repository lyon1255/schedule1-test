using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057E RID: 1406
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x06007BA7 RID: 31655 RVA: 0x002142EC File Offset: 0x002124EC
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem()
		{
			Il2CppClassPointerStore<StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem>.NativeClassPtr);
			StoredItem.NativeFieldInfoPtr__item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<item>k__BackingField");
			StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<Destroyed>k__BackingField");
			StoredItem.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "buildPoint");
			StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			StoredItem.NativeFieldInfoPtr_footprintX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintX");
			StoredItem.NativeFieldInfoPtr_footprintY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintY");
			StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentStorageEntity>k__BackingField");
			StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentGrid>k__BackingField");
			StoredItem.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "intObj");
			StoredItem.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "coordinatePairs");
			StoredItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "rotation");
			StoredItem.NativeFieldInfoPtr_xSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "xSize");
			StoredItem.NativeFieldInfoPtr_ySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "ySize");
			StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<canBePickedUp>k__BackingField");
			StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<noPickupReason>k__BackingField");
			StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678795);
			StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678796);
			StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678797);
			StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678798);
			StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678799);
			StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678800);
			StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678801);
			StoredItem.NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678802);
			StoredItem.NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678803);
			StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678804);
			StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678805);
			StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678806);
			StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678807);
			StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678808);
			StoredItem.NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678809);
			StoredItem.NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678810);
			StoredItem.NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678811);
			StoredItem.NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678812);
			StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678813);
			StoredItem.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678814);
			StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678815);
			StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678816);
			StoredItem.NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678817);
			StoredItem.NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678818);
			StoredItem.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678819);
			StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678820);
			StoredItem.NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678821);
			StoredItem.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678822);
			StoredItem.NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678823);
			StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678824);
			StoredItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678825);
			StoredItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678826);
			StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678827);
			StoredItem.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678828);
			StoredItem.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678829);
			StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678830);
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x00214718 File Offset: 0x00212918
		// (set) Token: 0x06007BA9 RID: 31657 RVA: 0x00214758 File Offset: 0x00212958
		public unsafe StorableItemInstance item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x0021479C File Offset: 0x0021299C
		// (set) Token: 0x06007BAB RID: 31659 RVA: 0x002147D8 File Offset: 0x002129D8
		public unsafe bool Destroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x00214818 File Offset: 0x00212A18
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 236605, RefRangeEnd = 236608, XrefRangeStart = 236602, XrefRangeEnd = 236605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x00214858 File Offset: 0x00212A58
		public unsafe int FootprintX
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 236629, RefRangeEnd = 236633, XrefRangeStart = 236608, XrefRangeEnd = 236629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06007BAE RID: 31662 RVA: 0x00214894 File Offset: 0x00212A94
		public unsafe int FootprintY
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 236654, RefRangeEnd = 236658, XrefRangeStart = 236633, XrefRangeEnd = 236654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x002148D0 File Offset: 0x00212AD0
		// (set) Token: 0x06007BB0 RID: 31664 RVA: 0x00214910 File Offset: 0x00212B10
		public unsafe IStorageEntity parentStorageEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x06007BB1 RID: 31665 RVA: 0x00214954 File Offset: 0x00212B54
		// (set) Token: 0x06007BB2 RID: 31666 RVA: 0x00214994 File Offset: 0x00212B94
		public unsafe StorageGrid parentGrid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x002149D8 File Offset: 0x00212BD8
		public unsafe List<CoordinatePair> CoordinatePairs
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47268, RefRangeEnd = 47308, XrefRangeStart = 47268, XrefRangeEnd = 47308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr3) : null;
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06007BB4 RID: 31668 RVA: 0x00214A18 File Offset: 0x00212C18
		public unsafe float Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x00214A54 File Offset: 0x00212C54
		public unsafe int totalArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236658, XrefRangeEnd = 236659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06007BB6 RID: 31670 RVA: 0x00214A90 File Offset: 0x00212C90
		// (set) Token: 0x06007BB7 RID: 31671 RVA: 0x00214ACC File Offset: 0x00212CCC
		public unsafe bool canBePickedUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x00214B0C File Offset: 0x00212D0C
		// (set) Token: 0x06007BB9 RID: 31673 RVA: 0x00214B44 File Offset: 0x00212D44
		public unsafe string noPickupReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45797, RefRangeEnd = 45798, XrefRangeStart = 45797, XrefRangeEnd = 45798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x00214B88 File Offset: 0x00212D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236659, XrefRangeEnd = 236667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x00214BC4 File Offset: 0x00212DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236667, XrefRangeEnd = 236688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x00214C00 File Offset: 0x00212E00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 236745, RefRangeEnd = 236752, XrefRangeStart = 236688, XrefRangeEnd = 236745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00214C7C File Offset: 0x00212E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236785, RefRangeEnd = 236786, XrefRangeStart = 236752, XrefRangeEnd = 236785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x00214CB0 File Offset: 0x00212EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236786, XrefRangeEnd = 236809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeIntObj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x00214CEC File Offset: 0x00212EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236809, XrefRangeEnd = 236830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x00214D28 File Offset: 0x00212F28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236843, RefRangeEnd = 236846, XrefRangeStart = 236830, XrefRangeEnd = 236843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x00214D5C File Offset: 0x00212F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236863, RefRangeEnd = 236865, XrefRangeStart = 236846, XrefRangeEnd = 236863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFootprintOccupancy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x00214D90 File Offset: 0x00212F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236865, XrefRangeEnd = 236866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _canBePickedUp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_noPickupReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x00214DE0 File Offset: 0x00212FE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236877, RefRangeEnd = 236879, XrefRangeStart = 236866, XrefRangeEnd = 236877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x00214E24 File Offset: 0x00213024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236879, XrefRangeEnd = 236897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<StoredItem> RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allowedReservant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x00214E7C File Offset: 0x0021307C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236904, RefRangeEnd = 236905, XrefRangeStart = 236897, XrefRangeEnd = 236904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x00214EEC File Offset: 0x002130EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236911, RefRangeEnd = 236914, XrefRangeStart = 236905, XrefRangeEnd = 236911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00214F2C File Offset: 0x0021312C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 236919, RefRangeEnd = 236925, XrefRangeStart = 236914, XrefRangeEnd = 236919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00214F60 File Offset: 0x00213160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236925, XrefRangeEnd = 236932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00214FB0 File Offset: 0x002131B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236932, XrefRangeEnd = 236941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00214FEC File Offset: 0x002131EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236941, XrefRangeEnd = 236947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x00215028 File Offset: 0x00213228
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 236965, RefRangeEnd = 236973, XrefRangeStart = 236947, XrefRangeEnd = 236965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x0003AB07 File Offset: 0x00038D07
		public StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x00215064 File Offset: 0x00213264
		// (set) Token: 0x06007BCE RID: 31694 RVA: 0x0003AB10 File Offset: 0x00038D10
		public unsafe StorableItemInstance _item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x06007BCF RID: 31695 RVA: 0x00215094 File Offset: 0x00213294
		// (set) Token: 0x06007BD0 RID: 31696 RVA: 0x0003AB2F File Offset: 0x00038D2F
		public unsafe bool _Destroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x002150BC File Offset: 0x002132BC
		// (set) Token: 0x06007BD2 RID: 31698 RVA: 0x0003AB4A File Offset: 0x00038D4A
		public unsafe Transform buildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x06007BD3 RID: 31699 RVA: 0x002150EC File Offset: 0x002132EC
		// (set) Token: 0x06007BD4 RID: 31700 RVA: 0x0003AB69 File Offset: 0x00038D69
		public unsafe List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06007BD5 RID: 31701 RVA: 0x0021511C File Offset: 0x0021331C
		// (set) Token: 0x06007BD6 RID: 31702 RVA: 0x0003AB88 File Offset: 0x00038D88
		public unsafe int footprintX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX)) = value;
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x00215144 File Offset: 0x00213344
		// (set) Token: 0x06007BD8 RID: 31704 RVA: 0x0003ABA3 File Offset: 0x00038DA3
		public unsafe int footprintY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY)) = value;
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x0021516C File Offset: 0x0021336C
		// (set) Token: 0x06007BDA RID: 31706 RVA: 0x0003ABBE File Offset: 0x00038DBE
		public unsafe IStorageEntity _parentStorageEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x0021519C File Offset: 0x0021339C
		// (set) Token: 0x06007BDC RID: 31708 RVA: 0x0003ABDD File Offset: 0x00038DDD
		public unsafe StorageGrid _parentGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06007BDD RID: 31709 RVA: 0x002151CC File Offset: 0x002133CC
		// (set) Token: 0x06007BDE RID: 31710 RVA: 0x0003ABFC File Offset: 0x00038DFC
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06007BDF RID: 31711 RVA: 0x002151FC File Offset: 0x002133FC
		// (set) Token: 0x06007BE0 RID: 31712 RVA: 0x0003AC1B File Offset: 0x00038E1B
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x0021522C File Offset: 0x0021342C
		// (set) Token: 0x06007BE2 RID: 31714 RVA: 0x0003AC3A File Offset: 0x00038E3A
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x06007BE3 RID: 31715 RVA: 0x00215254 File Offset: 0x00213454
		// (set) Token: 0x06007BE4 RID: 31716 RVA: 0x0003AC55 File Offset: 0x00038E55
		public unsafe int xSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize)) = value;
			}
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x0021527C File Offset: 0x0021347C
		// (set) Token: 0x06007BE6 RID: 31718 RVA: 0x0003AC70 File Offset: 0x00038E70
		public unsafe int ySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize)) = value;
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x002152A4 File Offset: 0x002134A4
		// (set) Token: 0x06007BE8 RID: 31720 RVA: 0x0003AC8B File Offset: 0x00038E8B
		public unsafe bool _canBePickedUp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField)) = value;
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x06007BE9 RID: 31721 RVA: 0x002152CC File Offset: 0x002134CC
		// (set) Token: 0x06007BEA RID: 31722 RVA: 0x0003ACA6 File Offset: 0x00038EA6
		public unsafe string _noPickupReason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005431 RID: 21553
		private static readonly IntPtr NativeFieldInfoPtr__item_k__BackingField;

		// Token: 0x04005432 RID: 21554
		private static readonly IntPtr NativeFieldInfoPtr__Destroyed_k__BackingField;

		// Token: 0x04005433 RID: 21555
		private static readonly IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x04005434 RID: 21556
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04005435 RID: 21557
		private static readonly IntPtr NativeFieldInfoPtr_footprintX;

		// Token: 0x04005436 RID: 21558
		private static readonly IntPtr NativeFieldInfoPtr_footprintY;

		// Token: 0x04005437 RID: 21559
		private static readonly IntPtr NativeFieldInfoPtr__parentStorageEntity_k__BackingField;

		// Token: 0x04005438 RID: 21560
		private static readonly IntPtr NativeFieldInfoPtr__parentGrid_k__BackingField;

		// Token: 0x04005439 RID: 21561
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x0400543A RID: 21562
		private static readonly IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x0400543B RID: 21563
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400543C RID: 21564
		private static readonly IntPtr NativeFieldInfoPtr_xSize;

		// Token: 0x0400543D RID: 21565
		private static readonly IntPtr NativeFieldInfoPtr_ySize;

		// Token: 0x0400543E RID: 21566
		private static readonly IntPtr NativeFieldInfoPtr__canBePickedUp_k__BackingField;

		// Token: 0x0400543F RID: 21567
		private static readonly IntPtr NativeFieldInfoPtr__noPickupReason_k__BackingField;

		// Token: 0x04005440 RID: 21568
		private static readonly IntPtr NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0;

		// Token: 0x04005441 RID: 21569
		private static readonly IntPtr NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0;

		// Token: 0x04005442 RID: 21570
		private static readonly IntPtr NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0;

		// Token: 0x04005443 RID: 21571
		private static readonly IntPtr NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0;

		// Token: 0x04005444 RID: 21572
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x04005445 RID: 21573
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x04005446 RID: 21574
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x04005447 RID: 21575
		private static readonly IntPtr NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0;

		// Token: 0x04005448 RID: 21576
		private static readonly IntPtr NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0;

		// Token: 0x04005449 RID: 21577
		private static readonly IntPtr NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0;

		// Token: 0x0400544A RID: 21578
		private static readonly IntPtr NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0;

		// Token: 0x0400544B RID: 21579
		private static readonly IntPtr NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0;

		// Token: 0x0400544C RID: 21580
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;

		// Token: 0x0400544D RID: 21581
		private static readonly IntPtr NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0;

		// Token: 0x0400544E RID: 21582
		private static readonly IntPtr NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0;

		// Token: 0x0400544F RID: 21583
		private static readonly IntPtr NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0;

		// Token: 0x04005450 RID: 21584
		private static readonly IntPtr NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0;

		// Token: 0x04005451 RID: 21585
		private static readonly IntPtr NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0;

		// Token: 0x04005452 RID: 21586
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005453 RID: 21587
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04005454 RID: 21588
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x04005455 RID: 21589
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04005456 RID: 21590
		private static readonly IntPtr NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0;

		// Token: 0x04005457 RID: 21591
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0;

		// Token: 0x04005458 RID: 21592
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0;

		// Token: 0x04005459 RID: 21593
		private static readonly IntPtr NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0;

		// Token: 0x0400545A RID: 21594
		private static readonly IntPtr NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0;

		// Token: 0x0400545B RID: 21595
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;

		// Token: 0x0400545C RID: 21596
		private static readonly IntPtr NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0;

		// Token: 0x0400545D RID: 21597
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0;

		// Token: 0x0400545E RID: 21598
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x0400545F RID: 21599
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0;

		// Token: 0x04005460 RID: 21600
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04005461 RID: 21601
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04005462 RID: 21602
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04005463 RID: 21603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB2 RID: 2738
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D39A RID: 54170 RVA: 0x00328A00 File Offset: 0x00326C00
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr);
				StoredItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9");
				StoredItem.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__14_0");
				StoredItem.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__17_0");
				StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678832);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678833);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678834);
			}

			// Token: 0x0600D39B RID: 54171 RVA: 0x00328AA4 File Offset: 0x00326CA4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D39C RID: 54172 RVA: 0x00328AE0 File Offset: 0x00326CE0
			[CallerCount(0)]
			public unsafe int _get_FootprintX_b__14_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D39D RID: 54173 RVA: 0x00328B34 File Offset: 0x00326D34
			[CallerCount(0)]
			public unsafe int _get_FootprintY_b__17_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D39E RID: 54174 RVA: 0x0006705F File Offset: 0x0006525F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A0 RID: 16800
			// (get) Token: 0x0600D39F RID: 54175 RVA: 0x00328B88 File Offset: 0x00326D88
			// (set) Token: 0x0600D3A0 RID: 54176 RVA: 0x00067068 File Offset: 0x00065268
			public unsafe static StoredItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A1 RID: 16801
			// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x00328BB0 File Offset: 0x00326DB0
			// (set) Token: 0x0600D3A2 RID: 54178 RVA: 0x0006707A File Offset: 0x0006527A
			public unsafe static Func<CoordinateStorageFootprintTilePair, int> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A2 RID: 16802
			// (get) Token: 0x0600D3A3 RID: 54179 RVA: 0x00328BD8 File Offset: 0x00326DD8
			// (set) Token: 0x0600D3A4 RID: 54180 RVA: 0x0006708C File Offset: 0x0006528C
			public unsafe static Func<CoordinateStorageFootprintTilePair, int> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E89 RID: 36489
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E8A RID: 36490
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04008E8B RID: 36491
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008E8C RID: 36492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E8D RID: 36493
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;

			// Token: 0x04008E8E RID: 36494
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;
		}

		// Token: 0x02000AB3 RID: 2739
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3A5 RID: 54181 RVA: 0x00328C00 File Offset: 0x00326E00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr);
				StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, "allowedReservant");
				StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, 100678835);
				StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, 100678836);
			}

			// Token: 0x0600D3A6 RID: 54182 RVA: 0x00328C68 File Offset: 0x00326E68
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A7 RID: 54183 RVA: 0x00328CA4 File Offset: 0x00326EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236595, XrefRangeEnd = 236602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveReservedItems_b__0(StoredItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3A8 RID: 54184 RVA: 0x0006709E File Offset: 0x0006529E
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A3 RID: 16803
			// (get) Token: 0x0600D3A9 RID: 54185 RVA: 0x00328CF4 File Offset: 0x00326EF4
			// (set) Token: 0x0600D3AA RID: 54186 RVA: 0x000670A7 File Offset: 0x000652A7
			public unsafe Employee allowedReservant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E8F RID: 36495
			private static readonly IntPtr NativeFieldInfoPtr_allowedReservant;

			// Token: 0x04008E90 RID: 36496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E91 RID: 36497
			private static readonly IntPtr NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0;
		}
	}
}
