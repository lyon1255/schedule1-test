using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000565 RID: 1381
	public class FunctionalMeth : FunctionalProduct
	{
		// Token: 0x06007917 RID: 30999 RVA: 0x000397EC File Offset: 0x000379EC
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalMeth()
		{
			Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalMeth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr);
			FunctionalMeth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr, 100678479);
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x0020ACBC File Offset: 0x00208EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalMeth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalMeth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x00039825 File Offset: 0x00037A25
		public FunctionalMeth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005272 RID: 21106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
