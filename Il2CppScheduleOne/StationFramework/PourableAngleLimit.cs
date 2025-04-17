using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058F RID: 1423
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06007D1D RID: 32029 RVA: 0x00218CF0 File Offset: 0x00216EF0
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAngleLimit()
		{
			Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableAngleLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr);
			PourableAngleLimit.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Pourable");
			PourableAngleLimit.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Constraint");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMinFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMinFill");
			PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100678961);
			PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100678962);
			PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100678963);
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x00218DD4 File Offset: 0x00216FD4
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x00218E08 File Offset: 0x00217008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237605, XrefRangeEnd = 237607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x00218E3C File Offset: 0x0021703C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237607, XrefRangeEnd = 237608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAngleLimit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x0003B6AC File Offset: 0x000398AC
		public PourableAngleLimit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x00218E78 File Offset: 0x00217078
		// (set) Token: 0x06007D23 RID: 32035 RVA: 0x0003B6B5 File Offset: 0x000398B5
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x00218EA8 File Offset: 0x002170A8
		// (set) Token: 0x06007D25 RID: 32037 RVA: 0x0003B6D4 File Offset: 0x000398D4
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x00218ED8 File Offset: 0x002170D8
		// (set) Token: 0x06007D27 RID: 32039 RVA: 0x0003B6F3 File Offset: 0x000398F3
		public unsafe float AngleAtMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill)) = value;
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x06007D28 RID: 32040 RVA: 0x00218F00 File Offset: 0x00217100
		// (set) Token: 0x06007D29 RID: 32041 RVA: 0x0003B70E File Offset: 0x0003990E
		public unsafe float AngleAtMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill)) = value;
			}
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x06007D2A RID: 32042 RVA: 0x00218F28 File Offset: 0x00217128
		// (set) Token: 0x06007D2B RID: 32043 RVA: 0x0003B729 File Offset: 0x00039929
		public unsafe float PourAngleMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill)) = value;
			}
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x06007D2C RID: 32044 RVA: 0x00218F50 File Offset: 0x00217150
		// (set) Token: 0x06007D2D RID: 32045 RVA: 0x0003B744 File Offset: 0x00039944
		public unsafe float PourAngleMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill)) = value;
			}
		}

		// Token: 0x04005522 RID: 21794
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x04005523 RID: 21795
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x04005524 RID: 21796
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMaxFill;

		// Token: 0x04005525 RID: 21797
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMinFill;

		// Token: 0x04005526 RID: 21798
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMaxFill;

		// Token: 0x04005527 RID: 21799
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMinFill;

		// Token: 0x04005528 RID: 21800
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005529 RID: 21801
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x0400552A RID: 21802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
