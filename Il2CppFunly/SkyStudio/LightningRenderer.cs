using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000128 RID: 296
	public class LightningRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x0600193C RID: 6460 RVA: 0x000BF5C8 File Offset: 0x000BD7C8
		// Note: this type is marked as 'beforefieldinit'.
		static LightningRenderer()
		{
			Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr);
			LightningRenderer.NativeFieldInfoPtr_m_SpawnAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_SpawnAreas");
			LightningRenderer.NativeFieldInfoPtr_m_LightningProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_LightningProbability");
			LightningRenderer.NativeFieldInfoPtr_m_NextSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_NextSpawnTime");
			LightningRenderer.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_SkyProfile");
			LightningRenderer.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_Style");
			LightningRenderer.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_TimeOfDay");
			LightningRenderer.NativeFieldInfoPtr_m_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_AudioSource");
			LightningRenderer.NativeFieldInfoPtr_m_LightningIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_LightningIntensity");
			LightningRenderer.NativeFieldInfoPtr_m_ThunderSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_ThunderSoundDelay");
			LightningRenderer.NativeFieldInfoPtr_m_SpawnCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_SpawnCoolDown");
			LightningRenderer.NativeFieldInfoPtr_k_ProbabiltyCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "k_ProbabiltyCheckInterval");
			LightningRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665985);
			LightningRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665986);
			LightningRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665987);
			LightningRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665988);
			LightningRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665989);
			LightningRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665990);
			LightningRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665991);
			LightningRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665992);
			LightningRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665993);
			LightningRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_LightningArtItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665994);
			LightningRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665995);
			LightningRenderer.NativeMethodInfoPtr_GetRandomLightningSpawnArea_Private_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665996);
			LightningRenderer.NativeMethodInfoPtr_PlayThunderBoltSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665997);
			LightningRenderer.NativeMethodInfoPtr_AddSpawnArea_Public_Static_Void_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665998);
			LightningRenderer.NativeMethodInfoPtr_RemoveSpawnArea_Public_Static_Void_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665999);
			LightningRenderer.NativeMethodInfoPtr_GetRandomWorldPositionInsideSpawnArea_Private_Vector3_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100666000);
			LightningRenderer.NativeMethodInfoPtr_CalculateLightningBoltScaleForArea_Private_Single_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100666001);
			LightningRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100666002);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000BF83C File Offset: 0x000BDA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96050, XrefRangeEnd = 96062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000BF870 File Offset: 0x000BDA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96062, XrefRangeEnd = 96064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Bounds CalculateMeshBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000BF8B8 File Offset: 0x000BDAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96064, XrefRangeEnd = 96068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseSpriteItemData CreateSpriteItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseSpriteItemData>(intPtr3) : null;
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000BF904 File Offset: 0x000BDB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96068, XrefRangeEnd = 96080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRenderingEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000BF94C File Offset: 0x000BDB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96080, XrefRangeEnd = 96099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spritePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000BF9C4 File Offset: 0x000BDBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96099, XrefRangeEnd = 96105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000BFA14 File Offset: 0x000BDC14
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000BFA70 File Offset: 0x000BDC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96105, XrefRangeEnd = 96109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(propertyBlock);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			propertyBlock = ((intPtr4 == 0) ? null : new MaterialPropertyBlock(intPtr4));
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000BFAD4 File Offset: 0x000BDCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96109, XrefRangeEnd = 96112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNextSpawnCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000BFB1C File Offset: 0x000BDD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96112, XrefRangeEnd = 96134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(artItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_LightningArtItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000BFB80 File Offset: 0x000BDD80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96152, RefRangeEnd = 96154, XrefRangeStart = 96134, XrefRangeEnd = 96152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDataFromSkyProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000BFBB4 File Offset: 0x000BDDB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96176, RefRangeEnd = 96177, XrefRangeStart = 96154, XrefRangeEnd = 96176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningSpawnArea GetRandomLightningSpawnArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_GetRandomLightningSpawnArea_Private_LightningSpawnArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightningSpawnArea>(intPtr3) : null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000BFBF4 File Offset: 0x000BDDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96177, XrefRangeEnd = 96186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayThunderBoltSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_PlayThunderBoltSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000BFC28 File Offset: 0x000BDE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96186, XrefRangeEnd = 96199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSpawnArea(LightningSpawnArea area)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_AddSpawnArea_Public_Static_Void_LightningSpawnArea_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000BFC60 File Offset: 0x000BDE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96199, XrefRangeEnd = 96212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSpawnArea(LightningSpawnArea area)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_RemoveSpawnArea_Public_Static_Void_LightningSpawnArea_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000BFC98 File Offset: 0x000BDE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96212, XrefRangeEnd = 96216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_GetRandomWorldPositionInsideSpawnArea_Private_Vector3_LightningSpawnArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000BFCE8 File Offset: 0x000BDEE8
		[CallerCount(0)]
		public unsafe float CalculateLightningBoltScaleForArea(LightningSpawnArea area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_CalculateLightningBoltScaleForArea_Private_Single_LightningSpawnArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000BFD38 File Offset: 0x000BDF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96216, XrefRangeEnd = 96217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0000E658 File Offset: 0x0000C858
		public LightningRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000BFD74 File Offset: 0x000BDF74
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0000E661 File Offset: 0x0000C861
		public unsafe static List<LightningSpawnArea> m_SpawnAreas
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightningRenderer.NativeFieldInfoPtr_m_SpawnAreas, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LightningSpawnArea>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightningRenderer.NativeFieldInfoPtr_m_SpawnAreas, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x000BFD9C File Offset: 0x000BDF9C
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x0000E673 File Offset: 0x0000C873
		public unsafe float m_LightningProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningProbability)) = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x000BFDC4 File Offset: 0x000BDFC4
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x0000E68E File Offset: 0x0000C88E
		public unsafe float m_NextSpawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_NextSpawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_NextSpawnTime)) = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x000BFDEC File Offset: 0x000BDFEC
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0000E6A9 File Offset: 0x0000C8A9
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x000BFE1C File Offset: 0x000BE01C
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public unsafe LightningArtItem m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightningArtItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x000BFE4C File Offset: 0x000BE04C
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000E6E7 File Offset: 0x0000C8E7
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x000BFE74 File Offset: 0x000BE074
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000E702 File Offset: 0x0000C902
		public unsafe AudioSource m_AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000BFEA4 File Offset: 0x000BE0A4
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000E721 File Offset: 0x0000C921
		public unsafe float m_LightningIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningIntensity)) = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000BFECC File Offset: 0x000BE0CC
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000E73C File Offset: 0x0000C93C
		public unsafe float m_ThunderSoundDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_ThunderSoundDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_ThunderSoundDelay)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000BFEF4 File Offset: 0x000BE0F4
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000E757 File Offset: 0x0000C957
		public unsafe float m_SpawnCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SpawnCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SpawnCoolDown)) = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000BFF1C File Offset: 0x000BE11C
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000E772 File Offset: 0x0000C972
		public unsafe static float k_ProbabiltyCheckInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightningRenderer.NativeFieldInfoPtr_k_ProbabiltyCheckInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightningRenderer.NativeFieldInfoPtr_k_ProbabiltyCheckInterval, (void*)(&value));
			}
		}

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnAreas;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr_m_LightningProbability;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr_m_NextSpawnTime;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeFieldInfoPtr_m_AudioSource;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeFieldInfoPtr_m_LightningIntensity;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeFieldInfoPtr_m_ThunderSoundDelay;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnCoolDown;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeFieldInfoPtr_k_ProbabiltyCheckInterval;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_LightningArtItem_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLightningSpawnArea_Private_LightningSpawnArea_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_PlayThunderBoltSound_Private_Void_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_AddSpawnArea_Public_Static_Void_LightningSpawnArea_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpawnArea_Public_Static_Void_LightningSpawnArea_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomWorldPositionInsideSpawnArea_Private_Vector3_LightningSpawnArea_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLightningBoltScaleForArea_Private_Single_LightningSpawnArea_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
