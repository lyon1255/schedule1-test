using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne
{
	// Token: 0x0200016C RID: 364
	public class AchievementManager : PersistentSingleton<AchievementManager>
	{
		// Token: 0x06001D72 RID: 7538 RVA: 0x000CBFB4 File Offset: 0x000CA1B4
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementManager()
		{
			Il2CppClassPointerStore<AchievementManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "AchievementManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr);
			AchievementManager.NativeFieldInfoPtr_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievements");
			AchievementManager.NativeFieldInfoPtr_achievementUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievementUnlocked");
			AchievementManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666646);
			AchievementManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666647);
			AchievementManager.NativeMethodInfoPtr_PullAchievements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666648);
			AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666649);
			AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666650);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000CC070 File Offset: 0x000CA270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105914, XrefRangeEnd = 105952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000CC0AC File Offset: 0x000CA2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105952, XrefRangeEnd = 105987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x000CC0E8 File Offset: 0x000CA2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105987, XrefRangeEnd = 106005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PullAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_PullAchievements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x000CC11C File Offset: 0x000CA31C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 106030, RefRangeEnd = 106039, XrefRangeStart = 106005, XrefRangeEnd = 106030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000CC15C File Offset: 0x000CA35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106039, XrefRangeEnd = 106049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00010A47 File Offset: 0x0000EC47
		public AchievementManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000CC198 File Offset: 0x000CA398
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x00010A50 File Offset: 0x0000EC50
		public unsafe Il2CppStructArray<AchievementManager.EAchievement> achievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AchievementManager.EAchievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000CC1C8 File Offset: 0x000CA3C8
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x00010A6F File Offset: 0x0000EC6F
		public unsafe Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AchievementManager.EAchievement, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_achievements;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_achievementUnlocked;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_PullAchievements_Private_Void_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008A6 RID: 2214
		[OriginalName("Assembly-CSharp.dll", "", "EAchievement")]
		public enum EAchievement
		{
			// Token: 0x04008400 RID: 33792
			COMPLETE_PROLOGUE,
			// Token: 0x04008401 RID: 33793
			RV_DESTROYED,
			// Token: 0x04008402 RID: 33794
			DEALER_RECRUITED,
			// Token: 0x04008403 RID: 33795
			MASTER_CHEF,
			// Token: 0x04008404 RID: 33796
			BUSINESSMAN,
			// Token: 0x04008405 RID: 33797
			BIGWIG,
			// Token: 0x04008406 RID: 33798
			MAGNATE,
			// Token: 0x04008407 RID: 33799
			UPSTANDING_CITIZEN,
			// Token: 0x04008408 RID: 33800
			ROLLING_IN_STYLE,
			// Token: 0x04008409 RID: 33801
			LONG_ARM_OF_THE_LAW,
			// Token: 0x0400840A RID: 33802
			INDIAN_DEALER
		}
	}
}
