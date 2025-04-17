using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011C RID: 284
	public class HelpInformation : MonoBehaviour
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x0000E012 File Offset: 0x0000C212
		// Note: this type is marked as 'beforefieldinit'.
		static HelpInformation()
		{
			Il2CppClassPointerStore<HelpInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "HelpInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpInformation>.NativeClassPtr);
			HelpInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpInformation>.NativeClassPtr, 100665894);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000BC79C File Offset: 0x000BA99C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpInformation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0000E04B File Offset: 0x0000C24B
		public HelpInformation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
