using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000117 RID: 279
	public class SkyProfile : ScriptableObject
	{
		// Token: 0x06001600 RID: 5632 RVA: 0x000B3D90 File Offset: 0x000B1F90
		// Note: this type is marked as 'beforefieldinit'.
		static SkyProfile()
		{
			Il2CppClassPointerStore<SkyProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SkyProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr);
			SkyProfile.NativeFieldInfoPtr_DefaultShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "DefaultShaderName");
			SkyProfile.NativeFieldInfoPtr_DefaultLegacyShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "DefaultLegacyShaderName");
			SkyProfile.NativeFieldInfoPtr_m_SkyboxMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "m_SkyboxMaterial");
			SkyProfile.NativeFieldInfoPtr_m_ShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "m_ShaderName");
			SkyProfile.NativeFieldInfoPtr_profileDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "profileDefinition");
			SkyProfile.NativeFieldInfoPtr_timelineManagedKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "timelineManagedKeys");
			SkyProfile.NativeFieldInfoPtr_keyframeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "keyframeGroups");
			SkyProfile.NativeFieldInfoPtr_featureStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "featureStatus");
			SkyProfile.NativeFieldInfoPtr_lightningArtSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "lightningArtSet");
			SkyProfile.NativeFieldInfoPtr_rainSplashArtSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "rainSplashArtSet");
			SkyProfile.NativeFieldInfoPtr_starLayer1DataTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "starLayer1DataTexture");
			SkyProfile.NativeFieldInfoPtr_starLayer2DataTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "starLayer2DataTexture");
			SkyProfile.NativeFieldInfoPtr_starLayer3DataTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "starLayer3DataTexture");
			SkyProfile.NativeFieldInfoPtr_m_ProfileVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "m_ProfileVersion");
			SkyProfile.NativeFieldInfoPtr_m_KeyToGroupInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, "m_KeyToGroupInfo");
			SkyProfile.NativeMethodInfoPtr_get_skyboxMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665581);
			SkyProfile.NativeMethodInfoPtr_set_skyboxMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665582);
			SkyProfile.NativeMethodInfoPtr_get_shaderName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665583);
			SkyProfile.NativeMethodInfoPtr_get_groupDefinitions_Public_get_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665584);
			SkyProfile.NativeMethodInfoPtr_get_featureDefinitions_Public_get_Il2CppReferenceArray_1_ProfileFeatureSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665585);
			SkyProfile.NativeMethodInfoPtr_GetNumberPropertyValue_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665586);
			SkyProfile.NativeMethodInfoPtr_GetNumberPropertyValue_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665587);
			SkyProfile.NativeMethodInfoPtr_GetColorPropertyValue_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665588);
			SkyProfile.NativeMethodInfoPtr_GetColorPropertyValue_Public_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665589);
			SkyProfile.NativeMethodInfoPtr_GetTexturePropertyValue_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665590);
			SkyProfile.NativeMethodInfoPtr_GetTexturePropertyValue_Public_Texture_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665591);
			SkyProfile.NativeMethodInfoPtr_GetSpherePointPropertyValue_Public_SpherePoint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665592);
			SkyProfile.NativeMethodInfoPtr_GetSpherePointPropertyValue_Public_SpherePoint_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665593);
			SkyProfile.NativeMethodInfoPtr_GetBoolPropertyValue_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665594);
			SkyProfile.NativeMethodInfoPtr_GetBoolPropertyValue_Public_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665595);
			SkyProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665596);
			SkyProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665597);
			SkyProfile.NativeMethodInfoPtr_ReloadFullProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665598);
			SkyProfile.NativeMethodInfoPtr_ReloadDefinitions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665599);
			SkyProfile.NativeMethodInfoPtr_GetShaderInfoForMaterial_Private_IProfileDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665600);
			SkyProfile.NativeMethodInfoPtr_MergeProfileWithDefinitions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665601);
			SkyProfile.NativeMethodInfoPtr_MergeGroupsWithDefinitions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665602);
			SkyProfile.NativeMethodInfoPtr_GroupDefinitionDictionary_Public_Dictionary_2_String_ProfileGroupDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665603);
			SkyProfile.NativeMethodInfoPtr_ProfileDefinitionTable_Public_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665604);
			SkyProfile.NativeMethodInfoPtr_AddNumericGroup_Private_Void_String_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665605);
			SkyProfile.NativeMethodInfoPtr_AddColorGroup_Private_Void_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665606);
			SkyProfile.NativeMethodInfoPtr_AddTextureGroup_Private_Void_String_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665607);
			SkyProfile.NativeMethodInfoPtr_AddSpherePointGroup_Private_Void_String_String_SpherePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665608);
			SkyProfile.NativeMethodInfoPtr_AddBooleanGroup_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665609);
			SkyProfile.NativeMethodInfoPtr_GetGroup_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665610);
			SkyProfile.NativeMethodInfoPtr_GetGroup_Public_IKeyframeGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665611);
			SkyProfile.NativeMethodInfoPtr_GetGroupWithId_Public_IKeyframeGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665612);
			SkyProfile.NativeMethodInfoPtr_GetProfileDefinitions_Public_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665613);
			SkyProfile.NativeMethodInfoPtr_GetSectionInfo_Public_ProfileGroupSection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665614);
			SkyProfile.NativeMethodInfoPtr_IsManagedByTimeline_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665615);
			SkyProfile.NativeMethodInfoPtr_ValidateTimelineGroupKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665616);
			SkyProfile.NativeMethodInfoPtr_GetGroupDefinitionsManagedByTimeline_Public_List_1_ProfileGroupDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665617);
			SkyProfile.NativeMethodInfoPtr_GetGroupDefinitionsNotManagedByTimeline_Public_List_1_ProfileGroupDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665618);
			SkyProfile.NativeMethodInfoPtr_GetGroupDefinitionForKey_Public_ProfileGroupDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665619);
			SkyProfile.NativeMethodInfoPtr_RebuildKeyToGroupInfoMapping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665620);
			SkyProfile.NativeMethodInfoPtr_TrimGroupToSingleKeyframe_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665621);
			SkyProfile.NativeMethodInfoPtr_CanGroupBeOnTimeline_Public_Boolean_ProfileGroupDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665622);
			SkyProfile.NativeMethodInfoPtr_MergeShaderKeywordsWithDefinitions_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665623);
			SkyProfile.NativeMethodInfoPtr_IsFeatureEnabled_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665624);
			SkyProfile.NativeMethodInfoPtr_SetFeatureEnabled_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr, 100665625);
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x000B4270 File Offset: 0x000B2470
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x000B42B0 File Offset: 0x000B24B0
		public unsafe Material skyboxMaterial
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_get_skyboxMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92850, XrefRangeEnd = 92870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_set_skyboxMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x000B42F4 File Offset: 0x000B24F4
		public unsafe string shaderName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_get_shaderName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x000B432C File Offset: 0x000B252C
		public unsafe Il2CppReferenceArray<ProfileGroupSection> groupDefinitions
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 92873, RefRangeEnd = 92881, XrefRangeStart = 92870, XrefRangeEnd = 92873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_get_groupDefinitions_Public_get_Il2CppReferenceArray_1_ProfileGroupSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x000B436C File Offset: 0x000B256C
		public unsafe Il2CppReferenceArray<ProfileFeatureSection> featureDefinitions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92881, XrefRangeEnd = 92884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_get_featureDefinitions_Public_get_Il2CppReferenceArray_1_ProfileFeatureSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureSection>>(intPtr3) : null;
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000B43AC File Offset: 0x000B25AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92884, XrefRangeEnd = 92885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNumberPropertyValue(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetNumberPropertyValue_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000B43FC File Offset: 0x000B25FC
		[CallerCount(104)]
		[CachedScanResults(RefRangeStart = 92896, RefRangeEnd = 93000, XrefRangeStart = 92885, XrefRangeEnd = 92896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNumberPropertyValue(string propertyKey, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetNumberPropertyValue_Public_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000B4458 File Offset: 0x000B2658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93000, XrefRangeEnd = 93001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColorPropertyValue(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetColorPropertyValue_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000B44A8 File Offset: 0x000B26A8
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 93013, RefRangeEnd = 93040, XrefRangeStart = 93001, XrefRangeEnd = 93013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColorPropertyValue(string propertyKey, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetColorPropertyValue_Public_Color_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000B4504 File Offset: 0x000B2704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93040, XrefRangeEnd = 93041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexturePropertyValue(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetTexturePropertyValue_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000B4554 File Offset: 0x000B2754
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 93056, RefRangeEnd = 93071, XrefRangeStart = 93041, XrefRangeEnd = 93056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexturePropertyValue(string propertyKey, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetTexturePropertyValue_Public_Texture_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000B45B4 File Offset: 0x000B27B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93071, XrefRangeEnd = 93072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint GetSpherePointPropertyValue(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetSpherePointPropertyValue_Public_SpherePoint_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000B4604 File Offset: 0x000B2804
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93083, RefRangeEnd = 93086, XrefRangeStart = 93072, XrefRangeEnd = 93083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetSpherePointPropertyValue_Public_SpherePoint_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000B4664 File Offset: 0x000B2864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93086, XrefRangeEnd = 93087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolPropertyValue(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetBoolPropertyValue_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000B46B4 File Offset: 0x000B28B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93098, RefRangeEnd = 93100, XrefRangeStart = 93087, XrefRangeEnd = 93098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolPropertyValue(string propertyKey, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetBoolPropertyValue_Public_Boolean_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000B4710 File Offset: 0x000B2910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93100, XrefRangeEnd = 93125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000B474C File Offset: 0x000B294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93125, XrefRangeEnd = 93126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000B4780 File Offset: 0x000B2980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93154, RefRangeEnd = 93156, XrefRangeStart = 93126, XrefRangeEnd = 93154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadFullProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_ReloadFullProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000B47B4 File Offset: 0x000B29B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93164, RefRangeEnd = 93167, XrefRangeStart = 93156, XrefRangeEnd = 93164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadDefinitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_ReloadDefinitions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000B47E8 File Offset: 0x000B29E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93167, XrefRangeEnd = 93174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IProfileDefinition GetShaderInfoForMaterial(string shaderName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetShaderInfoForMaterial_Private_IProfileDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IProfileDefinition>(intPtr3) : null;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000B4838 File Offset: 0x000B2A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93174, XrefRangeEnd = 93185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeProfileWithDefinitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_MergeProfileWithDefinitions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000B486C File Offset: 0x000B2A6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93229, RefRangeEnd = 93231, XrefRangeStart = 93185, XrefRangeEnd = 93229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeGroupsWithDefinitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_MergeGroupsWithDefinitions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000B48A0 File Offset: 0x000B2AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93231, XrefRangeEnd = 93243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GroupDefinitionDictionary_Public_Dictionary_2_String_ProfileGroupDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProfileGroupDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000B48E0 File Offset: 0x000B2AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93243, XrefRangeEnd = 93244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ProfileGroupSection> ProfileDefinitionTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_ProfileDefinitionTable_Public_Il2CppReferenceArray_1_ProfileGroupSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000B4920 File Offset: 0x000B2B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93262, RefRangeEnd = 93263, XrefRangeStart = 93244, XrefRangeEnd = 93262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNumericGroup(string propKey, string groupName, float min, float max, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_AddNumericGroup_Private_Void_String_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000B49A0 File Offset: 0x000B2BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93281, RefRangeEnd = 93282, XrefRangeStart = 93263, XrefRangeEnd = 93281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColorGroup(string propKey, string groupName, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_AddColorGroup_Private_Void_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000B4A04 File Offset: 0x000B2C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93301, RefRangeEnd = 93302, XrefRangeStart = 93282, XrefRangeEnd = 93301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTextureGroup(string propKey, string groupName, Texture2D texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_AddTextureGroup_Private_Void_String_String_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000B4A6C File Offset: 0x000B2C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93331, RefRangeEnd = 93332, XrefRangeStart = 93302, XrefRangeEnd = 93331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpherePointGroup(string propKey, string groupName, SpherePoint point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_AddSpherePointGroup_Private_Void_String_String_SpherePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000B4AD4 File Offset: 0x000B2CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93350, RefRangeEnd = 93351, XrefRangeStart = 93332, XrefRangeEnd = 93350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBooleanGroup(string propKey, string groupName, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_AddBooleanGroup_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000B4B38 File Offset: 0x000B2D38
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 93366, RefRangeEnd = 93386, XrefRangeStart = 93351, XrefRangeEnd = 93366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetGroup<T>(string propertyKey) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.MethodInfoStoreGeneric_GetGroup_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000B4B84 File Offset: 0x000B2D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93386, XrefRangeEnd = 93388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IKeyframeGroup GetGroup(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetGroup_Public_IKeyframeGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IKeyframeGroup>(intPtr3) : null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000B4BD4 File Offset: 0x000B2DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93388, XrefRangeEnd = 93410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IKeyframeGroup GetGroupWithId(string groupId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetGroupWithId_Public_IKeyframeGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IKeyframeGroup>(intPtr3) : null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000B4C24 File Offset: 0x000B2E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ProfileGroupSection> GetProfileDefinitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetProfileDefinitions_Public_Il2CppReferenceArray_1_ProfileGroupSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000B4C64 File Offset: 0x000B2E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93410, XrefRangeEnd = 93413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileGroupSection GetSectionInfo(string sectionKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sectionKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetSectionInfo_Public_ProfileGroupSection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupSection>(intPtr3) : null;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000B4CB4 File Offset: 0x000B2EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93417, RefRangeEnd = 93418, XrefRangeStart = 93413, XrefRangeEnd = 93417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsManagedByTimeline(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_IsManagedByTimeline_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000B4D04 File Offset: 0x000B2F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93464, RefRangeEnd = 93465, XrefRangeStart = 93418, XrefRangeEnd = 93464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateTimelineGroupKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_ValidateTimelineGroupKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000B4D38 File Offset: 0x000B2F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93465, XrefRangeEnd = 93491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetGroupDefinitionsManagedByTimeline_Public_List_1_ProfileGroupDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProfileGroupDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000B4D78 File Offset: 0x000B2F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93491, XrefRangeEnd = 93505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetGroupDefinitionsNotManagedByTimeline_Public_List_1_ProfileGroupDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProfileGroupDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000B4DB8 File Offset: 0x000B2FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93505, XrefRangeEnd = 93508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_GetGroupDefinitionForKey_Public_ProfileGroupDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000B4E08 File Offset: 0x000B3008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93508, XrefRangeEnd = 93521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildKeyToGroupInfoMapping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_RebuildKeyToGroupInfoMapping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000B4E3C File Offset: 0x000B303C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93521, XrefRangeEnd = 93525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimGroupToSingleKeyframe(string propertyKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_TrimGroupToSingleKeyframe_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000B4E80 File Offset: 0x000B3080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93534, RefRangeEnd = 93535, XrefRangeStart = 93525, XrefRangeEnd = 93534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGroupBeOnTimeline(ProfileGroupDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_CanGroupBeOnTimeline_Public_Boolean_ProfileGroupDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000B4ED0 File Offset: 0x000B30D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93535, XrefRangeEnd = 93545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeShaderKeywordsWithDefinitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_MergeShaderKeywordsWithDefinitions_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000B4F04 File Offset: 0x000B3104
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 93560, RefRangeEnd = 93611, XrefRangeStart = 93545, XrefRangeEnd = 93560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFeatureEnabled(string featureKey, bool recursive = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_IsFeatureEnabled_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000B4F60 File Offset: 0x000B3160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93621, RefRangeEnd = 93624, XrefRangeStart = 93611, XrefRangeEnd = 93621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeatureEnabled(string featureKey, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyProfile.NativeMethodInfoPtr_SetFeatureEnabled_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0000D006 File Offset: 0x0000B206
		public SkyProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x000B4FB0 File Offset: 0x000B31B0
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x0000D00F File Offset: 0x0000B20F
		public unsafe static string DefaultShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkyProfile.NativeFieldInfoPtr_DefaultShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkyProfile.NativeFieldInfoPtr_DefaultShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x000B4FD0 File Offset: 0x000B31D0
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x0000D021 File Offset: 0x0000B221
		public unsafe static string DefaultLegacyShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkyProfile.NativeFieldInfoPtr_DefaultLegacyShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkyProfile.NativeFieldInfoPtr_DefaultLegacyShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x000B4FF0 File Offset: 0x000B31F0
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0000D033 File Offset: 0x0000B233
		public unsafe Material m_SkyboxMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_SkyboxMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_SkyboxMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x000B5020 File Offset: 0x000B3220
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x0000D052 File Offset: 0x0000B252
		public unsafe string m_ShaderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_ShaderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_ShaderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x000B5048 File Offset: 0x000B3248
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x0000D071 File Offset: 0x0000B271
		public unsafe IProfileDefinition profileDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_profileDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IProfileDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_profileDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000B5078 File Offset: 0x000B3278
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0000D090 File Offset: 0x0000B290
		public unsafe List<string> timelineManagedKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_timelineManagedKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_timelineManagedKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000B50A8 File Offset: 0x000B32A8
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0000D0AF File Offset: 0x0000B2AF
		public unsafe KeyframeGroupDictionary keyframeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_keyframeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyframeGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_keyframeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000B50D8 File Offset: 0x000B32D8
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0000D0CE File Offset: 0x0000B2CE
		public unsafe BoolDictionary featureStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_featureStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_featureStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x000B5108 File Offset: 0x000B3308
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x0000D0ED File Offset: 0x0000B2ED
		public unsafe LightningArtSet lightningArtSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_lightningArtSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightningArtSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_lightningArtSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x000B5138 File Offset: 0x000B3338
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x0000D10C File Offset: 0x0000B30C
		public unsafe RainSplashArtSet rainSplashArtSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_rainSplashArtSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainSplashArtSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_rainSplashArtSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x000B5168 File Offset: 0x000B3368
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x0000D12B File Offset: 0x0000B32B
		public unsafe Texture2D starLayer1DataTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_starLayer1DataTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_starLayer1DataTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x000B5198 File Offset: 0x000B3398
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x0000D14A File Offset: 0x0000B34A
		public unsafe Texture2D starLayer2DataTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_starLayer2DataTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_starLayer2DataTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x000B51C8 File Offset: 0x000B33C8
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x0000D169 File Offset: 0x0000B369
		public unsafe Texture2D starLayer3DataTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_starLayer3DataTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_starLayer3DataTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x000B51F8 File Offset: 0x000B33F8
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x0000D188 File Offset: 0x0000B388
		public unsafe int m_ProfileVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_ProfileVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_ProfileVersion)) = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000B5220 File Offset: 0x000B3420
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x0000D1A3 File Offset: 0x0000B3A3
		public unsafe Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_KeyToGroupInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProfileGroupDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyProfile.NativeFieldInfoPtr_m_KeyToGroupInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_DefaultShaderName;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLegacyShaderName;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyboxMaterial;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderName;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_profileDefinition;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeFieldInfoPtr_timelineManagedKeys;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeFieldInfoPtr_keyframeGroups;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_featureStatus;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_lightningArtSet;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeFieldInfoPtr_rainSplashArtSet;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_starLayer1DataTexture;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_starLayer2DataTexture;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_starLayer3DataTexture;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfileVersion;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyToGroupInfo;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_get_skyboxMaterial_Public_get_Material_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_set_skyboxMaterial_Public_set_Void_Material_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderName_Public_get_String_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_groupDefinitions_Public_get_Il2CppReferenceArray_1_ProfileGroupSection_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_get_featureDefinitions_Public_get_Il2CppReferenceArray_1_ProfileFeatureSection_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberPropertyValue_Public_Single_String_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberPropertyValue_Public_Single_String_Single_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_GetColorPropertyValue_Public_Color_String_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_GetColorPropertyValue_Public_Color_String_Single_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_GetTexturePropertyValue_Public_Texture_String_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_GetTexturePropertyValue_Public_Texture_String_Single_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_GetSpherePointPropertyValue_Public_SpherePoint_String_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_GetSpherePointPropertyValue_Public_SpherePoint_String_Single_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolPropertyValue_Public_Boolean_String_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolPropertyValue_Public_Boolean_String_Single_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_ReloadFullProfile_Private_Void_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_ReloadDefinitions_Private_Void_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderInfoForMaterial_Private_IProfileDefinition_String_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_MergeProfileWithDefinitions_Public_Void_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_MergeGroupsWithDefinitions_Public_Void_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_GroupDefinitionDictionary_Public_Dictionary_2_String_ProfileGroupDefinition_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_ProfileDefinitionTable_Public_Il2CppReferenceArray_1_ProfileGroupSection_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_AddNumericGroup_Private_Void_String_String_Single_Single_Single_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_AddColorGroup_Private_Void_String_String_Color_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_AddTextureGroup_Private_Void_String_String_Texture2D_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_AddSpherePointGroup_Private_Void_String_String_SpherePoint_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_AddBooleanGroup_Private_Void_String_String_Boolean_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Public_T_String_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Public_IKeyframeGroup_String_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupWithId_Public_IKeyframeGroup_String_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_GetProfileDefinitions_Public_Il2CppReferenceArray_1_ProfileGroupSection_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_GetSectionInfo_Public_ProfileGroupSection_String_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_IsManagedByTimeline_Public_Boolean_String_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTimelineGroupKeys_Public_Void_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupDefinitionsManagedByTimeline_Public_List_1_ProfileGroupDefinition_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupDefinitionsNotManagedByTimeline_Public_List_1_ProfileGroupDefinition_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupDefinitionForKey_Public_ProfileGroupDefinition_String_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_RebuildKeyToGroupInfoMapping_Public_Void_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_TrimGroupToSingleKeyframe_Public_Void_String_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_CanGroupBeOnTimeline_Public_Boolean_ProfileGroupDefinition_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_MergeShaderKeywordsWithDefinitions_Protected_Void_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_IsFeatureEnabled_Public_Boolean_String_Boolean_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_SetFeatureEnabled_Public_Void_String_Boolean_0;

		// Token: 0x02000853 RID: 2131
		private sealed class MethodInfoStoreGeneric_GetGroup_Public_T_String_0<T>
		{
			// Token: 0x0400824B RID: 33355
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SkyProfile.NativeMethodInfoPtr_GetGroup_Public_T_String_0, Il2CppClassPointerStore<SkyProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
