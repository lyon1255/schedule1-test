﻿using System;
using Il2CppAmplifyColor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000003 RID: 3
	public class AmplifyColorEffect : MonoBehaviour
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00071460 File Offset: 0x0006F660
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyColorEffect()
		{
			Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmplifyColorEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr);
			AmplifyColorEffect.NativeFieldInfoPtr_LutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "LutSize");
			AmplifyColorEffect.NativeFieldInfoPtr_LutWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "LutWidth");
			AmplifyColorEffect.NativeFieldInfoPtr_LutHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "LutHeight");
			AmplifyColorEffect.NativeFieldInfoPtr_DepthCurveLutRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "DepthCurveLutRange");
			AmplifyColorEffect.NativeFieldInfoPtr_Tonemapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "Tonemapper");
			AmplifyColorEffect.NativeFieldInfoPtr_Exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "Exposure");
			AmplifyColorEffect.NativeFieldInfoPtr_LinearWhitePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "LinearWhitePoint");
			AmplifyColorEffect.NativeFieldInfoPtr_ApplyDithering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "ApplyDithering");
			AmplifyColorEffect.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "QualityLevel");
			AmplifyColorEffect.NativeFieldInfoPtr_BlendAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "BlendAmount");
			AmplifyColorEffect.NativeFieldInfoPtr_LutTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "LutTexture");
			AmplifyColorEffect.NativeFieldInfoPtr_LutBlendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "LutBlendTexture");
			AmplifyColorEffect.NativeFieldInfoPtr_MaskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "MaskTexture");
			AmplifyColorEffect.NativeFieldInfoPtr_UseDepthMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "UseDepthMask");
			AmplifyColorEffect.NativeFieldInfoPtr_DepthMaskCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "DepthMaskCurve");
			AmplifyColorEffect.NativeFieldInfoPtr_UseVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "UseVolumes");
			AmplifyColorEffect.NativeFieldInfoPtr_ExitVolumeBlendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "ExitVolumeBlendTime");
			AmplifyColorEffect.NativeFieldInfoPtr_TriggerVolumeProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "TriggerVolumeProxy");
			AmplifyColorEffect.NativeFieldInfoPtr_VolumeCollisionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "VolumeCollisionMask");
			AmplifyColorEffect.NativeFieldInfoPtr_ownerCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "ownerCamera");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderBase");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderBlendCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderBlendCache");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderMask");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderMaskBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderMaskBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderDepthMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderDepthMask");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderDepthMaskBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderDepthMaskBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_shaderProcessOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "shaderProcessOnly");
			AmplifyColorEffect.NativeFieldInfoPtr_blendCacheLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blendCacheLut");
			AmplifyColorEffect.NativeFieldInfoPtr_defaultLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "defaultLut");
			AmplifyColorEffect.NativeFieldInfoPtr_depthCurveLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "depthCurveLut");
			AmplifyColorEffect.NativeFieldInfoPtr_depthCurveColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "depthCurveColors");
			AmplifyColorEffect.NativeFieldInfoPtr_colorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "colorSpace");
			AmplifyColorEffect.NativeFieldInfoPtr_qualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "qualityLevel");
			AmplifyColorEffect.NativeFieldInfoPtr_materialBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialBase");
			AmplifyColorEffect.NativeFieldInfoPtr_materialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_materialBlendCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialBlendCache");
			AmplifyColorEffect.NativeFieldInfoPtr_materialMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialMask");
			AmplifyColorEffect.NativeFieldInfoPtr_materialMaskBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialMaskBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_materialDepthMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialDepthMask");
			AmplifyColorEffect.NativeFieldInfoPtr_materialDepthMaskBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialDepthMaskBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_materialProcessOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "materialProcessOnly");
			AmplifyColorEffect.NativeFieldInfoPtr_blending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blending");
			AmplifyColorEffect.NativeFieldInfoPtr_blendingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blendingTime");
			AmplifyColorEffect.NativeFieldInfoPtr_blendingTimeCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blendingTimeCountdown");
			AmplifyColorEffect.NativeFieldInfoPtr_onFinishBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "onFinishBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_prevDepthMaskCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "prevDepthMaskCurve");
			AmplifyColorEffect.NativeFieldInfoPtr_volumesBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "volumesBlending");
			AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "volumesBlendingTime");
			AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendingTimeCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "volumesBlendingTimeCountdown");
			AmplifyColorEffect.NativeFieldInfoPtr_volumesLutBlendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "volumesLutBlendTexture");
			AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "volumesBlendAmount");
			AmplifyColorEffect.NativeFieldInfoPtr_worldLUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "worldLUT");
			AmplifyColorEffect.NativeFieldInfoPtr_currentVolumeLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "currentVolumeLut");
			AmplifyColorEffect.NativeFieldInfoPtr_midBlendLUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "midBlendLUT");
			AmplifyColorEffect.NativeFieldInfoPtr_blendingFromMidBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blendingFromMidBlend");
			AmplifyColorEffect.NativeFieldInfoPtr_worldVolumeEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "worldVolumeEffects");
			AmplifyColorEffect.NativeFieldInfoPtr_currentVolumeEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "currentVolumeEffects");
			AmplifyColorEffect.NativeFieldInfoPtr_blendVolumeEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blendVolumeEffects");
			AmplifyColorEffect.NativeFieldInfoPtr_worldExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "worldExposure");
			AmplifyColorEffect.NativeFieldInfoPtr_currentExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "currentExposure");
			AmplifyColorEffect.NativeFieldInfoPtr_blendExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "blendExposure");
			AmplifyColorEffect.NativeFieldInfoPtr_effectVolumesBlendAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "effectVolumesBlendAdjust");
			AmplifyColorEffect.NativeFieldInfoPtr_enteredVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "enteredVolumes");
			AmplifyColorEffect.NativeFieldInfoPtr_actualTriggerProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "actualTriggerProxy");
			AmplifyColorEffect.NativeFieldInfoPtr_EffectFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "EffectFlags");
			AmplifyColorEffect.NativeFieldInfoPtr_sharedInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "sharedInstanceID");
			AmplifyColorEffect.NativeFieldInfoPtr_silentError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, "silentError");
			AmplifyColorEffect.NativeMethodInfoPtr_get_DefaultLut_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663303);
			AmplifyColorEffect.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663304);
			AmplifyColorEffect.NativeMethodInfoPtr_get_effectVolumesBlendAdjusted_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663305);
			AmplifyColorEffect.NativeMethodInfoPtr_get_SharedInstanceID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663306);
			AmplifyColorEffect.NativeMethodInfoPtr_get_WillItBlend_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663307);
			AmplifyColorEffect.NativeMethodInfoPtr_NewSharedInstanceID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663308);
			AmplifyColorEffect.NativeMethodInfoPtr_ReportMissingShaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663309);
			AmplifyColorEffect.NativeMethodInfoPtr_ReportNotSupported_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663310);
			AmplifyColorEffect.NativeMethodInfoPtr_CheckShader_Private_Boolean_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663311);
			AmplifyColorEffect.NativeMethodInfoPtr_CheckShaders_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663312);
			AmplifyColorEffect.NativeMethodInfoPtr_CheckSupport_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663313);
			AmplifyColorEffect.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663314);
			AmplifyColorEffect.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663315);
			AmplifyColorEffect.NativeMethodInfoPtr_VolumesBlendTo_Private_Void_Texture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663316);
			AmplifyColorEffect.NativeMethodInfoPtr_BlendTo_Public_Void_Texture_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663317);
			AmplifyColorEffect.NativeMethodInfoPtr_CheckCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663318);
			AmplifyColorEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663319);
			AmplifyColorEffect.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663320);
			AmplifyColorEffect.NativeMethodInfoPtr_EnterVolume_Public_Void_AmplifyColorVolumeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663321);
			AmplifyColorEffect.NativeMethodInfoPtr_ExitVolume_Public_Void_AmplifyColorVolumeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663322);
			AmplifyColorEffect.NativeMethodInfoPtr_UpdateVolumes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663323);
			AmplifyColorEffect.NativeMethodInfoPtr_SetupShader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663324);
			AmplifyColorEffect.NativeMethodInfoPtr_ReleaseMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663325);
			AmplifyColorEffect.NativeMethodInfoPtr_CreateDefaultLut_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663326);
			AmplifyColorEffect.NativeMethodInfoPtr_CreateDepthCurveLut_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663327);
			AmplifyColorEffect.NativeMethodInfoPtr_UpdateDepthCurveLut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663328);
			AmplifyColorEffect.NativeMethodInfoPtr_CheckUpdateDepthCurveLut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663329);
			AmplifyColorEffect.NativeMethodInfoPtr_CreateHelperTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663330);
			AmplifyColorEffect.NativeMethodInfoPtr_CheckMaterialAndShader_Private_Boolean_Material_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663331);
			AmplifyColorEffect.NativeMethodInfoPtr_CreateMaterials_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663332);
			AmplifyColorEffect.NativeMethodInfoPtr_SetMaterialKeyword_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663333);
			AmplifyColorEffect.NativeMethodInfoPtr_SafeRelease_Private_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663334);
			AmplifyColorEffect.NativeMethodInfoPtr_ReleaseTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663335);
			AmplifyColorEffect.NativeMethodInfoPtr_ValidateLutDimensions_Public_Static_Boolean_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663336);
			AmplifyColorEffect.NativeMethodInfoPtr_UpdatePostEffectParams_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663337);
			AmplifyColorEffect.NativeMethodInfoPtr_ComputeShaderPass_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663338);
			AmplifyColorEffect.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663339);
			AmplifyColorEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr, 100663340);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00071CD8 File Offset: 0x0006FED8
		public unsafe Texture2D DefaultLut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70218, XrefRangeEnd = 70223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_get_DefaultLut_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00071D18 File Offset: 0x0006FF18
		public unsafe bool IsBlending
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00071D54 File Offset: 0x0006FF54
		public unsafe float effectVolumesBlendAdjusted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70223, XrefRangeEnd = 70224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_get_effectVolumesBlendAdjusted_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00071D90 File Offset: 0x0006FF90
		public unsafe string SharedInstanceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_get_SharedInstanceID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00071DC8 File Offset: 0x0006FFC8
		public unsafe bool WillItBlend
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70224, XrefRangeEnd = 70231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_get_WillItBlend_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00071E04 File Offset: 0x00070004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70231, XrefRangeEnd = 70234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NewSharedInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_NewSharedInstanceID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00071E38 File Offset: 0x00070038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70234, XrefRangeEnd = 70241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportMissingShaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ReportMissingShaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00071E6C File Offset: 0x0007006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70241, XrefRangeEnd = 70248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportNotSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ReportNotSupported_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00071EA0 File Offset: 0x000700A0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 70253, RefRangeEnd = 70265, XrefRangeStart = 70248, XrefRangeEnd = 70253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckShader(Shader s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CheckShader_Private_Boolean_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00071EF0 File Offset: 0x000700F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70265, XrefRangeEnd = 70271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckShaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CheckShaders_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00071F2C File Offset: 0x0007012C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckSupport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CheckSupport_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00071F68 File Offset: 0x00070168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70271, XrefRangeEnd = 70291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00071F9C File Offset: 0x0007019C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70291, XrefRangeEnd = 70303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00071FD0 File Offset: 0x000701D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70303, XrefRangeEnd = 70304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VolumesBlendTo(Texture blendTargetLUT, float blendTimeInSec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendTargetLUT);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendTimeInSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_VolumesBlendTo_Private_Void_Texture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00072020 File Offset: 0x00070220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70304, XrefRangeEnd = 70306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendTo(Texture blendTargetLUT, float blendTimeInSec, Action onFinishBlend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendTargetLUT);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendTimeInSec;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishBlend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_BlendTo_Public_Void_Texture_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00072084 File Offset: 0x00070284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70317, RefRangeEnd = 70319, XrefRangeStart = 70306, XrefRangeEnd = 70317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CheckCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000720B8 File Offset: 0x000702B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70319, XrefRangeEnd = 70325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000720EC File Offset: 0x000702EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70325, XrefRangeEnd = 70380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00072120 File Offset: 0x00070320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70386, RefRangeEnd = 70388, XrefRangeStart = 70380, XrefRangeEnd = 70386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVolume(AmplifyColorVolumeBase volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_EnterVolume_Public_Void_AmplifyColorVolumeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00072164 File Offset: 0x00070364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70394, RefRangeEnd = 70396, XrefRangeStart = 70388, XrefRangeEnd = 70394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVolume(AmplifyColorVolumeBase volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ExitVolume_Public_Void_AmplifyColorVolumeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000721A8 File Offset: 0x000703A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70489, RefRangeEnd = 70490, XrefRangeStart = 70396, XrefRangeEnd = 70489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_UpdateVolumes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000721DC File Offset: 0x000703DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70490, XrefRangeEnd = 70523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupShader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_SetupShader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00072210 File Offset: 0x00070410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70540, RefRangeEnd = 70542, XrefRangeStart = 70523, XrefRangeEnd = 70540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ReleaseMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00072244 File Offset: 0x00070444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70559, RefRangeEnd = 70561, XrefRangeStart = 70542, XrefRangeEnd = 70559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D CreateDefaultLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CreateDefaultLut_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00072284 File Offset: 0x00070484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70581, RefRangeEnd = 70584, XrefRangeStart = 70561, XrefRangeEnd = 70581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D CreateDepthCurveLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CreateDepthCurveLut_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000722C4 File Offset: 0x000704C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70584, XrefRangeEnd = 70599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCurveLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_UpdateDepthCurveLut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000722F8 File Offset: 0x000704F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70628, RefRangeEnd = 70630, XrefRangeStart = 70599, XrefRangeEnd = 70628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUpdateDepthCurveLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CheckUpdateDepthCurveLut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0007232C File Offset: 0x0007052C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70658, RefRangeEnd = 70659, XrefRangeStart = 70630, XrefRangeEnd = 70658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateHelperTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CreateHelperTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00072360 File Offset: 0x00070560
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 70688, RefRangeEnd = 70696, XrefRangeStart = 70659, XrefRangeEnd = 70688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckMaterialAndShader(Material material, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CheckMaterialAndShader_Private_Boolean_Material_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000723C0 File Offset: 0x000705C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70794, RefRangeEnd = 70796, XrefRangeStart = 70696, XrefRangeEnd = 70794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_CreateMaterials_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000723FC File Offset: 0x000705FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70796, XrefRangeEnd = 70805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialKeyword(string keyword, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_SetMaterialKeyword_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0007244C File Offset: 0x0007064C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 70824, RefRangeEnd = 70837, XrefRangeStart = 70805, XrefRangeEnd = 70824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeRelease<T>(ref T obj) where T : UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.MethodInfoStoreGeneric_SafeRelease_Private_Void_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000724A8 File Offset: 0x000706A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70848, RefRangeEnd = 70850, XrefRangeStart = 70837, XrefRangeEnd = 70848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ReleaseTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000724DC File Offset: 0x000706DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70859, RefRangeEnd = 70861, XrefRangeStart = 70850, XrefRangeEnd = 70859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateLutDimensions(Texture lut)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ValidateLutDimensions_Public_Static_Boolean_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00072520 File Offset: 0x00070720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70861, XrefRangeEnd = 70862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePostEffectParams()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_UpdatePostEffectParams_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00072554 File Offset: 0x00070754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70862, XrefRangeEnd = 70863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeShaderPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_ComputeShaderPass_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00072590 File Offset: 0x00070790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70863, XrefRangeEnd = 71003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000725E4 File Offset: 0x000707E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71003, XrefRangeEnd = 71035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmplifyColorEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002059 File Offset: 0x00000259
		public AmplifyColorEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00072620 File Offset: 0x00070820
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe static int LutSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyColorEffect.NativeFieldInfoPtr_LutSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyColorEffect.NativeFieldInfoPtr_LutSize, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0007263C File Offset: 0x0007083C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002070 File Offset: 0x00000270
		public unsafe static int LutWidth
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyColorEffect.NativeFieldInfoPtr_LutWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyColorEffect.NativeFieldInfoPtr_LutWidth, (void*)(&value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00072658 File Offset: 0x00070858
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000207E File Offset: 0x0000027E
		public unsafe static int LutHeight
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyColorEffect.NativeFieldInfoPtr_LutHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyColorEffect.NativeFieldInfoPtr_LutHeight, (void*)(&value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00072674 File Offset: 0x00070874
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000208C File Offset: 0x0000028C
		public unsafe static int DepthCurveLutRange
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyColorEffect.NativeFieldInfoPtr_DepthCurveLutRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyColorEffect.NativeFieldInfoPtr_DepthCurveLutRange, (void*)(&value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00072690 File Offset: 0x00070890
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000209A File Offset: 0x0000029A
		public unsafe Tonemapping Tonemapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_Tonemapper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_Tonemapper)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000726B8 File Offset: 0x000708B8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000020B5 File Offset: 0x000002B5
		public unsafe float Exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_Exposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_Exposure)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000726E0 File Offset: 0x000708E0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000020D0 File Offset: 0x000002D0
		public unsafe float LinearWhitePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_LinearWhitePoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_LinearWhitePoint)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00072708 File Offset: 0x00070908
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000020EB File Offset: 0x000002EB
		public unsafe bool ApplyDithering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_ApplyDithering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_ApplyDithering)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00072730 File Offset: 0x00070930
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002106 File Offset: 0x00000306
		public unsafe Quality QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00072758 File Offset: 0x00070958
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002121 File Offset: 0x00000321
		public unsafe float BlendAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_BlendAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_BlendAmount)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00072780 File Offset: 0x00070980
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000213C File Offset: 0x0000033C
		public unsafe Texture LutTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_LutTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_LutTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000727B0 File Offset: 0x000709B0
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000215B File Offset: 0x0000035B
		public unsafe Texture LutBlendTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_LutBlendTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_LutBlendTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000727E0 File Offset: 0x000709E0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000217A File Offset: 0x0000037A
		public unsafe Texture MaskTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_MaskTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_MaskTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00072810 File Offset: 0x00070A10
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002199 File Offset: 0x00000399
		public unsafe bool UseDepthMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_UseDepthMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_UseDepthMask)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00072838 File Offset: 0x00070A38
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000021B4 File Offset: 0x000003B4
		public unsafe AnimationCurve DepthMaskCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_DepthMaskCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_DepthMaskCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00072868 File Offset: 0x00070A68
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000021D3 File Offset: 0x000003D3
		public unsafe bool UseVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_UseVolumes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_UseVolumes)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00072890 File Offset: 0x00070A90
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021EE File Offset: 0x000003EE
		public unsafe float ExitVolumeBlendTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_ExitVolumeBlendTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_ExitVolumeBlendTime)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000728B8 File Offset: 0x00070AB8
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002209 File Offset: 0x00000409
		public unsafe Transform TriggerVolumeProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_TriggerVolumeProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_TriggerVolumeProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000728E8 File Offset: 0x00070AE8
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002228 File Offset: 0x00000428
		public unsafe LayerMask VolumeCollisionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_VolumeCollisionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_VolumeCollisionMask)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00072910 File Offset: 0x00070B10
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002243 File Offset: 0x00000443
		public unsafe Camera ownerCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_ownerCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_ownerCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00072940 File Offset: 0x00070B40
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002262 File Offset: 0x00000462
		public unsafe Shader shaderBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00072970 File Offset: 0x00070B70
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002281 File Offset: 0x00000481
		public unsafe Shader shaderBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000729A0 File Offset: 0x00070BA0
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000022A0 File Offset: 0x000004A0
		public unsafe Shader shaderBlendCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderBlendCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderBlendCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000729D0 File Offset: 0x00070BD0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000022BF File Offset: 0x000004BF
		public unsafe Shader shaderMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00072A00 File Offset: 0x00070C00
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000022DE File Offset: 0x000004DE
		public unsafe Shader shaderMaskBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderMaskBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderMaskBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00072A30 File Offset: 0x00070C30
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000022FD File Offset: 0x000004FD
		public unsafe Shader shaderDepthMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderDepthMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderDepthMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00072A60 File Offset: 0x00070C60
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000231C File Offset: 0x0000051C
		public unsafe Shader shaderDepthMaskBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderDepthMaskBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderDepthMaskBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00072A90 File Offset: 0x00070C90
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe Shader shaderProcessOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderProcessOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_shaderProcessOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00072AC0 File Offset: 0x00070CC0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000235A File Offset: 0x0000055A
		public unsafe RenderTexture blendCacheLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendCacheLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendCacheLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00072AF0 File Offset: 0x00070CF0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe Texture2D defaultLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_defaultLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_defaultLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00072B20 File Offset: 0x00070D20
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002398 File Offset: 0x00000598
		public unsafe Texture2D depthCurveLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_depthCurveLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_depthCurveLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00072B50 File Offset: 0x00070D50
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe Il2CppStructArray<Color32> depthCurveColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_depthCurveColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_depthCurveColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00072B80 File Offset: 0x00070D80
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000023D6 File Offset: 0x000005D6
		public unsafe ColorSpace colorSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_colorSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_colorSpace)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00072BA8 File Offset: 0x00070DA8
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000023F1 File Offset: 0x000005F1
		public unsafe Quality qualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_qualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_qualityLevel)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00072BD0 File Offset: 0x00070DD0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000240C File Offset: 0x0000060C
		public unsafe Material materialBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00072C00 File Offset: 0x00070E00
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000242B File Offset: 0x0000062B
		public unsafe Material materialBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00072C30 File Offset: 0x00070E30
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000244A File Offset: 0x0000064A
		public unsafe Material materialBlendCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialBlendCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialBlendCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00072C60 File Offset: 0x00070E60
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002469 File Offset: 0x00000669
		public unsafe Material materialMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00072C90 File Offset: 0x00070E90
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002488 File Offset: 0x00000688
		public unsafe Material materialMaskBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialMaskBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialMaskBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00072CC0 File Offset: 0x00070EC0
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000024A7 File Offset: 0x000006A7
		public unsafe Material materialDepthMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialDepthMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialDepthMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00072CF0 File Offset: 0x00070EF0
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000024C6 File Offset: 0x000006C6
		public unsafe Material materialDepthMaskBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialDepthMaskBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialDepthMaskBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00072D20 File Offset: 0x00070F20
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000024E5 File Offset: 0x000006E5
		public unsafe Material materialProcessOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialProcessOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_materialProcessOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00072D50 File Offset: 0x00070F50
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002504 File Offset: 0x00000704
		public unsafe bool blending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blending)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00072D78 File Offset: 0x00070F78
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000251F File Offset: 0x0000071F
		public unsafe float blendingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendingTime)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00072DA0 File Offset: 0x00070FA0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe float blendingTimeCountdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendingTimeCountdown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendingTimeCountdown)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00072DC8 File Offset: 0x00070FC8
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002555 File Offset: 0x00000755
		public unsafe Action onFinishBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_onFinishBlend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_onFinishBlend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00072DF8 File Offset: 0x00070FF8
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002574 File Offset: 0x00000774
		public unsafe AnimationCurve prevDepthMaskCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_prevDepthMaskCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_prevDepthMaskCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00072E28 File Offset: 0x00071028
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002593 File Offset: 0x00000793
		public unsafe bool volumesBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlending)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00072E50 File Offset: 0x00071050
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000025AE File Offset: 0x000007AE
		public unsafe float volumesBlendingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendingTime)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00072E78 File Offset: 0x00071078
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000025C9 File Offset: 0x000007C9
		public unsafe float volumesBlendingTimeCountdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendingTimeCountdown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendingTimeCountdown)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00072EA0 File Offset: 0x000710A0
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000025E4 File Offset: 0x000007E4
		public unsafe Texture volumesLutBlendTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesLutBlendTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesLutBlendTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00072ED0 File Offset: 0x000710D0
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002603 File Offset: 0x00000803
		public unsafe float volumesBlendAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_volumesBlendAmount)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00072EF8 File Offset: 0x000710F8
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000261E File Offset: 0x0000081E
		public unsafe Texture worldLUT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_worldLUT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_worldLUT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00072F28 File Offset: 0x00071128
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000263D File Offset: 0x0000083D
		public unsafe AmplifyColorVolumeBase currentVolumeLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_currentVolumeLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmplifyColorVolumeBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_currentVolumeLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00072F58 File Offset: 0x00071158
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000265C File Offset: 0x0000085C
		public unsafe RenderTexture midBlendLUT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_midBlendLUT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_midBlendLUT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00072F88 File Offset: 0x00071188
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe bool blendingFromMidBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendingFromMidBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendingFromMidBlend)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00072FB0 File Offset: 0x000711B0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002696 File Offset: 0x00000896
		public unsafe VolumeEffect worldVolumeEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_worldVolumeEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_worldVolumeEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00072FE0 File Offset: 0x000711E0
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000026B5 File Offset: 0x000008B5
		public unsafe VolumeEffect currentVolumeEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_currentVolumeEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_currentVolumeEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00073010 File Offset: 0x00071210
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000026D4 File Offset: 0x000008D4
		public unsafe VolumeEffect blendVolumeEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendVolumeEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendVolumeEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00073040 File Offset: 0x00071240
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000026F3 File Offset: 0x000008F3
		public unsafe float worldExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_worldExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_worldExposure)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00073068 File Offset: 0x00071268
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000270E File Offset: 0x0000090E
		public unsafe float currentExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_currentExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_currentExposure)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00073090 File Offset: 0x00071290
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002729 File Offset: 0x00000929
		public unsafe float blendExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_blendExposure)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000730B8 File Offset: 0x000712B8
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002744 File Offset: 0x00000944
		public unsafe float effectVolumesBlendAdjust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_effectVolumesBlendAdjust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_effectVolumesBlendAdjust)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000730E0 File Offset: 0x000712E0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000275F File Offset: 0x0000095F
		public unsafe List<AmplifyColorVolumeBase> enteredVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_enteredVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AmplifyColorVolumeBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_enteredVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00073110 File Offset: 0x00071310
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000277E File Offset: 0x0000097E
		public unsafe AmplifyColorTriggerProxyBase actualTriggerProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_actualTriggerProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmplifyColorTriggerProxyBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_actualTriggerProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00073140 File Offset: 0x00071340
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe VolumeEffectFlags EffectFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_EffectFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_EffectFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00073170 File Offset: 0x00071370
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe string sharedInstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_sharedInstanceID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_sharedInstanceID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00073198 File Offset: 0x00071398
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe bool silentError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_silentError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorEffect.NativeFieldInfoPtr_silentError)) = value;
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_LutSize;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_LutWidth;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_LutHeight;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_DepthCurveLutRange;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_Tonemapper;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_Exposure;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_LinearWhitePoint;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_ApplyDithering;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_BlendAmount;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_LutTexture;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_LutBlendTexture;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_MaskTexture;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_UseDepthMask;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_DepthMaskCurve;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_UseVolumes;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_ExitVolumeBlendTime;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_TriggerVolumeProxy;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCollisionMask;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_ownerCamera;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_shaderBase;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_shaderBlend;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_shaderBlendCache;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_shaderMask;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_shaderMaskBlend;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_shaderDepthMask;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_shaderDepthMaskBlend;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_shaderProcessOnly;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_blendCacheLut;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_defaultLut;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_depthCurveLut;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_depthCurveColors;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_colorSpace;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_qualityLevel;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_materialBase;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_materialBlend;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_materialBlendCache;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_materialMask;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_materialMaskBlend;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_materialDepthMask;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_materialDepthMaskBlend;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_materialProcessOnly;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_blending;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_blendingTime;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_blendingTimeCountdown;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_onFinishBlend;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_prevDepthMaskCurve;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_volumesBlending;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_volumesBlendingTime;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_volumesBlendingTimeCountdown;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_volumesLutBlendTexture;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_volumesBlendAmount;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_worldLUT;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_currentVolumeLut;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_midBlendLUT;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_blendingFromMidBlend;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_worldVolumeEffects;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_currentVolumeEffects;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_blendVolumeEffects;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_worldExposure;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_currentExposure;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_blendExposure;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_effectVolumesBlendAdjust;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_enteredVolumes;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_actualTriggerProxy;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_EffectFlags;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_sharedInstanceID;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_silentError;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultLut_Public_get_Texture2D_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_effectVolumesBlendAdjusted_Private_get_Single_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedInstanceID_Public_get_String_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_WillItBlend_Public_get_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_NewSharedInstanceID_Public_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ReportMissingShaders_Private_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ReportNotSupported_Private_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_CheckShader_Private_Boolean_Shader_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_CheckShaders_Private_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_CheckSupport_Private_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_VolumesBlendTo_Private_Void_Texture_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_BlendTo_Public_Void_Texture_Single_Action_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_CheckCamera_Private_Void_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_EnterVolume_Public_Void_AmplifyColorVolumeBase_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_ExitVolume_Public_Void_AmplifyColorVolumeBase_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumes_Private_Void_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_SetupShader_Private_Void_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMaterials_Private_Void_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultLut_Private_Texture2D_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_CreateDepthCurveLut_Private_Texture2D_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCurveLut_Private_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_CheckUpdateDepthCurveLut_Private_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_CreateHelperTextures_Private_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_CheckMaterialAndShader_Private_Boolean_Material_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterials_Private_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialKeyword_Private_Void_String_Boolean_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_SafeRelease_Private_Void_byref_T_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTextures_Private_Void_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLutDimensions_Public_Static_Boolean_Texture_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePostEffectParams_Private_Void_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_ComputeShaderPass_Private_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A1 RID: 1953
		private sealed class MethodInfoStoreGeneric_SafeRelease_Private_Void_byref_T_0<T>
		{
			// Token: 0x04007CE0 RID: 31968
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AmplifyColorEffect.NativeMethodInfoPtr_SafeRelease_Private_Void_byref_T_0, Il2CppClassPointerStore<AmplifyColorEffect>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
