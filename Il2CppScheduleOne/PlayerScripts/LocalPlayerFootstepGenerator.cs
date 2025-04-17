using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E0 RID: 992
	public class LocalPlayerFootstepGenerator : MonoBehaviour
	{
		// Token: 0x06004CAC RID: 19628 RVA: 0x00170338 File Offset: 0x0016E538
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerFootstepGenerator()
		{
			Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "LocalPlayerFootstepGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr);
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "DistancePerStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "ReferencePoint");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "GroundDetectionMask");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "onStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "currentDistance");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "lastFramePosition");
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672764);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_TriggerStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672765);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672766);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672767);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x00170430 File Offset: 0x0016E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165886, XrefRangeEnd = 165911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x00170464 File Offset: 0x0016E664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165911, XrefRangeEnd = 165920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_TriggerStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x00170498 File Offset: 0x0016E698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165932, RefRangeEnd = 165934, XrefRangeStart = 165920, XrefRangeEnd = 165932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x001704E4 File Offset: 0x0016E6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165934, XrefRangeEnd = 165944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerFootstepGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00024DE1 File Offset: 0x00022FE1
		public LocalPlayerFootstepGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x00170520 File Offset: 0x0016E720
		// (set) Token: 0x06004CB3 RID: 19635 RVA: 0x00024DEA File Offset: 0x00022FEA
		public unsafe float DistancePerStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep)) = value;
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00170548 File Offset: 0x0016E748
		// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x00024E05 File Offset: 0x00023005
		public unsafe Transform ReferencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x00170578 File Offset: 0x0016E778
		// (set) Token: 0x06004CB7 RID: 19639 RVA: 0x00024E24 File Offset: 0x00023024
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x001705A0 File Offset: 0x0016E7A0
		// (set) Token: 0x06004CB9 RID: 19641 RVA: 0x00024E3F File Offset: 0x0002303F
		public unsafe UnityEvent<EMaterialType, float> onStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EMaterialType, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x001705D0 File Offset: 0x0016E7D0
		// (set) Token: 0x06004CBB RID: 19643 RVA: 0x00024E5E File Offset: 0x0002305E
		public unsafe float currentDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance)) = value;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x001705F8 File Offset: 0x0016E7F8
		// (set) Token: 0x06004CBD RID: 19645 RVA: 0x00024E79 File Offset: 0x00023079
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeFieldInfoPtr_DistancePerStep;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeFieldInfoPtr_ReferencePoint;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeFieldInfoPtr_onStep;

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeFieldInfoPtr_currentDistance;

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Public_Void_0;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
