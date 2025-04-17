using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037E RID: 894
	public class UndergroundMerchant : Merchant
	{
		// Token: 0x060045E9 RID: 17897 RVA: 0x000220BE File Offset: 0x000202BE
		// Note: this type is marked as 'beforefieldinit'.
		static UndergroundMerchant()
		{
			Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "UndergroundMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr);
			UndergroundMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr, 100671891);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00157D8C File Offset: 0x00155F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndergroundMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndergroundMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x000220F7 File Offset: 0x000202F7
		public UndergroundMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
