using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200013C RID: 316
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x06001A55 RID: 6741 RVA: 0x000C2D3C File Offset: 0x000C0F3C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraAnimator()
		{
			Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "CameraAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr);
			CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100666093);
			CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100666094);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000C2D94 File Offset: 0x000C0F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97140, XrefRangeEnd = 97143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000C2DC8 File Offset: 0x000C0FC8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0000EEBD File Offset: 0x0000D0BD
		public CameraAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
