using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Skating;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000609 RID: 1545
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x0600882F RID: 34863 RVA: 0x0023DE50 File Offset: 0x0023C050
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAnimation()
		{
			Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr);
			AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AnimationRangeSqr");
			AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "FrustrumCullMinDist");
			AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RunningAnimationSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffset");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffsetSqr");
			AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SITTING_OFFSET");
			AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SEAT_TIME");
			AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsCrouched>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<TimeSinceSitEnd>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<CurrentSeat>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<StandUpAnimationPlaying>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsAvatarCulled>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "DEBUG_MODE");
			AvatarAnimation.NativeFieldInfoPtr_framesActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "framesActive");
			AvatarAnimation.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animator");
			AvatarAnimation.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "HipBone");
			AvatarAnimation.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "Bones");
			AvatarAnimation.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "avatar");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_IKController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "IKController");
			AvatarAnimation.NativeFieldInfoPtr_GroundingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "GroundingMask");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromBackClipName");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromFrontClipName");
			AvatarAnimation.NativeFieldInfoPtr_UseImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "UseImpostor");
			AvatarAnimation.NativeFieldInfoPtr_AllowCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AllowCulling");
			AvatarAnimation.NativeFieldInfoPtr_onStandupStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupStart");
			AvatarAnimation.NativeFieldInfoPtr_onStandupDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupDone");
			AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onHeavyFlinch");
			AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standingBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromBackBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromFrontBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "ragdollBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpRoutine");
			AvatarAnimation.NativeFieldInfoPtr_seatRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "seatRoutine");
			AvatarAnimation.NativeFieldInfoPtr_activeSkateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "activeSkateboard");
			AvatarAnimation.NativeFieldInfoPtr_animationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animationEnabled");
			AvatarAnimation.NativeFieldInfoPtr_initialCullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "initialCullingMode");
			AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680283);
			AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680284);
			AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680285);
			AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680286);
			AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680287);
			AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680288);
			AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680289);
			AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680290);
			AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680291);
			AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680292);
			AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680293);
			AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680294);
			AvatarAnimation.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680295);
			AvatarAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680296);
			AvatarAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680297);
			AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680298);
			AvatarAnimation.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680299);
			AvatarAnimation.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680300);
			AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680301);
			AvatarAnimation.NativeMethodInfoPtr_SetDirection_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680302);
			AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680303);
			AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680304);
			AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680305);
			AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680306);
			AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680307);
			AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680308);
			AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680309);
			AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680310);
			AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680311);
			AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680312);
			AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680313);
			AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680314);
			AvatarAnimation.NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680315);
			AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680316);
			AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680317);
			AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680318);
			AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680319);
			AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680320);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680321);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680322);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680323);
			AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680324);
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x0023E4E8 File Offset: 0x0023C6E8
		// (set) Token: 0x06008831 RID: 34865 RVA: 0x0023E524 File Offset: 0x0023C724
		public unsafe bool IsCrouched
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x0023E564 File Offset: 0x0023C764
		public unsafe bool IsSeated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252125, RefRangeEnd = 252126, XrefRangeStart = 252121, XrefRangeEnd = 252125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x06008833 RID: 34867 RVA: 0x0023E5A0 File Offset: 0x0023C7A0
		// (set) Token: 0x06008834 RID: 34868 RVA: 0x0023E5DC File Offset: 0x0023C7DC
		public unsafe float TimeSinceSitEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x06008835 RID: 34869 RVA: 0x0023E61C File Offset: 0x0023C81C
		// (set) Token: 0x06008836 RID: 34870 RVA: 0x0023E65C File Offset: 0x0023C85C
		public unsafe AvatarSeat CurrentSeat
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x06008837 RID: 34871 RVA: 0x0023E6A0 File Offset: 0x0023C8A0
		// (set) Token: 0x06008838 RID: 34872 RVA: 0x0023E6DC File Offset: 0x0023C8DC
		public unsafe bool StandUpAnimationPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x06008839 RID: 34873 RVA: 0x0023E71C File Offset: 0x0023C91C
		// (set) Token: 0x0600883A RID: 34874 RVA: 0x0023E758 File Offset: 0x0023C958
		public unsafe bool IsAvatarCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57500, RefRangeEnd = 57501, XrefRangeStart = 57500, XrefRangeEnd = 57501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x0023E798 File Offset: 0x0023C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252126, XrefRangeEnd = 252183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x0023E7D4 File Offset: 0x0023C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252183, XrefRangeEnd = 252245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x0023E810 File Offset: 0x0023CA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252245, XrefRangeEnd = 252263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x0023E844 File Offset: 0x0023CA44
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x0023E878 File Offset: 0x0023CA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252263, XrefRangeEnd = 252287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x0023E8AC File Offset: 0x0023CAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252287, XrefRangeEnd = 252288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x0023E8E0 File Offset: 0x0023CAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252288, XrefRangeEnd = 252298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x0023E914 File Offset: 0x0023CB14
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 252330, RefRangeEnd = 252339, XrefRangeStart = 252298, XrefRangeEnd = 252330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimationActive(bool forceWriteIdle = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forceWriteIdle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x0023E954 File Offset: 0x0023CB54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 252343, RefRangeEnd = 252347, XrefRangeStart = 252339, XrefRangeEnd = 252343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(float dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetDirection_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x0023E994 File Offset: 0x0023CB94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252351, RefRangeEnd = 252353, XrefRangeStart = 252347, XrefRangeEnd = 252351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStrafe(float strafe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x0023E9D4 File Offset: 0x0023CBD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252357, RefRangeEnd = 252359, XrefRangeStart = 252353, XrefRangeEnd = 252357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeAirborne(float airbone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref airbone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x0023EA14 File Offset: 0x0023CC14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 252363, RefRangeEnd = 252368, XrefRangeStart = 252359, XrefRangeEnd = 252363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x0023EA54 File Offset: 0x0023CC54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252372, RefRangeEnd = 252374, XrefRangeStart = 252368, XrefRangeEnd = 252372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrounded(bool grounded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref grounded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x0023EA94 File Offset: 0x0023CC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252378, RefRangeEnd = 252380, XrefRangeStart = 252374, XrefRangeEnd = 252378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008849 RID: 34889 RVA: 0x0023EAC8 File Offset: 0x0023CCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252380, XrefRangeEnd = 252381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600884A RID: 34890 RVA: 0x0023EB08 File Offset: 0x0023CD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252403, RefRangeEnd = 252405, XrefRangeStart = 252381, XrefRangeEnd = 252403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forceDirection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600884B RID: 34891 RVA: 0x0023EB54 File Offset: 0x0023CD54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252426, RefRangeEnd = 252427, XrefRangeStart = 252405, XrefRangeEnd = 252426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStandUpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x0023EB88 File Offset: 0x0023CD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252427, XrefRangeEnd = 252452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x0023EBE4 File Offset: 0x0023CDE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252489, RefRangeEnd = 252490, XrefRangeStart = 252452, XrefRangeEnd = 252489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignPositionToHips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x0023EC18 File Offset: 0x0023CE18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252494, RefRangeEnd = 252496, XrefRangeStart = 252490, XrefRangeEnd = 252494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGetUpFromBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x0023EC54 File Offset: 0x0023CE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252499, RefRangeEnd = 252501, XrefRangeStart = 252496, XrefRangeEnd = 252499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateBoneTransforms(Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x0023EC98 File Offset: 0x0023CE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252501, XrefRangeEnd = 252515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pose> GetBoneTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pose>>(intPtr3) : null;
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x0023ECD8 File Offset: 0x0023CED8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 252536, RefRangeEnd = 252540, XrefRangeStart = 252515, XrefRangeEnd = 252536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateAnimationStartBoneTransforms(string clipName, Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clipName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x0023ED2C File Offset: 0x0023CF2C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 252543, RefRangeEnd = 252557, XrefRangeStart = 252540, XrefRangeEnd = 252543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x0023ED70 File Offset: 0x0023CF70
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 252559, RefRangeEnd = 252567, XrefRangeStart = 252557, XrefRangeEnd = 252559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x0023EDB4 File Offset: 0x0023CFB4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 252570, RefRangeEnd = 252593, XrefRangeStart = 252567, XrefRangeEnd = 252570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x0023EE04 File Offset: 0x0023D004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252647, RefRangeEnd = 252648, XrefRangeStart = 252593, XrefRangeEnd = 252647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008856 RID: 34902 RVA: 0x0023EE48 File Offset: 0x0023D048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252648, XrefRangeEnd = 252674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardMounted(Skateboard board)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x0023EE8C File Offset: 0x0023D08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252674, XrefRangeEnd = 252690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardDismounted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x0023EEC0 File Offset: 0x0023D0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252690, XrefRangeEnd = 252695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x0023EEF4 File Offset: 0x0023D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252695, XrefRangeEnd = 252696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x00040EC3 File Offset: 0x0003F0C3
		public AvatarAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600885B RID: 34907 RVA: 0x0023EF30 File Offset: 0x0023D130
		// (set) Token: 0x0600885C RID: 34908 RVA: 0x00040ECC File Offset: 0x0003F0CC
		public unsafe static float AnimationRangeSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr, (void*)(&value));
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600885D RID: 34909 RVA: 0x0023EF4C File Offset: 0x0023D14C
		// (set) Token: 0x0600885E RID: 34910 RVA: 0x00040EDA File Offset: 0x0003F0DA
		public unsafe static float FrustrumCullMinDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&value));
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x0023EF68 File Offset: 0x0023D168
		// (set) Token: 0x06008860 RID: 34912 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		public unsafe static float RunningAnimationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06008861 RID: 34913 RVA: 0x0023EF84 File Offset: 0x0023D184
		// (set) Token: 0x06008862 RID: 34914 RVA: 0x00040EF6 File Offset: 0x0003F0F6
		public unsafe static float MaxBoneOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&value));
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x06008863 RID: 34915 RVA: 0x0023EFA0 File Offset: 0x0023D1A0
		// (set) Token: 0x06008864 RID: 34916 RVA: 0x00040F04 File Offset: 0x0003F104
		public unsafe static float MaxBoneOffsetSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&value));
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x06008865 RID: 34917 RVA: 0x0023EFBC File Offset: 0x0023D1BC
		// (set) Token: 0x06008866 RID: 34918 RVA: 0x00040F12 File Offset: 0x0003F112
		public unsafe static Vector3 SITTING_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x0023EFD8 File Offset: 0x0023D1D8
		// (set) Token: 0x06008868 RID: 34920 RVA: 0x00040F20 File Offset: 0x0003F120
		public unsafe static float SEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06008869 RID: 34921 RVA: 0x0023EFF4 File Offset: 0x0023D1F4
		// (set) Token: 0x0600886A RID: 34922 RVA: 0x00040F2E File Offset: 0x0003F12E
		public unsafe bool _IsCrouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600886B RID: 34923 RVA: 0x0023F01C File Offset: 0x0023D21C
		// (set) Token: 0x0600886C RID: 34924 RVA: 0x00040F49 File Offset: 0x0003F149
		public unsafe float _TimeSinceSitEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField)) = value;
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600886D RID: 34925 RVA: 0x0023F044 File Offset: 0x0023D244
		// (set) Token: 0x0600886E RID: 34926 RVA: 0x00040F64 File Offset: 0x0003F164
		public unsafe AvatarSeat _CurrentSeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600886F RID: 34927 RVA: 0x0023F074 File Offset: 0x0023D274
		// (set) Token: 0x06008870 RID: 34928 RVA: 0x00040F83 File Offset: 0x0003F183
		public unsafe bool _StandUpAnimationPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06008871 RID: 34929 RVA: 0x0023F09C File Offset: 0x0023D29C
		// (set) Token: 0x06008872 RID: 34930 RVA: 0x00040F9E File Offset: 0x0003F19E
		public unsafe bool _IsAvatarCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06008873 RID: 34931 RVA: 0x0023F0C4 File Offset: 0x0023D2C4
		// (set) Token: 0x06008874 RID: 34932 RVA: 0x00040FB9 File Offset: 0x0003F1B9
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06008875 RID: 34933 RVA: 0x0023F0EC File Offset: 0x0023D2EC
		// (set) Token: 0x06008876 RID: 34934 RVA: 0x00040FD4 File Offset: 0x0003F1D4
		public unsafe int framesActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_framesActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_framesActive)) = value;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06008877 RID: 34935 RVA: 0x0023F114 File Offset: 0x0023D314
		// (set) Token: 0x06008878 RID: 34936 RVA: 0x00040FEF File Offset: 0x0003F1EF
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x06008879 RID: 34937 RVA: 0x0023F144 File Offset: 0x0023D344
		// (set) Token: 0x0600887A RID: 34938 RVA: 0x0004100E File Offset: 0x0003F20E
		public unsafe Transform HipBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600887B RID: 34939 RVA: 0x0023F174 File Offset: 0x0023D374
		// (set) Token: 0x0600887C RID: 34940 RVA: 0x0004102D File Offset: 0x0003F22D
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600887D RID: 34941 RVA: 0x0023F1A4 File Offset: 0x0023D3A4
		// (set) Token: 0x0600887E RID: 34942 RVA: 0x0004104C File Offset: 0x0003F24C
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600887F RID: 34943 RVA: 0x0023F1D4 File Offset: 0x0023D3D4
		// (set) Token: 0x06008880 RID: 34944 RVA: 0x0004106B File Offset: 0x0003F26B
		public unsafe Transform LeftHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x06008881 RID: 34945 RVA: 0x0023F204 File Offset: 0x0023D404
		// (set) Token: 0x06008882 RID: 34946 RVA: 0x0004108A File Offset: 0x0003F28A
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x06008883 RID: 34947 RVA: 0x0023F234 File Offset: 0x0023D434
		// (set) Token: 0x06008884 RID: 34948 RVA: 0x000410A9 File Offset: 0x0003F2A9
		public unsafe Transform RightHandAlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x06008885 RID: 34949 RVA: 0x0023F264 File Offset: 0x0023D464
		// (set) Token: 0x06008886 RID: 34950 RVA: 0x000410C8 File Offset: 0x0003F2C8
		public unsafe Transform LeftHandAlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06008887 RID: 34951 RVA: 0x0023F294 File Offset: 0x0023D494
		// (set) Token: 0x06008888 RID: 34952 RVA: 0x000410E7 File Offset: 0x0003F2E7
		public unsafe AvatarIKController IKController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarIKController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x06008889 RID: 34953 RVA: 0x0023F2C4 File Offset: 0x0023D4C4
		// (set) Token: 0x0600888A RID: 34954 RVA: 0x00041106 File Offset: 0x0003F306
		public unsafe LayerMask GroundingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask)) = value;
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x0023F2EC File Offset: 0x0023D4EC
		// (set) Token: 0x0600888C RID: 34956 RVA: 0x00041121 File Offset: 0x0003F321
		public unsafe string StandUpFromBackClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600888D RID: 34957 RVA: 0x0023F314 File Offset: 0x0023D514
		// (set) Token: 0x0600888E RID: 34958 RVA: 0x00041140 File Offset: 0x0003F340
		public unsafe string StandUpFromFrontClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600888F RID: 34959 RVA: 0x0023F33C File Offset: 0x0023D53C
		// (set) Token: 0x06008890 RID: 34960 RVA: 0x0004115F File Offset: 0x0003F35F
		public unsafe bool UseImpostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_UseImpostor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_UseImpostor)) = value;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x06008891 RID: 34961 RVA: 0x0023F364 File Offset: 0x0023D564
		// (set) Token: 0x06008892 RID: 34962 RVA: 0x0004117A File Offset: 0x0003F37A
		public unsafe bool AllowCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling)) = value;
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x06008893 RID: 34963 RVA: 0x0023F38C File Offset: 0x0023D58C
		// (set) Token: 0x06008894 RID: 34964 RVA: 0x00041195 File Offset: 0x0003F395
		public unsafe UnityEvent onStandupStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x06008895 RID: 34965 RVA: 0x0023F3BC File Offset: 0x0023D5BC
		// (set) Token: 0x06008896 RID: 34966 RVA: 0x000411B4 File Offset: 0x0003F3B4
		public unsafe UnityEvent onStandupDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x06008897 RID: 34967 RVA: 0x0023F3EC File Offset: 0x0023D5EC
		// (set) Token: 0x06008898 RID: 34968 RVA: 0x000411D3 File Offset: 0x0003F3D3
		public unsafe UnityEvent onHeavyFlinch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x06008899 RID: 34969 RVA: 0x0023F41C File Offset: 0x0023D61C
		// (set) Token: 0x0600889A RID: 34970 RVA: 0x000411F2 File Offset: 0x0003F3F2
		public unsafe Il2CppReferenceArray<BoneTransform> standingBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600889B RID: 34971 RVA: 0x0023F44C File Offset: 0x0023D64C
		// (set) Token: 0x0600889C RID: 34972 RVA: 0x00041211 File Offset: 0x0003F411
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromBackBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x0023F47C File Offset: 0x0023D67C
		// (set) Token: 0x0600889E RID: 34974 RVA: 0x00041230 File Offset: 0x0003F430
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromFrontBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600889F RID: 34975 RVA: 0x0023F4AC File Offset: 0x0023D6AC
		// (set) Token: 0x060088A0 RID: 34976 RVA: 0x0004124F File Offset: 0x0003F44F
		public unsafe Il2CppReferenceArray<BoneTransform> ragdollBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x0023F4DC File Offset: 0x0023D6DC
		// (set) Token: 0x060088A2 RID: 34978 RVA: 0x0004126E File Offset: 0x0003F46E
		public unsafe Coroutine standUpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x0023F50C File Offset: 0x0023D70C
		// (set) Token: 0x060088A4 RID: 34980 RVA: 0x0004128D File Offset: 0x0003F48D
		public unsafe Coroutine seatRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x060088A5 RID: 34981 RVA: 0x0023F53C File Offset: 0x0023D73C
		// (set) Token: 0x060088A6 RID: 34982 RVA: 0x000412AC File Offset: 0x0003F4AC
		public unsafe Skateboard activeSkateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x060088A7 RID: 34983 RVA: 0x0023F56C File Offset: 0x0023D76C
		// (set) Token: 0x060088A8 RID: 34984 RVA: 0x000412CB File Offset: 0x0003F4CB
		public unsafe bool animationEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled)) = value;
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x060088A9 RID: 34985 RVA: 0x0023F594 File Offset: 0x0023D794
		// (set) Token: 0x060088AA RID: 34986 RVA: 0x000412E6 File Offset: 0x0003F4E6
		public unsafe AnimatorCullingMode initialCullingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_initialCullingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_initialCullingMode)) = value;
			}
		}

		// Token: 0x04005C8C RID: 23692
		private static readonly IntPtr NativeFieldInfoPtr_AnimationRangeSqr;

		// Token: 0x04005C8D RID: 23693
		private static readonly IntPtr NativeFieldInfoPtr_FrustrumCullMinDist;

		// Token: 0x04005C8E RID: 23694
		private static readonly IntPtr NativeFieldInfoPtr_RunningAnimationSpeed;

		// Token: 0x04005C8F RID: 23695
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoneOffset;

		// Token: 0x04005C90 RID: 23696
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoneOffsetSqr;

		// Token: 0x04005C91 RID: 23697
		private static readonly IntPtr NativeFieldInfoPtr_SITTING_OFFSET;

		// Token: 0x04005C92 RID: 23698
		private static readonly IntPtr NativeFieldInfoPtr_SEAT_TIME;

		// Token: 0x04005C93 RID: 23699
		private static readonly IntPtr NativeFieldInfoPtr__IsCrouched_k__BackingField;

		// Token: 0x04005C94 RID: 23700
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField;

		// Token: 0x04005C95 RID: 23701
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSeat_k__BackingField;

		// Token: 0x04005C96 RID: 23702
		private static readonly IntPtr NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField;

		// Token: 0x04005C97 RID: 23703
		private static readonly IntPtr NativeFieldInfoPtr__IsAvatarCulled_k__BackingField;

		// Token: 0x04005C98 RID: 23704
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04005C99 RID: 23705
		private static readonly IntPtr NativeFieldInfoPtr_framesActive;

		// Token: 0x04005C9A RID: 23706
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04005C9B RID: 23707
		private static readonly IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04005C9C RID: 23708
		private static readonly IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04005C9D RID: 23709
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005C9E RID: 23710
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandContainer;

		// Token: 0x04005C9F RID: 23711
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x04005CA0 RID: 23712
		private static readonly IntPtr NativeFieldInfoPtr_RightHandAlignmentPoint;

		// Token: 0x04005CA1 RID: 23713
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandAlignmentPoint;

		// Token: 0x04005CA2 RID: 23714
		private static readonly IntPtr NativeFieldInfoPtr_IKController;

		// Token: 0x04005CA3 RID: 23715
		private static readonly IntPtr NativeFieldInfoPtr_GroundingMask;

		// Token: 0x04005CA4 RID: 23716
		private static readonly IntPtr NativeFieldInfoPtr_StandUpFromBackClipName;

		// Token: 0x04005CA5 RID: 23717
		private static readonly IntPtr NativeFieldInfoPtr_StandUpFromFrontClipName;

		// Token: 0x04005CA6 RID: 23718
		private static readonly IntPtr NativeFieldInfoPtr_UseImpostor;

		// Token: 0x04005CA7 RID: 23719
		private static readonly IntPtr NativeFieldInfoPtr_AllowCulling;

		// Token: 0x04005CA8 RID: 23720
		private static readonly IntPtr NativeFieldInfoPtr_onStandupStart;

		// Token: 0x04005CA9 RID: 23721
		private static readonly IntPtr NativeFieldInfoPtr_onStandupDone;

		// Token: 0x04005CAA RID: 23722
		private static readonly IntPtr NativeFieldInfoPtr_onHeavyFlinch;

		// Token: 0x04005CAB RID: 23723
		private static readonly IntPtr NativeFieldInfoPtr_standingBoneTransforms;

		// Token: 0x04005CAC RID: 23724
		private static readonly IntPtr NativeFieldInfoPtr_standUpFromBackBoneTransforms;

		// Token: 0x04005CAD RID: 23725
		private static readonly IntPtr NativeFieldInfoPtr_standUpFromFrontBoneTransforms;

		// Token: 0x04005CAE RID: 23726
		private static readonly IntPtr NativeFieldInfoPtr_ragdollBoneTransforms;

		// Token: 0x04005CAF RID: 23727
		private static readonly IntPtr NativeFieldInfoPtr_standUpRoutine;

		// Token: 0x04005CB0 RID: 23728
		private static readonly IntPtr NativeFieldInfoPtr_seatRoutine;

		// Token: 0x04005CB1 RID: 23729
		private static readonly IntPtr NativeFieldInfoPtr_activeSkateboard;

		// Token: 0x04005CB2 RID: 23730
		private static readonly IntPtr NativeFieldInfoPtr_animationEnabled;

		// Token: 0x04005CB3 RID: 23731
		private static readonly IntPtr NativeFieldInfoPtr_initialCullingMode;

		// Token: 0x04005CB4 RID: 23732
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0;

		// Token: 0x04005CB5 RID: 23733
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04005CB6 RID: 23734
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0;

		// Token: 0x04005CB7 RID: 23735
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0;

		// Token: 0x04005CB8 RID: 23736
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0;

		// Token: 0x04005CB9 RID: 23737
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0;

		// Token: 0x04005CBA RID: 23738
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0;

		// Token: 0x04005CBB RID: 23739
		private static readonly IntPtr NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0;

		// Token: 0x04005CBC RID: 23740
		private static readonly IntPtr NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04005CBD RID: 23741
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0;

		// Token: 0x04005CBE RID: 23742
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0;

		// Token: 0x04005CBF RID: 23743
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005CC0 RID: 23744
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04005CC1 RID: 23745
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005CC2 RID: 23746
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005CC3 RID: 23747
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005CC4 RID: 23748
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0;

		// Token: 0x04005CC5 RID: 23749
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04005CC6 RID: 23750
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0;

		// Token: 0x04005CC7 RID: 23751
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Single_0;

		// Token: 0x04005CC8 RID: 23752
		private static readonly IntPtr NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0;

		// Token: 0x04005CC9 RID: 23753
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0;

		// Token: 0x04005CCA RID: 23754
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x04005CCB RID: 23755
		private static readonly IntPtr NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0;

		// Token: 0x04005CCC RID: 23756
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x04005CCD RID: 23757
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0;

		// Token: 0x04005CCE RID: 23758
		private static readonly IntPtr NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0;

		// Token: 0x04005CCF RID: 23759
		private static readonly IntPtr NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0;

		// Token: 0x04005CD0 RID: 23760
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005CD1 RID: 23761
		private static readonly IntPtr NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0;

		// Token: 0x04005CD2 RID: 23762
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0;

		// Token: 0x04005CD3 RID: 23763
		private static readonly IntPtr NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04005CD4 RID: 23764
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0;

		// Token: 0x04005CD5 RID: 23765
		private static readonly IntPtr NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04005CD6 RID: 23766
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x04005CD7 RID: 23767
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0;

		// Token: 0x04005CD8 RID: 23768
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04005CD9 RID: 23769
		private static readonly IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x04005CDA RID: 23770
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0;

		// Token: 0x04005CDB RID: 23771
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0;

		// Token: 0x04005CDC RID: 23772
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardPush_Private_Void_0;

		// Token: 0x04005CDD RID: 23773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B00 RID: 2816
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchType")]
		public enum EFlinchType
		{
			// Token: 0x04009011 RID: 36881
			Light,
			// Token: 0x04009012 RID: 36882
			Heavy
		}

		// Token: 0x02000B01 RID: 2817
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchDirection")]
		public enum EFlinchDirection
		{
			// Token: 0x04009014 RID: 36884
			Forward,
			// Token: 0x04009015 RID: 36885
			Backward,
			// Token: 0x04009016 RID: 36886
			Left,
			// Token: 0x04009017 RID: 36887
			Right
		}

		// Token: 0x02000B02 RID: 2818
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D63A RID: 54842 RVA: 0x003301E4 File Offset: 0x0032E3E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "finalBoneTransforms");
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "standUpFromBack");
				AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, 100680326);
				AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, 100680327);
			}

			// Token: 0x0600D63B RID: 54843 RVA: 0x00330274 File Offset: 0x0032E474
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D63C RID: 54844 RVA: 0x003302B0 File Offset: 0x0032E4B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252093, RefRangeEnd = 252094, XrefRangeStart = 252088, XrefRangeEnd = 252093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D63D RID: 54845 RVA: 0x0006841C File Offset: 0x0006661C
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004264 RID: 16996
			// (get) Token: 0x0600D63E RID: 54846 RVA: 0x003302F0 File Offset: 0x0032E4F0
			// (set) Token: 0x0600D63F RID: 54847 RVA: 0x00068425 File Offset: 0x00066625
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004265 RID: 16997
			// (get) Token: 0x0600D640 RID: 54848 RVA: 0x00330320 File Offset: 0x0032E520
			// (set) Token: 0x0600D641 RID: 54849 RVA: 0x00068444 File Offset: 0x00066644
			public unsafe Il2CppReferenceArray<BoneTransform> finalBoneTransforms
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004266 RID: 16998
			// (get) Token: 0x0600D642 RID: 54850 RVA: 0x00330350 File Offset: 0x0032E550
			// (set) Token: 0x0600D643 RID: 54851 RVA: 0x00068463 File Offset: 0x00066663
			public unsafe bool standUpFromBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack)) = value;
				}
			}

			// Token: 0x04009018 RID: 36888
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009019 RID: 36889
			private static readonly IntPtr NativeFieldInfoPtr_finalBoneTransforms;

			// Token: 0x0400901A RID: 36890
			private static readonly IntPtr NativeFieldInfoPtr_standUpFromBack;

			// Token: 0x0400901B RID: 36891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400901C RID: 36892
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C6B RID: 3179
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass75_0+<<PlayStandUpAnimation>g__StandUpRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4C1 RID: 58561 RVA: 0x00359FAC File Offset: 0x003581AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "<<PlayStandUpAnimation>g__StandUpRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<time>5__2");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680328);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680329);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680330);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680331);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680332);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680333);
				}

				// Token: 0x0600E4C2 RID: 58562 RVA: 0x0035A0B4 File Offset: 0x003582B4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4C3 RID: 58563 RVA: 0x0035A0FC File Offset: 0x003582FC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4C4 RID: 58564 RVA: 0x0035A130 File Offset: 0x00358330
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252060, XrefRangeEnd = 252083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004717 RID: 18199
				// (get) Token: 0x0600E4C5 RID: 58565 RVA: 0x0035A16C File Offset: 0x0035836C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4C6 RID: 58566 RVA: 0x0035A1AC File Offset: 0x003583AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252083, XrefRangeEnd = 252088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004718 RID: 18200
				// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x0035A1E0 File Offset: 0x003583E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4C8 RID: 58568 RVA: 0x0006F892 File Offset: 0x0006DA92
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004712 RID: 18194
				// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x0035A220 File Offset: 0x00358420
				// (set) Token: 0x0600E4CA RID: 58570 RVA: 0x0006F89B File Offset: 0x0006DA9B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004713 RID: 18195
				// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x0035A248 File Offset: 0x00358448
				// (set) Token: 0x0600E4CC RID: 58572 RVA: 0x0006F8B6 File Offset: 0x0006DAB6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004714 RID: 18196
				// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x0035A278 File Offset: 0x00358478
				// (set) Token: 0x0600E4CE RID: 58574 RVA: 0x0006F8D5 File Offset: 0x0006DAD5
				public unsafe AvatarAnimation.__c__DisplayClass75_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass75_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004715 RID: 18197
				// (get) Token: 0x0600E4CF RID: 58575 RVA: 0x0035A2A8 File Offset: 0x003584A8
				// (set) Token: 0x0600E4D0 RID: 58576 RVA: 0x0006F8F4 File Offset: 0x0006DAF4
				public unsafe float _time_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2)) = value;
					}
				}

				// Token: 0x17004716 RID: 18198
				// (get) Token: 0x0600E4D1 RID: 58577 RVA: 0x0035A2D0 File Offset: 0x003584D0
				// (set) Token: 0x0600E4D2 RID: 58578 RVA: 0x0006F90F File Offset: 0x0006DB0F
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009900 RID: 39168
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009901 RID: 39169
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009902 RID: 39170
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009903 RID: 39171
				private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

				// Token: 0x04009904 RID: 39172
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009905 RID: 39173
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009906 RID: 39174
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009907 RID: 39175
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009908 RID: 39176
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009909 RID: 39177
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400990A RID: 39178
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B03 RID: 2819
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D644 RID: 54852 RVA: 0x00330378 File Offset: 0x0032E578
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "startPos");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "endPos");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "startRot");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "endRot");
				AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, 100680334);
				AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, 100680335);
			}

			// Token: 0x0600D645 RID: 54853 RVA: 0x00330430 File Offset: 0x0032E630
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D646 RID: 54854 RVA: 0x0033046C File Offset: 0x0032E66C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252120, RefRangeEnd = 252121, XrefRangeStart = 252115, XrefRangeEnd = 252120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Boolean_0(bool resetLocalCoordinates)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref resetLocalCoordinates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D647 RID: 54855 RVA: 0x0006847E File Offset: 0x0006667E
			public __c__DisplayClass85_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004267 RID: 16999
			// (get) Token: 0x0600D648 RID: 54856 RVA: 0x003304B8 File Offset: 0x0032E6B8
			// (set) Token: 0x0600D649 RID: 54857 RVA: 0x00068487 File Offset: 0x00066687
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004268 RID: 17000
			// (get) Token: 0x0600D64A RID: 54858 RVA: 0x003304E8 File Offset: 0x0032E6E8
			// (set) Token: 0x0600D64B RID: 54859 RVA: 0x000684A6 File Offset: 0x000666A6
			public unsafe Vector3 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x17004269 RID: 17001
			// (get) Token: 0x0600D64C RID: 54860 RVA: 0x00330510 File Offset: 0x0032E710
			// (set) Token: 0x0600D64D RID: 54861 RVA: 0x000684C1 File Offset: 0x000666C1
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x1700426A RID: 17002
			// (get) Token: 0x0600D64E RID: 54862 RVA: 0x00330538 File Offset: 0x0032E738
			// (set) Token: 0x0600D64F RID: 54863 RVA: 0x000684DC File Offset: 0x000666DC
			public unsafe Quaternion startRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x1700426B RID: 17003
			// (get) Token: 0x0600D650 RID: 54864 RVA: 0x00330560 File Offset: 0x0032E760
			// (set) Token: 0x0600D651 RID: 54865 RVA: 0x000684F7 File Offset: 0x000666F7
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x0400901D RID: 36893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400901E RID: 36894
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x0400901F RID: 36895
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009020 RID: 36896
			private static readonly IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x04009021 RID: 36897
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x04009022 RID: 36898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009023 RID: 36899
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0;

			// Token: 0x02000C6C RID: 3180
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass85_0+<<SetSeat>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4D3 RID: 58579 RVA: 0x0035A2F8 File Offset: 0x003584F8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "<<SetSeat>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "resetLocalCoordinates");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<i>5__2");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680336);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680337);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680338);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680339);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680340);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680341);
				}

				// Token: 0x0600E4D4 RID: 58580 RVA: 0x0035A400 File Offset: 0x00358600
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4D5 RID: 58581 RVA: 0x0035A448 File Offset: 0x00358648
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4D6 RID: 58582 RVA: 0x0035A47C File Offset: 0x0035867C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252094, XrefRangeEnd = 252110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700471E RID: 18206
				// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x0035A4B8 File Offset: 0x003586B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4D8 RID: 58584 RVA: 0x0035A4F8 File Offset: 0x003586F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252110, XrefRangeEnd = 252115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700471F RID: 18207
				// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x0035A52C File Offset: 0x0035872C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4DA RID: 58586 RVA: 0x0006F92A File Offset: 0x0006DB2A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004719 RID: 18201
				// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x0035A56C File Offset: 0x0035876C
				// (set) Token: 0x0600E4DC RID: 58588 RVA: 0x0006F933 File Offset: 0x0006DB33
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700471A RID: 18202
				// (get) Token: 0x0600E4DD RID: 58589 RVA: 0x0035A594 File Offset: 0x00358794
				// (set) Token: 0x0600E4DE RID: 58590 RVA: 0x0006F94E File Offset: 0x0006DB4E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700471B RID: 18203
				// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x0035A5C4 File Offset: 0x003587C4
				// (set) Token: 0x0600E4E0 RID: 58592 RVA: 0x0006F96D File Offset: 0x0006DB6D
				public unsafe AvatarAnimation.__c__DisplayClass85_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass85_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700471C RID: 18204
				// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x0035A5F4 File Offset: 0x003587F4
				// (set) Token: 0x0600E4E2 RID: 58594 RVA: 0x0006F98C File Offset: 0x0006DB8C
				public unsafe bool resetLocalCoordinates
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates)) = value;
					}
				}

				// Token: 0x1700471D RID: 18205
				// (get) Token: 0x0600E4E3 RID: 58595 RVA: 0x0035A61C File Offset: 0x0035881C
				// (set) Token: 0x0600E4E4 RID: 58596 RVA: 0x0006F9A7 File Offset: 0x0006DBA7
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400990B RID: 39179
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400990C RID: 39180
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400990D RID: 39181
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400990E RID: 39182
				private static readonly IntPtr NativeFieldInfoPtr_resetLocalCoordinates;

				// Token: 0x0400990F RID: 39183
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009910 RID: 39184
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009911 RID: 39185
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009912 RID: 39186
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009913 RID: 39187
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009914 RID: 39188
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009915 RID: 39189
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
