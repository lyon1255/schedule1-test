using System;
using Il2CppAdvancedPeopleSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000021 RID: 33
	public class UIControllerDEMO : MonoBehaviour
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00076CCC File Offset: 0x00074ECC
		// Note: this type is marked as 'beforefieldinit'.
		static UIControllerDEMO()
		{
			Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIControllerDEMO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr);
			UIControllerDEMO.NativeFieldInfoPtr_CharacterCustomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "CharacterCustomization");
			UIControllerDEMO.NativeFieldInfoPtr_playbutton_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "playbutton_text");
			UIControllerDEMO.NativeFieldInfoPtr_bake_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "bake_text");
			UIControllerDEMO.NativeFieldInfoPtr_lod_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "lod_text");
			UIControllerDEMO.NativeFieldInfoPtr_panelNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "panelNameText");
			UIControllerDEMO.NativeFieldInfoPtr_fatSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "fatSlider");
			UIControllerDEMO.NativeFieldInfoPtr_musclesSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "musclesSlider");
			UIControllerDEMO.NativeFieldInfoPtr_thinSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "thinSlider");
			UIControllerDEMO.NativeFieldInfoPtr_slimnessSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "slimnessSlider");
			UIControllerDEMO.NativeFieldInfoPtr_breastSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "breastSlider");
			UIControllerDEMO.NativeFieldInfoPtr_heightSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "heightSlider");
			UIControllerDEMO.NativeFieldInfoPtr_legSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "legSlider");
			UIControllerDEMO.NativeFieldInfoPtr_headSizeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "headSizeSlider");
			UIControllerDEMO.NativeFieldInfoPtr_headOffsetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "headOffsetSlider");
			UIControllerDEMO.NativeFieldInfoPtr_faceShapeSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "faceShapeSliders");
			UIControllerDEMO.NativeFieldInfoPtr_HairPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HairPanel");
			UIControllerDEMO.NativeFieldInfoPtr_BeardPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "BeardPanel");
			UIControllerDEMO.NativeFieldInfoPtr_ShirtPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "ShirtPanel");
			UIControllerDEMO.NativeFieldInfoPtr_PantsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "PantsPanel");
			UIControllerDEMO.NativeFieldInfoPtr_ShoesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "ShoesPanel");
			UIControllerDEMO.NativeFieldInfoPtr_HatPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HatPanel");
			UIControllerDEMO.NativeFieldInfoPtr_AccessoryPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "AccessoryPanel");
			UIControllerDEMO.NativeFieldInfoPtr_BackpackPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "BackpackPanel");
			UIControllerDEMO.NativeFieldInfoPtr_FaceEditPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "FaceEditPanel");
			UIControllerDEMO.NativeFieldInfoPtr_BaseEditPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "BaseEditPanel");
			UIControllerDEMO.NativeFieldInfoPtr_SkinColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SkinColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_EyeColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "EyeColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_HairColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HairColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "UnderpantsColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_EmotionsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "EmotionsPanel");
			UIControllerDEMO.NativeFieldInfoPtr_SavesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesPanel");
			UIControllerDEMO.NativeFieldInfoPtr_SavesPanelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesPanelList");
			UIControllerDEMO.NativeFieldInfoPtr_SavesPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesPrefab");
			UIControllerDEMO.NativeFieldInfoPtr_SavesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesList");
			UIControllerDEMO.NativeFieldInfoPtr_SkinColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SkinColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_EyeColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "EyeColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_HairColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HairColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "UnderpantsColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_CameraPositionForPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "CameraPositionForPanels");
			UIControllerDEMO.NativeFieldInfoPtr_CameraEulerForPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "CameraEulerForPanels");
			UIControllerDEMO.NativeFieldInfoPtr_currentPanelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "currentPanelIndex");
			UIControllerDEMO.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "Camera");
			UIControllerDEMO.NativeFieldInfoPtr_femaleUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "femaleUI");
			UIControllerDEMO.NativeFieldInfoPtr_maleUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "maleUI");
			UIControllerDEMO.NativeFieldInfoPtr_lodIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "lodIndex");
			UIControllerDEMO.NativeFieldInfoPtr_walk_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "walk_active");
			UIControllerDEMO.NativeFieldInfoPtr_canvasVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "canvasVisible");
			UIControllerDEMO.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663485);
			UIControllerDEMO.NativeMethodInfoPtr_ShowFaceEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663486);
			UIControllerDEMO.NativeMethodInfoPtr_ShowBaseEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663487);
			UIControllerDEMO.NativeMethodInfoPtr_SetFaceShape_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663488);
			UIControllerDEMO.NativeMethodInfoPtr_SetHeadOffset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663489);
			UIControllerDEMO.NativeMethodInfoPtr_BodyFat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663490);
			UIControllerDEMO.NativeMethodInfoPtr_BodyMuscles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663491);
			UIControllerDEMO.NativeMethodInfoPtr_BodyThin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663492);
			UIControllerDEMO.NativeMethodInfoPtr_BodySlimness_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663493);
			UIControllerDEMO.NativeMethodInfoPtr_BodyBreast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663494);
			UIControllerDEMO.NativeMethodInfoPtr_SetHeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663495);
			UIControllerDEMO.NativeMethodInfoPtr_SetHeadSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663496);
			UIControllerDEMO.NativeMethodInfoPtr_Lod_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663497);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewSkinColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663498);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewEyeColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663499);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewHairColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663500);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewUnderpantsColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663501);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleSkinColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663502);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleEyeColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663503);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleHairColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663504);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleUnderpantsColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663505);
			UIControllerDEMO.NativeMethodInfoPtr_ShirtPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663506);
			UIControllerDEMO.NativeMethodInfoPtr_PantsPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663507);
			UIControllerDEMO.NativeMethodInfoPtr_ShoesPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663508);
			UIControllerDEMO.NativeMethodInfoPtr_BackpackPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663509);
			UIControllerDEMO.NativeMethodInfoPtr_HairPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663510);
			UIControllerDEMO.NativeMethodInfoPtr_BeardPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663511);
			UIControllerDEMO.NativeMethodInfoPtr_HatPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663512);
			UIControllerDEMO.NativeMethodInfoPtr_EmotionsPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663513);
			UIControllerDEMO.NativeMethodInfoPtr_AccessoryPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663514);
			UIControllerDEMO.NativeMethodInfoPtr_SavesPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663515);
			UIControllerDEMO.NativeMethodInfoPtr_SaveSelect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663516);
			UIControllerDEMO.NativeMethodInfoPtr_EmotionsChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663517);
			UIControllerDEMO.NativeMethodInfoPtr_HairChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663518);
			UIControllerDEMO.NativeMethodInfoPtr_BeardChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663519);
			UIControllerDEMO.NativeMethodInfoPtr_ShirtChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663520);
			UIControllerDEMO.NativeMethodInfoPtr_PantsChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663521);
			UIControllerDEMO.NativeMethodInfoPtr_ShoesChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663522);
			UIControllerDEMO.NativeMethodInfoPtr_BackpackChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663523);
			UIControllerDEMO.NativeMethodInfoPtr_HatChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663524);
			UIControllerDEMO.NativeMethodInfoPtr_AccessoryChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663525);
			UIControllerDEMO.NativeMethodInfoPtr_HideAllPanels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663526);
			UIControllerDEMO.NativeMethodInfoPtr_SaveToFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663527);
			UIControllerDEMO.NativeMethodInfoPtr_ClearFromFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663528);
			UIControllerDEMO.NativeMethodInfoPtr_Randimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663529);
			UIControllerDEMO.NativeMethodInfoPtr_PlayAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663530);
			UIControllerDEMO.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663531);
			UIControllerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663532);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00077468 File Offset: 0x00075668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72374, XrefRangeEnd = 72389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchCharacterSettings(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000774AC File Offset: 0x000756AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72389, XrefRangeEnd = 72396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowFaceEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShowFaceEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000774E0 File Offset: 0x000756E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72396, XrefRangeEnd = 72403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowBaseEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShowBaseEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00077514 File Offset: 0x00075714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72403, XrefRangeEnd = 72408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceShape(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetFaceShape_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00077554 File Offset: 0x00075754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72408, XrefRangeEnd = 72409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetHeadOffset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00077588 File Offset: 0x00075788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72409, XrefRangeEnd = 72410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyFat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyFat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000775BC File Offset: 0x000757BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72410, XrefRangeEnd = 72411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyMuscles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyMuscles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000775F0 File Offset: 0x000757F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72411, XrefRangeEnd = 72412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyThin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyThin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00077624 File Offset: 0x00075824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72412, XrefRangeEnd = 72413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodySlimness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodySlimness_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00077658 File Offset: 0x00075858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72413, XrefRangeEnd = 72429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyBreast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyBreast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0007768C File Offset: 0x0007588C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72429, XrefRangeEnd = 72431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetHeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000776C0 File Offset: 0x000758C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72431, XrefRangeEnd = 72433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetHeadSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000776F4 File Offset: 0x000758F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72433, XrefRangeEnd = 72436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lod_Event(int next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref next;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_Lod_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00077734 File Offset: 0x00075934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72436, XrefRangeEnd = 72437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewSkinColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewSkinColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00077774 File Offset: 0x00075974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72437, XrefRangeEnd = 72438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewEyeColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewEyeColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000777B4 File Offset: 0x000759B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72438, XrefRangeEnd = 72439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewHairColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewHairColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000777F4 File Offset: 0x000759F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72439, XrefRangeEnd = 72440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewUnderpantsColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewUnderpantsColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00077834 File Offset: 0x00075A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72440, XrefRangeEnd = 72444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleSkinColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleSkinColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00077874 File Offset: 0x00075A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72444, XrefRangeEnd = 72448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleEyeColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleEyeColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000778B4 File Offset: 0x00075AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72448, XrefRangeEnd = 72452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleHairColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleHairColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000778F4 File Offset: 0x00075AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72452, XrefRangeEnd = 72456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleUnderpantsColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleUnderpantsColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00077934 File Offset: 0x00075B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72456, XrefRangeEnd = 72462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShirtPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShirtPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00077974 File Offset: 0x00075B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72462, XrefRangeEnd = 72468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PantsPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_PantsPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000779B4 File Offset: 0x00075BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72468, XrefRangeEnd = 72474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShoesPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShoesPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000779F4 File Offset: 0x00075BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72474, XrefRangeEnd = 72480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackpackPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BackpackPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00077A34 File Offset: 0x00075C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72480, XrefRangeEnd = 72485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HairPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00077A74 File Offset: 0x00075C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72485, XrefRangeEnd = 72490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeardPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BeardPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00077AB4 File Offset: 0x00075CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72490, XrefRangeEnd = 72495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HatPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HatPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00077AF4 File Offset: 0x00075CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72495, XrefRangeEnd = 72500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmotionsPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_EmotionsPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00077B34 File Offset: 0x00075D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72500, XrefRangeEnd = 72505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_AccessoryPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00077B74 File Offset: 0x00075D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72505, XrefRangeEnd = 72556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavesPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SavesPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00077BB4 File Offset: 0x00075DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72556, XrefRangeEnd = 72564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveSelect(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SaveSelect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00077BF4 File Offset: 0x00075DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72564, XrefRangeEnd = 72568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmotionsChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_EmotionsChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00077C34 File Offset: 0x00075E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72568, XrefRangeEnd = 72570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HairChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00077C74 File Offset: 0x00075E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72570, XrefRangeEnd = 72572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeardChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BeardChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00077CB4 File Offset: 0x00075EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72572, XrefRangeEnd = 72574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShirtChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShirtChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00077CF4 File Offset: 0x00075EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72574, XrefRangeEnd = 72576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PantsChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_PantsChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00077D34 File Offset: 0x00075F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72576, XrefRangeEnd = 72578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShoesChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShoesChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00077D74 File Offset: 0x00075F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72578, XrefRangeEnd = 72580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackpackChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BackpackChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00077DB4 File Offset: 0x00075FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72580, XrefRangeEnd = 72582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HatChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HatChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00077DF4 File Offset: 0x00075FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72582, XrefRangeEnd = 72584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_AccessoryChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00077E34 File Offset: 0x00076034
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 72619, RefRangeEnd = 72633, XrefRangeStart = 72584, XrefRangeEnd = 72619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideAllPanels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HideAllPanels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00077E68 File Offset: 0x00076068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72633, XrefRangeEnd = 72636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToFile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SaveToFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00077E9C File Offset: 0x0007609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72636, XrefRangeEnd = 72640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFromFile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ClearFromFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00077ED0 File Offset: 0x000760D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72640, XrefRangeEnd = 72642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_Randimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00077F04 File Offset: 0x00076104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72642, XrefRangeEnd = 72650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_PlayAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00077F38 File Offset: 0x00076138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72650, XrefRangeEnd = 72670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00077F6C File Offset: 0x0007616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72670, XrefRangeEnd = 72678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIControllerDEMO() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000031C0 File Offset: 0x000013C0
		public UIControllerDEMO(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00077FA8 File Offset: 0x000761A8
		// (set) Token: 0x06000238 RID: 568 RVA: 0x000031C9 File Offset: 0x000013C9
		public unsafe CharacterCustomization CharacterCustomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CharacterCustomization);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CharacterCustomization), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00077FD8 File Offset: 0x000761D8
		// (set) Token: 0x0600023A RID: 570 RVA: 0x000031E8 File Offset: 0x000013E8
		public unsafe Text playbutton_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_playbutton_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_playbutton_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00078008 File Offset: 0x00076208
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00003207 File Offset: 0x00001407
		public unsafe Text bake_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_bake_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_bake_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00078038 File Offset: 0x00076238
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00003226 File Offset: 0x00001426
		public unsafe Text lod_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lod_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lod_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00078068 File Offset: 0x00076268
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00003245 File Offset: 0x00001445
		public unsafe Text panelNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_panelNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_panelNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00078098 File Offset: 0x00076298
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003264 File Offset: 0x00001464
		public unsafe Slider fatSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_fatSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_fatSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000780C8 File Offset: 0x000762C8
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003283 File Offset: 0x00001483
		public unsafe Slider musclesSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_musclesSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_musclesSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000780F8 File Offset: 0x000762F8
		// (set) Token: 0x06000246 RID: 582 RVA: 0x000032A2 File Offset: 0x000014A2
		public unsafe Slider thinSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_thinSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_thinSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00078128 File Offset: 0x00076328
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000032C1 File Offset: 0x000014C1
		public unsafe Slider slimnessSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_slimnessSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_slimnessSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00078158 File Offset: 0x00076358
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000032E0 File Offset: 0x000014E0
		public unsafe Slider breastSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_breastSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_breastSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00078188 File Offset: 0x00076388
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000032FF File Offset: 0x000014FF
		public unsafe Slider heightSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_heightSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_heightSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000781B8 File Offset: 0x000763B8
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000331E File Offset: 0x0000151E
		public unsafe Slider legSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_legSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_legSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000781E8 File Offset: 0x000763E8
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000333D File Offset: 0x0000153D
		public unsafe Slider headSizeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headSizeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headSizeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00078218 File Offset: 0x00076418
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000335C File Offset: 0x0000155C
		public unsafe Slider headOffsetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headOffsetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headOffsetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00078248 File Offset: 0x00076448
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000337B File Offset: 0x0000157B
		public unsafe Il2CppReferenceArray<Slider> faceShapeSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_faceShapeSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Slider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_faceShapeSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00078278 File Offset: 0x00076478
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000339A File Offset: 0x0000159A
		public unsafe RectTransform HairPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000782A8 File Offset: 0x000764A8
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000033B9 File Offset: 0x000015B9
		public unsafe RectTransform BeardPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BeardPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BeardPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000782D8 File Offset: 0x000764D8
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000033D8 File Offset: 0x000015D8
		public unsafe RectTransform ShirtPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShirtPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShirtPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00078308 File Offset: 0x00076508
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000033F7 File Offset: 0x000015F7
		public unsafe RectTransform PantsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_PantsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_PantsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00078338 File Offset: 0x00076538
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003416 File Offset: 0x00001616
		public unsafe RectTransform ShoesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShoesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShoesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00078368 File Offset: 0x00076568
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003435 File Offset: 0x00001635
		public unsafe RectTransform HatPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HatPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HatPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00078398 File Offset: 0x00076598
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00003454 File Offset: 0x00001654
		public unsafe RectTransform AccessoryPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_AccessoryPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_AccessoryPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000783C8 File Offset: 0x000765C8
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00003473 File Offset: 0x00001673
		public unsafe RectTransform BackpackPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BackpackPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BackpackPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000783F8 File Offset: 0x000765F8
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00003492 File Offset: 0x00001692
		public unsafe RectTransform FaceEditPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_FaceEditPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_FaceEditPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00078428 File Offset: 0x00076628
		// (set) Token: 0x06000268 RID: 616 RVA: 0x000034B1 File Offset: 0x000016B1
		public unsafe RectTransform BaseEditPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BaseEditPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BaseEditPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00078458 File Offset: 0x00076658
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000034D0 File Offset: 0x000016D0
		public unsafe RectTransform SkinColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00078488 File Offset: 0x00076688
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000034EF File Offset: 0x000016EF
		public unsafe RectTransform EyeColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000784B8 File Offset: 0x000766B8
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000350E File Offset: 0x0000170E
		public unsafe RectTransform HairColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000784E8 File Offset: 0x000766E8
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000352D File Offset: 0x0000172D
		public unsafe RectTransform UnderpantsColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00078518 File Offset: 0x00076718
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000354C File Offset: 0x0000174C
		public unsafe RectTransform EmotionsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EmotionsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EmotionsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00078548 File Offset: 0x00076748
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000356B File Offset: 0x0000176B
		public unsafe RectTransform SavesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00078578 File Offset: 0x00076778
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000358A File Offset: 0x0000178A
		public unsafe RectTransform SavesPanelList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanelList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanelList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000785A8 File Offset: 0x000767A8
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000035A9 File Offset: 0x000017A9
		public unsafe RectTransform SavesPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000785D8 File Offset: 0x000767D8
		// (set) Token: 0x0600027A RID: 634 RVA: 0x000035C8 File Offset: 0x000017C8
		public unsafe List<RectTransform> SavesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00078608 File Offset: 0x00076808
		// (set) Token: 0x0600027C RID: 636 RVA: 0x000035E7 File Offset: 0x000017E7
		public unsafe Image SkinColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00078638 File Offset: 0x00076838
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00003606 File Offset: 0x00001806
		public unsafe Image EyeColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00078668 File Offset: 0x00076868
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00003625 File Offset: 0x00001825
		public unsafe Image HairColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00078698 File Offset: 0x00076898
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00003644 File Offset: 0x00001844
		public unsafe Image UnderpantsColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000786C8 File Offset: 0x000768C8
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00003663 File Offset: 0x00001863
		public unsafe Il2CppStructArray<Vector3> CameraPositionForPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraPositionForPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraPositionForPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000786F8 File Offset: 0x000768F8
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003682 File Offset: 0x00001882
		public unsafe Il2CppStructArray<Vector3> CameraEulerForPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraEulerForPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraEulerForPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00078728 File Offset: 0x00076928
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000036A1 File Offset: 0x000018A1
		public unsafe int currentPanelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_currentPanelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_currentPanelIndex)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00078750 File Offset: 0x00076950
		// (set) Token: 0x0600028A RID: 650 RVA: 0x000036BC File Offset: 0x000018BC
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00078780 File Offset: 0x00076980
		// (set) Token: 0x0600028C RID: 652 RVA: 0x000036DB File Offset: 0x000018DB
		public unsafe RectTransform femaleUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_femaleUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_femaleUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000787B0 File Offset: 0x000769B0
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000036FA File Offset: 0x000018FA
		public unsafe RectTransform maleUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_maleUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_maleUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000787E0 File Offset: 0x000769E0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00003719 File Offset: 0x00001919
		public unsafe int lodIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lodIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lodIndex)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00078808 File Offset: 0x00076A08
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00003734 File Offset: 0x00001934
		public unsafe bool walk_active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_walk_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_walk_active)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00078830 File Offset: 0x00076A30
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000374F File Offset: 0x0000194F
		public unsafe bool canvasVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_canvasVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_canvasVisible)) = value;
			}
		}

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_CharacterCustomization;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_playbutton_text;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_bake_text;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_lod_text;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_panelNameText;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_fatSlider;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_musclesSlider;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_thinSlider;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_slimnessSlider;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_breastSlider;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_heightSlider;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_legSlider;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_headSizeSlider;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_headOffsetSlider;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_faceShapeSliders;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_HairPanel;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_BeardPanel;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_ShirtPanel;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_PantsPanel;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_ShoesPanel;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_HatPanel;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_AccessoryPanel;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_BackpackPanel;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_FaceEditPanel;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_BaseEditPanel;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorPanel;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_EyeColorPanel;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_HairColorPanel;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_UnderpantsColorPanel;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_EmotionsPanel;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_SavesPanel;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_SavesPanelList;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_SavesPrefab;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_SavesList;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorButtonColor;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_EyeColorButtonColor;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_HairColorButtonColor;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_UnderpantsColorButtonColor;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_CameraPositionForPanels;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_CameraEulerForPanels;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_currentPanelIndex;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_femaleUI;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_maleUI;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_lodIndex;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_walk_active;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_canvasVisible;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_ShowFaceEdit_Public_Void_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_ShowBaseEdit_Public_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceShape_Public_Void_Int32_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadOffset_Public_Void_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_BodyFat_Public_Void_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_BodyMuscles_Public_Void_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_BodyThin_Public_Void_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_BodySlimness_Public_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_BodyBreast_Public_Void_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_SetHeight_Public_Void_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadSize_Public_Void_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Lod_Event_Public_Void_Int32_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_SetNewSkinColor_Public_Void_Color_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_SetNewEyeColor_Public_Void_Color_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_SetNewHairColor_Public_Void_Color_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_SetNewUnderpantsColor_Public_Void_Color_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_VisibleSkinColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_VisibleEyeColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_VisibleHairColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_VisibleUnderpantsColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_ShirtPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_PantsPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_ShoesPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_BackpackPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_HairPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_BeardPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_HatPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_EmotionsPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_SavesPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_SaveSelect_Public_Void_Int32_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_EmotionsChange_Event_Public_Void_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_HairChange_Event_Public_Void_Int32_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_BeardChange_Event_Public_Void_Int32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_ShirtChange_Event_Public_Void_Int32_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_PantsChange_Event_Public_Void_Int32_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_ShoesChange_Event_Public_Void_Int32_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_BackpackChange_Event_Public_Void_Int32_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_HatChange_Event_Public_Void_Int32_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryChange_Event_Public_Void_Int32_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_HideAllPanels_Public_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_SaveToFile_Public_Void_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromFile_Public_Void_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_Randimize_Public_Void_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Void_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007AB RID: 1963
		[ObfuscatedName("UIControllerDEMO+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B963 RID: 47459 RVA: 0x002E0698 File Offset: 0x002DE898
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr);
				UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, "index");
				UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, 100663533);
				UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__SavesPanel_Select_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, 100663534);
			}

			// Token: 0x0600B964 RID: 47460 RVA: 0x002E0714 File Offset: 0x002DE914
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B965 RID: 47461 RVA: 0x002E0750 File Offset: 0x002DE950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72338, XrefRangeEnd = 72374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SavesPanel_Select_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__SavesPanel_Select_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B966 RID: 47462 RVA: 0x0005AA2D File Offset: 0x00058C2D
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003937 RID: 14647
			// (get) Token: 0x0600B967 RID: 47463 RVA: 0x002E0784 File Offset: 0x002DE984
			// (set) Token: 0x0600B968 RID: 47464 RVA: 0x0005AA36 File Offset: 0x00058C36
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17003938 RID: 14648
			// (get) Token: 0x0600B969 RID: 47465 RVA: 0x002E07AC File Offset: 0x002DE9AC
			// (set) Token: 0x0600B96A RID: 47466 RVA: 0x0005AA51 File Offset: 0x00058C51
			public unsafe UIControllerDEMO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIControllerDEMO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D17 RID: 32023
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04007D18 RID: 32024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D19 RID: 32025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D1A RID: 32026
			private static readonly IntPtr NativeMethodInfoPtr__SavesPanel_Select_b__0_Internal_Void_0;
		}
	}
}
