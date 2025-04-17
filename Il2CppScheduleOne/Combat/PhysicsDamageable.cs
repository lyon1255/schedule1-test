using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000495 RID: 1173
	public class PhysicsDamageable : MonoBehaviour
	{
		// Token: 0x06006549 RID: 25929 RVA: 0x001C93B4 File Offset: 0x001C75B4
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsDamageable()
		{
			Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PhysicsDamageable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr);
			PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "VELOCITY_HISTORY_LENGTH");
			PhysicsDamageable.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "Rb");
			PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "ForceMultiplier");
			PhysicsDamageable.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "impactHistory");
			PhysicsDamageable.NativeFieldInfoPtr_onImpacted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "onImpacted");
			PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "<averageVelocity>k__BackingField");
			PhysicsDamageable.NativeFieldInfoPtr_velocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "velocityHistory");
			PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676112);
			PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676113);
			PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676114);
			PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676115);
			PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676116);
			PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676117);
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x001C94E8 File Offset: 0x001C76E8
		// (set) Token: 0x0600654B RID: 25931 RVA: 0x001C9524 File Offset: 0x001C7724
		public unsafe Vector3 averageVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205631, RefRangeEnd = 205632, XrefRangeStart = 205631, XrefRangeEnd = 205631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x001C9564 File Offset: 0x001C7764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205632, XrefRangeEnd = 205640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x001C9598 File Offset: 0x001C7798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205640, RefRangeEnd = 205641, XrefRangeStart = 205640, XrefRangeEnd = 205640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x001C95E8 File Offset: 0x001C77E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205641, XrefRangeEnd = 205655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x001C9638 File Offset: 0x001C7838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205655, XrefRangeEnd = 205672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsDamageable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x0002FE7B File Offset: 0x0002E07B
		public PhysicsDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06006551 RID: 25937 RVA: 0x001C9674 File Offset: 0x001C7874
		// (set) Token: 0x06006552 RID: 25938 RVA: 0x0002FE84 File Offset: 0x0002E084
		public unsafe static int VELOCITY_HISTORY_LENGTH
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&value));
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06006553 RID: 25939 RVA: 0x001C9690 File Offset: 0x001C7890
		// (set) Token: 0x06006554 RID: 25940 RVA: 0x0002FE92 File Offset: 0x0002E092
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06006555 RID: 25941 RVA: 0x001C96C0 File Offset: 0x001C78C0
		// (set) Token: 0x06006556 RID: 25942 RVA: 0x0002FEB1 File Offset: 0x0002E0B1
		public unsafe float ForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier)) = value;
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06006557 RID: 25943 RVA: 0x001C96E8 File Offset: 0x001C78E8
		// (set) Token: 0x06006558 RID: 25944 RVA: 0x0002FECC File Offset: 0x0002E0CC
		public unsafe List<int> impactHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06006559 RID: 25945 RVA: 0x001C9718 File Offset: 0x001C7918
		// (set) Token: 0x0600655A RID: 25946 RVA: 0x0002FEEB File Offset: 0x0002E0EB
		public unsafe Action<Impact> onImpacted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Impact>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x001C9748 File Offset: 0x001C7948
		// (set) Token: 0x0600655C RID: 25948 RVA: 0x0002FF0A File Offset: 0x0002E10A
		public unsafe Vector3 _averageVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x001C9770 File Offset: 0x001C7970
		// (set) Token: 0x0600655E RID: 25950 RVA: 0x0002FF25 File Offset: 0x0002E125
		public unsafe List<Vector3> velocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004522 RID: 17698
		private static readonly IntPtr NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH;

		// Token: 0x04004523 RID: 17699
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04004524 RID: 17700
		private static readonly IntPtr NativeFieldInfoPtr_ForceMultiplier;

		// Token: 0x04004525 RID: 17701
		private static readonly IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04004526 RID: 17702
		private static readonly IntPtr NativeFieldInfoPtr_onImpacted;

		// Token: 0x04004527 RID: 17703
		private static readonly IntPtr NativeFieldInfoPtr__averageVelocity_k__BackingField;

		// Token: 0x04004528 RID: 17704
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistory;

		// Token: 0x04004529 RID: 17705
		private static readonly IntPtr NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0;

		// Token: 0x0400452A RID: 17706
		private static readonly IntPtr NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0;

		// Token: 0x0400452B RID: 17707
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400452C RID: 17708
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400452D RID: 17709
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400452E RID: 17710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
