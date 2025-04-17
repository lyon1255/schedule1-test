using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A6 RID: 422
	public class SkateboardAnimation : MonoBehaviour
	{
		// Token: 0x06002351 RID: 9041 RVA: 0x000DE84C File Offset: 0x000DCA4C
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardAnimation()
		{
			Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr);
			SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "JumpCrouchAmount");
			SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "CrouchSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "ArmLiftRate");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisMaxRotation");
			SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "HandsMaxRotation");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisOffsetBlend");
			SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "VerticalMomentumMultiplier");
			SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "VerticalMomentumOffsetClamp");
			SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "MomentumMoveSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "IKBlendChangeRate");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnimationDuration");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnimationSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisContainerAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineContainerAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineAlignment_Hunched");
			SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftFootAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightFootAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftLegBendTarget");
			SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightLegBendTarget");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "AvatarFaceTarget");
			SkateboardAnimation.NativeFieldInfoPtr_HandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "HandContainer");
			SkateboardAnimation.NativeFieldInfoPtr_IKAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "IKAnimation");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandLoweredAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandRaisedAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandLoweredAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandRaisedAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "board");
			SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentCrouchShift");
			SkateboardAnimation.NativeFieldInfoPtr_targetArmLift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "targetArmLift");
			SkateboardAnimation.NativeFieldInfoPtr_currentArmLift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentArmLift");
			SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "pelvisDefaultRotation");
			SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "pelvisDefaultPosition");
			SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "spineDefaultPosition");
			SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentMomentumOffset");
			SkateboardAnimation.NativeFieldInfoPtr_ikBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "ikBlend");
			SkateboardAnimation.NativeFieldInfoPtr_alignmentSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "alignmentSets");
			SkateboardAnimation.NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667256);
			SkateboardAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667257);
			SkateboardAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667258);
			SkateboardAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667259);
			SkateboardAnimation.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667260);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667261);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667262);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateArmLift_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667263);
			SkateboardAnimation.NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667264);
			SkateboardAnimation.NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667265);
			SkateboardAnimation.NativeMethodInfoPtr_OnPushStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667266);
			SkateboardAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667267);
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000DEC8C File Offset: 0x000DCE8C
		public unsafe float CurrentCrouchShift
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000DECC8 File Offset: 0x000DCEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112416, XrefRangeEnd = 112488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000DECFC File Offset: 0x000DCEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112488, XrefRangeEnd = 112489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x000DED30 File Offset: 0x000DCF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112489, XrefRangeEnd = 112492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x000DED64 File Offset: 0x000DCF64
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x000DED98 File Offset: 0x000DCF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112519, RefRangeEnd = 112520, XrefRangeStart = 112492, XrefRangeEnd = 112519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIKBlend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x000DEDCC File Offset: 0x000DCFCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112535, RefRangeEnd = 112536, XrefRangeStart = 112520, XrefRangeEnd = 112535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBodyAlignment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000DEE00 File Offset: 0x000DD000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112559, RefRangeEnd = 112560, XrefRangeStart = 112536, XrefRangeEnd = 112559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArmLift()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateArmLift_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x000DEE34 File Offset: 0x000DD034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112572, RefRangeEnd = 112573, XrefRangeStart = 112560, XrefRangeEnd = 112572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePelvisRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x000DEE68 File Offset: 0x000DD068
		[CallerCount(0)]
		public unsafe void SetArmLift(float lift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000DEEA8 File Offset: 0x000DD0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112573, XrefRangeEnd = 112581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPushStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_OnPushStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000DEEDC File Offset: 0x000DD0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112581, XrefRangeEnd = 112589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00013C60 File Offset: 0x00011E60
		public SkateboardAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x000DEF18 File Offset: 0x000DD118
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x00013C69 File Offset: 0x00011E69
		public unsafe float JumpCrouchAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x000DEF40 File Offset: 0x000DD140
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x00013C84 File Offset: 0x00011E84
		public unsafe float CrouchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed)) = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x000DEF68 File Offset: 0x000DD168
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x00013C9F File Offset: 0x00011E9F
		public unsafe float ArmLiftRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate)) = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000DEF90 File Offset: 0x000DD190
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x00013CBA File Offset: 0x00011EBA
		public unsafe float PelvisMaxRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation)) = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000DEFB8 File Offset: 0x000DD1B8
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x00013CD5 File Offset: 0x00011ED5
		public unsafe float HandsMaxRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation)) = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000DEFE0 File Offset: 0x000DD1E0
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x00013CF0 File Offset: 0x00011EF0
		public unsafe float PelvisOffsetBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend)) = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000DF008 File Offset: 0x000DD208
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x00013D0B File Offset: 0x00011F0B
		public unsafe float VerticalMomentumMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier)) = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000DF030 File Offset: 0x000DD230
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x00013D26 File Offset: 0x00011F26
		public unsafe float VerticalMomentumOffsetClamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp)) = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000DF058 File Offset: 0x000DD258
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x00013D41 File Offset: 0x00011F41
		public unsafe float MomentumMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed)) = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000DF080 File Offset: 0x000DD280
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x00013D5C File Offset: 0x00011F5C
		public unsafe float IKBlendChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate)) = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000DF0A8 File Offset: 0x000DD2A8
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x00013D77 File Offset: 0x00011F77
		public unsafe float PushAnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration)) = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000DF0D0 File Offset: 0x000DD2D0
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x00013D92 File Offset: 0x00011F92
		public unsafe float PushAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed)) = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000DF0F8 File Offset: 0x000DD2F8
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x00013DAD File Offset: 0x00011FAD
		public unsafe SkateboardAnimation.AlignmentSet PelvisContainerAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000DF128 File Offset: 0x000DD328
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x00013DCC File Offset: 0x00011FCC
		public unsafe SkateboardAnimation.AlignmentSet PelvisAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000DF158 File Offset: 0x000DD358
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x00013DEB File Offset: 0x00011FEB
		public unsafe SkateboardAnimation.AlignmentSet SpineContainerAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000DF188 File Offset: 0x000DD388
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x00013E0A File Offset: 0x0001200A
		public unsafe SkateboardAnimation.AlignmentSet SpineAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000DF1B8 File Offset: 0x000DD3B8
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x00013E29 File Offset: 0x00012029
		public unsafe Transform SpineAlignment_Hunched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000DF1E8 File Offset: 0x000DD3E8
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x00013E48 File Offset: 0x00012048
		public unsafe SkateboardAnimation.AlignmentSet LeftFootAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x000DF218 File Offset: 0x000DD418
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x00013E67 File Offset: 0x00012067
		public unsafe SkateboardAnimation.AlignmentSet RightFootAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000DF248 File Offset: 0x000DD448
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x00013E86 File Offset: 0x00012086
		public unsafe SkateboardAnimation.AlignmentSet LeftLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000DF278 File Offset: 0x000DD478
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x00013EA5 File Offset: 0x000120A5
		public unsafe SkateboardAnimation.AlignmentSet RightLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000DF2A8 File Offset: 0x000DD4A8
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x00013EC4 File Offset: 0x000120C4
		public unsafe SkateboardAnimation.AlignmentSet LeftHandAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000DF2D8 File Offset: 0x000DD4D8
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x00013EE3 File Offset: 0x000120E3
		public unsafe SkateboardAnimation.AlignmentSet RightHandAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000DF308 File Offset: 0x000DD508
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x00013F02 File Offset: 0x00012102
		public unsafe Transform AvatarFaceTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000DF338 File Offset: 0x000DD538
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x00013F21 File Offset: 0x00012121
		public unsafe Transform HandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000DF368 File Offset: 0x000DD568
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00013F40 File Offset: 0x00012140
		public unsafe Animation IKAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000DF398 File Offset: 0x000DD598
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x00013F5F File Offset: 0x0001215F
		public unsafe SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x00013F7E File Offset: 0x0001217E
		public unsafe SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x000DF3F8 File Offset: 0x000DD5F8
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x00013F9D File Offset: 0x0001219D
		public unsafe SkateboardAnimation.AlignmentSet RightHandLoweredAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x000DF428 File Offset: 0x000DD628
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x00013FBC File Offset: 0x000121BC
		public unsafe SkateboardAnimation.AlignmentSet RightHandRaisedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000DF458 File Offset: 0x000DD658
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x00013FDB File Offset: 0x000121DB
		public unsafe Skateboard board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000DF488 File Offset: 0x000DD688
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x00013FFA File Offset: 0x000121FA
		public unsafe float currentCrouchShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift)) = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x000DF4B0 File Offset: 0x000DD6B0
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x00014015 File Offset: 0x00012215
		public unsafe float targetArmLift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_targetArmLift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_targetArmLift)) = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x000DF4D8 File Offset: 0x000DD6D8
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x00014030 File Offset: 0x00012230
		public unsafe float currentArmLift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentArmLift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentArmLift)) = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000DF500 File Offset: 0x000DD700
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x0001404B File Offset: 0x0001224B
		public unsafe Quaternion pelvisDefaultRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation)) = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000DF528 File Offset: 0x000DD728
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x00014066 File Offset: 0x00012266
		public unsafe Vector3 pelvisDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition)) = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000DF550 File Offset: 0x000DD750
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x00014081 File Offset: 0x00012281
		public unsafe Vector3 spineDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition)) = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000DF578 File Offset: 0x000DD778
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x0001409C File Offset: 0x0001229C
		public unsafe float currentMomentumOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset)) = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x000DF5A0 File Offset: 0x000DD7A0
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x000140B7 File Offset: 0x000122B7
		public unsafe float ikBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ikBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ikBlend)) = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x000DF5C8 File Offset: 0x000DD7C8
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x000140D2 File Offset: 0x000122D2
		public unsafe List<SkateboardAnimation.AlignmentSet> alignmentSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_alignmentSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkateboardAnimation.AlignmentSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_alignmentSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeFieldInfoPtr_JumpCrouchAmount;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeFieldInfoPtr_CrouchSpeed;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeFieldInfoPtr_ArmLiftRate;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeFieldInfoPtr_PelvisMaxRotation;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeFieldInfoPtr_HandsMaxRotation;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_PelvisOffsetBlend;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_VerticalMomentumMultiplier;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeFieldInfoPtr_VerticalMomentumOffsetClamp;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeFieldInfoPtr_MomentumMoveSpeed;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeFieldInfoPtr_IKBlendChangeRate;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeFieldInfoPtr_PushAnimationDuration;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeFieldInfoPtr_PushAnimationSpeed;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeFieldInfoPtr_PelvisContainerAlignment;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeFieldInfoPtr_PelvisAlignment;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeFieldInfoPtr_SpineContainerAlignment;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeFieldInfoPtr_SpineAlignment;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeFieldInfoPtr_SpineAlignment_Hunched;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeFieldInfoPtr_LeftFootAlignment;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeFieldInfoPtr_RightFootAlignment;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeFieldInfoPtr_LeftLegBendTarget;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeFieldInfoPtr_RightLegBendTarget;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandAlignment;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_RightHandAlignment;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeFieldInfoPtr_AvatarFaceTarget;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeFieldInfoPtr_HandContainer;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeFieldInfoPtr_IKAnimation;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandLoweredAlignment;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandRaisedAlignment;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeFieldInfoPtr_RightHandLoweredAlignment;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeFieldInfoPtr_RightHandRaisedAlignment;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeFieldInfoPtr_board;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_currentCrouchShift;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_targetArmLift;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeFieldInfoPtr_currentArmLift;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeFieldInfoPtr_pelvisDefaultRotation;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeFieldInfoPtr_pelvisDefaultPosition;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeFieldInfoPtr_spineDefaultPosition;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeFieldInfoPtr_currentMomentumOffset;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeFieldInfoPtr_ikBlend;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_alignmentSets;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArmLift_Private_Void_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_OnPushStart_Private_Void_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008C9 RID: 2249
		[Serializable]
		public class AlignmentSet : Il2CppSystem.Object
		{
			// Token: 0x0600C3D8 RID: 50136 RVA: 0x002FBD10 File Offset: 0x002F9F10
			// Note: this type is marked as 'beforefieldinit'.
			static AlignmentSet()
			{
				Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "AlignmentSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr);
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Transform");
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Default");
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Animated");
				SkateboardAnimation.AlignmentSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, 100667268);
			}

			// Token: 0x0600C3D9 RID: 50137 RVA: 0x002FBD8C File Offset: 0x002F9F8C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AlignmentSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.AlignmentSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3DA RID: 50138 RVA: 0x0005F535 File Offset: 0x0005D735
			public AlignmentSet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D25 RID: 15653
			// (get) Token: 0x0600C3DB RID: 50139 RVA: 0x002FBDC8 File Offset: 0x002F9FC8
			// (set) Token: 0x0600C3DC RID: 50140 RVA: 0x0005F53E File Offset: 0x0005D73E
			public unsafe Transform Transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D26 RID: 15654
			// (get) Token: 0x0600C3DD RID: 50141 RVA: 0x002FBDF8 File Offset: 0x002F9FF8
			// (set) Token: 0x0600C3DE RID: 50142 RVA: 0x0005F55D File Offset: 0x0005D75D
			public unsafe Transform Default
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D27 RID: 15655
			// (get) Token: 0x0600C3DF RID: 50143 RVA: 0x002FBE28 File Offset: 0x002FA028
			// (set) Token: 0x0600C3E0 RID: 50144 RVA: 0x0005F57C File Offset: 0x0005D77C
			public unsafe Transform Animated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084C1 RID: 33985
			private static readonly IntPtr NativeFieldInfoPtr_Transform;

			// Token: 0x040084C2 RID: 33986
			private static readonly IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x040084C3 RID: 33987
			private static readonly IntPtr NativeFieldInfoPtr_Animated;

			// Token: 0x040084C4 RID: 33988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
