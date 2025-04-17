using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000785 RID: 1925
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x0600B63E RID: 46654 RVA: 0x002D43B0 File Offset: 0x002D25B0
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduledMaterialChange()
		{
			Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ScheduledMaterialChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr);
			ScheduledMaterialChange.NativeFieldInfoPtr_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Renderers");
			ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "MaterialIndex");
			ScheduledMaterialChange.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Enabled");
			ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "OutsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "InsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMin");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMax");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeShift");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeRandomization");
			ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TurnOnChance");
			ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "appliedInsideTimeRange");
			ScheduledMaterialChange.NativeFieldInfoPtr_onState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "onState");
			ScheduledMaterialChange.NativeFieldInfoPtr_randomShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "randomShift");
			ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685708);
			ScheduledMaterialChange.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685709);
			ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685710);
			ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685711);
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x002D4534 File Offset: 0x002D2734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310932, XrefRangeEnd = 310950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x002D4570 File Offset: 0x002D2770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310950, XrefRangeEnd = 310965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x002D45AC File Offset: 0x002D27AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310972, RefRangeEnd = 310975, XrefRangeStart = 310965, XrefRangeEnd = 310972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(bool insideTimeRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref insideTimeRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x002D45EC File Offset: 0x002D27EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310975, XrefRangeEnd = 310976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduledMaterialChange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x0005976D File Offset: 0x0005796D
		public ScheduledMaterialChange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600B644 RID: 46660 RVA: 0x002D4628 File Offset: 0x002D2828
		// (set) Token: 0x0600B645 RID: 46661 RVA: 0x00059776 File Offset: 0x00057976
		public unsafe Il2CppReferenceArray<MeshRenderer> Renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600B646 RID: 46662 RVA: 0x002D4658 File Offset: 0x002D2858
		// (set) Token: 0x0600B647 RID: 46663 RVA: 0x00059795 File Offset: 0x00057995
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600B648 RID: 46664 RVA: 0x002D4680 File Offset: 0x002D2880
		// (set) Token: 0x0600B649 RID: 46665 RVA: 0x000597B0 File Offset: 0x000579B0
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600B64A RID: 46666 RVA: 0x002D46A8 File Offset: 0x002D28A8
		// (set) Token: 0x0600B64B RID: 46667 RVA: 0x000597CB File Offset: 0x000579CB
		public unsafe Material OutsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x002D46D8 File Offset: 0x002D28D8
		// (set) Token: 0x0600B64D RID: 46669 RVA: 0x000597EA File Offset: 0x000579EA
		public unsafe Material InsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600B64E RID: 46670 RVA: 0x002D4708 File Offset: 0x002D2908
		// (set) Token: 0x0600B64F RID: 46671 RVA: 0x00059809 File Offset: 0x00057A09
		public unsafe int TimeRangeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin)) = value;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600B650 RID: 46672 RVA: 0x002D4730 File Offset: 0x002D2930
		// (set) Token: 0x0600B651 RID: 46673 RVA: 0x00059824 File Offset: 0x00057A24
		public unsafe int TimeRangeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax)) = value;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600B652 RID: 46674 RVA: 0x002D4758 File Offset: 0x002D2958
		// (set) Token: 0x0600B653 RID: 46675 RVA: 0x0005983F File Offset: 0x00057A3F
		public unsafe int TimeRangeShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift)) = value;
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600B654 RID: 46676 RVA: 0x002D4780 File Offset: 0x002D2980
		// (set) Token: 0x0600B655 RID: 46677 RVA: 0x0005985A File Offset: 0x00057A5A
		public unsafe int TimeRangeRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization)) = value;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600B656 RID: 46678 RVA: 0x002D47A8 File Offset: 0x002D29A8
		// (set) Token: 0x0600B657 RID: 46679 RVA: 0x00059875 File Offset: 0x00057A75
		public unsafe float TurnOnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance)) = value;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600B658 RID: 46680 RVA: 0x002D47D0 File Offset: 0x002D29D0
		// (set) Token: 0x0600B659 RID: 46681 RVA: 0x00059890 File Offset: 0x00057A90
		public unsafe bool appliedInsideTimeRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange)) = value;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600B65A RID: 46682 RVA: 0x002D47F8 File Offset: 0x002D29F8
		// (set) Token: 0x0600B65B RID: 46683 RVA: 0x000598AB File Offset: 0x00057AAB
		public unsafe ScheduledMaterialChange.EOnState onState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState)) = value;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600B65C RID: 46684 RVA: 0x002D4820 File Offset: 0x002D2A20
		// (set) Token: 0x0600B65D RID: 46685 RVA: 0x000598C6 File Offset: 0x00057AC6
		public unsafe int randomShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift)) = value;
			}
		}

		// Token: 0x04007AC8 RID: 31432
		private static readonly IntPtr NativeFieldInfoPtr_Renderers;

		// Token: 0x04007AC9 RID: 31433
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x04007ACA RID: 31434
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04007ACB RID: 31435
		private static readonly IntPtr NativeFieldInfoPtr_OutsideTimeRangeMaterial;

		// Token: 0x04007ACC RID: 31436
		private static readonly IntPtr NativeFieldInfoPtr_InsideTimeRangeMaterial;

		// Token: 0x04007ACD RID: 31437
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMin;

		// Token: 0x04007ACE RID: 31438
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMax;

		// Token: 0x04007ACF RID: 31439
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeShift;

		// Token: 0x04007AD0 RID: 31440
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeRandomization;

		// Token: 0x04007AD1 RID: 31441
		private static readonly IntPtr NativeFieldInfoPtr_TurnOnChance;

		// Token: 0x04007AD2 RID: 31442
		private static readonly IntPtr NativeFieldInfoPtr_appliedInsideTimeRange;

		// Token: 0x04007AD3 RID: 31443
		private static readonly IntPtr NativeFieldInfoPtr_onState;

		// Token: 0x04007AD4 RID: 31444
		private static readonly IntPtr NativeFieldInfoPtr_randomShift;

		// Token: 0x04007AD5 RID: 31445
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007AD6 RID: 31446
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0;

		// Token: 0x04007AD7 RID: 31447
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0;

		// Token: 0x04007AD8 RID: 31448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C05 RID: 3077
		[OriginalName("Assembly-CSharp.dll", "", "EOnState")]
		public enum EOnState
		{
			// Token: 0x04009618 RID: 38424
			Undecided,
			// Token: 0x04009619 RID: 38425
			On,
			// Token: 0x0400961A RID: 38426
			Off
		}
	}
}
