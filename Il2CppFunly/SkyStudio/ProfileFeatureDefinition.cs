using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000106 RID: 262
	[Serializable]
	public class ProfileFeatureDefinition : Object
	{
		// Token: 0x0600136E RID: 4974 RVA: 0x000AE9C0 File Offset: 0x000ACBC0
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileFeatureDefinition()
		{
			Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileFeatureDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr);
			ProfileFeatureDefinition.NativeFieldInfoPtr_featureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "featureKey");
			ProfileFeatureDefinition.NativeFieldInfoPtr_featureKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "featureKeys");
			ProfileFeatureDefinition.NativeFieldInfoPtr_featureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "featureType");
			ProfileFeatureDefinition.NativeFieldInfoPtr_shaderKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "shaderKeyword");
			ProfileFeatureDefinition.NativeFieldInfoPtr_shaderKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "shaderKeywords");
			ProfileFeatureDefinition.NativeFieldInfoPtr_dropdownLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "dropdownLabels");
			ProfileFeatureDefinition.NativeFieldInfoPtr_dropdownSelectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "dropdownSelectedIndex");
			ProfileFeatureDefinition.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "name");
			ProfileFeatureDefinition.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "value");
			ProfileFeatureDefinition.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "tooltip");
			ProfileFeatureDefinition.NativeFieldInfoPtr_dependsOnFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "dependsOnFeature");
			ProfileFeatureDefinition.NativeFieldInfoPtr_dependsOnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "dependsOnValue");
			ProfileFeatureDefinition.NativeFieldInfoPtr_isShaderKeywordFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, "isShaderKeywordFeature");
			ProfileFeatureDefinition.NativeMethodInfoPtr_CreateShaderFeature_Public_Static_ProfileFeatureDefinition_String_String_Boolean_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, 100665535);
			ProfileFeatureDefinition.NativeMethodInfoPtr_CreateShaderFeatureDropdown_Public_Static_ProfileFeatureDefinition_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Int32_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, 100665536);
			ProfileFeatureDefinition.NativeMethodInfoPtr_CreateBooleanFeature_Public_Static_ProfileFeatureDefinition_String_Boolean_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, 100665537);
			ProfileFeatureDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr, 100665538);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000AEB44 File Offset: 0x000ACD44
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 90334, RefRangeEnd = 90361, XrefRangeStart = 90325, XrefRangeEnd = 90334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnFeature);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileFeatureDefinition.NativeMethodInfoPtr_CreateShaderFeature_Public_Static_ProfileFeatureDefinition_String_String_Boolean_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileFeatureDefinition>(intPtr3) : null;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000AEBF0 File Offset: 0x000ACDF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90371, RefRangeEnd = 90373, XrefRangeStart = 90361, XrefRangeEnd = 90371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileFeatureDefinition CreateShaderFeatureDropdown(Il2CppStringArray featureKeys, Il2CppStringArray shaderKeywords, Il2CppStringArray labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(featureKeys);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shaderKeywords);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(labels);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectedIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnFeature);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileFeatureDefinition.NativeMethodInfoPtr_CreateShaderFeatureDropdown_Public_Static_ProfileFeatureDefinition_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Int32_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileFeatureDefinition>(intPtr3) : null;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000AECB0 File Offset: 0x000ACEB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 90380, RefRangeEnd = 90387, XrefRangeStart = 90373, XrefRangeEnd = 90380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnFeature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileFeatureDefinition.NativeMethodInfoPtr_CreateBooleanFeature_Public_Static_ProfileFeatureDefinition_String_Boolean_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileFeatureDefinition>(intPtr3) : null;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x000AED48 File Offset: 0x000ACF48
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileFeatureDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileFeatureDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileFeatureDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0000B803 File Offset: 0x00009A03
		public ProfileFeatureDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000AED84 File Offset: 0x000ACF84
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000B80C File Offset: 0x00009A0C
		public unsafe string featureKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_featureKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_featureKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000AEDAC File Offset: 0x000ACFAC
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000B82B File Offset: 0x00009A2B
		public unsafe Il2CppStringArray featureKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_featureKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_featureKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x000AEDDC File Offset: 0x000ACFDC
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000B84A File Offset: 0x00009A4A
		public unsafe ProfileFeatureDefinition.FeatureType featureType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_featureType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_featureType)) = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000AEE04 File Offset: 0x000AD004
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0000B865 File Offset: 0x00009A65
		public unsafe string shaderKeyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_shaderKeyword);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_shaderKeyword), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000AEE2C File Offset: 0x000AD02C
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x0000B884 File Offset: 0x00009A84
		public unsafe Il2CppStringArray shaderKeywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_shaderKeywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_shaderKeywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x000AEE5C File Offset: 0x000AD05C
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x0000B8A3 File Offset: 0x00009AA3
		public unsafe Il2CppStringArray dropdownLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dropdownLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dropdownLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x000AEE8C File Offset: 0x000AD08C
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x0000B8C2 File Offset: 0x00009AC2
		public unsafe int dropdownSelectedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dropdownSelectedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dropdownSelectedIndex)) = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x000AEEB4 File Offset: 0x000AD0B4
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000B8DD File Offset: 0x00009ADD
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000AEEDC File Offset: 0x000AD0DC
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x0000B8FC File Offset: 0x00009AFC
		public unsafe bool value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x000AEF04 File Offset: 0x000AD104
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x0000B917 File Offset: 0x00009B17
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000AEF2C File Offset: 0x000AD12C
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x0000B936 File Offset: 0x00009B36
		public unsafe string dependsOnFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dependsOnFeature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dependsOnFeature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000AEF54 File Offset: 0x000AD154
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x0000B955 File Offset: 0x00009B55
		public unsafe bool dependsOnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dependsOnValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_dependsOnValue)) = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x000AEF7C File Offset: 0x000AD17C
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x0000B970 File Offset: 0x00009B70
		public unsafe bool isShaderKeywordFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_isShaderKeywordFeature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureDefinition.NativeFieldInfoPtr_isShaderKeywordFeature)) = value;
			}
		}

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeFieldInfoPtr_featureKey;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeFieldInfoPtr_featureKeys;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_featureType;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr_shaderKeyword;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_shaderKeywords;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_dropdownLabels;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_dropdownSelectedIndex;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_dependsOnFeature;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr_dependsOnValue;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeFieldInfoPtr_isShaderKeywordFeature;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_CreateShaderFeature_Public_Static_ProfileFeatureDefinition_String_String_Boolean_String_String_Boolean_String_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_CreateShaderFeatureDropdown_Public_Static_ProfileFeatureDefinition_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Int32_String_String_Boolean_String_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_CreateBooleanFeature_Public_Static_ProfileFeatureDefinition_String_Boolean_String_String_Boolean_String_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084F RID: 2127
		[OriginalName("Assembly-CSharp.dll", "", "FeatureType")]
		public enum FeatureType
		{
			// Token: 0x0400823A RID: 33338
			ShaderKeyword,
			// Token: 0x0400823B RID: 33339
			BooleanValue,
			// Token: 0x0400823C RID: 33340
			ShaderKeywordDropdown
		}
	}
}
