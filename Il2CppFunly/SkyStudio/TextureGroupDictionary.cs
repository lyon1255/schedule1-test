using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public class TextureGroupDictionary : SerializableDictionary<string, TextureKeyframeGroup>
	{
		// Token: 0x060015CE RID: 5582 RVA: 0x0000CEAF File Offset: 0x0000B0AF
		// Note: this type is marked as 'beforefieldinit'.
		static TextureGroupDictionary()
		{
			Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TextureGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr);
			TextureGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr, 100665565);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000B34BC File Offset: 0x000B16BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90671, RefRangeEnd = 90672, XrefRangeStart = 90668, XrefRangeEnd = 90671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		public TextureGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
