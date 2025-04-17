using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000108 RID: 264
	public class ProfileGroupDefinition : Il2CppSystem.Object
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x000AF8E0 File Offset: 0x000ADAE0
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileGroupDefinition()
		{
			Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileGroupDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr);
			ProfileGroupDefinition.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "type");
			ProfileGroupDefinition.NativeFieldInfoPtr_formatStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "formatStyle");
			ProfileGroupDefinition.NativeFieldInfoPtr_rebuildType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "rebuildType");
			ProfileGroupDefinition.NativeFieldInfoPtr_propertyKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "propertyKey");
			ProfileGroupDefinition.NativeFieldInfoPtr_groupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "groupName");
			ProfileGroupDefinition.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "color");
			ProfileGroupDefinition.NativeFieldInfoPtr_spherePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "spherePoint");
			ProfileGroupDefinition.NativeFieldInfoPtr_minimumValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "minimumValue");
			ProfileGroupDefinition.NativeFieldInfoPtr_maximumValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "maximumValue");
			ProfileGroupDefinition.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "value");
			ProfileGroupDefinition.NativeFieldInfoPtr_boolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "boolValue");
			ProfileGroupDefinition.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "texture");
			ProfileGroupDefinition.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "tooltip");
			ProfileGroupDefinition.NativeFieldInfoPtr_dependsOnFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "dependsOnFeature");
			ProfileGroupDefinition.NativeFieldInfoPtr_dependsOnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, "dependsOnValue");
			ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665540);
			ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665541);
			ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_RebuildType_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665542);
			ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_RebuildType_FormatStyle_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665543);
			ProfileGroupDefinition.NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665544);
			ProfileGroupDefinition.NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665545);
			ProfileGroupDefinition.NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_RebuildType_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665546);
			ProfileGroupDefinition.NativeMethodInfoPtr_SpherePointGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665547);
			ProfileGroupDefinition.NativeMethodInfoPtr_SpherePointGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_RebuildType_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665548);
			ProfileGroupDefinition.NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665549);
			ProfileGroupDefinition.NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665550);
			ProfileGroupDefinition.NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_RebuildType_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665551);
			ProfileGroupDefinition.NativeMethodInfoPtr_BoolGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Boolean_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665552);
			ProfileGroupDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr, 100665553);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000AFB54 File Offset: 0x000ADD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90387, XrefRangeEnd = 90388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000AFBE8 File Offset: 0x000ADDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90388, XrefRangeEnd = 90389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000AFC9C File Offset: 0x000ADE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90389, XrefRangeEnd = 90390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_RebuildType_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000AFD60 File Offset: 0x000ADF60
		[CallerCount(107)]
		[CachedScanResults(RefRangeStart = 90398, RefRangeEnd = 90505, XrefRangeStart = 90390, XrefRangeEnd = 90398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, ProfileGroupDefinition.FormatStyle formatStyle, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatStyle;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_RebuildType_FormatStyle_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000AFE34 File Offset: 0x000AE034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90505, XrefRangeEnd = 90506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000AFEAC File Offset: 0x000AE0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90506, XrefRangeEnd = 90507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnFeature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000AFF44 File Offset: 0x000AE144
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 90515, RefRangeEnd = 90543, XrefRangeStart = 90507, XrefRangeEnd = 90515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_RebuildType_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x000AFFEC File Offset: 0x000AE1EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90556, RefRangeEnd = 90558, XrefRangeStart = 90543, XrefRangeEnd = 90556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontalRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalRotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_SpherePointGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000B0074 File Offset: 0x000AE274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90558, XrefRangeEnd = 90571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontalRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalRotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_SpherePointGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_RebuildType_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x000B0128 File Offset: 0x000AE328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90571, XrefRangeEnd = 90572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x000B01A4 File Offset: 0x000AE3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90572, XrefRangeEnd = 90573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000B0240 File Offset: 0x000AE440
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 90582, RefRangeEnd = 90598, XrefRangeStart = 90573, XrefRangeEnd = 90582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_RebuildType_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000B02EC File Offset: 0x000AE4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90598, XrefRangeEnd = 90606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileGroupDefinition BoolGroupDefinition(string groupName, string propKey, bool value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnKeyword);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr_BoolGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Boolean_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileGroupDefinition>(intPtr3) : null;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000B0384 File Offset: 0x000AE584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90606, XrefRangeEnd = 90607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileGroupDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileGroupDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0000BC9A File Offset: 0x00009E9A
		public ProfileGroupDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000B03C0 File Offset: 0x000AE5C0
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0000BCA3 File Offset: 0x00009EA3
		public unsafe ProfileGroupDefinition.GroupType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000B03E8 File Offset: 0x000AE5E8
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0000BCBE File Offset: 0x00009EBE
		public unsafe ProfileGroupDefinition.FormatStyle formatStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_formatStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_formatStyle)) = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000B0410 File Offset: 0x000AE610
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0000BCD9 File Offset: 0x00009ED9
		public unsafe ProfileGroupDefinition.RebuildType rebuildType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_rebuildType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_rebuildType)) = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x000B0438 File Offset: 0x000AE638
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		public unsafe string propertyKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_propertyKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_propertyKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x000B0460 File Offset: 0x000AE660
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0000BD13 File Offset: 0x00009F13
		public unsafe string groupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_groupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_groupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x000B0488 File Offset: 0x000AE688
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0000BD32 File Offset: 0x00009F32
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x000B04B0 File Offset: 0x000AE6B0
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0000BD4D File Offset: 0x00009F4D
		public unsafe SpherePoint spherePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_spherePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_spherePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x000B04E0 File Offset: 0x000AE6E0
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0000BD6C File Offset: 0x00009F6C
		public unsafe float minimumValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_minimumValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_minimumValue)) = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x000B0508 File Offset: 0x000AE708
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x0000BD87 File Offset: 0x00009F87
		public unsafe float maximumValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_maximumValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_maximumValue)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x000B0530 File Offset: 0x000AE730
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0000BDA2 File Offset: 0x00009FA2
		public unsafe float value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x000B0558 File Offset: 0x000AE758
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0000BDBD File Offset: 0x00009FBD
		public unsafe bool boolValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_boolValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_boolValue)) = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x000B0580 File Offset: 0x000AE780
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000B05B0 File Offset: 0x000AE7B0
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0000BDF7 File Offset: 0x00009FF7
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x000B05D8 File Offset: 0x000AE7D8
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0000BE16 File Offset: 0x0000A016
		public unsafe string dependsOnFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_dependsOnFeature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_dependsOnFeature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x000B0600 File Offset: 0x000AE800
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x0000BE35 File Offset: 0x0000A035
		public unsafe bool dependsOnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_dependsOnValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupDefinition.NativeFieldInfoPtr_dependsOnValue)) = value;
			}
		}

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeFieldInfoPtr_formatStyle;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr_rebuildType;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr_propertyKey;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr_groupName;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_spherePoint;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_minimumValue;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr_maximumValue;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_boolValue;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_dependsOnFeature;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_dependsOnValue;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_String_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_String_Boolean_String_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_RebuildType_String_Boolean_String_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_NumberGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_Single_RebuildType_FormatStyle_String_Boolean_String_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_String_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_String_Boolean_String_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_ColorGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Color_RebuildType_String_Boolean_String_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_SpherePointGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_String_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_SpherePointGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Single_Single_RebuildType_String_Boolean_String_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_String_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_String_Boolean_String_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_TextureGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Texture2D_RebuildType_String_Boolean_String_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_BoolGroupDefinition_Public_Static_ProfileGroupDefinition_String_String_Boolean_String_Boolean_String_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000850 RID: 2128
		[OriginalName("Assembly-CSharp.dll", "", "GroupType")]
		public enum GroupType
		{
			// Token: 0x0400823E RID: 33342
			None,
			// Token: 0x0400823F RID: 33343
			Color,
			// Token: 0x04008240 RID: 33344
			Number,
			// Token: 0x04008241 RID: 33345
			Texture,
			// Token: 0x04008242 RID: 33346
			SpherePoint,
			// Token: 0x04008243 RID: 33347
			Boolean
		}

		// Token: 0x02000851 RID: 2129
		[OriginalName("Assembly-CSharp.dll", "", "FormatStyle")]
		public enum FormatStyle
		{
			// Token: 0x04008245 RID: 33349
			None,
			// Token: 0x04008246 RID: 33350
			Integer,
			// Token: 0x04008247 RID: 33351
			Float
		}

		// Token: 0x02000852 RID: 2130
		[OriginalName("Assembly-CSharp.dll", "", "RebuildType")]
		public enum RebuildType
		{
			// Token: 0x04008249 RID: 33353
			None,
			// Token: 0x0400824A RID: 33354
			Stars
		}
	}
}
