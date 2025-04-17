using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B1 RID: 177
	public static class SpotLightHelper : Il2CppSystem.Object
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x0009A8C0 File Offset: 0x00098AC0
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLightHelper()
		{
			Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SpotLightHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr);
			SpotLightHelper.NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664905);
			SpotLightHelper.NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664906);
			SpotLightHelper.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664907);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0009A92C File Offset: 0x00098B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84380, XrefRangeEnd = 84385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetIntensity(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0009A970 File Offset: 0x00098B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84385, XrefRangeEnd = 84390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetSpotAngle(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0009A9B4 File Offset: 0x00098BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84390, XrefRangeEnd = 84395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFallOffEnd(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0000877C File Offset: 0x0000697C
		public SpotLightHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0;
	}
}
