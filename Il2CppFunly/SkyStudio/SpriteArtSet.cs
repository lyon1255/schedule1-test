using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E5 RID: 229
	public class SpriteArtSet : BaseArtSet
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x0000B0D8 File Offset: 0x000092D8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteArtSet()
		{
			Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpriteArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr);
			SpriteArtSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr, 100665371);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000A9628 File Offset: 0x000A7828
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteArtSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0000B111 File Offset: 0x00009311
		public SpriteArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
