using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FB RID: 1275
	[Serializable]
	public class DriveFlags : Object
	{
		// Token: 0x0600709F RID: 28831 RVA: 0x001EF010 File Offset: 0x001ED210
		// Note: this type is marked as 'beforefieldinit'.
		static DriveFlags()
		{
			Il2CppClassPointerStore<DriveFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "DriveFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr);
			DriveFlags.NativeFieldInfoPtr_OverrideSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverrideSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenReverseSpeed");
			DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "SpeedLimitMultiplier");
			DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "IgnoreTrafficLights");
			DriveFlags.NativeFieldInfoPtr_UseRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "UseRoads");
			DriveFlags.NativeFieldInfoPtr_StuckDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "StuckDetection");
			DriveFlags.NativeFieldInfoPtr_ObstacleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "ObstacleMode");
			DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "AutoBrakeAtDestination");
			DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "TurnBasedSpeedReduction");
			DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100677451);
			DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100677452);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x001EF130 File Offset: 0x001ED330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221668, RefRangeEnd = 221671, XrefRangeStart = 221668, XrefRangeEnd = 221668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x001EF164 File Offset: 0x001ED364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221671, XrefRangeEnd = 221672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveFlags() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x00035766 File Offset: 0x00033966
		public DriveFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x060070A3 RID: 28835 RVA: 0x001EF1A0 File Offset: 0x001ED3A0
		// (set) Token: 0x060070A4 RID: 28836 RVA: 0x0003576F File Offset: 0x0003396F
		public unsafe bool OverrideSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed)) = value;
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x060070A5 RID: 28837 RVA: 0x001EF1C8 File Offset: 0x001ED3C8
		// (set) Token: 0x060070A6 RID: 28838 RVA: 0x0003578A File Offset: 0x0003398A
		public unsafe float OverriddenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed)) = value;
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x060070A7 RID: 28839 RVA: 0x001EF1F0 File Offset: 0x001ED3F0
		// (set) Token: 0x060070A8 RID: 28840 RVA: 0x000357A5 File Offset: 0x000339A5
		public unsafe float OverriddenReverseSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed)) = value;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x060070A9 RID: 28841 RVA: 0x001EF218 File Offset: 0x001ED418
		// (set) Token: 0x060070AA RID: 28842 RVA: 0x000357C0 File Offset: 0x000339C0
		public unsafe float SpeedLimitMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier)) = value;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x060070AB RID: 28843 RVA: 0x001EF240 File Offset: 0x001ED440
		// (set) Token: 0x060070AC RID: 28844 RVA: 0x000357DB File Offset: 0x000339DB
		public unsafe bool IgnoreTrafficLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights)) = value;
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x060070AD RID: 28845 RVA: 0x001EF268 File Offset: 0x001ED468
		// (set) Token: 0x060070AE RID: 28846 RVA: 0x000357F6 File Offset: 0x000339F6
		public unsafe bool UseRoads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads)) = value;
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x001EF290 File Offset: 0x001ED490
		// (set) Token: 0x060070B0 RID: 28848 RVA: 0x00035811 File Offset: 0x00033A11
		public unsafe bool StuckDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection)) = value;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x001EF2B8 File Offset: 0x001ED4B8
		// (set) Token: 0x060070B2 RID: 28850 RVA: 0x0003582C File Offset: 0x00033A2C
		public unsafe DriveFlags.EObstacleMode ObstacleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode)) = value;
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x060070B3 RID: 28851 RVA: 0x001EF2E0 File Offset: 0x001ED4E0
		// (set) Token: 0x060070B4 RID: 28852 RVA: 0x00035847 File Offset: 0x00033A47
		public unsafe bool AutoBrakeAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination)) = value;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x060070B5 RID: 28853 RVA: 0x001EF308 File Offset: 0x001ED508
		// (set) Token: 0x060070B6 RID: 28854 RVA: 0x00035862 File Offset: 0x00033A62
		public unsafe bool TurnBasedSpeedReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction)) = value;
			}
		}

		// Token: 0x04004CF8 RID: 19704
		private static readonly IntPtr NativeFieldInfoPtr_OverrideSpeed;

		// Token: 0x04004CF9 RID: 19705
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenSpeed;

		// Token: 0x04004CFA RID: 19706
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenReverseSpeed;

		// Token: 0x04004CFB RID: 19707
		private static readonly IntPtr NativeFieldInfoPtr_SpeedLimitMultiplier;

		// Token: 0x04004CFC RID: 19708
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreTrafficLights;

		// Token: 0x04004CFD RID: 19709
		private static readonly IntPtr NativeFieldInfoPtr_UseRoads;

		// Token: 0x04004CFE RID: 19710
		private static readonly IntPtr NativeFieldInfoPtr_StuckDetection;

		// Token: 0x04004CFF RID: 19711
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleMode;

		// Token: 0x04004D00 RID: 19712
		private static readonly IntPtr NativeFieldInfoPtr_AutoBrakeAtDestination;

		// Token: 0x04004D01 RID: 19713
		private static readonly IntPtr NativeFieldInfoPtr_TurnBasedSpeedReduction;

		// Token: 0x04004D02 RID: 19714
		private static readonly IntPtr NativeMethodInfoPtr_ResetFlags_Public_Void_0;

		// Token: 0x04004D03 RID: 19715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A70 RID: 2672
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleMode")]
		public enum EObstacleMode
		{
			// Token: 0x04008D2A RID: 36138
			Default,
			// Token: 0x04008D2B RID: 36139
			IgnoreAll,
			// Token: 0x04008D2C RID: 36140
			IgnoreOnlySquishy
		}
	}
}
