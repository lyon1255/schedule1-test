using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004E RID: 78
	public sealed class TrackballGroupAttribute : PropertyAttribute
	{
		// Token: 0x06000635 RID: 1589 RVA: 0x00005A50 File Offset: 0x00003C50
		// Note: this type is marked as 'beforefieldinit'.
		static TrackballGroupAttribute()
		{
			Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "TrackballGroupAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr);
			TrackballGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr, 100663874);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00082C38 File Offset: 0x00080E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75781, RefRangeEnd = 75783, XrefRangeStart = 75780, XrefRangeEnd = 75781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackballGroupAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackballGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00005A89 File Offset: 0x00003C89
		public TrackballGroupAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
