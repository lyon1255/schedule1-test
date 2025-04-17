using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DB RID: 1499
	public class ItemFilter_MixingIngredient : ItemFilter
	{
		// Token: 0x06008357 RID: 33623 RVA: 0x0022E918 File Offset: 0x0022CB18
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_MixingIngredient()
		{
			Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_MixingIngredient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100679723);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100679724);
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0022E970 File Offset: 0x0022CB70
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_MixingIngredient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x0022E9AC File Offset: 0x0022CBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247038, XrefRangeEnd = 247048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x0003E64D File Offset: 0x0003C84D
		public ItemFilter_MixingIngredient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005964 RID: 22884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005965 RID: 22885
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
