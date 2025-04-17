using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DF RID: 223
	public class BaseArtSet : ScriptableObject
	{
		// Token: 0x060011FB RID: 4603 RVA: 0x0000AEA5 File Offset: 0x000090A5
		// Note: this type is marked as 'beforefieldinit'.
		static BaseArtSet()
		{
			Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr);
			BaseArtSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr, 100665365);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000A8F84 File Offset: 0x000A7184
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseArtSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0000AEDE File Offset: 0x000090DE
		public BaseArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
