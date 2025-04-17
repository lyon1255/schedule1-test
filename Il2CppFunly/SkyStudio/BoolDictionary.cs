﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010E RID: 270
	[Serializable]
	public class BoolDictionary : SerializableDictionary<string, bool>
	{
		// Token: 0x060015BF RID: 5567 RVA: 0x0000CD65 File Offset: 0x0000AF65
		// Note: this type is marked as 'beforefieldinit'.
		static BoolDictionary()
		{
			Il2CppClassPointerStore<BoolDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolDictionary>.NativeClassPtr);
			BoolDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolDictionary>.NativeClassPtr, 100665560);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000B3390 File Offset: 0x000B1590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90649, XrefRangeEnd = 90652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0000CD9E File Offset: 0x0000AF9E
		public BoolDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
