using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000112 RID: 274
	[Serializable]
	public class SpherePointGroupDictionary : SerializableDictionary<string, SpherePointKeyframeGroup>
	{
		// Token: 0x060015CB RID: 5579 RVA: 0x0000CE6D File Offset: 0x0000B06D
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePointGroupDictionary()
		{
			Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePointGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr);
			SpherePointGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr, 100665564);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000B3480 File Offset: 0x000B1680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90667, RefRangeEnd = 90668, XrefRangeStart = 90664, XrefRangeEnd = 90667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0000CEA6 File Offset: 0x0000B0A6
		public SpherePointGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
