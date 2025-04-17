using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000109 RID: 265
	public class ProfileGroupSection : Object
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x000B0628 File Offset: 0x000AE828
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileGroupSection()
		{
			Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileGroupSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr);
			ProfileGroupSection.NativeFieldInfoPtr_sectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, "sectionTitle");
			ProfileGroupSection.NativeFieldInfoPtr_sectionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, "sectionIcon");
			ProfileGroupSection.NativeFieldInfoPtr_sectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, "sectionKey");
			ProfileGroupSection.NativeFieldInfoPtr_dependsOnFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, "dependsOnFeature");
			ProfileGroupSection.NativeFieldInfoPtr_dependsOnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, "dependsOnValue");
			ProfileGroupSection.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, "groups");
			ProfileGroupSection.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Il2CppReferenceArray_1_ProfileGroupDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr, 100665554);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000B06E4 File Offset: 0x000AE8E4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 90613, RefRangeEnd = 90624, XrefRangeStart = 90607, XrefRangeEnd = 90613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileGroupSection(string sectionTitle, string sectionKey, string sectionIcon, string dependsOnFeature, bool dependsOnValue, Il2CppReferenceArray<ProfileGroupDefinition> groups) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileGroupSection>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sectionKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sectionIcon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dependsOnFeature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOnValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groups);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileGroupSection.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Il2CppReferenceArray_1_ProfileGroupDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0000BE50 File Offset: 0x0000A050
		public ProfileGroupSection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x000B0788 File Offset: 0x000AE988
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0000BE59 File Offset: 0x0000A059
		public unsafe string sectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_sectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_sectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000B07B0 File Offset: 0x000AE9B0
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0000BE78 File Offset: 0x0000A078
		public unsafe string sectionIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_sectionIcon);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_sectionIcon), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x000B07D8 File Offset: 0x000AE9D8
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0000BE97 File Offset: 0x0000A097
		public unsafe string sectionKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_sectionKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_sectionKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000B0800 File Offset: 0x000AEA00
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0000BEB6 File Offset: 0x0000A0B6
		public unsafe string dependsOnFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_dependsOnFeature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_dependsOnFeature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x000B0828 File Offset: 0x000AEA28
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0000BED5 File Offset: 0x0000A0D5
		public unsafe bool dependsOnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_dependsOnValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_dependsOnValue)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x000B0850 File Offset: 0x000AEA50
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		public unsafe Il2CppReferenceArray<ProfileGroupDefinition> groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileGroupSection.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_sectionTitle;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_sectionIcon;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_sectionKey;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_dependsOnFeature;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeFieldInfoPtr_dependsOnValue;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Il2CppReferenceArray_1_ProfileGroupDefinition_0;
	}
}
