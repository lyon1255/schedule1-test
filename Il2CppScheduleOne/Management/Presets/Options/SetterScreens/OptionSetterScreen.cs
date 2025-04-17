using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Presets.Options.SetterScreens
{
	// Token: 0x020003B0 RID: 944
	public class OptionSetterScreen : MonoBehaviour
	{
		// Token: 0x060049B8 RID: 18872 RVA: 0x00023813 File Offset: 0x00021A13
		// Note: this type is marked as 'beforefieldinit'.
		static OptionSetterScreen()
		{
			Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options.SetterScreens", "OptionSetterScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr);
			OptionSetterScreen.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr, 100672446);
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x00166DF0 File Offset: 0x00164FF0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSetterScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSetterScreen.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x0002384C File Offset: 0x00021A4C
		public OptionSetterScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
