using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037C RID: 892
	public class GeneralStoreMerchant : Merchant
	{
		// Token: 0x060045D8 RID: 17880 RVA: 0x00021FFF File Offset: 0x000201FF
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralStoreMerchant()
		{
			Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "GeneralStoreMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr);
			GeneralStoreMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr, 100671886);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00157AF0 File Offset: 0x00155CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157697, XrefRangeEnd = 157702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralStoreMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralStoreMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00022038 File Offset: 0x00020238
		public GeneralStoreMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
