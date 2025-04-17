using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D9 RID: 217
	public class LiquidVolume : MonoBehaviour
	{
		// Token: 0x06000FB6 RID: 4022 RVA: 0x000A1A88 File Offset: 0x0009FC88
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolume()
		{
			Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr);
			LiquidVolume.NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "FORCE_GLES_COMPATIBILITY");
			LiquidVolume.NativeFieldInfoPtr_onPropertiesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "onPropertiesChanged");
			LiquidVolume.NativeFieldInfoPtr__topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_topology");
			LiquidVolume.NativeFieldInfoPtr__detail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_detail");
			LiquidVolume.NativeFieldInfoPtr__level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_level");
			LiquidVolume.NativeFieldInfoPtr__levelMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_levelMultiplier");
			LiquidVolume.NativeFieldInfoPtr__useLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_useLightColor");
			LiquidVolume.NativeFieldInfoPtr__useLightDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_useLightDirection");
			LiquidVolume.NativeFieldInfoPtr__directionalLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_directionalLight");
			LiquidVolume.NativeFieldInfoPtr__liquidColor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidColor1");
			LiquidVolume.NativeFieldInfoPtr__liquidScale1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidScale1");
			LiquidVolume.NativeFieldInfoPtr__liquidColor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidColor2");
			LiquidVolume.NativeFieldInfoPtr__liquidScale2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidScale2");
			LiquidVolume.NativeFieldInfoPtr__alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_alpha");
			LiquidVolume.NativeFieldInfoPtr__emissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_emissionColor");
			LiquidVolume.NativeFieldInfoPtr__ditherShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_ditherShadows");
			LiquidVolume.NativeFieldInfoPtr__murkiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_murkiness");
			LiquidVolume.NativeFieldInfoPtr__turbulence1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_turbulence1");
			LiquidVolume.NativeFieldInfoPtr__turbulence2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_turbulence2");
			LiquidVolume.NativeFieldInfoPtr__frecuency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_frecuency");
			LiquidVolume.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_speed");
			LiquidVolume.NativeFieldInfoPtr__sparklingIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_sparklingIntensity");
			LiquidVolume.NativeFieldInfoPtr__sparklingAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_sparklingAmount");
			LiquidVolume.NativeFieldInfoPtr__deepObscurance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_deepObscurance");
			LiquidVolume.NativeFieldInfoPtr__foamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamColor");
			LiquidVolume.NativeFieldInfoPtr__foamScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamScale");
			LiquidVolume.NativeFieldInfoPtr__foamThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamThickness");
			LiquidVolume.NativeFieldInfoPtr__foamDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamDensity");
			LiquidVolume.NativeFieldInfoPtr__foamWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamWeight");
			LiquidVolume.NativeFieldInfoPtr__foamTurbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamTurbulence");
			LiquidVolume.NativeFieldInfoPtr__foamVisibleFromBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamVisibleFromBottom");
			LiquidVolume.NativeFieldInfoPtr__smokeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeEnabled");
			LiquidVolume.NativeFieldInfoPtr__smokeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeColor");
			LiquidVolume.NativeFieldInfoPtr__smokeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeScale");
			LiquidVolume.NativeFieldInfoPtr__smokeBaseObscurance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeBaseObscurance");
			LiquidVolume.NativeFieldInfoPtr__smokeHeightAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeHeightAtten");
			LiquidVolume.NativeFieldInfoPtr__smokeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeSpeed");
			LiquidVolume.NativeFieldInfoPtr__fixMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_fixMesh");
			LiquidVolume.NativeFieldInfoPtr_originalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "originalMesh");
			LiquidVolume.NativeFieldInfoPtr_originalPivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "originalPivotOffset");
			LiquidVolume.NativeFieldInfoPtr__pivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_pivotOffset");
			LiquidVolume.NativeFieldInfoPtr__limitVerticalRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_limitVerticalRange");
			LiquidVolume.NativeFieldInfoPtr__upperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_upperLimit");
			LiquidVolume.NativeFieldInfoPtr__lowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_lowerLimit");
			LiquidVolume.NativeFieldInfoPtr__subMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_subMeshIndex");
			LiquidVolume.NativeFieldInfoPtr__flaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_flaskMaterial");
			LiquidVolume.NativeFieldInfoPtr__flaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_flaskThickness");
			LiquidVolume.NativeFieldInfoPtr__glossinessInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_glossinessInternal");
			LiquidVolume.NativeFieldInfoPtr__scatteringEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_scatteringEnabled");
			LiquidVolume.NativeFieldInfoPtr__scatteringPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_scatteringPower");
			LiquidVolume.NativeFieldInfoPtr__scatteringAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_scatteringAmount");
			LiquidVolume.NativeFieldInfoPtr__refractionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_refractionBlur");
			LiquidVolume.NativeFieldInfoPtr__blurIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_blurIntensity");
			LiquidVolume.NativeFieldInfoPtr__liquidRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidRaySteps");
			LiquidVolume.NativeFieldInfoPtr__foamRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamRaySteps");
			LiquidVolume.NativeFieldInfoPtr__smokeRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeRaySteps");
			LiquidVolume.NativeFieldInfoPtr__bumpMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpMap");
			LiquidVolume.NativeFieldInfoPtr__bumpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpStrength");
			LiquidVolume.NativeFieldInfoPtr__bumpDistortionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpDistortionScale");
			LiquidVolume.NativeFieldInfoPtr__bumpDistortionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpDistortionOffset");
			LiquidVolume.NativeFieldInfoPtr__distortionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_distortionMap");
			LiquidVolume.NativeFieldInfoPtr__texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_texture");
			LiquidVolume.NativeFieldInfoPtr__textureScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_textureScale");
			LiquidVolume.NativeFieldInfoPtr__textureOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_textureOffset");
			LiquidVolume.NativeFieldInfoPtr__distortionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_distortionAmount");
			LiquidVolume.NativeFieldInfoPtr__depthAware = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAware");
			LiquidVolume.NativeFieldInfoPtr__depthAwareOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAwareOffset");
			LiquidVolume.NativeFieldInfoPtr__irregularDepthDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_irregularDepthDebug");
			LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAwareCustomPass");
			LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPassDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAwareCustomPassDebug");
			LiquidVolume.NativeFieldInfoPtr__doubleSidedBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_doubleSidedBias");
			LiquidVolume.NativeFieldInfoPtr__backDepthBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_backDepthBias");
			LiquidVolume.NativeFieldInfoPtr__rotationLevelCompensation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_rotationLevelCompensation");
			LiquidVolume.NativeFieldInfoPtr__ignoreGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_ignoreGravity");
			LiquidVolume.NativeFieldInfoPtr__reactToForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_reactToForces");
			LiquidVolume.NativeFieldInfoPtr__extentsScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_extentsScale");
			LiquidVolume.NativeFieldInfoPtr__noiseVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_noiseVariation");
			LiquidVolume.NativeFieldInfoPtr__allowViewFromInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_allowViewFromInside");
			LiquidVolume.NativeFieldInfoPtr__debugSpillPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_debugSpillPoint");
			LiquidVolume.NativeFieldInfoPtr__renderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_renderQueue");
			LiquidVolume.NativeFieldInfoPtr__reflectionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_reflectionTexture");
			LiquidVolume.NativeFieldInfoPtr__physicsMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_physicsMass");
			LiquidVolume.NativeFieldInfoPtr__physicsAngularDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_physicsAngularDamp");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_IGNORE_GRAVITY_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_NON_AABB_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_TOPOLOGY_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_REFRACTION_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_NON_AABB");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_IGNORE_GRAVITY");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_SPHERE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CUBE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_CUBE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_CYLINDER");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_IRREGULAR");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_FP_RENDER_TEXTURE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_USE_REFRACTION");
			LiquidVolume.NativeFieldInfoPtr_SPILL_POINT_GIZMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SPILL_POINT_GIZMO");
			LiquidVolume.NativeFieldInfoPtr_liqMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liqMat");
			LiquidVolume.NativeFieldInfoPtr_liqMatSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liqMatSimple");
			LiquidVolume.NativeFieldInfoPtr_liqMatDefaultNoFlask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liqMatDefaultNoFlask");
			LiquidVolume.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "mesh");
			LiquidVolume.NativeFieldInfoPtr_mr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "mr");
			LiquidVolume.NativeFieldInfoPtr_mrSharedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "mrSharedMaterials");
			LiquidVolume.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastPosition");
			LiquidVolume.NativeFieldInfoPtr_lastScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastScale");
			LiquidVolume.NativeFieldInfoPtr_lastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastRotation");
			LiquidVolume.NativeFieldInfoPtr_shaderKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "shaderKeywords");
			LiquidVolume.NativeFieldInfoPtr_camInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "camInside");
			LiquidVolume.NativeFieldInfoPtr_lastDistanceToCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastDistanceToCam");
			LiquidVolume.NativeFieldInfoPtr_currentDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "currentDetail");
			LiquidVolume.NativeFieldInfoPtr_turb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "turb");
			LiquidVolume.NativeFieldInfoPtr_shaderTurb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "shaderTurb");
			LiquidVolume.NativeFieldInfoPtr_turbulenceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "turbulenceSpeed");
			LiquidVolume.NativeFieldInfoPtr_murkinessSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "murkinessSpeed");
			LiquidVolume.NativeFieldInfoPtr_liquidLevelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liquidLevelPos");
			LiquidVolume.NativeFieldInfoPtr_shouldUpdateMaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "shouldUpdateMaterialProperties");
			LiquidVolume.NativeFieldInfoPtr_currentNoiseVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "currentNoiseVariation");
			LiquidVolume.NativeFieldInfoPtr_levelMultipled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "levelMultipled");
			LiquidVolume.NativeFieldInfoPtr_noise3DUnwrapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "noise3DUnwrapped");
			LiquidVolume.NativeFieldInfoPtr_noise3DTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "noise3DTex");
			LiquidVolume.NativeFieldInfoPtr_colors3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "colors3D");
			LiquidVolume.NativeFieldInfoPtr_verticesUnsorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verticesUnsorted");
			LiquidVolume.NativeFieldInfoPtr_verticesSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verticesSorted");
			LiquidVolume.NativeFieldInfoPtr_rotatedVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "rotatedVertices");
			LiquidVolume.NativeFieldInfoPtr_verticesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verticesIndices");
			LiquidVolume.NativeFieldInfoPtr_volumeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "volumeRef");
			LiquidVolume.NativeFieldInfoPtr_lastLevelVolumeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastLevelVolumeRef");
			LiquidVolume.NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "inertia");
			LiquidVolume.NativeFieldInfoPtr_lastAvgVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastAvgVelocity");
			LiquidVolume.NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "angularVelocity");
			LiquidVolume.NativeFieldInfoPtr_angularInertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "angularInertia");
			LiquidVolume.NativeFieldInfoPtr_turbulenceDueForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "turbulenceDueForces");
			LiquidVolume.NativeFieldInfoPtr_liquidRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liquidRot");
			LiquidVolume.NativeFieldInfoPtr_prevThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "prevThickness");
			LiquidVolume.NativeFieldInfoPtr_spillPointGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "spillPointGizmo");
			LiquidVolume.NativeFieldInfoPtr_defaultContainerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "defaultContainerNames");
			LiquidVolume.NativeFieldInfoPtr_pointLightColorBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "pointLightColorBuffer");
			LiquidVolume.NativeFieldInfoPtr_pointLightPositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "pointLightPositionBuffer");
			LiquidVolume.NativeFieldInfoPtr_lastPointLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastPointLightCount");
			LiquidVolume.NativeFieldInfoPtr_meshCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "meshCache");
			LiquidVolume.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verts");
			LiquidVolume.NativeFieldInfoPtr_cutPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "cutPoints");
			LiquidVolume.NativeFieldInfoPtr_cutPlaneCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "cutPlaneCenter");
			LiquidVolume.NativeFieldInfoPtr_fixedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "fixedMesh");
			LiquidVolume.NativeMethodInfoPtr_add_onPropertiesChanged_Public_add_Void_PropertiesChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665106);
			LiquidVolume.NativeMethodInfoPtr_remove_onPropertiesChanged_Public_rem_Void_PropertiesChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665107);
			LiquidVolume.NativeMethodInfoPtr_get_topology_Public_get_TOPOLOGY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665108);
			LiquidVolume.NativeMethodInfoPtr_set_topology_Public_set_Void_TOPOLOGY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665109);
			LiquidVolume.NativeMethodInfoPtr_get_detail_Public_get_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665110);
			LiquidVolume.NativeMethodInfoPtr_set_detail_Public_set_Void_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665111);
			LiquidVolume.NativeMethodInfoPtr_get_level_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665112);
			LiquidVolume.NativeMethodInfoPtr_set_level_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665113);
			LiquidVolume.NativeMethodInfoPtr_get_levelMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665114);
			LiquidVolume.NativeMethodInfoPtr_set_levelMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665115);
			LiquidVolume.NativeMethodInfoPtr_get_useLightColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665116);
			LiquidVolume.NativeMethodInfoPtr_set_useLightColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665117);
			LiquidVolume.NativeMethodInfoPtr_get_useLightDirection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665118);
			LiquidVolume.NativeMethodInfoPtr_set_useLightDirection_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665119);
			LiquidVolume.NativeMethodInfoPtr_get_directionalLight_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665120);
			LiquidVolume.NativeMethodInfoPtr_set_directionalLight_Public_set_Void_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665121);
			LiquidVolume.NativeMethodInfoPtr_get_liquidColor1_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665122);
			LiquidVolume.NativeMethodInfoPtr_set_liquidColor1_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665123);
			LiquidVolume.NativeMethodInfoPtr_get_liquidScale1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665124);
			LiquidVolume.NativeMethodInfoPtr_set_liquidScale1_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665125);
			LiquidVolume.NativeMethodInfoPtr_get_liquidColor2_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665126);
			LiquidVolume.NativeMethodInfoPtr_set_liquidColor2_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665127);
			LiquidVolume.NativeMethodInfoPtr_get_liquidScale2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665128);
			LiquidVolume.NativeMethodInfoPtr_set_liquidScale2_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665129);
			LiquidVolume.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665130);
			LiquidVolume.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665131);
			LiquidVolume.NativeMethodInfoPtr_get_emissionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665132);
			LiquidVolume.NativeMethodInfoPtr_set_emissionColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665133);
			LiquidVolume.NativeMethodInfoPtr_get_ditherShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665134);
			LiquidVolume.NativeMethodInfoPtr_set_ditherShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665135);
			LiquidVolume.NativeMethodInfoPtr_get_murkiness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665136);
			LiquidVolume.NativeMethodInfoPtr_set_murkiness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665137);
			LiquidVolume.NativeMethodInfoPtr_get_turbulence1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665138);
			LiquidVolume.NativeMethodInfoPtr_set_turbulence1_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665139);
			LiquidVolume.NativeMethodInfoPtr_get_turbulence2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665140);
			LiquidVolume.NativeMethodInfoPtr_set_turbulence2_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665141);
			LiquidVolume.NativeMethodInfoPtr_get_frecuency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665142);
			LiquidVolume.NativeMethodInfoPtr_set_frecuency_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665143);
			LiquidVolume.NativeMethodInfoPtr_get_speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665144);
			LiquidVolume.NativeMethodInfoPtr_set_speed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665145);
			LiquidVolume.NativeMethodInfoPtr_get_sparklingIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665146);
			LiquidVolume.NativeMethodInfoPtr_set_sparklingIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665147);
			LiquidVolume.NativeMethodInfoPtr_get_sparklingAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665148);
			LiquidVolume.NativeMethodInfoPtr_set_sparklingAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665149);
			LiquidVolume.NativeMethodInfoPtr_get_deepObscurance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665150);
			LiquidVolume.NativeMethodInfoPtr_set_deepObscurance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665151);
			LiquidVolume.NativeMethodInfoPtr_get_foamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665152);
			LiquidVolume.NativeMethodInfoPtr_set_foamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665153);
			LiquidVolume.NativeMethodInfoPtr_get_foamScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665154);
			LiquidVolume.NativeMethodInfoPtr_set_foamScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665155);
			LiquidVolume.NativeMethodInfoPtr_get_foamThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665156);
			LiquidVolume.NativeMethodInfoPtr_set_foamThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665157);
			LiquidVolume.NativeMethodInfoPtr_get_foamDensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665158);
			LiquidVolume.NativeMethodInfoPtr_set_foamDensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665159);
			LiquidVolume.NativeMethodInfoPtr_get_foamWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665160);
			LiquidVolume.NativeMethodInfoPtr_set_foamWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665161);
			LiquidVolume.NativeMethodInfoPtr_get_foamTurbulence_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665162);
			LiquidVolume.NativeMethodInfoPtr_set_foamTurbulence_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665163);
			LiquidVolume.NativeMethodInfoPtr_get_foamVisibleFromBottom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665164);
			LiquidVolume.NativeMethodInfoPtr_set_foamVisibleFromBottom_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665165);
			LiquidVolume.NativeMethodInfoPtr_get_smokeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665166);
			LiquidVolume.NativeMethodInfoPtr_set_smokeEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665167);
			LiquidVolume.NativeMethodInfoPtr_get_smokeColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665168);
			LiquidVolume.NativeMethodInfoPtr_set_smokeColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665169);
			LiquidVolume.NativeMethodInfoPtr_get_smokeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665170);
			LiquidVolume.NativeMethodInfoPtr_set_smokeScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665171);
			LiquidVolume.NativeMethodInfoPtr_get_smokeBaseObscurance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665172);
			LiquidVolume.NativeMethodInfoPtr_set_smokeBaseObscurance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665173);
			LiquidVolume.NativeMethodInfoPtr_get_smokeHeightAtten_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665174);
			LiquidVolume.NativeMethodInfoPtr_set_smokeHeightAtten_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665175);
			LiquidVolume.NativeMethodInfoPtr_get_smokeSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665176);
			LiquidVolume.NativeMethodInfoPtr_set_smokeSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665177);
			LiquidVolume.NativeMethodInfoPtr_get_fixMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665178);
			LiquidVolume.NativeMethodInfoPtr_set_fixMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665179);
			LiquidVolume.NativeMethodInfoPtr_get_pivotOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665180);
			LiquidVolume.NativeMethodInfoPtr_set_pivotOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665181);
			LiquidVolume.NativeMethodInfoPtr_get_limitVerticalRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665182);
			LiquidVolume.NativeMethodInfoPtr_set_limitVerticalRange_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665183);
			LiquidVolume.NativeMethodInfoPtr_get_upperLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665184);
			LiquidVolume.NativeMethodInfoPtr_set_upperLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665185);
			LiquidVolume.NativeMethodInfoPtr_get_lowerLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665186);
			LiquidVolume.NativeMethodInfoPtr_set_lowerLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665187);
			LiquidVolume.NativeMethodInfoPtr_get_subMeshIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665188);
			LiquidVolume.NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665189);
			LiquidVolume.NativeMethodInfoPtr_get_flaskMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665190);
			LiquidVolume.NativeMethodInfoPtr_set_flaskMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665191);
			LiquidVolume.NativeMethodInfoPtr_get_flaskThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665192);
			LiquidVolume.NativeMethodInfoPtr_set_flaskThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665193);
			LiquidVolume.NativeMethodInfoPtr_get_glossinessInternal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665194);
			LiquidVolume.NativeMethodInfoPtr_set_glossinessInternal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665195);
			LiquidVolume.NativeMethodInfoPtr_get_scatteringEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665196);
			LiquidVolume.NativeMethodInfoPtr_set_scatteringEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665197);
			LiquidVolume.NativeMethodInfoPtr_get_scatteringPower_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665198);
			LiquidVolume.NativeMethodInfoPtr_set_scatteringPower_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665199);
			LiquidVolume.NativeMethodInfoPtr_get_scatteringAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665200);
			LiquidVolume.NativeMethodInfoPtr_set_scatteringAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665201);
			LiquidVolume.NativeMethodInfoPtr_get_refractionBlur_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665202);
			LiquidVolume.NativeMethodInfoPtr_set_refractionBlur_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665203);
			LiquidVolume.NativeMethodInfoPtr_get_blurIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665204);
			LiquidVolume.NativeMethodInfoPtr_set_blurIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665205);
			LiquidVolume.NativeMethodInfoPtr_get_liquidRaySteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665206);
			LiquidVolume.NativeMethodInfoPtr_set_liquidRaySteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665207);
			LiquidVolume.NativeMethodInfoPtr_get_foamRaySteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665208);
			LiquidVolume.NativeMethodInfoPtr_set_foamRaySteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665209);
			LiquidVolume.NativeMethodInfoPtr_get_smokeRaySteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665210);
			LiquidVolume.NativeMethodInfoPtr_set_smokeRaySteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665211);
			LiquidVolume.NativeMethodInfoPtr_get_bumpMap_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665212);
			LiquidVolume.NativeMethodInfoPtr_set_bumpMap_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665213);
			LiquidVolume.NativeMethodInfoPtr_get_bumpStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665214);
			LiquidVolume.NativeMethodInfoPtr_set_bumpStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665215);
			LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665216);
			LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665217);
			LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665218);
			LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665219);
			LiquidVolume.NativeMethodInfoPtr_get_distortionMap_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665220);
			LiquidVolume.NativeMethodInfoPtr_set_distortionMap_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665221);
			LiquidVolume.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665222);
			LiquidVolume.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665223);
			LiquidVolume.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665224);
			LiquidVolume.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665225);
			LiquidVolume.NativeMethodInfoPtr_get_textureOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665226);
			LiquidVolume.NativeMethodInfoPtr_set_textureOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665227);
			LiquidVolume.NativeMethodInfoPtr_get_distortionAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665228);
			LiquidVolume.NativeMethodInfoPtr_set_distortionAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665229);
			LiquidVolume.NativeMethodInfoPtr_get_depthAware_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665230);
			LiquidVolume.NativeMethodInfoPtr_set_depthAware_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665231);
			LiquidVolume.NativeMethodInfoPtr_get_depthAwareOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665232);
			LiquidVolume.NativeMethodInfoPtr_set_depthAwareOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665233);
			LiquidVolume.NativeMethodInfoPtr_get_irregularDepthDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665234);
			LiquidVolume.NativeMethodInfoPtr_set_irregularDepthDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665235);
			LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665236);
			LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPass_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665237);
			LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPassDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665238);
			LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPassDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665239);
			LiquidVolume.NativeMethodInfoPtr_get_doubleSidedBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665240);
			LiquidVolume.NativeMethodInfoPtr_set_doubleSidedBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665241);
			LiquidVolume.NativeMethodInfoPtr_get_backDepthBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665242);
			LiquidVolume.NativeMethodInfoPtr_set_backDepthBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665243);
			LiquidVolume.NativeMethodInfoPtr_get_rotationLevelCompensation_Public_get_LEVEL_COMPENSATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665244);
			LiquidVolume.NativeMethodInfoPtr_set_rotationLevelCompensation_Public_set_Void_LEVEL_COMPENSATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665245);
			LiquidVolume.NativeMethodInfoPtr_get_ignoreGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665246);
			LiquidVolume.NativeMethodInfoPtr_set_ignoreGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665247);
			LiquidVolume.NativeMethodInfoPtr_get_reactToForces_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665248);
			LiquidVolume.NativeMethodInfoPtr_set_reactToForces_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665249);
			LiquidVolume.NativeMethodInfoPtr_get_extentsScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665250);
			LiquidVolume.NativeMethodInfoPtr_set_extentsScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665251);
			LiquidVolume.NativeMethodInfoPtr_get_noiseVariation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665252);
			LiquidVolume.NativeMethodInfoPtr_set_noiseVariation_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665253);
			LiquidVolume.NativeMethodInfoPtr_get_allowViewFromInside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665254);
			LiquidVolume.NativeMethodInfoPtr_set_allowViewFromInside_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665255);
			LiquidVolume.NativeMethodInfoPtr_get_debugSpillPoint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665256);
			LiquidVolume.NativeMethodInfoPtr_set_debugSpillPoint_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665257);
			LiquidVolume.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665258);
			LiquidVolume.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665259);
			LiquidVolume.NativeMethodInfoPtr_get_reflectionTexture_Public_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665260);
			LiquidVolume.NativeMethodInfoPtr_set_reflectionTexture_Public_set_Void_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665261);
			LiquidVolume.NativeMethodInfoPtr_get_physicsMass_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665262);
			LiquidVolume.NativeMethodInfoPtr_set_physicsMass_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665263);
			LiquidVolume.NativeMethodInfoPtr_get_physicsAngularDamp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665264);
			LiquidVolume.NativeMethodInfoPtr_set_physicsAngularDamp_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665265);
			LiquidVolume.NativeMethodInfoPtr_get_useFPRenderTextures_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665266);
			LiquidVolume.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665267);
			LiquidVolume.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665268);
			LiquidVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665269);
			LiquidVolume.NativeMethodInfoPtr_RenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665270);
			LiquidVolume.NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665271);
			LiquidVolume.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665272);
			LiquidVolume.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665273);
			LiquidVolume.NativeMethodInfoPtr_ClearMeshCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665274);
			LiquidVolume.NativeMethodInfoPtr_ReadVertices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665275);
			LiquidVolume.NativeMethodInfoPtr_vertexComparer_Private_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665276);
			LiquidVolume.NativeMethodInfoPtr_UpdateAnimations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665277);
			LiquidVolume.NativeMethodInfoPtr_UpdateMaterialProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665278);
			LiquidVolume.NativeMethodInfoPtr_UpdateMaterialPropertiesNow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665279);
			LiquidVolume.NativeMethodInfoPtr_ApplyGlobalAlpha_Private_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665280);
			LiquidVolume.NativeMethodInfoPtr_GetRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665281);
			LiquidVolume.NativeMethodInfoPtr_UpdateLevels_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665282);
			LiquidVolume.NativeMethodInfoPtr_RotateVertices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665283);
			LiquidVolume.NativeMethodInfoPtr_SignedVolumeOfTriangle_Private_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665284);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelFast_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665285);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWSFast_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665286);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWSFast_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665287);
			LiquidVolume.NativeMethodInfoPtr_ClampVertexToSlicePlane_Private_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665288);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevel_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665289);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWS_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665290);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWS_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665291);
			LiquidVolume.NativeMethodInfoPtr_PolygonSortOnPlane_Private_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665292);
			LiquidVolume.NativeMethodInfoPtr_UpdateTurbulence_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665293);
			LiquidVolume.NativeMethodInfoPtr_CheckInsideOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665294);
			LiquidVolume.NativeMethodInfoPtr_PointInAABB_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665295);
			LiquidVolume.NativeMethodInfoPtr_PointInCylinder_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665296);
			LiquidVolume.NativeMethodInfoPtr_UpdateInsideOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665297);
			LiquidVolume.NativeMethodInfoPtr_get_liquidSurfaceYPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665298);
			LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665299);
			LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_byref_Single_Single_LEVEL_COMPENSATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665300);
			LiquidVolume.NativeMethodInfoPtr_UpdateSpillPointGizmo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665301);
			LiquidVolume.NativeMethodInfoPtr_BakeRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665302);
			LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665303);
			LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665304);
			LiquidVolume.NativeMethodInfoPtr_RefreshMeshAndCollider_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665305);
			LiquidVolume.NativeMethodInfoPtr_Redraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665306);
			LiquidVolume.NativeMethodInfoPtr_CheckMeshDisplacement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665307);
			LiquidVolume.NativeMethodInfoPtr_RestoreOriginalMesh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665308);
			LiquidVolume.NativeMethodInfoPtr_CopyFrom_Public_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665309);
			LiquidVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100665310);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000A3638 File Offset: 0x000A1838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86397, XrefRangeEnd = 86401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onPropertiesChanged(PropertiesChangedEvent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_add_onPropertiesChanged_Public_add_Void_PropertiesChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000A367C File Offset: 0x000A187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86401, XrefRangeEnd = 86405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onPropertiesChanged(PropertiesChangedEvent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_remove_onPropertiesChanged_Public_rem_Void_PropertiesChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000A36C0 File Offset: 0x000A18C0
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x000A36FC File Offset: 0x000A18FC
		public unsafe TOPOLOGY topology
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_topology_Public_get_TOPOLOGY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86410, RefRangeEnd = 86412, XrefRangeStart = 86405, XrefRangeEnd = 86410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_topology_Public_set_Void_TOPOLOGY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000A373C File Offset: 0x000A193C
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x000A3778 File Offset: 0x000A1978
		public unsafe DETAIL detail
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_detail_Public_get_DETAIL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86412, XrefRangeEnd = 86417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_detail_Public_set_Void_DETAIL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000A37B8 File Offset: 0x000A19B8
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x000A37F4 File Offset: 0x000A19F4
		public unsafe float level
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30020, RefRangeEnd = 30021, XrefRangeStart = 30020, XrefRangeEnd = 30021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_level_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 86422, RefRangeEnd = 86425, XrefRangeStart = 86417, XrefRangeEnd = 86422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_level_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x000A3834 File Offset: 0x000A1A34
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x000A3870 File Offset: 0x000A1A70
		public unsafe float levelMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_levelMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86425, XrefRangeEnd = 86430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_levelMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x000A38B0 File Offset: 0x000A1AB0
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x000A38EC File Offset: 0x000A1AEC
		public unsafe bool useLightColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_useLightColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86430, XrefRangeEnd = 86435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_useLightColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000A392C File Offset: 0x000A1B2C
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000A3968 File Offset: 0x000A1B68
		public unsafe bool useLightDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_useLightDirection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86435, XrefRangeEnd = 86440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_useLightDirection_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000A39A8 File Offset: 0x000A1BA8
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000A39E8 File Offset: 0x000A1BE8
		public unsafe Light directionalLight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_directionalLight_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86450, RefRangeEnd = 86451, XrefRangeStart = 86440, XrefRangeEnd = 86450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_directionalLight_Public_set_Void_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000A3A2C File Offset: 0x000A1C2C
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x000A3A68 File Offset: 0x000A1C68
		public unsafe Color liquidColor1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidColor1_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86456, RefRangeEnd = 86460, XrefRangeStart = 86451, XrefRangeEnd = 86456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidColor1_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000A3AA8 File Offset: 0x000A1CA8
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000A3AE4 File Offset: 0x000A1CE4
		public unsafe float liquidScale1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidScale1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86460, XrefRangeEnd = 86465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidScale1_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000A3B24 File Offset: 0x000A1D24
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x000A3B60 File Offset: 0x000A1D60
		public unsafe Color liquidColor2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidColor2_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86470, RefRangeEnd = 86474, XrefRangeStart = 86465, XrefRangeEnd = 86470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidColor2_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000A3BDC File Offset: 0x000A1DDC
		public unsafe float liquidScale2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidScale2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86474, XrefRangeEnd = 86479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidScale2_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000A3C1C File Offset: 0x000A1E1C
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x000A3C58 File Offset: 0x000A1E58
		public unsafe float alpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86487, RefRangeEnd = 86489, XrefRangeStart = 86479, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x000A3C98 File Offset: 0x000A1E98
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x000A3CD4 File Offset: 0x000A1ED4
		public unsafe Color emissionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_emissionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86489, XrefRangeEnd = 86494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_emissionColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000A3D14 File Offset: 0x000A1F14
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000A3D50 File Offset: 0x000A1F50
		public unsafe bool ditherShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_ditherShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86494, XrefRangeEnd = 86499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_ditherShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000A3D90 File Offset: 0x000A1F90
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x000A3DCC File Offset: 0x000A1FCC
		public unsafe float murkiness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_murkiness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86499, XrefRangeEnd = 86504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_murkiness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000A3E0C File Offset: 0x000A200C
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000A3E48 File Offset: 0x000A2048
		public unsafe float turbulence1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_turbulence1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86504, XrefRangeEnd = 86509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_turbulence1_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000A3E88 File Offset: 0x000A2088
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x000A3EC4 File Offset: 0x000A20C4
		public unsafe float turbulence2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_turbulence2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86509, XrefRangeEnd = 86514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_turbulence2_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x000A3F04 File Offset: 0x000A2104
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x000A3F40 File Offset: 0x000A2140
		public unsafe float frecuency
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_frecuency_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86514, XrefRangeEnd = 86519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_frecuency_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000A3F80 File Offset: 0x000A2180
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x000A3FBC File Offset: 0x000A21BC
		public unsafe float speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_speed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86519, XrefRangeEnd = 86524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_speed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000A3FFC File Offset: 0x000A21FC
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x000A4038 File Offset: 0x000A2238
		public unsafe float sparklingIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_sparklingIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86524, XrefRangeEnd = 86529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_sparklingIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000A4078 File Offset: 0x000A2278
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x000A40B4 File Offset: 0x000A22B4
		public unsafe float sparklingAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_sparklingAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86529, XrefRangeEnd = 86534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_sparklingAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000A40F4 File Offset: 0x000A22F4
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000A4130 File Offset: 0x000A2330
		public unsafe float deepObscurance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_deepObscurance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86534, XrefRangeEnd = 86539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_deepObscurance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000A4170 File Offset: 0x000A2370
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000A41AC File Offset: 0x000A23AC
		public unsafe Color foamColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86539, XrefRangeEnd = 86544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000A41EC File Offset: 0x000A23EC
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000A4228 File Offset: 0x000A2428
		public unsafe float foamScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86544, XrefRangeEnd = 86549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x000A4268 File Offset: 0x000A2468
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x000A42A4 File Offset: 0x000A24A4
		public unsafe float foamThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86549, XrefRangeEnd = 86554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x000A42E4 File Offset: 0x000A24E4
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x000A4320 File Offset: 0x000A2520
		public unsafe float foamDensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamDensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86554, XrefRangeEnd = 86559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamDensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x000A4360 File Offset: 0x000A2560
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x000A439C File Offset: 0x000A259C
		public unsafe float foamWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86559, XrefRangeEnd = 86564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x000A43DC File Offset: 0x000A25DC
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x000A4418 File Offset: 0x000A2618
		public unsafe float foamTurbulence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamTurbulence_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86564, XrefRangeEnd = 86569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamTurbulence_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x000A4458 File Offset: 0x000A2658
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x000A4494 File Offset: 0x000A2694
		public unsafe bool foamVisibleFromBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamVisibleFromBottom_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86569, XrefRangeEnd = 86574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamVisibleFromBottom_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000A44D4 File Offset: 0x000A26D4
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x000A4510 File Offset: 0x000A2710
		public unsafe bool smokeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86574, XrefRangeEnd = 86579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x000A4550 File Offset: 0x000A2750
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x000A458C File Offset: 0x000A278C
		public unsafe Color smokeColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86579, XrefRangeEnd = 86584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x000A45CC File Offset: 0x000A27CC
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x000A4608 File Offset: 0x000A2808
		public unsafe float smokeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86584, XrefRangeEnd = 86589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000A4648 File Offset: 0x000A2848
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x000A4684 File Offset: 0x000A2884
		public unsafe float smokeBaseObscurance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeBaseObscurance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86589, XrefRangeEnd = 86594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeBaseObscurance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x000A46C4 File Offset: 0x000A28C4
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x000A4700 File Offset: 0x000A2900
		public unsafe float smokeHeightAtten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeHeightAtten_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86594, XrefRangeEnd = 86599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeHeightAtten_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x000A4740 File Offset: 0x000A2940
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x000A477C File Offset: 0x000A297C
		public unsafe float smokeSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86599, XrefRangeEnd = 86604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x000A47BC File Offset: 0x000A29BC
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x000A47F8 File Offset: 0x000A29F8
		public unsafe bool fixMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_fixMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86604, XrefRangeEnd = 86609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_fixMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000A4838 File Offset: 0x000A2A38
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x000A4874 File Offset: 0x000A2A74
		public unsafe Vector3 pivotOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_pivotOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86609, XrefRangeEnd = 86614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_pivotOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x000A48B4 File Offset: 0x000A2AB4
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x000A48F0 File Offset: 0x000A2AF0
		public unsafe bool limitVerticalRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_limitVerticalRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86614, XrefRangeEnd = 86619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_limitVerticalRange_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000A4930 File Offset: 0x000A2B30
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x000A496C File Offset: 0x000A2B6C
		public unsafe float upperLimit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86619, RefRangeEnd = 86621, XrefRangeStart = 86619, XrefRangeEnd = 86619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_upperLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86621, XrefRangeEnd = 86626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_upperLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x000A49AC File Offset: 0x000A2BAC
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x000A49E8 File Offset: 0x000A2BE8
		public unsafe float lowerLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_lowerLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86626, XrefRangeEnd = 86631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_lowerLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x000A4A28 File Offset: 0x000A2C28
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x000A4A64 File Offset: 0x000A2C64
		public unsafe int subMeshIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_subMeshIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86631, XrefRangeEnd = 86636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x000A4AA4 File Offset: 0x000A2CA4
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x000A4AE4 File Offset: 0x000A2CE4
		public unsafe Material flaskMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_flaskMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86636, XrefRangeEnd = 86646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_flaskMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x000A4B28 File Offset: 0x000A2D28
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x000A4B64 File Offset: 0x000A2D64
		public unsafe float flaskThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_flaskThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86646, XrefRangeEnd = 86651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_flaskThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000A4BA4 File Offset: 0x000A2DA4
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x000A4BE0 File Offset: 0x000A2DE0
		public unsafe float glossinessInternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_glossinessInternal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86651, XrefRangeEnd = 86656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_glossinessInternal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000A4C20 File Offset: 0x000A2E20
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x000A4C5C File Offset: 0x000A2E5C
		public unsafe bool scatteringEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_scatteringEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86656, XrefRangeEnd = 86661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_scatteringEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000A4C9C File Offset: 0x000A2E9C
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x000A4CD8 File Offset: 0x000A2ED8
		public unsafe int scatteringPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_scatteringPower_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86661, XrefRangeEnd = 86666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_scatteringPower_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x000A4D18 File Offset: 0x000A2F18
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x000A4D54 File Offset: 0x000A2F54
		public unsafe float scatteringAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_scatteringAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86666, XrefRangeEnd = 86671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_scatteringAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x000A4D94 File Offset: 0x000A2F94
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x000A4DD0 File Offset: 0x000A2FD0
		public unsafe bool refractionBlur
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_refractionBlur_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86671, XrefRangeEnd = 86676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_refractionBlur_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000A4E10 File Offset: 0x000A3010
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x000A4E4C File Offset: 0x000A304C
		public unsafe float blurIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_blurIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86676, XrefRangeEnd = 86684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_blurIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x000A4E8C File Offset: 0x000A308C
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x000A4EC8 File Offset: 0x000A30C8
		public unsafe int liquidRaySteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidRaySteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86684, XrefRangeEnd = 86689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidRaySteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x000A4F08 File Offset: 0x000A3108
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x000A4F44 File Offset: 0x000A3144
		public unsafe int foamRaySteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamRaySteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86689, XrefRangeEnd = 86694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamRaySteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000A4F84 File Offset: 0x000A3184
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x000A4FC0 File Offset: 0x000A31C0
		public unsafe int smokeRaySteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeRaySteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86694, XrefRangeEnd = 86699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeRaySteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x000A5000 File Offset: 0x000A3200
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x000A5040 File Offset: 0x000A3240
		public unsafe Texture2D bumpMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpMap_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86699, XrefRangeEnd = 86709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpMap_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x000A5084 File Offset: 0x000A3284
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x000A50C0 File Offset: 0x000A32C0
		public unsafe float bumpStrength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86709, XrefRangeEnd = 86714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpStrength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x000A5100 File Offset: 0x000A3300
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x000A513C File Offset: 0x000A333C
		public unsafe float bumpDistortionScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86714, XrefRangeEnd = 86719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x000A517C File Offset: 0x000A337C
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x000A51B8 File Offset: 0x000A33B8
		public unsafe Vector2 bumpDistortionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86719, XrefRangeEnd = 86724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x000A51F8 File Offset: 0x000A33F8
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x000A5238 File Offset: 0x000A3438
		public unsafe Texture2D distortionMap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_distortionMap_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86725, XrefRangeEnd = 86735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_distortionMap_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x000A527C File Offset: 0x000A347C
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x000A52BC File Offset: 0x000A34BC
		public unsafe Texture2D texture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86735, XrefRangeEnd = 86745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x000A5300 File Offset: 0x000A3500
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x000A533C File Offset: 0x000A353C
		public unsafe Vector2 textureScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86745, XrefRangeEnd = 86750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x000A537C File Offset: 0x000A357C
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x000A53B8 File Offset: 0x000A35B8
		public unsafe Vector2 textureOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_textureOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86750, XrefRangeEnd = 86755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_textureOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x000A53F8 File Offset: 0x000A35F8
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x000A5434 File Offset: 0x000A3634
		public unsafe float distortionAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_distortionAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86755, XrefRangeEnd = 86760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_distortionAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x000A5474 File Offset: 0x000A3674
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x000A54B0 File Offset: 0x000A36B0
		public unsafe bool depthAware
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAware_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86760, XrefRangeEnd = 86765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAware_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x000A54F0 File Offset: 0x000A36F0
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x000A552C File Offset: 0x000A372C
		public unsafe float depthAwareOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAwareOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86765, XrefRangeEnd = 86770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAwareOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000A556C File Offset: 0x000A376C
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x000A55A8 File Offset: 0x000A37A8
		public unsafe bool irregularDepthDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_irregularDepthDebug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86770, XrefRangeEnd = 86775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_irregularDepthDebug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x000A55E8 File Offset: 0x000A37E8
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x000A5624 File Offset: 0x000A3824
		public unsafe bool depthAwareCustomPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86775, XrefRangeEnd = 86780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPass_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x000A5664 File Offset: 0x000A3864
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x000A56A0 File Offset: 0x000A38A0
		public unsafe bool depthAwareCustomPassDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPassDebug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86780, XrefRangeEnd = 86785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPassDebug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x000A56E0 File Offset: 0x000A38E0
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x000A571C File Offset: 0x000A391C
		public unsafe float doubleSidedBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_doubleSidedBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86785, XrefRangeEnd = 86790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_doubleSidedBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000A575C File Offset: 0x000A395C
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x000A5798 File Offset: 0x000A3998
		public unsafe float backDepthBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_backDepthBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86790, XrefRangeEnd = 86795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_backDepthBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x000A57D8 File Offset: 0x000A39D8
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x000A5814 File Offset: 0x000A3A14
		public unsafe LEVEL_COMPENSATION rotationLevelCompensation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_rotationLevelCompensation_Public_get_LEVEL_COMPENSATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86795, XrefRangeEnd = 86800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_rotationLevelCompensation_Public_set_Void_LEVEL_COMPENSATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x000A5854 File Offset: 0x000A3A54
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x000A5890 File Offset: 0x000A3A90
		public unsafe bool ignoreGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_ignoreGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86800, XrefRangeEnd = 86805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_ignoreGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x000A58D0 File Offset: 0x000A3AD0
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x000A590C File Offset: 0x000A3B0C
		public unsafe bool reactToForces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_reactToForces_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86805, XrefRangeEnd = 86810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_reactToForces_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x000A594C File Offset: 0x000A3B4C
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x000A5988 File Offset: 0x000A3B88
		public unsafe Vector3 extentsScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_extentsScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86810, XrefRangeEnd = 86815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_extentsScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000A59C8 File Offset: 0x000A3BC8
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x000A5A04 File Offset: 0x000A3C04
		public unsafe int noiseVariation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_noiseVariation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86815, XrefRangeEnd = 86820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_noiseVariation_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x000A5A44 File Offset: 0x000A3C44
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x000A5A80 File Offset: 0x000A3C80
		public unsafe bool allowViewFromInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_allowViewFromInside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86820, XrefRangeEnd = 86821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_allowViewFromInside_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x000A5AC0 File Offset: 0x000A3CC0
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x000A5AFC File Offset: 0x000A3CFC
		public unsafe bool debugSpillPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_debugSpillPoint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_debugSpillPoint_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x000A5B3C File Offset: 0x000A3D3C
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x000A5B78 File Offset: 0x000A3D78
		public unsafe int renderQueue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86821, XrefRangeEnd = 86826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x000A5BB8 File Offset: 0x000A3DB8
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x000A5BF8 File Offset: 0x000A3DF8
		public unsafe Cubemap reflectionTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_reflectionTexture_Public_get_Cubemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86826, XrefRangeEnd = 86836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_reflectionTexture_Public_set_Void_Cubemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x000A5C3C File Offset: 0x000A3E3C
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x000A5C78 File Offset: 0x000A3E78
		public unsafe float physicsMass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_physicsMass_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86836, XrefRangeEnd = 86841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_physicsMass_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x000A5CB8 File Offset: 0x000A3EB8
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x000A5CF4 File Offset: 0x000A3EF4
		public unsafe float physicsAngularDamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_physicsAngularDamp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86841, XrefRangeEnd = 86846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_physicsAngularDamp_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x000A5D34 File Offset: 0x000A3F34
		public unsafe static bool useFPRenderTextures
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_useFPRenderTextures_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000A5D64 File Offset: 0x000A3F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86846, XrefRangeEnd = 86867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000A5D98 File Offset: 0x000A3F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86867, XrefRangeEnd = 86905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000A5DCC File Offset: 0x000A3FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86905, XrefRangeEnd = 86941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000A5E00 File Offset: 0x000A4000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86979, RefRangeEnd = 86980, XrefRangeStart = 86941, XrefRangeEnd = 86979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000A5E34 File Offset: 0x000A4034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86980, XrefRangeEnd = 86981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000A5E68 File Offset: 0x000A4068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86981, XrefRangeEnd = 86991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000A5E9C File Offset: 0x000A409C
		[CallerCount(0)]
		public unsafe void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000A5ED0 File Offset: 0x000A40D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86999, RefRangeEnd = 87000, XrefRangeStart = 86991, XrefRangeEnd = 86999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMeshCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ClearMeshCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x000A5F04 File Offset: 0x000A4104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87023, RefRangeEnd = 87024, XrefRangeStart = 87000, XrefRangeEnd = 87023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ReadVertices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000A5F38 File Offset: 0x000A4138
		[CallerCount(0)]
		public unsafe int vertexComparer(Vector3 v0, Vector3 v1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_vertexComparer_Private_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000A5F90 File Offset: 0x000A4190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87093, RefRangeEnd = 87095, XrefRangeStart = 87024, XrefRangeEnd = 87093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateAnimations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000A5FC4 File Offset: 0x000A41C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87095, XrefRangeEnd = 87100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateMaterialProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000A5FF8 File Offset: 0x000A41F8
		[CallerCount(87)]
		[CachedScanResults(RefRangeStart = 87382, RefRangeEnd = 87469, XrefRangeStart = 87100, XrefRangeEnd = 87382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialPropertiesNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateMaterialPropertiesNow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000A602C File Offset: 0x000A422C
		[CallerCount(0)]
		public unsafe Color ApplyGlobalAlpha(Color originalColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originalColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ApplyGlobalAlpha_Private_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x000A6078 File Offset: 0x000A4278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87486, RefRangeEnd = 87488, XrefRangeStart = 87469, XrefRangeEnd = 87486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000A60AC File Offset: 0x000A42AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87649, RefRangeEnd = 87651, XrefRangeStart = 87488, XrefRangeEnd = 87649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLevels(bool updateShaderKeywords = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateShaderKeywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateLevels_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000A60EC File Offset: 0x000A42EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87672, RefRangeEnd = 87674, XrefRangeStart = 87651, XrefRangeEnd = 87672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RotateVertices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000A6120 File Offset: 0x000A4320
		[CallerCount(0)]
		public unsafe float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 zeroPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_SignedVolumeOfTriangle_Private_Single_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000A6194 File Offset: 0x000A4394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87674, XrefRangeEnd = 87677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevelFast(float level01, float yExtent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level01;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelFast_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000A61EC File Offset: 0x000A43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87677, XrefRangeEnd = 87678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeWSFast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWSFast_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000A6228 File Offset: 0x000A4428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 87684, RefRangeEnd = 87688, XrefRangeStart = 87678, XrefRangeEnd = 87684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevelWSFast(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWSFast_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000A6274 File Offset: 0x000A4474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87689, RefRangeEnd = 87691, XrefRangeStart = 87688, XrefRangeEnd = 87689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ClampVertexToSlicePlane(Vector3 p, Vector3 q, float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ClampVertexToSlicePlane_Private_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000A62DC File Offset: 0x000A44DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87691, XrefRangeEnd = 87694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevel(float level01, float yExtent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level01;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevel_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000A6334 File Offset: 0x000A4534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87694, XrefRangeEnd = 87695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeWS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWS_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000A6370 File Offset: 0x000A4570
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 87818, RefRangeEnd = 87822, XrefRangeStart = 87695, XrefRangeEnd = 87818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevelWS(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWS_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000A63BC File Offset: 0x000A45BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87822, XrefRangeEnd = 87824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PolygonSortOnPlane(Vector3 p1, Vector3 p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_PolygonSortOnPlane_Private_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x000A6414 File Offset: 0x000A4614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87834, RefRangeEnd = 87836, XrefRangeStart = 87824, XrefRangeEnd = 87834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTurbulence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateTurbulence_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000A6448 File Offset: 0x000A4648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87866, RefRangeEnd = 87868, XrefRangeStart = 87836, XrefRangeEnd = 87866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInsideOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CheckInsideOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000A647C File Offset: 0x000A467C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87868, XrefRangeEnd = 87871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInAABB(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_PointInAABB_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000A64C8 File Offset: 0x000A46C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87871, XrefRangeEnd = 87876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCylinder(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_PointInCylinder_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x000A6514 File Offset: 0x000A4714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87911, RefRangeEnd = 87913, XrefRangeStart = 87876, XrefRangeEnd = 87911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInsideOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateInsideOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x000A6548 File Offset: 0x000A4748
		public unsafe float liquidSurfaceYPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidSurfaceYPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000A6584 File Offset: 0x000A4784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87913, XrefRangeEnd = 87914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSpillPoint(out Vector3 spillPosition, float apertureStart = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &spillPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apertureStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000A65DC File Offset: 0x000A47DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 87935, RefRangeEnd = 87938, XrefRangeStart = 87914, XrefRangeEnd = 87935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSpillPoint(out Vector3 spillPosition, out float spillAmount, float apertureStart = 1f, LEVEL_COMPENSATION rotationCompensation = LEVEL_COMPENSATION.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &spillPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spillAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apertureStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationCompensation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_byref_Single_Single_LEVEL_COMPENSATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x000A6650 File Offset: 0x000A4850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87988, RefRangeEnd = 87989, XrefRangeStart = 87938, XrefRangeEnd = 87988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpillPointGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateSpillPointGizmo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000A6684 File Offset: 0x000A4884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87989, XrefRangeEnd = 88040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_BakeRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000A66B8 File Offset: 0x000A48B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88040, XrefRangeEnd = 88043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CenterPivot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000A66EC File Offset: 0x000A48EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88074, RefRangeEnd = 88076, XrefRangeStart = 88043, XrefRangeEnd = 88074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CenterPivot(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x000A672C File Offset: 0x000A492C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88087, RefRangeEnd = 88090, XrefRangeStart = 88076, XrefRangeEnd = 88087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshMeshAndCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RefreshMeshAndCollider_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x000A6760 File Offset: 0x000A4960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_Redraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000A6794 File Offset: 0x000A4994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88126, RefRangeEnd = 88127, XrefRangeStart = 88090, XrefRangeEnd = 88126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckMeshDisplacement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CheckMeshDisplacement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000A67C8 File Offset: 0x000A49C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88143, RefRangeEnd = 88145, XrefRangeStart = 88127, XrefRangeEnd = 88143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreOriginalMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RestoreOriginalMesh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000A67FC File Offset: 0x000A49FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88145, XrefRangeEnd = 88153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(LiquidVolume lv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CopyFrom_Public_Void_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000A6840 File Offset: 0x000A4A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88153, XrefRangeEnd = 88170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00009D54 File Offset: 0x00007F54
		public LiquidVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000A687C File Offset: 0x000A4A7C
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00009D5D File Offset: 0x00007F5D
		public unsafe static bool FORCE_GLES_COMPATIBILITY
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY, (void*)(&value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x000A6898 File Offset: 0x000A4A98
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00009D6B File Offset: 0x00007F6B
		public unsafe PropertiesChangedEvent onPropertiesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_onPropertiesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_onPropertiesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x000A68C8 File Offset: 0x000A4AC8
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00009D8A File Offset: 0x00007F8A
		public unsafe TOPOLOGY _topology
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__topology);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__topology)) = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x000A68F0 File Offset: 0x000A4AF0
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00009DA5 File Offset: 0x00007FA5
		public unsafe DETAIL _detail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__detail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__detail)) = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x000A6918 File Offset: 0x000A4B18
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00009DC0 File Offset: 0x00007FC0
		public unsafe float _level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__level)) = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000A6940 File Offset: 0x000A4B40
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00009DDB File Offset: 0x00007FDB
		public unsafe float _levelMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__levelMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__levelMultiplier)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000A6968 File Offset: 0x000A4B68
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x00009DF6 File Offset: 0x00007FF6
		public unsafe bool _useLightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightColor)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000A6990 File Offset: 0x000A4B90
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00009E11 File Offset: 0x00008011
		public unsafe bool _useLightDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightDirection)) = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x000A69B8 File Offset: 0x000A4BB8
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x00009E2C File Offset: 0x0000802C
		public unsafe Light _directionalLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__directionalLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__directionalLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x000A69E8 File Offset: 0x000A4BE8
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x00009E4B File Offset: 0x0000804B
		public unsafe Color _liquidColor1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor1)) = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x000A6A10 File Offset: 0x000A4C10
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x00009E66 File Offset: 0x00008066
		public unsafe float _liquidScale1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale1)) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x000A6A38 File Offset: 0x000A4C38
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x00009E81 File Offset: 0x00008081
		public unsafe Color _liquidColor2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor2)) = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x000A6A60 File Offset: 0x000A4C60
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x00009E9C File Offset: 0x0000809C
		public unsafe float _liquidScale2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale2)) = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x000A6A88 File Offset: 0x000A4C88
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00009EB7 File Offset: 0x000080B7
		public unsafe float _alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__alpha)) = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x000A6AB0 File Offset: 0x000A4CB0
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00009ED2 File Offset: 0x000080D2
		public unsafe Color _emissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__emissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__emissionColor)) = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x000A6AD8 File Offset: 0x000A4CD8
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00009EED File Offset: 0x000080ED
		public unsafe bool _ditherShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ditherShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ditherShadows)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x000A6B00 File Offset: 0x000A4D00
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00009F08 File Offset: 0x00008108
		public unsafe float _murkiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__murkiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__murkiness)) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x000A6B28 File Offset: 0x000A4D28
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00009F23 File Offset: 0x00008123
		public unsafe float _turbulence1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence1)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x000A6B50 File Offset: 0x000A4D50
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00009F3E File Offset: 0x0000813E
		public unsafe float _turbulence2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence2)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x000A6B78 File Offset: 0x000A4D78
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00009F59 File Offset: 0x00008159
		public unsafe float _frecuency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__frecuency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__frecuency)) = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x000A6BA0 File Offset: 0x000A4DA0
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00009F74 File Offset: 0x00008174
		public unsafe float _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000A6BC8 File Offset: 0x000A4DC8
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00009F8F File Offset: 0x0000818F
		public unsafe float _sparklingIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingIntensity)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x000A6BF0 File Offset: 0x000A4DF0
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00009FAA File Offset: 0x000081AA
		public unsafe float _sparklingAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingAmount)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x000A6C18 File Offset: 0x000A4E18
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00009FC5 File Offset: 0x000081C5
		public unsafe float _deepObscurance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__deepObscurance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__deepObscurance)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000A6C40 File Offset: 0x000A4E40
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00009FE0 File Offset: 0x000081E0
		public unsafe Color _foamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamColor)) = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x000A6C68 File Offset: 0x000A4E68
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00009FFB File Offset: 0x000081FB
		public unsafe float _foamScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamScale)) = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000A6C90 File Offset: 0x000A4E90
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0000A016 File Offset: 0x00008216
		public unsafe float _foamThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamThickness)) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000A6CB8 File Offset: 0x000A4EB8
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000A031 File Offset: 0x00008231
		public unsafe float _foamDensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamDensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamDensity)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x000A6CE0 File Offset: 0x000A4EE0
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0000A04C File Offset: 0x0000824C
		public unsafe float _foamWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamWeight)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x000A6D08 File Offset: 0x000A4F08
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x0000A067 File Offset: 0x00008267
		public unsafe float _foamTurbulence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamTurbulence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamTurbulence)) = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x000A6D30 File Offset: 0x000A4F30
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0000A082 File Offset: 0x00008282
		public unsafe bool _foamVisibleFromBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamVisibleFromBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamVisibleFromBottom)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x000A6D58 File Offset: 0x000A4F58
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x0000A09D File Offset: 0x0000829D
		public unsafe bool _smokeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeEnabled)) = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x000A6D80 File Offset: 0x000A4F80
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public unsafe Color _smokeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeColor)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000A6DA8 File Offset: 0x000A4FA8
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0000A0D3 File Offset: 0x000082D3
		public unsafe float _smokeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeScale)) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x000A6DD0 File Offset: 0x000A4FD0
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0000A0EE File Offset: 0x000082EE
		public unsafe float _smokeBaseObscurance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeBaseObscurance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeBaseObscurance)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0000A109 File Offset: 0x00008309
		public unsafe float _smokeHeightAtten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeHeightAtten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeHeightAtten)) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x000A6E20 File Offset: 0x000A5020
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0000A124 File Offset: 0x00008324
		public unsafe float _smokeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeSpeed)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x000A6E48 File Offset: 0x000A5048
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0000A13F File Offset: 0x0000833F
		public unsafe bool _fixMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__fixMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__fixMesh)) = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000A6E70 File Offset: 0x000A5070
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x0000A15A File Offset: 0x0000835A
		public unsafe Mesh originalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000A6EA0 File Offset: 0x000A50A0
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x0000A179 File Offset: 0x00008379
		public unsafe Vector3 originalPivotOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalPivotOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalPivotOffset)) = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000A6EC8 File Offset: 0x000A50C8
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0000A194 File Offset: 0x00008394
		public unsafe Vector3 _pivotOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__pivotOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__pivotOffset)) = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x000A6EF0 File Offset: 0x000A50F0
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0000A1AF File Offset: 0x000083AF
		public unsafe bool _limitVerticalRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__limitVerticalRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__limitVerticalRange)) = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000A6F18 File Offset: 0x000A5118
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0000A1CA File Offset: 0x000083CA
		public unsafe float _upperLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__upperLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__upperLimit)) = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x000A6F40 File Offset: 0x000A5140
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0000A1E5 File Offset: 0x000083E5
		public unsafe float _lowerLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__lowerLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__lowerLimit)) = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x000A6F68 File Offset: 0x000A5168
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0000A200 File Offset: 0x00008400
		public unsafe int _subMeshIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__subMeshIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__subMeshIndex)) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000A6F90 File Offset: 0x000A5190
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0000A21B File Offset: 0x0000841B
		public unsafe Material _flaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x000A6FC0 File Offset: 0x000A51C0
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0000A23A File Offset: 0x0000843A
		public unsafe float _flaskThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskThickness)) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x000A6FE8 File Offset: 0x000A51E8
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0000A255 File Offset: 0x00008455
		public unsafe float _glossinessInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__glossinessInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__glossinessInternal)) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x000A7010 File Offset: 0x000A5210
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x0000A270 File Offset: 0x00008470
		public unsafe bool _scatteringEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringEnabled)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000A7038 File Offset: 0x000A5238
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0000A28B File Offset: 0x0000848B
		public unsafe int _scatteringPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringPower)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000A7060 File Offset: 0x000A5260
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0000A2A6 File Offset: 0x000084A6
		public unsafe float _scatteringAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringAmount)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x000A7088 File Offset: 0x000A5288
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0000A2C1 File Offset: 0x000084C1
		public unsafe bool _refractionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__refractionBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__refractionBlur)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x000A70B0 File Offset: 0x000A52B0
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0000A2DC File Offset: 0x000084DC
		public unsafe float _blurIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__blurIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__blurIntensity)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x000A70D8 File Offset: 0x000A52D8
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0000A2F7 File Offset: 0x000084F7
		public unsafe int _liquidRaySteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidRaySteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidRaySteps)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x000A7100 File Offset: 0x000A5300
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0000A312 File Offset: 0x00008512
		public unsafe int _foamRaySteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamRaySteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamRaySteps)) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x000A7128 File Offset: 0x000A5328
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0000A32D File Offset: 0x0000852D
		public unsafe int _smokeRaySteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeRaySteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeRaySteps)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x000A7150 File Offset: 0x000A5350
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0000A348 File Offset: 0x00008548
		public unsafe Texture2D _bumpMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x000A7180 File Offset: 0x000A5380
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0000A367 File Offset: 0x00008567
		public unsafe float _bumpStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpStrength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpStrength)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x000A71A8 File Offset: 0x000A53A8
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0000A382 File Offset: 0x00008582
		public unsafe float _bumpDistortionScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionScale)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x000A71D0 File Offset: 0x000A53D0
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0000A39D File Offset: 0x0000859D
		public unsafe Vector2 _bumpDistortionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionOffset)) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000A71F8 File Offset: 0x000A53F8
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public unsafe Texture2D _distortionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x000A7228 File Offset: 0x000A5428
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0000A3D7 File Offset: 0x000085D7
		public unsafe Texture2D _texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x000A7258 File Offset: 0x000A5458
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0000A3F6 File Offset: 0x000085F6
		public unsafe Vector2 _textureScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureScale)) = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000A7280 File Offset: 0x000A5480
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0000A411 File Offset: 0x00008611
		public unsafe Vector2 _textureOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureOffset)) = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000A72A8 File Offset: 0x000A54A8
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x0000A42C File Offset: 0x0000862C
		public unsafe float _distortionAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionAmount)) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000A72D0 File Offset: 0x000A54D0
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0000A447 File Offset: 0x00008647
		public unsafe bool _depthAware
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAware);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAware)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000A72F8 File Offset: 0x000A54F8
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x0000A462 File Offset: 0x00008662
		public unsafe float _depthAwareOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareOffset)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000A7320 File Offset: 0x000A5520
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0000A47D File Offset: 0x0000867D
		public unsafe bool _irregularDepthDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__irregularDepthDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__irregularDepthDebug)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000A7348 File Offset: 0x000A5548
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0000A498 File Offset: 0x00008698
		public unsafe bool _depthAwareCustomPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPass)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000A7370 File Offset: 0x000A5570
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0000A4B3 File Offset: 0x000086B3
		public unsafe bool _depthAwareCustomPassDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPassDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPassDebug)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000A7398 File Offset: 0x000A5598
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x0000A4CE File Offset: 0x000086CE
		public unsafe float _doubleSidedBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__doubleSidedBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__doubleSidedBias)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x000A73C0 File Offset: 0x000A55C0
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0000A4E9 File Offset: 0x000086E9
		public unsafe float _backDepthBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__backDepthBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__backDepthBias)) = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x000A73E8 File Offset: 0x000A55E8
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0000A504 File Offset: 0x00008704
		public unsafe LEVEL_COMPENSATION _rotationLevelCompensation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__rotationLevelCompensation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__rotationLevelCompensation)) = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x000A7410 File Offset: 0x000A5610
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x0000A51F File Offset: 0x0000871F
		public unsafe bool _ignoreGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ignoreGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ignoreGravity)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x000A7438 File Offset: 0x000A5638
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0000A53A File Offset: 0x0000873A
		public unsafe bool _reactToForces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reactToForces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reactToForces)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x000A7460 File Offset: 0x000A5660
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0000A555 File Offset: 0x00008755
		public unsafe Vector3 _extentsScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__extentsScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__extentsScale)) = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x000A7488 File Offset: 0x000A5688
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000A570 File Offset: 0x00008770
		public unsafe int _noiseVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__noiseVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__noiseVariation)) = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x000A74B0 File Offset: 0x000A56B0
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0000A58B File Offset: 0x0000878B
		public unsafe bool _allowViewFromInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__allowViewFromInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__allowViewFromInside)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x000A74D8 File Offset: 0x000A56D8
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0000A5A6 File Offset: 0x000087A6
		public unsafe bool _debugSpillPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__debugSpillPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__debugSpillPoint)) = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x000A7500 File Offset: 0x000A5700
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0000A5C1 File Offset: 0x000087C1
		public unsafe int _renderQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__renderQueue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__renderQueue)) = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x000A7528 File Offset: 0x000A5728
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0000A5DC File Offset: 0x000087DC
		public unsafe Cubemap _reflectionTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reflectionTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reflectionTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x000A7558 File Offset: 0x000A5758
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x0000A5FB File Offset: 0x000087FB
		public unsafe float _physicsMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsMass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsMass)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x000A7580 File Offset: 0x000A5780
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0000A616 File Offset: 0x00008816
		public unsafe float _physicsAngularDamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsAngularDamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsAngularDamp)) = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x000A75A8 File Offset: 0x000A57A8
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000A631 File Offset: 0x00008831
		public unsafe static int SHADER_KEYWORD_DEPTH_AWARE_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX, (void*)(&value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x000A75C4 File Offset: 0x000A57C4
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0000A63F File Offset: 0x0000883F
		public unsafe static int SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX, (void*)(&value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x000A75E0 File Offset: 0x000A57E0
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x0000A64D File Offset: 0x0000884D
		public unsafe static int SHADER_KEYWORD_IGNORE_GRAVITY_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000A75FC File Offset: 0x000A57FC
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x0000A65B File Offset: 0x0000885B
		public unsafe static int SHADER_KEYWORD_NON_AABB_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x000A7618 File Offset: 0x000A5818
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0000A669 File Offset: 0x00008869
		public unsafe static int SHADER_KEYWORD_TOPOLOGY_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x000A7634 File Offset: 0x000A5834
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x0000A677 File Offset: 0x00008877
		public unsafe static int SHADER_KEYWORD_REFRACTION_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x000A7650 File Offset: 0x000A5850
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0000A685 File Offset: 0x00008885
		public unsafe static string SHADER_KEYWORD_DEPTH_AWARE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x000A7670 File Offset: 0x000A5870
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0000A697 File Offset: 0x00008897
		public unsafe static string SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x000A7690 File Offset: 0x000A5890
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x0000A6A9 File Offset: 0x000088A9
		public unsafe static string SHADER_KEYWORD_NON_AABB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x000A76B0 File Offset: 0x000A58B0
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0000A6BB File Offset: 0x000088BB
		public unsafe static string SHADER_KEYWORD_IGNORE_GRAVITY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x000A76D0 File Offset: 0x000A58D0
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0000A6CD File Offset: 0x000088CD
		public unsafe static string SHADER_KEYWORD_SPHERE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x000A76F0 File Offset: 0x000A58F0
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0000A6DF File Offset: 0x000088DF
		public unsafe static string SHADER_KEYWORD_CUBE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CUBE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CUBE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000A7710 File Offset: 0x000A5910
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0000A6F1 File Offset: 0x000088F1
		public unsafe static string SHADER_KEYWORD_CYLINDER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x000A7730 File Offset: 0x000A5930
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0000A703 File Offset: 0x00008903
		public unsafe static string SHADER_KEYWORD_IRREGULAR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x000A7750 File Offset: 0x000A5950
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0000A715 File Offset: 0x00008915
		public unsafe static string SHADER_KEYWORD_FP_RENDER_TEXTURE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000A7770 File Offset: 0x000A5970
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0000A727 File Offset: 0x00008927
		public unsafe static string SHADER_KEYWORD_USE_REFRACTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x000A7790 File Offset: 0x000A5990
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0000A739 File Offset: 0x00008939
		public unsafe static string SPILL_POINT_GIZMO
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SPILL_POINT_GIZMO, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SPILL_POINT_GIZMO, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000A77B0 File Offset: 0x000A59B0
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x0000A74B File Offset: 0x0000894B
		public unsafe Material liqMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000A77E0 File Offset: 0x000A59E0
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0000A76A File Offset: 0x0000896A
		public unsafe Material liqMatSimple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatSimple);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatSimple), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000A7810 File Offset: 0x000A5A10
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000A789 File Offset: 0x00008989
		public unsafe Material liqMatDefaultNoFlask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatDefaultNoFlask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatDefaultNoFlask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x000A7840 File Offset: 0x000A5A40
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0000A7A8 File Offset: 0x000089A8
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000A7870 File Offset: 0x000A5A70
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0000A7C7 File Offset: 0x000089C7
		public unsafe Renderer mr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000A78A0 File Offset: 0x000A5AA0
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0000A7E6 File Offset: 0x000089E6
		public unsafe static List<Material> mrSharedMaterials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_mrSharedMaterials, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_mrSharedMaterials, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x000A78C8 File Offset: 0x000A5AC8
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0000A7F8 File Offset: 0x000089F8
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x000A78F0 File Offset: 0x000A5AF0
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0000A813 File Offset: 0x00008A13
		public unsafe Vector3 lastScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastScale)) = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000A7918 File Offset: 0x000A5B18
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0000A82E File Offset: 0x00008A2E
		public unsafe Quaternion lastRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastRotation)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x000A7940 File Offset: 0x000A5B40
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0000A849 File Offset: 0x00008A49
		public unsafe Il2CppStringArray shaderKeywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderKeywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderKeywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x000A7970 File Offset: 0x000A5B70
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0000A868 File Offset: 0x00008A68
		public unsafe bool camInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_camInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_camInside)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x000A7998 File Offset: 0x000A5B98
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0000A883 File Offset: 0x00008A83
		public unsafe float lastDistanceToCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastDistanceToCam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastDistanceToCam)) = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x000A79C0 File Offset: 0x000A5BC0
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0000A89E File Offset: 0x00008A9E
		public unsafe DETAIL currentDetail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentDetail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentDetail)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x000A79E8 File Offset: 0x000A5BE8
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0000A8B9 File Offset: 0x00008AB9
		public unsafe Vector4 turb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turb)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x000A7A10 File Offset: 0x000A5C10
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public unsafe Vector4 shaderTurb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderTurb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderTurb)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x000A7A38 File Offset: 0x000A5C38
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0000A8EF File Offset: 0x00008AEF
		public unsafe float turbulenceSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceSpeed)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000A7A60 File Offset: 0x000A5C60
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0000A90A File Offset: 0x00008B0A
		public unsafe float murkinessSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_murkinessSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_murkinessSpeed)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x000A7A88 File Offset: 0x000A5C88
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0000A925 File Offset: 0x00008B25
		public unsafe float liquidLevelPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidLevelPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidLevelPos)) = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x000A7AB0 File Offset: 0x000A5CB0
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0000A940 File Offset: 0x00008B40
		public unsafe bool shouldUpdateMaterialProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shouldUpdateMaterialProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shouldUpdateMaterialProperties)) = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000A7AD8 File Offset: 0x000A5CD8
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0000A95B File Offset: 0x00008B5B
		public unsafe int currentNoiseVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentNoiseVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentNoiseVariation)) = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x000A7B00 File Offset: 0x000A5D00
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0000A976 File Offset: 0x00008B76
		public unsafe float levelMultipled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_levelMultipled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_levelMultipled)) = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000A7B28 File Offset: 0x000A5D28
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0000A991 File Offset: 0x00008B91
		public unsafe Texture2D noise3DUnwrapped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DUnwrapped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DUnwrapped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000A7B58 File Offset: 0x000A5D58
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public unsafe Il2CppReferenceArray<Texture3D> noise3DTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000A7B88 File Offset: 0x000A5D88
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0000A9CF File Offset: 0x00008BCF
		public unsafe Il2CppReferenceArray<Il2CppStructArray<Color>> colors3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_colors3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Color>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_colors3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000A7BB8 File Offset: 0x000A5DB8
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0000A9EE File Offset: 0x00008BEE
		public unsafe Il2CppStructArray<Vector3> verticesUnsorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesUnsorted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesUnsorted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000A7BE8 File Offset: 0x000A5DE8
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0000AA0D File Offset: 0x00008C0D
		public unsafe Il2CppStructArray<Vector3> verticesSorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesSorted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesSorted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000A7C18 File Offset: 0x000A5E18
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public unsafe static Il2CppStructArray<Vector3> rotatedVertices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_rotatedVertices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_rotatedVertices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000A7C40 File Offset: 0x000A5E40
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x0000AA3E File Offset: 0x00008C3E
		public unsafe Il2CppStructArray<int> verticesIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x000A7C70 File Offset: 0x000A5E70
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0000AA5D File Offset: 0x00008C5D
		public unsafe float volumeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_volumeRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_volumeRef)) = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x000A7C98 File Offset: 0x000A5E98
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000AA78 File Offset: 0x00008C78
		public unsafe float lastLevelVolumeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastLevelVolumeRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastLevelVolumeRef)) = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x000A7CC0 File Offset: 0x000A5EC0
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0000AA93 File Offset: 0x00008C93
		public unsafe Vector3 inertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_inertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_inertia)) = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x000A7CE8 File Offset: 0x000A5EE8
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0000AAAE File Offset: 0x00008CAE
		public unsafe Vector3 lastAvgVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastAvgVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastAvgVelocity)) = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000A7D10 File Offset: 0x000A5F10
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0000AAC9 File Offset: 0x00008CC9
		public unsafe float angularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularVelocity)) = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000A7D38 File Offset: 0x000A5F38
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		public unsafe float angularInertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularInertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularInertia)) = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000A7D60 File Offset: 0x000A5F60
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0000AAFF File Offset: 0x00008CFF
		public unsafe float turbulenceDueForces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceDueForces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceDueForces)) = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000A7D88 File Offset: 0x000A5F88
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000AB1A File Offset: 0x00008D1A
		public unsafe Quaternion liquidRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidRot)) = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000A7DB0 File Offset: 0x000A5FB0
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0000AB35 File Offset: 0x00008D35
		public unsafe float prevThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_prevThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_prevThickness)) = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x000A7DD8 File Offset: 0x000A5FD8
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0000AB50 File Offset: 0x00008D50
		public unsafe GameObject spillPointGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_spillPointGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_spillPointGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000A7E08 File Offset: 0x000A6008
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0000AB6F File Offset: 0x00008D6F
		public unsafe static Il2CppStringArray defaultContainerNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_defaultContainerNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_defaultContainerNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x000A7E30 File Offset: 0x000A6030
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0000AB81 File Offset: 0x00008D81
		public unsafe Il2CppStructArray<Color> pointLightColorBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightColorBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightColorBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000A7E60 File Offset: 0x000A6060
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		public unsafe Il2CppStructArray<Vector4> pointLightPositionBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightPositionBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightPositionBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000A7E90 File Offset: 0x000A6090
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0000ABBF File Offset: 0x00008DBF
		public unsafe int lastPointLightCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPointLightCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPointLightCount)) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000A7EB8 File Offset: 0x000A60B8
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0000ABDA File Offset: 0x00008DDA
		public unsafe static Dictionary<Mesh, LiquidVolume.MeshCache> meshCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_meshCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Mesh, LiquidVolume.MeshCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_meshCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000A7EE0 File Offset: 0x000A60E0
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000ABEC File Offset: 0x00008DEC
		public unsafe List<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000A7F10 File Offset: 0x000A6110
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0000AC0B File Offset: 0x00008E0B
		public unsafe List<Vector3> cutPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000A7F40 File Offset: 0x000A6140
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0000AC2A File Offset: 0x00008E2A
		public unsafe Vector3 cutPlaneCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPlaneCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPlaneCenter)) = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000A7F68 File Offset: 0x000A6168
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000AC45 File Offset: 0x00008E45
		public unsafe Mesh fixedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_fixedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_fixedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_onPropertiesChanged;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr__topology;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr__detail;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr__level;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeFieldInfoPtr__levelMultiplier;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr__useLightColor;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeFieldInfoPtr__useLightDirection;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeFieldInfoPtr__directionalLight;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeFieldInfoPtr__liquidColor1;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeFieldInfoPtr__liquidScale1;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeFieldInfoPtr__liquidColor2;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr__liquidScale2;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr__alpha;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr__emissionColor;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr__ditherShadows;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr__murkiness;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr__turbulence1;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr__turbulence2;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr__frecuency;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr__sparklingIntensity;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr__sparklingAmount;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr__deepObscurance;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr__foamColor;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeFieldInfoPtr__foamScale;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeFieldInfoPtr__foamThickness;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeFieldInfoPtr__foamDensity;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr__foamWeight;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr__foamTurbulence;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr__foamVisibleFromBottom;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr__smokeEnabled;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeFieldInfoPtr__smokeColor;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr__smokeScale;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr__smokeBaseObscurance;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr__smokeHeightAtten;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr__smokeSpeed;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr__fixMesh;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_originalMesh;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_originalPivotOffset;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr__pivotOffset;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr__limitVerticalRange;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr__upperLimit;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr__lowerLimit;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr__subMeshIndex;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr__flaskMaterial;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr__flaskThickness;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr__glossinessInternal;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr__scatteringEnabled;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr__scatteringPower;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr__scatteringAmount;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr__refractionBlur;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr__blurIntensity;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr__liquidRaySteps;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr__foamRaySteps;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr__smokeRaySteps;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeFieldInfoPtr__bumpMap;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr__bumpStrength;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr__bumpDistortionScale;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr__bumpDistortionOffset;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr__distortionMap;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr__texture;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeFieldInfoPtr__textureScale;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr__textureOffset;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr__distortionAmount;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr__depthAware;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeFieldInfoPtr__depthAwareOffset;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr__irregularDepthDebug;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr__depthAwareCustomPass;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr__depthAwareCustomPassDebug;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr__doubleSidedBias;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr__backDepthBias;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr__rotationLevelCompensation;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr__ignoreGravity;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr__reactToForces;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr__extentsScale;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr__noiseVariation;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeFieldInfoPtr__allowViewFromInside;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr__debugSpillPoint;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr__renderQueue;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr__reflectionTexture;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr__physicsMass;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeFieldInfoPtr__physicsAngularDamp;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_CUBE;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_SPILL_POINT_GIZMO;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_liqMat;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_liqMatSimple;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_liqMatDefaultNoFlask;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_mr;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_mrSharedMaterials;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_lastScale;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_lastRotation;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_shaderKeywords;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_camInside;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_lastDistanceToCam;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_currentDetail;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_turb;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_shaderTurb;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_turbulenceSpeed;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_murkinessSpeed;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr_liquidLevelPos;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr_shouldUpdateMaterialProperties;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeFieldInfoPtr_currentNoiseVariation;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr_levelMultipled;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeFieldInfoPtr_noise3DUnwrapped;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeFieldInfoPtr_noise3DTex;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeFieldInfoPtr_colors3D;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_verticesUnsorted;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_verticesSorted;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_rotatedVertices;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeFieldInfoPtr_verticesIndices;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeFieldInfoPtr_volumeRef;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeFieldInfoPtr_lastLevelVolumeRef;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_inertia;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_lastAvgVelocity;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_angularVelocity;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeFieldInfoPtr_angularInertia;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_turbulenceDueForces;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeFieldInfoPtr_liquidRot;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeFieldInfoPtr_prevThickness;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeFieldInfoPtr_spillPointGizmo;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeFieldInfoPtr_defaultContainerNames;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeFieldInfoPtr_pointLightColorBuffer;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeFieldInfoPtr_pointLightPositionBuffer;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr_lastPointLightCount;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr_meshCache;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_cutPoints;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_cutPlaneCenter;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_fixedMesh;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_add_onPropertiesChanged_Public_add_Void_PropertiesChangedEvent_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_remove_onPropertiesChanged_Public_rem_Void_PropertiesChangedEvent_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_get_topology_Public_get_TOPOLOGY_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_set_topology_Public_set_Void_TOPOLOGY_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_detail_Public_get_DETAIL_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_set_detail_Public_set_Void_DETAIL_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_get_level_Public_get_Single_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_set_level_Public_set_Void_Single_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_get_levelMultiplier_Public_get_Single_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_set_levelMultiplier_Public_set_Void_Single_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_get_useLightColor_Public_get_Boolean_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_set_useLightColor_Public_set_Void_Boolean_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_get_useLightDirection_Public_get_Boolean_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_set_useLightDirection_Public_set_Void_Boolean_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_get_directionalLight_Public_get_Light_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_set_directionalLight_Public_set_Void_Light_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidColor1_Public_get_Color_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidColor1_Public_set_Void_Color_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidScale1_Public_get_Single_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidScale1_Public_set_Void_Single_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidColor2_Public_get_Color_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidColor2_Public_set_Void_Color_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidScale2_Public_get_Single_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidScale2_Public_set_Void_Single_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_get_emissionColor_Public_get_Color_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_set_emissionColor_Public_set_Void_Color_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_get_ditherShadows_Public_get_Boolean_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_set_ditherShadows_Public_set_Void_Boolean_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_get_murkiness_Public_get_Single_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_set_murkiness_Public_set_Void_Single_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_get_turbulence1_Public_get_Single_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_set_turbulence1_Public_set_Void_Single_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_get_turbulence2_Public_get_Single_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_set_turbulence2_Public_set_Void_Single_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_get_frecuency_Public_get_Single_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_set_frecuency_Public_set_Void_Single_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Public_get_Single_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_set_speed_Public_set_Void_Single_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_get_sparklingIntensity_Public_get_Single_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_set_sparklingIntensity_Public_set_Void_Single_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_sparklingAmount_Public_get_Single_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_set_sparklingAmount_Public_set_Void_Single_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_get_deepObscurance_Public_get_Single_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_set_deepObscurance_Public_set_Void_Single_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_get_foamColor_Public_get_Color_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_set_foamColor_Public_set_Void_Color_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_foamScale_Public_get_Single_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_set_foamScale_Public_set_Void_Single_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_get_foamThickness_Public_get_Single_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_set_foamThickness_Public_set_Void_Single_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_get_foamDensity_Public_get_Single_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_set_foamDensity_Public_set_Void_Single_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_get_foamWeight_Public_get_Single_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_set_foamWeight_Public_set_Void_Single_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_get_foamTurbulence_Public_get_Single_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_set_foamTurbulence_Public_set_Void_Single_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_get_foamVisibleFromBottom_Public_get_Boolean_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_set_foamVisibleFromBottom_Public_set_Void_Boolean_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeEnabled_Public_get_Boolean_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeColor_Public_get_Color_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeColor_Public_set_Void_Color_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeScale_Public_get_Single_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeScale_Public_set_Void_Single_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeBaseObscurance_Public_get_Single_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeBaseObscurance_Public_set_Void_Single_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeHeightAtten_Public_get_Single_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeHeightAtten_Public_set_Void_Single_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeSpeed_Public_get_Single_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeSpeed_Public_set_Void_Single_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_get_fixMesh_Public_get_Boolean_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_set_fixMesh_Public_set_Void_Boolean_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_get_pivotOffset_Public_get_Vector3_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_set_pivotOffset_Public_set_Void_Vector3_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_limitVerticalRange_Public_get_Boolean_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_set_limitVerticalRange_Public_set_Void_Boolean_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_get_upperLimit_Public_get_Single_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_set_upperLimit_Public_set_Void_Single_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_get_lowerLimit_Public_get_Single_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_set_lowerLimit_Public_set_Void_Single_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshIndex_Public_get_Int32_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_get_flaskMaterial_Public_get_Material_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_set_flaskMaterial_Public_set_Void_Material_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_get_flaskThickness_Public_get_Single_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_set_flaskThickness_Public_set_Void_Single_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_get_glossinessInternal_Public_get_Single_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_set_glossinessInternal_Public_set_Void_Single_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_get_scatteringEnabled_Public_get_Boolean_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_set_scatteringEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_get_scatteringPower_Public_get_Int32_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_set_scatteringPower_Public_set_Void_Int32_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_get_scatteringAmount_Public_get_Single_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_set_scatteringAmount_Public_set_Void_Single_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_get_refractionBlur_Public_get_Boolean_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_set_refractionBlur_Public_set_Void_Boolean_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_get_blurIntensity_Public_get_Single_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_set_blurIntensity_Public_set_Void_Single_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidRaySteps_Public_get_Int32_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidRaySteps_Public_set_Void_Int32_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_get_foamRaySteps_Public_get_Int32_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_set_foamRaySteps_Public_set_Void_Int32_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeRaySteps_Public_get_Int32_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeRaySteps_Public_set_Void_Int32_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpMap_Public_get_Texture2D_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpMap_Public_set_Void_Texture2D_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpStrength_Public_get_Single_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpStrength_Public_set_Void_Single_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpDistortionScale_Public_get_Single_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpDistortionScale_Public_set_Void_Single_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpDistortionOffset_Public_get_Vector2_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpDistortionOffset_Public_set_Void_Vector2_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_get_distortionMap_Public_get_Texture2D_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_set_distortionMap_Public_set_Void_Texture2D_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_get_textureOffset_Public_get_Vector2_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_set_textureOffset_Public_set_Void_Vector2_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_get_distortionAmount_Public_get_Single_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_set_distortionAmount_Public_set_Void_Single_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAware_Public_get_Boolean_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAware_Public_set_Void_Boolean_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAwareOffset_Public_get_Single_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAwareOffset_Public_set_Void_Single_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_get_irregularDepthDebug_Public_get_Boolean_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_set_irregularDepthDebug_Public_set_Void_Boolean_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAwareCustomPass_Public_get_Boolean_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAwareCustomPass_Public_set_Void_Boolean_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAwareCustomPassDebug_Public_get_Boolean_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAwareCustomPassDebug_Public_set_Void_Boolean_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_get_doubleSidedBias_Public_get_Single_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_set_doubleSidedBias_Public_set_Void_Single_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_get_backDepthBias_Public_get_Single_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_set_backDepthBias_Public_set_Void_Single_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationLevelCompensation_Public_get_LEVEL_COMPENSATION_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_set_rotationLevelCompensation_Public_set_Void_LEVEL_COMPENSATION_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreGravity_Public_get_Boolean_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreGravity_Public_set_Void_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_get_reactToForces_Public_get_Boolean_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_set_reactToForces_Public_set_Void_Boolean_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_get_extentsScale_Public_get_Vector3_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_set_extentsScale_Public_set_Void_Vector3_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseVariation_Public_get_Int32_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseVariation_Public_set_Void_Int32_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_get_allowViewFromInside_Public_get_Boolean_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_set_allowViewFromInside_Public_set_Void_Boolean_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_get_debugSpillPoint_Public_get_Boolean_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_set_debugSpillPoint_Public_set_Void_Boolean_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionTexture_Public_get_Cubemap_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionTexture_Public_set_Void_Cubemap_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_get_physicsMass_Public_get_Single_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_set_physicsMass_Public_set_Void_Single_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_get_physicsAngularDamp_Public_get_Single_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_set_physicsAngularDamp_Public_set_Void_Single_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_get_useFPRenderTextures_Public_Static_get_Boolean_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_RenderObject_Private_Void_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_ClearMeshCache_Public_Void_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_ReadVertices_Private_Void_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_vertexComparer_Private_Int32_Vector3_Vector3_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimations_Private_Void_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialProperties_Public_Void_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialPropertiesNow_Private_Void_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGlobalAlpha_Private_Color_Color_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderer_Private_Void_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLevels_Private_Void_Boolean_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_RotateVertices_Private_Void_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_SignedVolumeOfTriangle_Private_Single_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevelFast_Public_Single_Single_Single_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeWSFast_Public_Single_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevelWSFast_Public_Single_Single_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_ClampVertexToSlicePlane_Private_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevel_Public_Single_Single_Single_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeWS_Public_Single_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevelWS_Public_Single_Single_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_PolygonSortOnPlane_Private_Int32_Vector3_Vector3_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTurbulence_Private_Void_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_CheckInsideOut_Private_Void_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_PointInAABB_Private_Boolean_Vector3_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_PointInCylinder_Private_Boolean_Vector3_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInsideOut_Private_Void_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidSurfaceYPosition_Public_get_Single_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_Single_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_byref_Single_Single_LEVEL_COMPENSATION_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpillPointGizmo_Private_Void_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_BakeRotation_Public_Void_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_CenterPivot_Public_Void_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_CenterPivot_Public_Void_Vector3_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_RefreshMeshAndCollider_Public_Void_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_Redraw_Public_Void_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_CheckMeshDisplacement_Private_Void_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_RestoreOriginalMesh_Private_Void_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_LiquidVolume_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000847 RID: 2119
		public sealed class MeshCache : ValueType
		{
			// Token: 0x0600BF99 RID: 49049 RVA: 0x002EEFCC File Offset: 0x002ED1CC
			// Note: this type is marked as 'beforefieldinit'.
			static MeshCache()
			{
				Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "MeshCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr);
				LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr, "verticesSorted");
				LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesUnsorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr, "verticesUnsorted");
				LiquidVolume.MeshCache.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr, "indices");
			}

			// Token: 0x0600BF9A RID: 49050 RVA: 0x0005D9D2 File Offset: 0x0005BBD2
			public MeshCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BF9B RID: 49051 RVA: 0x0005D9DB File Offset: 0x0005BBDB
			public MeshCache() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr))
			{
			}

			// Token: 0x17003B9A RID: 15258
			// (get) Token: 0x0600BF9C RID: 49052 RVA: 0x002EF034 File Offset: 0x002ED234
			// (set) Token: 0x0600BF9D RID: 49053 RVA: 0x0005D9ED File Offset: 0x0005BBED
			public unsafe Il2CppStructArray<Vector3> verticesSorted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesSorted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesSorted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9B RID: 15259
			// (get) Token: 0x0600BF9E RID: 49054 RVA: 0x002EF064 File Offset: 0x002ED264
			// (set) Token: 0x0600BF9F RID: 49055 RVA: 0x0005DA0C File Offset: 0x0005BC0C
			public unsafe Il2CppStructArray<Vector3> verticesUnsorted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesUnsorted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesUnsorted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9C RID: 15260
			// (get) Token: 0x0600BFA0 RID: 49056 RVA: 0x002EF094 File Offset: 0x002ED294
			// (set) Token: 0x0600BFA1 RID: 49057 RVA: 0x0005DA2B File Offset: 0x0005BC2B
			public unsafe Il2CppStructArray<int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040081D6 RID: 33238
			private static readonly IntPtr NativeFieldInfoPtr_verticesSorted;

			// Token: 0x040081D7 RID: 33239
			private static readonly IntPtr NativeFieldInfoPtr_verticesUnsorted;

			// Token: 0x040081D8 RID: 33240
			private static readonly IntPtr NativeFieldInfoPtr_indices;
		}

		// Token: 0x02000848 RID: 2120
		public sealed class MeshVolumeCalcFunction : MulticastDelegate
		{
			// Token: 0x0600BFA2 RID: 49058 RVA: 0x002EF0C4 File Offset: 0x002ED2C4
			// Note: this type is marked as 'beforefieldinit'.
			static MeshVolumeCalcFunction()
			{
				Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "MeshVolumeCalcFunction");
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100665312);
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100665313);
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100665314);
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100665315);
			}

			// Token: 0x0600BFA3 RID: 49059 RVA: 0x002EF138 File Offset: 0x002ED338
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86389, RefRangeEnd = 86391, XrefRangeStart = 86386, XrefRangeEnd = 86389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshVolumeCalcFunction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BFA4 RID: 49060 RVA: 0x002EF194 File Offset: 0x002ED394
			[CallerCount(0)]
			public unsafe float Invoke(float level01, float yExtent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref level01;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BFA5 RID: 49061 RVA: 0x002EF1EC File Offset: 0x002ED3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86391, XrefRangeEnd = 86397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(float level01, float yExtent, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref level01;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BFA6 RID: 49062 RVA: 0x002EF26C File Offset: 0x002ED46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BFA7 RID: 49063 RVA: 0x0005DA4A File Offset: 0x0005BC4A
			public MeshVolumeCalcFunction(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BFA8 RID: 49064 RVA: 0x0005DA53 File Offset: 0x0005BC53
			public static implicit operator LiquidVolume.MeshVolumeCalcFunction(Func<float, float, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<LiquidVolume.MeshVolumeCalcFunction>(A_0);
			}

			// Token: 0x0600BFA9 RID: 49065 RVA: 0x0005DA5B File Offset: 0x0005BC5B
			public static LiquidVolume.MeshVolumeCalcFunction operator +(LiquidVolume.MeshVolumeCalcFunction A_0, LiquidVolume.MeshVolumeCalcFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LiquidVolume.MeshVolumeCalcFunction>();
			}

			// Token: 0x0600BFAA RID: 49066 RVA: 0x0005DA69 File Offset: 0x0005BC69
			public static LiquidVolume.MeshVolumeCalcFunction operator -(LiquidVolume.MeshVolumeCalcFunction A_0, LiquidVolume.MeshVolumeCalcFunction A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<LiquidVolume.MeshVolumeCalcFunction>();
				}
				return result;
			}

			// Token: 0x040081D9 RID: 33241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040081DA RID: 33242
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_0;

			// Token: 0x040081DB RID: 33243
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_AsyncCallback_Object_0;

			// Token: 0x040081DC RID: 33244
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
		}

		// Token: 0x02000849 RID: 2121
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600BFAB RID: 49067 RVA: 0x002EF2BC File Offset: 0x002ED4BC
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr);
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightInsideAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightInsideAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightColorArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightColorArray");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightPositionArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightPositionArray");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightCount");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlossinessInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "GlossinessInt");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_DoubleSidedBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "DoubleSidedBias");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_BackDepthBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "BackDepthBias");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Muddy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Muddy");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Alpha");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_AlphaCombined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "AlphaCombined");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SparklingIntensity");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SparklingThreshold");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "DepthAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeSpeed");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeHeightAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeHeightAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeRaySteps");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LiquidRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LiquidRaySteps");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskBlurIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FlaskBlurIntensity");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamRaySteps");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamDensity");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamWeight");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamBottom");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamTurbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamTurbulence");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_RefractTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "RefractTex");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FlaskThickness");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Size");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Scale");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Center");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SizeWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SizeWorld");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAwareOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "DepthAwareOffset");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Turbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Turbulence");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_TurbulenceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "TurbulenceSpeed");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_MurkinessSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "MurkinessSpeed");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Color1");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Color2");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_EmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "EmissionColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LightColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LightDir");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LevelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LevelPos");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_UpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "UpperLimit");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LowerLimit");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamMaxPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamMaxPos");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_CullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "CullMode");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_ZTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "ZTestMode");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "NoiseTex");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTexUnwrapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "NoiseTexUnwrapped");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlobalRefractionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "GlobalRefractionTexture");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_RotationMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "RotationMatrix");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_QueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "QueueOffset");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PreserveSpecular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PreserveSpecular");
			}

			// Token: 0x0600BFAC RID: 49068 RVA: 0x0005DA7A File Offset: 0x0005BC7A
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B9D RID: 15261
			// (get) Token: 0x0600BFAD RID: 49069 RVA: 0x002EF70C File Offset: 0x002ED90C
			// (set) Token: 0x0600BFAE RID: 49070 RVA: 0x0005DA83 File Offset: 0x0005BC83
			public unsafe static int PointLightInsideAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightInsideAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightInsideAtten, (void*)(&value));
				}
			}

			// Token: 0x17003B9E RID: 15262
			// (get) Token: 0x0600BFAF RID: 49071 RVA: 0x002EF728 File Offset: 0x002ED928
			// (set) Token: 0x0600BFB0 RID: 49072 RVA: 0x0005DA91 File Offset: 0x0005BC91
			public unsafe static int PointLightColorArray
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightColorArray, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightColorArray, (void*)(&value));
				}
			}

			// Token: 0x17003B9F RID: 15263
			// (get) Token: 0x0600BFB1 RID: 49073 RVA: 0x002EF744 File Offset: 0x002ED944
			// (set) Token: 0x0600BFB2 RID: 49074 RVA: 0x0005DA9F File Offset: 0x0005BC9F
			public unsafe static int PointLightPositionArray
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightPositionArray, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightPositionArray, (void*)(&value));
				}
			}

			// Token: 0x17003BA0 RID: 15264
			// (get) Token: 0x0600BFB3 RID: 49075 RVA: 0x002EF760 File Offset: 0x002ED960
			// (set) Token: 0x0600BFB4 RID: 49076 RVA: 0x0005DAAD File Offset: 0x0005BCAD
			public unsafe static int PointLightCount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightCount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightCount, (void*)(&value));
				}
			}

			// Token: 0x17003BA1 RID: 15265
			// (get) Token: 0x0600BFB5 RID: 49077 RVA: 0x002EF77C File Offset: 0x002ED97C
			// (set) Token: 0x0600BFB6 RID: 49078 RVA: 0x0005DABB File Offset: 0x0005BCBB
			public unsafe static int GlossinessInt
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlossinessInt, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlossinessInt, (void*)(&value));
				}
			}

			// Token: 0x17003BA2 RID: 15266
			// (get) Token: 0x0600BFB7 RID: 49079 RVA: 0x002EF798 File Offset: 0x002ED998
			// (set) Token: 0x0600BFB8 RID: 49080 RVA: 0x0005DAC9 File Offset: 0x0005BCC9
			public unsafe static int DoubleSidedBias
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DoubleSidedBias, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DoubleSidedBias, (void*)(&value));
				}
			}

			// Token: 0x17003BA3 RID: 15267
			// (get) Token: 0x0600BFB9 RID: 49081 RVA: 0x002EF7B4 File Offset: 0x002ED9B4
			// (set) Token: 0x0600BFBA RID: 49082 RVA: 0x0005DAD7 File Offset: 0x0005BCD7
			public unsafe static int BackDepthBias
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_BackDepthBias, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_BackDepthBias, (void*)(&value));
				}
			}

			// Token: 0x17003BA4 RID: 15268
			// (get) Token: 0x0600BFBB RID: 49083 RVA: 0x002EF7D0 File Offset: 0x002ED9D0
			// (set) Token: 0x0600BFBC RID: 49084 RVA: 0x0005DAE5 File Offset: 0x0005BCE5
			public unsafe static int Muddy
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Muddy, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Muddy, (void*)(&value));
				}
			}

			// Token: 0x17003BA5 RID: 15269
			// (get) Token: 0x0600BFBD RID: 49085 RVA: 0x002EF7EC File Offset: 0x002ED9EC
			// (set) Token: 0x0600BFBE RID: 49086 RVA: 0x0005DAF3 File Offset: 0x0005BCF3
			public unsafe static int Alpha
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Alpha, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Alpha, (void*)(&value));
				}
			}

			// Token: 0x17003BA6 RID: 15270
			// (get) Token: 0x0600BFBF RID: 49087 RVA: 0x002EF808 File Offset: 0x002EDA08
			// (set) Token: 0x0600BFC0 RID: 49088 RVA: 0x0005DB01 File Offset: 0x0005BD01
			public unsafe static int AlphaCombined
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_AlphaCombined, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_AlphaCombined, (void*)(&value));
				}
			}

			// Token: 0x17003BA7 RID: 15271
			// (get) Token: 0x0600BFC1 RID: 49089 RVA: 0x002EF824 File Offset: 0x002EDA24
			// (set) Token: 0x0600BFC2 RID: 49090 RVA: 0x0005DB0F File Offset: 0x0005BD0F
			public unsafe static int SparklingIntensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingIntensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingIntensity, (void*)(&value));
				}
			}

			// Token: 0x17003BA8 RID: 15272
			// (get) Token: 0x0600BFC3 RID: 49091 RVA: 0x002EF840 File Offset: 0x002EDA40
			// (set) Token: 0x0600BFC4 RID: 49092 RVA: 0x0005DB1D File Offset: 0x0005BD1D
			public unsafe static int SparklingThreshold
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingThreshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingThreshold, (void*)(&value));
				}
			}

			// Token: 0x17003BA9 RID: 15273
			// (get) Token: 0x0600BFC5 RID: 49093 RVA: 0x002EF85C File Offset: 0x002EDA5C
			// (set) Token: 0x0600BFC6 RID: 49094 RVA: 0x0005DB2B File Offset: 0x0005BD2B
			public unsafe static int DepthAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAtten, (void*)(&value));
				}
			}

			// Token: 0x17003BAA RID: 15274
			// (get) Token: 0x0600BFC7 RID: 49095 RVA: 0x002EF878 File Offset: 0x002EDA78
			// (set) Token: 0x0600BFC8 RID: 49096 RVA: 0x0005DB39 File Offset: 0x0005BD39
			public unsafe static int SmokeColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeColor, (void*)(&value));
				}
			}

			// Token: 0x17003BAB RID: 15275
			// (get) Token: 0x0600BFC9 RID: 49097 RVA: 0x002EF894 File Offset: 0x002EDA94
			// (set) Token: 0x0600BFCA RID: 49098 RVA: 0x0005DB47 File Offset: 0x0005BD47
			public unsafe static int SmokeAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeAtten, (void*)(&value));
				}
			}

			// Token: 0x17003BAC RID: 15276
			// (get) Token: 0x0600BFCB RID: 49099 RVA: 0x002EF8B0 File Offset: 0x002EDAB0
			// (set) Token: 0x0600BFCC RID: 49100 RVA: 0x0005DB55 File Offset: 0x0005BD55
			public unsafe static int SmokeSpeed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeSpeed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeSpeed, (void*)(&value));
				}
			}

			// Token: 0x17003BAD RID: 15277
			// (get) Token: 0x0600BFCD RID: 49101 RVA: 0x002EF8CC File Offset: 0x002EDACC
			// (set) Token: 0x0600BFCE RID: 49102 RVA: 0x0005DB63 File Offset: 0x0005BD63
			public unsafe static int SmokeHeightAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeHeightAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeHeightAtten, (void*)(&value));
				}
			}

			// Token: 0x17003BAE RID: 15278
			// (get) Token: 0x0600BFCF RID: 49103 RVA: 0x002EF8E8 File Offset: 0x002EDAE8
			// (set) Token: 0x0600BFD0 RID: 49104 RVA: 0x0005DB71 File Offset: 0x0005BD71
			public unsafe static int SmokeRaySteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeRaySteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeRaySteps, (void*)(&value));
				}
			}

			// Token: 0x17003BAF RID: 15279
			// (get) Token: 0x0600BFD1 RID: 49105 RVA: 0x002EF904 File Offset: 0x002EDB04
			// (set) Token: 0x0600BFD2 RID: 49106 RVA: 0x0005DB7F File Offset: 0x0005BD7F
			public unsafe static int LiquidRaySteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LiquidRaySteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LiquidRaySteps, (void*)(&value));
				}
			}

			// Token: 0x17003BB0 RID: 15280
			// (get) Token: 0x0600BFD3 RID: 49107 RVA: 0x002EF920 File Offset: 0x002EDB20
			// (set) Token: 0x0600BFD4 RID: 49108 RVA: 0x0005DB8D File Offset: 0x0005BD8D
			public unsafe static int FlaskBlurIntensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskBlurIntensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskBlurIntensity, (void*)(&value));
				}
			}

			// Token: 0x17003BB1 RID: 15281
			// (get) Token: 0x0600BFD5 RID: 49109 RVA: 0x002EF93C File Offset: 0x002EDB3C
			// (set) Token: 0x0600BFD6 RID: 49110 RVA: 0x0005DB9B File Offset: 0x0005BD9B
			public unsafe static int FoamColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamColor, (void*)(&value));
				}
			}

			// Token: 0x17003BB2 RID: 15282
			// (get) Token: 0x0600BFD7 RID: 49111 RVA: 0x002EF958 File Offset: 0x002EDB58
			// (set) Token: 0x0600BFD8 RID: 49112 RVA: 0x0005DBA9 File Offset: 0x0005BDA9
			public unsafe static int FoamRaySteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamRaySteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamRaySteps, (void*)(&value));
				}
			}

			// Token: 0x17003BB3 RID: 15283
			// (get) Token: 0x0600BFD9 RID: 49113 RVA: 0x002EF974 File Offset: 0x002EDB74
			// (set) Token: 0x0600BFDA RID: 49114 RVA: 0x0005DBB7 File Offset: 0x0005BDB7
			public unsafe static int FoamDensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamDensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamDensity, (void*)(&value));
				}
			}

			// Token: 0x17003BB4 RID: 15284
			// (get) Token: 0x0600BFDB RID: 49115 RVA: 0x002EF990 File Offset: 0x002EDB90
			// (set) Token: 0x0600BFDC RID: 49116 RVA: 0x0005DBC5 File Offset: 0x0005BDC5
			public unsafe static int FoamWeight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamWeight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamWeight, (void*)(&value));
				}
			}

			// Token: 0x17003BB5 RID: 15285
			// (get) Token: 0x0600BFDD RID: 49117 RVA: 0x002EF9AC File Offset: 0x002EDBAC
			// (set) Token: 0x0600BFDE RID: 49118 RVA: 0x0005DBD3 File Offset: 0x0005BDD3
			public unsafe static int FoamBottom
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamBottom, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamBottom, (void*)(&value));
				}
			}

			// Token: 0x17003BB6 RID: 15286
			// (get) Token: 0x0600BFDF RID: 49119 RVA: 0x002EF9C8 File Offset: 0x002EDBC8
			// (set) Token: 0x0600BFE0 RID: 49120 RVA: 0x0005DBE1 File Offset: 0x0005BDE1
			public unsafe static int FoamTurbulence
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamTurbulence, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamTurbulence, (void*)(&value));
				}
			}

			// Token: 0x17003BB7 RID: 15287
			// (get) Token: 0x0600BFE1 RID: 49121 RVA: 0x002EF9E4 File Offset: 0x002EDBE4
			// (set) Token: 0x0600BFE2 RID: 49122 RVA: 0x0005DBEF File Offset: 0x0005BDEF
			public unsafe static int RefractTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RefractTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RefractTex, (void*)(&value));
				}
			}

			// Token: 0x17003BB8 RID: 15288
			// (get) Token: 0x0600BFE3 RID: 49123 RVA: 0x002EFA00 File Offset: 0x002EDC00
			// (set) Token: 0x0600BFE4 RID: 49124 RVA: 0x0005DBFD File Offset: 0x0005BDFD
			public unsafe static int FlaskThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&value));
				}
			}

			// Token: 0x17003BB9 RID: 15289
			// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x002EFA1C File Offset: 0x002EDC1C
			// (set) Token: 0x0600BFE6 RID: 49126 RVA: 0x0005DC0B File Offset: 0x0005BE0B
			public unsafe static int Size
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Size, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Size, (void*)(&value));
				}
			}

			// Token: 0x17003BBA RID: 15290
			// (get) Token: 0x0600BFE7 RID: 49127 RVA: 0x002EFA38 File Offset: 0x002EDC38
			// (set) Token: 0x0600BFE8 RID: 49128 RVA: 0x0005DC19 File Offset: 0x0005BE19
			public unsafe static int Scale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Scale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Scale, (void*)(&value));
				}
			}

			// Token: 0x17003BBB RID: 15291
			// (get) Token: 0x0600BFE9 RID: 49129 RVA: 0x002EFA54 File Offset: 0x002EDC54
			// (set) Token: 0x0600BFEA RID: 49130 RVA: 0x0005DC27 File Offset: 0x0005BE27
			public unsafe static int Center
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Center, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Center, (void*)(&value));
				}
			}

			// Token: 0x17003BBC RID: 15292
			// (get) Token: 0x0600BFEB RID: 49131 RVA: 0x002EFA70 File Offset: 0x002EDC70
			// (set) Token: 0x0600BFEC RID: 49132 RVA: 0x0005DC35 File Offset: 0x0005BE35
			public unsafe static int SizeWorld
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SizeWorld, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SizeWorld, (void*)(&value));
				}
			}

			// Token: 0x17003BBD RID: 15293
			// (get) Token: 0x0600BFED RID: 49133 RVA: 0x002EFA8C File Offset: 0x002EDC8C
			// (set) Token: 0x0600BFEE RID: 49134 RVA: 0x0005DC43 File Offset: 0x0005BE43
			public unsafe static int DepthAwareOffset
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAwareOffset, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAwareOffset, (void*)(&value));
				}
			}

			// Token: 0x17003BBE RID: 15294
			// (get) Token: 0x0600BFEF RID: 49135 RVA: 0x002EFAA8 File Offset: 0x002EDCA8
			// (set) Token: 0x0600BFF0 RID: 49136 RVA: 0x0005DC51 File Offset: 0x0005BE51
			public unsafe static int Turbulence
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Turbulence, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Turbulence, (void*)(&value));
				}
			}

			// Token: 0x17003BBF RID: 15295
			// (get) Token: 0x0600BFF1 RID: 49137 RVA: 0x002EFAC4 File Offset: 0x002EDCC4
			// (set) Token: 0x0600BFF2 RID: 49138 RVA: 0x0005DC5F File Offset: 0x0005BE5F
			public unsafe static int TurbulenceSpeed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_TurbulenceSpeed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_TurbulenceSpeed, (void*)(&value));
				}
			}

			// Token: 0x17003BC0 RID: 15296
			// (get) Token: 0x0600BFF3 RID: 49139 RVA: 0x002EFAE0 File Offset: 0x002EDCE0
			// (set) Token: 0x0600BFF4 RID: 49140 RVA: 0x0005DC6D File Offset: 0x0005BE6D
			public unsafe static int MurkinessSpeed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_MurkinessSpeed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_MurkinessSpeed, (void*)(&value));
				}
			}

			// Token: 0x17003BC1 RID: 15297
			// (get) Token: 0x0600BFF5 RID: 49141 RVA: 0x002EFAFC File Offset: 0x002EDCFC
			// (set) Token: 0x0600BFF6 RID: 49142 RVA: 0x0005DC7B File Offset: 0x0005BE7B
			public unsafe static int Color1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color1, (void*)(&value));
				}
			}

			// Token: 0x17003BC2 RID: 15298
			// (get) Token: 0x0600BFF7 RID: 49143 RVA: 0x002EFB18 File Offset: 0x002EDD18
			// (set) Token: 0x0600BFF8 RID: 49144 RVA: 0x0005DC89 File Offset: 0x0005BE89
			public unsafe static int Color2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color2, (void*)(&value));
				}
			}

			// Token: 0x17003BC3 RID: 15299
			// (get) Token: 0x0600BFF9 RID: 49145 RVA: 0x002EFB34 File Offset: 0x002EDD34
			// (set) Token: 0x0600BFFA RID: 49146 RVA: 0x0005DC97 File Offset: 0x0005BE97
			public unsafe static int EmissionColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_EmissionColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_EmissionColor, (void*)(&value));
				}
			}

			// Token: 0x17003BC4 RID: 15300
			// (get) Token: 0x0600BFFB RID: 49147 RVA: 0x002EFB50 File Offset: 0x002EDD50
			// (set) Token: 0x0600BFFC RID: 49148 RVA: 0x0005DCA5 File Offset: 0x0005BEA5
			public unsafe static int LightColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightColor, (void*)(&value));
				}
			}

			// Token: 0x17003BC5 RID: 15301
			// (get) Token: 0x0600BFFD RID: 49149 RVA: 0x002EFB6C File Offset: 0x002EDD6C
			// (set) Token: 0x0600BFFE RID: 49150 RVA: 0x0005DCB3 File Offset: 0x0005BEB3
			public unsafe static int LightDir
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightDir, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightDir, (void*)(&value));
				}
			}

			// Token: 0x17003BC6 RID: 15302
			// (get) Token: 0x0600BFFF RID: 49151 RVA: 0x002EFB88 File Offset: 0x002EDD88
			// (set) Token: 0x0600C000 RID: 49152 RVA: 0x0005DCC1 File Offset: 0x0005BEC1
			public unsafe static int LevelPos
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LevelPos, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LevelPos, (void*)(&value));
				}
			}

			// Token: 0x17003BC7 RID: 15303
			// (get) Token: 0x0600C001 RID: 49153 RVA: 0x002EFBA4 File Offset: 0x002EDDA4
			// (set) Token: 0x0600C002 RID: 49154 RVA: 0x0005DCCF File Offset: 0x0005BECF
			public unsafe static int UpperLimit
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_UpperLimit, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_UpperLimit, (void*)(&value));
				}
			}

			// Token: 0x17003BC8 RID: 15304
			// (get) Token: 0x0600C003 RID: 49155 RVA: 0x002EFBC0 File Offset: 0x002EDDC0
			// (set) Token: 0x0600C004 RID: 49156 RVA: 0x0005DCDD File Offset: 0x0005BEDD
			public unsafe static int LowerLimit
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LowerLimit, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LowerLimit, (void*)(&value));
				}
			}

			// Token: 0x17003BC9 RID: 15305
			// (get) Token: 0x0600C005 RID: 49157 RVA: 0x002EFBDC File Offset: 0x002EDDDC
			// (set) Token: 0x0600C006 RID: 49158 RVA: 0x0005DCEB File Offset: 0x0005BEEB
			public unsafe static int FoamMaxPos
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamMaxPos, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamMaxPos, (void*)(&value));
				}
			}

			// Token: 0x17003BCA RID: 15306
			// (get) Token: 0x0600C007 RID: 49159 RVA: 0x002EFBF8 File Offset: 0x002EDDF8
			// (set) Token: 0x0600C008 RID: 49160 RVA: 0x0005DCF9 File Offset: 0x0005BEF9
			public unsafe static int CullMode
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_CullMode, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_CullMode, (void*)(&value));
				}
			}

			// Token: 0x17003BCB RID: 15307
			// (get) Token: 0x0600C009 RID: 49161 RVA: 0x002EFC14 File Offset: 0x002EDE14
			// (set) Token: 0x0600C00A RID: 49162 RVA: 0x0005DD07 File Offset: 0x0005BF07
			public unsafe static int ZTestMode
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_ZTestMode, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_ZTestMode, (void*)(&value));
				}
			}

			// Token: 0x17003BCC RID: 15308
			// (get) Token: 0x0600C00B RID: 49163 RVA: 0x002EFC30 File Offset: 0x002EDE30
			// (set) Token: 0x0600C00C RID: 49164 RVA: 0x0005DD15 File Offset: 0x0005BF15
			public unsafe static int NoiseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTex, (void*)(&value));
				}
			}

			// Token: 0x17003BCD RID: 15309
			// (get) Token: 0x0600C00D RID: 49165 RVA: 0x002EFC4C File Offset: 0x002EDE4C
			// (set) Token: 0x0600C00E RID: 49166 RVA: 0x0005DD23 File Offset: 0x0005BF23
			public unsafe static int NoiseTexUnwrapped
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTexUnwrapped, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTexUnwrapped, (void*)(&value));
				}
			}

			// Token: 0x17003BCE RID: 15310
			// (get) Token: 0x0600C00F RID: 49167 RVA: 0x002EFC68 File Offset: 0x002EDE68
			// (set) Token: 0x0600C010 RID: 49168 RVA: 0x0005DD31 File Offset: 0x0005BF31
			public unsafe static int GlobalRefractionTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlobalRefractionTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlobalRefractionTexture, (void*)(&value));
				}
			}

			// Token: 0x17003BCF RID: 15311
			// (get) Token: 0x0600C011 RID: 49169 RVA: 0x002EFC84 File Offset: 0x002EDE84
			// (set) Token: 0x0600C012 RID: 49170 RVA: 0x0005DD3F File Offset: 0x0005BF3F
			public unsafe static int RotationMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RotationMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RotationMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003BD0 RID: 15312
			// (get) Token: 0x0600C013 RID: 49171 RVA: 0x002EFCA0 File Offset: 0x002EDEA0
			// (set) Token: 0x0600C014 RID: 49172 RVA: 0x0005DD4D File Offset: 0x0005BF4D
			public unsafe static int QueueOffset
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_QueueOffset, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_QueueOffset, (void*)(&value));
				}
			}

			// Token: 0x17003BD1 RID: 15313
			// (get) Token: 0x0600C015 RID: 49173 RVA: 0x002EFCBC File Offset: 0x002EDEBC
			// (set) Token: 0x0600C016 RID: 49174 RVA: 0x0005DD5B File Offset: 0x0005BF5B
			public unsafe static int PreserveSpecular
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PreserveSpecular, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PreserveSpecular, (void*)(&value));
				}
			}

			// Token: 0x040081DD RID: 33245
			private static readonly IntPtr NativeFieldInfoPtr_PointLightInsideAtten;

			// Token: 0x040081DE RID: 33246
			private static readonly IntPtr NativeFieldInfoPtr_PointLightColorArray;

			// Token: 0x040081DF RID: 33247
			private static readonly IntPtr NativeFieldInfoPtr_PointLightPositionArray;

			// Token: 0x040081E0 RID: 33248
			private static readonly IntPtr NativeFieldInfoPtr_PointLightCount;

			// Token: 0x040081E1 RID: 33249
			private static readonly IntPtr NativeFieldInfoPtr_GlossinessInt;

			// Token: 0x040081E2 RID: 33250
			private static readonly IntPtr NativeFieldInfoPtr_DoubleSidedBias;

			// Token: 0x040081E3 RID: 33251
			private static readonly IntPtr NativeFieldInfoPtr_BackDepthBias;

			// Token: 0x040081E4 RID: 33252
			private static readonly IntPtr NativeFieldInfoPtr_Muddy;

			// Token: 0x040081E5 RID: 33253
			private static readonly IntPtr NativeFieldInfoPtr_Alpha;

			// Token: 0x040081E6 RID: 33254
			private static readonly IntPtr NativeFieldInfoPtr_AlphaCombined;

			// Token: 0x040081E7 RID: 33255
			private static readonly IntPtr NativeFieldInfoPtr_SparklingIntensity;

			// Token: 0x040081E8 RID: 33256
			private static readonly IntPtr NativeFieldInfoPtr_SparklingThreshold;

			// Token: 0x040081E9 RID: 33257
			private static readonly IntPtr NativeFieldInfoPtr_DepthAtten;

			// Token: 0x040081EA RID: 33258
			private static readonly IntPtr NativeFieldInfoPtr_SmokeColor;

			// Token: 0x040081EB RID: 33259
			private static readonly IntPtr NativeFieldInfoPtr_SmokeAtten;

			// Token: 0x040081EC RID: 33260
			private static readonly IntPtr NativeFieldInfoPtr_SmokeSpeed;

			// Token: 0x040081ED RID: 33261
			private static readonly IntPtr NativeFieldInfoPtr_SmokeHeightAtten;

			// Token: 0x040081EE RID: 33262
			private static readonly IntPtr NativeFieldInfoPtr_SmokeRaySteps;

			// Token: 0x040081EF RID: 33263
			private static readonly IntPtr NativeFieldInfoPtr_LiquidRaySteps;

			// Token: 0x040081F0 RID: 33264
			private static readonly IntPtr NativeFieldInfoPtr_FlaskBlurIntensity;

			// Token: 0x040081F1 RID: 33265
			private static readonly IntPtr NativeFieldInfoPtr_FoamColor;

			// Token: 0x040081F2 RID: 33266
			private static readonly IntPtr NativeFieldInfoPtr_FoamRaySteps;

			// Token: 0x040081F3 RID: 33267
			private static readonly IntPtr NativeFieldInfoPtr_FoamDensity;

			// Token: 0x040081F4 RID: 33268
			private static readonly IntPtr NativeFieldInfoPtr_FoamWeight;

			// Token: 0x040081F5 RID: 33269
			private static readonly IntPtr NativeFieldInfoPtr_FoamBottom;

			// Token: 0x040081F6 RID: 33270
			private static readonly IntPtr NativeFieldInfoPtr_FoamTurbulence;

			// Token: 0x040081F7 RID: 33271
			private static readonly IntPtr NativeFieldInfoPtr_RefractTex;

			// Token: 0x040081F8 RID: 33272
			private static readonly IntPtr NativeFieldInfoPtr_FlaskThickness;

			// Token: 0x040081F9 RID: 33273
			private static readonly IntPtr NativeFieldInfoPtr_Size;

			// Token: 0x040081FA RID: 33274
			private static readonly IntPtr NativeFieldInfoPtr_Scale;

			// Token: 0x040081FB RID: 33275
			private static readonly IntPtr NativeFieldInfoPtr_Center;

			// Token: 0x040081FC RID: 33276
			private static readonly IntPtr NativeFieldInfoPtr_SizeWorld;

			// Token: 0x040081FD RID: 33277
			private static readonly IntPtr NativeFieldInfoPtr_DepthAwareOffset;

			// Token: 0x040081FE RID: 33278
			private static readonly IntPtr NativeFieldInfoPtr_Turbulence;

			// Token: 0x040081FF RID: 33279
			private static readonly IntPtr NativeFieldInfoPtr_TurbulenceSpeed;

			// Token: 0x04008200 RID: 33280
			private static readonly IntPtr NativeFieldInfoPtr_MurkinessSpeed;

			// Token: 0x04008201 RID: 33281
			private static readonly IntPtr NativeFieldInfoPtr_Color1;

			// Token: 0x04008202 RID: 33282
			private static readonly IntPtr NativeFieldInfoPtr_Color2;

			// Token: 0x04008203 RID: 33283
			private static readonly IntPtr NativeFieldInfoPtr_EmissionColor;

			// Token: 0x04008204 RID: 33284
			private static readonly IntPtr NativeFieldInfoPtr_LightColor;

			// Token: 0x04008205 RID: 33285
			private static readonly IntPtr NativeFieldInfoPtr_LightDir;

			// Token: 0x04008206 RID: 33286
			private static readonly IntPtr NativeFieldInfoPtr_LevelPos;

			// Token: 0x04008207 RID: 33287
			private static readonly IntPtr NativeFieldInfoPtr_UpperLimit;

			// Token: 0x04008208 RID: 33288
			private static readonly IntPtr NativeFieldInfoPtr_LowerLimit;

			// Token: 0x04008209 RID: 33289
			private static readonly IntPtr NativeFieldInfoPtr_FoamMaxPos;

			// Token: 0x0400820A RID: 33290
			private static readonly IntPtr NativeFieldInfoPtr_CullMode;

			// Token: 0x0400820B RID: 33291
			private static readonly IntPtr NativeFieldInfoPtr_ZTestMode;

			// Token: 0x0400820C RID: 33292
			private static readonly IntPtr NativeFieldInfoPtr_NoiseTex;

			// Token: 0x0400820D RID: 33293
			private static readonly IntPtr NativeFieldInfoPtr_NoiseTexUnwrapped;

			// Token: 0x0400820E RID: 33294
			private static readonly IntPtr NativeFieldInfoPtr_GlobalRefractionTexture;

			// Token: 0x0400820F RID: 33295
			private static readonly IntPtr NativeFieldInfoPtr_RotationMatrix;

			// Token: 0x04008210 RID: 33296
			private static readonly IntPtr NativeFieldInfoPtr_QueueOffset;

			// Token: 0x04008211 RID: 33297
			private static readonly IntPtr NativeFieldInfoPtr_PreserveSpecular;
		}
	}
}
