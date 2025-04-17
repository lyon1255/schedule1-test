using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000198 RID: 408
	[Serializable]
	public sealed class CoordinateProceduralTilePair : ValueType
	{
		// Token: 0x060021AD RID: 8621 RVA: 0x000D9D9C File Offset: 0x000D7F9C
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateProceduralTilePair()
		{
			Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateProceduralTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr);
			CoordinateProceduralTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "coord");
			CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "tileParent");
			CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "tileIndex");
			CoordinateProceduralTilePair.NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, 100667111);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x000D9E1C File Offset: 0x000D801C
		public unsafe ProceduralTile tile
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 110650, RefRangeEnd = 110658, XrefRangeStart = 110639, XrefRangeEnd = 110650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoordinateProceduralTilePair.NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
			}
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00012C3F File Offset: 0x00010E3F
		public CoordinateProceduralTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00012C48 File Offset: 0x00010E48
		public CoordinateProceduralTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x000D9E60 File Offset: 0x000D8060
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00012C5A File Offset: 0x00010E5A
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000D9E90 File Offset: 0x000D8090
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x00012C79 File Offset: 0x00010E79
		public unsafe NetworkObject tileParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000D9EC0 File Offset: 0x000D80C0
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x00012C98 File Offset: 0x00010E98
		public unsafe int tileIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex)) = value;
			}
		}

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeFieldInfoPtr_tileParent;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeFieldInfoPtr_tileIndex;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0;
	}
}
