using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A3 RID: 675
	public class ToggleableItemData : GridItemData
	{
		// Token: 0x06003109 RID: 12553 RVA: 0x0010C2F0 File Offset: 0x0010A4F0
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableItemData()
		{
			Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ToggleableItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr);
			ToggleableItemData.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr, "IsOn");
			ToggleableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr, 100668824);
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0010C348 File Offset: 0x0010A548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130971, RefRangeEnd = 130972, XrefRangeStart = 130965, XrefRangeEnd = 130971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, bool isOn) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0001A2A3 File Offset: 0x000184A3
		public ToggleableItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0010C3EC File Offset: 0x0010A5EC
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0001A2AC File Offset: 0x000184AC
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItemData.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItemData.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_Boolean_0;
	}
}
