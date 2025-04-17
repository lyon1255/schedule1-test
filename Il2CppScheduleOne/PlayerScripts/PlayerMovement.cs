using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E8 RID: 1000
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x06005155 RID: 20821 RVA: 0x00182E48 File Offset: 0x00181048
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMovement()
		{
			Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr);
			PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DEV_SPRINT_MULTIPLIER");
			PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "GROUNDED_THRESHOLD");
			PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SLOPE_THRESHOLD");
			PlayerMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "WalkSpeed");
			PlayerMovement.NativeFieldInfoPtr_SprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaticMoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreDelay");
			PlayerMovement.NativeFieldInfoPtr_JumpMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "JumpMultiplier");
			PlayerMovement.NativeFieldInfoPtr_ControllerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "ControllerRadius");
			PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StandingControllerHeight");
			PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchHeightMultiplier");
			PlayerMovement.NativeFieldInfoPtr_CrouchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchTime");
			PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaDrainRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaReserveMax");
			PlayerMovement.NativeFieldInfoPtr_SprintChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintChangeRate");
			PlayerMovement.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Player");
			PlayerMovement.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Controller");
			PlayerMovement.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sensitivity");
			PlayerMovement.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "dead");
			PlayerMovement.NativeFieldInfoPtr_canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "canMove");
			PlayerMovement.NativeFieldInfoPtr_canJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "canJump");
			PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintingRequiresStamina");
			PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlipperyMovementMultiplier");
			PlayerMovement.NativeFieldInfoPtr_jumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "jumpForce");
			PlayerMovement.NativeFieldInfoPtr_gravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "gravityMultiplier");
			PlayerMovement.NativeFieldInfoPtr_groundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "groundDetectionMask");
			PlayerMovement.NativeFieldInfoPtr_slopeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "slopeForce");
			PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "slopeForceRayLength");
			PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "crouchSpeedMultipler");
			PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Crouched_VigIntensity");
			PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Crouched_VigSmoothness");
			PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "visibilityPointsToScale");
			PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "originalVisibilityPointOffsets");
			PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<playerHeight>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movement");
			PlayerMovement.NativeFieldInfoPtr_movementY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementY");
			PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<currentVehicle>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "recentlyDrivenVehicles");
			PlayerMovement.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "isJumping");
			PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<airTime>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isCrouched>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<standingScale>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isRagdolled>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isSprinting>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentSprintMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CurrentStaminaReserve");
			PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsGrounded>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onStaminaReserveChanged");
			PlayerMovement.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onJump");
			PlayerMovement.NativeFieldInfoPtr_onLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onLand");
			PlayerMovement.NativeFieldInfoPtr_onCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onCrouch");
			PlayerMovement.NativeFieldInfoPtr_onUncrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onUncrouch");
			PlayerMovement.NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "horizontalAxis");
			PlayerMovement.NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "verticalAxis");
			PlayerMovement.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeGrounded");
			PlayerMovement.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementEvents");
			PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeSinceStaminaDrain");
			PlayerMovement.NativeFieldInfoPtr_sprintActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintActive");
			PlayerMovement.NativeFieldInfoPtr_sprintReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintReleased");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDirection");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityForce");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDuration");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityTimeRemaining");
			PlayerMovement.NativeFieldInfoPtr_teleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleport");
			PlayerMovement.NativeFieldInfoPtr_teleportPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleportPosition");
			PlayerMovement.NativeFieldInfoPtr_sprintBlockers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintBlockers");
			PlayerMovement.NativeFieldInfoPtr_lastFrameMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastFrameMovement");
			PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "playerRotCoroutine");
			PlayerMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673513);
			PlayerMovement.NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673514);
			PlayerMovement.NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673515);
			PlayerMovement.NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673516);
			PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673517);
			PlayerMovement.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673518);
			PlayerMovement.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673519);
			PlayerMovement.NativeMethodInfoPtr_get_airTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673520);
			PlayerMovement.NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673521);
			PlayerMovement.NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673522);
			PlayerMovement.NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673523);
			PlayerMovement.NativeMethodInfoPtr_get_standingScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673524);
			PlayerMovement.NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673525);
			PlayerMovement.NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673526);
			PlayerMovement.NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673527);
			PlayerMovement.NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673528);
			PlayerMovement.NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673529);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673530);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673531);
			PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673532);
			PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673533);
			PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673534);
			PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673535);
			PlayerMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673536);
			PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673537);
			PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673538);
			PlayerMovement.NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673539);
			PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673540);
			PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673541);
			PlayerMovement.NativeMethodInfoPtr_isGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673542);
			PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673543);
			PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673544);
			PlayerMovement.NativeMethodInfoPtr_Jump_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673545);
			PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673546);
			PlayerMovement.NativeMethodInfoPtr_CanStand_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673547);
			PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673548);
			PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673549);
			PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673550);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673551);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673552);
			PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673553);
			PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673554);
			PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673555);
			PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673556);
			PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673557);
			PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673558);
			PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673559);
			PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673560);
			PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673561);
			PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673562);
			PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673563);
			PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673564);
			PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673565);
			PlayerMovement.NativeMethodInfoPtr__Start_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673567);
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x0018383C File Offset: 0x00181A3C
		// (set) Token: 0x06005157 RID: 20823 RVA: 0x0018386C File Offset: 0x00181A6C
		public unsafe static float GravityMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176730, XrefRangeEnd = 176734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176734, XrefRangeEnd = 176738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06005158 RID: 20824 RVA: 0x001838A0 File Offset: 0x00181AA0
		// (set) Token: 0x06005159 RID: 20825 RVA: 0x001838DC File Offset: 0x00181ADC
		public unsafe float playerHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x0018391C File Offset: 0x00181B1C
		public unsafe Vector3 Movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x00183958 File Offset: 0x00181B58
		// (set) Token: 0x0600515C RID: 20828 RVA: 0x00183998 File Offset: 0x00181B98
		public unsafe LandVehicle currentVehicle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 31092, RefRangeEnd = 31099, XrefRangeStart = 31092, XrefRangeEnd = 31099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x001839DC File Offset: 0x00181BDC
		// (set) Token: 0x0600515E RID: 20830 RVA: 0x00183A18 File Offset: 0x00181C18
		public unsafe float airTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_airTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x00183A58 File Offset: 0x00181C58
		// (set) Token: 0x06005160 RID: 20832 RVA: 0x00183A94 File Offset: 0x00181C94
		public unsafe bool isCrouched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x00183AD4 File Offset: 0x00181CD4
		// (set) Token: 0x06005162 RID: 20834 RVA: 0x00183B10 File Offset: 0x00181D10
		public unsafe float standingScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_standingScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x00183B50 File Offset: 0x00181D50
		// (set) Token: 0x06005164 RID: 20836 RVA: 0x00183B8C File Offset: 0x00181D8C
		public unsafe bool isRagdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x00183BCC File Offset: 0x00181DCC
		// (set) Token: 0x06005166 RID: 20838 RVA: 0x00183C08 File Offset: 0x00181E08
		public unsafe bool isSprinting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x00183C48 File Offset: 0x00181E48
		// (set) Token: 0x06005168 RID: 20840 RVA: 0x00183C84 File Offset: 0x00181E84
		public unsafe float CurrentSprintMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x00183CC4 File Offset: 0x00181EC4
		// (set) Token: 0x0600516A RID: 20842 RVA: 0x00183D00 File Offset: 0x00181F00
		public unsafe bool IsGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00183D40 File Offset: 0x00181F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176738, XrefRangeEnd = 176754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00183D7C File Offset: 0x00181F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176754, XrefRangeEnd = 176797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00183DB8 File Offset: 0x00181FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176797, XrefRangeEnd = 176820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00183DF4 File Offset: 0x00181FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176820, XrefRangeEnd = 176825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x00183E28 File Offset: 0x00182028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176825, XrefRangeEnd = 176829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00183E5C File Offset: 0x0018205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176829, XrefRangeEnd = 176976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00183E98 File Offset: 0x00182098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176982, RefRangeEnd = 176983, XrefRangeStart = 176976, XrefRangeEnd = 176982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00183ECC File Offset: 0x001820CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176983, XrefRangeEnd = 176992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00183F08 File Offset: 0x00182108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176992, XrefRangeEnd = 176998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_isGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00183F44 File Offset: 0x00182144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177014, RefRangeEnd = 177015, XrefRangeStart = 176998, XrefRangeEnd = 177014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHorizontalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00183F78 File Offset: 0x00182178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177031, RefRangeEnd = 177032, XrefRangeStart = 177015, XrefRangeEnd = 177031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerticalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00183FAC File Offset: 0x001821AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177032, XrefRangeEnd = 177037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Jump_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00183FEC File Offset: 0x001821EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177040, RefRangeEnd = 177042, XrefRangeStart = 177037, XrefRangeEnd = 177040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryToggleCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00184020 File Offset: 0x00182220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177059, RefRangeEnd = 177060, XrefRangeStart = 177042, XrefRangeEnd = 177059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_CanStand_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x0018405C File Offset: 0x0018225C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177071, RefRangeEnd = 177074, XrefRangeStart = 177060, XrefRangeEnd = 177071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x0018409C File Offset: 0x0018229C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177090, RefRangeEnd = 177091, XrefRangeStart = 177074, XrefRangeEnd = 177090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCrouchVignetteEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x001840D0 File Offset: 0x001822D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177116, RefRangeEnd = 177117, XrefRangeStart = 177091, XrefRangeEnd = 177116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00184104 File Offset: 0x00182304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177125, RefRangeEnd = 177126, XrefRangeStart = 177117, XrefRangeEnd = 177125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00184150 File Offset: 0x00182350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177126, XrefRangeEnd = 177131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endRotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x001841AC File Offset: 0x001823AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177131, XrefRangeEnd = 177143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x001841F0 File Offset: 0x001823F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177143, XrefRangeEnd = 177146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x00184244 File Offset: 0x00182444
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 177163, RefRangeEnd = 177173, XrefRangeStart = 177146, XrefRangeEnd = 177163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00184284 File Offset: 0x00182484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177174, RefRangeEnd = 177177, XrefRangeStart = 177173, XrefRangeEnd = 177174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResidualVelocity(Vector3 dir, float force, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x001842E0 File Offset: 0x001824E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177200, RefRangeEnd = 177201, XrefRangeStart = 177177, XrefRangeEnd = 177200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x00184314 File Offset: 0x00182514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177228, RefRangeEnd = 177230, XrefRangeStart = 177201, XrefRangeEnd = 177228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00184364 File Offset: 0x00182564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177258, RefRangeEnd = 177260, XrefRangeStart = 177230, XrefRangeEnd = 177258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x001843A8 File Offset: 0x001825A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177291, RefRangeEnd = 177292, XrefRangeStart = 177260, XrefRangeEnd = 177291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x001843DC File Offset: 0x001825DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177293, RefRangeEnd = 177296, XrefRangeStart = 177292, XrefRangeEnd = 177293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeStamina(float change, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x00184428 File Offset: 0x00182628
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177301, RefRangeEnd = 177306, XrefRangeStart = 177296, XrefRangeEnd = 177301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStamina(float value, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00184474 File Offset: 0x00182674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177312, RefRangeEnd = 177313, XrefRangeStart = 177306, XrefRangeEnd = 177312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x001844B8 File Offset: 0x001826B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177319, RefRangeEnd = 177321, XrefRangeStart = 177313, XrefRangeEnd = 177319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x001844FC File Offset: 0x001826FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177321, XrefRangeEnd = 177371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00184538 File Offset: 0x00182738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177371, XrefRangeEnd = 177379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__104_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__Start_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00026A67 File Offset: 0x00024C67
		public PlayerMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600518D RID: 20877 RVA: 0x0018456C File Offset: 0x0018276C
		// (set) Token: 0x0600518E RID: 20878 RVA: 0x00026A70 File Offset: 0x00024C70
		public unsafe static float DEV_SPRINT_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600518F RID: 20879 RVA: 0x00184588 File Offset: 0x00182788
		// (set) Token: 0x06005190 RID: 20880 RVA: 0x00026A7E File Offset: 0x00024C7E
		public unsafe static float GROUNDED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x001845A4 File Offset: 0x001827A4
		// (set) Token: 0x06005192 RID: 20882 RVA: 0x00026A8C File Offset: 0x00024C8C
		public unsafe static float SLOPE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x001845C0 File Offset: 0x001827C0
		// (set) Token: 0x06005194 RID: 20884 RVA: 0x00026A9A File Offset: 0x00024C9A
		public unsafe static float WalkSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&value));
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06005195 RID: 20885 RVA: 0x001845DC File Offset: 0x001827DC
		// (set) Token: 0x06005196 RID: 20886 RVA: 0x00026AA8 File Offset: 0x00024CA8
		public unsafe static float SprintMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x001845F8 File Offset: 0x001827F8
		// (set) Token: 0x06005198 RID: 20888 RVA: 0x00026AB6 File Offset: 0x00024CB6
		public unsafe static float StaticMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x00184614 File Offset: 0x00182814
		// (set) Token: 0x0600519A RID: 20890 RVA: 0x00026AC4 File Offset: 0x00024CC4
		public unsafe static float StaminaRestoreDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&value));
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x0600519B RID: 20891 RVA: 0x00184630 File Offset: 0x00182830
		// (set) Token: 0x0600519C RID: 20892 RVA: 0x00026AD2 File Offset: 0x00024CD2
		public unsafe static float JumpMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600519D RID: 20893 RVA: 0x0018464C File Offset: 0x0018284C
		// (set) Token: 0x0600519E RID: 20894 RVA: 0x00026AE0 File Offset: 0x00024CE0
		public unsafe static float ControllerRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&value));
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x00184668 File Offset: 0x00182868
		// (set) Token: 0x060051A0 RID: 20896 RVA: 0x00026AEE File Offset: 0x00024CEE
		public unsafe static float StandingControllerHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight, (void*)(&value));
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060051A1 RID: 20897 RVA: 0x00184684 File Offset: 0x00182884
		// (set) Token: 0x060051A2 RID: 20898 RVA: 0x00026AFC File Offset: 0x00024CFC
		public unsafe static float CrouchHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x001846A0 File Offset: 0x001828A0
		// (set) Token: 0x060051A4 RID: 20900 RVA: 0x00026B0A File Offset: 0x00024D0A
		public unsafe static float CrouchTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&value));
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060051A5 RID: 20901 RVA: 0x001846BC File Offset: 0x001828BC
		// (set) Token: 0x060051A6 RID: 20902 RVA: 0x00026B18 File Offset: 0x00024D18
		public unsafe static float _GravityMultiplier_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060051A7 RID: 20903 RVA: 0x001846D8 File Offset: 0x001828D8
		// (set) Token: 0x060051A8 RID: 20904 RVA: 0x00026B26 File Offset: 0x00024D26
		public unsafe static float StaminaDrainRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&value));
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x001846F4 File Offset: 0x001828F4
		// (set) Token: 0x060051AA RID: 20906 RVA: 0x00026B34 File Offset: 0x00024D34
		public unsafe static float StaminaRestoreRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&value));
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x00184710 File Offset: 0x00182910
		// (set) Token: 0x060051AC RID: 20908 RVA: 0x00026B42 File Offset: 0x00024D42
		public unsafe static float StaminaReserveMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&value));
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x0018472C File Offset: 0x0018292C
		// (set) Token: 0x060051AE RID: 20910 RVA: 0x00026B50 File Offset: 0x00024D50
		public unsafe static float SprintChangeRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&value));
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x00184748 File Offset: 0x00182948
		// (set) Token: 0x060051B0 RID: 20912 RVA: 0x00026B5E File Offset: 0x00024D5E
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x00184778 File Offset: 0x00182978
		// (set) Token: 0x060051B2 RID: 20914 RVA: 0x00026B7D File Offset: 0x00024D7D
		public unsafe CharacterController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x001847A8 File Offset: 0x001829A8
		// (set) Token: 0x060051B4 RID: 20916 RVA: 0x00026B9C File Offset: 0x00024D9C
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x001847D0 File Offset: 0x001829D0
		// (set) Token: 0x060051B6 RID: 20918 RVA: 0x00026BB7 File Offset: 0x00024DB7
		public unsafe float dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x001847F8 File Offset: 0x001829F8
		// (set) Token: 0x060051B8 RID: 20920 RVA: 0x00026BD2 File Offset: 0x00024DD2
		public unsafe bool canMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canMove)) = value;
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x00184820 File Offset: 0x00182A20
		// (set) Token: 0x060051BA RID: 20922 RVA: 0x00026BED File Offset: 0x00024DED
		public unsafe bool canJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canJump)) = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x00184848 File Offset: 0x00182A48
		// (set) Token: 0x060051BC RID: 20924 RVA: 0x00026C08 File Offset: 0x00024E08
		public unsafe bool SprintingRequiresStamina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina)) = value;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x00184870 File Offset: 0x00182A70
		// (set) Token: 0x060051BE RID: 20926 RVA: 0x00026C23 File Offset: 0x00024E23
		public unsafe float MoveSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x060051BF RID: 20927 RVA: 0x00184898 File Offset: 0x00182A98
		// (set) Token: 0x060051C0 RID: 20928 RVA: 0x00026C3E File Offset: 0x00024E3E
		public unsafe float SlipperyMovementMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier)) = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x001848C0 File Offset: 0x00182AC0
		// (set) Token: 0x060051C2 RID: 20930 RVA: 0x00026C59 File Offset: 0x00024E59
		public unsafe float jumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_jumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_jumpForce)) = value;
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x001848E8 File Offset: 0x00182AE8
		// (set) Token: 0x060051C4 RID: 20932 RVA: 0x00026C74 File Offset: 0x00024E74
		public unsafe float gravityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_gravityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_gravityMultiplier)) = value;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x00184910 File Offset: 0x00182B10
		// (set) Token: 0x060051C6 RID: 20934 RVA: 0x00026C8F File Offset: 0x00024E8F
		public unsafe LayerMask groundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_groundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_groundDetectionMask)) = value;
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x00184938 File Offset: 0x00182B38
		// (set) Token: 0x060051C8 RID: 20936 RVA: 0x00026CAA File Offset: 0x00024EAA
		public unsafe float slopeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForce)) = value;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x00184960 File Offset: 0x00182B60
		// (set) Token: 0x060051CA RID: 20938 RVA: 0x00026CC5 File Offset: 0x00024EC5
		public unsafe float slopeForceRayLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength)) = value;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x00184988 File Offset: 0x00182B88
		// (set) Token: 0x060051CC RID: 20940 RVA: 0x00026CE0 File Offset: 0x00024EE0
		public unsafe float crouchSpeedMultipler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler)) = value;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x001849B0 File Offset: 0x00182BB0
		// (set) Token: 0x060051CE RID: 20942 RVA: 0x00026CFB File Offset: 0x00024EFB
		public unsafe float Crouched_VigIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity)) = value;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x001849D8 File Offset: 0x00182BD8
		// (set) Token: 0x060051D0 RID: 20944 RVA: 0x00026D16 File Offset: 0x00024F16
		public unsafe float Crouched_VigSmoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness)) = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x00184A00 File Offset: 0x00182C00
		// (set) Token: 0x060051D2 RID: 20946 RVA: 0x00026D31 File Offset: 0x00024F31
		public unsafe List<Transform> visibilityPointsToScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x00184A30 File Offset: 0x00182C30
		// (set) Token: 0x060051D4 RID: 20948 RVA: 0x00026D50 File Offset: 0x00024F50
		public unsafe Dictionary<Transform, float> originalVisibilityPointOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x00184A60 File Offset: 0x00182C60
		// (set) Token: 0x060051D6 RID: 20950 RVA: 0x00026D6F File Offset: 0x00024F6F
		public unsafe float _playerHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x060051D7 RID: 20951 RVA: 0x00184A88 File Offset: 0x00182C88
		// (set) Token: 0x060051D8 RID: 20952 RVA: 0x00026D8A File Offset: 0x00024F8A
		public unsafe Vector3 movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement)) = value;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x060051D9 RID: 20953 RVA: 0x00184AB0 File Offset: 0x00182CB0
		// (set) Token: 0x060051DA RID: 20954 RVA: 0x00026DA5 File Offset: 0x00024FA5
		public unsafe float movementY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY)) = value;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x00184AD8 File Offset: 0x00182CD8
		// (set) Token: 0x060051DC RID: 20956 RVA: 0x00026DC0 File Offset: 0x00024FC0
		public unsafe LandVehicle _currentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060051DD RID: 20957 RVA: 0x00184B08 File Offset: 0x00182D08
		// (set) Token: 0x060051DE RID: 20958 RVA: 0x00026DDF File Offset: 0x00024FDF
		public unsafe List<LandVehicle> recentlyDrivenVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x060051DF RID: 20959 RVA: 0x00184B38 File Offset: 0x00182D38
		// (set) Token: 0x060051E0 RID: 20960 RVA: 0x00026DFE File Offset: 0x00024FFE
		public unsafe bool isJumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x00184B60 File Offset: 0x00182D60
		// (set) Token: 0x060051E2 RID: 20962 RVA: 0x00026E19 File Offset: 0x00025019
		public unsafe float _airTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x060051E3 RID: 20963 RVA: 0x00184B88 File Offset: 0x00182D88
		// (set) Token: 0x060051E4 RID: 20964 RVA: 0x00026E34 File Offset: 0x00025034
		public unsafe bool _isCrouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x00184BB0 File Offset: 0x00182DB0
		// (set) Token: 0x060051E6 RID: 20966 RVA: 0x00026E4F File Offset: 0x0002504F
		public unsafe float _standingScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x00184BD8 File Offset: 0x00182DD8
		// (set) Token: 0x060051E8 RID: 20968 RVA: 0x00026E6A File Offset: 0x0002506A
		public unsafe bool _isRagdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x00184C00 File Offset: 0x00182E00
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x00026E85 File Offset: 0x00025085
		public unsafe bool _isSprinting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x00184C28 File Offset: 0x00182E28
		// (set) Token: 0x060051EC RID: 20972 RVA: 0x00026EA0 File Offset: 0x000250A0
		public unsafe float _CurrentSprintMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x00184C50 File Offset: 0x00182E50
		// (set) Token: 0x060051EE RID: 20974 RVA: 0x00026EBB File Offset: 0x000250BB
		public unsafe float CurrentStaminaReserve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve)) = value;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x060051EF RID: 20975 RVA: 0x00184C78 File Offset: 0x00182E78
		// (set) Token: 0x060051F0 RID: 20976 RVA: 0x00026ED6 File Offset: 0x000250D6
		public unsafe bool _IsGrounded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField)) = value;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x00184CA0 File Offset: 0x00182EA0
		// (set) Token: 0x060051F2 RID: 20978 RVA: 0x00026EF1 File Offset: 0x000250F1
		public unsafe Action<float> onStaminaReserveChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00184CD0 File Offset: 0x00182ED0
		// (set) Token: 0x060051F4 RID: 20980 RVA: 0x00026F10 File Offset: 0x00025110
		public unsafe Action onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x060051F5 RID: 20981 RVA: 0x00184D00 File Offset: 0x00182F00
		// (set) Token: 0x060051F6 RID: 20982 RVA: 0x00026F2F File Offset: 0x0002512F
		public unsafe Action onLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x00184D30 File Offset: 0x00182F30
		// (set) Token: 0x060051F8 RID: 20984 RVA: 0x00026F4E File Offset: 0x0002514E
		public unsafe UnityEvent onCrouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x00184D60 File Offset: 0x00182F60
		// (set) Token: 0x060051FA RID: 20986 RVA: 0x00026F6D File Offset: 0x0002516D
		public unsafe UnityEvent onUncrouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x00184D90 File Offset: 0x00182F90
		// (set) Token: 0x060051FC RID: 20988 RVA: 0x00026F8C File Offset: 0x0002518C
		public unsafe float horizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis)) = value;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x00184DB8 File Offset: 0x00182FB8
		// (set) Token: 0x060051FE RID: 20990 RVA: 0x00026FA7 File Offset: 0x000251A7
		public unsafe float verticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis)) = value;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x00184DE0 File Offset: 0x00182FE0
		// (set) Token: 0x06005200 RID: 20992 RVA: 0x00026FC2 File Offset: 0x000251C2
		public unsafe float timeGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x00184E08 File Offset: 0x00183008
		// (set) Token: 0x06005202 RID: 20994 RVA: 0x00026FDD File Offset: 0x000251DD
		public unsafe Dictionary<int, PlayerMovement.MovementEvent> movementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PlayerMovement.MovementEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06005203 RID: 20995 RVA: 0x00184E38 File Offset: 0x00183038
		// (set) Token: 0x06005204 RID: 20996 RVA: 0x00026FFC File Offset: 0x000251FC
		public unsafe float timeSinceStaminaDrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain)) = value;
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x00184E60 File Offset: 0x00183060
		// (set) Token: 0x06005206 RID: 20998 RVA: 0x00027017 File Offset: 0x00025217
		public unsafe bool sprintActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive)) = value;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06005207 RID: 20999 RVA: 0x00184E88 File Offset: 0x00183088
		// (set) Token: 0x06005208 RID: 21000 RVA: 0x00027032 File Offset: 0x00025232
		public unsafe bool sprintReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased)) = value;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x00184EB0 File Offset: 0x001830B0
		// (set) Token: 0x0600520A RID: 21002 RVA: 0x0002704D File Offset: 0x0002524D
		public unsafe Vector3 residualVelocityDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection)) = value;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x00184ED8 File Offset: 0x001830D8
		// (set) Token: 0x0600520C RID: 21004 RVA: 0x00027068 File Offset: 0x00025268
		public unsafe float residualVelocityForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce)) = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x0600520D RID: 21005 RVA: 0x00184F00 File Offset: 0x00183100
		// (set) Token: 0x0600520E RID: 21006 RVA: 0x00027083 File Offset: 0x00025283
		public unsafe float residualVelocityDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration)) = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x0600520F RID: 21007 RVA: 0x00184F28 File Offset: 0x00183128
		// (set) Token: 0x06005210 RID: 21008 RVA: 0x0002709E File Offset: 0x0002529E
		public unsafe float residualVelocityTimeRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining)) = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06005211 RID: 21009 RVA: 0x00184F50 File Offset: 0x00183150
		// (set) Token: 0x06005212 RID: 21010 RVA: 0x000270B9 File Offset: 0x000252B9
		public unsafe bool teleport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport)) = value;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x00184F78 File Offset: 0x00183178
		// (set) Token: 0x06005214 RID: 21012 RVA: 0x000270D4 File Offset: 0x000252D4
		public unsafe Vector3 teleportPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition)) = value;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x00184FA0 File Offset: 0x001831A0
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x000270EF File Offset: 0x000252EF
		public unsafe List<string> sprintBlockers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x00184FD0 File Offset: 0x001831D0
		// (set) Token: 0x06005218 RID: 21016 RVA: 0x0002710E File Offset: 0x0002530E
		public unsafe Vector3 lastFrameMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement)) = value;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x00184FF8 File Offset: 0x001831F8
		// (set) Token: 0x0600521A RID: 21018 RVA: 0x00027129 File Offset: 0x00025329
		public unsafe Coroutine playerRotCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003737 RID: 14135
		private static readonly IntPtr NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER;

		// Token: 0x04003738 RID: 14136
		private static readonly IntPtr NativeFieldInfoPtr_GROUNDED_THRESHOLD;

		// Token: 0x04003739 RID: 14137
		private static readonly IntPtr NativeFieldInfoPtr_SLOPE_THRESHOLD;

		// Token: 0x0400373A RID: 14138
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x0400373B RID: 14139
		private static readonly IntPtr NativeFieldInfoPtr_SprintMultiplier;

		// Token: 0x0400373C RID: 14140
		private static readonly IntPtr NativeFieldInfoPtr_StaticMoveSpeedMultiplier;

		// Token: 0x0400373D RID: 14141
		private static readonly IntPtr NativeFieldInfoPtr_StaminaRestoreDelay;

		// Token: 0x0400373E RID: 14142
		private static readonly IntPtr NativeFieldInfoPtr_JumpMultiplier;

		// Token: 0x0400373F RID: 14143
		private static readonly IntPtr NativeFieldInfoPtr_ControllerRadius;

		// Token: 0x04003740 RID: 14144
		private static readonly IntPtr NativeFieldInfoPtr_StandingControllerHeight;

		// Token: 0x04003741 RID: 14145
		private static readonly IntPtr NativeFieldInfoPtr_CrouchHeightMultiplier;

		// Token: 0x04003742 RID: 14146
		private static readonly IntPtr NativeFieldInfoPtr_CrouchTime;

		// Token: 0x04003743 RID: 14147
		private static readonly IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x04003744 RID: 14148
		private static readonly IntPtr NativeFieldInfoPtr_StaminaDrainRate;

		// Token: 0x04003745 RID: 14149
		private static readonly IntPtr NativeFieldInfoPtr_StaminaRestoreRate;

		// Token: 0x04003746 RID: 14150
		private static readonly IntPtr NativeFieldInfoPtr_StaminaReserveMax;

		// Token: 0x04003747 RID: 14151
		private static readonly IntPtr NativeFieldInfoPtr_SprintChangeRate;

		// Token: 0x04003748 RID: 14152
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04003749 RID: 14153
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x0400374A RID: 14154
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x0400374B RID: 14155
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x0400374C RID: 14156
		private static readonly IntPtr NativeFieldInfoPtr_canMove;

		// Token: 0x0400374D RID: 14157
		private static readonly IntPtr NativeFieldInfoPtr_canJump;

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeFieldInfoPtr_SprintingRequiresStamina;

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeedMultiplier;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyMovementMultiplier;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeFieldInfoPtr_jumpForce;

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeFieldInfoPtr_gravityMultiplier;

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeFieldInfoPtr_groundDetectionMask;

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeFieldInfoPtr_slopeForce;

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeFieldInfoPtr_slopeForceRayLength;

		// Token: 0x04003756 RID: 14166
		private static readonly IntPtr NativeFieldInfoPtr_crouchSpeedMultipler;

		// Token: 0x04003757 RID: 14167
		private static readonly IntPtr NativeFieldInfoPtr_Crouched_VigIntensity;

		// Token: 0x04003758 RID: 14168
		private static readonly IntPtr NativeFieldInfoPtr_Crouched_VigSmoothness;

		// Token: 0x04003759 RID: 14169
		private static readonly IntPtr NativeFieldInfoPtr_visibilityPointsToScale;

		// Token: 0x0400375A RID: 14170
		private static readonly IntPtr NativeFieldInfoPtr_originalVisibilityPointOffsets;

		// Token: 0x0400375B RID: 14171
		private static readonly IntPtr NativeFieldInfoPtr__playerHeight_k__BackingField;

		// Token: 0x0400375C RID: 14172
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x0400375D RID: 14173
		private static readonly IntPtr NativeFieldInfoPtr_movementY;

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeFieldInfoPtr__currentVehicle_k__BackingField;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeFieldInfoPtr_recentlyDrivenVehicles;

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeFieldInfoPtr__airTime_k__BackingField;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeFieldInfoPtr__isCrouched_k__BackingField;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeFieldInfoPtr__standingScale_k__BackingField;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeFieldInfoPtr__isRagdolled_k__BackingField;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeFieldInfoPtr__isSprinting_k__BackingField;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeFieldInfoPtr_CurrentStaminaReserve;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeFieldInfoPtr__IsGrounded_k__BackingField;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeFieldInfoPtr_onStaminaReserveChanged;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeFieldInfoPtr_onLand;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeFieldInfoPtr_onCrouch;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeFieldInfoPtr_onUncrouch;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAxis;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeFieldInfoPtr_verticalAxis;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStaminaDrain;

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr_sprintActive;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeFieldInfoPtr_sprintReleased;

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityDirection;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityForce;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityDuration;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityTimeRemaining;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeFieldInfoPtr_teleport;

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeFieldInfoPtr_teleportPosition;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeFieldInfoPtr_sprintBlockers;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameMovement;

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeFieldInfoPtr_playerRotCoroutine;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0;

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0;

		// Token: 0x04003782 RID: 14210
		private static readonly IntPtr NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0;

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0;

		// Token: 0x04003784 RID: 14212
		private static readonly IntPtr NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04003785 RID: 14213
		private static readonly IntPtr NativeMethodInfoPtr_get_airTime_Public_get_Single_0;

		// Token: 0x04003786 RID: 14214
		private static readonly IntPtr NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0;

		// Token: 0x04003787 RID: 14215
		private static readonly IntPtr NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0;

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeMethodInfoPtr_get_standingScale_Public_get_Single_0;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0;

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeMethodInfoPtr_ClampMovement_Private_Void_0;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr_isGrounded_Private_Boolean_0;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_IEnumerator_0;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr_CanStand_Public_Boolean_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__104_0_Private_Void_0;

		// Token: 0x020009A7 RID: 2471
		public class MovementEvent : Il2CppSystem.Object
		{
			// Token: 0x0600CB5B RID: 52059 RVA: 0x00311AC4 File Offset: 0x0030FCC4
			// Note: this type is marked as 'beforefieldinit'.
			static MovementEvent()
			{
				Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MovementEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr);
				PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, "actions");
				PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, "LastUpdatedDistance");
				PlayerMovement.MovementEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, 100673568);
				PlayerMovement.MovementEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, 100673569);
			}

			// Token: 0x0600CB5C RID: 52060 RVA: 0x00311B40 File Offset: 0x0030FD40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 176675, RefRangeEnd = 176677, XrefRangeStart = 176661, XrefRangeEnd = 176675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(Vector3 newPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref newPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.MovementEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB5D RID: 52061 RVA: 0x00311B80 File Offset: 0x0030FD80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176687, RefRangeEnd = 176688, XrefRangeStart = 176677, XrefRangeEnd = 176687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MovementEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.MovementEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB5E RID: 52062 RVA: 0x00062E71 File Offset: 0x00061071
			public MovementEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F58 RID: 16216
			// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x00311BBC File Offset: 0x0030FDBC
			// (set) Token: 0x0600CB60 RID: 52064 RVA: 0x00062E7A File Offset: 0x0006107A
			public unsafe List<Action> actions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F59 RID: 16217
			// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00311BEC File Offset: 0x0030FDEC
			// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x00062E99 File Offset: 0x00061099
			public unsafe Vector3 LastUpdatedDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance)) = value;
				}
			}

			// Token: 0x04008979 RID: 35193
			private static readonly IntPtr NativeFieldInfoPtr_actions;

			// Token: 0x0400897A RID: 35194
			private static readonly IntPtr NativeFieldInfoPtr_LastUpdatedDistance;

			// Token: 0x0400897B RID: 35195
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Vector3_0;

			// Token: 0x0400897C RID: 35196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009A8 RID: 2472
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<Jump>d__114")]
		public sealed class _Jump_d__114 : Il2CppSystem.Object
		{
			// Token: 0x0600CB63 RID: 52067 RVA: 0x00311C14 File Offset: 0x0030FE14
			// Note: this type is marked as 'beforefieldinit'.
			static _Jump_d__114()
			{
				Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<Jump>d__114");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr);
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<>1__state");
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<>2__current");
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<>4__this");
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr__savedSlopeLimit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<savedSlopeLimit>5__2");
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673570);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673571);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673572);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673573);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673574);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673575);
			}

			// Token: 0x0600CB64 RID: 52068 RVA: 0x00311D08 File Offset: 0x0030FF08
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Jump_d__114(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB65 RID: 52069 RVA: 0x00311D50 File Offset: 0x0030FF50
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB66 RID: 52070 RVA: 0x00311D84 File Offset: 0x0030FF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176688, XrefRangeEnd = 176707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F5E RID: 16222
			// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00311DC0 File Offset: 0x0030FFC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB68 RID: 52072 RVA: 0x00311E00 File Offset: 0x00310000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176707, XrefRangeEnd = 176712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F5F RID: 16223
			// (get) Token: 0x0600CB69 RID: 52073 RVA: 0x00311E34 File Offset: 0x00310034
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB6A RID: 52074 RVA: 0x00062EB4 File Offset: 0x000610B4
			public _Jump_d__114(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F5A RID: 16218
			// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x00311E74 File Offset: 0x00310074
			// (set) Token: 0x0600CB6C RID: 52076 RVA: 0x00062EBD File Offset: 0x000610BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F5B RID: 16219
			// (get) Token: 0x0600CB6D RID: 52077 RVA: 0x00311E9C File Offset: 0x0031009C
			// (set) Token: 0x0600CB6E RID: 52078 RVA: 0x00062ED8 File Offset: 0x000610D8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5C RID: 16220
			// (get) Token: 0x0600CB6F RID: 52079 RVA: 0x00311ECC File Offset: 0x003100CC
			// (set) Token: 0x0600CB70 RID: 52080 RVA: 0x00062EF7 File Offset: 0x000610F7
			public unsafe PlayerMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5D RID: 16221
			// (get) Token: 0x0600CB71 RID: 52081 RVA: 0x00311EFC File Offset: 0x003100FC
			// (set) Token: 0x0600CB72 RID: 52082 RVA: 0x00062F16 File Offset: 0x00061116
			public unsafe float _savedSlopeLimit_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr__savedSlopeLimit_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr__savedSlopeLimit_5__2)) = value;
				}
			}

			// Token: 0x0400897D RID: 35197
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400897E RID: 35198
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400897F RID: 35199
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008980 RID: 35200
			private static readonly IntPtr NativeFieldInfoPtr__savedSlopeLimit_5__2;

			// Token: 0x04008981 RID: 35201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008982 RID: 35202
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008983 RID: 35203
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008984 RID: 35204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008985 RID: 35205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008986 RID: 35206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009A9 RID: 2473
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<LerpPlayerRotation_Process>d__122")]
		public sealed class _LerpPlayerRotation_Process_d__122 : Il2CppSystem.Object
		{
			// Token: 0x0600CB73 RID: 52083 RVA: 0x00311F24 File Offset: 0x00310124
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpPlayerRotation_Process_d__122()
			{
				Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<LerpPlayerRotation_Process>d__122");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<>1__state");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<>2__current");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<>4__this");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_endRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "endRotation");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "lerpTime");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<startRot>5__2");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<i>5__3");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673576);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673577);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673578);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673579);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673580);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673581);
			}

			// Token: 0x0600CB74 RID: 52084 RVA: 0x00312054 File Offset: 0x00310254
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpPlayerRotation_Process_d__122(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB75 RID: 52085 RVA: 0x0031209C File Offset: 0x0031029C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB76 RID: 52086 RVA: 0x003120D0 File Offset: 0x003102D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176712, XrefRangeEnd = 176725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F67 RID: 16231
			// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x0031210C File Offset: 0x0031030C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB78 RID: 52088 RVA: 0x0031214C File Offset: 0x0031034C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176725, XrefRangeEnd = 176730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F68 RID: 16232
			// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x00312180 File Offset: 0x00310380
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB7A RID: 52090 RVA: 0x00062F31 File Offset: 0x00061131
			public _LerpPlayerRotation_Process_d__122(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F60 RID: 16224
			// (get) Token: 0x0600CB7B RID: 52091 RVA: 0x003121C0 File Offset: 0x003103C0
			// (set) Token: 0x0600CB7C RID: 52092 RVA: 0x00062F3A File Offset: 0x0006113A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F61 RID: 16225
			// (get) Token: 0x0600CB7D RID: 52093 RVA: 0x003121E8 File Offset: 0x003103E8
			// (set) Token: 0x0600CB7E RID: 52094 RVA: 0x00062F55 File Offset: 0x00061155
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F62 RID: 16226
			// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x00312218 File Offset: 0x00310418
			// (set) Token: 0x0600CB80 RID: 52096 RVA: 0x00062F74 File Offset: 0x00061174
			public unsafe PlayerMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F63 RID: 16227
			// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00312248 File Offset: 0x00310448
			// (set) Token: 0x0600CB82 RID: 52098 RVA: 0x00062F93 File Offset: 0x00061193
			public unsafe Quaternion endRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_endRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_endRotation)) = value;
				}
			}

			// Token: 0x17003F64 RID: 16228
			// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x00312270 File Offset: 0x00310470
			// (set) Token: 0x0600CB84 RID: 52100 RVA: 0x00062FAE File Offset: 0x000611AE
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F65 RID: 16229
			// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x00312298 File Offset: 0x00310498
			// (set) Token: 0x0600CB86 RID: 52102 RVA: 0x00062FC9 File Offset: 0x000611C9
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17003F66 RID: 16230
			// (get) Token: 0x0600CB87 RID: 52103 RVA: 0x003122C0 File Offset: 0x003104C0
			// (set) Token: 0x0600CB88 RID: 52104 RVA: 0x00062FE4 File Offset: 0x000611E4
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008987 RID: 35207
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008988 RID: 35208
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008989 RID: 35209
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400898A RID: 35210
			private static readonly IntPtr NativeFieldInfoPtr_endRotation;

			// Token: 0x0400898B RID: 35211
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400898C RID: 35212
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x0400898D RID: 35213
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400898E RID: 35214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400898F RID: 35215
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008990 RID: 35216
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008991 RID: 35217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008992 RID: 35218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008993 RID: 35219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
