using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AE RID: 174
	public class VolumetricLightBeamSD : VolumetricLightBeamAbstractBase
	{
		// Token: 0x06000C28 RID: 3112 RVA: 0x000977A8 File Offset: 0x000959A8
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeamSD()
		{
			Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeamSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr);
			VolumetricLightBeamSD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "ClassName");
			VolumetricLightBeamSD.NativeFieldInfoPtr_colorFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "colorFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "colorMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "color");
			VolumetricLightBeamSD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "colorGradient");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityModeAdvanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityModeAdvanced");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityInside");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityOutside");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityMultiplier");
			VolumetricLightBeamSD.NativeFieldInfoPtr_hdrpExposureWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "hdrpExposureWeight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "blendingMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "spotAngleFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "spotAngle");
			VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "spotAngleMultiplier");
			VolumetricLightBeamSD.NativeFieldInfoPtr_coneRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "coneRadiusStart");
			VolumetricLightBeamSD.NativeFieldInfoPtr_shaderAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "shaderAccuracy");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomMeshType");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomCustomSides");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomCustomSegments");
			VolumetricLightBeamSD.NativeFieldInfoPtr_skewingLocalForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "skewingLocalForwardDirection");
			VolumetricLightBeamSD.NativeFieldInfoPtr_clippingPlaneTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "clippingPlaneTransform");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomCap");
			VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationEquation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "attenuationEquation");
			VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationCustomBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "attenuationCustomBlending");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffStart");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffEnd");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffEndFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffEndMultiplier");
			VolumetricLightBeamSD.NativeFieldInfoPtr_depthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "depthBlendDistance");
			VolumetricLightBeamSD.NativeFieldInfoPtr_cameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "cameraClippingDistance");
			VolumetricLightBeamSD.NativeFieldInfoPtr_glareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "glareFrontal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_glareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "glareBehind");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fresnelPow");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseIntensity");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseScaleUseGlobal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseScaleLocal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseVelocityUseGlobal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseVelocityLocal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "dimensions");
			VolumetricLightBeamSD.NativeFieldInfoPtr_tiltFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "tiltFactor");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_INTERNAL_DynamicOcclusionMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_INTERNAL_DynamicOcclusionMode_Runtime");
			VolumetricLightBeamSD.NativeFieldInfoPtr_onWillCameraRenderThisBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "onWillCameraRenderThisBeam");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_OnBeamGeometryInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_OnBeamGeometryInitialized");
			VolumetricLightBeamSD.NativeFieldInfoPtr__TrackChangesDuringPlaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_TrackChangesDuringPlaytime");
			VolumetricLightBeamSD.NativeFieldInfoPtr__SortingLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_SortingLayerID");
			VolumetricLightBeamSD.NativeFieldInfoPtr__SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_SortingOrder");
			VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_FadeOutBegin");
			VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_FadeOutEnd");
			VolumetricLightBeamSD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "<_INTERNAL_InstancedMaterialGroupID>k__BackingField");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_BeamGeom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_BeamGeom");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_CoPlaytimeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_CoPlaytimeUpdate");
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_usedColorMode_Public_get_ColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664789);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664790);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664791);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664792);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664793);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664794);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664795);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664796);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664797);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664798);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideAndOutsideIntensity_Public_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664799);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664800);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664801);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664802);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664803);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664804);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664805);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionLocal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664806);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionGlobal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664807);
			VolumetricLightBeamSD.NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664808);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664809);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664810);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664811);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664812);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_skewingLocalForwardDirectionNormalized_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664813);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_canHaveMeshSkewing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664814);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_hasMeshSkewing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664815);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_additionalClippingPlane_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664816);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664817);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664818);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664819);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664820);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664821);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664822);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664823);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664824);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664825);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664826);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664827);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664828);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664829);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664830);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664831);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664832);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664833);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isTilted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664834);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664835);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664836);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664837);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664838);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664839);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664840);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664841);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664842);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664843);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664844);
			VolumetricLightBeamSD.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664845);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664846);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664847);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664848);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664849);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664850);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664851);
			VolumetricLightBeamSD.NativeMethodInfoPtr_ComputeRaycastGlobalVector_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664852);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664853);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalUp_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664854);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664855);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664856);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664857);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Runtime_Public_get_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664858);
			VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664859);
			VolumetricLightBeamSD.NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664860);
			VolumetricLightBeamSD.NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664861);
			VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664862);
			VolumetricLightBeamSD.NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664863);
			VolumetricLightBeamSD.NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664864);
			VolumetricLightBeamSD.NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664865);
			VolumetricLightBeamSD.NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664866);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664867);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664868);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshStats_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664869);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664870);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664871);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664872);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664873);
			VolumetricLightBeamSD.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664874);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664875);
			VolumetricLightBeamSD.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664876);
			VolumetricLightBeamSD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664877);
			VolumetricLightBeamSD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664878);
			VolumetricLightBeamSD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664879);
			VolumetricLightBeamSD.NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664880);
			VolumetricLightBeamSD.NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664881);
			VolumetricLightBeamSD.NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664882);
			VolumetricLightBeamSD.NativeMethodInfoPtr_ClampProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664883);
			VolumetricLightBeamSD.NativeMethodInfoPtr_ValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664884);
			VolumetricLightBeamSD.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664885);
			VolumetricLightBeamSD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664886);
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000983B8 File Offset: 0x000965B8
		public unsafe ColorMode usedColorMode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 80926, RefRangeEnd = 80933, XrefRangeStart = 80926, XrefRangeEnd = 80933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_usedColorMode_Public_get_ColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000983F4 File Offset: 0x000965F4
		public unsafe bool useColorFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83971, XrefRangeEnd = 83972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00098430 File Offset: 0x00096630
		public unsafe bool useColorTemperatureFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83972, XrefRangeEnd = 83978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0009846C File Offset: 0x0009666C
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x000984A8 File Offset: 0x000966A8
		public unsafe float alphaInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83978, RefRangeEnd = 83980, XrefRangeStart = 83978, XrefRangeEnd = 83978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000984E8 File Offset: 0x000966E8
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00098524 File Offset: 0x00096724
		public unsafe float alphaOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00098564 File Offset: 0x00096764
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x000985A0 File Offset: 0x000967A0
		public unsafe float intensityGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000985E0 File Offset: 0x000967E0
		public unsafe bool useIntensityFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83980, XrefRangeEnd = 83981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0009861C File Offset: 0x0009681C
		[CallerCount(0)]
		public unsafe void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &inside;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outside;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideAndOutsideIntensity_Public_Void_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00098668 File Offset: 0x00096868
		public unsafe bool useSpotAngleFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83981, XrefRangeEnd = 83982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x000986A4 File Offset: 0x000968A4
		public unsafe float coneAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83982, XrefRangeEnd = 83984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x000986E0 File Offset: 0x000968E0
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0009871C File Offset: 0x0009691C
		public unsafe float coneRadiusEnd
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83984, XrefRangeEnd = 83985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83985, XrefRangeEnd = 83986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0009875C File Offset: 0x0009695C
		public unsafe float coneVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83986, XrefRangeEnd = 83987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00098798 File Offset: 0x00096998
		public unsafe float coneApexOffsetZ
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 83988, RefRangeEnd = 83994, XrefRangeStart = 83987, XrefRangeEnd = 83988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x000987D4 File Offset: 0x000969D4
		public unsafe Vector3 coneApexPositionLocal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83994, XrefRangeEnd = 83995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionLocal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00098810 File Offset: 0x00096A10
		public unsafe Vector3 coneApexPositionGlobal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83995, XrefRangeEnd = 83999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionGlobal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0009884C File Offset: 0x00096A4C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsScalable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00098894 File Offset: 0x00096A94
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x000988D0 File Offset: 0x00096AD0
		public unsafe int geomSides
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83999, XrefRangeEnd = 84017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00098910 File Offset: 0x00096B10
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x0009894C File Offset: 0x00096B4C
		public unsafe int geomSegments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84017, XrefRangeEnd = 84035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0009898C File Offset: 0x00096B8C
		public unsafe Vector3 skewingLocalForwardDirectionNormalized
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 84040, RefRangeEnd = 84047, XrefRangeStart = 84035, XrefRangeEnd = 84040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_skewingLocalForwardDirectionNormalized_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000989C8 File Offset: 0x00096BC8
		public unsafe bool canHaveMeshSkewing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_canHaveMeshSkewing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00098A04 File Offset: 0x00096C04
		public unsafe bool hasMeshSkewing
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 84052, RefRangeEnd = 84060, XrefRangeStart = 84047, XrefRangeEnd = 84052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_hasMeshSkewing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00098A40 File Offset: 0x00096C40
		public unsafe Vector4 additionalClippingPlane
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84060, XrefRangeEnd = 84066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_additionalClippingPlane_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00098A7C File Offset: 0x00096C7C
		public unsafe float attenuationLerpLinearQuad
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00098AB8 File Offset: 0x00096CB8
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00098AF4 File Offset: 0x00096CF4
		public unsafe float fadeStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00098B34 File Offset: 0x00096D34
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00098B70 File Offset: 0x00096D70
		public unsafe float fadeEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00098BB0 File Offset: 0x00096DB0
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00098BEC File Offset: 0x00096DEC
		public unsafe bool fadeEndFromLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00098C2C File Offset: 0x00096E2C
		public unsafe bool useFallOffEndFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84066, XrefRangeEnd = 84067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00098C68 File Offset: 0x00096E68
		public unsafe float maxGeometryDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00098CA4 File Offset: 0x00096EA4
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84067, RefRangeEnd = 84069, XrefRangeStart = 84067, XrefRangeEnd = 84067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00098CE0 File Offset: 0x00096EE0
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00098D1C File Offset: 0x00096F1C
		public unsafe bool noiseEnabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84067, RefRangeEnd = 84069, XrefRangeStart = 84067, XrefRangeEnd = 84069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00098D5C File Offset: 0x00096F5C
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00098D98 File Offset: 0x00096F98
		public unsafe float fadeOutBegin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84069, XrefRangeEnd = 84070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00098DD8 File Offset: 0x00096FD8
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00098E14 File Offset: 0x00097014
		public unsafe float fadeOutEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84070, XrefRangeEnd = 84071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00098E54 File Offset: 0x00097054
		public unsafe bool isFadeOutEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00098E90 File Offset: 0x00097090
		public unsafe bool isTilted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84071, XrefRangeEnd = 84073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isTilted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00098ECC File Offset: 0x000970CC
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00098F08 File Offset: 0x00097108
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84073, XrefRangeEnd = 84078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00098F48 File Offset: 0x00097148
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00098F80 File Offset: 0x00097180
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84078, XrefRangeEnd = 84079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84079, XrefRangeEnd = 84085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00098FC4 File Offset: 0x000971C4
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00099000 File Offset: 0x00097200
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84085, XrefRangeEnd = 84090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00099040 File Offset: 0x00097240
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x0009907C File Offset: 0x0009727C
		public unsafe bool trackChangesDuringPlaytime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84090, XrefRangeEnd = 84091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000990BC File Offset: 0x000972BC
		public unsafe bool isCurrentlyTrackingChanges
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000990F8 File Offset: 0x000972F8
		[CallerCount(0)]
		public unsafe override BeamGeometryAbstractBase GetBeamGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BeamGeometryAbstractBase>(intPtr3) : null;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00099144 File Offset: 0x00097344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84091, XrefRangeEnd = 84092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetBeamGeometryNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00099180 File Offset: 0x00097380
		public unsafe int blendingModeAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84092, XrefRangeEnd = 84103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000991BC File Offset: 0x000973BC
		public unsafe Quaternion beamInternalLocalRotation
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 84105, RefRangeEnd = 84110, XrefRangeStart = 84103, XrefRangeEnd = 84105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000991F8 File Offset: 0x000973F8
		public unsafe Vector3 beamLocalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84110, XrefRangeEnd = 84112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00099234 File Offset: 0x00097434
		public unsafe Vector3 beamGlobalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84112, XrefRangeEnd = 84119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00099270 File Offset: 0x00097470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84119, XrefRangeEnd = 84121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetLossyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x000992B8 File Offset: 0x000974B8
		public unsafe float raycastDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84124, RefRangeEnd = 84126, XrefRangeStart = 84121, XrefRangeEnd = 84124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000992F4 File Offset: 0x000974F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 84130, RefRangeEnd = 84136, XrefRangeStart = 84126, XrefRangeEnd = 84130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ComputeRaycastGlobalVector(Vector3 localVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref localVec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_ComputeRaycastGlobalVector_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00099340 File Offset: 0x00097540
		public unsafe Vector3 raycastGlobalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84136, XrefRangeEnd = 84142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0009937C File Offset: 0x0009757C
		public unsafe Vector3 raycastGlobalUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84142, XrefRangeEnd = 84145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalUp_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000993B8 File Offset: 0x000975B8
		public unsafe Vector3 raycastGlobalRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84145, XrefRangeEnd = 84148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000993F4 File Offset: 0x000975F4
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00099430 File Offset: 0x00097630
		public unsafe MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84148, XrefRangeEnd = 84149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00099470 File Offset: 0x00097670
		public unsafe MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84149, XrefRangeEnd = 84150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Runtime_Public_get_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000994AC File Offset: 0x000976AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 84160, RefRangeEnd = 84168, XrefRangeStart = 84150, XrefRangeEnd = 84160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00099500 File Offset: 0x00097700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84168, XrefRangeEnd = 84172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onWillCameraRenderThisBeam(VolumetricLightBeamSD.OnWillCameraRenderCB value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00099544 File Offset: 0x00097744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84172, XrefRangeEnd = 84176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onWillCameraRenderThisBeam(VolumetricLightBeamSD.OnWillCameraRenderCB value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00099588 File Offset: 0x00097788
		[CallerCount(0)]
		public unsafe void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000995CC File Offset: 0x000977CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84176, XrefRangeEnd = 84187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterOnBeamGeometryInitializedCallback(VolumetricLightBeamSD.OnBeamGeometryInitialized cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00099610 File Offset: 0x00097810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84187, XrefRangeEnd = 84188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallOnBeamGeometryInitializedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00099644 File Offset: 0x00097844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84195, RefRangeEnd = 84197, XrefRangeStart = 84188, XrefRangeEnd = 84195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFadeOutValue(ref float propToChange, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &propToChange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00099690 File Offset: 0x00097890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84197, XrefRangeEnd = 84202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFadeOutStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000996C4 File Offset: 0x000978C4
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00099700 File Offset: 0x00097900
		public unsafe uint _INTERNAL_InstancedMaterialGroupID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00099740 File Offset: 0x00097940
		public unsafe string meshStats
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84202, XrefRangeEnd = 84215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshStats_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00099778 File Offset: 0x00097978
		public unsafe int meshVerticesCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84215, XrefRangeEnd = 84223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000997B4 File Offset: 0x000979B4
		public unsafe int meshTrianglesCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84223, XrefRangeEnd = 84231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000997F0 File Offset: 0x000979F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84231, XrefRangeEnd = 84234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInsideBeamFactor(Vector3 posWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0009983C File Offset: 0x00097A3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84242, RefRangeEnd = 84244, XrefRangeStart = 84234, XrefRangeEnd = 84242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posOS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00099888 File Offset: 0x00097A88
		[CallerCount(0)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000998BC File Offset: 0x00097ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84244, XrefRangeEnd = 84266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GenerateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000998F8 File Offset: 0x00097AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84266, XrefRangeEnd = 84273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateAfterManualPropertyChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00099934 File Offset: 0x00097B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84273, XrefRangeEnd = 84274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00099968 File Offset: 0x00097B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84274, XrefRangeEnd = 84282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0009999C File Offset: 0x00097B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84282, XrefRangeEnd = 84291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000999D0 File Offset: 0x00097BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84302, RefRangeEnd = 84304, XrefRangeStart = 84291, XrefRangeEnd = 84302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPlaytimeUpdateIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00099A04 File Offset: 0x00097C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84304, XrefRangeEnd = 84309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoPlaytimeUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00099A44 File Offset: 0x00097C44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84345, RefRangeEnd = 84348, XrefRangeStart = 84309, XrefRangeEnd = 84345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPropertiesFromAttachedSpotLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00099A78 File Offset: 0x00097C78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84355, RefRangeEnd = 84358, XrefRangeStart = 84348, XrefRangeEnd = 84355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_ClampProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00099AAC File Offset: 0x00097CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84358, XrefRangeEnd = 84360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_ValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00099AE0 File Offset: 0x00097CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84360, XrefRangeEnd = 84365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00099B2C File Offset: 0x00097D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84365, XrefRangeEnd = 84376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightBeamSD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0000804E File Offset: 0x0000624E
		public VolumetricLightBeamSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00099B68 File Offset: 0x00097D68
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00008057 File Offset: 0x00006257
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricLightBeamSD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricLightBeamSD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00099B88 File Offset: 0x00097D88
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00008069 File Offset: 0x00006269
		public unsafe bool colorFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorFromLight)) = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00099BB0 File Offset: 0x00097DB0
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00008084 File Offset: 0x00006284
		public unsafe ColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00099BD8 File Offset: 0x00097DD8
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x0000809F File Offset: 0x0000629F
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00099C00 File Offset: 0x00097E00
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000080BA File Offset: 0x000062BA
		public unsafe Gradient colorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00099C30 File Offset: 0x00097E30
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000080D9 File Offset: 0x000062D9
		public unsafe bool intensityFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityFromLight)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00099C58 File Offset: 0x00097E58
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000080F4 File Offset: 0x000062F4
		public unsafe bool intensityModeAdvanced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityModeAdvanced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityModeAdvanced)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00099C80 File Offset: 0x00097E80
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0000810F File Offset: 0x0000630F
		public unsafe float intensityInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityInside)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00099CA8 File Offset: 0x00097EA8
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0000812A File Offset: 0x0000632A
		public unsafe float intensityOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityOutside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityOutside)) = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00099CD0 File Offset: 0x00097ED0
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00008145 File Offset: 0x00006345
		public unsafe float intensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityMultiplier)) = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00099CF8 File Offset: 0x00097EF8
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00008160 File Offset: 0x00006360
		public unsafe float hdrpExposureWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_hdrpExposureWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_hdrpExposureWeight)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00099D20 File Offset: 0x00097F20
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x0000817B File Offset: 0x0000637B
		public unsafe BlendingMode blendingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_blendingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_blendingMode)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00099D48 File Offset: 0x00097F48
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00008196 File Offset: 0x00006396
		public unsafe bool spotAngleFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleFromLight)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00099D70 File Offset: 0x00097F70
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000081B1 File Offset: 0x000063B1
		public unsafe float spotAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngle)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00099D98 File Offset: 0x00097F98
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x000081CC File Offset: 0x000063CC
		public unsafe float spotAngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleMultiplier)) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00099DC0 File Offset: 0x00097FC0
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x000081E7 File Offset: 0x000063E7
		public unsafe float coneRadiusStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_coneRadiusStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_coneRadiusStart)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00099DE8 File Offset: 0x00097FE8
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00008202 File Offset: 0x00006402
		public unsafe ShaderAccuracy shaderAccuracy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_shaderAccuracy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_shaderAccuracy)) = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00099E10 File Offset: 0x00098010
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x0000821D File Offset: 0x0000641D
		public unsafe MeshType geomMeshType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomMeshType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomMeshType)) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00099E38 File Offset: 0x00098038
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00008238 File Offset: 0x00006438
		public unsafe int geomCustomSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSides)) = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00099E60 File Offset: 0x00098060
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00008253 File Offset: 0x00006453
		public unsafe int geomCustomSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSegments)) = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00099E88 File Offset: 0x00098088
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x0000826E File Offset: 0x0000646E
		public unsafe Vector3 skewingLocalForwardDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_skewingLocalForwardDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_skewingLocalForwardDirection)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00099EB0 File Offset: 0x000980B0
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00008289 File Offset: 0x00006489
		public unsafe Transform clippingPlaneTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_clippingPlaneTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_clippingPlaneTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00099EE0 File Offset: 0x000980E0
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x000082A8 File Offset: 0x000064A8
		public unsafe bool geomCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCap)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00099F08 File Offset: 0x00098108
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x000082C3 File Offset: 0x000064C3
		public unsafe AttenuationEquation attenuationEquation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationEquation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationEquation)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00099F30 File Offset: 0x00098130
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x000082DE File Offset: 0x000064DE
		public unsafe float attenuationCustomBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationCustomBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationCustomBlending)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00099F58 File Offset: 0x00098158
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x000082F9 File Offset: 0x000064F9
		public unsafe float fallOffStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffStart)) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00099F80 File Offset: 0x00098180
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00008314 File Offset: 0x00006514
		public unsafe float fallOffEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEnd)) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00099FA8 File Offset: 0x000981A8
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x0000832F File Offset: 0x0000652F
		public unsafe bool fallOffEndFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndFromLight)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00099FD0 File Offset: 0x000981D0
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0000834A File Offset: 0x0000654A
		public unsafe float fallOffEndMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndMultiplier)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00099FF8 File Offset: 0x000981F8
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00008365 File Offset: 0x00006565
		public unsafe float depthBlendDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_depthBlendDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_depthBlendDistance)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0009A020 File Offset: 0x00098220
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00008380 File Offset: 0x00006580
		public unsafe float cameraClippingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_cameraClippingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_cameraClippingDistance)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0009A048 File Offset: 0x00098248
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x0000839B File Offset: 0x0000659B
		public unsafe float glareFrontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareFrontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareFrontal)) = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0009A070 File Offset: 0x00098270
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x000083B6 File Offset: 0x000065B6
		public unsafe float glareBehind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareBehind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareBehind)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0009A098 File Offset: 0x00098298
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x000083D1 File Offset: 0x000065D1
		public unsafe float fresnelPow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fresnelPow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fresnelPow)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0009A0C0 File Offset: 0x000982C0
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x000083EC File Offset: 0x000065EC
		public unsafe NoiseMode noiseMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseMode)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0009A0E8 File Offset: 0x000982E8
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00008407 File Offset: 0x00006607
		public unsafe float noiseIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseIntensity)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0009A110 File Offset: 0x00098310
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00008422 File Offset: 0x00006622
		public unsafe bool noiseScaleUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleUseGlobal)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0009A138 File Offset: 0x00098338
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x0000843D File Offset: 0x0000663D
		public unsafe float noiseScaleLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleLocal)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0009A160 File Offset: 0x00098360
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00008458 File Offset: 0x00006658
		public unsafe bool noiseVelocityUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityUseGlobal)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0009A188 File Offset: 0x00098388
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00008473 File Offset: 0x00006673
		public unsafe Vector3 noiseVelocityLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityLocal)) = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0009A1B0 File Offset: 0x000983B0
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x0000848E File Offset: 0x0000668E
		public unsafe Dimensions dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0009A1D8 File Offset: 0x000983D8
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x000084A9 File Offset: 0x000066A9
		public unsafe Vector2 tiltFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_tiltFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_tiltFactor)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0009A200 File Offset: 0x00098400
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x000084C4 File Offset: 0x000066C4
		public unsafe MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0009A228 File Offset: 0x00098428
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x000084DF File Offset: 0x000066DF
		public unsafe bool m_INTERNAL_DynamicOcclusionMode_Runtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0009A250 File Offset: 0x00098450
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x000084FA File Offset: 0x000066FA
		public unsafe VolumetricLightBeamSD.OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_onWillCameraRenderThisBeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD.OnWillCameraRenderCB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_onWillCameraRenderThisBeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0009A280 File Offset: 0x00098480
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00008519 File Offset: 0x00006719
		public unsafe VolumetricLightBeamSD.OnBeamGeometryInitialized m_OnBeamGeometryInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_OnBeamGeometryInitialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD.OnBeamGeometryInitialized>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_OnBeamGeometryInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0009A2B0 File Offset: 0x000984B0
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00008538 File Offset: 0x00006738
		public unsafe bool _TrackChangesDuringPlaytime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__TrackChangesDuringPlaytime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__TrackChangesDuringPlaytime)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0009A2D8 File Offset: 0x000984D8
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00008553 File Offset: 0x00006753
		public unsafe int _SortingLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingLayerID)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0009A300 File Offset: 0x00098500
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0000856E File Offset: 0x0000676E
		public unsafe int _SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingOrder)) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0009A328 File Offset: 0x00098528
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00008589 File Offset: 0x00006789
		public unsafe float _FadeOutBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutBegin)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0009A350 File Offset: 0x00098550
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x000085A4 File Offset: 0x000067A4
		public unsafe float _FadeOutEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutEnd)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0009A378 File Offset: 0x00098578
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x000085BF File Offset: 0x000067BF
		public unsafe uint __INTERNAL_InstancedMaterialGroupID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0009A3A0 File Offset: 0x000985A0
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x000085DA File Offset: 0x000067DA
		public unsafe BeamGeometrySD m_BeamGeom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_BeamGeom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeamGeometrySD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_BeamGeom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0009A3D0 File Offset: 0x000985D0
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x000085F9 File Offset: 0x000067F9
		public unsafe Coroutine m_CoPlaytimeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_CoPlaytimeUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_CoPlaytimeUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_colorFromLight;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_intensityFromLight;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_intensityModeAdvanced;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_intensityInside;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_intensityOutside;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_hdrpExposureWeight;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_spotAngleFromLight;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_spotAngle;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_spotAngleMultiplier;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr_coneRadiusStart;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr_shaderAccuracy;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr_geomMeshType;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr_geomCustomSides;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_geomCustomSegments;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr_skewingLocalForwardDirection;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr_clippingPlaneTransform;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_geomCap;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_attenuationEquation;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_attenuationCustomBlending;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_fallOffStart;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEnd;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEndFromLight;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEndMultiplier;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_depthBlendDistance;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_cameraClippingDistance;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_glareFrontal;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_glareBehind;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_fresnelPow;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_noiseMode;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr_noiseIntensity;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr_noiseScaleUseGlobal;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_noiseScaleLocal;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_noiseVelocityUseGlobal;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_noiseVelocityLocal;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr_tiltFactor;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr_onWillCameraRenderThisBeam;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_m_OnBeamGeometryInitialized;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr__TrackChangesDuringPlaytime;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr__SortingLayerID;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr__SortingOrder;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr__FadeOutBegin;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeFieldInfoPtr__FadeOutEnd;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeFieldInfoPtr_m_BeamGeom;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeFieldInfoPtr_m_CoPlaytimeUpdate;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_usedColorMode_Public_get_ColorMode_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideAndOutsideIntensity_Public_Void_byref_Single_byref_Single_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexPositionLocal_Public_get_Vector3_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexPositionGlobal_Public_get_Vector3_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_get_skewingLocalForwardDirectionNormalized_Public_get_Vector3_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_get_canHaveMeshSkewing_Public_get_Boolean_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_get_hasMeshSkewing_Public_get_Boolean_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalClippingPlane_Public_get_Vector4_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_isTilted_Public_get_Boolean_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastDistance_Public_get_Single_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRaycastGlobalVector_Private_Vector3_Vector3_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastGlobalForward_Public_get_Vector3_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastGlobalUp_Public_get_Vector3_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastGlobalRight_Public_get_Vector3_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Runtime_Public_get_DynamicOcclusion_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_get_meshStats_Public_get_String_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Private_Void_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_ClampProperties_Private_Void_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_ValidateProperties_Private_Void_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000834 RID: 2100
		public sealed class OnWillCameraRenderCB : MulticastDelegate
		{
			// Token: 0x0600BEFB RID: 48891 RVA: 0x002ED970 File Offset: 0x002EBB70
			// Note: this type is marked as 'beforefieldinit'.
			static OnWillCameraRenderCB()
			{
				Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "OnWillCameraRenderCB");
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664887);
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664888);
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664889);
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664890);
			}

			// Token: 0x0600BEFC RID: 48892 RVA: 0x002ED9E4 File Offset: 0x002EBBE4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83960, RefRangeEnd = 83964, XrefRangeStart = 83956, XrefRangeEnd = 83960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnWillCameraRenderCB(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEFD RID: 48893 RVA: 0x002EDA40 File Offset: 0x002EBC40
			[CallerCount(0)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEFE RID: 48894 RVA: 0x002EDA84 File Offset: 0x002EBC84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BEFF RID: 48895 RVA: 0x002EDAF8 File Offset: 0x002EBCF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF00 RID: 48896 RVA: 0x0005D5C5 File Offset: 0x0005B7C5
			public OnWillCameraRenderCB(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BF01 RID: 48897 RVA: 0x0005D5CE File Offset: 0x0005B7CE
			public static implicit operator VolumetricLightBeamSD.OnWillCameraRenderCB(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<VolumetricLightBeamSD.OnWillCameraRenderCB>(A_0);
			}

			// Token: 0x0600BF02 RID: 48898 RVA: 0x0005D5D6 File Offset: 0x0005B7D6
			public static VolumetricLightBeamSD.OnWillCameraRenderCB operator +(VolumetricLightBeamSD.OnWillCameraRenderCB A_0, VolumetricLightBeamSD.OnWillCameraRenderCB A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VolumetricLightBeamSD.OnWillCameraRenderCB>();
			}

			// Token: 0x0600BF03 RID: 48899 RVA: 0x0005D5E4 File Offset: 0x0005B7E4
			public static VolumetricLightBeamSD.OnWillCameraRenderCB operator -(VolumetricLightBeamSD.OnWillCameraRenderCB A_0, VolumetricLightBeamSD.OnWillCameraRenderCB A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VolumetricLightBeamSD.OnWillCameraRenderCB>();
				}
				return result;
			}

			// Token: 0x04008174 RID: 33140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008175 RID: 33141
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

			// Token: 0x04008176 RID: 33142
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0;

			// Token: 0x04008177 RID: 33143
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000835 RID: 2101
		public sealed class OnBeamGeometryInitialized : MulticastDelegate
		{
			// Token: 0x0600BF04 RID: 48900 RVA: 0x002EDB3C File Offset: 0x002EBD3C
			// Note: this type is marked as 'beforefieldinit'.
			static OnBeamGeometryInitialized()
			{
				Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "OnBeamGeometryInitialized");
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664891);
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664892);
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664893);
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664894);
			}

			// Token: 0x0600BF05 RID: 48901 RVA: 0x002EDBB0 File Offset: 0x002EBDB0
			[CallerCount(1085)]
			[CachedScanResults(RefRangeStart = 21411, RefRangeEnd = 22496, XrefRangeStart = 21411, XrefRangeEnd = 22496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnBeamGeometryInitialized(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF06 RID: 48902 RVA: 0x002EDC0C File Offset: 0x002EBE0C
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF07 RID: 48903 RVA: 0x002EDC40 File Offset: 0x002EBE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BF08 RID: 48904 RVA: 0x002EDCA4 File Offset: 0x002EBEA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF09 RID: 48905 RVA: 0x0005D5F5 File Offset: 0x0005B7F5
			public OnBeamGeometryInitialized(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BF0A RID: 48906 RVA: 0x0005D5FE File Offset: 0x0005B7FE
			public static implicit operator VolumetricLightBeamSD.OnBeamGeometryInitialized(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<VolumetricLightBeamSD.OnBeamGeometryInitialized>(A_0);
			}

			// Token: 0x0600BF0B RID: 48907 RVA: 0x0005D606 File Offset: 0x0005B806
			public static VolumetricLightBeamSD.OnBeamGeometryInitialized operator +(VolumetricLightBeamSD.OnBeamGeometryInitialized A_0, VolumetricLightBeamSD.OnBeamGeometryInitialized A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VolumetricLightBeamSD.OnBeamGeometryInitialized>();
			}

			// Token: 0x0600BF0C RID: 48908 RVA: 0x0005D614 File Offset: 0x0005B814
			public static VolumetricLightBeamSD.OnBeamGeometryInitialized operator -(VolumetricLightBeamSD.OnBeamGeometryInitialized A_0, VolumetricLightBeamSD.OnBeamGeometryInitialized A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VolumetricLightBeamSD.OnBeamGeometryInitialized>();
				}
				return result;
			}

			// Token: 0x04008178 RID: 33144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008179 RID: 33145
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400817A RID: 33146
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400817B RID: 33147
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000836 RID: 2102
		[ObfuscatedName("VLB.VolumetricLightBeamSD+<CoPlaytimeUpdate>d__199")]
		public sealed class _CoPlaytimeUpdate_d__199 : Il2CppSystem.Object
		{
			// Token: 0x0600BF0D RID: 48909 RVA: 0x002EDCE8 File Offset: 0x002EBEE8
			// Note: this type is marked as 'beforefieldinit'.
			static _CoPlaytimeUpdate_d__199()
			{
				Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "<CoPlaytimeUpdate>d__199");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, "<>1__state");
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, "<>2__current");
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, "<>4__this");
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664895);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664896);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664897);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664898);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664899);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664900);
			}

			// Token: 0x0600BF0E RID: 48910 RVA: 0x002EDDC8 File Offset: 0x002EBFC8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoPlaytimeUpdate_d__199(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF0F RID: 48911 RVA: 0x002EDE10 File Offset: 0x002EC010
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF10 RID: 48912 RVA: 0x002EDE44 File Offset: 0x002EC044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83964, XrefRangeEnd = 83966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B66 RID: 15206
			// (get) Token: 0x0600BF11 RID: 48913 RVA: 0x002EDE80 File Offset: 0x002EC080
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF12 RID: 48914 RVA: 0x002EDEC0 File Offset: 0x002EC0C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83966, XrefRangeEnd = 83971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B67 RID: 15207
			// (get) Token: 0x0600BF13 RID: 48915 RVA: 0x002EDEF4 File Offset: 0x002EC0F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF14 RID: 48916 RVA: 0x0005D625 File Offset: 0x0005B825
			public _CoPlaytimeUpdate_d__199(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B63 RID: 15203
			// (get) Token: 0x0600BF15 RID: 48917 RVA: 0x002EDF34 File Offset: 0x002EC134
			// (set) Token: 0x0600BF16 RID: 48918 RVA: 0x0005D62E File Offset: 0x0005B82E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B64 RID: 15204
			// (get) Token: 0x0600BF17 RID: 48919 RVA: 0x002EDF5C File Offset: 0x002EC15C
			// (set) Token: 0x0600BF18 RID: 48920 RVA: 0x0005D649 File Offset: 0x0005B849
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B65 RID: 15205
			// (get) Token: 0x0600BF19 RID: 48921 RVA: 0x002EDF8C File Offset: 0x002EC18C
			// (set) Token: 0x0600BF1A RID: 48922 RVA: 0x0005D668 File Offset: 0x0005B868
			public unsafe VolumetricLightBeamSD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400817C RID: 33148
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400817D RID: 33149
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400817E RID: 33150
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400817F RID: 33151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008180 RID: 33152
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008181 RID: 33153
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008182 RID: 33154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008183 RID: 33155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008184 RID: 33156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
