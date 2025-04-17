using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Demos
{
	// Token: 0x0200013B RID: 315
	public class ToggleDoF : MonoBehaviour
	{
		// Token: 0x06001A51 RID: 6737 RVA: 0x000C2C74 File Offset: 0x000C0E74
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleDoF()
		{
			Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Demos", "ToggleDoF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr);
			ToggleDoF.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr, 100666091);
			ToggleDoF.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr, 100666092);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000C2CCC File Offset: 0x000C0ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97134, XrefRangeEnd = 97140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleDoF.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000C2D00 File Offset: 0x000C0F00
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleDoF() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleDoF.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		public ToggleDoF(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
