using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B6 RID: 182
	public static class UtilsBeamProps : Il2CppSystem.Object
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x0009C028 File Offset: 0x0009A228
		// Note: this type is marked as 'beforefieldinit'.
		static UtilsBeamProps()
		{
			Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "UtilsBeamProps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr);
			UtilsBeamProps.NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664963);
			UtilsBeamProps.NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664964);
			UtilsBeamProps.NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664965);
			UtilsBeamProps.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664966);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664967);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664968);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664969);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664970);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664971);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664972);
			UtilsBeamProps.NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664973);
			UtilsBeamProps.NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664974);
			UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664975);
			UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664976);
			UtilsBeamProps.NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664977);
			UtilsBeamProps.NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664978);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0009C198 File Offset: 0x0009A398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84784, XrefRangeEnd = 84792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanChangeDuringPlaytime(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0009C1DC File Offset: 0x0009A3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84792, XrefRangeEnd = 84810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion GetInternalLocalRotation(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0009C220 File Offset: 0x0009A420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84824, RefRangeEnd = 84825, XrefRangeStart = 84810, XrefRangeEnd = 84824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetThickness(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0009C264 File Offset: 0x0009A464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84839, RefRangeEnd = 84842, XrefRangeStart = 84825, XrefRangeEnd = 84839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFallOffEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0009C2A8 File Offset: 0x0009A4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84842, XrefRangeEnd = 84857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorMode GetColorMode(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0009C2EC File Offset: 0x0009A4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84857, XrefRangeEnd = 84871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColorFlat(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0009C330 File Offset: 0x0009A530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84871, XrefRangeEnd = 84885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Gradient GetColorGradient(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr3) : null;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0009C374 File Offset: 0x0009A574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84899, RefRangeEnd = 84900, XrefRangeStart = 84885, XrefRangeEnd = 84899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeAngle(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0009C3B8 File Offset: 0x0009A5B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84914, RefRangeEnd = 84916, XrefRangeStart = 84900, XrefRangeEnd = 84914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeRadiusStart(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0009C3FC File Offset: 0x0009A5FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84930, RefRangeEnd = 84931, XrefRangeStart = 84916, XrefRangeEnd = 84930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeRadiusEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0009C440 File Offset: 0x0009A640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84931, XrefRangeEnd = 84945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSortingLayerID(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0009C484 File Offset: 0x0009A684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84945, XrefRangeEnd = 84959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSortingOrder(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0009C4C8 File Offset: 0x0009A6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84959, XrefRangeEnd = 84967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFadeOutEnabled(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0009C50C File Offset: 0x0009A70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84967, XrefRangeEnd = 84975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFadeOutEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0009C550 File Offset: 0x0009A750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84989, RefRangeEnd = 84992, XrefRangeStart = 84975, XrefRangeEnd = 84989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dimensions GetDimensions(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0009C594 File Offset: 0x0009A794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84992, XrefRangeEnd = 85000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGeomSides(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000088DB File Offset: 0x00006ADB
		public UtilsBeamProps(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;
	}
}
