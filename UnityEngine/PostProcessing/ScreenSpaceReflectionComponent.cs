﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005B RID: 91
	public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x000856A4 File Offset: 0x000838A4
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionComponent()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ScreenSpaceReflectionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr);
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_HighlightSuppression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_HighlightSuppression");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TraceBehindObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_TraceBehindObjects");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_TreatBackfaceHitAsMiss");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_BilateralUpsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_BilateralUpsample");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_m_ReflectionTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "m_ReflectionTextures");
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664006);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664007);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664008);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664009);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664010);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664011);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664012);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000857C4 File Offset: 0x000839C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00085800 File Offset: 0x00083A00
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77350, XrefRangeEnd = 77352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0008583C File Offset: 0x00083A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77352, XrefRangeEnd = 77367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00085870 File Offset: 0x00083A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77367, XrefRangeEnd = 77369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000858A8 File Offset: 0x00083AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77369, RefRangeEnd = 77371, XrefRangeStart = 77369, XrefRangeEnd = 77369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000858E4 File Offset: 0x00083AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77371, XrefRangeEnd = 77528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00085928 File Offset: 0x00083B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77528, XrefRangeEnd = 77535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00005E63 File Offset: 0x00004063
		public ScreenSpaceReflectionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00085964 File Offset: 0x00083B64
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00005E6C File Offset: 0x0000406C
		public unsafe bool k_HighlightSuppression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_HighlightSuppression);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_HighlightSuppression)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0008598C File Offset: 0x00083B8C
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00005E87 File Offset: 0x00004087
		public unsafe bool k_TraceBehindObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TraceBehindObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TraceBehindObjects)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000859B4 File Offset: 0x00083BB4
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00005EA2 File Offset: 0x000040A2
		public unsafe bool k_TreatBackfaceHitAsMiss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000859DC File Offset: 0x00083BDC
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00005EBD File Offset: 0x000040BD
		public unsafe bool k_BilateralUpsample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_BilateralUpsample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_BilateralUpsample)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00085A04 File Offset: 0x00083C04
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00005ED8 File Offset: 0x000040D8
		public unsafe Il2CppStructArray<int> m_ReflectionTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_m_ReflectionTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_m_ReflectionTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_k_HighlightSuppression;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_k_TraceBehindObjects;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_k_BilateralUpsample;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_m_ReflectionTextures;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D5 RID: 2005
		public static class Uniforms : Object
		{
			// Token: 0x0600BBD9 RID: 48089 RVA: 0x002E6454 File Offset: 0x002E4654
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr);
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__RayStepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_RayStepSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AdditiveReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_AdditiveReflection");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BilateralUpsampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_BilateralUpsampling");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TreatBackfaceHitAsMiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_TreatBackfaceHitAsMiss");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AllowBackwardsRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_AllowBackwardsRays");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TraceBehindObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_TraceBehindObjects");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_MaxSteps");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FullResolutionFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FullResolutionFiltering");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HalfResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_HalfResolution");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HighlightSuppression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_HighlightSuppression");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__PixelsPerMeterAtOneMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_PixelsPerMeterAtOneMeter");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenEdgeFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ScreenEdgeFading");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ReflectionBlur");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxRayTraceDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_MaxRayTraceDistance");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FadeDistance");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__LayerThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_LayerThickness");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__SSRMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_SSRMultiplier");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FresnelFade");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFadePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FresnelFadePower");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ReflectionBufferSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ScreenSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__InvScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_InvScreenSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ProjInfo");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraClipInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_CameraClipInfo");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjectToPixelMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ProjectToPixelMatrix");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__WorldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_WorldToCameraMatrix");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_CameraToWorldMatrix");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_Axis");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CurrentMipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_CurrentMipLevel");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__NormalAndRoughnessTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_NormalAndRoughnessTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HitPointTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_HitPointTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BlurTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_BlurTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FilteredReflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FilteredReflections");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FinalReflectionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FinalReflectionTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TempTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_TempTexture");
			}

			// Token: 0x0600BBDA RID: 48090 RVA: 0x0005BE01 File Offset: 0x0005A001
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A24 RID: 14884
			// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x002E673C File Offset: 0x002E493C
			// (set) Token: 0x0600BBDC RID: 48092 RVA: 0x0005BE0A File Offset: 0x0005A00A
			public unsafe static int _RayStepSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__RayStepSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__RayStepSize, (void*)(&value));
				}
			}

			// Token: 0x17003A25 RID: 14885
			// (get) Token: 0x0600BBDD RID: 48093 RVA: 0x002E6758 File Offset: 0x002E4958
			// (set) Token: 0x0600BBDE RID: 48094 RVA: 0x0005BE18 File Offset: 0x0005A018
			public unsafe static int _AdditiveReflection
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AdditiveReflection, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AdditiveReflection, (void*)(&value));
				}
			}

			// Token: 0x17003A26 RID: 14886
			// (get) Token: 0x0600BBDF RID: 48095 RVA: 0x002E6774 File Offset: 0x002E4974
			// (set) Token: 0x0600BBE0 RID: 48096 RVA: 0x0005BE26 File Offset: 0x0005A026
			public unsafe static int _BilateralUpsampling
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BilateralUpsampling, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BilateralUpsampling, (void*)(&value));
				}
			}

			// Token: 0x17003A27 RID: 14887
			// (get) Token: 0x0600BBE1 RID: 48097 RVA: 0x002E6790 File Offset: 0x002E4990
			// (set) Token: 0x0600BBE2 RID: 48098 RVA: 0x0005BE34 File Offset: 0x0005A034
			public unsafe static int _TreatBackfaceHitAsMiss
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TreatBackfaceHitAsMiss, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TreatBackfaceHitAsMiss, (void*)(&value));
				}
			}

			// Token: 0x17003A28 RID: 14888
			// (get) Token: 0x0600BBE3 RID: 48099 RVA: 0x002E67AC File Offset: 0x002E49AC
			// (set) Token: 0x0600BBE4 RID: 48100 RVA: 0x0005BE42 File Offset: 0x0005A042
			public unsafe static int _AllowBackwardsRays
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AllowBackwardsRays, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AllowBackwardsRays, (void*)(&value));
				}
			}

			// Token: 0x17003A29 RID: 14889
			// (get) Token: 0x0600BBE5 RID: 48101 RVA: 0x002E67C8 File Offset: 0x002E49C8
			// (set) Token: 0x0600BBE6 RID: 48102 RVA: 0x0005BE50 File Offset: 0x0005A050
			public unsafe static int _TraceBehindObjects
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TraceBehindObjects, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TraceBehindObjects, (void*)(&value));
				}
			}

			// Token: 0x17003A2A RID: 14890
			// (get) Token: 0x0600BBE7 RID: 48103 RVA: 0x002E67E4 File Offset: 0x002E49E4
			// (set) Token: 0x0600BBE8 RID: 48104 RVA: 0x0005BE5E File Offset: 0x0005A05E
			public unsafe static int _MaxSteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxSteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxSteps, (void*)(&value));
				}
			}

			// Token: 0x17003A2B RID: 14891
			// (get) Token: 0x0600BBE9 RID: 48105 RVA: 0x002E6800 File Offset: 0x002E4A00
			// (set) Token: 0x0600BBEA RID: 48106 RVA: 0x0005BE6C File Offset: 0x0005A06C
			public unsafe static int _FullResolutionFiltering
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FullResolutionFiltering, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FullResolutionFiltering, (void*)(&value));
				}
			}

			// Token: 0x17003A2C RID: 14892
			// (get) Token: 0x0600BBEB RID: 48107 RVA: 0x002E681C File Offset: 0x002E4A1C
			// (set) Token: 0x0600BBEC RID: 48108 RVA: 0x0005BE7A File Offset: 0x0005A07A
			public unsafe static int _HalfResolution
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HalfResolution, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HalfResolution, (void*)(&value));
				}
			}

			// Token: 0x17003A2D RID: 14893
			// (get) Token: 0x0600BBED RID: 48109 RVA: 0x002E6838 File Offset: 0x002E4A38
			// (set) Token: 0x0600BBEE RID: 48110 RVA: 0x0005BE88 File Offset: 0x0005A088
			public unsafe static int _HighlightSuppression
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HighlightSuppression, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HighlightSuppression, (void*)(&value));
				}
			}

			// Token: 0x17003A2E RID: 14894
			// (get) Token: 0x0600BBEF RID: 48111 RVA: 0x002E6854 File Offset: 0x002E4A54
			// (set) Token: 0x0600BBF0 RID: 48112 RVA: 0x0005BE96 File Offset: 0x0005A096
			public unsafe static int _PixelsPerMeterAtOneMeter
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__PixelsPerMeterAtOneMeter, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__PixelsPerMeterAtOneMeter, (void*)(&value));
				}
			}

			// Token: 0x17003A2F RID: 14895
			// (get) Token: 0x0600BBF1 RID: 48113 RVA: 0x002E6870 File Offset: 0x002E4A70
			// (set) Token: 0x0600BBF2 RID: 48114 RVA: 0x0005BEA4 File Offset: 0x0005A0A4
			public unsafe static int _ScreenEdgeFading
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenEdgeFading, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenEdgeFading, (void*)(&value));
				}
			}

			// Token: 0x17003A30 RID: 14896
			// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x002E688C File Offset: 0x002E4A8C
			// (set) Token: 0x0600BBF4 RID: 48116 RVA: 0x0005BEB2 File Offset: 0x0005A0B2
			public unsafe static int _ReflectionBlur
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBlur, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBlur, (void*)(&value));
				}
			}

			// Token: 0x17003A31 RID: 14897
			// (get) Token: 0x0600BBF5 RID: 48117 RVA: 0x002E68A8 File Offset: 0x002E4AA8
			// (set) Token: 0x0600BBF6 RID: 48118 RVA: 0x0005BEC0 File Offset: 0x0005A0C0
			public unsafe static int _MaxRayTraceDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxRayTraceDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxRayTraceDistance, (void*)(&value));
				}
			}

			// Token: 0x17003A32 RID: 14898
			// (get) Token: 0x0600BBF7 RID: 48119 RVA: 0x002E68C4 File Offset: 0x002E4AC4
			// (set) Token: 0x0600BBF8 RID: 48120 RVA: 0x0005BECE File Offset: 0x0005A0CE
			public unsafe static int _FadeDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FadeDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FadeDistance, (void*)(&value));
				}
			}

			// Token: 0x17003A33 RID: 14899
			// (get) Token: 0x0600BBF9 RID: 48121 RVA: 0x002E68E0 File Offset: 0x002E4AE0
			// (set) Token: 0x0600BBFA RID: 48122 RVA: 0x0005BEDC File Offset: 0x0005A0DC
			public unsafe static int _LayerThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__LayerThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__LayerThickness, (void*)(&value));
				}
			}

			// Token: 0x17003A34 RID: 14900
			// (get) Token: 0x0600BBFB RID: 48123 RVA: 0x002E68FC File Offset: 0x002E4AFC
			// (set) Token: 0x0600BBFC RID: 48124 RVA: 0x0005BEEA File Offset: 0x0005A0EA
			public unsafe static int _SSRMultiplier
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__SSRMultiplier, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__SSRMultiplier, (void*)(&value));
				}
			}

			// Token: 0x17003A35 RID: 14901
			// (get) Token: 0x0600BBFD RID: 48125 RVA: 0x002E6918 File Offset: 0x002E4B18
			// (set) Token: 0x0600BBFE RID: 48126 RVA: 0x0005BEF8 File Offset: 0x0005A0F8
			public unsafe static int _FresnelFade
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFade, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFade, (void*)(&value));
				}
			}

			// Token: 0x17003A36 RID: 14902
			// (get) Token: 0x0600BBFF RID: 48127 RVA: 0x002E6934 File Offset: 0x002E4B34
			// (set) Token: 0x0600BC00 RID: 48128 RVA: 0x0005BF06 File Offset: 0x0005A106
			public unsafe static int _FresnelFadePower
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFadePower, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFadePower, (void*)(&value));
				}
			}

			// Token: 0x17003A37 RID: 14903
			// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x002E6950 File Offset: 0x002E4B50
			// (set) Token: 0x0600BC02 RID: 48130 RVA: 0x0005BF14 File Offset: 0x0005A114
			public unsafe static int _ReflectionBufferSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBufferSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBufferSize, (void*)(&value));
				}
			}

			// Token: 0x17003A38 RID: 14904
			// (get) Token: 0x0600BC03 RID: 48131 RVA: 0x002E696C File Offset: 0x002E4B6C
			// (set) Token: 0x0600BC04 RID: 48132 RVA: 0x0005BF22 File Offset: 0x0005A122
			public unsafe static int _ScreenSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenSize, (void*)(&value));
				}
			}

			// Token: 0x17003A39 RID: 14905
			// (get) Token: 0x0600BC05 RID: 48133 RVA: 0x002E6988 File Offset: 0x002E4B88
			// (set) Token: 0x0600BC06 RID: 48134 RVA: 0x0005BF30 File Offset: 0x0005A130
			public unsafe static int _InvScreenSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__InvScreenSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__InvScreenSize, (void*)(&value));
				}
			}

			// Token: 0x17003A3A RID: 14906
			// (get) Token: 0x0600BC07 RID: 48135 RVA: 0x002E69A4 File Offset: 0x002E4BA4
			// (set) Token: 0x0600BC08 RID: 48136 RVA: 0x0005BF3E File Offset: 0x0005A13E
			public unsafe static int _ProjInfo
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjInfo, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjInfo, (void*)(&value));
				}
			}

			// Token: 0x17003A3B RID: 14907
			// (get) Token: 0x0600BC09 RID: 48137 RVA: 0x002E69C0 File Offset: 0x002E4BC0
			// (set) Token: 0x0600BC0A RID: 48138 RVA: 0x0005BF4C File Offset: 0x0005A14C
			public unsafe static int _CameraClipInfo
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraClipInfo, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraClipInfo, (void*)(&value));
				}
			}

			// Token: 0x17003A3C RID: 14908
			// (get) Token: 0x0600BC0B RID: 48139 RVA: 0x002E69DC File Offset: 0x002E4BDC
			// (set) Token: 0x0600BC0C RID: 48140 RVA: 0x0005BF5A File Offset: 0x0005A15A
			public unsafe static int _ProjectToPixelMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjectToPixelMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjectToPixelMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003A3D RID: 14909
			// (get) Token: 0x0600BC0D RID: 48141 RVA: 0x002E69F8 File Offset: 0x002E4BF8
			// (set) Token: 0x0600BC0E RID: 48142 RVA: 0x0005BF68 File Offset: 0x0005A168
			public unsafe static int _WorldToCameraMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__WorldToCameraMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__WorldToCameraMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003A3E RID: 14910
			// (get) Token: 0x0600BC0F RID: 48143 RVA: 0x002E6A14 File Offset: 0x002E4C14
			// (set) Token: 0x0600BC10 RID: 48144 RVA: 0x0005BF76 File Offset: 0x0005A176
			public unsafe static int _CameraToWorldMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraToWorldMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraToWorldMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003A3F RID: 14911
			// (get) Token: 0x0600BC11 RID: 48145 RVA: 0x002E6A30 File Offset: 0x002E4C30
			// (set) Token: 0x0600BC12 RID: 48146 RVA: 0x0005BF84 File Offset: 0x0005A184
			public unsafe static int _Axis
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__Axis, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__Axis, (void*)(&value));
				}
			}

			// Token: 0x17003A40 RID: 14912
			// (get) Token: 0x0600BC13 RID: 48147 RVA: 0x002E6A4C File Offset: 0x002E4C4C
			// (set) Token: 0x0600BC14 RID: 48148 RVA: 0x0005BF92 File Offset: 0x0005A192
			public unsafe static int _CurrentMipLevel
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CurrentMipLevel, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CurrentMipLevel, (void*)(&value));
				}
			}

			// Token: 0x17003A41 RID: 14913
			// (get) Token: 0x0600BC15 RID: 48149 RVA: 0x002E6A68 File Offset: 0x002E4C68
			// (set) Token: 0x0600BC16 RID: 48150 RVA: 0x0005BFA0 File Offset: 0x0005A1A0
			public unsafe static int _NormalAndRoughnessTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__NormalAndRoughnessTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__NormalAndRoughnessTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A42 RID: 14914
			// (get) Token: 0x0600BC17 RID: 48151 RVA: 0x002E6A84 File Offset: 0x002E4C84
			// (set) Token: 0x0600BC18 RID: 48152 RVA: 0x0005BFAE File Offset: 0x0005A1AE
			public unsafe static int _HitPointTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HitPointTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HitPointTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A43 RID: 14915
			// (get) Token: 0x0600BC19 RID: 48153 RVA: 0x002E6AA0 File Offset: 0x002E4CA0
			// (set) Token: 0x0600BC1A RID: 48154 RVA: 0x0005BFBC File Offset: 0x0005A1BC
			public unsafe static int _BlurTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BlurTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BlurTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A44 RID: 14916
			// (get) Token: 0x0600BC1B RID: 48155 RVA: 0x002E6ABC File Offset: 0x002E4CBC
			// (set) Token: 0x0600BC1C RID: 48156 RVA: 0x0005BFCA File Offset: 0x0005A1CA
			public unsafe static int _FilteredReflections
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FilteredReflections, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FilteredReflections, (void*)(&value));
				}
			}

			// Token: 0x17003A45 RID: 14917
			// (get) Token: 0x0600BC1D RID: 48157 RVA: 0x002E6AD8 File Offset: 0x002E4CD8
			// (set) Token: 0x0600BC1E RID: 48158 RVA: 0x0005BFD8 File Offset: 0x0005A1D8
			public unsafe static int _FinalReflectionTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FinalReflectionTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FinalReflectionTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A46 RID: 14918
			// (get) Token: 0x0600BC1F RID: 48159 RVA: 0x002E6AF4 File Offset: 0x002E4CF4
			// (set) Token: 0x0600BC20 RID: 48160 RVA: 0x0005BFE6 File Offset: 0x0005A1E6
			public unsafe static int _TempTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TempTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TempTexture, (void*)(&value));
				}
			}

			// Token: 0x04007E8D RID: 32397
			private static readonly IntPtr NativeFieldInfoPtr__RayStepSize;

			// Token: 0x04007E8E RID: 32398
			private static readonly IntPtr NativeFieldInfoPtr__AdditiveReflection;

			// Token: 0x04007E8F RID: 32399
			private static readonly IntPtr NativeFieldInfoPtr__BilateralUpsampling;

			// Token: 0x04007E90 RID: 32400
			private static readonly IntPtr NativeFieldInfoPtr__TreatBackfaceHitAsMiss;

			// Token: 0x04007E91 RID: 32401
			private static readonly IntPtr NativeFieldInfoPtr__AllowBackwardsRays;

			// Token: 0x04007E92 RID: 32402
			private static readonly IntPtr NativeFieldInfoPtr__TraceBehindObjects;

			// Token: 0x04007E93 RID: 32403
			private static readonly IntPtr NativeFieldInfoPtr__MaxSteps;

			// Token: 0x04007E94 RID: 32404
			private static readonly IntPtr NativeFieldInfoPtr__FullResolutionFiltering;

			// Token: 0x04007E95 RID: 32405
			private static readonly IntPtr NativeFieldInfoPtr__HalfResolution;

			// Token: 0x04007E96 RID: 32406
			private static readonly IntPtr NativeFieldInfoPtr__HighlightSuppression;

			// Token: 0x04007E97 RID: 32407
			private static readonly IntPtr NativeFieldInfoPtr__PixelsPerMeterAtOneMeter;

			// Token: 0x04007E98 RID: 32408
			private static readonly IntPtr NativeFieldInfoPtr__ScreenEdgeFading;

			// Token: 0x04007E99 RID: 32409
			private static readonly IntPtr NativeFieldInfoPtr__ReflectionBlur;

			// Token: 0x04007E9A RID: 32410
			private static readonly IntPtr NativeFieldInfoPtr__MaxRayTraceDistance;

			// Token: 0x04007E9B RID: 32411
			private static readonly IntPtr NativeFieldInfoPtr__FadeDistance;

			// Token: 0x04007E9C RID: 32412
			private static readonly IntPtr NativeFieldInfoPtr__LayerThickness;

			// Token: 0x04007E9D RID: 32413
			private static readonly IntPtr NativeFieldInfoPtr__SSRMultiplier;

			// Token: 0x04007E9E RID: 32414
			private static readonly IntPtr NativeFieldInfoPtr__FresnelFade;

			// Token: 0x04007E9F RID: 32415
			private static readonly IntPtr NativeFieldInfoPtr__FresnelFadePower;

			// Token: 0x04007EA0 RID: 32416
			private static readonly IntPtr NativeFieldInfoPtr__ReflectionBufferSize;

			// Token: 0x04007EA1 RID: 32417
			private static readonly IntPtr NativeFieldInfoPtr__ScreenSize;

			// Token: 0x04007EA2 RID: 32418
			private static readonly IntPtr NativeFieldInfoPtr__InvScreenSize;

			// Token: 0x04007EA3 RID: 32419
			private static readonly IntPtr NativeFieldInfoPtr__ProjInfo;

			// Token: 0x04007EA4 RID: 32420
			private static readonly IntPtr NativeFieldInfoPtr__CameraClipInfo;

			// Token: 0x04007EA5 RID: 32421
			private static readonly IntPtr NativeFieldInfoPtr__ProjectToPixelMatrix;

			// Token: 0x04007EA6 RID: 32422
			private static readonly IntPtr NativeFieldInfoPtr__WorldToCameraMatrix;

			// Token: 0x04007EA7 RID: 32423
			private static readonly IntPtr NativeFieldInfoPtr__CameraToWorldMatrix;

			// Token: 0x04007EA8 RID: 32424
			private static readonly IntPtr NativeFieldInfoPtr__Axis;

			// Token: 0x04007EA9 RID: 32425
			private static readonly IntPtr NativeFieldInfoPtr__CurrentMipLevel;

			// Token: 0x04007EAA RID: 32426
			private static readonly IntPtr NativeFieldInfoPtr__NormalAndRoughnessTexture;

			// Token: 0x04007EAB RID: 32427
			private static readonly IntPtr NativeFieldInfoPtr__HitPointTexture;

			// Token: 0x04007EAC RID: 32428
			private static readonly IntPtr NativeFieldInfoPtr__BlurTexture;

			// Token: 0x04007EAD RID: 32429
			private static readonly IntPtr NativeFieldInfoPtr__FilteredReflections;

			// Token: 0x04007EAE RID: 32430
			private static readonly IntPtr NativeFieldInfoPtr__FinalReflectionTexture;

			// Token: 0x04007EAF RID: 32431
			private static readonly IntPtr NativeFieldInfoPtr__TempTexture;
		}

		// Token: 0x020007D6 RID: 2006
		[OriginalName("Assembly-CSharp.dll", "", "PassIndex")]
		public enum PassIndex
		{
			// Token: 0x04007EB1 RID: 32433
			RayTraceStep,
			// Token: 0x04007EB2 RID: 32434
			CompositeFinal,
			// Token: 0x04007EB3 RID: 32435
			Blur,
			// Token: 0x04007EB4 RID: 32436
			CompositeSSR,
			// Token: 0x04007EB5 RID: 32437
			MinMipGeneration,
			// Token: 0x04007EB6 RID: 32438
			HitPointToReflections,
			// Token: 0x04007EB7 RID: 32439
			BilateralKeyPack,
			// Token: 0x04007EB8 RID: 32440
			BlitDepthAsCSZ,
			// Token: 0x04007EB9 RID: 32441
			PoissonBlur
		}
	}
}
