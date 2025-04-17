using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029D RID: 669
	[Serializable]
	public class PlaceableStorageData : GridItemData
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x0010B9C4 File Offset: 0x00109BC4
		// Note: this type is marked as 'beforefieldinit'.
		static PlaceableStorageData()
		{
			Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlaceableStorageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr);
			PlaceableStorageData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr, "Contents");
			PlaceableStorageData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr, 100668818);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0010BA1C File Offset: 0x00109C1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130862, RefRangeEnd = 130867, XrefRangeStart = 130862, XrefRangeEnd = 130867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaceableStorageData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0001A0D3 File Offset: 0x000182D3
		public PlaceableStorageData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x0010BAC8 File Offset: 0x00109CC8
		// (set) Token: 0x060030DF RID: 12511 RVA: 0x0001A0DC File Offset: 0x000182DC
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0;
	}
}
