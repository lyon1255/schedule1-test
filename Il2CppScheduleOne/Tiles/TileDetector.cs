using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A3 RID: 419
	public class TileDetector : MonoBehaviour
	{
		// Token: 0x0600223D RID: 8765 RVA: 0x000DB868 File Offset: 0x000D9A68
		// Note: this type is marked as 'beforefieldinit'.
		static TileDetector()
		{
			Il2CppClassPointerStore<TileDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "TileDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDetector>.NativeClassPtr);
			TileDetector.NativeFieldInfoPtr_detectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "detectionRadius");
			TileDetector.NativeFieldInfoPtr_tileDetectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "tileDetectionMode");
			TileDetector.NativeFieldInfoPtr_intersectedTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedTiles");
			TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedOutdoorTiles");
			TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedIndoorTiles");
			TileDetector.NativeFieldInfoPtr_intersectedStorageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedStorageTiles");
			TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedProceduralTiles");
			TileDetector.NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667161);
			TileDetector.NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667162);
			TileDetector.NativeMethodInfoPtr_GetClosestTile_Public_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667163);
			TileDetector.NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667164);
			TileDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667165);
			TileDetector.NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667166);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000DB99C File Offset: 0x000D9B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111243, XrefRangeEnd = 111340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections(bool sort = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileDetector.NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x000DB9E8 File Offset: 0x000D9BE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 111346, RefRangeEnd = 111351, XrefRangeStart = 111340, XrefRangeEnd = 111346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.MethodInfoStoreGeneric_OrderList_Public_List_1_T_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000DBA38 File Offset: 0x000D9C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111351, XrefRangeEnd = 111374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetClosestTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr_GetClosestTile_Public_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000DBA78 File Offset: 0x000D9C78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111397, RefRangeEnd = 111399, XrefRangeStart = 111374, XrefRangeEnd = 111397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetClosestProceduralTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x000DBAB8 File Offset: 0x000D9CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111399, XrefRangeEnd = 111431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000DBAF4 File Offset: 0x000D9CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111431, XrefRangeEnd = 111438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _OrderList_b__8_0<T>(T x) where T : MonoBehaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = x;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref x;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.MethodInfoStoreGeneric__OrderList_b__8_0_Private_Single_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0001319A File Offset: 0x0001139A
		public TileDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x000DBB8C File Offset: 0x000D9D8C
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x000131A3 File Offset: 0x000113A3
		public unsafe float detectionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_detectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_detectionRadius)) = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x000DBBB4 File Offset: 0x000D9DB4
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x000131BE File Offset: 0x000113BE
		public unsafe ETileDetectionMode tileDetectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_tileDetectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_tileDetectionMode)) = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x000DBBDC File Offset: 0x000D9DDC
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x000131D9 File Offset: 0x000113D9
		public unsafe List<Tile> intersectedTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000DBC0C File Offset: 0x000D9E0C
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x000131F8 File Offset: 0x000113F8
		public unsafe List<Tile> intersectedOutdoorTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000DBC3C File Offset: 0x000D9E3C
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x00013217 File Offset: 0x00011417
		public unsafe List<Tile> intersectedIndoorTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000DBC6C File Offset: 0x000D9E6C
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x00013236 File Offset: 0x00011436
		public unsafe List<StorageTile> intersectedStorageTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedStorageTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedStorageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000DBC9C File Offset: 0x000D9E9C
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x00013255 File Offset: 0x00011455
		public unsafe List<ProceduralTile> intersectedProceduralTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeFieldInfoPtr_detectionRadius;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeFieldInfoPtr_tileDetectionMode;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeFieldInfoPtr_intersectedTiles;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeFieldInfoPtr_intersectedOutdoorTiles;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeFieldInfoPtr_intersectedIndoorTiles;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeFieldInfoPtr_intersectedStorageTiles;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeFieldInfoPtr_intersectedProceduralTiles;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestTile_Public_Tile_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0;

		// Token: 0x020008C2 RID: 2242
		private sealed class MethodInfoStoreGeneric_OrderList_Public_List_1_T_List_1_T_0<T>
		{
			// Token: 0x0400849F RID: 33951
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDetector.NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0, Il2CppClassPointerStore<TileDetector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008C3 RID: 2243
		private sealed class MethodInfoStoreGeneric__OrderList_b__8_0_Private_Single_T_0<T>
		{
			// Token: 0x040084A0 RID: 33952
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDetector.NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0, Il2CppClassPointerStore<TileDetector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
