using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D8 RID: 1496
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x06008344 RID: 33604 RVA: 0x0022E524 File Offset: 0x0022C724
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Dryable()
		{
			Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Dryable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr);
			ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100679716);
			ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100679717);
			ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100679718);
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x0022E590 File Offset: 0x0022C790
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Dryable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x0022E5CC File Offset: 0x0022C7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247000, XrefRangeEnd = 247001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x0022E624 File Offset: 0x0022C824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247018, RefRangeEnd = 247020, XrefRangeStart = 247001, XrefRangeEnd = 247018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsItemDryable(ItemInstance instance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x0003E5DD File Offset: 0x0003C7DD
		public ItemFilter_Dryable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400595A RID: 22874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400595B RID: 22875
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x0400595C RID: 22876
		private static readonly IntPtr NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0;
	}
}
