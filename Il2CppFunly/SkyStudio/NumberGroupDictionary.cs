using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class NumberGroupDictionary : SerializableDictionary<string, NumberKeyframeGroup>
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x0000CE2B File Offset: 0x0000B02B
		// Note: this type is marked as 'beforefieldinit'.
		static NumberGroupDictionary()
		{
			Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NumberGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr);
			NumberGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr, 100665563);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000B3444 File Offset: 0x000B1644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90663, RefRangeEnd = 90664, XrefRangeStart = 90660, XrefRangeEnd = 90663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0000CE64 File Offset: 0x0000B064
		public NumberGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
