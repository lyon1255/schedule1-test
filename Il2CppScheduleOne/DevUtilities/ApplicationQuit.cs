using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044B RID: 1099
	public class ApplicationQuit : MonoBehaviour
	{
		// Token: 0x06005FA5 RID: 24485 RVA: 0x001B6DFC File Offset: 0x001B4FFC
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationQuit()
		{
			Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ApplicationQuit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr);
			ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100675501);
			ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100675502);
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x001B6E54 File Offset: 0x001B5054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198535, XrefRangeEnd = 198539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x001B6E88 File Offset: 0x001B5088
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationQuit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x0002D1E5 File Offset: 0x0002B3E5
		public ApplicationQuit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400415D RID: 16733
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Void_0;

		// Token: 0x0400415E RID: 16734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
