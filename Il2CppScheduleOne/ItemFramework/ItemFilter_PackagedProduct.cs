using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DC RID: 1500
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		// Token: 0x0600835B RID: 33627 RVA: 0x0022EA04 File Offset: 0x0022CC04
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_PackagedProduct()
		{
			Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_PackagedProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr);
			ItemFilter_PackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr, 100679725);
			ItemFilter_PackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr, 100679726);
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0022EA5C File Offset: 0x0022CC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247061, RefRangeEnd = 247063, XrefRangeStart = 247048, XrefRangeEnd = 247061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_PackagedProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_PackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0022EA98 File Offset: 0x0022CC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247063, XrefRangeEnd = 247073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_PackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0003E656 File Offset: 0x0003C856
		public ItemFilter_PackagedProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005966 RID: 22886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005967 RID: 22887
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
