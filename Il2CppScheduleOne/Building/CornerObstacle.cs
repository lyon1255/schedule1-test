using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C1 RID: 1217
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x06006AAB RID: 27307 RVA: 0x001DC3AC File Offset: 0x001DA5AC
		// Note: this type is marked as 'beforefieldinit'.
		static CornerObstacle()
		{
			Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "CornerObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr);
			CornerObstacle.NativeFieldInfoPtr_obstacleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "obstacleEnabled");
			CornerObstacle.NativeFieldInfoPtr_parentFootprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "parentFootprint");
			CornerObstacle.NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "coordinates");
			CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676823);
			CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676824);
			CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676825);
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x001DC454 File Offset: 0x001DA654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215145, RefRangeEnd = 215147, XrefRangeStart = 215115, XrefRangeEnd = 215145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr3) : null;
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x001DC4A4 File Offset: 0x001DA6A4
		[CallerCount(0)]
		public unsafe bool ApproxEquals(float a, float b, float precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x001DC50C File Offset: 0x001DA70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215147, XrefRangeEnd = 215150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CornerObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x000326CA File Offset: 0x000308CA
		public CornerObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x001DC548 File Offset: 0x001DA748
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x000326D3 File Offset: 0x000308D3
		public unsafe bool obstacleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled)) = value;
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x001DC570 File Offset: 0x001DA770
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x000326EE File Offset: 0x000308EE
		public unsafe FootprintTile parentFootprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x001DC5A0 File Offset: 0x001DA7A0
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x0003270D File Offset: 0x0003090D
		public unsafe Vector2 coordinates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates)) = value;
			}
		}

		// Token: 0x04004903 RID: 18691
		private static readonly IntPtr NativeFieldInfoPtr_obstacleEnabled;

		// Token: 0x04004904 RID: 18692
		private static readonly IntPtr NativeFieldInfoPtr_parentFootprint;

		// Token: 0x04004905 RID: 18693
		private static readonly IntPtr NativeFieldInfoPtr_coordinates;

		// Token: 0x04004906 RID: 18694
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0;

		// Token: 0x04004907 RID: 18695
		private static readonly IntPtr NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0;

		// Token: 0x04004908 RID: 18696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
