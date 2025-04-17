using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044F RID: 1103
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x06005FB8 RID: 24504 RVA: 0x001B7134 File Offset: 0x001B5334
		// Note: this type is marked as 'beforefieldinit'.
		static AverageAcceleration()
		{
			Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AverageAcceleration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr);
			AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "<Acceleration>k__BackingField");
			AverageAcceleration.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "Rb");
			AverageAcceleration.NativeFieldInfoPtr_TimeWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "TimeWindow");
			AverageAcceleration.NativeFieldInfoPtr_accelerations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "accelerations");
			AverageAcceleration.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "currentIndex");
			AverageAcceleration.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "timer");
			AverageAcceleration.NativeFieldInfoPtr_prevVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "prevVelocity");
			AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675508);
			AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675509);
			AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675510);
			AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675511);
			AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675512);
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x001B7254 File Offset: 0x001B5454
		// (set) Token: 0x06005FBA RID: 24506 RVA: 0x001B7290 File Offset: 0x001B5490
		public unsafe Vector3 Acceleration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x001B72D0 File Offset: 0x001B54D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198551, XrefRangeEnd = 198572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x001B7304 File Offset: 0x001B5504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198572, XrefRangeEnd = 198582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x001B7338 File Offset: 0x001B5538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198582, XrefRangeEnd = 198585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AverageAcceleration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x0002D280 File Offset: 0x0002B480
		public AverageAcceleration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06005FBF RID: 24511 RVA: 0x001B7374 File Offset: 0x001B5574
		// (set) Token: 0x06005FC0 RID: 24512 RVA: 0x0002D289 File Offset: 0x0002B489
		public unsafe Vector3 _Acceleration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x001B739C File Offset: 0x001B559C
		// (set) Token: 0x06005FC2 RID: 24514 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x001B73CC File Offset: 0x001B55CC
		// (set) Token: 0x06005FC4 RID: 24516 RVA: 0x0002D2C3 File Offset: 0x0002B4C3
		public unsafe float TimeWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow)) = value;
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x001B73F4 File Offset: 0x001B55F4
		// (set) Token: 0x06005FC6 RID: 24518 RVA: 0x0002D2DE File Offset: 0x0002B4DE
		public unsafe Il2CppStructArray<Vector3> accelerations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x001B7424 File Offset: 0x001B5624
		// (set) Token: 0x06005FC8 RID: 24520 RVA: 0x0002D2FD File Offset: 0x0002B4FD
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06005FC9 RID: 24521 RVA: 0x001B744C File Offset: 0x001B564C
		// (set) Token: 0x06005FCA RID: 24522 RVA: 0x0002D318 File Offset: 0x0002B518
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06005FCB RID: 24523 RVA: 0x001B7474 File Offset: 0x001B5674
		// (set) Token: 0x06005FCC RID: 24524 RVA: 0x0002D333 File Offset: 0x0002B533
		public unsafe Vector3 prevVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity)) = value;
			}
		}

		// Token: 0x04004166 RID: 16742
		private static readonly IntPtr NativeFieldInfoPtr__Acceleration_k__BackingField;

		// Token: 0x04004167 RID: 16743
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04004168 RID: 16744
		private static readonly IntPtr NativeFieldInfoPtr_TimeWindow;

		// Token: 0x04004169 RID: 16745
		private static readonly IntPtr NativeFieldInfoPtr_accelerations;

		// Token: 0x0400416A RID: 16746
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x0400416B RID: 16747
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x0400416C RID: 16748
		private static readonly IntPtr NativeFieldInfoPtr_prevVelocity;

		// Token: 0x0400416D RID: 16749
		private static readonly IntPtr NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0;

		// Token: 0x0400416E RID: 16750
		private static readonly IntPtr NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0;

		// Token: 0x0400416F RID: 16751
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004170 RID: 16752
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004171 RID: 16753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
