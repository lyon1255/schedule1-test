using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D9 RID: 985
	[Serializable]
	public class PatrolInstance : Object
	{
		// Token: 0x06004C2E RID: 19502 RVA: 0x0016EF38 File Offset: 0x0016D138
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolInstance()
		{
			Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr);
			PatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Route");
			PatrolInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Members");
			PatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "StartTime");
			PatrolInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "EndTime");
			PatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "IntensityRequirement");
			PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "<ActiveGroup>k__BackingField");
			PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672727);
			PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672728);
			PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672729);
			PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672730);
			PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672731);
			PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672732);
			PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672733);
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x0016F080 File Offset: 0x0016D280
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x0016F0C0 File Offset: 0x0016D2C0
		public unsafe PatrolGroup ActiveGroup
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x0016F104 File Offset: 0x0016D304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165354, XrefRangeEnd = 165366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x0016F138 File Offset: 0x0016D338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165394, RefRangeEnd = 165396, XrefRangeStart = 165366, XrefRangeEnd = 165394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x0016F16C File Offset: 0x0016D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165396, XrefRangeEnd = 165418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x0016F1A0 File Offset: 0x0016D3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165418, XrefRangeEnd = 165435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x0016F1D4 File Offset: 0x0016D3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165435, XrefRangeEnd = 165436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x000249D9 File Offset: 0x00022BD9
		public PatrolInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06004C37 RID: 19511 RVA: 0x0016F210 File Offset: 0x0016D410
		// (set) Token: 0x06004C38 RID: 19512 RVA: 0x000249E2 File Offset: 0x00022BE2
		public unsafe FootPatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x0016F240 File Offset: 0x0016D440
		// (set) Token: 0x06004C3A RID: 19514 RVA: 0x00024A01 File Offset: 0x00022C01
		public unsafe int Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x0016F268 File Offset: 0x0016D468
		// (set) Token: 0x06004C3C RID: 19516 RVA: 0x00024A1C File Offset: 0x00022C1C
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x0016F290 File Offset: 0x0016D490
		// (set) Token: 0x06004C3E RID: 19518 RVA: 0x00024A37 File Offset: 0x00022C37
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x0016F2B8 File Offset: 0x0016D4B8
		// (set) Token: 0x06004C40 RID: 19520 RVA: 0x00024A52 File Offset: 0x00022C52
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x0016F2E0 File Offset: 0x0016D4E0
		// (set) Token: 0x06004C42 RID: 19522 RVA: 0x00024A6D File Offset: 0x00022C6D
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06004C43 RID: 19523 RVA: 0x0016F308 File Offset: 0x0016D508
		// (set) Token: 0x06004C44 RID: 19524 RVA: 0x00024A88 File Offset: 0x00022C88
		public unsafe PatrolGroup _ActiveGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeFieldInfoPtr__ActiveGroup_k__BackingField;

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0;

		// Token: 0x04003363 RID: 13155
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0;

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeMethodInfoPtr_EndPatrol_Public_Void_0;

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
