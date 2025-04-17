using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000197 RID: 407
	[Serializable]
	public sealed class CoordinateTilePair : ValueType
	{
		// Token: 0x060021A6 RID: 8614 RVA: 0x000D9CE4 File Offset: 0x000D7EE4
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateTilePair()
		{
			Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr);
			CoordinateTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "coord");
			CoordinateTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00012BE6 File Offset: 0x00010DE6
		public CoordinateTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00012BEF File Offset: 0x00010DEF
		public CoordinateTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x000D9D3C File Offset: 0x000D7F3C
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00012C01 File Offset: 0x00010E01
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x000D9D6C File Offset: 0x000D7F6C
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00012C20 File Offset: 0x00010E20
		public unsafe Tile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
