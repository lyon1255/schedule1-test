using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000618 RID: 1560
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x060089FE RID: 35326 RVA: 0x00243100 File Offset: 0x00241300
		// Note: this type is marked as 'beforefieldinit'.
		static CustomizationManager()
		{
			Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CustomizationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr);
			CustomizationManager.NativeFieldInfoPtr_ActiveSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "ActiveSettings");
			CustomizationManager.NativeFieldInfoPtr_TemplateAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "TemplateAvatar");
			CustomizationManager.NativeFieldInfoPtr_SaveInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "SaveInputField");
			CustomizationManager.NativeFieldInfoPtr_LoadInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "LoadInputField");
			CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "OnAvatarSettingsChanged");
			CustomizationManager.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "DefaultSettings");
			CustomizationManager.NativeFieldInfoPtr_isEditingOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "isEditingOriginal");
			CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680446);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680447);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680448);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680449);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680450);
			CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680451);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680452);
			CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680453);
			CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680454);
			CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680455);
			CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680456);
			CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680457);
			CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680458);
			CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680459);
			CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680460);
			CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680461);
			CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680462);
			CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680463);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680464);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680465);
			CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680466);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680467);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680468);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680469);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680470);
			CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680471);
			CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680472);
			CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680473);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x002433EC File Offset: 0x002415EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253755, XrefRangeEnd = 253765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x00243428 File Offset: 0x00241628
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x0024346C File Offset: 0x0024166C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253765, XrefRangeEnd = 253770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x002434A0 File Offset: 0x002416A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253790, RefRangeEnd = 253793, XrefRangeStart = 253770, XrefRangeEnd = 253790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(AvatarSettings loadedSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x002434E4 File Offset: 0x002416E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253793, XrefRangeEnd = 253809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(string settingsName, bool editOriginal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(settingsName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editOriginal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x00243534 File Offset: 0x00241734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253809, XrefRangeEnd = 253816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDefaultSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x00243578 File Offset: 0x00241778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253816, XrefRangeEnd = 253842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A06 RID: 35334 RVA: 0x002435AC File Offset: 0x002417AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253842, XrefRangeEnd = 253844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenderChanged(float genderScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref genderScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x002435EC File Offset: 0x002417EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253844, XrefRangeEnd = 253846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeightChanged(float weightScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weightScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A08 RID: 35336 RVA: 0x0024362C File Offset: 0x0024182C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253846, XrefRangeEnd = 253848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HeightChanged(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A09 RID: 35337 RVA: 0x0024366C File Offset: 0x0024186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253848, XrefRangeEnd = 253852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkinColorChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A0A RID: 35338 RVA: 0x002436AC File Offset: 0x002418AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253852, XrefRangeEnd = 253862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairChanged(Accessory newHair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newHair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A0B RID: 35339 RVA: 0x002436F0 File Offset: 0x002418F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253862, XrefRangeEnd = 253864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairColorChanged(Color newCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A0C RID: 35340 RVA: 0x00243730 File Offset: 0x00241930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253864, XrefRangeEnd = 253866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyeBallTintChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x00243770 File Offset: 0x00241970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253866, XrefRangeEnd = 253868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpperEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A0E RID: 35342 RVA: 0x002437B0 File Offset: 0x002419B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253868, XrefRangeEnd = 253870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A0F RID: 35343 RVA: 0x002437F0 File Offset: 0x002419F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253870, XrefRangeEnd = 253872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowScaleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x00243830 File Offset: 0x00241A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253872, XrefRangeEnd = 253874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowThicknessChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x00243870 File Offset: 0x00241A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253874, XrefRangeEnd = 253876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingHeightChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A12 RID: 35346 RVA: 0x002438B0 File Offset: 0x00241AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253876, XrefRangeEnd = 253878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingAngleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x002438F0 File Offset: 0x00241AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253878, XrefRangeEnd = 253880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PupilDilationChanged(float dilation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dilation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x00243930 File Offset: 0x00241B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253880, XrefRangeEnd = 253895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerChanged(FaceLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x00243980 File Offset: 0x00241B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253895, XrefRangeEnd = 253903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x002439CC File Offset: 0x00241BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253903, XrefRangeEnd = 253918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerChanged(AvatarLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x00243A1C File Offset: 0x00241C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253918, XrefRangeEnd = 253926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x00243A68 File Offset: 0x00241C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253926, XrefRangeEnd = 253965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryChanged(Accessory acc, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x00243AB8 File Offset: 0x00241CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253965, XrefRangeEnd = 253978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x00243B04 File Offset: 0x00241D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253978, XrefRangeEnd = 253981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomizationManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x00041FEE File Offset: 0x000401EE
		public CustomizationManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x06008A1C RID: 35356 RVA: 0x00243B40 File Offset: 0x00241D40
		// (set) Token: 0x06008A1D RID: 35357 RVA: 0x00041FF7 File Offset: 0x000401F7
		public unsafe AvatarSettings ActiveSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x06008A1E RID: 35358 RVA: 0x00243B70 File Offset: 0x00241D70
		// (set) Token: 0x06008A1F RID: 35359 RVA: 0x00042016 File Offset: 0x00040216
		public unsafe Avatar TemplateAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x06008A20 RID: 35360 RVA: 0x00243BA0 File Offset: 0x00241DA0
		// (set) Token: 0x06008A21 RID: 35361 RVA: 0x00042035 File Offset: 0x00040235
		public unsafe TMP_InputField SaveInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x06008A22 RID: 35362 RVA: 0x00243BD0 File Offset: 0x00241DD0
		// (set) Token: 0x06008A23 RID: 35363 RVA: 0x00042054 File Offset: 0x00040254
		public unsafe TMP_InputField LoadInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x06008A24 RID: 35364 RVA: 0x00243C00 File Offset: 0x00241E00
		// (set) Token: 0x06008A25 RID: 35365 RVA: 0x00042073 File Offset: 0x00040273
		public unsafe CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomizationManager.AvatarSettingsChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x06008A26 RID: 35366 RVA: 0x00243C30 File Offset: 0x00241E30
		// (set) Token: 0x06008A27 RID: 35367 RVA: 0x00042092 File Offset: 0x00040292
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x06008A28 RID: 35368 RVA: 0x00243C60 File Offset: 0x00241E60
		// (set) Token: 0x06008A29 RID: 35369 RVA: 0x000420B1 File Offset: 0x000402B1
		public unsafe bool isEditingOriginal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal)) = value;
			}
		}

		// Token: 0x04005DA4 RID: 23972
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSettings;

		// Token: 0x04005DA5 RID: 23973
		private static readonly IntPtr NativeFieldInfoPtr_TemplateAvatar;

		// Token: 0x04005DA6 RID: 23974
		private static readonly IntPtr NativeFieldInfoPtr_SaveInputField;

		// Token: 0x04005DA7 RID: 23975
		private static readonly IntPtr NativeFieldInfoPtr_LoadInputField;

		// Token: 0x04005DA8 RID: 23976
		private static readonly IntPtr NativeFieldInfoPtr_OnAvatarSettingsChanged;

		// Token: 0x04005DA9 RID: 23977
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005DAA RID: 23978
		private static readonly IntPtr NativeFieldInfoPtr_isEditingOriginal;

		// Token: 0x04005DAB RID: 23979
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005DAC RID: 23980
		private static readonly IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_String_0;

		// Token: 0x04005DAD RID: 23981
		private static readonly IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_0;

		// Token: 0x04005DAE RID: 23982
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005DAF RID: 23983
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0;

		// Token: 0x04005DB0 RID: 23984
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0;

		// Token: 0x04005DB1 RID: 23985
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_0;

		// Token: 0x04005DB2 RID: 23986
		private static readonly IntPtr NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0;

		// Token: 0x04005DB3 RID: 23987
		private static readonly IntPtr NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0;

		// Token: 0x04005DB4 RID: 23988
		private static readonly IntPtr NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0;

		// Token: 0x04005DB5 RID: 23989
		private static readonly IntPtr NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0;

		// Token: 0x04005DB6 RID: 23990
		private static readonly IntPtr NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0;

		// Token: 0x04005DB7 RID: 23991
		private static readonly IntPtr NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0;

		// Token: 0x04005DB8 RID: 23992
		private static readonly IntPtr NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0;

		// Token: 0x04005DB9 RID: 23993
		private static readonly IntPtr NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04005DBA RID: 23994
		private static readonly IntPtr NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04005DBB RID: 23995
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0;

		// Token: 0x04005DBC RID: 23996
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0;

		// Token: 0x04005DBD RID: 23997
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0;

		// Token: 0x04005DBE RID: 23998
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0;

		// Token: 0x04005DBF RID: 23999
		private static readonly IntPtr NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0;

		// Token: 0x04005DC0 RID: 24000
		private static readonly IntPtr NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0;

		// Token: 0x04005DC1 RID: 24001
		private static readonly IntPtr NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005DC2 RID: 24002
		private static readonly IntPtr NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0;

		// Token: 0x04005DC3 RID: 24003
		private static readonly IntPtr NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005DC4 RID: 24004
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0;

		// Token: 0x04005DC5 RID: 24005
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005DC6 RID: 24006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B0F RID: 2831
		public sealed class AvatarSettingsChanged : MulticastDelegate
		{
			// Token: 0x0600D68B RID: 54923 RVA: 0x003310A0 File Offset: 0x0032F2A0
			// Note: this type is marked as 'beforefieldinit'.
			static AvatarSettingsChanged()
			{
				Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "AvatarSettingsChanged");
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680474);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680475);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680476);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680477);
			}

			// Token: 0x0600D68C RID: 54924 RVA: 0x00331114 File Offset: 0x0032F314
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 82515, XrefRangeStart = 81883, XrefRangeEnd = 82515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AvatarSettingsChanged(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D68D RID: 54925 RVA: 0x00331170 File Offset: 0x0032F370
			[CallerCount(0)]
			public unsafe void Invoke(AvatarSettings settings)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D68E RID: 54926 RVA: 0x003311B4 File Offset: 0x0032F3B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AvatarSettings settings, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D68F RID: 54927 RVA: 0x00331228 File Offset: 0x0032F428
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D690 RID: 54928 RVA: 0x00068684 File Offset: 0x00066884
			public AvatarSettingsChanged(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D691 RID: 54929 RVA: 0x0006868D File Offset: 0x0006688D
			public static implicit operator CustomizationManager.AvatarSettingsChanged(Action<AvatarSettings> A_0)
			{
				return DelegateSupport.ConvertDelegate<CustomizationManager.AvatarSettingsChanged>(A_0);
			}

			// Token: 0x0600D692 RID: 54930 RVA: 0x00068695 File Offset: 0x00066895
			public static CustomizationManager.AvatarSettingsChanged operator +(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CustomizationManager.AvatarSettingsChanged>();
			}

			// Token: 0x0600D693 RID: 54931 RVA: 0x000686A3 File Offset: 0x000668A3
			public static CustomizationManager.AvatarSettingsChanged operator -(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<CustomizationManager.AvatarSettingsChanged>();
				}
				return result;
			}

			// Token: 0x0400904C RID: 36940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400904D RID: 36941
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0;

			// Token: 0x0400904E RID: 36942
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0;

			// Token: 0x0400904F RID: 36943
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
