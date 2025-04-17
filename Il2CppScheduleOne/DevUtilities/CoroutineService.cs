using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000453 RID: 1107
	public class CoroutineService : Singleton<CoroutineService>
	{
		// Token: 0x06006036 RID: 24630 RVA: 0x0002D78B File Offset: 0x0002B98B
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineService()
		{
			Il2CppClassPointerStore<CoroutineService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CoroutineService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr);
			CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr, 100675544);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x001B85B8 File Offset: 0x001B67B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198882, XrefRangeEnd = 198885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoroutineService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
		public CoroutineService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040041AF RID: 16815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
