using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060A RID: 1546
	public class AvatarFootstepDetector : MonoBehaviour
	{
		// Token: 0x060088AB RID: 34987 RVA: 0x0023F5BC File Offset: 0x0023D7BC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarFootstepDetector()
		{
			Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarFootstepDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr);
			AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "MAX_DETECTION_RANGE");
			AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "GROUND_DETECTION_RANGE");
			AvatarFootstepDetector.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "Avatar");
			AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "ReferencePoint");
			AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "LeftBone");
			AvatarFootstepDetector.NativeFieldInfoPtr_RightBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "RightBone");
			AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "StepThreshold");
			AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "GroundDetectionMask");
			AvatarFootstepDetector.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "leftDown");
			AvatarFootstepDetector.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "rightDown");
			AvatarFootstepDetector.NativeFieldInfoPtr_onStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "onStep");
			AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680342);
			AvatarFootstepDetector.NativeMethodInfoPtr_TriggerStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680343);
			AvatarFootstepDetector.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680344);
			AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680345);
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x0023F718 File Offset: 0x0023D918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252696, XrefRangeEnd = 252719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x0023F74C File Offset: 0x0023D94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252723, RefRangeEnd = 252724, XrefRangeStart = 252719, XrefRangeEnd = 252723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_TriggerStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x0023F780 File Offset: 0x0023D980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252736, RefRangeEnd = 252737, XrefRangeStart = 252724, XrefRangeEnd = 252736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x0023F7CC File Offset: 0x0023D9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252737, XrefRangeEnd = 252745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarFootstepDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x00041301 File Offset: 0x0003F501
		public AvatarFootstepDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x060088B1 RID: 34993 RVA: 0x0023F808 File Offset: 0x0023DA08
		// (set) Token: 0x060088B2 RID: 34994 RVA: 0x0004130A File Offset: 0x0003F50A
		public unsafe static float MAX_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x0023F824 File Offset: 0x0023DA24
		// (set) Token: 0x060088B4 RID: 34996 RVA: 0x00041318 File Offset: 0x0003F518
		public unsafe static float GROUND_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x0023F840 File Offset: 0x0023DA40
		// (set) Token: 0x060088B6 RID: 34998 RVA: 0x00041326 File Offset: 0x0003F526
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x060088B7 RID: 34999 RVA: 0x0023F870 File Offset: 0x0023DA70
		// (set) Token: 0x060088B8 RID: 35000 RVA: 0x00041345 File Offset: 0x0003F545
		public unsafe Transform ReferencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x0023F8A0 File Offset: 0x0023DAA0
		// (set) Token: 0x060088BA RID: 35002 RVA: 0x00041364 File Offset: 0x0003F564
		public unsafe Transform LeftBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x0023F8D0 File Offset: 0x0023DAD0
		// (set) Token: 0x060088BC RID: 35004 RVA: 0x00041383 File Offset: 0x0003F583
		public unsafe Transform RightBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_RightBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_RightBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x060088BD RID: 35005 RVA: 0x0023F900 File Offset: 0x0023DB00
		// (set) Token: 0x060088BE RID: 35006 RVA: 0x000413A2 File Offset: 0x0003F5A2
		public unsafe float StepThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold)) = value;
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x0023F928 File Offset: 0x0023DB28
		// (set) Token: 0x060088C0 RID: 35008 RVA: 0x000413BD File Offset: 0x0003F5BD
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x0023F950 File Offset: 0x0023DB50
		// (set) Token: 0x060088C2 RID: 35010 RVA: 0x000413D8 File Offset: 0x0003F5D8
		public unsafe bool leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x0023F978 File Offset: 0x0023DB78
		// (set) Token: 0x060088C4 RID: 35012 RVA: 0x000413F3 File Offset: 0x0003F5F3
		public unsafe bool rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x060088C5 RID: 35013 RVA: 0x0023F9A0 File Offset: 0x0023DBA0
		// (set) Token: 0x060088C6 RID: 35014 RVA: 0x0004140E File Offset: 0x0003F60E
		public unsafe UnityEvent<EMaterialType, float> onStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_onStep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EMaterialType, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_onStep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005CDE RID: 23774
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DETECTION_RANGE;

		// Token: 0x04005CDF RID: 23775
		private static readonly IntPtr NativeFieldInfoPtr_GROUND_DETECTION_RANGE;

		// Token: 0x04005CE0 RID: 23776
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005CE1 RID: 23777
		private static readonly IntPtr NativeFieldInfoPtr_ReferencePoint;

		// Token: 0x04005CE2 RID: 23778
		private static readonly IntPtr NativeFieldInfoPtr_LeftBone;

		// Token: 0x04005CE3 RID: 23779
		private static readonly IntPtr NativeFieldInfoPtr_RightBone;

		// Token: 0x04005CE4 RID: 23780
		private static readonly IntPtr NativeFieldInfoPtr_StepThreshold;

		// Token: 0x04005CE5 RID: 23781
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04005CE6 RID: 23782
		private static readonly IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x04005CE7 RID: 23783
		private static readonly IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x04005CE8 RID: 23784
		private static readonly IntPtr NativeFieldInfoPtr_onStep;

		// Token: 0x04005CE9 RID: 23785
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005CEA RID: 23786
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Public_Void_0;

		// Token: 0x04005CEB RID: 23787
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0;

		// Token: 0x04005CEC RID: 23788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
