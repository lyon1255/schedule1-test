using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000706 RID: 1798
	public class CartEntry_Clothing : CartEntry
	{
		// Token: 0x0600A1A9 RID: 41385 RVA: 0x0028A7F4 File Offset: 0x002889F4
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry_Clothing()
		{
			Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry_Clothing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr);
			CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100683078);
			CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100683079);
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x0028A84C File Offset: 0x00288A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283871, XrefRangeEnd = 283885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x0028A888 File Offset: 0x00288A88
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry_Clothing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x0004F8A4 File Offset: 0x0004DAA4
		public CartEntry_Clothing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006C62 RID: 27746
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0;

		// Token: 0x04006C63 RID: 27747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
