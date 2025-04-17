using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BC RID: 1212
	public class TileIntersection : Object
	{
		// Token: 0x06006A1B RID: 27163 RVA: 0x001DA97C File Offset: 0x001D8B7C
		// Note: this type is marked as 'beforefieldinit'.
		static TileIntersection()
		{
			Il2CppClassPointerStore<TileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "TileIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr);
			TileIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "footprint");
			TileIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "tile");
			TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, 100676777);
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x001DA9E8 File Offset: 0x001D8BE8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x00032186 File Offset: 0x00030386
		public TileIntersection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06006A1E RID: 27166 RVA: 0x001DAA24 File Offset: 0x001D8C24
		// (set) Token: 0x06006A1F RID: 27167 RVA: 0x0003218F File Offset: 0x0003038F
		public unsafe FootprintTile footprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06006A20 RID: 27168 RVA: 0x001DAA54 File Offset: 0x001D8C54
		// (set) Token: 0x06006A21 RID: 27169 RVA: 0x000321AE File Offset: 0x000303AE
		public unsafe Tile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048AA RID: 18602
		private static readonly IntPtr NativeFieldInfoPtr_footprint;

		// Token: 0x040048AB RID: 18603
		private static readonly IntPtr NativeFieldInfoPtr_tile;

		// Token: 0x040048AC RID: 18604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
