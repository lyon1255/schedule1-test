using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000748 RID: 1864
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x0600AED0 RID: 44752 RVA: 0x002B9EB4 File Offset: 0x002B80B4
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenHammer()
		{
			Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenHammer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr);
			LabOvenHammer.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Draggable");
			LabOvenHammer.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Constraint");
			LabOvenHammer.NativeFieldInfoPtr_Rotator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Rotator");
			LabOvenHammer.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "CoM");
			LabOvenHammer.NativeFieldInfoPtr_ImpactPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "ImpactPoint");
			LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "VelocityCalculator");
			LabOvenHammer.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinHeight");
			LabOvenHammer.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxHeight");
			LabOvenHammer.NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinAngle");
			LabOvenHammer.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxAngle");
			LabOvenHammer.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "onCollision");
			LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684794);
			LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684795);
			LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684796);
			LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684797);
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x002BA010 File Offset: 0x002B8210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302155, XrefRangeEnd = 302157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x002BA044 File Offset: 0x002B8244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302157, XrefRangeEnd = 302163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x002BA078 File Offset: 0x002B8278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302163, XrefRangeEnd = 302166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x002BA0BC File Offset: 0x002B82BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302166, XrefRangeEnd = 302167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenHammer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x00055E58 File Offset: 0x00054058
		public LabOvenHammer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600AED6 RID: 44758 RVA: 0x002BA0F8 File Offset: 0x002B82F8
		// (set) Token: 0x0600AED7 RID: 44759 RVA: 0x00055E61 File Offset: 0x00054061
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600AED8 RID: 44760 RVA: 0x002BA128 File Offset: 0x002B8328
		// (set) Token: 0x0600AED9 RID: 44761 RVA: 0x00055E80 File Offset: 0x00054080
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600AEDA RID: 44762 RVA: 0x002BA158 File Offset: 0x002B8358
		// (set) Token: 0x0600AEDB RID: 44763 RVA: 0x00055E9F File Offset: 0x0005409F
		public unsafe RotateRigidbodyToTarget Rotator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotateRigidbodyToTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600AEDC RID: 44764 RVA: 0x002BA188 File Offset: 0x002B8388
		// (set) Token: 0x0600AEDD RID: 44765 RVA: 0x00055EBE File Offset: 0x000540BE
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600AEDE RID: 44766 RVA: 0x002BA1B8 File Offset: 0x002B83B8
		// (set) Token: 0x0600AEDF RID: 44767 RVA: 0x00055EDD File Offset: 0x000540DD
		public unsafe Transform ImpactPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600AEE0 RID: 44768 RVA: 0x002BA1E8 File Offset: 0x002B83E8
		// (set) Token: 0x0600AEE1 RID: 44769 RVA: 0x00055EFC File Offset: 0x000540FC
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600AEE2 RID: 44770 RVA: 0x002BA218 File Offset: 0x002B8418
		// (set) Token: 0x0600AEE3 RID: 44771 RVA: 0x00055F1B File Offset: 0x0005411B
		public unsafe float MinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight)) = value;
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600AEE4 RID: 44772 RVA: 0x002BA240 File Offset: 0x002B8440
		// (set) Token: 0x0600AEE5 RID: 44773 RVA: 0x00055F36 File Offset: 0x00054136
		public unsafe float MaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight)) = value;
			}
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x002BA268 File Offset: 0x002B8468
		// (set) Token: 0x0600AEE7 RID: 44775 RVA: 0x00055F51 File Offset: 0x00054151
		public unsafe float MinAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle)) = value;
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600AEE8 RID: 44776 RVA: 0x002BA290 File Offset: 0x002B8490
		// (set) Token: 0x0600AEE9 RID: 44777 RVA: 0x00055F6C File Offset: 0x0005416C
		public unsafe float MaxAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle)) = value;
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x002BA2B8 File Offset: 0x002B84B8
		// (set) Token: 0x0600AEEB RID: 44779 RVA: 0x00055F87 File Offset: 0x00054187
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040075AD RID: 30125
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x040075AE RID: 30126
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x040075AF RID: 30127
		private static readonly IntPtr NativeFieldInfoPtr_Rotator;

		// Token: 0x040075B0 RID: 30128
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x040075B1 RID: 30129
		private static readonly IntPtr NativeFieldInfoPtr_ImpactPoint;

		// Token: 0x040075B2 RID: 30130
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x040075B3 RID: 30131
		private static readonly IntPtr NativeFieldInfoPtr_MinHeight;

		// Token: 0x040075B4 RID: 30132
		private static readonly IntPtr NativeFieldInfoPtr_MaxHeight;

		// Token: 0x040075B5 RID: 30133
		private static readonly IntPtr NativeFieldInfoPtr_MinAngle;

		// Token: 0x040075B6 RID: 30134
		private static readonly IntPtr NativeFieldInfoPtr_MaxAngle;

		// Token: 0x040075B7 RID: 30135
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x040075B8 RID: 30136
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075B9 RID: 30137
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040075BA RID: 30138
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040075BB RID: 30139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
