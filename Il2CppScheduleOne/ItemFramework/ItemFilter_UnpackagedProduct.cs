using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DD RID: 1501
	public class ItemFilter_UnpackagedProduct : ItemFilter_Category
	{
		// Token: 0x0600835F RID: 33631 RVA: 0x0022EAF0 File Offset: 0x0022CCF0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_UnpackagedProduct()
		{
			Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_UnpackagedProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr);
			ItemFilter_UnpackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr, 100679727);
			ItemFilter_UnpackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr, 100679728);
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0022EB48 File Offset: 0x0022CD48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 247086, RefRangeEnd = 247090, XrefRangeStart = 247073, XrefRangeEnd = 247086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_UnpackagedProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_UnpackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x0022EB84 File Offset: 0x0022CD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247090, XrefRangeEnd = 247100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_UnpackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0003E65F File Offset: 0x0003C85F
		public ItemFilter_UnpackagedProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005968 RID: 22888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005969 RID: 22889
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
