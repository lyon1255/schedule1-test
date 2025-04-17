using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052F RID: 1327
	public class CleanNodeLinks : MonoBehaviour
	{
		// Token: 0x0600765B RID: 30299 RVA: 0x00202D40 File Offset: 0x00200F40
		// Note: this type is marked as 'beforefieldinit'.
		static CleanNodeLinks()
		{
			Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CleanNodeLinks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr);
			CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100678200);
			CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100678201);
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00202D98 File Offset: 0x00200F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230643, XrefRangeEnd = 230662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00202DCC File Offset: 0x00200FCC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanNodeLinks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00038159 File Offset: 0x00036359
		public CleanNodeLinks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050D9 RID: 20697
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Public_Void_0;

		// Token: 0x040050DA RID: 20698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
