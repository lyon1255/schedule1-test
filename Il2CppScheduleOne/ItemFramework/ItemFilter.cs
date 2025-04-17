﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D5 RID: 1493
	public class ItemFilter : Object
	{
		// Token: 0x06008332 RID: 33586 RVA: 0x0022E120 File Offset: 0x0022C320
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter()
		{
			Il2CppClassPointerStore<ItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr);
			ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100679708);
			ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100679709);
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x0022E178 File Offset: 0x0022C378
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0022E1D0 File Offset: 0x0022C3D0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0003E588 File Offset: 0x0003C788
		public ItemFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005950 RID: 22864
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005951 RID: 22865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
