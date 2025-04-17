using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F4 RID: 244
	public sealed class ProfileBlendingState : ValueType
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x000AC0C4 File Offset: 0x000AA2C4
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileBlendingState()
		{
			Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileBlendingState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr);
			ProfileBlendingState.NativeFieldInfoPtr_blendedProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "blendedProfile");
			ProfileBlendingState.NativeFieldInfoPtr_fromProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "fromProfile");
			ProfileBlendingState.NativeFieldInfoPtr_toProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "toProfile");
			ProfileBlendingState.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "progress");
			ProfileBlendingState.NativeFieldInfoPtr_outProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "outProgress");
			ProfileBlendingState.NativeFieldInfoPtr_inProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "inProgress");
			ProfileBlendingState.NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "timeOfDay");
			ProfileBlendingState.NativeMethodInfoPtr__ctor_Public_Void_SkyProfile_SkyProfile_SkyProfile_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, 100665457);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000AC194 File Offset: 0x000AA394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89987, XrefRangeEnd = 89990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileBlendingState(SkyProfile blendedProfile, SkyProfile fromProfile, SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendedProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fromProfile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toProfile);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outProgress;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inProgress;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileBlendingState.NativeMethodInfoPtr__ctor_Public_Void_SkyProfile_SkyProfile_SkyProfile_Single_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0000B4D7 File Offset: 0x000096D7
		public ProfileBlendingState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public ProfileBlendingState() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr))
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000AC240 File Offset: 0x000AA440
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0000B4F2 File Offset: 0x000096F2
		public unsafe SkyProfile blendedProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_blendedProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_blendedProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000AC270 File Offset: 0x000AA470
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0000B511 File Offset: 0x00009711
		public unsafe SkyProfile fromProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_fromProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_fromProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000AC2A0 File Offset: 0x000AA4A0
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x0000B530 File Offset: 0x00009730
		public unsafe SkyProfile toProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_toProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_toProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000AC2D0 File Offset: 0x000AA4D0
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0000B54F File Offset: 0x0000974F
		public unsafe float progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_progress)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0000B56A File Offset: 0x0000976A
		public unsafe float outProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_outProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_outProgress)) = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000AC320 File Offset: 0x000AA520
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x0000B585 File Offset: 0x00009785
		public unsafe float inProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_inProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_inProgress)) = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x000AC348 File Offset: 0x000AA548
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000B5A0 File Offset: 0x000097A0
		public unsafe float timeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_timeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_timeOfDay)) = value;
			}
		}

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeFieldInfoPtr_blendedProfile;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeFieldInfoPtr_fromProfile;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr_toProfile;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr_outProgress;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr_inProgress;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDay;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SkyProfile_SkyProfile_SkyProfile_Single_Single_Single_Single_0;
	}
}
