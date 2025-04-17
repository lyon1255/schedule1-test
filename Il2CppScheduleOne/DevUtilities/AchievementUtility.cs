using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044A RID: 1098
	public class AchievementUtility : MonoBehaviour
	{
		// Token: 0x06005F9F RID: 24479 RVA: 0x001B6CF8 File Offset: 0x001B4EF8
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementUtility()
		{
			Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AchievementUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr);
			AchievementUtility.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, "Achievement");
			AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100675499);
			AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100675500);
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x001B6D64 File Offset: 0x001B4F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198529, XrefRangeEnd = 198535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x001B6D98 File Offset: 0x001B4F98
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x0002D1C1 File Offset: 0x0002B3C1
		public AchievementUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06005FA3 RID: 24483 RVA: 0x001B6DD4 File Offset: 0x001B4FD4
		// (set) Token: 0x06005FA4 RID: 24484 RVA: 0x0002D1CA File Offset: 0x0002B3CA
		public unsafe AchievementManager.EAchievement Achievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement)) = value;
			}
		}

		// Token: 0x0400415A RID: 16730
		private static readonly IntPtr NativeFieldInfoPtr_Achievement;

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_0;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
