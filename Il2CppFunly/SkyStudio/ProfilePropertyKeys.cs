using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010B RID: 267
	public class ProfilePropertyKeys : Object
	{
		// Token: 0x0600142F RID: 5167 RVA: 0x000B0A2C File Offset: 0x000AEC2C
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilePropertyKeys()
		{
			Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfilePropertyKeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr);
			ProfilePropertyKeys.NativeFieldInfoPtr_SkyCubemapKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SkyCubemapKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SkyUpperColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SkyUpperColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SkyMiddleColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SkyMiddleColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SkyLowerColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SkyLowerColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SkyMiddleColorPositionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SkyMiddleColorPositionKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_HorizonTrasitionStartKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "HorizonTrasitionStartKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_HorizonTransitionLengthKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "HorizonTransitionLengthKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_HorizonStarScaleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "HorizonStarScaleKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarTransitionStartKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarTransitionStartKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarTransitionLengthKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarTransitionLengthKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightSkyColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "AmbientLightSkyColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightEquatorColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "AmbientLightEquatorColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightGroundColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "AmbientLightGroundColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunSizeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunSizeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunRotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunRotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunEdgeFeatheringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunEdgeFeatheringKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunColorIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunColorIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunLightColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunLightColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunLightIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunLightIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunPositionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunPositionKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteRowCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunSpriteRowCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteColumnCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunSpriteColumnCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteItemCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunSpriteItemCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteAnimationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunSpriteAnimationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_SunAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "SunAlpha");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonSizeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonSizeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonRotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonRotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonEdgeFeatheringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonEdgeFeatheringKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonColorIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonColorIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonLightColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonLightColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonLightIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonLightIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonPositionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonPositionKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteRowCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonSpriteRowCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteColumnCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonSpriteColumnCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteItemCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonSpriteItemCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteAnimationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonSpriteAnimationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_MoonAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "MoonAlpha");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicCubemapKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicCubemapKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTwinkleSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicTwinkleSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTwinkleAmountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicTwinkleAmountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicOpacityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicOpacityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTintColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicTintColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicExponentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "StarBasicExponentKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1SizeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1SizeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1DensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1DensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1TextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1TextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1ColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1ColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1TwinkleAmountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1TwinkleAmountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1TwinkleSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1TwinkleSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1RotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1RotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1EdgeFeatheringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1EdgeFeatheringKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1ColorIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1ColorIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteRowCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1SpriteRowCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteColumnCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1SpriteColumnCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteItemCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1SpriteItemCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteAnimationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star1SpriteAnimationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2SizeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2SizeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2DensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2DensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2TextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2TextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2ColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2ColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2TwinkleAmountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2TwinkleAmountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2TwinkleSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2TwinkleSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2RotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2RotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2EdgeFeatheringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2EdgeFeatheringKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2ColorIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2ColorIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteRowCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2SpriteRowCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteColumnCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2SpriteColumnCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteItemCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2SpriteItemCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteAnimationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star2SpriteAnimationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3SizeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3SizeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3DensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3DensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3TextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3TextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3ColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3ColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3TwinkleAmountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3TwinkleAmountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3TwinkleSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3TwinkleSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3RotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3RotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3EdgeFeatheringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3EdgeFeatheringKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3ColorIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3ColorIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteRowCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3SpriteRowCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteColumnCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3SpriteColumnCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteItemCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3SpriteItemCountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteAnimationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "Star3SpriteAnimationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudNoiseTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudNoiseTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudDensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudDensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudDirectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudDirectionKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudHeightKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudHeightKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudColor1Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudColor1Key");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudColor2Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudColor2Key");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudFadePositionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudFadePositionKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudFadeAmountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudFadeAmountKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudTextureTiling");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudAlpha");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalLitColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalLitColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalShadowKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalShadowKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalRotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalRotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalAmbientIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalAmbientIntensity");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalHeightKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalHeightKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerRotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalDoubleLayerRotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerHeightKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalDoubleLayerHeightKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerCustomTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalDoubleLayerCustomTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerLitColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalDoubleLayerLitColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerShadowKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapNormalDoubleLayerShadowKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapRotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapRotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapTintColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapTintColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapHeightKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapHeightKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerRotationSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapDoubleLayerRotationSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerHeightKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapDoubleLayerHeightKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerCustomTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapDoubleLayerCustomTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerTintColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "CloudCubemapDoubleLayerTintColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_FogDensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "FogDensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_FogColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "FogColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_FogLengthKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "FogLengthKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_FogSyncWithGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "FogSyncWithGlobal");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainNearIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainNearIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainFarIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainFarIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainNearSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainNearSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainFarSpeedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainFarSpeedKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSoundVolumeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSoundVolumeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSoundKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSoundKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainTintColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainTintColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainWindTurbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainWindTurbulence");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainWindTurbulenceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainWindTurbulenceSpeed");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainNearTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainNearTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainFarTextureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainFarTextureKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainNearTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainNearTextureTiling");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainFarTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainFarTextureTiling");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashMaxConcurrentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashMaxConcurrentKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashAreaStartKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashAreaStartKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashAreaLengthKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashAreaLengthKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashScaleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashScaleKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashScaleVarienceKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashScaleVarienceKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashSurfaceOffsetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashSurfaceOffsetKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashTintColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "RainSplashTintColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_LightningProbabilityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "LightningProbabilityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_LightningStrikeCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "LightningStrikeCoolDown");
			ProfilePropertyKeys.NativeFieldInfoPtr_LightningIntensityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "LightningIntensityKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_LightningTintColorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "LightningTintColorKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_ThunderSoundVolumeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "ThunderSoundVolumeKey");
			ProfilePropertyKeys.NativeFieldInfoPtr_ThunderSoundDelayKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, "ThunderSoundDelayKey");
			ProfilePropertyKeys.NativeMethodInfoPtr_GetPropertyKeysSet_Public_Static_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, 100665556);
			ProfilePropertyKeys.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr, 100665557);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000B1614 File Offset: 0x000AF814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90647, RefRangeEnd = 90649, XrefRangeStart = 90628, XrefRangeEnd = 90647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<string> GetPropertyKeysSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilePropertyKeys.NativeMethodInfoPtr_GetPropertyKeysSet_Public_Static_HashSet_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000B1648 File Offset: 0x000AF848
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilePropertyKeys() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilePropertyKeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilePropertyKeys.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0000BF94 File Offset: 0x0000A194
		public ProfilePropertyKeys(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000B1684 File Offset: 0x000AF884
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x0000BF9D File Offset: 0x0000A19D
		public unsafe static string SkyCubemapKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyCubemapKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyCubemapKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x000B16A4 File Offset: 0x000AF8A4
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0000BFAF File Offset: 0x0000A1AF
		public unsafe static string SkyUpperColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyUpperColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyUpperColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x000B16C4 File Offset: 0x000AF8C4
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0000BFC1 File Offset: 0x0000A1C1
		public unsafe static string SkyMiddleColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyMiddleColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyMiddleColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000B16E4 File Offset: 0x000AF8E4
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0000BFD3 File Offset: 0x0000A1D3
		public unsafe static string SkyLowerColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyLowerColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyLowerColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x000B1704 File Offset: 0x000AF904
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0000BFE5 File Offset: 0x0000A1E5
		public unsafe static string SkyMiddleColorPositionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyMiddleColorPositionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SkyMiddleColorPositionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x000B1724 File Offset: 0x000AF924
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0000BFF7 File Offset: 0x0000A1F7
		public unsafe static string HorizonTrasitionStartKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_HorizonTrasitionStartKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_HorizonTrasitionStartKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x000B1744 File Offset: 0x000AF944
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0000C009 File Offset: 0x0000A209
		public unsafe static string HorizonTransitionLengthKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_HorizonTransitionLengthKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_HorizonTransitionLengthKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x000B1764 File Offset: 0x000AF964
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x0000C01B File Offset: 0x0000A21B
		public unsafe static string HorizonStarScaleKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_HorizonStarScaleKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_HorizonStarScaleKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x000B1784 File Offset: 0x000AF984
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x0000C02D File Offset: 0x0000A22D
		public unsafe static string StarTransitionStartKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarTransitionStartKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarTransitionStartKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x000B17A4 File Offset: 0x000AF9A4
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x0000C03F File Offset: 0x0000A23F
		public unsafe static string StarTransitionLengthKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarTransitionLengthKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarTransitionLengthKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000B17C4 File Offset: 0x000AF9C4
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x0000C051 File Offset: 0x0000A251
		public unsafe static string AmbientLightSkyColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightSkyColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightSkyColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x000B17E4 File Offset: 0x000AF9E4
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0000C063 File Offset: 0x0000A263
		public unsafe static string AmbientLightEquatorColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightEquatorColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightEquatorColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000B1804 File Offset: 0x000AFA04
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0000C075 File Offset: 0x0000A275
		public unsafe static string AmbientLightGroundColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightGroundColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_AmbientLightGroundColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x000B1824 File Offset: 0x000AFA24
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0000C087 File Offset: 0x0000A287
		public unsafe static string SunColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x000B1844 File Offset: 0x000AFA44
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0000C099 File Offset: 0x0000A299
		public unsafe static string SunTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x000B1864 File Offset: 0x000AFA64
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0000C0AB File Offset: 0x0000A2AB
		public unsafe static string SunSizeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSizeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSizeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x000B1884 File Offset: 0x000AFA84
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x0000C0BD File Offset: 0x0000A2BD
		public unsafe static string SunRotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunRotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunRotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x000B18A4 File Offset: 0x000AFAA4
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x0000C0CF File Offset: 0x0000A2CF
		public unsafe static string SunEdgeFeatheringKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunEdgeFeatheringKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunEdgeFeatheringKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x000B18C4 File Offset: 0x000AFAC4
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
		public unsafe static string SunColorIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunColorIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunColorIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000B18E4 File Offset: 0x000AFAE4
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000C0F3 File Offset: 0x0000A2F3
		public unsafe static string SunLightColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunLightColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunLightColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x000B1904 File Offset: 0x000AFB04
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000C105 File Offset: 0x0000A305
		public unsafe static string SunLightIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunLightIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunLightIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x000B1924 File Offset: 0x000AFB24
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0000C117 File Offset: 0x0000A317
		public unsafe static string SunPositionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunPositionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunPositionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000B1944 File Offset: 0x000AFB44
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0000C129 File Offset: 0x0000A329
		public unsafe static string SunSpriteRowCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteRowCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteRowCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x000B1964 File Offset: 0x000AFB64
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x0000C13B File Offset: 0x0000A33B
		public unsafe static string SunSpriteColumnCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteColumnCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteColumnCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x000B1984 File Offset: 0x000AFB84
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0000C14D File Offset: 0x0000A34D
		public unsafe static string SunSpriteItemCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteItemCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteItemCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x000B19A4 File Offset: 0x000AFBA4
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000C15F File Offset: 0x0000A35F
		public unsafe static string SunSpriteAnimationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteAnimationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunSpriteAnimationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000B19C4 File Offset: 0x000AFBC4
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x0000C171 File Offset: 0x0000A371
		public unsafe static string SunAlpha
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunAlpha, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_SunAlpha, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x000B19E4 File Offset: 0x000AFBE4
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000C183 File Offset: 0x0000A383
		public unsafe static string MoonColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x000B1A04 File Offset: 0x000AFC04
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000C195 File Offset: 0x0000A395
		public unsafe static string MoonTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x000B1A24 File Offset: 0x000AFC24
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000C1A7 File Offset: 0x0000A3A7
		public unsafe static string MoonSizeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSizeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSizeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x000B1A44 File Offset: 0x000AFC44
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000C1B9 File Offset: 0x0000A3B9
		public unsafe static string MoonRotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonRotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonRotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x000B1A64 File Offset: 0x000AFC64
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000C1CB File Offset: 0x0000A3CB
		public unsafe static string MoonEdgeFeatheringKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonEdgeFeatheringKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonEdgeFeatheringKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x000B1A84 File Offset: 0x000AFC84
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0000C1DD File Offset: 0x0000A3DD
		public unsafe static string MoonColorIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonColorIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonColorIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x000B1AA4 File Offset: 0x000AFCA4
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0000C1EF File Offset: 0x0000A3EF
		public unsafe static string MoonLightColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonLightColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonLightColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x000B1AC4 File Offset: 0x000AFCC4
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0000C201 File Offset: 0x0000A401
		public unsafe static string MoonLightIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonLightIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonLightIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000B1AE4 File Offset: 0x000AFCE4
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0000C213 File Offset: 0x0000A413
		public unsafe static string MoonPositionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonPositionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonPositionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x000B1B04 File Offset: 0x000AFD04
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0000C225 File Offset: 0x0000A425
		public unsafe static string MoonSpriteRowCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteRowCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteRowCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x000B1B24 File Offset: 0x000AFD24
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0000C237 File Offset: 0x0000A437
		public unsafe static string MoonSpriteColumnCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteColumnCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteColumnCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x000B1B44 File Offset: 0x000AFD44
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0000C249 File Offset: 0x0000A449
		public unsafe static string MoonSpriteItemCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteItemCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteItemCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x000B1B64 File Offset: 0x000AFD64
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0000C25B File Offset: 0x0000A45B
		public unsafe static string MoonSpriteAnimationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteAnimationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonSpriteAnimationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x000B1B84 File Offset: 0x000AFD84
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000C26D File Offset: 0x0000A46D
		public unsafe static string MoonAlpha
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonAlpha, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_MoonAlpha, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x000B1BA4 File Offset: 0x000AFDA4
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000C27F File Offset: 0x0000A47F
		public unsafe static string StarBasicCubemapKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicCubemapKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicCubemapKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x000B1BC4 File Offset: 0x000AFDC4
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0000C291 File Offset: 0x0000A491
		public unsafe static string StarBasicTwinkleSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTwinkleSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTwinkleSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x000B1BE4 File Offset: 0x000AFDE4
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000C2A3 File Offset: 0x0000A4A3
		public unsafe static string StarBasicTwinkleAmountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTwinkleAmountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTwinkleAmountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x000B1C04 File Offset: 0x000AFE04
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0000C2B5 File Offset: 0x0000A4B5
		public unsafe static string StarBasicOpacityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicOpacityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicOpacityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x000B1C24 File Offset: 0x000AFE24
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000C2C7 File Offset: 0x0000A4C7
		public unsafe static string StarBasicTintColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTintColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicTintColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x000B1C44 File Offset: 0x000AFE44
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000C2D9 File Offset: 0x0000A4D9
		public unsafe static string StarBasicIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x000B1C64 File Offset: 0x000AFE64
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x0000C2EB File Offset: 0x0000A4EB
		public unsafe static string StarBasicExponentKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicExponentKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_StarBasicExponentKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000B1C84 File Offset: 0x000AFE84
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0000C2FD File Offset: 0x0000A4FD
		public unsafe static string Star1SizeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SizeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SizeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x000B1CA4 File Offset: 0x000AFEA4
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000C30F File Offset: 0x0000A50F
		public unsafe static string Star1DensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1DensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1DensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x000B1CC4 File Offset: 0x000AFEC4
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000C321 File Offset: 0x0000A521
		public unsafe static string Star1TextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1TextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1TextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0000C333 File Offset: 0x0000A533
		public unsafe static string Star1ColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1ColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1ColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x000B1D04 File Offset: 0x000AFF04
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000C345 File Offset: 0x0000A545
		public unsafe static string Star1TwinkleAmountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1TwinkleAmountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1TwinkleAmountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x000B1D24 File Offset: 0x000AFF24
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000C357 File Offset: 0x0000A557
		public unsafe static string Star1TwinkleSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1TwinkleSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1TwinkleSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x000B1D44 File Offset: 0x000AFF44
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000C369 File Offset: 0x0000A569
		public unsafe static string Star1RotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1RotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1RotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000B1D64 File Offset: 0x000AFF64
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000C37B File Offset: 0x0000A57B
		public unsafe static string Star1EdgeFeatheringKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1EdgeFeatheringKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1EdgeFeatheringKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x000B1D84 File Offset: 0x000AFF84
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000C38D File Offset: 0x0000A58D
		public unsafe static string Star1ColorIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1ColorIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1ColorIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x000B1DA4 File Offset: 0x000AFFA4
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000C39F File Offset: 0x0000A59F
		public unsafe static string Star1SpriteRowCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteRowCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteRowCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x000B1DC4 File Offset: 0x000AFFC4
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0000C3B1 File Offset: 0x0000A5B1
		public unsafe static string Star1SpriteColumnCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteColumnCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteColumnCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x000B1DE4 File Offset: 0x000AFFE4
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		public unsafe static string Star1SpriteItemCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteItemCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteItemCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000B1E04 File Offset: 0x000B0004
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0000C3D5 File Offset: 0x0000A5D5
		public unsafe static string Star1SpriteAnimationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteAnimationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star1SpriteAnimationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x000B1E24 File Offset: 0x000B0024
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x0000C3E7 File Offset: 0x0000A5E7
		public unsafe static string Star2SizeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SizeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SizeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x000B1E44 File Offset: 0x000B0044
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000C3F9 File Offset: 0x0000A5F9
		public unsafe static string Star2DensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2DensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2DensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000B1E64 File Offset: 0x000B0064
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0000C40B File Offset: 0x0000A60B
		public unsafe static string Star2TextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2TextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2TextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000B1E84 File Offset: 0x000B0084
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000C41D File Offset: 0x0000A61D
		public unsafe static string Star2ColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2ColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2ColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x000B1EA4 File Offset: 0x000B00A4
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0000C42F File Offset: 0x0000A62F
		public unsafe static string Star2TwinkleAmountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2TwinkleAmountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2TwinkleAmountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x000B1EC4 File Offset: 0x000B00C4
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0000C441 File Offset: 0x0000A641
		public unsafe static string Star2TwinkleSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2TwinkleSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2TwinkleSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x000B1EE4 File Offset: 0x000B00E4
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x0000C453 File Offset: 0x0000A653
		public unsafe static string Star2RotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2RotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2RotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x000B1F04 File Offset: 0x000B0104
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x0000C465 File Offset: 0x0000A665
		public unsafe static string Star2EdgeFeatheringKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2EdgeFeatheringKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2EdgeFeatheringKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x000B1F24 File Offset: 0x000B0124
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x0000C477 File Offset: 0x0000A677
		public unsafe static string Star2ColorIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2ColorIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2ColorIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x000B1F44 File Offset: 0x000B0144
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0000C489 File Offset: 0x0000A689
		public unsafe static string Star2SpriteRowCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteRowCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteRowCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x000B1F64 File Offset: 0x000B0164
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x0000C49B File Offset: 0x0000A69B
		public unsafe static string Star2SpriteColumnCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteColumnCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteColumnCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x000B1F84 File Offset: 0x000B0184
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0000C4AD File Offset: 0x0000A6AD
		public unsafe static string Star2SpriteItemCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteItemCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteItemCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000B1FA4 File Offset: 0x000B01A4
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x0000C4BF File Offset: 0x0000A6BF
		public unsafe static string Star2SpriteAnimationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteAnimationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star2SpriteAnimationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x000B1FC4 File Offset: 0x000B01C4
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x0000C4D1 File Offset: 0x0000A6D1
		public unsafe static string Star3SizeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SizeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SizeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000B1FE4 File Offset: 0x000B01E4
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x0000C4E3 File Offset: 0x0000A6E3
		public unsafe static string Star3DensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3DensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3DensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000B2004 File Offset: 0x000B0204
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000C4F5 File Offset: 0x0000A6F5
		public unsafe static string Star3TextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3TextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3TextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000B2024 File Offset: 0x000B0224
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000C507 File Offset: 0x0000A707
		public unsafe static string Star3ColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3ColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3ColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x000B2044 File Offset: 0x000B0244
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000C519 File Offset: 0x0000A719
		public unsafe static string Star3TwinkleAmountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3TwinkleAmountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3TwinkleAmountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x000B2064 File Offset: 0x000B0264
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000C52B File Offset: 0x0000A72B
		public unsafe static string Star3TwinkleSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3TwinkleSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3TwinkleSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x000B2084 File Offset: 0x000B0284
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0000C53D File Offset: 0x0000A73D
		public unsafe static string Star3RotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3RotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3RotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x000B20A4 File Offset: 0x000B02A4
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x0000C54F File Offset: 0x0000A74F
		public unsafe static string Star3EdgeFeatheringKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3EdgeFeatheringKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3EdgeFeatheringKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x000B20C4 File Offset: 0x000B02C4
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0000C561 File Offset: 0x0000A761
		public unsafe static string Star3ColorIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3ColorIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3ColorIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x000B20E4 File Offset: 0x000B02E4
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0000C573 File Offset: 0x0000A773
		public unsafe static string Star3SpriteRowCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteRowCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteRowCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x000B2104 File Offset: 0x000B0304
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0000C585 File Offset: 0x0000A785
		public unsafe static string Star3SpriteColumnCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteColumnCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteColumnCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x000B2124 File Offset: 0x000B0324
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x0000C597 File Offset: 0x0000A797
		public unsafe static string Star3SpriteItemCountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteItemCountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteItemCountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x000B2144 File Offset: 0x000B0344
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0000C5A9 File Offset: 0x0000A7A9
		public unsafe static string Star3SpriteAnimationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteAnimationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_Star3SpriteAnimationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000B2164 File Offset: 0x000B0364
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000C5BB File Offset: 0x0000A7BB
		public unsafe static string CloudNoiseTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudNoiseTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudNoiseTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000B2184 File Offset: 0x000B0384
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0000C5CD File Offset: 0x0000A7CD
		public unsafe static string CloudDensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudDensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudDensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000B21A4 File Offset: 0x000B03A4
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x0000C5DF File Offset: 0x0000A7DF
		public unsafe static string CloudSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x000B21C4 File Offset: 0x000B03C4
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0000C5F1 File Offset: 0x0000A7F1
		public unsafe static string CloudDirectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudDirectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudDirectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x000B21E4 File Offset: 0x000B03E4
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x0000C603 File Offset: 0x0000A803
		public unsafe static string CloudHeightKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudHeightKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudHeightKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x000B2204 File Offset: 0x000B0404
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x0000C615 File Offset: 0x0000A815
		public unsafe static string CloudColor1Key
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudColor1Key, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudColor1Key, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000B2224 File Offset: 0x000B0424
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0000C627 File Offset: 0x0000A827
		public unsafe static string CloudColor2Key
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudColor2Key, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudColor2Key, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x000B2244 File Offset: 0x000B0444
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000C639 File Offset: 0x0000A839
		public unsafe static string CloudFadePositionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudFadePositionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudFadePositionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000B2264 File Offset: 0x000B0464
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x0000C64B File Offset: 0x0000A84B
		public unsafe static string CloudFadeAmountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudFadeAmountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudFadeAmountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x000B2284 File Offset: 0x000B0484
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x0000C65D File Offset: 0x0000A85D
		public unsafe static string CloudTextureTiling
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudTextureTiling, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudTextureTiling, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x000B22A4 File Offset: 0x000B04A4
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x0000C66F File Offset: 0x0000A86F
		public unsafe static string CloudAlpha
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudAlpha, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudAlpha, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x000B22C4 File Offset: 0x000B04C4
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x0000C681 File Offset: 0x0000A881
		public unsafe static string CloudCubemapNormalTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000B22E4 File Offset: 0x000B04E4
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0000C693 File Offset: 0x0000A893
		public unsafe static string CloudCubemapNormalLitColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalLitColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalLitColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000B2304 File Offset: 0x000B0504
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x0000C6A5 File Offset: 0x0000A8A5
		public unsafe static string CloudCubemapNormalShadowKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalShadowKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalShadowKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000B2324 File Offset: 0x000B0524
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x0000C6B7 File Offset: 0x0000A8B7
		public unsafe static string CloudCubemapNormalRotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalRotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalRotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000B2344 File Offset: 0x000B0544
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x0000C6C9 File Offset: 0x0000A8C9
		public unsafe static string CloudCubemapNormalAmbientIntensity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalAmbientIntensity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalAmbientIntensity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000B2364 File Offset: 0x000B0564
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x0000C6DB File Offset: 0x0000A8DB
		public unsafe static string CloudCubemapNormalHeightKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalHeightKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalHeightKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000B2384 File Offset: 0x000B0584
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x0000C6ED File Offset: 0x0000A8ED
		public unsafe static string CloudCubemapNormalDoubleLayerRotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerRotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerRotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000B23A4 File Offset: 0x000B05A4
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000C6FF File Offset: 0x0000A8FF
		public unsafe static string CloudCubemapNormalDoubleLayerHeightKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerHeightKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerHeightKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000B23C4 File Offset: 0x000B05C4
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x0000C711 File Offset: 0x0000A911
		public unsafe static string CloudCubemapNormalDoubleLayerCustomTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerCustomTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerCustomTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000B23E4 File Offset: 0x000B05E4
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x0000C723 File Offset: 0x0000A923
		public unsafe static string CloudCubemapNormalDoubleLayerLitColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerLitColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerLitColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x000B2404 File Offset: 0x000B0604
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x0000C735 File Offset: 0x0000A935
		public unsafe static string CloudCubemapNormalDoubleLayerShadowKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerShadowKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerShadowKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x000B2424 File Offset: 0x000B0624
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x0000C747 File Offset: 0x0000A947
		public unsafe static string CloudCubemapTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x000B2444 File Offset: 0x000B0644
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x0000C759 File Offset: 0x0000A959
		public unsafe static string CloudCubemapRotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapRotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapRotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x000B2464 File Offset: 0x000B0664
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x0000C76B File Offset: 0x0000A96B
		public unsafe static string CloudCubemapTintColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapTintColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapTintColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x000B2484 File Offset: 0x000B0684
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x0000C77D File Offset: 0x0000A97D
		public unsafe static string CloudCubemapHeightKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapHeightKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapHeightKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000B24A4 File Offset: 0x000B06A4
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x0000C78F File Offset: 0x0000A98F
		public unsafe static string CloudCubemapDoubleLayerRotationSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerRotationSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerRotationSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x000B24C4 File Offset: 0x000B06C4
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000C7A1 File Offset: 0x0000A9A1
		public unsafe static string CloudCubemapDoubleLayerHeightKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerHeightKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerHeightKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000B24E4 File Offset: 0x000B06E4
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
		public unsafe static string CloudCubemapDoubleLayerCustomTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerCustomTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerCustomTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x000B2504 File Offset: 0x000B0704
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000C7C5 File Offset: 0x0000A9C5
		public unsafe static string CloudCubemapDoubleLayerTintColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerTintColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_CloudCubemapDoubleLayerTintColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x000B2524 File Offset: 0x000B0724
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0000C7D7 File Offset: 0x0000A9D7
		public unsafe static string FogDensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogDensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogDensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000B2544 File Offset: 0x000B0744
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0000C7E9 File Offset: 0x0000A9E9
		public unsafe static string FogColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x000B2564 File Offset: 0x000B0764
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000C7FB File Offset: 0x0000A9FB
		public unsafe static string FogLengthKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogLengthKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogLengthKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000B2584 File Offset: 0x000B0784
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000C80D File Offset: 0x0000AA0D
		public unsafe static string FogSyncWithGlobal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogSyncWithGlobal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_FogSyncWithGlobal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x000B25A4 File Offset: 0x000B07A4
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000C81F File Offset: 0x0000AA1F
		public unsafe static string RainNearIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000B25C4 File Offset: 0x000B07C4
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x0000C831 File Offset: 0x0000AA31
		public unsafe static string RainFarIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x000B25E4 File Offset: 0x000B07E4
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000C843 File Offset: 0x0000AA43
		public unsafe static string RainNearSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x000B2604 File Offset: 0x000B0804
		// (set) Token: 0x0600152C RID: 5420 RVA: 0x0000C855 File Offset: 0x0000AA55
		public unsafe static string RainFarSpeedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarSpeedKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarSpeedKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x000B2624 File Offset: 0x000B0824
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x0000C867 File Offset: 0x0000AA67
		public unsafe static string RainSoundVolumeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSoundVolumeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSoundVolumeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x000B2644 File Offset: 0x000B0844
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000C879 File Offset: 0x0000AA79
		public unsafe static string RainSoundKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSoundKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSoundKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x000B2664 File Offset: 0x000B0864
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000C88B File Offset: 0x0000AA8B
		public unsafe static string RainTintColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainTintColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainTintColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x000B2684 File Offset: 0x000B0884
		// (set) Token: 0x06001534 RID: 5428 RVA: 0x0000C89D File Offset: 0x0000AA9D
		public unsafe static string RainWindTurbulence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainWindTurbulence, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainWindTurbulence, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x000B26A4 File Offset: 0x000B08A4
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x0000C8AF File Offset: 0x0000AAAF
		public unsafe static string RainWindTurbulenceSpeed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainWindTurbulenceSpeed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainWindTurbulenceSpeed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000B26C4 File Offset: 0x000B08C4
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x0000C8C1 File Offset: 0x0000AAC1
		public unsafe static string RainNearTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x000B26E4 File Offset: 0x000B08E4
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x0000C8D3 File Offset: 0x0000AAD3
		public unsafe static string RainFarTextureKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarTextureKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarTextureKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000B2704 File Offset: 0x000B0904
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x0000C8E5 File Offset: 0x0000AAE5
		public unsafe static string RainNearTextureTiling
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearTextureTiling, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainNearTextureTiling, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000B2724 File Offset: 0x000B0924
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x0000C8F7 File Offset: 0x0000AAF7
		public unsafe static string RainFarTextureTiling
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarTextureTiling, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainFarTextureTiling, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000B2744 File Offset: 0x000B0944
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0000C909 File Offset: 0x0000AB09
		public unsafe static string RainSplashMaxConcurrentKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashMaxConcurrentKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashMaxConcurrentKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x000B2764 File Offset: 0x000B0964
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0000C91B File Offset: 0x0000AB1B
		public unsafe static string RainSplashAreaStartKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashAreaStartKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashAreaStartKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x000B2784 File Offset: 0x000B0984
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0000C92D File Offset: 0x0000AB2D
		public unsafe static string RainSplashAreaLengthKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashAreaLengthKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashAreaLengthKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x000B27A4 File Offset: 0x000B09A4
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x0000C93F File Offset: 0x0000AB3F
		public unsafe static string RainSplashScaleKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashScaleKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashScaleKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x000B27C4 File Offset: 0x000B09C4
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0000C951 File Offset: 0x0000AB51
		public unsafe static string RainSplashScaleVarienceKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashScaleVarienceKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashScaleVarienceKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x000B27E4 File Offset: 0x000B09E4
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x0000C963 File Offset: 0x0000AB63
		public unsafe static string RainSplashIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x000B2804 File Offset: 0x000B0A04
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x0000C975 File Offset: 0x0000AB75
		public unsafe static string RainSplashSurfaceOffsetKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashSurfaceOffsetKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashSurfaceOffsetKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x000B2824 File Offset: 0x000B0A24
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x0000C987 File Offset: 0x0000AB87
		public unsafe static string RainSplashTintColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashTintColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_RainSplashTintColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000B2844 File Offset: 0x000B0A44
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0000C999 File Offset: 0x0000AB99
		public unsafe static string LightningProbabilityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningProbabilityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningProbabilityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x000B2864 File Offset: 0x000B0A64
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0000C9AB File Offset: 0x0000ABAB
		public unsafe static string LightningStrikeCoolDown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningStrikeCoolDown, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningStrikeCoolDown, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x000B2884 File Offset: 0x000B0A84
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0000C9BD File Offset: 0x0000ABBD
		public unsafe static string LightningIntensityKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningIntensityKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningIntensityKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000B28A4 File Offset: 0x000B0AA4
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0000C9CF File Offset: 0x0000ABCF
		public unsafe static string LightningTintColorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningTintColorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_LightningTintColorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x000B28C4 File Offset: 0x000B0AC4
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x0000C9E1 File Offset: 0x0000ABE1
		public unsafe static string ThunderSoundVolumeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_ThunderSoundVolumeKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_ThunderSoundVolumeKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x000B28E4 File Offset: 0x000B0AE4
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
		public unsafe static string ThunderSoundDelayKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfilePropertyKeys.NativeFieldInfoPtr_ThunderSoundDelayKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilePropertyKeys.NativeFieldInfoPtr_ThunderSoundDelayKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeFieldInfoPtr_SkyCubemapKey;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeFieldInfoPtr_SkyUpperColorKey;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeFieldInfoPtr_SkyMiddleColorKey;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeFieldInfoPtr_SkyLowerColorKey;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeFieldInfoPtr_SkyMiddleColorPositionKey;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeFieldInfoPtr_HorizonTrasitionStartKey;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeFieldInfoPtr_HorizonTransitionLengthKey;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeFieldInfoPtr_HorizonStarScaleKey;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeFieldInfoPtr_StarTransitionStartKey;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeFieldInfoPtr_StarTransitionLengthKey;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeFieldInfoPtr_AmbientLightSkyColorKey;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeFieldInfoPtr_AmbientLightEquatorColorKey;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr_AmbientLightGroundColorKey;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr_SunColorKey;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr_SunTextureKey;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeFieldInfoPtr_SunSizeKey;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeFieldInfoPtr_SunRotationSpeedKey;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeFieldInfoPtr_SunEdgeFeatheringKey;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeFieldInfoPtr_SunColorIntensityKey;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeFieldInfoPtr_SunLightColorKey;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeFieldInfoPtr_SunLightIntensityKey;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeFieldInfoPtr_SunPositionKey;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeFieldInfoPtr_SunSpriteRowCountKey;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeFieldInfoPtr_SunSpriteColumnCountKey;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeFieldInfoPtr_SunSpriteItemCountKey;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeFieldInfoPtr_SunSpriteAnimationSpeedKey;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeFieldInfoPtr_SunAlpha;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeFieldInfoPtr_MoonColorKey;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeFieldInfoPtr_MoonTextureKey;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeFieldInfoPtr_MoonSizeKey;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeFieldInfoPtr_MoonRotationSpeedKey;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeFieldInfoPtr_MoonEdgeFeatheringKey;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeFieldInfoPtr_MoonColorIntensityKey;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeFieldInfoPtr_MoonLightColorKey;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeFieldInfoPtr_MoonLightIntensityKey;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeFieldInfoPtr_MoonPositionKey;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeFieldInfoPtr_MoonSpriteRowCountKey;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeFieldInfoPtr_MoonSpriteColumnCountKey;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeFieldInfoPtr_MoonSpriteItemCountKey;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeFieldInfoPtr_MoonSpriteAnimationSpeedKey;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeFieldInfoPtr_MoonAlpha;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicCubemapKey;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicTwinkleSpeedKey;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicTwinkleAmountKey;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicOpacityKey;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicTintColorKey;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicIntensityKey;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_StarBasicExponentKey;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_Star1SizeKey;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_Star1DensityKey;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeFieldInfoPtr_Star1TextureKey;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeFieldInfoPtr_Star1ColorKey;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeFieldInfoPtr_Star1TwinkleAmountKey;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr_Star1TwinkleSpeedKey;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeFieldInfoPtr_Star1RotationSpeedKey;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr_Star1EdgeFeatheringKey;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr_Star1ColorIntensityKey;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_Star1SpriteRowCountKey;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_Star1SpriteColumnCountKey;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_Star1SpriteItemCountKey;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_Star1SpriteAnimationSpeedKey;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_Star2SizeKey;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_Star2DensityKey;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_Star2TextureKey;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_Star2ColorKey;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_Star2TwinkleAmountKey;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_Star2TwinkleSpeedKey;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_Star2RotationSpeedKey;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_Star2EdgeFeatheringKey;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_Star2ColorIntensityKey;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_Star2SpriteRowCountKey;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_Star2SpriteColumnCountKey;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_Star2SpriteItemCountKey;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr_Star2SpriteAnimationSpeedKey;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeFieldInfoPtr_Star3SizeKey;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr_Star3DensityKey;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_Star3TextureKey;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeFieldInfoPtr_Star3ColorKey;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeFieldInfoPtr_Star3TwinkleAmountKey;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_Star3TwinkleSpeedKey;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_Star3RotationSpeedKey;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_Star3EdgeFeatheringKey;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_Star3ColorIntensityKey;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_Star3SpriteRowCountKey;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_Star3SpriteColumnCountKey;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_Star3SpriteItemCountKey;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_Star3SpriteAnimationSpeedKey;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_CloudNoiseTextureKey;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeFieldInfoPtr_CloudDensityKey;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeFieldInfoPtr_CloudSpeedKey;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_CloudDirectionKey;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_CloudHeightKey;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeFieldInfoPtr_CloudColor1Key;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeFieldInfoPtr_CloudColor2Key;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_CloudFadePositionKey;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_CloudFadeAmountKey;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr_CloudTextureTiling;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr_CloudAlpha;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalTextureKey;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalLitColorKey;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalShadowKey;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalRotationSpeedKey;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalAmbientIntensity;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalHeightKey;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerRotationSpeedKey;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerHeightKey;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerCustomTextureKey;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerLitColorKey;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapNormalDoubleLayerShadowKey;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapTextureKey;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapRotationSpeedKey;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapTintColorKey;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapHeightKey;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapDoubleLayerRotationSpeedKey;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapDoubleLayerHeightKey;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapDoubleLayerCustomTextureKey;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeFieldInfoPtr_CloudCubemapDoubleLayerTintColorKey;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeFieldInfoPtr_FogDensityKey;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeFieldInfoPtr_FogColorKey;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_FogLengthKey;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_FogSyncWithGlobal;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeFieldInfoPtr_RainNearIntensityKey;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeFieldInfoPtr_RainFarIntensityKey;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeFieldInfoPtr_RainNearSpeedKey;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeFieldInfoPtr_RainFarSpeedKey;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeFieldInfoPtr_RainSoundVolumeKey;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeFieldInfoPtr_RainSoundKey;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeFieldInfoPtr_RainTintColorKey;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeFieldInfoPtr_RainWindTurbulence;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr_RainWindTurbulenceSpeed;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr_RainNearTextureKey;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeFieldInfoPtr_RainFarTextureKey;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeFieldInfoPtr_RainNearTextureTiling;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeFieldInfoPtr_RainFarTextureTiling;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashMaxConcurrentKey;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashAreaStartKey;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashAreaLengthKey;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashScaleKey;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashScaleVarienceKey;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashIntensityKey;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashSurfaceOffsetKey;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashTintColorKey;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeFieldInfoPtr_LightningProbabilityKey;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeFieldInfoPtr_LightningStrikeCoolDown;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeFieldInfoPtr_LightningIntensityKey;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr_LightningTintColorKey;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeFieldInfoPtr_ThunderSoundVolumeKey;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr_ThunderSoundDelayKey;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyKeysSet_Public_Static_HashSet_1_String_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
