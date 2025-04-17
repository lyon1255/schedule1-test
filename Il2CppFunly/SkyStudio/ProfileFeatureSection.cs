using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010A RID: 266
	[Serializable]
	public class ProfileFeatureSection : Object
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x000B0880 File Offset: 0x000AEA80
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileFeatureSection()
		{
			Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileFeatureSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr);
			ProfileFeatureSection.NativeFieldInfoPtr_sectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "sectionTitle");
			ProfileFeatureSection.NativeFieldInfoPtr_sectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "sectionKey");
			ProfileFeatureSection.NativeFieldInfoPtr_sectionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "sectionIcon");
			ProfileFeatureSection.NativeFieldInfoPtr_featureDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "featureDefinitions");
			ProfileFeatureSection.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppReferenceArray_1_ProfileFeatureDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, 100665555);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000B0914 File Offset: 0x000AEB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90624, XrefRangeEnd = 90628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileFeatureSection(string sectionTitle, string sectionKey, Il2CppReferenceArray<ProfileFeatureDefinition> featureDefinitions) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sectionKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(featureDefinitions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileFeatureSection.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppReferenceArray_1_ProfileFeatureDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0000BF0F File Offset: 0x0000A10F
		public ProfileFeatureSection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000B0984 File Offset: 0x000AEB84
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0000BF18 File Offset: 0x0000A118
		public unsafe string sectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000B09AC File Offset: 0x000AEBAC
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x0000BF37 File Offset: 0x0000A137
		public unsafe string sectionKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x000B09D4 File Offset: 0x000AEBD4
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x0000BF56 File Offset: 0x0000A156
		public unsafe string sectionIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionIcon);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionIcon), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x000B09FC File Offset: 0x000AEBFC
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x0000BF75 File Offset: 0x0000A175
		public unsafe Il2CppReferenceArray<ProfileFeatureDefinition> featureDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_featureDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_featureDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeFieldInfoPtr_sectionTitle;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeFieldInfoPtr_sectionKey;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeFieldInfoPtr_sectionIcon;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeFieldInfoPtr_featureDefinitions;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppReferenceArray_1_ProfileFeatureDefinition_0;
	}
}
