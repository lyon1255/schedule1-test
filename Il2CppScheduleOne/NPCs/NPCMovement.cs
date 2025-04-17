using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D9 RID: 729
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x06003506 RID: 13574 RVA: 0x0011AEB4 File Offset: 0x001190B4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCMovement()
		{
			Il2CppClassPointerStore<NPCMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr);
			NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VEHICLE_RUNOVER_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SKATEBOARD_RUNOVER_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_ANNOYED_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "USE_PATH_CACHE");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_DURATION");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_FORCE");
			NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "OBSTACLE_AVOIDANCE_RANGE");
			NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "PLAYER_DIST_IMPACT_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestReachablePoints");
			NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestPointKeys");
			NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET");
			NPCMovement.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DEBUG");
			NPCMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "WalkSpeed");
			NPCMovement.NativeFieldInfoPtr_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RunSpeed");
			NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MoveSpeedMultiplier");
			NPCMovement.NativeFieldInfoPtr_SlipperyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyMode");
			NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyModeMultiplier");
			NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DefaultObstacleAvoidanceType");
			NPCMovement.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "Agent");
			NPCMovement.NativeFieldInfoPtr_SpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SpeedController");
			NPCMovement.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "npc");
			NPCMovement.NativeFieldInfoPtr_capsuleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "capsuleCollider");
			NPCMovement.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "anim");
			NPCMovement.NativeFieldInfoPtr_ragdollCentralRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollCentralRB");
			NPCMovement.NativeFieldInfoPtr_velocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityCalculator");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggable");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggableCollider");
			NPCMovement.NativeFieldInfoPtr_MovementSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MovementSpeedScale");
			NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<hasDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<IsPaused>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Stance>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<timeSinceHitByCar>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_ragdollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollTime");
			NPCMovement.NativeFieldInfoPtr_ragdollStaticTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollStaticTime");
			NPCMovement.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onHitByCar");
			NPCMovement.NativeFieldInfoPtr_onRagdollStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollStart");
			NPCMovement.NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollEnd");
			NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<CurrentDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<PathCache>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_cacheNextPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cacheNextPath");
			NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentDestination_Reachable");
			NPCMovement.NativeFieldInfoPtr_walkResultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "walkResultCallback");
			NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentMaxDistanceForSuccess");
			NPCMovement.NativeFieldInfoPtr_forceIsMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "forceIsMoving");
			NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "FaceDirectionRoutine");
			NPCMovement.NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollForceComponents");
			NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Disoriented>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeUntilNextStumble");
			NPCMovement.NativeFieldInfoPtr_timeSinceStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceStumble");
			NPCMovement.NativeFieldInfoPtr_stumbleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "stumbleDirection");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistory");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistoryLength");
			NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityHistorySpacing");
			NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceLastVelocityHistoryRecord");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669303);
			NPCMovement.NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669304);
			NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669305);
			NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669306);
			NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669307);
			NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669308);
			NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669309);
			NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669310);
			NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669311);
			NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669312);
			NPCMovement.NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669313);
			NPCMovement.NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669314);
			NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669315);
			NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669316);
			NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669317);
			NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669318);
			NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669319);
			NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669320);
			NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669321);
			NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669322);
			NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669323);
			NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669324);
			NPCMovement.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669325);
			NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669326);
			NPCMovement.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669327);
			NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669328);
			NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669329);
			NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669330);
			NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669331);
			NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669332);
			NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669333);
			NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669334);
			NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669335);
			NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669336);
			NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669337);
			NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669338);
			NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669339);
			NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669340);
			NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669341);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669342);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669343);
			NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669344);
			NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669345);
			NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669346);
			NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669347);
			NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669348);
			NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669349);
			NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669350);
			NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669351);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669352);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669353);
			NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669354);
			NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669355);
			NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669356);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669357);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669358);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669359);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669360);
			NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669361);
			NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669362);
			NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669363);
			NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669364);
			NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669365);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669366);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669367);
			NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669368);
			NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669369);
			NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669370);
			NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669371);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669372);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669373);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669374);
			NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669375);
			NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669376);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669378);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669379);
			NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669380);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669381);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669382);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669383);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669384);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669385);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669386);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669387);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669388);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669389);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669390);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669391);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669392);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669393);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669394);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669395);
			NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669396);
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x0011BB14 File Offset: 0x00119D14
		// (set) Token: 0x06003508 RID: 13576 RVA: 0x0011BB50 File Offset: 0x00119D50
		public unsafe bool hasDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x0011BB90 File Offset: 0x00119D90
		public unsafe bool IsMoving
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 136614, RefRangeEnd = 136688, XrefRangeStart = 136611, XrefRangeEnd = 136614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x0011BBCC File Offset: 0x00119DCC
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x0011BC08 File Offset: 0x00119E08
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x0011BC48 File Offset: 0x00119E48
		public unsafe Vector3 FootPosition
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 136690, RefRangeEnd = 136702, XrefRangeStart = 136688, XrefRangeEnd = 136690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x0011BC84 File Offset: 0x00119E84
		// (set) Token: 0x0600350E RID: 13582 RVA: 0x0011BCC0 File Offset: 0x00119EC0
		public unsafe float GravityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x0011BD00 File Offset: 0x00119F00
		// (set) Token: 0x06003510 RID: 13584 RVA: 0x0011BD3C File Offset: 0x00119F3C
		public unsafe NPCMovement.EStance Stance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 136702, RefRangeEnd = 136707, XrefRangeStart = 136702, XrefRangeEnd = 136702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x0011BD7C File Offset: 0x00119F7C
		// (set) Token: 0x06003512 RID: 13586 RVA: 0x0011BDB8 File Offset: 0x00119FB8
		public unsafe float timeSinceHitByCar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x0011BDF8 File Offset: 0x00119FF8
		public unsafe bool FaceDirectionInProgress
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 136707, RefRangeEnd = 136710, XrefRangeStart = 136707, XrefRangeEnd = 136707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x0011BE34 File Offset: 0x0011A034
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x0011BE70 File Offset: 0x0011A070
		public unsafe Vector3 CurrentDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0011BEB0 File Offset: 0x0011A0B0
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x0011BEF0 File Offset: 0x0011A0F0
		public unsafe NPCPathCache PathCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136710, XrefRangeEnd = 136711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x0011BF34 File Offset: 0x0011A134
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x0011BF70 File Offset: 0x0011A170
		public unsafe bool Disoriented
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0011BFB0 File Offset: 0x0011A1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136711, XrefRangeEnd = 136712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0011BFEC File Offset: 0x0011A1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136712, XrefRangeEnd = 136726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0011C020 File Offset: 0x0011A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136726, XrefRangeEnd = 136729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0011C05C File Offset: 0x0011A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136729, XrefRangeEnd = 136730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0011C0AC File Offset: 0x0011A2AC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0011C0E8 File Offset: 0x0011A2E8
		[CallerCount(0)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0011C124 File Offset: 0x0011A324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136730, XrefRangeEnd = 136751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0011C158 File Offset: 0x0011A358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136751, XrefRangeEnd = 136761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0011C18C File Offset: 0x0011A38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136784, RefRangeEnd = 136785, XrefRangeStart = 136761, XrefRangeEnd = 136784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0011C1C0 File Offset: 0x0011A3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136785, XrefRangeEnd = 136835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x0011C1FC File Offset: 0x0011A3FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136853, RefRangeEnd = 136854, XrefRangeStart = 136835, XrefRangeEnd = 136853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0011C230 File Offset: 0x0011A430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136854, XrefRangeEnd = 136858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0011C264 File Offset: 0x0011A464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136858, XrefRangeEnd = 136862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x0011C298 File Offset: 0x0011A498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136887, RefRangeEnd = 136888, XrefRangeStart = 136862, XrefRangeEnd = 136887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlippery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x0011C2CC File Offset: 0x0011A4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136906, RefRangeEnd = 136907, XrefRangeStart = 136888, XrefRangeEnd = 136906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0011C300 File Offset: 0x0011A500
		[CallerCount(0)]
		public unsafe bool CanRecoverFromRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0011C33C File Offset: 0x0011A53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136907, XrefRangeEnd = 136914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0011C370 File Offset: 0x0011A570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136914, XrefRangeEnd = 136917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0011C3B4 File Offset: 0x0011A5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136917, XrefRangeEnd = 136923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0011C3F8 File Offset: 0x0011A5F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136956, RefRangeEnd = 136958, XrefRangeStart = 136923, XrefRangeEnd = 136956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCollision;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0011C468 File Offset: 0x0011A668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136962, RefRangeEnd = 136964, XrefRangeStart = 136958, XrefRangeEnd = 136962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0011C4AC File Offset: 0x0011A6AC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 136981, RefRangeEnd = 137002, XrefRangeStart = 136964, XrefRangeEnd = 136981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0011C4EC File Offset: 0x0011A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137002, XrefRangeEnd = 137023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveWarp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x0011C52C File Offset: 0x0011A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137023, XrefRangeEnd = 137026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibilityChange(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0011C56C File Offset: 0x0011A76C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 137028, RefRangeEnd = 137035, XrefRangeStart = 137026, XrefRangeEnd = 137028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0011C5A8 File Offset: 0x0011A7A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 137049, RefRangeEnd = 137060, XrefRangeStart = 137035, XrefRangeEnd = 137049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAgentType(NPCMovement.EAgentType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0011C5E8 File Offset: 0x0011A7E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137069, RefRangeEnd = 137073, XrefRangeStart = 137060, XrefRangeEnd = 137069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0011C62C File Offset: 0x0011A82C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136702, RefRangeEnd = 136707, XrefRangeStart = 136702, XrefRangeEnd = 136707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStance(NPCMovement.EStance stance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0011C66C File Offset: 0x0011A86C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137096, RefRangeEnd = 137099, XrefRangeStart = 137073, XrefRangeEnd = 137096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0011C6AC File Offset: 0x0011A8AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137102, RefRangeEnd = 137107, XrefRangeStart = 137099, XrefRangeEnd = 137102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdollDraggable(bool draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref draggable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x0011C6EC File Offset: 0x0011A8EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137128, RefRangeEnd = 137131, XrefRangeStart = 137107, XrefRangeEnd = 137128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0011C720 File Offset: 0x0011A920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137133, RefRangeEnd = 137135, XrefRangeStart = 137131, XrefRangeEnd = 137133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0011C77C File Offset: 0x0011A97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137135, XrefRangeEnd = 137137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0011C7D8 File Offset: 0x0011A9D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137158, RefRangeEnd = 137161, XrefRangeStart = 137137, XrefRangeEnd = 137158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0011C80C File Offset: 0x0011AA0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137171, RefRangeEnd = 137173, XrefRangeStart = 137161, XrefRangeEnd = 137171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0011C890 File Offset: 0x0011AA90
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 137174, RefRangeEnd = 137195, XrefRangeStart = 137173, XrefRangeEnd = 137174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0011C8D0 File Offset: 0x0011AAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137195, XrefRangeEnd = 137201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0011C914 File Offset: 0x0011AB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137202, RefRangeEnd = 137203, XrefRangeStart = 137201, XrefRangeEnd = 137202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumDistanceForSuccess;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheMaxDistSqr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0011C980 File Offset: 0x0011AB80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137321, RefRangeEnd = 137324, XrefRangeStart = 137203, XrefRangeEnd = 137321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interruptExistingCallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successThreshold;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheMaxDistSqr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x0011C9FC File Offset: 0x0011ABFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137325, RefRangeEnd = 137326, XrefRangeStart = 137324, XrefRangeEnd = 137325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x0011CA48 File Offset: 0x0011AC48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137342, RefRangeEnd = 137347, XrefRangeStart = 137326, XrefRangeEnd = 137342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSetDestination(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x0011CA88 File Offset: 0x0011AC88
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 137356, RefRangeEnd = 137392, XrefRangeStart = 137347, XrefRangeEnd = 137356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x0011CABC File Offset: 0x0011ACBC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0011CAF0 File Offset: 0x0011ACF0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 137412, RefRangeEnd = 137420, XrefRangeStart = 137392, XrefRangeEnd = 137412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0011CB3C File Offset: 0x0011AD3C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 137443, RefRangeEnd = 137462, XrefRangeStart = 137420, XrefRangeEnd = 137443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x0011CB88 File Offset: 0x0011AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137462, XrefRangeEnd = 137467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0011CBE4 File Offset: 0x0011ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137467, XrefRangeEnd = 137471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x0011CC18 File Offset: 0x0011AE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137473, RefRangeEnd = 137474, XrefRangeStart = 137471, XrefRangeEnd = 137473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0011CC4C File Offset: 0x0011AE4C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 137482, RefRangeEnd = 137499, XrefRangeStart = 137474, XrefRangeEnd = 137482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x0011CCA4 File Offset: 0x0011AEA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137523, RefRangeEnd = 137526, XrefRangeStart = 137499, XrefRangeEnd = 137523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0011CCFC File Offset: 0x0011AEFC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 137527, RefRangeEnd = 137548, XrefRangeStart = 137526, XrefRangeEnd = 137527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0011CD54 File Offset: 0x0011AF54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137560, RefRangeEnd = 137564, XrefRangeStart = 137548, XrefRangeEnd = 137560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0011CDB0 File Offset: 0x0011AFB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137595, RefRangeEnd = 137598, XrefRangeStart = 137564, XrefRangeEnd = 137595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			path = ((intPtr4 == 0) ? null : new NavMeshPath(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0011CE2C File Offset: 0x0011B02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137625, RefRangeEnd = 137626, XrefRangeStart = 137598, XrefRangeEnd = 137625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr3) : null;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0011CE88 File Offset: 0x0011B088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137626, XrefRangeEnd = 137659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0011CEC4 File Offset: 0x0011B0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137659, XrefRangeEnd = 137691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0011CF00 File Offset: 0x0011B100
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0011CF3C File Offset: 0x0011B13C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0011CF78 File Offset: 0x0011B178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0011CFB8 File Offset: 0x0011B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137691, XrefRangeEnd = 137695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0011CFF8 File Offset: 0x0011B1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137695, XrefRangeEnd = 137703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0011D048 File Offset: 0x0011B248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137703, XrefRangeEnd = 137721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0011D07C File Offset: 0x0011B27C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137727, RefRangeEnd = 137729, XrefRangeStart = 137721, XrefRangeEnd = 137727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x0011D0B0 File Offset: 0x0011B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137729, XrefRangeEnd = 137732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0011D114 File Offset: 0x0011B314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137748, RefRangeEnd = 137750, XrefRangeStart = 137732, XrefRangeEnd = 137748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x0011D170 File Offset: 0x0011B370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137758, RefRangeEnd = 137761, XrefRangeStart = 137750, XrefRangeEnd = 137758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0011D1CC File Offset: 0x0011B3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137761, XrefRangeEnd = 137771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0011D21C File Offset: 0x0011B41C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137787, RefRangeEnd = 137789, XrefRangeStart = 137771, XrefRangeEnd = 137787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0011D278 File Offset: 0x0011B478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137826, RefRangeEnd = 137829, XrefRangeStart = 137789, XrefRangeEnd = 137826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0011D2D4 File Offset: 0x0011B4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137829, XrefRangeEnd = 137839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0011D324 File Offset: 0x0011B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137839, XrefRangeEnd = 137857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0011D358 File Offset: 0x0011B558
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137893, RefRangeEnd = 137897, XrefRangeStart = 137857, XrefRangeEnd = 137893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x0011D38C File Offset: 0x0011B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137897, XrefRangeEnd = 137900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x0011D3DC File Offset: 0x0011B5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137939, RefRangeEnd = 137940, XrefRangeStart = 137900, XrefRangeEnd = 137939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		public NPCMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x0011D418 File Offset: 0x0011B618
		// (set) Token: 0x06003566 RID: 13670 RVA: 0x0001BEB5 File Offset: 0x0001A0B5
		public unsafe static float VEHICLE_RUNOVER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x0011D434 File Offset: 0x0011B634
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x0001BEC3 File Offset: 0x0001A0C3
		public unsafe static float SKATEBOARD_RUNOVER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x0011D450 File Offset: 0x0011B650
		// (set) Token: 0x0600356A RID: 13674 RVA: 0x0001BED1 File Offset: 0x0001A0D1
		public unsafe static float LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x0600356B RID: 13675 RVA: 0x0011D46C File Offset: 0x0011B66C
		// (set) Token: 0x0600356C RID: 13676 RVA: 0x0001BEDF File Offset: 0x0001A0DF
		public unsafe static float HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x0600356D RID: 13677 RVA: 0x0011D488 File Offset: 0x0011B688
		// (set) Token: 0x0600356E RID: 13678 RVA: 0x0001BEED File Offset: 0x0001A0ED
		public unsafe static float RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x0011D4A4 File Offset: 0x0011B6A4
		// (set) Token: 0x06003570 RID: 13680 RVA: 0x0001BEFB File Offset: 0x0001A0FB
		public unsafe static float MOMENTUM_ANNOYED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06003571 RID: 13681 RVA: 0x0011D4C0 File Offset: 0x0011B6C0
		// (set) Token: 0x06003572 RID: 13682 RVA: 0x0001BF09 File Offset: 0x0001A109
		public unsafe static float MOMENTUM_LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x0011D4DC File Offset: 0x0011B6DC
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x0001BF17 File Offset: 0x0001A117
		public unsafe static float MOMENTUM_HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x0011D4F8 File Offset: 0x0011B6F8
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x0001BF25 File Offset: 0x0001A125
		public unsafe static float MOMENTUM_RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x0011D514 File Offset: 0x0011B714
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x0001BF33 File Offset: 0x0001A133
		public unsafe static bool USE_PATH_CACHE
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&value));
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06003579 RID: 13689 RVA: 0x0011D530 File Offset: 0x0011B730
		// (set) Token: 0x0600357A RID: 13690 RVA: 0x0001BF41 File Offset: 0x0001A141
		public unsafe static float STUMBLE_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x0011D54C File Offset: 0x0011B74C
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x0001BF4F File Offset: 0x0001A14F
		public unsafe static float STUMBLE_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&value));
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x0011D568 File Offset: 0x0011B768
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x0001BF5D File Offset: 0x0001A15D
		public unsafe static float OBSTACLE_AVOIDANCE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x0011D584 File Offset: 0x0011B784
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x0001BF6B File Offset: 0x0001A16B
		public unsafe static float PLAYER_DIST_IMPACT_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0011D5A0 File Offset: 0x0011B7A0
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x0001BF79 File Offset: 0x0001A179
		public unsafe static Dictionary<Vector3, Vector3> cachedClosestReachablePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x0001BF8B File Offset: 0x0001A18B
		public unsafe static List<Vector3> cachedClosestPointKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x0011D5F0 File Offset: 0x0011B7F0
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x0001BF9D File Offset: 0x0001A19D
		public unsafe static float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x0011D60C File Offset: 0x0011B80C
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x0001BFAB File Offset: 0x0001A1AB
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x0011D634 File Offset: 0x0011B834
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x0001BFC6 File Offset: 0x0001A1C6
		public unsafe float WalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_WalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_WalkSpeed)) = value;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x0011D65C File Offset: 0x0011B85C
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x0001BFE1 File Offset: 0x0001A1E1
		public unsafe float RunSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RunSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RunSpeed)) = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x0011D684 File Offset: 0x0011B884
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		public unsafe float MoveSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x0011D6AC File Offset: 0x0011B8AC
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x0001C017 File Offset: 0x0001A217
		public unsafe bool SlipperyMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyMode)) = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x0011D6D4 File Offset: 0x0011B8D4
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x0001C032 File Offset: 0x0001A232
		public unsafe float SlipperyModeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier)) = value;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x0011D6FC File Offset: 0x0011B8FC
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x0001C04D File Offset: 0x0001A24D
		public unsafe ObstacleAvoidanceType DefaultObstacleAvoidanceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType)) = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x0011D724 File Offset: 0x0011B924
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x0001C068 File Offset: 0x0001A268
		public unsafe NavMeshAgent Agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x0011D754 File Offset: 0x0011B954
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x0001C087 File Offset: 0x0001A287
		public unsafe NPCSpeedController SpeedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x0011D784 File Offset: 0x0011B984
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x0001C0A6 File Offset: 0x0001A2A6
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x0011D7B4 File Offset: 0x0011B9B4
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x0001C0C5 File Offset: 0x0001A2C5
		public unsafe CapsuleCollider capsuleCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_capsuleCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_capsuleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x0011D7E4 File Offset: 0x0011B9E4
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		public unsafe NPCAnimation anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x0011D814 File Offset: 0x0011BA14
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x0001C103 File Offset: 0x0001A303
		public unsafe Rigidbody ragdollCentralRB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollCentralRB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollCentralRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x0011D844 File Offset: 0x0011BA44
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x0001C122 File Offset: 0x0001A322
		public unsafe SmoothedVelocityCalculator velocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x0011D874 File Offset: 0x0011BA74
		// (set) Token: 0x060035A4 RID: 13732 RVA: 0x0001C141 File Offset: 0x0001A341
		public unsafe Draggable RagdollDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x0011D8A4 File Offset: 0x0011BAA4
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x0001C160 File Offset: 0x0001A360
		public unsafe Collider RagdollDraggableCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x0011D8D4 File Offset: 0x0011BAD4
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x0001C17F File Offset: 0x0001A37F
		public unsafe float MovementSpeedScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MovementSpeedScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MovementSpeedScale)) = value;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x0011D8FC File Offset: 0x0011BAFC
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x0001C19A File Offset: 0x0001A39A
		public unsafe bool _hasDestination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x0011D924 File Offset: 0x0011BB24
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x0001C1B5 File Offset: 0x0001A3B5
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x0011D94C File Offset: 0x0011BB4C
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		public unsafe float _GravityMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x0011D974 File Offset: 0x0011BB74
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x0001C1EB File Offset: 0x0001A3EB
		public unsafe NPCMovement.EStance _Stance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField)) = value;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x0011D99C File Offset: 0x0011BB9C
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x0001C206 File Offset: 0x0001A406
		public unsafe float _timeSinceHitByCar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField)) = value;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0011D9C4 File Offset: 0x0011BBC4
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x0001C221 File Offset: 0x0001A421
		public unsafe float ragdollTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollTime)) = value;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x0011D9EC File Offset: 0x0011BBEC
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x0001C23C File Offset: 0x0001A43C
		public unsafe float ragdollStaticTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime)) = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x0011DA14 File Offset: 0x0011BC14
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x0001C257 File Offset: 0x0001A457
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x0011DA44 File Offset: 0x0011BC44
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x0001C276 File Offset: 0x0001A476
		public unsafe UnityEvent onRagdollStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x0011DA74 File Offset: 0x0011BC74
		// (set) Token: 0x060035BC RID: 13756 RVA: 0x0001C295 File Offset: 0x0001A495
		public unsafe UnityEvent onRagdollEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x0011DAA4 File Offset: 0x0011BCA4
		// (set) Token: 0x060035BE RID: 13758 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		public unsafe Vector3 _CurrentDestination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x0011DACC File Offset: 0x0011BCCC
		// (set) Token: 0x060035C0 RID: 13760 RVA: 0x0001C2CF File Offset: 0x0001A4CF
		public unsafe NPCPathCache _PathCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x0011DAFC File Offset: 0x0011BCFC
		// (set) Token: 0x060035C2 RID: 13762 RVA: 0x0001C2EE File Offset: 0x0001A4EE
		public unsafe bool cacheNextPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath)) = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x0011DB24 File Offset: 0x0011BD24
		// (set) Token: 0x060035C4 RID: 13764 RVA: 0x0001C309 File Offset: 0x0001A509
		public unsafe Vector3 currentDestination_Reachable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable)) = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x0011DB4C File Offset: 0x0011BD4C
		// (set) Token: 0x060035C6 RID: 13766 RVA: 0x0001C324 File Offset: 0x0001A524
		public unsafe Action<NPCMovement.WalkResult> walkResultCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPCMovement.WalkResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x0011DB7C File Offset: 0x0011BD7C
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x0001C343 File Offset: 0x0001A543
		public unsafe float currentMaxDistanceForSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess)) = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x0011DBA4 File Offset: 0x0011BDA4
		// (set) Token: 0x060035CA RID: 13770 RVA: 0x0001C35E File Offset: 0x0001A55E
		public unsafe bool forceIsMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving)) = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x0011DBCC File Offset: 0x0011BDCC
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x0001C379 File Offset: 0x0001A579
		public unsafe Coroutine FaceDirectionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x0011DBFC File Offset: 0x0011BDFC
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x0001C398 File Offset: 0x0001A598
		public unsafe List<ConstantForce> ragdollForceComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x0011DC2C File Offset: 0x0011BE2C
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x0001C3B7 File Offset: 0x0001A5B7
		public unsafe bool _Disoriented_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x0011DC54 File Offset: 0x0011BE54
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x0001C3D2 File Offset: 0x0001A5D2
		public unsafe float timeUntilNextStumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble)) = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x0011DC7C File Offset: 0x0011BE7C
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x0001C3ED File Offset: 0x0001A5ED
		public unsafe float timeSinceStumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble)) = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x0011DCA4 File Offset: 0x0011BEA4
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x0001C408 File Offset: 0x0001A608
		public unsafe Vector3 stumbleDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection)) = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x0011DCCC File Offset: 0x0011BECC
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x0001C423 File Offset: 0x0001A623
		public unsafe List<Vector3> desiredVelocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x0011DCFC File Offset: 0x0011BEFC
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x0001C442 File Offset: 0x0001A642
		public unsafe int desiredVelocityHistoryLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength)) = value;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x0011DD24 File Offset: 0x0011BF24
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x0001C45D File Offset: 0x0001A65D
		public unsafe float velocityHistorySpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing)) = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x0011DD4C File Offset: 0x0011BF4C
		// (set) Token: 0x060035DE RID: 13790 RVA: 0x0001C478 File Offset: 0x0001A678
		public unsafe float timeSinceLastVelocityHistoryRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord)) = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x0011DD74 File Offset: 0x0011BF74
		// (set) Token: 0x060035E0 RID: 13792 RVA: 0x0001C493 File Offset: 0x0001A693
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x0011DD9C File Offset: 0x0011BF9C
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x0001C4AE File Offset: 0x0001A6AE
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeFieldInfoPtr_RAGDOLL_THRESHOLD;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeFieldInfoPtr_USE_PATH_CACHE;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeFieldInfoPtr_STUMBLE_DURATION;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeFieldInfoPtr_STUMBLE_FORCE;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeFieldInfoPtr_cachedClosestReachablePoints;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeFieldInfoPtr_cachedClosestPointKeys;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeFieldInfoPtr_RunSpeed;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeedMultiplier;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyMode;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyModeMultiplier;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeFieldInfoPtr_DefaultObstacleAvoidanceType;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeFieldInfoPtr_SpeedController;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeFieldInfoPtr_capsuleCollider;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeFieldInfoPtr_ragdollCentralRB;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeFieldInfoPtr_velocityCalculator;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeFieldInfoPtr_RagdollDraggable;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeFieldInfoPtr_RagdollDraggableCollider;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeFieldInfoPtr_MovementSpeedScale;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeFieldInfoPtr__hasDestination_k__BackingField;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeFieldInfoPtr__Stance_k__BackingField;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeFieldInfoPtr_ragdollTime;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeFieldInfoPtr_ragdollStaticTime;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollStart;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollEnd;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDestination_k__BackingField;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeFieldInfoPtr__PathCache_k__BackingField;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeFieldInfoPtr_cacheNextPath;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeFieldInfoPtr_currentDestination_Reachable;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeFieldInfoPtr_walkResultCallback;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeFieldInfoPtr_currentMaxDistanceForSuccess;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeFieldInfoPtr_forceIsMoving;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeFieldInfoPtr_FaceDirectionRoutine;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeFieldInfoPtr_ragdollForceComponents;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextStumble;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStumble;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeFieldInfoPtr_stumbleDirection;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeFieldInfoPtr_desiredVelocityHistory;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeFieldInfoPtr_desiredVelocityHistoryLength;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistorySpacing;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_get_Stance_Public_get_EStance_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_Stumble_Private_Void_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStumble_Private_Void_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Private_Void_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_RecordVelocity_Private_Void_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSlippery_Private_Void_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCache_Private_Void_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_Warp_Public_Void_Transform_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_Warp_Public_Void_Vector3_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_SetStance_Public_Void_EStance_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_PauseMovement_Public_Void_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_ResumeMovement_Public_Void_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200091F RID: 2335
		[OriginalName("Assembly-CSharp.dll", "", "EAgentType")]
		public enum EAgentType
		{
			// Token: 0x0400863A RID: 34362
			Humanoid,
			// Token: 0x0400863B RID: 34363
			BigHumanoid,
			// Token: 0x0400863C RID: 34364
			IgnoreCosts
		}

		// Token: 0x02000920 RID: 2336
		[OriginalName("Assembly-CSharp.dll", "", "EStance")]
		public enum EStance
		{
			// Token: 0x0400863E RID: 34366
			None,
			// Token: 0x0400863F RID: 34367
			Stanced
		}

		// Token: 0x02000921 RID: 2337
		[OriginalName("Assembly-CSharp.dll", "", "WalkResult")]
		public enum WalkResult
		{
			// Token: 0x04008641 RID: 34369
			Failed,
			// Token: 0x04008642 RID: 34370
			Interrupted,
			// Token: 0x04008643 RID: 34371
			Stopped,
			// Token: 0x04008644 RID: 34372
			Partial,
			// Token: 0x04008645 RID: 34373
			Success
		}

		// Token: 0x02000922 RID: 2338
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C64D RID: 50765 RVA: 0x00302AF0 File Offset: 0x00300CF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr);
				NPCMovement.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, "<>9");
				NPCMovement.__c.NativeFieldInfoPtr___9__126_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, "<>9__126_1");
				NPCMovement.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, 100669398);
				NPCMovement.__c.NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, 100669399);
			}

			// Token: 0x0600C64E RID: 50766 RVA: 0x00302B6C File Offset: 0x00300D6C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C64F RID: 50767 RVA: 0x00302BA8 File Offset: 0x00300DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136570, XrefRangeEnd = 136571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ApplyRagdollForce_b__126_1(__f__AnonymousType0<Rigidbody, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c.NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C650 RID: 50768 RVA: 0x0006084F File Offset: 0x0005EA4F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC9 RID: 15817
			// (get) Token: 0x0600C651 RID: 50769 RVA: 0x00302BF8 File Offset: 0x00300DF8
			// (set) Token: 0x0600C652 RID: 50770 RVA: 0x00060858 File Offset: 0x0005EA58
			public unsafe static NPCMovement.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCMovement.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCMovement.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DCA RID: 15818
			// (get) Token: 0x0600C653 RID: 50771 RVA: 0x00302C20 File Offset: 0x00300E20
			// (set) Token: 0x0600C654 RID: 50772 RVA: 0x0006086A File Offset: 0x0005EA6A
			public unsafe static Func<__f__AnonymousType0<Rigidbody, float>, float> __9__126_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCMovement.__c.NativeFieldInfoPtr___9__126_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<Rigidbody, float>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCMovement.__c.NativeFieldInfoPtr___9__126_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008646 RID: 34374
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008647 RID: 34375
			private static readonly IntPtr NativeFieldInfoPtr___9__126_1;

			// Token: 0x04008648 RID: 34376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008649 RID: 34377
			private static readonly IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0;
		}

		// Token: 0x02000923 RID: 2339
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c__DisplayClass126_0")]
		public sealed class __c__DisplayClass126_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C655 RID: 50773 RVA: 0x00302C48 File Offset: 0x00300E48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass126_0()
			{
				Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c__DisplayClass126_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr);
				NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, "forcePoint");
				NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, 100669400);
				NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, 100669401);
			}

			// Token: 0x0600C656 RID: 50774 RVA: 0x00302CB0 File Offset: 0x00300EB0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass126_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C657 RID: 50775 RVA: 0x00302CEC File Offset: 0x00300EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136571, XrefRangeEnd = 136584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<Rigidbody, float> _ApplyRagdollForce_b__0(Rigidbody x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Rigidbody, float>>(intPtr3) : null;
			}

			// Token: 0x0600C658 RID: 50776 RVA: 0x0006087C File Offset: 0x0005EA7C
			public __c__DisplayClass126_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DCB RID: 15819
			// (get) Token: 0x0600C659 RID: 50777 RVA: 0x00302D3C File Offset: 0x00300F3C
			// (set) Token: 0x0600C65A RID: 50778 RVA: 0x00060885 File Offset: 0x0005EA85
			public unsafe Vector3 forcePoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint)) = value;
				}
			}

			// Token: 0x0400864A RID: 34378
			private static readonly IntPtr NativeFieldInfoPtr_forcePoint;

			// Token: 0x0400864B RID: 34379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400864C RID: 34380
			private static readonly IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<FaceDirection_Process>d__139")]
		public sealed class _FaceDirection_Process_d__139 : Il2CppSystem.Object
		{
			// Token: 0x0600C65B RID: 50779 RVA: 0x00302D64 File Offset: 0x00300F64
			// Note: this type is marked as 'beforefieldinit'.
			static _FaceDirection_Process_d__139()
			{
				Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<FaceDirection_Process>d__139");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr);
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>1__state");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>2__current");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "lerpTime");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>4__this");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "forward");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<startRot>5__2");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<i>5__3");
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669402);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669403);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669404);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669405);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669406);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669407);
			}

			// Token: 0x0600C65C RID: 50780 RVA: 0x00302E94 File Offset: 0x00301094
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FaceDirection_Process_d__139(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C65D RID: 50781 RVA: 0x00302EDC File Offset: 0x003010DC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C65E RID: 50782 RVA: 0x00302F10 File Offset: 0x00301110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136584, XrefRangeEnd = 136606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003DD3 RID: 15827
			// (get) Token: 0x0600C65F RID: 50783 RVA: 0x00302F4C File Offset: 0x0030114C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C660 RID: 50784 RVA: 0x00302F8C File Offset: 0x0030118C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136606, XrefRangeEnd = 136611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003DD4 RID: 15828
			// (get) Token: 0x0600C661 RID: 50785 RVA: 0x00302FC0 File Offset: 0x003011C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C662 RID: 50786 RVA: 0x000608A0 File Offset: 0x0005EAA0
			public _FaceDirection_Process_d__139(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DCC RID: 15820
			// (get) Token: 0x0600C663 RID: 50787 RVA: 0x00303000 File Offset: 0x00301200
			// (set) Token: 0x0600C664 RID: 50788 RVA: 0x000608A9 File Offset: 0x0005EAA9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DCD RID: 15821
			// (get) Token: 0x0600C665 RID: 50789 RVA: 0x00303028 File Offset: 0x00301228
			// (set) Token: 0x0600C666 RID: 50790 RVA: 0x000608C4 File Offset: 0x0005EAC4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DCE RID: 15822
			// (get) Token: 0x0600C667 RID: 50791 RVA: 0x00303058 File Offset: 0x00301258
			// (set) Token: 0x0600C668 RID: 50792 RVA: 0x000608E3 File Offset: 0x0005EAE3
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003DCF RID: 15823
			// (get) Token: 0x0600C669 RID: 50793 RVA: 0x00303080 File Offset: 0x00301280
			// (set) Token: 0x0600C66A RID: 50794 RVA: 0x000608FE File Offset: 0x0005EAFE
			public unsafe NPCMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DD0 RID: 15824
			// (get) Token: 0x0600C66B RID: 50795 RVA: 0x003030B0 File Offset: 0x003012B0
			// (set) Token: 0x0600C66C RID: 50796 RVA: 0x0006091D File Offset: 0x0005EB1D
			public unsafe Vector3 forward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward)) = value;
				}
			}

			// Token: 0x17003DD1 RID: 15825
			// (get) Token: 0x0600C66D RID: 50797 RVA: 0x003030D8 File Offset: 0x003012D8
			// (set) Token: 0x0600C66E RID: 50798 RVA: 0x00060938 File Offset: 0x0005EB38
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17003DD2 RID: 15826
			// (get) Token: 0x0600C66F RID: 50799 RVA: 0x00303100 File Offset: 0x00301300
			// (set) Token: 0x0600C670 RID: 50800 RVA: 0x00060953 File Offset: 0x0005EB53
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400864D RID: 34381
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400864E RID: 34382
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400864F RID: 34383
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008650 RID: 34384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008651 RID: 34385
			private static readonly IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x04008652 RID: 34386
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x04008653 RID: 34387
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008654 RID: 34388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008655 RID: 34389
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008656 RID: 34390
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008657 RID: 34391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008658 RID: 34392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008659 RID: 34393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
