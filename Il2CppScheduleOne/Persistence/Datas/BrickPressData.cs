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
	// Token: 0x02000293 RID: 659
	[Serializable]
	public class BrickPressData : GridItemData
	{
		// Token: 0x06003075 RID: 12405 RVA: 0x0010A654 File Offset: 0x00108854
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressData()
		{
			Il2CppClassPointerStore<BrickPressData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BrickPressData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr);
			BrickPressData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr, "Contents");
			BrickPressData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr, 100668808);
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0010A6AC File Offset: 0x001088AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130862, RefRangeEnd = 130867, XrefRangeStart = 130854, XrefRangeEnd = 130862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00019C51 File Offset: 0x00017E51
		public BrickPressData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x0010A758 File Offset: 0x00108958
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00019C5A File Offset: 0x00017E5A
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0;
	}
}
