using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010C RID: 268
	public class ProfileSectionKeys : Object
	{
		// Token: 0x0600155B RID: 5467 RVA: 0x000B2904 File Offset: 0x000B0B04
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileSectionKeys()
		{
			Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileSectionKeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr);
			ProfileSectionKeys.NativeFieldInfoPtr_FeaturesSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "FeaturesSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_SkySectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "SkySectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_SunSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "SunSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_MoonSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "MoonSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_CloudSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "CloudSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_FogSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "FogSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_StarsBasicSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "StarsBasicSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_Star1SectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "Star1SectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_Star2SectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "Star2SectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_Star3SectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "Star3SectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_RainSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "RainSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_RainSplashSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "RainSplashSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_LightningSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "LightningSectionKey");
			ProfileSectionKeys.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, 100665558);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000B2A4C File Offset: 0x000B0C4C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileSectionKeys() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileSectionKeys.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0000CA05 File Offset: 0x0000AC05
		public ProfileSectionKeys(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x000B2A88 File Offset: 0x000B0C88
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x0000CA0E File Offset: 0x0000AC0E
		public unsafe static string FeaturesSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_FeaturesSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_FeaturesSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x000B2AA8 File Offset: 0x000B0CA8
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0000CA20 File Offset: 0x0000AC20
		public unsafe static string SkySectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_SkySectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_SkySectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x000B2AC8 File Offset: 0x000B0CC8
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0000CA32 File Offset: 0x0000AC32
		public unsafe static string SunSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_SunSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_SunSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000B2AE8 File Offset: 0x000B0CE8
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0000CA44 File Offset: 0x0000AC44
		public unsafe static string MoonSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_MoonSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_MoonSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x000B2B08 File Offset: 0x000B0D08
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0000CA56 File Offset: 0x0000AC56
		public unsafe static string CloudSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_CloudSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_CloudSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x000B2B28 File Offset: 0x000B0D28
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0000CA68 File Offset: 0x0000AC68
		public unsafe static string FogSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_FogSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_FogSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000B2B48 File Offset: 0x000B0D48
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000CA7A File Offset: 0x0000AC7A
		public unsafe static string StarsBasicSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_StarsBasicSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_StarsBasicSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000B2B68 File Offset: 0x000B0D68
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		public unsafe static string Star1SectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_Star1SectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_Star1SectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000B2B88 File Offset: 0x000B0D88
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000CA9E File Offset: 0x0000AC9E
		public unsafe static string Star2SectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_Star2SectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_Star2SectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000B2BA8 File Offset: 0x000B0DA8
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		public unsafe static string Star3SectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_Star3SectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_Star3SectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000B2BC8 File Offset: 0x000B0DC8
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x0000CAC2 File Offset: 0x0000ACC2
		public unsafe static string RainSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x000B2BE8 File Offset: 0x000B0DE8
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		public unsafe static string RainSplashSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSplashSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSplashSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x000B2C08 File Offset: 0x000B0E08
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000CAE6 File Offset: 0x0000ACE6
		public unsafe static string LightningSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_LightningSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_LightningSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeFieldInfoPtr_FeaturesSectionKey;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_SkySectionKey;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeFieldInfoPtr_SunSectionKey;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeFieldInfoPtr_MoonSectionKey;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeFieldInfoPtr_CloudSectionKey;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeFieldInfoPtr_FogSectionKey;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr_StarsBasicSectionKey;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr_Star1SectionKey;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_Star2SectionKey;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_Star3SectionKey;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeFieldInfoPtr_RainSectionKey;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashSectionKey;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeFieldInfoPtr_LightningSectionKey;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
