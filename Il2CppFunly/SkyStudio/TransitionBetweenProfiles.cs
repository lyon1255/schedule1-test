using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000132 RID: 306
	public class TransitionBetweenProfiles : MonoBehaviour
	{
		// Token: 0x06001A0B RID: 6667 RVA: 0x000C1EEC File Offset: 0x000C00EC
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionBetweenProfiles()
		{
			Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TransitionBetweenProfiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr);
			TransitionBetweenProfiles.NativeFieldInfoPtr_daySkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "daySkyProfile");
			TransitionBetweenProfiles.NativeFieldInfoPtr_nightSkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "nightSkyProfile");
			TransitionBetweenProfiles.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "transitionDuration");
			TransitionBetweenProfiles.NativeFieldInfoPtr_timeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "timeOfDayController");
			TransitionBetweenProfiles.NativeFieldInfoPtr_m_CurrentSkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "m_CurrentSkyProfile");
			TransitionBetweenProfiles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, 100666061);
			TransitionBetweenProfiles.NativeMethodInfoPtr_ToggleSkyProfiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, 100666062);
			TransitionBetweenProfiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, 100666063);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000C1FBC File Offset: 0x000C01BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96902, XrefRangeEnd = 96912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionBetweenProfiles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000C1FF0 File Offset: 0x000C01F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96912, XrefRangeEnd = 96920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleSkyProfiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionBetweenProfiles.NativeMethodInfoPtr_ToggleSkyProfiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000C2024 File Offset: 0x000C0224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96920, XrefRangeEnd = 96921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionBetweenProfiles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionBetweenProfiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public TransitionBetweenProfiles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x000C2060 File Offset: 0x000C0260
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x0000ED09 File Offset: 0x0000CF09
		public unsafe SkyProfile daySkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_daySkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_daySkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x000C2090 File Offset: 0x000C0290
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0000ED28 File Offset: 0x0000CF28
		public unsafe SkyProfile nightSkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_nightSkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_nightSkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x000C20C0 File Offset: 0x000C02C0
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x0000ED47 File Offset: 0x0000CF47
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x000C20E8 File Offset: 0x000C02E8
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0000ED62 File Offset: 0x0000CF62
		public unsafe TimeOfDayController timeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_timeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_timeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x000C2118 File Offset: 0x000C0318
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0000ED81 File Offset: 0x0000CF81
		public unsafe SkyProfile m_CurrentSkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_m_CurrentSkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_m_CurrentSkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeFieldInfoPtr_daySkyProfile;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeFieldInfoPtr_nightSkyProfile;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDayController;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSkyProfile;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_ToggleSkyProfiles_Public_Void_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
