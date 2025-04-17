using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000631 RID: 1585
	public class DealerManagementScreen : Singleton<DealerManagementScreen>
	{
		// Token: 0x06008C0E RID: 35854 RVA: 0x000431BC File Offset: 0x000413BC
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementScreen()
		{
			Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealerManagementScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr);
			DealerManagementScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr, 100680695);
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x00249784 File Offset: 0x00247984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256118, XrefRangeEnd = 256121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x000431F5 File Offset: 0x000413F5
		public DealerManagementScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005EF3 RID: 24307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
