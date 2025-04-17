using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class BoolGroupDictionary : SerializableDictionary<string, BoolKeyframeGroup>
	{
		// Token: 0x060015C2 RID: 5570 RVA: 0x0000CDA7 File Offset: 0x0000AFA7
		// Note: this type is marked as 'beforefieldinit'.
		static BoolGroupDictionary()
		{
			Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr);
			BoolGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr, 100665561);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000B33CC File Offset: 0x000B15CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90655, RefRangeEnd = 90656, XrefRangeStart = 90652, XrefRangeEnd = 90655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		public BoolGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
