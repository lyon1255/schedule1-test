using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060B RID: 1547
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x060088C7 RID: 35015 RVA: 0x0023F9D0 File Offset: 0x0023DBD0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarIKController()
		{
			Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarIKController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr);
			AvatarIKController.NativeFieldInfoPtr_BodyIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "BodyIK");
			AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultLeftLegBendTarget");
			AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultRightLegBendTarget");
			AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680346);
			AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680347);
			AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680348);
			AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680349);
			AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680350);
			AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680351);
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x0023FAB4 File Offset: 0x0023DCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252745, XrefRangeEnd = 252749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x0023FAE8 File Offset: 0x0023DCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252749, XrefRangeEnd = 252751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x0023FB1C File Offset: 0x0023DD1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252753, RefRangeEnd = 252755, XrefRangeStart = 252751, XrefRangeEnd = 252753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIKActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088CB RID: 35019 RVA: 0x0023FB5C File Offset: 0x0023DD5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252758, RefRangeEnd = 252759, XrefRangeStart = 252755, XrefRangeEnd = 252758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftLegTarget);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightLegTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x0023FBB0 File Offset: 0x0023DDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252762, RefRangeEnd = 252763, XrefRangeStart = 252759, XrefRangeEnd = 252762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetLegBendTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x0023FBE4 File Offset: 0x0023DDE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarIKController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x0004142D File Offset: 0x0003F62D
		public AvatarIKController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x0023FC20 File Offset: 0x0023DE20
		// (set) Token: 0x060088D0 RID: 35024 RVA: 0x00041436 File Offset: 0x0003F636
		public unsafe BipedIK BodyIK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BipedIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x0023FC50 File Offset: 0x0023DE50
		// (set) Token: 0x060088D2 RID: 35026 RVA: 0x00041455 File Offset: 0x0003F655
		public unsafe Transform defaultLeftLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x0023FC80 File Offset: 0x0023DE80
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x00041474 File Offset: 0x0003F674
		public unsafe Transform defaultRightLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005CED RID: 23789
		private static readonly IntPtr NativeFieldInfoPtr_BodyIK;

		// Token: 0x04005CEE RID: 23790
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftLegBendTarget;

		// Token: 0x04005CEF RID: 23791
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightLegBendTarget;

		// Token: 0x04005CF0 RID: 23792
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005CF1 RID: 23793
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005CF2 RID: 23794
		private static readonly IntPtr NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0;

		// Token: 0x04005CF3 RID: 23795
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0;

		// Token: 0x04005CF4 RID: 23796
		private static readonly IntPtr NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0;

		// Token: 0x04005CF5 RID: 23797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
