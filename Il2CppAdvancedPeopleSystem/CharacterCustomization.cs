using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200013F RID: 319
	public class CharacterCustomization : MonoBehaviour
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x000C3384 File Offset: 0x000C1584
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomization()
		{
			Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterCustomization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr);
			CharacterCustomization.NativeFieldInfoPtr_isSettingsExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "isSettingsExpanded");
			CharacterCustomization.NativeFieldInfoPtr_selectedsettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "selectedsettings");
			CharacterCustomization.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "_settings");
			CharacterCustomization.NativeFieldInfoPtr_characterParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "characterParts");
			CharacterCustomization.NativeFieldInfoPtr_prefabPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "prefabPath");
			CharacterCustomization.NativeFieldInfoPtr_instanceStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "instanceStatus");
			CharacterCustomization.NativeFieldInfoPtr_originHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "originHip");
			CharacterCustomization.NativeFieldInfoPtr_headHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "headHip");
			CharacterCustomization.NativeFieldInfoPtr_clothesAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "clothesAnchors");
			CharacterCustomization.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "animator");
			CharacterCustomization.NativeFieldInfoPtr_characterSelectedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "characterSelectedElements");
			CharacterCustomization.NativeFieldInfoPtr_heightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "heightValue");
			CharacterCustomization.NativeFieldInfoPtr_headSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "headSizeValue");
			CharacterCustomization.NativeFieldInfoPtr_feetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "feetOffset");
			CharacterCustomization.NativeFieldInfoPtr_characterBlendshapeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "characterBlendshapeDatas");
			CharacterCustomization.NativeFieldInfoPtr_Skin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Skin");
			CharacterCustomization.NativeFieldInfoPtr_Eye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Eye");
			CharacterCustomization.NativeFieldInfoPtr_Hair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Hair");
			CharacterCustomization.NativeFieldInfoPtr_Underpants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Underpants");
			CharacterCustomization.NativeFieldInfoPtr_OralCavity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "OralCavity");
			CharacterCustomization.NativeFieldInfoPtr_Teeth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Teeth");
			CharacterCustomization.NativeFieldInfoPtr_bodyPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "bodyPropertyBlock");
			CharacterCustomization.NativeFieldInfoPtr_currentBlendshapeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "currentBlendshapeAnimation");
			CharacterCustomization.NativeFieldInfoPtr_CurrentCombinerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "CurrentCombinerState");
			CharacterCustomization.NativeFieldInfoPtr_combinedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "combinedCharacter");
			CharacterCustomization.NativeFieldInfoPtr_ProbesAnchorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "ProbesAnchorOverride");
			CharacterCustomization.NativeFieldInfoPtr_CharacterGenerator_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "CharacterGenerator_settings");
			CharacterCustomization.NativeFieldInfoPtr_UpdateWhenOffscreenMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "UpdateWhenOffscreenMeshes");
			CharacterCustomization.NativeFieldInfoPtr_MinLODLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "MinLODLevels");
			CharacterCustomization.NativeFieldInfoPtr_MaxLODLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "MaxLODLevels");
			CharacterCustomization.NativeFieldInfoPtr__lodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "_lodGroup");
			CharacterCustomization.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "_transform");
			CharacterCustomization.NativeFieldInfoPtr_applyFeetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "applyFeetOffset");
			CharacterCustomization.NativeFieldInfoPtr_notAPP2Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "notAPP2Shader");
			CharacterCustomization.NativeFieldInfoPtr_prebuiltPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "prebuiltPrefab");
			CharacterCustomization.NativeMethodInfoPtr_get_Settings_Public_get_CharacterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666105);
			CharacterCustomization.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666106);
			CharacterCustomization.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666107);
			CharacterCustomization.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666108);
			CharacterCustomization.NativeMethodInfoPtr_AnimationTick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666109);
			CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666110);
			CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666111);
			CharacterCustomization.NativeMethodInfoPtr_InitializeMeshes_Public_Void_CharacterSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666112);
			CharacterCustomization.NativeMethodInfoPtr_UpdateSkinnedMeshesOffscreenBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666113);
			CharacterCustomization.NativeMethodInfoPtr_GetCharacterSettingsSelectors_Public_List_1_CharacterSettingsSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666114);
			CharacterCustomization.NativeMethodInfoPtr_ResetBodyMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666115);
			CharacterCustomization.NativeMethodInfoPtr_InitColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666116);
			CharacterCustomization.NativeMethodInfoPtr_ResetBodyColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666117);
			CharacterCustomization.NativeMethodInfoPtr_SetBlendshapeValue_Public_Void_CharacterBlendShapeType_Single_Il2CppStringArray_Il2CppStructArray_1_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666118);
			CharacterCustomization.NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666119);
			CharacterCustomization.NativeMethodInfoPtr_SetElementByIndex_Public_Void_CharacterElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666120);
			CharacterCustomization.NativeMethodInfoPtr_ClearElement_Public_Void_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666121);
			CharacterCustomization.NativeMethodInfoPtr_SetHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666122);
			CharacterCustomization.NativeMethodInfoPtr_SetHeadSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666123);
			CharacterCustomization.NativeMethodInfoPtr_SetFeetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666124);
			CharacterCustomization.NativeMethodInfoPtr_SetHairByIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666125);
			CharacterCustomization.NativeMethodInfoPtr_SetBeardByIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666126);
			CharacterCustomization.NativeMethodInfoPtr_GetClothesAnchor_Public_ClothesAnchor_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666127);
			CharacterCustomization.NativeMethodInfoPtr_GetCharacterPart_Public_CharacterPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666128);
			CharacterCustomization.NativeMethodInfoPtr_GetAllMeshesByLod_Public_List_1_SkinnedMeshRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666129);
			CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666130);
			CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666131);
			CharacterCustomization.NativeMethodInfoPtr_HideParts_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666132);
			CharacterCustomization.NativeMethodInfoPtr_UnHideParts_Public_Void_Il2CppStringArray_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666133);
			CharacterCustomization.NativeMethodInfoPtr_SetBodyColor_Public_Void_BodyColorPart_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666134);
			CharacterCustomization.NativeMethodInfoPtr_GetBodyColor_Public_Color_BodyColorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666135);
			CharacterCustomization.NativeMethodInfoPtr_SetCharacterSetup_Public_Void_CharacterCustomizationSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666136);
			CharacterCustomization.NativeMethodInfoPtr_GetSetup_Public_CharacterCustomizationSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666137);
			CharacterCustomization.NativeMethodInfoPtr_ApplySavedCharacterData_Public_Void_SavedCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666138);
			CharacterCustomization.NativeMethodInfoPtr_LoadCharacterFromFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666139);
			CharacterCustomization.NativeMethodInfoPtr_GetSavedCharacterDatas_Public_List_1_SavedCharacterData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666140);
			CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_SavedCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666141);
			CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666142);
			CharacterCustomization.NativeMethodInfoPtr_SaveCharacterToFile_Public_Void_CharacterFileSaveFormat_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666143);
			CharacterCustomization.NativeMethodInfoPtr_RecalculateShapes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666144);
			CharacterCustomization.NativeMethodInfoPtr_EditorSavePreBuiltPrefab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666145);
			CharacterCustomization.NativeMethodInfoPtr_BakeCharacter_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666146);
			CharacterCustomization.NativeMethodInfoPtr_ClearBake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666147);
			CharacterCustomization.NativeMethodInfoPtr_RecalculateLOD_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666148);
			CharacterCustomization.NativeMethodInfoPtr_SetLODRange_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666149);
			CharacterCustomization.NativeMethodInfoPtr_IsBaked_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666150);
			CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666151);
			CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666152);
			CharacterCustomization.NativeMethodInfoPtr_GetElementsPresets_Public_List_1_CharacterElementsPreset_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666153);
			CharacterCustomization.NativeMethodInfoPtr_PlayBlendshapeAnimation_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666154);
			CharacterCustomization.NativeMethodInfoPtr_StopBlendshapeAnimations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666155);
			CharacterCustomization.NativeMethodInfoPtr_ResetAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666156);
			CharacterCustomization.NativeMethodInfoPtr_Randomize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666157);
			CharacterCustomization.NativeMethodInfoPtr_GetAnimator_Public_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666158);
			CharacterCustomization.NativeMethodInfoPtr_UnlockPrefab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666159);
			CharacterCustomization.NativeMethodInfoPtr_LockPrefab_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666160);
			CharacterCustomization.NativeMethodInfoPtr_ApplyPrefab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666161);
			CharacterCustomization.NativeMethodInfoPtr_RevertBonesChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666162);
			CharacterCustomization.NativeMethodInfoPtr_ApplyPrefabInPlaymode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666163);
			CharacterCustomization.NativeMethodInfoPtr_UpdateActualCharacterInstanceStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666164);
			CharacterCustomization.NativeMethodInfoPtr_GetCharacterInstanceStatus_Public_CharacterInstanceStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666165);
			CharacterCustomization.NativeMethodInfoPtr_SetNewCharacterInstanceStatus_Public_Void_CharacterInstanceStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666166);
			CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_CharacterBlendShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666167);
			CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666168);
			CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeDatasByGroup_Public_List_1_CharacterBlendshapeData_CharacterBlendShapeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666169);
			CharacterCustomization.NativeMethodInfoPtr_DestroyObjects_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666170);
			CharacterCustomization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666171);
			CharacterCustomization.NativeMethodInfoPtr_Method_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666172);
			CharacterCustomization.NativeMethodInfoPtr__BakeCharacter_b__77_1_Private_Void_List_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666173);
			CharacterCustomization.NativeMethodInfoPtr__ClearBake_b__78_0_Private_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666174);
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000C3BE8 File Offset: 0x000C1DE8
		public unsafe CharacterSettings Settings
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_get_Settings_Public_get_CharacterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000C3C28 File Offset: 0x000C1E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97276, XrefRangeEnd = 97283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000C3C5C File Offset: 0x000C1E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97283, XrefRangeEnd = 97284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x000C3C90 File Offset: 0x000C1E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97284, XrefRangeEnd = 97285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000C3CC4 File Offset: 0x000C1EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97303, RefRangeEnd = 97304, XrefRangeStart = 97285, XrefRangeEnd = 97303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimationTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_AnimationTick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000C3CF8 File Offset: 0x000C1EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97309, RefRangeEnd = 97310, XrefRangeStart = 97304, XrefRangeEnd = 97309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchCharacterSettings(int settingsIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settingsIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000C3D38 File Offset: 0x000C1F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97317, RefRangeEnd = 97318, XrefRangeStart = 97310, XrefRangeEnd = 97317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchCharacterSettings(string selectorName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectorName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000C3D7C File Offset: 0x000C1F7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97714, RefRangeEnd = 97716, XrefRangeStart = 97318, XrefRangeEnd = 97714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeMeshes(CharacterSettings newSettings = null, bool resetAll = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_InitializeMeshes_Public_Void_CharacterSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000C3DCC File Offset: 0x000C1FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97742, RefRangeEnd = 97743, XrefRangeStart = 97716, XrefRangeEnd = 97742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSkinnedMeshesOffscreenBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UpdateSkinnedMeshesOffscreenBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000C3E00 File Offset: 0x000C2000
		[CallerCount(0)]
		public unsafe List<CharacterSettingsSelector> GetCharacterSettingsSelectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetCharacterSettingsSelectors_Public_List_1_CharacterSettingsSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CharacterSettingsSelector>>(intPtr3) : null;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000C3E40 File Offset: 0x000C2040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97871, RefRangeEnd = 97873, XrefRangeStart = 97743, XrefRangeEnd = 97871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ResetBodyMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x000C3E74 File Offset: 0x000C2074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97888, RefRangeEnd = 97890, XrefRangeStart = 97873, XrefRangeEnd = 97888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_InitColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000C3EA8 File Offset: 0x000C20A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97926, RefRangeEnd = 97927, XrefRangeStart = 97890, XrefRangeEnd = 97926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodyColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ResetBodyColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000C3EDC File Offset: 0x000C20DC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 98049, RefRangeEnd = 98066, XrefRangeStart = 97927, XrefRangeEnd = 98049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlendshapeValue(CharacterBlendShapeType type, float weight, Il2CppStringArray forPart = null, Il2CppStructArray<CharacterElementType> forClothPart = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPart);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forClothPart);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetBlendshapeValue_Public_Void_CharacterBlendShapeType_Single_Il2CppStringArray_Il2CppStructArray_1_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000C3F50 File Offset: 0x000C2150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98067, RefRangeEnd = 98068, XrefRangeStart = 98066, XrefRangeEnd = 98067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLOD(int lodLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lodLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000C3F90 File Offset: 0x000C2190
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 98203, RefRangeEnd = 98221, XrefRangeStart = 98068, XrefRangeEnd = 98203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementByIndex(CharacterElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetElementByIndex_Public_Void_CharacterElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000C3FDC File Offset: 0x000C21DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98221, XrefRangeEnd = 98224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearElement(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearElement_Public_Void_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000C401C File Offset: 0x000C221C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98229, RefRangeEnd = 98231, XrefRangeStart = 98224, XrefRangeEnd = 98229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000C405C File Offset: 0x000C225C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98240, RefRangeEnd = 98242, XrefRangeStart = 98231, XrefRangeEnd = 98240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetHeadSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000C409C File Offset: 0x000C229C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98242, XrefRangeEnd = 98243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeetOffset(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetFeetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000C40DC File Offset: 0x000C22DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98276, RefRangeEnd = 98278, XrefRangeStart = 98243, XrefRangeEnd = 98276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHairByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetHairByIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000C411C File Offset: 0x000C231C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98310, RefRangeEnd = 98312, XrefRangeStart = 98278, XrefRangeEnd = 98310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBeardByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetBeardByIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000C415C File Offset: 0x000C235C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98322, RefRangeEnd = 98324, XrefRangeStart = 98312, XrefRangeEnd = 98322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothesAnchor GetClothesAnchor(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetClothesAnchor_Public_ClothesAnchor_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothesAnchor>(intPtr3) : null;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000C41A8 File Offset: 0x000C23A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 98337, RefRangeEnd = 98348, XrefRangeStart = 98324, XrefRangeEnd = 98337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPart GetCharacterPart(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetCharacterPart_Public_CharacterPart_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPart>(intPtr3) : null;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000C41F8 File Offset: 0x000C23F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98393, RefRangeEnd = 98394, XrefRangeStart = 98348, XrefRangeEnd = 98393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SkinnedMeshRenderer> GetAllMeshesByLod(int lod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAllMeshesByLod_Public_List_1_SkinnedMeshRenderer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000C4244 File Offset: 0x000C2444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98433, RefRangeEnd = 98434, XrefRangeStart = 98394, XrefRangeEnd = 98433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SkinnedMeshRenderer> GetAllMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000C4284 File Offset: 0x000C2484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98476, RefRangeEnd = 98477, XrefRangeStart = 98434, XrefRangeEnd = 98476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SkinnedMeshRenderer> GetAllMeshes(bool onlyBodyMeshes = false, Il2CppStringArray excludeNames = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyBodyMeshes;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000C42E4 File Offset: 0x000C24E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98477, XrefRangeEnd = 98510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideParts(Il2CppStringArray parts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_HideParts_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000C4328 File Offset: 0x000C2528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98557, RefRangeEnd = 98558, XrefRangeStart = 98511, XrefRangeEnd = 98557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnHideParts(Il2CppStringArray parts, CharacterElementType hidePartsForElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidePartsForElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UnHideParts_Public_Void_Il2CppStringArray_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x000C4378 File Offset: 0x000C2578
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 98626, RefRangeEnd = 98655, XrefRangeStart = 98558, XrefRangeEnd = 98626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBodyColor(BodyColorPart bodyColorPart, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bodyColorPart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetBodyColor_Public_Void_BodyColorPart_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000C43C4 File Offset: 0x000C25C4
		[CallerCount(0)]
		public unsafe Color GetBodyColor(BodyColorPart bodyColorPart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bodyColorPart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBodyColor_Public_Color_BodyColorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000C4410 File Offset: 0x000C2610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98655, XrefRangeEnd = 98657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharacterSetup(CharacterCustomizationSetup characterCustomizationSetup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterCustomizationSetup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetCharacterSetup_Public_Void_CharacterCustomizationSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000C4454 File Offset: 0x000C2654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98705, RefRangeEnd = 98706, XrefRangeStart = 98657, XrefRangeEnd = 98705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationSetup GetSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetSetup_Public_CharacterCustomizationSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationSetup>(intPtr3) : null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000C4494 File Offset: 0x000C2694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98708, RefRangeEnd = 98710, XrefRangeStart = 98706, XrefRangeEnd = 98708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySavedCharacterData(SavedCharacterData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ApplySavedCharacterData_Public_Void_SavedCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000C44D8 File Offset: 0x000C26D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98733, RefRangeEnd = 98734, XrefRangeStart = 98710, XrefRangeEnd = 98733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadCharacterFromFile(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_LoadCharacterFromFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000C451C File Offset: 0x000C271C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 98778, RefRangeEnd = 98782, XrefRangeStart = 98734, XrefRangeEnd = 98778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SavedCharacterData> GetSavedCharacterDatas(string path = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetSavedCharacterDatas_Public_List_1_SavedCharacterData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SavedCharacterData>>(intPtr3) : null;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000C456C File Offset: 0x000C276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98782, XrefRangeEnd = 98784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSavedData(SavedCharacterData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_SavedCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000C45B0 File Offset: 0x000C27B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98814, RefRangeEnd = 98815, XrefRangeStart = 98784, XrefRangeEnd = 98814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSavedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000C45E4 File Offset: 0x000C27E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98899, RefRangeEnd = 98900, XrefRangeStart = 98815, XrefRangeEnd = 98899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveCharacterToFile(CharacterCustomizationSetup.CharacterFileSaveFormat format, string path = "", string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SaveCharacterToFile_Public_Void_CharacterFileSaveFormat_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000C4648 File Offset: 0x000C2848
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98915, RefRangeEnd = 98918, XrefRangeStart = 98900, XrefRangeEnd = 98915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateShapes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_RecalculateShapes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x000C467C File Offset: 0x000C287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98918, XrefRangeEnd = 98924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditorSavePreBuiltPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_EditorSavePreBuiltPrefab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000C46B0 File Offset: 0x000C28B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98924, XrefRangeEnd = 98960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeCharacter(bool usePreBuiltMeshes = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usePreBuiltMeshes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_BakeCharacter_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000C46F0 File Offset: 0x000C28F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98960, XrefRangeEnd = 99041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearBake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000C4724 File Offset: 0x000C2924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99127, RefRangeEnd = 99129, XrefRangeStart = 99041, XrefRangeEnd = 99127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateLOD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_RecalculateLOD_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000C4758 File Offset: 0x000C2958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99129, XrefRangeEnd = 99130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLODRange(int minLod, int maxLod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minLod;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetLODRange_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000C47A4 File Offset: 0x000C29A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99130, RefRangeEnd = 99131, XrefRangeStart = 99130, XrefRangeEnd = 99130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBaked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_IsBaked_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000C47E0 File Offset: 0x000C29E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 99136, RefRangeEnd = 99143, XrefRangeStart = 99131, XrefRangeEnd = 99136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterElementsPreset GetElementsPreset(CharacterElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterElementsPreset>(intPtr3) : null;
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000C483C File Offset: 0x000C2A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99143, XrefRangeEnd = 99159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterElementsPreset GetElementsPreset(CharacterElementType type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterElementsPreset>(intPtr3) : null;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000C489C File Offset: 0x000C2A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99159, RefRangeEnd = 99161, XrefRangeStart = 99159, XrefRangeEnd = 99159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<CharacterElementsPreset> GetElementsPresets(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetElementsPresets_Public_List_1_CharacterElementsPreset_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr3) : null;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000C48E8 File Offset: 0x000C2AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99221, RefRangeEnd = 99222, XrefRangeStart = 99161, XrefRangeEnd = 99221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBlendshapeAnimation(string animationName, float duration = 1f, float weightPower = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weightPower;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_PlayBlendshapeAnimation_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000C4948 File Offset: 0x000C2B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99222, XrefRangeEnd = 99230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBlendshapeAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_StopBlendshapeAnimations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000C497C File Offset: 0x000C2B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99323, RefRangeEnd = 99324, XrefRangeStart = 99230, XrefRangeEnd = 99323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAll(bool ignore_settingsDefaultElements = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore_settingsDefaultElements;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ResetAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000C49BC File Offset: 0x000C2BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99325, RefRangeEnd = 99326, XrefRangeStart = 99324, XrefRangeEnd = 99325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Randomize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000C49F0 File Offset: 0x000C2BF0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Animator GetAnimator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAnimator_Public_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000C4A30 File Offset: 0x000C2C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99326, XrefRangeEnd = 99330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UnlockPrefab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000C4A64 File Offset: 0x000C2C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99330, XrefRangeEnd = 99334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockPrefab(string custompath = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(custompath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_LockPrefab_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000C4AA8 File Offset: 0x000C2CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99334, XrefRangeEnd = 99340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ApplyPrefab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000C4ADC File Offset: 0x000C2CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99340, XrefRangeEnd = 99358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertBonesChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_RevertBonesChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000C4B10 File Offset: 0x000C2D10
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPrefabInPlaymode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ApplyPrefabInPlaymode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000C4B44 File Offset: 0x000C2D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99358, XrefRangeEnd = 99362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActualCharacterInstanceStatus(bool igroneUserNonPrefab = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref igroneUserNonPrefab;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UpdateActualCharacterInstanceStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000C4B84 File Offset: 0x000C2D84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42839, RefRangeEnd = 42843, XrefRangeStart = 42839, XrefRangeEnd = 42843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterInstanceStatus GetCharacterInstanceStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetCharacterInstanceStatus_Public_CharacterInstanceStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000C4BC0 File Offset: 0x000C2DC0
		[CallerCount(0)]
		public unsafe void SetNewCharacterInstanceStatus(CharacterInstanceStatus characterInstanceStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterInstanceStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetNewCharacterInstanceStatus_Public_Void_CharacterInstanceStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000C4C00 File Offset: 0x000C2E00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99372, RefRangeEnd = 99376, XrefRangeStart = 99362, XrefRangeEnd = 99372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData GetBlendshapeData(CharacterBlendShapeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_CharacterBlendShapeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterBlendshapeData>(intPtr3) : null;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000C4C4C File Offset: 0x000C2E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99387, RefRangeEnd = 99388, XrefRangeStart = 99376, XrefRangeEnd = 99387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData GetBlendshapeData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterBlendshapeData>(intPtr3) : null;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000C4C9C File Offset: 0x000C2E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99411, RefRangeEnd = 99412, XrefRangeStart = 99388, XrefRangeEnd = 99411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<CharacterBlendshapeData> GetBlendshapeDatasByGroup(CharacterBlendShapeGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref group;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeDatasByGroup_Public_List_1_CharacterBlendshapeData_CharacterBlendShapeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr3) : null;
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x000C4CE8 File Offset: 0x000C2EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99420, RefRangeEnd = 99421, XrefRangeStart = 99412, XrefRangeEnd = 99420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyObjects(Il2CppReferenceArray<UnityEngine.Object> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_DestroyObjects_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000C4D2C File Offset: 0x000C2F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99421, XrefRangeEnd = 99451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomization() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000C4D68 File Offset: 0x000C2F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99559, RefRangeEnd = 99560, XrefRangeStart = 99451, XrefRangeEnd = 99559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Boolean_0(bool usePreBuilt = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usePreBuilt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Method_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000C4DA8 File Offset: 0x000C2FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99560, XrefRangeEnd = 99561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BakeCharacter_b__77_1(List<SkinnedMeshRenderer> meshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr__BakeCharacter_b__77_1_Private_Void_List_1_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000C4DEC File Offset: 0x000C2FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99561, XrefRangeEnd = 99578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ClearBake_b__78_0(SkinnedMeshRenderer m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr__ClearBake_b__78_0_Private_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0000EFFE File Offset: 0x0000D1FE
		public CharacterCustomization(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000C4E30 File Offset: 0x000C3030
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000F007 File Offset: 0x0000D207
		public unsafe bool isSettingsExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_isSettingsExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_isSettingsExpanded)) = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x000C4E58 File Offset: 0x000C3058
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0000F022 File Offset: 0x0000D222
		public unsafe CharacterSettings selectedsettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_selectedsettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_selectedsettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x000C4E88 File Offset: 0x000C3088
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0000F041 File Offset: 0x0000D241
		public unsafe CharacterSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x000C4EB8 File Offset: 0x000C30B8
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0000F060 File Offset: 0x0000D260
		public unsafe List<CharacterPart> characterParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterPart>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x000C4EE8 File Offset: 0x000C30E8
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0000F07F File Offset: 0x0000D27F
		public unsafe string prefabPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prefabPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prefabPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000C4F10 File Offset: 0x000C3110
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0000F09E File Offset: 0x0000D29E
		public unsafe CharacterInstanceStatus instanceStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_instanceStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_instanceStatus)) = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000C4F38 File Offset: 0x000C3138
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0000F0B9 File Offset: 0x0000D2B9
		public unsafe Transform originHip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_originHip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_originHip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000C4F68 File Offset: 0x000C3168
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		public unsafe Transform headHip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headHip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headHip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x000C4F98 File Offset: 0x000C3198
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0000F0F7 File Offset: 0x0000D2F7
		public unsafe List<ClothesAnchor> clothesAnchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_clothesAnchors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothesAnchor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_clothesAnchors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x000C4FC8 File Offset: 0x000C31C8
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0000F116 File Offset: 0x0000D316
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x000C4FF8 File Offset: 0x000C31F8
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0000F135 File Offset: 0x0000D335
		public unsafe CharacterSelectedElements characterSelectedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterSelectedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSelectedElements>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterSelectedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x000C5028 File Offset: 0x000C3228
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000F154 File Offset: 0x0000D354
		public unsafe float heightValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_heightValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_heightValue)) = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000C5050 File Offset: 0x000C3250
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000F16F File Offset: 0x0000D36F
		public unsafe float headSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headSizeValue)) = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x000C5078 File Offset: 0x000C3278
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000F18A File Offset: 0x0000D38A
		public unsafe float feetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_feetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_feetOffset)) = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x000C50A0 File Offset: 0x000C32A0
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000F1A5 File Offset: 0x0000D3A5
		public unsafe List<CharacterBlendshapeData> characterBlendshapeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterBlendshapeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterBlendshapeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x000C50D0 File Offset: 0x000C32D0
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		public unsafe Color Skin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Skin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Skin)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x000C50F8 File Offset: 0x000C32F8
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0000F1DF File Offset: 0x0000D3DF
		public unsafe Color Eye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Eye);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Eye)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x000C5120 File Offset: 0x000C3320
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0000F1FA File Offset: 0x0000D3FA
		public unsafe Color Hair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Hair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Hair)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x000C5148 File Offset: 0x000C3348
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0000F215 File Offset: 0x0000D415
		public unsafe Color Underpants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Underpants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Underpants)) = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x000C5170 File Offset: 0x000C3370
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0000F230 File Offset: 0x0000D430
		public unsafe Color OralCavity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_OralCavity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_OralCavity)) = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x000C5198 File Offset: 0x000C3398
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x0000F24B File Offset: 0x0000D44B
		public unsafe Color Teeth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Teeth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Teeth)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x000C51C0 File Offset: 0x000C33C0
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0000F266 File Offset: 0x0000D466
		public unsafe MaterialPropertyBlock bodyPropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_bodyPropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_bodyPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x000C51F0 File Offset: 0x000C33F0
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0000F285 File Offset: 0x0000D485
		public unsafe CurrentBlendshapeAnimation currentBlendshapeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_currentBlendshapeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurrentBlendshapeAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_currentBlendshapeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x000C5220 File Offset: 0x000C3420
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		public unsafe CombinerState CurrentCombinerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CurrentCombinerState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CurrentCombinerState)) = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000C5248 File Offset: 0x000C3448
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0000F2BF File Offset: 0x0000D4BF
		public unsafe CharacterPreBuilt combinedCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_combinedCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterPreBuilt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_combinedCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000C5278 File Offset: 0x000C3478
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0000F2DE File Offset: 0x0000D4DE
		public unsafe Transform ProbesAnchorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_ProbesAnchorOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_ProbesAnchorOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x000C52A8 File Offset: 0x000C34A8
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0000F2FD File Offset: 0x0000D4FD
		public unsafe CharacterGeneratorSettings CharacterGenerator_settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CharacterGenerator_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterGeneratorSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CharacterGenerator_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000C52D8 File Offset: 0x000C34D8
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0000F31C File Offset: 0x0000D51C
		public unsafe bool UpdateWhenOffscreenMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_UpdateWhenOffscreenMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_UpdateWhenOffscreenMeshes)) = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x000C5300 File Offset: 0x000C3500
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x0000F337 File Offset: 0x0000D537
		public unsafe int MinLODLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MinLODLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MinLODLevels)) = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x000C5328 File Offset: 0x000C3528
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0000F352 File Offset: 0x0000D552
		public unsafe int MaxLODLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MaxLODLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MaxLODLevels)) = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x000C5350 File Offset: 0x000C3550
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0000F36D File Offset: 0x0000D56D
		public unsafe LODGroup _lodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__lodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LODGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__lodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x000C5380 File Offset: 0x000C3580
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0000F38C File Offset: 0x0000D58C
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x000C53B0 File Offset: 0x000C35B0
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0000F3AB File Offset: 0x0000D5AB
		public unsafe bool applyFeetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_applyFeetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_applyFeetOffset)) = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000C53D8 File Offset: 0x000C35D8
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0000F3C6 File Offset: 0x0000D5C6
		public unsafe bool notAPP2Shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_notAPP2Shader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_notAPP2Shader)) = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x000C5400 File Offset: 0x000C3600
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0000F3E1 File Offset: 0x0000D5E1
		public unsafe GameObject prebuiltPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prebuiltPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prebuiltPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeFieldInfoPtr_isSettingsExpanded;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeFieldInfoPtr_selectedsettings;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeFieldInfoPtr_characterParts;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr_prefabPath;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeFieldInfoPtr_instanceStatus;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeFieldInfoPtr_originHip;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeFieldInfoPtr_headHip;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeFieldInfoPtr_clothesAnchors;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeFieldInfoPtr_characterSelectedElements;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeFieldInfoPtr_heightValue;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeFieldInfoPtr_headSizeValue;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeFieldInfoPtr_feetOffset;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_characterBlendshapeDatas;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeFieldInfoPtr_Skin;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeFieldInfoPtr_Eye;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_Hair;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_Underpants;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr_OralCavity;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeFieldInfoPtr_Teeth;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_bodyPropertyBlock;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr_currentBlendshapeAnimation;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr_CurrentCombinerState;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_combinedCharacter;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_ProbesAnchorOverride;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_CharacterGenerator_settings;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_UpdateWhenOffscreenMeshes;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_MinLODLevels;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr_MaxLODLevels;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr__lodGroup;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr_applyFeetOffset;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr_notAPP2Shader;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_prebuiltPrefab;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_CharacterSettings_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_AnimationTick_Public_Void_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_Int32_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMeshes_Public_Void_CharacterSettings_Boolean_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSkinnedMeshesOffscreenBounds_Public_Void_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterSettingsSelectors_Public_List_1_CharacterSettingsSelector_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodyMaterial_Public_Void_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_InitColors_Public_Void_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodyColors_Public_Void_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendshapeValue_Public_Void_CharacterBlendShapeType_Single_Il2CppStringArray_Il2CppStructArray_1_CharacterElementType_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_SetElementByIndex_Public_Void_CharacterElementType_Int32_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_ClearElement_Public_Void_CharacterElementType_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_SetHeight_Public_Void_Single_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadSize_Public_Void_Single_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_SetFeetOffset_Public_Void_Vector3_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_SetHairByIndex_Private_Void_Int32_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_SetBeardByIndex_Private_Void_Int32_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_GetClothesAnchor_Public_ClothesAnchor_CharacterElementType_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterPart_Public_CharacterPart_String_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMeshesByLod_Public_List_1_SkinnedMeshRenderer_Int32_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_Boolean_Il2CppStringArray_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_HideParts_Public_Void_Il2CppStringArray_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_UnHideParts_Public_Void_Il2CppStringArray_CharacterElementType_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_SetBodyColor_Public_Void_BodyColorPart_Color_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_GetBodyColor_Public_Color_BodyColorPart_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_SetCharacterSetup_Public_Void_CharacterCustomizationSetup_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_GetSetup_Public_CharacterCustomizationSetup_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_ApplySavedCharacterData_Public_Void_SavedCharacterData_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_LoadCharacterFromFile_Public_Void_String_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedCharacterDatas_Public_List_1_SavedCharacterData_String_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_ClearSavedData_Public_Void_SavedCharacterData_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_ClearSavedData_Public_Void_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_SaveCharacterToFile_Public_Void_CharacterFileSaveFormat_String_String_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateShapes_Public_Void_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_EditorSavePreBuiltPrefab_Public_Void_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_BakeCharacter_Public_Void_Boolean_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_ClearBake_Public_Void_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateLOD_Public_Void_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_SetLODRange_Public_Void_Int32_Int32_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_IsBaked_Public_Boolean_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_Int32_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_String_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_GetElementsPresets_Public_List_1_CharacterElementsPreset_CharacterElementType_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_PlayBlendshapeAnimation_Public_Void_String_Single_Single_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_StopBlendshapeAnimations_Public_Void_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_ResetAll_Public_Void_Boolean_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Public_Void_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimator_Public_Animator_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_UnlockPrefab_Public_Void_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_LockPrefab_Public_Void_String_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPrefab_Public_Void_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_RevertBonesChanges_Public_Void_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPrefabInPlaymode_Public_Void_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActualCharacterInstanceStatus_Public_Void_Boolean_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInstanceStatus_Public_CharacterInstanceStatus_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCharacterInstanceStatus_Public_Void_CharacterInstanceStatus_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_CharacterBlendShapeType_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_String_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendshapeDatasByGroup_Public_List_1_CharacterBlendshapeData_CharacterBlendShapeGroup_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_DestroyObjects_Private_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_1_Private_Void_List_1_SkinnedMeshRenderer_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr__ClearBake_b__78_0_Private_Void_SkinnedMeshRenderer_0;

		// Token: 0x02000859 RID: 2137
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C063 RID: 49251 RVA: 0x002F09B4 File Offset: 0x002EEBB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr);
				CharacterCustomization.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__42_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__42_1");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__77_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__77_2");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__77_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__77_3");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__77_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__77_4");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__78_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__78_1");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__78_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__78_2");
				CharacterCustomization.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666176);
				CharacterCustomization.__c.NativeMethodInfoPtr__InitializeMeshes_b__42_1_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666177);
				CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_2_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666178);
				CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_3_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666179);
				CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_4_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666180);
				CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_1_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666181);
				CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_2_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666182);
			}

			// Token: 0x0600C064 RID: 49252 RVA: 0x002F0AF8 File Offset: 0x002EECF8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C065 RID: 49253 RVA: 0x002F0B34 File Offset: 0x002EED34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97217, XrefRangeEnd = 97223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeMeshes_b__42_1(Transform f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__InitializeMeshes_b__42_1_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C066 RID: 49254 RVA: 0x002F0B84 File Offset: 0x002EED84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97223, XrefRangeEnd = 97227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BakeCharacter_b__77_2(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_2_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C067 RID: 49255 RVA: 0x002F0BC8 File Offset: 0x002EEDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97227, XrefRangeEnd = 97230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BakeCharacter_b__77_3(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_3_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C068 RID: 49256 RVA: 0x002F0C0C File Offset: 0x002EEE0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BakeCharacter_b__77_4(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_4_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C069 RID: 49257 RVA: 0x002F0C50 File Offset: 0x002EEE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97230, XrefRangeEnd = 97237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClearBake_b__78_1(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_1_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C06A RID: 49258 RVA: 0x002F0C94 File Offset: 0x002EEE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97237, XrefRangeEnd = 97244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClearBake_b__78_2(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_2_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C06B RID: 49259 RVA: 0x0005DFAC File Offset: 0x0005C1AC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BEA RID: 15338
			// (get) Token: 0x0600C06C RID: 49260 RVA: 0x002F0CD8 File Offset: 0x002EEED8
			// (set) Token: 0x0600C06D RID: 49261 RVA: 0x0005DFB5 File Offset: 0x0005C1B5
			public unsafe static CharacterCustomization.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEB RID: 15339
			// (get) Token: 0x0600C06E RID: 49262 RVA: 0x002F0D00 File Offset: 0x002EEF00
			// (set) Token: 0x0600C06F RID: 49263 RVA: 0x0005DFC7 File Offset: 0x0005C1C7
			public unsafe static Func<Transform, bool> __9__42_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__42_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__42_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEC RID: 15340
			// (get) Token: 0x0600C070 RID: 49264 RVA: 0x002F0D28 File Offset: 0x002EEF28
			// (set) Token: 0x0600C071 RID: 49265 RVA: 0x0005DFD9 File Offset: 0x0005C1D9
			public unsafe static Action<SkinnedMeshRenderer> __9__77_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BED RID: 15341
			// (get) Token: 0x0600C072 RID: 49266 RVA: 0x002F0D50 File Offset: 0x002EEF50
			// (set) Token: 0x0600C073 RID: 49267 RVA: 0x0005DFEB File Offset: 0x0005C1EB
			public unsafe static Action<SkinnedMeshRenderer> __9__77_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEE RID: 15342
			// (get) Token: 0x0600C074 RID: 49268 RVA: 0x002F0D78 File Offset: 0x002EEF78
			// (set) Token: 0x0600C075 RID: 49269 RVA: 0x0005DFFD File Offset: 0x0005C1FD
			public unsafe static Action<SkinnedMeshRenderer> __9__77_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEF RID: 15343
			// (get) Token: 0x0600C076 RID: 49270 RVA: 0x002F0DA0 File Offset: 0x002EEFA0
			// (set) Token: 0x0600C077 RID: 49271 RVA: 0x0005E00F File Offset: 0x0005C20F
			public unsafe static Action<SkinnedMeshRenderer> __9__78_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF0 RID: 15344
			// (get) Token: 0x0600C078 RID: 49272 RVA: 0x002F0DC8 File Offset: 0x002EEFC8
			// (set) Token: 0x0600C079 RID: 49273 RVA: 0x0005E021 File Offset: 0x0005C221
			public unsafe static Action<SkinnedMeshRenderer> __9__78_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400825C RID: 33372
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400825D RID: 33373
			private static readonly IntPtr NativeFieldInfoPtr___9__42_1;

			// Token: 0x0400825E RID: 33374
			private static readonly IntPtr NativeFieldInfoPtr___9__77_2;

			// Token: 0x0400825F RID: 33375
			private static readonly IntPtr NativeFieldInfoPtr___9__77_3;

			// Token: 0x04008260 RID: 33376
			private static readonly IntPtr NativeFieldInfoPtr___9__77_4;

			// Token: 0x04008261 RID: 33377
			private static readonly IntPtr NativeFieldInfoPtr___9__78_1;

			// Token: 0x04008262 RID: 33378
			private static readonly IntPtr NativeFieldInfoPtr___9__78_2;

			// Token: 0x04008263 RID: 33379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008264 RID: 33380
			private static readonly IntPtr NativeMethodInfoPtr__InitializeMeshes_b__42_1_Internal_Boolean_Transform_0;

			// Token: 0x04008265 RID: 33381
			private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_2_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008266 RID: 33382
			private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_3_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008267 RID: 33383
			private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_4_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008268 RID: 33384
			private static readonly IntPtr NativeMethodInfoPtr__ClearBake_b__78_1_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008269 RID: 33385
			private static readonly IntPtr NativeMethodInfoPtr__ClearBake_b__78_2_Internal_Void_SkinnedMeshRenderer_0;
		}

		// Token: 0x0200085A RID: 2138
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C07A RID: 49274 RVA: 0x002F0DF0 File Offset: 0x002EEFF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr);
				CharacterCustomization.__c__DisplayClass42_0.NativeFieldInfoPtr_objType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, "objType");
				CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, 100666183);
				CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__0_Internal_Boolean_CharacterPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, 100666184);
				CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__2_Internal_Boolean_ClothesAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, 100666185);
			}

			// Token: 0x0600C07B RID: 49275 RVA: 0x002F0E6C File Offset: 0x002EF06C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C07C RID: 49276 RVA: 0x002F0EA8 File Offset: 0x002EF0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97244, XrefRangeEnd = 97246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeMeshes_b__0(CharacterPart f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__0_Internal_Boolean_CharacterPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C07D RID: 49277 RVA: 0x002F0EF8 File Offset: 0x002EF0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97246, XrefRangeEnd = 97252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeMeshes_b__2(ClothesAnchor f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__2_Internal_Boolean_ClothesAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C07E RID: 49278 RVA: 0x0005E033 File Offset: 0x0005C233
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF1 RID: 15345
			// (get) Token: 0x0600C07F RID: 49279 RVA: 0x002F0F48 File Offset: 0x002EF148
			// (set) Token: 0x0600C080 RID: 49280 RVA: 0x0005E03C File Offset: 0x0005C23C
			public unsafe string objType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass42_0.NativeFieldInfoPtr_objType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass42_0.NativeFieldInfoPtr_objType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400826A RID: 33386
			private static readonly IntPtr NativeFieldInfoPtr_objType;

			// Token: 0x0400826B RID: 33387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400826C RID: 33388
			private static readonly IntPtr NativeMethodInfoPtr__InitializeMeshes_b__0_Internal_Boolean_CharacterPart_0;

			// Token: 0x0400826D RID: 33389
			private static readonly IntPtr NativeMethodInfoPtr__InitializeMeshes_b__2_Internal_Boolean_ClothesAnchor_0;
		}

		// Token: 0x0200085B RID: 2139
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C081 RID: 49281 RVA: 0x002F0F70 File Offset: 0x002EF170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr);
				CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, "mesh");
				CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, 100666186);
				CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, 100666187);
			}

			// Token: 0x0600C082 RID: 49282 RVA: 0x002F0FEC File Offset: 0x002EF1EC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C083 RID: 49283 RVA: 0x002F1028 File Offset: 0x002EF228
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97274, RefRangeEnd = 97276, XrefRangeStart = 97269, XrefRangeEnd = 97274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C084 RID: 49284 RVA: 0x0005E05B File Offset: 0x0005C25B
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF2 RID: 15346
			// (get) Token: 0x0600C085 RID: 49285 RVA: 0x002F1068 File Offset: 0x002EF268
			// (set) Token: 0x0600C086 RID: 49286 RVA: 0x0005E064 File Offset: 0x0005C264
			public unsafe SkinnedMeshRenderer mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr_mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF3 RID: 15347
			// (get) Token: 0x0600C087 RID: 49287 RVA: 0x002F1098 File Offset: 0x002EF298
			// (set) Token: 0x0600C088 RID: 49288 RVA: 0x0005E083 File Offset: 0x0005C283
			public unsafe CharacterCustomization __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400826E RID: 33390
			private static readonly IntPtr NativeFieldInfoPtr_mesh;

			// Token: 0x0400826F RID: 33391
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008270 RID: 33392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008271 RID: 33393
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C2B RID: 3115
			[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass43_0+<<UpdateSkinnedMeshesOffscreenBounds>g__UpdateBounds|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E106 RID: 57606 RVA: 0x0034E760 File Offset: 0x0034C960
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, "<<UpdateSkinnedMeshesOffscreenBounds>g__UpdateBounds|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666188);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666189);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666190);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666191);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666192);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666193);
				}

				// Token: 0x0600E107 RID: 57607 RVA: 0x0034E840 File Offset: 0x0034CA40
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E108 RID: 57608 RVA: 0x0034E888 File Offset: 0x0034CA88
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E109 RID: 57609 RVA: 0x0034E8BC File Offset: 0x0034CABC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97252, XrefRangeEnd = 97264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045BB RID: 17851
				// (get) Token: 0x0600E10A RID: 57610 RVA: 0x0034E8F8 File Offset: 0x0034CAF8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E10B RID: 57611 RVA: 0x0034E938 File Offset: 0x0034CB38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97264, XrefRangeEnd = 97269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045BC RID: 17852
				// (get) Token: 0x0600E10C RID: 57612 RVA: 0x0034E96C File Offset: 0x0034CB6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E10D RID: 57613 RVA: 0x0006DB9B File Offset: 0x0006BD9B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045B8 RID: 17848
				// (get) Token: 0x0600E10E RID: 57614 RVA: 0x0034E9AC File Offset: 0x0034CBAC
				// (set) Token: 0x0600E10F RID: 57615 RVA: 0x0006DBA4 File Offset: 0x0006BDA4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045B9 RID: 17849
				// (get) Token: 0x0600E110 RID: 57616 RVA: 0x0034E9D4 File Offset: 0x0034CBD4
				// (set) Token: 0x0600E111 RID: 57617 RVA: 0x0006DBBF File Offset: 0x0006BDBF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045BA RID: 17850
				// (get) Token: 0x0600E112 RID: 57618 RVA: 0x0034EA04 File Offset: 0x0034CC04
				// (set) Token: 0x0600E113 RID: 57619 RVA: 0x0006DBDE File Offset: 0x0006BDDE
				public unsafe CharacterCustomization.__c__DisplayClass43_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization.__c__DisplayClass43_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096B0 RID: 38576
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096B1 RID: 38577
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096B2 RID: 38578
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096B3 RID: 38579
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096B4 RID: 38580
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096B5 RID: 38581
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096B6 RID: 38582
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096B7 RID: 38583
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096B8 RID: 38584
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200085C RID: 2140
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C089 RID: 49289 RVA: 0x002F10C8 File Offset: 0x002EF2C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr);
				CharacterCustomization.__c__DisplayClass83_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr, "name");
				CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr, 100666194);
				CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__GetElementsPreset_b__0_Internal_Boolean_CharacterElementsPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr, 100666195);
			}

			// Token: 0x0600C08A RID: 49290 RVA: 0x002F1130 File Offset: 0x002EF330
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C08B RID: 49291 RVA: 0x002F116C File Offset: 0x002EF36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetElementsPreset_b__0(CharacterElementsPreset f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__GetElementsPreset_b__0_Internal_Boolean_CharacterElementsPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C08C RID: 49292 RVA: 0x0005E0A2 File Offset: 0x0005C2A2
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF4 RID: 15348
			// (get) Token: 0x0600C08D RID: 49293 RVA: 0x002F11BC File Offset: 0x002EF3BC
			// (set) Token: 0x0600C08E RID: 49294 RVA: 0x0005E0AB File Offset: 0x0005C2AB
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass83_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass83_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008272 RID: 33394
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008273 RID: 33395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008274 RID: 33396
			private static readonly IntPtr NativeMethodInfoPtr__GetElementsPreset_b__0_Internal_Boolean_CharacterElementsPreset_0;
		}
	}
}
