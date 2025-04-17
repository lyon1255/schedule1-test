using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E3 RID: 227
	public class RainSplashArtSet : SpriteArtSet
	{
		// Token: 0x06001217 RID: 4631 RVA: 0x000A9330 File Offset: 0x000A7530
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashArtSet()
		{
			Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr);
			RainSplashArtSet.NativeFieldInfoPtr_rainSplashArtItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr, "rainSplashArtItems");
			RainSplashArtSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr, 100665369);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000A9388 File Offset: 0x000A7588
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashArtSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0000AFE2 File Offset: 0x000091E2
		public RainSplashArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000A93C4 File Offset: 0x000A75C4
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0000AFEB File Offset: 0x000091EB
		public unsafe List<RainSplashArtItem> rainSplashArtItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtSet.NativeFieldInfoPtr_rainSplashArtItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RainSplashArtItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtSet.NativeFieldInfoPtr_rainSplashArtItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_rainSplashArtItems;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
