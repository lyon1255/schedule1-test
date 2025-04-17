using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D8 RID: 216
	public static class DetailExtensions : Object
	{
		// Token: 0x06000FB2 RID: 4018 RVA: 0x000A19B0 File Offset: 0x0009FBB0
		// Note: this type is marked as 'beforefieldinit'.
		static DetailExtensions()
		{
			Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "DetailExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr);
			DetailExtensions.NativeMethodInfoPtr_allowsRefraction_Public_Static_Boolean_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr, 100665104);
			DetailExtensions.NativeMethodInfoPtr_usesFlask_Public_Static_Boolean_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr, 100665105);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000A1A08 File Offset: 0x0009FC08
		[CallerCount(0)]
		public unsafe static bool allowsRefraction(this DETAIL detail)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref detail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailExtensions.NativeMethodInfoPtr_allowsRefraction_Public_Static_Boolean_DETAIL_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000A1A48 File Offset: 0x0009FC48
		[CallerCount(0)]
		public unsafe static bool usesFlask(this DETAIL detail)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref detail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailExtensions.NativeMethodInfoPtr_usesFlask_Public_Static_Boolean_DETAIL_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00009D4B File Offset: 0x00007F4B
		public DetailExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_allowsRefraction_Public_Static_Boolean_DETAIL_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_usesFlask_Public_Static_Boolean_DETAIL_0;
	}
}
