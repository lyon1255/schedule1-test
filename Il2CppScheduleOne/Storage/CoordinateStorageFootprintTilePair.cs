using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057D RID: 1405
	[Serializable]
	public sealed class CoordinateStorageFootprintTilePair : ValueType
	{
		// Token: 0x06007BA0 RID: 31648 RVA: 0x00214234 File Offset: 0x00212434
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr);
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x0003AAAE File Offset: 0x00038CAE
		public CoordinateStorageFootprintTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0003AAB7 File Offset: 0x00038CB7
		public CoordinateStorageFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x0021428C File Offset: 0x0021248C
		// (set) Token: 0x06007BA4 RID: 31652 RVA: 0x0003AAC9 File Offset: 0x00038CC9
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x002142BC File Offset: 0x002124BC
		// (set) Token: 0x06007BA6 RID: 31654 RVA: 0x0003AAE8 File Offset: 0x00038CE8
		public unsafe FootprintTile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400542F RID: 21551
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x04005430 RID: 21552
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
