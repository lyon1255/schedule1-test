using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000199 RID: 409
	[Serializable]
	public sealed class CoordinateFootprintTilePair : ValueType
	{
		// Token: 0x060021B7 RID: 8631 RVA: 0x000D9EE8 File Offset: 0x000D80E8
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr);
			CoordinateFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr, "footprintTile");
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00012CB3 File Offset: 0x00010EB3
		public CoordinateFootprintTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00012CBC File Offset: 0x00010EBC
		public CoordinateFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000D9F40 File Offset: 0x000D8140
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x00012CCE File Offset: 0x00010ECE
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000D9F70 File Offset: 0x000D8170
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x00012CED File Offset: 0x00010EED
		public unsafe FootprintTile footprintTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeFieldInfoPtr_footprintTile;
	}
}
