using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CD RID: 205
	public class FishAnimator : MonoBehaviour
	{
		// Token: 0x06000F28 RID: 3880 RVA: 0x000A0590 File Offset: 0x0009E790
		// Note: this type is marked as 'beforefieldinit'.
		static FishAnimator()
		{
			Il2CppClassPointerStore<FishAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "FishAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishAnimator>.NativeClassPtr);
			FishAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishAnimator>.NativeClassPtr, 100665081);
			FishAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishAnimator>.NativeClassPtr, 100665082);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000A05E8 File Offset: 0x0009E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86179, XrefRangeEnd = 86186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000A061C File Offset: 0x0009E81C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000097BC File Offset: 0x000079BC
		public FishAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
