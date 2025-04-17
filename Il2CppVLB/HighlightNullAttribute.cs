using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009F RID: 159
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		// Token: 0x06000AF8 RID: 2808 RVA: 0x00007A13 File Offset: 0x00005C13
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightNullAttribute()
		{
			Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "HighlightNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr);
			HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr, 100664546);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00093090 File Offset: 0x00091290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75781, RefRangeEnd = 75783, XrefRangeStart = 75781, XrefRangeEnd = 75783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00007A4C File Offset: 0x00005C4C
		public HighlightNullAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
