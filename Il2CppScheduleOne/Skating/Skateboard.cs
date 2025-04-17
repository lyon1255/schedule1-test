using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A5 RID: 421
	public class Skateboard : NetworkBehaviour
	{
		// Token: 0x06002278 RID: 8824 RVA: 0x000DC404 File Offset: 0x000DA604
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard()
		{
			Il2CppClassPointerStore<Skateboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard>.NativeClassPtr);
			Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundedRaycastDistance");
			Skateboard.NativeFieldInfoPtr_JumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpCooldown");
			Skateboard.NativeFieldInfoPtr_JumpForceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceMin");
			Skateboard.NativeFieldInfoPtr_JumpForceBuildTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceBuildTime");
			Skateboard.NativeFieldInfoPtr_PushCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushCooldown");
			Skateboard.NativeFieldInfoPtr_PushStaminaConsumption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushStaminaConsumption");
			Skateboard.NativeFieldInfoPtr_PitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PitchLimit");
			Skateboard.NativeFieldInfoPtr_RollLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RollLimit");
			Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CurrentSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<CurrentSteerInput>k__BackingField");
			Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr__Rider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<Rider>k__BackingField");
			Skateboard.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Rb");
			Skateboard.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CoM");
			Skateboard.NativeFieldInfoPtr_HoverPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverPoints");
			Skateboard.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxlePosition");
			Skateboard.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxlePosition");
			Skateboard.NativeFieldInfoPtr_PlayerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PlayerContainer");
			Skateboard.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Animation");
			Skateboard.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "VelocityCalculator");
			Skateboard.NativeFieldInfoPtr_Accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Accelerometer");
			Skateboard.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Equippable");
			Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "IKAlignmentsContainer");
			Skateboard.NativeFieldInfoPtr_TurnForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForce");
			Skateboard.NativeFieldInfoPtr_TurnChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnChangeRate");
			Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnReturnToRestRate");
			Skateboard.NativeFieldInfoPtr_TurnSpeedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnSpeedBoost");
			Skateboard.NativeFieldInfoPtr_TurnForceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForceMap");
			Skateboard.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Gravity");
			Skateboard.NativeFieldInfoPtr_BrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "BrakeForce");
			Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "ReverseTopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundDetectionMask");
			Skateboard.NativeFieldInfoPtr_MainColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "MainColliders");
			Skateboard.NativeFieldInfoPtr_RotationClampForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RotationClampForce");
			Skateboard.NativeFieldInfoPtr_FrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrictionEnabled");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionCurve");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionMultiplier");
			Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LateralFrictionForceMultiplier");
			Skateboard.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForce");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Min");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Max");
			Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardForceCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardBoost");
			Skateboard.NativeFieldInfoPtr_HoverForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverForce");
			Skateboard.NativeFieldInfoPtr_HoverRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverRayLength");
			Skateboard.NativeFieldInfoPtr_HoverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverHeight");
			Skateboard.NativeFieldInfoPtr_Hover_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_P");
			Skateboard.NativeFieldInfoPtr_Hover_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_I");
			Skateboard.NativeFieldInfoPtr_Hover_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_D");
			Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplier");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplierMap");
			Skateboard.NativeFieldInfoPtr_PushForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceDuration");
			Skateboard.NativeFieldInfoPtr_PushDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushDelay");
			Skateboard.NativeFieldInfoPtr_PushForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceCurve");
			Skateboard.NativeFieldInfoPtr_AirMovementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementEnabled");
			Skateboard.NativeFieldInfoPtr_AirMovementForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementForce");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionDuration");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionCurve");
			Skateboard.NativeFieldInfoPtr_OnPushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnPushStart");
			Skateboard.NativeFieldInfoPtr_OnJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnJump");
			Skateboard.NativeFieldInfoPtr_OnLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnLand");
			Skateboard.NativeFieldInfoPtr_horizontalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "horizontalInput");
			Skateboard.NativeFieldInfoPtr_jumpReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpReleased");
			Skateboard.NativeFieldInfoPtr_timeSinceLastJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSinceLastJump");
			Skateboard.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeGrounded");
			Skateboard.NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeAirborne");
			Skateboard.NativeFieldInfoPtr_jumpHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpHeldTime");
			Skateboard.NativeFieldInfoPtr_frontAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "frontAxleForce");
			Skateboard.NativeFieldInfoPtr_rearAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "rearAxleForce");
			Skateboard.NativeFieldInfoPtr_jumpForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpForwardForce");
			Skateboard.NativeFieldInfoPtr_hoverPIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "hoverPIDs");
			Skateboard.NativeFieldInfoPtr_pushQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "pushQueued");
			Skateboard.NativeFieldInfoPtr_isPushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "isPushing");
			Skateboard.NativeFieldInfoPtr_thisFramePushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "thisFramePushForce");
			Skateboard.NativeFieldInfoPtr_timeSincePushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSincePushStart");
			Skateboard.NativeFieldInfoPtr_braking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "braking");
			Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "syncVar___<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667191);
			Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667192);
			Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667193);
			Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667194);
			Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667195);
			Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667196);
			Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667197);
			Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667198);
			Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667199);
			Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667200);
			Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667201);
			Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667202);
			Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667203);
			Skateboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667204);
			Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667205);
			Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667206);
			Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667207);
			Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667208);
			Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667209);
			Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667210);
			Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667211);
			Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667212);
			Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667213);
			Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667214);
			Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667215);
			Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667216);
			Skateboard.NativeMethodInfoPtr_Push_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667217);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667218);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667219);
			Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667220);
			Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667221);
			Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667222);
			Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667223);
			Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667224);
			Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667225);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667226);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667227);
			Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667228);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667229);
			Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667230);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667231);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667232);
			Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667233);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667234);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667235);
			Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667236);
			Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667237);
			Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667238);
			Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667239);
			Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667240);
			Skateboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667241);
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000DCE98 File Offset: 0x000DB098
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x000DCED4 File Offset: 0x000DB0D4
		public unsafe float CurrentSteerInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86619, RefRangeEnd = 86621, XrefRangeStart = 86619, XrefRangeEnd = 86621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000DCF14 File Offset: 0x000DB114
		public unsafe bool IsPushing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000DCF50 File Offset: 0x000DB150
		public unsafe float TimeSincePushStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x000DCF8C File Offset: 0x000DB18C
		public unsafe bool isGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x000DCFC8 File Offset: 0x000DB1C8
		public unsafe float AirTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x000DD004 File Offset: 0x000DB204
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x000DD040 File Offset: 0x000DB240
		public unsafe float JumpBuildAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111780, XrefRangeEnd = 111809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x000DD080 File Offset: 0x000DB280
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x000DD0C0 File Offset: 0x000DB2C0
		public unsafe Player Rider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000DD104 File Offset: 0x000DB304
		public unsafe float TopSpeed_Ms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000DD140 File Offset: 0x000DB340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111809, XrefRangeEnd = 111810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000DD17C File Offset: 0x000DB37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111810, XrefRangeEnd = 111823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000DD1B8 File Offset: 0x000DB3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111823, XrefRangeEnd = 111826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000DD1EC File Offset: 0x000DB3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111901, RefRangeEnd = 111902, XrefRangeStart = 111826, XrefRangeEnd = 111901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000DD220 File Offset: 0x000DB420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111902, XrefRangeEnd = 111920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000DD254 File Offset: 0x000DB454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111920, XrefRangeEnd = 111922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000DD288 File Offset: 0x000DB488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111972, RefRangeEnd = 111973, XrefRangeStart = 111922, XrefRangeEnd = 111972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000DD2BC File Offset: 0x000DB4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112000, RefRangeEnd = 112001, XrefRangeStart = 111973, XrefRangeEnd = 112000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLateralFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000DD2F0 File Offset: 0x000DB4F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112046, RefRangeEnd = 112047, XrefRangeStart = 112001, XrefRangeEnd = 112046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000DD324 File Offset: 0x000DB524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112047, XrefRangeEnd = 112059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGravity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000DD358 File Offset: 0x000DB558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112061, RefRangeEnd = 112062, XrefRangeStart = 112059, XrefRangeEnd = 112061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000DD38C File Offset: 0x000DB58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112093, RefRangeEnd = 112094, XrefRangeStart = 112062, XrefRangeEnd = 112093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000DD3C0 File Offset: 0x000DB5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112127, RefRangeEnd = 112129, XrefRangeStart = 112094, XrefRangeEnd = 112127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendJump(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000DD400 File Offset: 0x000DB600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112151, RefRangeEnd = 112153, XrefRangeStart = 112129, XrefRangeEnd = 112151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveJump(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000DD440 File Offset: 0x000DB640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112153, XrefRangeEnd = 112168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000DD474 File Offset: 0x000DB674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112168, XrefRangeEnd = 112175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Push_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000DD4A8 File Offset: 0x000DB6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112175, XrefRangeEnd = 112176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000DD4E4 File Offset: 0x000DB6E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 112195, RefRangeEnd = 112200, XrefRangeStart = 112176, XrefRangeEnd = 112195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000DD530 File Offset: 0x000DB730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112200, XrefRangeEnd = 112202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000DD570 File Offset: 0x000DB770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112235, RefRangeEnd = 112236, XrefRangeStart = 112202, XrefRangeEnd = 112235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000DD5A4 File Offset: 0x000DB7A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112243, RefRangeEnd = 112245, XrefRangeStart = 112236, XrefRangeEnd = 112243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPlayerScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000DD5D8 File Offset: 0x000DB7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112245, XrefRangeEnd = 112252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceSmoothness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000DD614 File Offset: 0x000DB814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112252, XrefRangeEnd = 112260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000DD650 File Offset: 0x000DB850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112260, XrefRangeEnd = 112265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000DD690 File Offset: 0x000DB890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112265, XrefRangeEnd = 112301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000DD6CC File Offset: 0x000DB8CC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000DD708 File Offset: 0x000DB908
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000DD744 File Offset: 0x000DB944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000DD784 File Offset: 0x000DB984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112301, XrefRangeEnd = 112308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000DD7C4 File Offset: 0x000DB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112308, XrefRangeEnd = 112318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000DD828 File Offset: 0x000DBA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112318, XrefRangeEnd = 112347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000DD868 File Offset: 0x000DBA68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112151, RefRangeEnd = 112153, XrefRangeStart = 112151, XrefRangeEnd = 112153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000DD8A8 File Offset: 0x000DBAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112347, XrefRangeEnd = 112352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000DD90C File Offset: 0x000DBB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112352, XrefRangeEnd = 112371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000DD94C File Offset: 0x000DBB4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112375, RefRangeEnd = 112378, XrefRangeStart = 112371, XrefRangeEnd = 112375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x000DD98C File Offset: 0x000DBB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112378, XrefRangeEnd = 112382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x000DD9DC File Offset: 0x000DBBDC
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x000DDA18 File Offset: 0x000DBC18
		public unsafe float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112382, XrefRangeEnd = 112390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000DDA64 File Offset: 0x000DBC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112390, XrefRangeEnd = 112391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Skating_Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000DDAD8 File Offset: 0x000DBCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112415, RefRangeEnd = 112416, XrefRangeStart = 112391, XrefRangeEnd = 112415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000133B1 File Offset: 0x000115B1
		public Skateboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000DDB0C File Offset: 0x000DBD0C
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x000133BA File Offset: 0x000115BA
		public unsafe static float GroundedRaycastDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance, (void*)(&value));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000DDB28 File Offset: 0x000DBD28
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x000133C8 File Offset: 0x000115C8
		public unsafe static float JumpCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x000DDB44 File Offset: 0x000DBD44
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x000133D6 File Offset: 0x000115D6
		public unsafe static float JumpForceMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&value));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000DDB60 File Offset: 0x000DBD60
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x000133E4 File Offset: 0x000115E4
		public unsafe static float JumpForceBuildTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000DDB7C File Offset: 0x000DBD7C
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x000133F2 File Offset: 0x000115F2
		public unsafe static float PushCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000DDB98 File Offset: 0x000DBD98
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00013400 File Offset: 0x00011600
		public unsafe static float PushStaminaConsumption
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&value));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000DDBB4 File Offset: 0x000DBDB4
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x0001340E File Offset: 0x0001160E
		public unsafe static float PitchLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&value));
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x000DDBD0 File Offset: 0x000DBDD0
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0001341C File Offset: 0x0001161C
		public unsafe static float RollLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000DDBEC File Offset: 0x000DBDEC
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0001342A File Offset: 0x0001162A
		public unsafe float CurrentSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000DDC14 File Offset: 0x000DBE14
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00013445 File Offset: 0x00011645
		public unsafe float _CurrentSteerInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000DDC3C File Offset: 0x000DBE3C
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00013460 File Offset: 0x00011660
		public unsafe float _JumpBuildAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000DDC64 File Offset: 0x000DBE64
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0001347B File Offset: 0x0001167B
		public unsafe Player _Rider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000DDC94 File Offset: 0x000DBE94
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x0001349A File Offset: 0x0001169A
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000DDCC4 File Offset: 0x000DBEC4
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x000134B9 File Offset: 0x000116B9
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000DDCF4 File Offset: 0x000DBEF4
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x000134D8 File Offset: 0x000116D8
		public unsafe Il2CppReferenceArray<Transform> HoverPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000DDD24 File Offset: 0x000DBF24
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x000134F7 File Offset: 0x000116F7
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000DDD54 File Offset: 0x000DBF54
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x00013516 File Offset: 0x00011716
		public unsafe Transform RearAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000DDD84 File Offset: 0x000DBF84
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x00013535 File Offset: 0x00011735
		public unsafe Transform PlayerContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000DDDB4 File Offset: 0x000DBFB4
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00013554 File Offset: 0x00011754
		public unsafe SkateboardAnimation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000DDDE4 File Offset: 0x000DBFE4
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x00013573 File Offset: 0x00011773
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000DDE14 File Offset: 0x000DC014
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00013592 File Offset: 0x00011792
		public unsafe AverageAcceleration Accelerometer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000DDE44 File Offset: 0x000DC044
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x000135B1 File Offset: 0x000117B1
		public unsafe Skateboard_Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard_Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000DDE74 File Offset: 0x000DC074
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x000135D0 File Offset: 0x000117D0
		public unsafe Transform IKAlignmentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000DDEA4 File Offset: 0x000DC0A4
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x000135EF File Offset: 0x000117EF
		public unsafe float TurnForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce)) = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000DDECC File Offset: 0x000DC0CC
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0001360A File Offset: 0x0001180A
		public unsafe float TurnChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate)) = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000DDEF4 File Offset: 0x000DC0F4
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00013625 File Offset: 0x00011825
		public unsafe float TurnReturnToRestRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate)) = value;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000DDF1C File Offset: 0x000DC11C
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00013640 File Offset: 0x00011840
		public unsafe float TurnSpeedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost)) = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000DDF44 File Offset: 0x000DC144
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x0001365B File Offset: 0x0001185B
		public unsafe AnimationCurve TurnForceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000DDF74 File Offset: 0x000DC174
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x0001367A File Offset: 0x0001187A
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000DDF9C File Offset: 0x000DC19C
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x00013695 File Offset: 0x00011895
		public unsafe float BrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce)) = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000DDFC4 File Offset: 0x000DC1C4
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x000136B0 File Offset: 0x000118B0
		public unsafe float ReverseTopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000DDFEC File Offset: 0x000DC1EC
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x000136CB File Offset: 0x000118CB
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x000DE014 File Offset: 0x000DC214
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x000136E6 File Offset: 0x000118E6
		public unsafe Il2CppReferenceArray<Collider> MainColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000DE044 File Offset: 0x000DC244
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00013705 File Offset: 0x00011905
		public unsafe float RotationClampForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce)) = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000DE06C File Offset: 0x000DC26C
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00013720 File Offset: 0x00011920
		public unsafe bool FrictionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000DE094 File Offset: 0x000DC294
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0001373B File Offset: 0x0001193B
		public unsafe AnimationCurve LongitudinalFrictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x000DE0C4 File Offset: 0x000DC2C4
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0001375A File Offset: 0x0001195A
		public unsafe float LongitudinalFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier)) = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x000DE0EC File Offset: 0x000DC2EC
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x00013775 File Offset: 0x00011975
		public unsafe float LateralFrictionForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x000DE114 File Offset: 0x000DC314
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x00013790 File Offset: 0x00011990
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000DE13C File Offset: 0x000DC33C
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x000137AB File Offset: 0x000119AB
		public unsafe float JumpDuration_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min)) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000DE164 File Offset: 0x000DC364
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x000137C6 File Offset: 0x000119C6
		public unsafe float JumpDuration_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000DE18C File Offset: 0x000DC38C
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x000137E1 File Offset: 0x000119E1
		public unsafe AnimationCurve FrontAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000DE1BC File Offset: 0x000DC3BC
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x00013800 File Offset: 0x00011A00
		public unsafe AnimationCurve RearAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000DE1EC File Offset: 0x000DC3EC
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0001381F File Offset: 0x00011A1F
		public unsafe AnimationCurve JumpForwardForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000DE21C File Offset: 0x000DC41C
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0001383E File Offset: 0x00011A3E
		public unsafe float JumpForwardBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost)) = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000DE244 File Offset: 0x000DC444
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x00013859 File Offset: 0x00011A59
		public unsafe float HoverForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce)) = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000DE26C File Offset: 0x000DC46C
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x00013874 File Offset: 0x00011A74
		public unsafe float HoverRayLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength)) = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000DE294 File Offset: 0x000DC494
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x0001388F File Offset: 0x00011A8F
		public unsafe float HoverHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight)) = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000DE2BC File Offset: 0x000DC4BC
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x000138AA File Offset: 0x00011AAA
		public unsafe float Hover_P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P)) = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000DE2E4 File Offset: 0x000DC4E4
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x000138C5 File Offset: 0x00011AC5
		public unsafe float Hover_I
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I)) = value;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000DE30C File Offset: 0x000DC50C
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x000138E0 File Offset: 0x00011AE0
		public unsafe float Hover_D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D)) = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000DE334 File Offset: 0x000DC534
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x000138FB File Offset: 0x00011AFB
		public unsafe float TopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000DE35C File Offset: 0x000DC55C
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x00013916 File Offset: 0x00011B16
		public unsafe float PushForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier)) = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000DE384 File Offset: 0x000DC584
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00013931 File Offset: 0x00011B31
		public unsafe AnimationCurve PushForceMultiplierMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x000DE3B4 File Offset: 0x000DC5B4
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00013950 File Offset: 0x00011B50
		public unsafe float PushForceDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration)) = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x000DE3DC File Offset: 0x000DC5DC
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x0001396B File Offset: 0x00011B6B
		public unsafe float PushDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay)) = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x000DE404 File Offset: 0x000DC604
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x00013986 File Offset: 0x00011B86
		public unsafe AnimationCurve PushForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000DE434 File Offset: 0x000DC634
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x000139A5 File Offset: 0x00011BA5
		public unsafe bool AirMovementEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled)) = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x000DE45C File Offset: 0x000DC65C
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x000139C0 File Offset: 0x00011BC0
		public unsafe float AirMovementForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce)) = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x000DE484 File Offset: 0x000DC684
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x000139DB File Offset: 0x00011BDB
		public unsafe float AirMovementJumpReductionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration)) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x000DE4AC File Offset: 0x000DC6AC
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x000139F6 File Offset: 0x00011BF6
		public unsafe AnimationCurve AirMovementJumpReductionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000DE4DC File Offset: 0x000DC6DC
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00013A15 File Offset: 0x00011C15
		public unsafe UnityEvent OnPushStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000DE50C File Offset: 0x000DC70C
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x00013A34 File Offset: 0x00011C34
		public unsafe UnityEvent<float> OnJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000DE53C File Offset: 0x000DC73C
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x00013A53 File Offset: 0x00011C53
		public unsafe UnityEvent OnLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000DE56C File Offset: 0x000DC76C
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x00013A72 File Offset: 0x00011C72
		public unsafe int horizontalInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput)) = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000DE594 File Offset: 0x000DC794
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00013A8D File Offset: 0x00011C8D
		public unsafe bool jumpReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased)) = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x000DE5BC File Offset: 0x000DC7BC
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00013AA8 File Offset: 0x00011CA8
		public unsafe float timeSinceLastJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump)) = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x000DE5E4 File Offset: 0x000DC7E4
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00013AC3 File Offset: 0x00011CC3
		public unsafe float timeGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x000DE60C File Offset: 0x000DC80C
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00013ADE File Offset: 0x00011CDE
		public unsafe float timeAirborne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne)) = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000DE634 File Offset: 0x000DC834
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00013AF9 File Offset: 0x00011CF9
		public unsafe float jumpHeldTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime)) = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000DE65C File Offset: 0x000DC85C
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00013B14 File Offset: 0x00011D14
		public unsafe float frontAxleForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce)) = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000DE684 File Offset: 0x000DC884
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x00013B2F File Offset: 0x00011D2F
		public unsafe float rearAxleForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce)) = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000DE6AC File Offset: 0x000DC8AC
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00013B4A File Offset: 0x00011D4A
		public unsafe float jumpForwardForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce)) = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000DE6D4 File Offset: 0x000DC8D4
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00013B65 File Offset: 0x00011D65
		public unsafe List<PID> hoverPIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000DE704 File Offset: 0x000DC904
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x00013B84 File Offset: 0x00011D84
		public unsafe bool pushQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued)) = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000DE72C File Offset: 0x000DC92C
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00013B9F File Offset: 0x00011D9F
		public unsafe bool isPushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000DE754 File Offset: 0x000DC954
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x00013BBA File Offset: 0x00011DBA
		public unsafe float thisFramePushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce)) = value;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000DE77C File Offset: 0x000DC97C
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00013BD5 File Offset: 0x00011DD5
		public unsafe float timeSincePushStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart)) = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000DE7A4 File Offset: 0x000DC9A4
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00013BF0 File Offset: 0x00011DF0
		public unsafe bool braking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking)) = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x000DE7CC File Offset: 0x000DC9CC
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x00013C0B File Offset: 0x00011E0B
		public unsafe SyncVar<float> syncVar____JumpBuildAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000DE7FC File Offset: 0x000DC9FC
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00013C2A File Offset: 0x00011E2A
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000DE824 File Offset: 0x000DCA24
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00013C45 File Offset: 0x00011E45
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_GroundedRaycastDistance;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr_JumpCooldown;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeFieldInfoPtr_JumpForceMin;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeFieldInfoPtr_JumpForceBuildTime;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr_PushCooldown;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_PushStaminaConsumption;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_PitchLimit;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_RollLimit;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSpeed_Kmh;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSteerInput_k__BackingField;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr__JumpBuildAmount_k__BackingField;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr__Rider_k__BackingField;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_HoverPoints;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr_PlayerContainer;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_Accelerometer;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_IKAlignmentsContainer;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_TurnForce;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_TurnChangeRate;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_TurnReturnToRestRate;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_TurnSpeedBoost;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_TurnForceMap;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_BrakeForce;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_ReverseTopSpeed_Kmh;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_MainColliders;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_RotationClampForce;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_FrictionEnabled;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionCurve;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionMultiplier;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_LateralFrictionForceMultiplier;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Min;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Max;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxleJumpCurve;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr_RearAxleJumpCurve;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardForceCurve;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardBoost;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_HoverForce;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_HoverRayLength;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_HoverHeight;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_Hover_P;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_Hover_I;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_Hover_D;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed_Kmh;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplier;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplierMap;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr_PushForceDuration;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr_PushDelay;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr_PushForceCurve;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementEnabled;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementForce;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionDuration;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionCurve;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeFieldInfoPtr_OnPushStart;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_OnJump;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeFieldInfoPtr_OnLand;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_horizontalInput;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_jumpReleased;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastJump;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_timeAirborne;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_jumpHeldTime;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_frontAxleForce;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_rearAxleForce;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_jumpForwardForce;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_hoverPIDs;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_pushQueued;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr_isPushing;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeFieldInfoPtr_thisFramePushForce;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePushStart;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeFieldInfoPtr_braking;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_get_AirTime_Public_get_Single_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_get_Rider_Public_get_Player_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_1;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_1;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInput_Private_Void_1;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_1;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGravity_Private_Void_1;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_CheckGrounded_Private_Void_1;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_CheckJump_Private_Void_1;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_SendJump_Private_Void_Single_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_1;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_1;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_ClampRotation_Private_Void_1;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x020008C7 RID: 2247
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<<Push>g__Push|113_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C3C0 RID: 50112 RVA: 0x002FB8B0 File Offset: 0x002F9AB0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique()
			{
				Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<<Push>g__Push|113_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>1__state");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>2__current");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>4__this");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<i>5__2");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667242);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667243);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667244);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667245);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667246);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667247);
			}

			// Token: 0x0600C3C1 RID: 50113 RVA: 0x002FB9A4 File Offset: 0x002F9BA4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3C2 RID: 50114 RVA: 0x002FB9EC File Offset: 0x002F9BEC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3C3 RID: 50115 RVA: 0x002FBA20 File Offset: 0x002F9C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111743, XrefRangeEnd = 111752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D21 RID: 15649
			// (get) Token: 0x0600C3C4 RID: 50116 RVA: 0x002FBA5C File Offset: 0x002F9C5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C3C5 RID: 50117 RVA: 0x002FBA9C File Offset: 0x002F9C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111752, XrefRangeEnd = 111757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D22 RID: 15650
			// (get) Token: 0x0600C3C6 RID: 50118 RVA: 0x002FBAD0 File Offset: 0x002F9CD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C3C7 RID: 50119 RVA: 0x0005F475 File Offset: 0x0005D675
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1D RID: 15645
			// (get) Token: 0x0600C3C8 RID: 50120 RVA: 0x002FBB10 File Offset: 0x002F9D10
			// (set) Token: 0x0600C3C9 RID: 50121 RVA: 0x0005F47E File Offset: 0x0005D67E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D1E RID: 15646
			// (get) Token: 0x0600C3CA RID: 50122 RVA: 0x002FBB38 File Offset: 0x002F9D38
			// (set) Token: 0x0600C3CB RID: 50123 RVA: 0x0005F499 File Offset: 0x0005D699
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D1F RID: 15647
			// (get) Token: 0x0600C3CC RID: 50124 RVA: 0x002FBB68 File Offset: 0x002F9D68
			// (set) Token: 0x0600C3CD RID: 50125 RVA: 0x0005F4B8 File Offset: 0x0005D6B8
			public unsafe Skateboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D20 RID: 15648
			// (get) Token: 0x0600C3CE RID: 50126 RVA: 0x002FBB98 File Offset: 0x002F9D98
			// (set) Token: 0x0600C3CF RID: 50127 RVA: 0x0005F4D7 File Offset: 0x0005D6D7
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040084B3 RID: 33971
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084B4 RID: 33972
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084B5 RID: 33973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084B6 RID: 33974
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040084B7 RID: 33975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084B8 RID: 33976
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084B9 RID: 33977
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084BA RID: 33978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084BB RID: 33979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084BC RID: 33980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008C8 RID: 2248
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3D0 RID: 50128 RVA: 0x002FBBC0 File Offset: 0x002F9DC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr);
				Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "<>4__this");
				Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "JumpDuration");
				Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, 100667248);
				Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, 100667249);
			}

			// Token: 0x0600C3D1 RID: 50129 RVA: 0x002FBC3C File Offset: 0x002F9E3C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3D2 RID: 50130 RVA: 0x002FBC78 File Offset: 0x002F9E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111775, XrefRangeEnd = 111780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C3D3 RID: 50131 RVA: 0x0005F4F2 File Offset: 0x0005D6F2
			public __c__DisplayClass112_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D23 RID: 15651
			// (get) Token: 0x0600C3D4 RID: 50132 RVA: 0x002FBCB8 File Offset: 0x002F9EB8
			// (set) Token: 0x0600C3D5 RID: 50133 RVA: 0x0005F4FB File Offset: 0x0005D6FB
			public unsafe Skateboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D24 RID: 15652
			// (get) Token: 0x0600C3D6 RID: 50134 RVA: 0x002FBCE8 File Offset: 0x002F9EE8
			// (set) Token: 0x0600C3D7 RID: 50135 RVA: 0x0005F51A File Offset: 0x0005D71A
			public unsafe float JumpDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration)) = value;
				}
			}

			// Token: 0x040084BD RID: 33981
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084BE RID: 33982
			private static readonly IntPtr NativeFieldInfoPtr_JumpDuration;

			// Token: 0x040084BF RID: 33983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084C0 RID: 33984
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C31 RID: 3121
			[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0+<<Jump>g__Jump|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E13B RID: 57659 RVA: 0x0034F1DC File Offset: 0x0034D3DC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "<<Jump>g__Jump|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667250);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667251);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667252);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667253);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667254);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667255);
				}

				// Token: 0x0600E13C RID: 57660 RVA: 0x0034F2D0 File Offset: 0x0034D4D0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E13D RID: 57661 RVA: 0x0034F318 File Offset: 0x0034D518
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E13E RID: 57662 RVA: 0x0034F34C File Offset: 0x0034D54C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111757, XrefRangeEnd = 111770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045CA RID: 17866
				// (get) Token: 0x0600E13F RID: 57663 RVA: 0x0034F388 File Offset: 0x0034D588
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E140 RID: 57664 RVA: 0x0034F3C8 File Offset: 0x0034D5C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111770, XrefRangeEnd = 111775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045CB RID: 17867
				// (get) Token: 0x0600E141 RID: 57665 RVA: 0x0034F3FC File Offset: 0x0034D5FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E142 RID: 57666 RVA: 0x0006DCFF File Offset: 0x0006BEFF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C6 RID: 17862
				// (get) Token: 0x0600E143 RID: 57667 RVA: 0x0034F43C File Offset: 0x0034D63C
				// (set) Token: 0x0600E144 RID: 57668 RVA: 0x0006DD08 File Offset: 0x0006BF08
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045C7 RID: 17863
				// (get) Token: 0x0600E145 RID: 57669 RVA: 0x0034F464 File Offset: 0x0034D664
				// (set) Token: 0x0600E146 RID: 57670 RVA: 0x0006DD23 File Offset: 0x0006BF23
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045C8 RID: 17864
				// (get) Token: 0x0600E147 RID: 57671 RVA: 0x0034F494 File Offset: 0x0034D694
				// (set) Token: 0x0600E148 RID: 57672 RVA: 0x0006DD42 File Offset: 0x0006BF42
				public unsafe Skateboard.__c__DisplayClass112_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard.__c__DisplayClass112_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045C9 RID: 17865
				// (get) Token: 0x0600E149 RID: 57673 RVA: 0x0034F4C4 File Offset: 0x0034D6C4
				// (set) Token: 0x0600E14A RID: 57674 RVA: 0x0006DD61 File Offset: 0x0006BF61
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x040096CF RID: 38607
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096D0 RID: 38608
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096D1 RID: 38609
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096D2 RID: 38610
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x040096D3 RID: 38611
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096D4 RID: 38612
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096D5 RID: 38613
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096D6 RID: 38614
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096D7 RID: 38615
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096D8 RID: 38616
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
