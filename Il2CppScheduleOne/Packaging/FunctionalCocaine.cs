using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000564 RID: 1380
	public class FunctionalCocaine : FunctionalProduct
	{
		// Token: 0x06007914 RID: 30996 RVA: 0x000397AA File Offset: 0x000379AA
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalCocaine()
		{
			Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalCocaine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr);
			FunctionalCocaine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr, 100678478);
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x0020AC80 File Offset: 0x00208E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232706, XrefRangeEnd = 232707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalCocaine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalCocaine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x000397E3 File Offset: 0x000379E3
		public FunctionalCocaine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005271 RID: 21105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
