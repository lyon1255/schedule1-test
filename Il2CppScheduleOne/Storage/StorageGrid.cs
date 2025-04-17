using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000578 RID: 1400
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x06007B30 RID: 31536 RVA: 0x002128FC File Offset: 0x00210AFC
		// Note: this type is marked as 'beforefieldinit'.
		static StorageGrid()
		{
			Il2CppClassPointerStore<StorageGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr);
			StorageGrid.NativeFieldInfoPtr_gridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "gridSize");
			StorageGrid.NativeFieldInfoPtr_storageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "storageTiles");
			StorageGrid.NativeFieldInfoPtr_freeTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "freeTiles");
			StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateStorageTilePairs");
			StorageGrid.NativeFieldInfoPtr_coordinateToTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateToTile");
			StorageGrid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678742);
			StorageGrid.NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678743);
			StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678744);
			StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678745);
			StorageGrid.NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678746);
			StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678747);
			StorageGrid.NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678748);
			StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678749);
			StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678750);
			StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678751);
			StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678752);
			StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678753);
			StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678754);
			StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678755);
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x00212AA8 File Offset: 0x00210CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235860, XrefRangeEnd = 235865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageGrid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x00212AE4 File Offset: 0x00210CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235882, RefRangeEnd = 235883, XrefRangeStart = 235865, XrefRangeEnd = 235882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoordinateTilePairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00212B18 File Offset: 0x00210D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235883, XrefRangeEnd = 235897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x00212B5C File Offset: 0x00210D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235897, XrefRangeEnd = 235912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00212BA0 File Offset: 0x00210DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235947, RefRangeEnd = 235948, XrefRangeStart = 235912, XrefRangeEnd = 235947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primaryTile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryFootprintTile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x00212C14 File Offset: 0x00210E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235963, RefRangeEnd = 235964, XrefRangeStart = 235948, XrefRangeEnd = 235963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x00212C64 File Offset: 0x00210E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235974, RefRangeEnd = 235975, XrefRangeStart = 235964, XrefRangeEnd = 235974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x00212CC4 File Offset: 0x00210EC4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 235982, RefRangeEnd = 235994, XrefRangeStart = 235975, XrefRangeEnd = 235982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr3) : null;
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x00212D14 File Offset: 0x00210F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235994, XrefRangeEnd = 235996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUserEndCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x00212D50 File Offset: 0x00210F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236001, RefRangeEnd = 236003, XrefRangeStart = 235996, XrefRangeEnd = 236001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00212D8C File Offset: 0x00210F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236003, XrefRangeEnd = 236005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x00212DC8 File Offset: 0x00210FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236005, XrefRangeEnd = 236006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalFootprintSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x00212E04 File Offset: 0x00211004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236057, RefRangeEnd = 236060, XrefRangeStart = 236006, XrefRangeEnd = 236057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockedCoordinates);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			originCoordinate = ((intPtr4 == 0) ? null : new Coordinate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x00212EA0 File Offset: 0x002110A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236060, XrefRangeEnd = 236087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x0003A776 File Offset: 0x00038976
		public StorageGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x06007B40 RID: 31552 RVA: 0x00212EDC File Offset: 0x002110DC
		// (set) Token: 0x06007B41 RID: 31553 RVA: 0x0003A77F File Offset: 0x0003897F
		public unsafe static float gridSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&value));
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x06007B42 RID: 31554 RVA: 0x00212EF8 File Offset: 0x002110F8
		// (set) Token: 0x06007B43 RID: 31555 RVA: 0x0003A78D File Offset: 0x0003898D
		public unsafe List<StorageTile> storageTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x06007B44 RID: 31556 RVA: 0x00212F28 File Offset: 0x00211128
		// (set) Token: 0x06007B45 RID: 31557 RVA: 0x0003A7AC File Offset: 0x000389AC
		public unsafe List<StorageTile> freeTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_freeTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_freeTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x06007B46 RID: 31558 RVA: 0x00212F58 File Offset: 0x00211158
		// (set) Token: 0x06007B47 RID: 31559 RVA: 0x0003A7CB File Offset: 0x000389CB
		public unsafe List<CoordinateStorageTilePair> coordinateStorageTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x00212F88 File Offset: 0x00211188
		// (set) Token: 0x06007B49 RID: 31561 RVA: 0x0003A7EA File Offset: 0x000389EA
		public unsafe Dictionary<Coordinate, StorageTile> coordinateToTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateToTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Coordinate, StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateToTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053E2 RID: 21474
		private static readonly IntPtr NativeFieldInfoPtr_gridSize;

		// Token: 0x040053E3 RID: 21475
		private static readonly IntPtr NativeFieldInfoPtr_storageTiles;

		// Token: 0x040053E4 RID: 21476
		private static readonly IntPtr NativeFieldInfoPtr_freeTiles;

		// Token: 0x040053E5 RID: 21477
		private static readonly IntPtr NativeFieldInfoPtr_coordinateStorageTilePairs;

		// Token: 0x040053E6 RID: 21478
		private static readonly IntPtr NativeFieldInfoPtr_coordinateToTile;

		// Token: 0x040053E7 RID: 21479
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040053E8 RID: 21480
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0;

		// Token: 0x040053E9 RID: 21481
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0;

		// Token: 0x040053EA RID: 21482
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0;

		// Token: 0x040053EB RID: 21483
		private static readonly IntPtr NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0;

		// Token: 0x040053EC RID: 21484
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x040053ED RID: 21485
		private static readonly IntPtr NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0;

		// Token: 0x040053EE RID: 21486
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0;

		// Token: 0x040053EF RID: 21487
		private static readonly IntPtr NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0;

		// Token: 0x040053F0 RID: 21488
		private static readonly IntPtr NativeMethodInfoPtr_GetActualY_Public_Int32_0;

		// Token: 0x040053F1 RID: 21489
		private static readonly IntPtr NativeMethodInfoPtr_GetActualX_Public_Int32_0;

		// Token: 0x040053F2 RID: 21490
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0;

		// Token: 0x040053F3 RID: 21491
		private static readonly IntPtr NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0;

		// Token: 0x040053F4 RID: 21492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
