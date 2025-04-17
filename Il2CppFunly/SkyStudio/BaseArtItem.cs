using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DE RID: 222
	public class BaseArtItem : ScriptableObject
	{
		// Token: 0x060011F8 RID: 4600 RVA: 0x0000AE63 File Offset: 0x00009063
		// Note: this type is marked as 'beforefieldinit'.
		static BaseArtItem()
		{
			Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr);
			BaseArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr, 100665364);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000A8F48 File Offset: 0x000A7148
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88912, XrefRangeEnd = 88913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0000AE9C File Offset: 0x0000909C
		public BaseArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
