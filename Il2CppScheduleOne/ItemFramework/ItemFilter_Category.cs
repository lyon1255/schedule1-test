using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D6 RID: 1494
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x06008336 RID: 33590 RVA: 0x0022E20C File Offset: 0x0022C40C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Category()
		{
			Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Category");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr);
			ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, "AcceptedCategories");
			ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100679710);
			ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100679711);
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x0022E278 File Offset: 0x0022C478
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 246980, RefRangeEnd = 246986, XrefRangeStart = 246971, XrefRangeEnd = 246980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Category(List<EItemCategory> acceptedCategories) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptedCategories);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x0022E2C4 File Offset: 0x0022C4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246986, XrefRangeEnd = 246989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x0003E591 File Offset: 0x0003C791
		public ItemFilter_Category(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x0600833A RID: 33594 RVA: 0x0022E31C File Offset: 0x0022C51C
		// (set) Token: 0x0600833B RID: 33595 RVA: 0x0003E59A File Offset: 0x0003C79A
		public unsafe List<EItemCategory> AcceptedCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EItemCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005952 RID: 22866
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedCategories;

		// Token: 0x04005953 RID: 22867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0;

		// Token: 0x04005954 RID: 22868
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
