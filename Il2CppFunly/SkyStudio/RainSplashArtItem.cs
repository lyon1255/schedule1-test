using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E2 RID: 226
	public class RainSplashArtItem : SpriteArtItem
	{
		// Token: 0x06001210 RID: 4624 RVA: 0x000A9238 File Offset: 0x000A7438
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashArtItem()
		{
			Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr);
			RainSplashArtItem.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr, "intensityMultiplier");
			RainSplashArtItem.NativeFieldInfoPtr_scaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr, "scaleMultiplier");
			RainSplashArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr, 100665368);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000A92A4 File Offset: 0x000A74A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88926, XrefRangeEnd = 88927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0000AFA3 File Offset: 0x000091A3
		public RainSplashArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000A92E0 File Offset: 0x000A74E0
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0000AFAC File Offset: 0x000091AC
		public unsafe float intensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_intensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_intensityMultiplier)) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x000A9308 File Offset: 0x000A7508
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0000AFC7 File Offset: 0x000091C7
		public unsafe float scaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_scaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_scaleMultiplier)) = value;
			}
		}

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr_scaleMultiplier;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
