using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F9 RID: 1785
	public class CharacterCustomizationUI : MonoBehaviour
	{
		// Token: 0x0600A025 RID: 40997 RVA: 0x002856B0 File Offset: 0x002838B0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationUI()
		{
			Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr);
			CharacterCustomizationUI.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCustomizationUI.NativeFieldInfoPtr__ActiveCategory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<ActiveCategory>k__BackingField");
			CharacterCustomizationUI.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "Title");
			CharacterCustomizationUI.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "Categories");
			CharacterCustomizationUI.NativeFieldInfoPtr_LoadAvatarSettingsNaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "LoadAvatarSettingsNaked");
			CharacterCustomizationUI.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "Canvas");
			CharacterCustomizationUI.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "MainContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "MenuContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "TitleText");
			CharacterCustomizationUI.NativeFieldInfoPtr_ButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "ButtonContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_ExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "ExitButton");
			CharacterCustomizationUI.NativeFieldInfoPtr_RigRotationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "RigRotationSlider");
			CharacterCustomizationUI.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "CameraPosition");
			CharacterCustomizationUI.NativeFieldInfoPtr_RigContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "RigContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_AvatarRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "AvatarRig");
			CharacterCustomizationUI.NativeFieldInfoPtr_PreviewIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "PreviewIndicator");
			CharacterCustomizationUI.NativeFieldInfoPtr_CategoryButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "CategoryButtonPrefab");
			CharacterCustomizationUI.NativeFieldInfoPtr_rigTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "rigTargetY");
			CharacterCustomizationUI.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "openCloseRoutine");
			CharacterCustomizationUI.NativeFieldInfoPtr_currentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "currentSettings");
			CharacterCustomizationUI.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682884);
			CharacterCustomizationUI.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682885);
			CharacterCustomizationUI.NativeMethodInfoPtr_get_ActiveCategory_Public_get_CharacterCustomizationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682886);
			CharacterCustomizationUI.NativeMethodInfoPtr_set_ActiveCategory_Private_set_Void_CharacterCustomizationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682887);
			CharacterCustomizationUI.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682888);
			CharacterCustomizationUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682889);
			CharacterCustomizationUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682890);
			CharacterCustomizationUI.NativeMethodInfoPtr_SetActiveCategory_Public_Void_CharacterCustomizationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682891);
			CharacterCustomizationUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_New_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682892);
			CharacterCustomizationUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_New_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682893);
			CharacterCustomizationUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_New_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682894);
			CharacterCustomizationUI.NativeMethodInfoPtr_OptionPurchased_Public_Virtual_New_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682895);
			CharacterCustomizationUI.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682896);
			CharacterCustomizationUI.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682897);
			CharacterCustomizationUI.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682898);
			CharacterCustomizationUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682899);
			CharacterCustomizationUI.NativeMethodInfoPtr__Awake_b__27_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682900);
			CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682901);
			CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100682902);
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x002859EC File Offset: 0x00283BEC
		// (set) Token: 0x0600A027 RID: 40999 RVA: 0x00285A28 File Offset: 0x00283C28
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600A028 RID: 41000 RVA: 0x00285A68 File Offset: 0x00283C68
		// (set) Token: 0x0600A029 RID: 41001 RVA: 0x00285AA8 File Offset: 0x00283CA8
		public unsafe CharacterCustomizationCategory ActiveCategory
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_get_ActiveCategory_Public_get_CharacterCustomizationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_set_ActiveCategory_Private_set_Void_CharacterCustomizationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A02A RID: 41002 RVA: 0x00285AEC File Offset: 0x00283CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282038, XrefRangeEnd = 282043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x00285B20 File Offset: 0x00283D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282043, XrefRangeEnd = 282101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x00285B54 File Offset: 0x00283D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282101, XrefRangeEnd = 282105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x00285B90 File Offset: 0x00283D90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 282122, RefRangeEnd = 282127, XrefRangeStart = 282105, XrefRangeEnd = 282122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveCategory(CharacterCustomizationCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(category);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_SetActiveCategory_Public_Void_CharacterCustomizationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x00285BD4 File Offset: 0x00283DD4
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_New_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x00285C2C File Offset: 0x00283E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282127, XrefRangeEnd = 282130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_New_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x00285C7C File Offset: 0x00283E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282130, XrefRangeEnd = 282138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_New_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x00285CCC File Offset: 0x00283ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282138, XrefRangeEnd = 282141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OptionPurchased_Public_Virtual_New_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x00285D1C File Offset: 0x00283F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282178, RefRangeEnd = 282179, XrefRangeStart = 282141, XrefRangeEnd = 282178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x00285D58 File Offset: 0x00283F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282179, XrefRangeEnd = 282183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x00285D9C File Offset: 0x00283F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282183, XrefRangeEnd = 282199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x00285DD8 File Offset: 0x00283FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282199, XrefRangeEnd = 282204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x00285E14 File Offset: 0x00284014
		[CallerCount(0)]
		public unsafe void _Awake_b__27_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr__Awake_b__27_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x00285E54 File Offset: 0x00284054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282204, XrefRangeEnd = 282209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x00285E94 File Offset: 0x00284094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282209, XrefRangeEnd = 282214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x0004EBCE File Offset: 0x0004CDCE
		public CharacterCustomizationUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600A03A RID: 41018 RVA: 0x00285ED4 File Offset: 0x002840D4
		// (set) Token: 0x0600A03B RID: 41019 RVA: 0x0004EBD7 File Offset: 0x0004CDD7
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600A03C RID: 41020 RVA: 0x00285EFC File Offset: 0x002840FC
		// (set) Token: 0x0600A03D RID: 41021 RVA: 0x0004EBF2 File Offset: 0x0004CDF2
		public unsafe CharacterCustomizationCategory _ActiveCategory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__ActiveCategory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__ActiveCategory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600A03E RID: 41022 RVA: 0x00285F2C File Offset: 0x0028412C
		// (set) Token: 0x0600A03F RID: 41023 RVA: 0x0004EC11 File Offset: 0x0004CE11
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600A040 RID: 41024 RVA: 0x00285F54 File Offset: 0x00284154
		// (set) Token: 0x0600A041 RID: 41025 RVA: 0x0004EC30 File Offset: 0x0004CE30
		public unsafe Il2CppReferenceArray<CharacterCustomizationCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCustomizationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600A042 RID: 41026 RVA: 0x00285F84 File Offset: 0x00284184
		// (set) Token: 0x0600A043 RID: 41027 RVA: 0x0004EC4F File Offset: 0x0004CE4F
		public unsafe bool LoadAvatarSettingsNaked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_LoadAvatarSettingsNaked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_LoadAvatarSettingsNaked)) = value;
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600A044 RID: 41028 RVA: 0x00285FAC File Offset: 0x002841AC
		// (set) Token: 0x0600A045 RID: 41029 RVA: 0x0004EC6A File Offset: 0x0004CE6A
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600A046 RID: 41030 RVA: 0x00285FDC File Offset: 0x002841DC
		// (set) Token: 0x0600A047 RID: 41031 RVA: 0x0004EC89 File Offset: 0x0004CE89
		public unsafe RectTransform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600A048 RID: 41032 RVA: 0x0028600C File Offset: 0x0028420C
		// (set) Token: 0x0600A049 RID: 41033 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
		public unsafe RectTransform MenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600A04A RID: 41034 RVA: 0x0028603C File Offset: 0x0028423C
		// (set) Token: 0x0600A04B RID: 41035 RVA: 0x0004ECC7 File Offset: 0x0004CEC7
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x0028606C File Offset: 0x0028426C
		// (set) Token: 0x0600A04D RID: 41037 RVA: 0x0004ECE6 File Offset: 0x0004CEE6
		public unsafe RectTransform ButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600A04E RID: 41038 RVA: 0x0028609C File Offset: 0x0028429C
		// (set) Token: 0x0600A04F RID: 41039 RVA: 0x0004ED05 File Offset: 0x0004CF05
		public unsafe Button ExitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ExitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ExitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600A050 RID: 41040 RVA: 0x002860CC File Offset: 0x002842CC
		// (set) Token: 0x0600A051 RID: 41041 RVA: 0x0004ED24 File Offset: 0x0004CF24
		public unsafe Slider RigRotationSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_RigRotationSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_RigRotationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x002860FC File Offset: 0x002842FC
		// (set) Token: 0x0600A053 RID: 41043 RVA: 0x0004ED43 File Offset: 0x0004CF43
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600A054 RID: 41044 RVA: 0x0028612C File Offset: 0x0028432C
		// (set) Token: 0x0600A055 RID: 41045 RVA: 0x0004ED62 File Offset: 0x0004CF62
		public unsafe Transform RigContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_RigContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_RigContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600A056 RID: 41046 RVA: 0x0028615C File Offset: 0x0028435C
		// (set) Token: 0x0600A057 RID: 41047 RVA: 0x0004ED81 File Offset: 0x0004CF81
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar AvatarRig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_AvatarRig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_AvatarRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600A058 RID: 41048 RVA: 0x0028618C File Offset: 0x0028438C
		// (set) Token: 0x0600A059 RID: 41049 RVA: 0x0004EDA0 File Offset: 0x0004CFA0
		public unsafe RectTransform PreviewIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_PreviewIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_PreviewIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600A05A RID: 41050 RVA: 0x002861BC File Offset: 0x002843BC
		// (set) Token: 0x0600A05B RID: 41051 RVA: 0x0004EDBF File Offset: 0x0004CFBF
		public unsafe Button CategoryButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CategoryButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CategoryButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600A05C RID: 41052 RVA: 0x002861EC File Offset: 0x002843EC
		// (set) Token: 0x0600A05D RID: 41053 RVA: 0x0004EDDE File Offset: 0x0004CFDE
		public unsafe float rigTargetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_rigTargetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_rigTargetY)) = value;
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600A05E RID: 41054 RVA: 0x00286214 File Offset: 0x00284414
		// (set) Token: 0x0600A05F RID: 41055 RVA: 0x0004EDF9 File Offset: 0x0004CFF9
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_openCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600A060 RID: 41056 RVA: 0x00286244 File Offset: 0x00284444
		// (set) Token: 0x0600A061 RID: 41057 RVA: 0x0004EE18 File Offset: 0x0004D018
		public unsafe BasicAvatarSettings currentSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_currentSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_currentSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B62 RID: 27490
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006B63 RID: 27491
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCategory_k__BackingField;

		// Token: 0x04006B64 RID: 27492
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04006B65 RID: 27493
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04006B66 RID: 27494
		private static readonly IntPtr NativeFieldInfoPtr_LoadAvatarSettingsNaked;

		// Token: 0x04006B67 RID: 27495
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006B68 RID: 27496
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04006B69 RID: 27497
		private static readonly IntPtr NativeFieldInfoPtr_MenuContainer;

		// Token: 0x04006B6A RID: 27498
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04006B6B RID: 27499
		private static readonly IntPtr NativeFieldInfoPtr_ButtonContainer;

		// Token: 0x04006B6C RID: 27500
		private static readonly IntPtr NativeFieldInfoPtr_ExitButton;

		// Token: 0x04006B6D RID: 27501
		private static readonly IntPtr NativeFieldInfoPtr_RigRotationSlider;

		// Token: 0x04006B6E RID: 27502
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04006B6F RID: 27503
		private static readonly IntPtr NativeFieldInfoPtr_RigContainer;

		// Token: 0x04006B70 RID: 27504
		private static readonly IntPtr NativeFieldInfoPtr_AvatarRig;

		// Token: 0x04006B71 RID: 27505
		private static readonly IntPtr NativeFieldInfoPtr_PreviewIndicator;

		// Token: 0x04006B72 RID: 27506
		private static readonly IntPtr NativeFieldInfoPtr_CategoryButtonPrefab;

		// Token: 0x04006B73 RID: 27507
		private static readonly IntPtr NativeFieldInfoPtr_rigTargetY;

		// Token: 0x04006B74 RID: 27508
		private static readonly IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x04006B75 RID: 27509
		private static readonly IntPtr NativeFieldInfoPtr_currentSettings;

		// Token: 0x04006B76 RID: 27510
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006B77 RID: 27511
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006B78 RID: 27512
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCategory_Public_get_CharacterCustomizationCategory_0;

		// Token: 0x04006B79 RID: 27513
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCategory_Private_set_Void_CharacterCustomizationCategory_0;

		// Token: 0x04006B7A RID: 27514
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006B7B RID: 27515
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006B7C RID: 27516
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006B7D RID: 27517
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveCategory_Public_Void_CharacterCustomizationCategory_0;

		// Token: 0x04006B7E RID: 27518
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_New_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04006B7F RID: 27519
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_New_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B80 RID: 27520
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Public_Virtual_New_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B81 RID: 27521
		private static readonly IntPtr NativeMethodInfoPtr_OptionPurchased_Public_Virtual_New_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B82 RID: 27522
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x04006B83 RID: 27523
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006B84 RID: 27524
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_0;

		// Token: 0x04006B85 RID: 27525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006B86 RID: 27526
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__27_0_Private_Void_Single_0;

		// Token: 0x04006B87 RID: 27527
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006B88 RID: 27528
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000BA7 RID: 2983
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI+<<Close>g__Close|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCB0 RID: 56496 RVA: 0x003428DC File Offset: 0x00340ADC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<<Close>g__Close|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100682903);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100682904);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100682905);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100682906);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100682907);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100682908);
			}

			// Token: 0x0600DCB1 RID: 56497 RVA: 0x003429BC File Offset: 0x00340BBC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCB2 RID: 56498 RVA: 0x00342A04 File Offset: 0x00340C04
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCB3 RID: 56499 RVA: 0x00342A38 File Offset: 0x00340C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281956, XrefRangeEnd = 281971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700446A RID: 17514
			// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x00342A74 File Offset: 0x00340C74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCB5 RID: 56501 RVA: 0x00342AB4 File Offset: 0x00340CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281971, XrefRangeEnd = 281976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700446B RID: 17515
			// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x00342AE8 File Offset: 0x00340CE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCB7 RID: 56503 RVA: 0x0006B8B3 File Offset: 0x00069AB3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004467 RID: 17511
			// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x00342B28 File Offset: 0x00340D28
			// (set) Token: 0x0600DCB9 RID: 56505 RVA: 0x0006B8BC File Offset: 0x00069ABC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004468 RID: 17512
			// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x00342B50 File Offset: 0x00340D50
			// (set) Token: 0x0600DCBB RID: 56507 RVA: 0x0006B8D7 File Offset: 0x00069AD7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004469 RID: 17513
			// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x00342B80 File Offset: 0x00340D80
			// (set) Token: 0x0600DCBD RID: 56509 RVA: 0x0006B8F6 File Offset: 0x00069AF6
			public unsafe CharacterCustomizationUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093E6 RID: 37862
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093E7 RID: 37863
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093E8 RID: 37864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093E9 RID: 37865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093EA RID: 37866
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093EB RID: 37867
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093EC RID: 37868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093ED RID: 37869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093EE RID: 37870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA8 RID: 2984
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI+<<Open>g__Close|34_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600DCBE RID: 56510 RVA: 0x00342BB0 File Offset: 0x00340DB0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<<Open>g__Close|34_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100682909);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100682910);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100682911);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100682912);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100682913);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100682914);
			}

			// Token: 0x0600DCBF RID: 56511 RVA: 0x00342C90 File Offset: 0x00340E90
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCC0 RID: 56512 RVA: 0x00342CD8 File Offset: 0x00340ED8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCC1 RID: 56513 RVA: 0x00342D0C File Offset: 0x00340F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281976, XrefRangeEnd = 282031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700446F RID: 17519
			// (get) Token: 0x0600DCC2 RID: 56514 RVA: 0x00342D48 File Offset: 0x00340F48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCC3 RID: 56515 RVA: 0x00342D88 File Offset: 0x00340F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282031, XrefRangeEnd = 282036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004470 RID: 17520
			// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x00342DBC File Offset: 0x00340FBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCC5 RID: 56517 RVA: 0x0006B915 File Offset: 0x00069B15
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700446C RID: 17516
			// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x00342DFC File Offset: 0x00340FFC
			// (set) Token: 0x0600DCC7 RID: 56519 RVA: 0x0006B91E File Offset: 0x00069B1E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700446D RID: 17517
			// (get) Token: 0x0600DCC8 RID: 56520 RVA: 0x00342E24 File Offset: 0x00341024
			// (set) Token: 0x0600DCC9 RID: 56521 RVA: 0x0006B939 File Offset: 0x00069B39
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446E RID: 17518
			// (get) Token: 0x0600DCCA RID: 56522 RVA: 0x00342E54 File Offset: 0x00341054
			// (set) Token: 0x0600DCCB RID: 56523 RVA: 0x0006B958 File Offset: 0x00069B58
			public unsafe CharacterCustomizationUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093EF RID: 37871
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093F0 RID: 37872
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093F1 RID: 37873
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093F2 RID: 37874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093F3 RID: 37875
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093F4 RID: 37876
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093F5 RID: 37877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093F6 RID: 37878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093F7 RID: 37879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA9 RID: 2985
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCCC RID: 56524 RVA: 0x00342E84 File Offset: 0x00341084
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr);
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, "category");
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, 100682915);
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, 100682916);
			}

			// Token: 0x0600DCCD RID: 56525 RVA: 0x00342F00 File Offset: 0x00341100
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCCE RID: 56526 RVA: 0x00342F3C File Offset: 0x0034113C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282036, XrefRangeEnd = 282038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCCF RID: 56527 RVA: 0x0006B977 File Offset: 0x00069B77
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004471 RID: 17521
			// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x00342F70 File Offset: 0x00341170
			// (set) Token: 0x0600DCD1 RID: 56529 RVA: 0x0006B980 File Offset: 0x00069B80
			public unsafe CharacterCustomizationCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr_category);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr_category), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004472 RID: 17522
			// (get) Token: 0x0600DCD2 RID: 56530 RVA: 0x00342FA0 File Offset: 0x003411A0
			// (set) Token: 0x0600DCD3 RID: 56531 RVA: 0x0006B99F File Offset: 0x00069B9F
			public unsafe CharacterCustomizationUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093F8 RID: 37880
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x040093F9 RID: 37881
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093FA RID: 37882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093FB RID: 37883
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;
		}
	}
}
