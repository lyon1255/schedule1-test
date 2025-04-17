using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x020001FE RID: 510
	public class DraggableConstraint : MonoBehaviour
	{
		// Token: 0x06002A15 RID: 10773 RVA: 0x000F5E10 File Offset: 0x000F4010
		// Note: this type is marked as 'beforefieldinit'.
		static DraggableConstraint()
		{
			Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "DraggableConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr);
			DraggableConstraint.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "Container");
			DraggableConstraint.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "Anchor");
			DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "ProportionalZClamp");
			DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "AlignUpToContainerPlane");
			DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "ClampUpDirection");
			DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "UpDirectionMaxDifference");
			DraggableConstraint.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "startLocalPos");
			DraggableConstraint.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "draggable");
			DraggableConstraint.NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "joint");
			DraggableConstraint.NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668039);
			DraggableConstraint.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668040);
			DraggableConstraint.NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668041);
			DraggableConstraint.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668042);
			DraggableConstraint.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668043);
			DraggableConstraint.NativeMethodInfoPtr_ProportionalClamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668044);
			DraggableConstraint.NativeMethodInfoPtr_LockRotationX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668045);
			DraggableConstraint.NativeMethodInfoPtr_LockRotationY_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668046);
			DraggableConstraint.NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668047);
			DraggableConstraint.NativeMethodInfoPtr_ClampUpRot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668048);
			DraggableConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668049);
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x000F5FD0 File Offset: 0x000F41D0
		public unsafe Vector3 RelativePos
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 120271, RefRangeEnd = 120273, XrefRangeStart = 120261, XrefRangeEnd = 120271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000F600C File Offset: 0x000F420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120273, XrefRangeEnd = 120305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000F6040 File Offset: 0x000F4240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120325, RefRangeEnd = 120328, XrefRangeStart = 120305, XrefRangeEnd = 120325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContainer(Transform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000F6084 File Offset: 0x000F4284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120328, XrefRangeEnd = 120329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableConstraint.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000F60C0 File Offset: 0x000F42C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120329, XrefRangeEnd = 120344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableConstraint.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000F60FC File Offset: 0x000F42FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120356, RefRangeEnd = 120357, XrefRangeStart = 120344, XrefRangeEnd = 120356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProportionalClamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_ProportionalClamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000F6130 File Offset: 0x000F4330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120357, XrefRangeEnd = 120367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockRotationX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_LockRotationX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000F6164 File Offset: 0x000F4364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120367, XrefRangeEnd = 120377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockRotationY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_LockRotationY_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000F6198 File Offset: 0x000F4398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120392, RefRangeEnd = 120393, XrefRangeStart = 120377, XrefRangeEnd = 120392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignToContainerPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000F61CC File Offset: 0x000F43CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120393, XrefRangeEnd = 120407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampUpRot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_ClampUpRot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000F6200 File Offset: 0x000F4400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120407, XrefRangeEnd = 120408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DraggableConstraint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00016C88 File Offset: 0x00014E88
		public DraggableConstraint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000F623C File Offset: 0x000F443C
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x00016C91 File Offset: 0x00014E91
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000F626C File Offset: 0x000F446C
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000F629C File Offset: 0x000F449C
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x00016CCF File Offset: 0x00014ECF
		public unsafe bool ProportionalZClamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp)) = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000F62C4 File Offset: 0x000F44C4
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x00016CEA File Offset: 0x00014EEA
		public unsafe bool AlignUpToContainerPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane)) = value;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000F62EC File Offset: 0x000F44EC
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x00016D05 File Offset: 0x00014F05
		public unsafe bool ClampUpDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection)) = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x000F6314 File Offset: 0x000F4514
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x00016D20 File Offset: 0x00014F20
		public unsafe float UpDirectionMaxDifference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference)) = value;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000F633C File Offset: 0x000F453C
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x00016D3B File Offset: 0x00014F3B
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000F6364 File Offset: 0x000F4564
		// (set) Token: 0x06002A31 RID: 10801 RVA: 0x00016D56 File Offset: 0x00014F56
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002A32 RID: 10802 RVA: 0x000F6394 File Offset: 0x000F4594
		// (set) Token: 0x06002A33 RID: 10803 RVA: 0x00016D75 File Offset: 0x00014F75
		public unsafe ConfigurableJoint joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_ProportionalZClamp;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr_AlignUpToContainerPlane;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeFieldInfoPtr_ClampUpDirection;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeFieldInfoPtr_UpDirectionMaxDifference;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeFieldInfoPtr_joint;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_ProportionalClamp_Private_Void_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_LockRotationX_Private_Void_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_LockRotationY_Private_Void_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_ClampUpRot_Private_Void_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
