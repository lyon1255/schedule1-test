using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C0 RID: 960
	[Serializable]
	public class CheckpointInstance : Object
	{
		// Token: 0x06004AD4 RID: 19156 RVA: 0x0016A898 File Offset: 0x00168A98
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointInstance()
		{
			Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr);
			CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "MIN_ACTIVATION_DISTANCE");
			CheckpointInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Location");
			CheckpointInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Members");
			CheckpointInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "StartTime");
			CheckpointInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "EndTime");
			CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "IntensityRequirement");
			CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			CheckpointInstance.NativeFieldInfoPtr_checkPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "checkPoint");
			CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "<activeCheckpoint>k__BackingField");
			CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672581);
			CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672582);
			CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672583);
			CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672584);
			CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672585);
			CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672586);
			CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672587);
			CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672588);
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x0016AA1C File Offset: 0x00168C1C
		// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x0016AA5C File Offset: 0x00168C5C
		public unsafe RoadCheckpoint activeCheckpoint
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0016AAA0 File Offset: 0x00168CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164466, RefRangeEnd = 164467, XrefRangeStart = 164438, XrefRangeEnd = 164466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0016AAD4 File Offset: 0x00168CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164505, RefRangeEnd = 164506, XrefRangeStart = 164467, XrefRangeEnd = 164505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0016AB08 File Offset: 0x00168D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164527, RefRangeEnd = 164529, XrefRangeStart = 164506, XrefRangeEnd = 164527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DistanceRequirementsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0016AB44 File Offset: 0x00168D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164529, XrefRangeEnd = 164536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0016AB78 File Offset: 0x00168D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164566, RefRangeEnd = 164567, XrefRangeStart = 164536, XrefRangeEnd = 164566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0016ABAC File Offset: 0x00168DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164567, XrefRangeEnd = 164568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0002407D File Offset: 0x0002227D
		public CheckpointInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x0016ABE8 File Offset: 0x00168DE8
		// (set) Token: 0x06004ADF RID: 19167 RVA: 0x00024086 File Offset: 0x00022286
		public unsafe static float MIN_ACTIVATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x0016AC04 File Offset: 0x00168E04
		// (set) Token: 0x06004AE1 RID: 19169 RVA: 0x00024094 File Offset: 0x00022294
		public unsafe CheckpointManager.ECheckpointLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location)) = value;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x0016AC2C File Offset: 0x00168E2C
		// (set) Token: 0x06004AE3 RID: 19171 RVA: 0x000240AF File Offset: 0x000222AF
		public unsafe int Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x0016AC54 File Offset: 0x00168E54
		// (set) Token: 0x06004AE5 RID: 19173 RVA: 0x000240CA File Offset: 0x000222CA
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x0016AC7C File Offset: 0x00168E7C
		// (set) Token: 0x06004AE7 RID: 19175 RVA: 0x000240E5 File Offset: 0x000222E5
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x0016ACA4 File Offset: 0x00168EA4
		// (set) Token: 0x06004AE9 RID: 19177 RVA: 0x00024100 File Offset: 0x00022300
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x0016ACCC File Offset: 0x00168ECC
		// (set) Token: 0x06004AEB RID: 19179 RVA: 0x0002411B File Offset: 0x0002231B
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004AEC RID: 19180 RVA: 0x0016ACF4 File Offset: 0x00168EF4
		// (set) Token: 0x06004AED RID: 19181 RVA: 0x00024136 File Offset: 0x00022336
		public unsafe RoadCheckpoint checkPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004AEE RID: 19182 RVA: 0x0016AD24 File Offset: 0x00168F24
		// (set) Token: 0x06004AEF RID: 19183 RVA: 0x00024155 File Offset: 0x00022355
		public unsafe RoadCheckpoint _activeCheckpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE;

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeFieldInfoPtr_checkPoint;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeFieldInfoPtr__activeCheckpoint_k__BackingField;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0;

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
