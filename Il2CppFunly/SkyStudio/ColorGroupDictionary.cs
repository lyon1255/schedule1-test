using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000110 RID: 272
	[Serializable]
	public class ColorGroupDictionary : SerializableDictionary<string, ColorKeyframeGroup>
	{
		// Token: 0x060015C5 RID: 5573 RVA: 0x0000CDE9 File Offset: 0x0000AFE9
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGroupDictionary()
		{
			Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr);
			ColorGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr, 100665562);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000B3408 File Offset: 0x000B1608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90659, RefRangeEnd = 90660, XrefRangeStart = 90656, XrefRangeEnd = 90659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0000CE22 File Offset: 0x0000B022
		public ColorGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
