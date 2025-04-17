using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000577 RID: 1399
	[Serializable]
	public sealed class CoordinateStorageTilePair : ValueType
	{
		// Token: 0x06007B29 RID: 31529 RVA: 0x00212844 File Offset: 0x00210A44
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr);
			CoordinateStorageTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "coord");
			CoordinateStorageTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x0003A71D File Offset: 0x0003891D
		public CoordinateStorageTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x0003A726 File Offset: 0x00038926
		public CoordinateStorageTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06007B2C RID: 31532 RVA: 0x0021289C File Offset: 0x00210A9C
		// (set) Token: 0x06007B2D RID: 31533 RVA: 0x0003A738 File Offset: 0x00038938
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x002128CC File Offset: 0x00210ACC
		// (set) Token: 0x06007B2F RID: 31535 RVA: 0x0003A757 File Offset: 0x00038957
		public unsafe StorageTile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053E0 RID: 21472
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040053E1 RID: 21473
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
