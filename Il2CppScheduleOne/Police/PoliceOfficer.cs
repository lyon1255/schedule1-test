﻿using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x020001FA RID: 506
	public class PoliceOfficer : NPC
	{
		// Token: 0x060028D2 RID: 10450 RVA: 0x000F1AB0 File Offset: 0x000EFCB0
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceOfficer()
		{
			Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "PoliceOfficer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr);
			PoliceOfficer.NativeFieldInfoPtr_DEACTIVATION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "DEACTIVATION_TIME");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_COOLDOWN");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_MAX_DISTANCE");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_MIN_VISIBILITY");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_CHECK_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BODY_SEARCH_CHANCE_DEFAULT");
			PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "MIN_CHATTER_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "MAX_CHATTER_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "OnPoliceVisionEvent");
			PoliceOfficer.NativeFieldInfoPtr_Officers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Officers");
			PoliceOfficer.NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<TargetPlayerNOB>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_AssignedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "AssignedVehicle");
			PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "PursuitBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "VehiclePursuitBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "CheckpointBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "FootPatrolBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_ProxCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ProxCircle");
			PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "VehiclePatrolBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "SentryBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_ChatterVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ChatterVO");
			PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "CheckpointDialogue");
			PoliceOfficer.NativeFieldInfoPtr_BatonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BatonPrefab");
			PoliceOfficer.NativeFieldInfoPtr_TaserPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "TaserPrefab");
			PoliceOfficer.NativeFieldInfoPtr_GunPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "GunPrefab");
			PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "AutoDeactivate");
			PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ChatterEnabled");
			PoliceOfficer.NativeFieldInfoPtr_Suspicion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Suspicion");
			PoliceOfficer.NativeFieldInfoPtr_Leniency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Leniency");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchChance");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchDuration");
			PoliceOfficer.NativeFieldInfoPtr_belt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "belt");
			PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "timeSinceReadyToPool");
			PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "timeSinceOutOfSight");
			PoliceOfficer.NativeFieldInfoPtr_chatterCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "chatterCountDown");
			PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "currentBodySearchInvestigation");
			PoliceOfficer.NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "syncVar___<TargetPlayerNOB>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted");
			PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted");
			PoliceOfficer.NativeMethodInfoPtr_get_TargetPlayerNOB_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667907);
			PoliceOfficer.NativeMethodInfoPtr_set_TargetPlayerNOB_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667908);
			PoliceOfficer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667909);
			PoliceOfficer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667910);
			PoliceOfficer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667911);
			PoliceOfficer.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667912);
			PoliceOfficer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667913);
			PoliceOfficer.NativeMethodInfoPtr_CheckDeactivation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667914);
			PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667915);
			PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuitTest_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667916);
			PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667917);
			PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667918);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_LocalPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667919);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667920);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667921);
			PoliceOfficer.NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667922);
			PoliceOfficer.NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667923);
			PoliceOfficer.NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667924);
			PoliceOfficer.NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667925);
			PoliceOfficer.NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667926);
			PoliceOfficer.NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667927);
			PoliceOfficer.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667928);
			PoliceOfficer.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667929);
			PoliceOfficer.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667930);
			PoliceOfficer.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667931);
			PoliceOfficer.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667932);
			PoliceOfficer.NativeMethodInfoPtr_UpdateChatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667933);
			PoliceOfficer.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667934);
			PoliceOfficer.NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667935);
			PoliceOfficer.NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667936);
			PoliceOfficer.NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667937);
			PoliceOfficer.NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667938);
			PoliceOfficer.NativeMethodInfoPtr_StartBodySearchInvestigation_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667939);
			PoliceOfficer.NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667940);
			PoliceOfficer.NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667941);
			PoliceOfficer.NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667942);
			PoliceOfficer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667943);
			PoliceOfficer.NativeMethodInfoPtr__Awake_b__39_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667945);
			PoliceOfficer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667946);
			PoliceOfficer.NativeMethodInfoPtr__Deactivate_b__59_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667947);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667948);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667949);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667950);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_419679943_Private_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667951);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_419679943_Public_Virtual_New_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667952);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_419679943_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667953);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuitTest_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667954);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuitTest_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667955);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuitTest_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667956);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667957);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_2261819652_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667958);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667959);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667960);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667961);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_2261819652_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667962);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667963);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3323014238_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667964);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667965);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667966);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667967);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667968);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667969);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667970);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667971);
			PoliceOfficer.NativeMethodInfoPtr_sync___get_value__TargetPlayerNOB_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667972);
			PoliceOfficer.NativeMethodInfoPtr_sync___set_value__TargetPlayerNOB_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667973);
			PoliceOfficer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667974);
			PoliceOfficer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100667975);
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x000F233C File Offset: 0x000F053C
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x000F237C File Offset: 0x000F057C
		public unsafe NetworkObject TargetPlayerNOB
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118902, RefRangeEnd = 118903, XrefRangeStart = 118902, XrefRangeEnd = 118902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_get_TargetPlayerNOB_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118911, RefRangeEnd = 118915, XrefRangeStart = 118903, XrefRangeEnd = 118911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_set_TargetPlayerNOB_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000F23C0 File Offset: 0x000F05C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118915, XrefRangeEnd = 118916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000F23FC File Offset: 0x000F05FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118916, XrefRangeEnd = 118922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000F2438 File Offset: 0x000F0638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118922, XrefRangeEnd = 118928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000F2474 File Offset: 0x000F0674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118928, XrefRangeEnd = 119020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000F24A8 File Offset: 0x000F06A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119020, XrefRangeEnd = 119027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000F24E4 File Offset: 0x000F06E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119092, RefRangeEnd = 119093, XrefRangeStart = 119027, XrefRangeEnd = 119092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeactivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CheckDeactivation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000F2518 File Offset: 0x000F0718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119093, XrefRangeEnd = 119116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginFootPursuit_Networked(NetworkObject target, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColleagues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000F2574 File Offset: 0x000F0774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119116, XrefRangeEnd = 119118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginFootPursuitTest(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuitTest_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000F25B8 File Offset: 0x000F07B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119118, XrefRangeEnd = 119142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginVehiclePursuit_Networked(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000F2628 File Offset: 0x000F0828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119166, RefRangeEnd = 119168, XrefRangeStart = 119142, XrefRangeEnd = 119166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginVehiclePursuit(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000F268C File Offset: 0x000F088C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119168, XrefRangeEnd = 119173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBodySearch_LocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_LocalPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000F26C0 File Offset: 0x000F08C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119173, XrefRangeEnd = 119195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginBodySearch_Networked(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000F2710 File Offset: 0x000F0910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119217, RefRangeEnd = 119219, XrefRangeStart = 119195, XrefRangeEnd = 119217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBodySearch(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000F2754 File Offset: 0x000F0954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119219, XrefRangeEnd = 119241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000F27A0 File Offset: 0x000F09A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119241, XrefRangeEnd = 119247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignFromCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000F27D4 File Offset: 0x000F09D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119251, RefRangeEnd = 119252, XrefRangeStart = 119247, XrefRangeEnd = 119251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFootPatrol(PatrolGroup group, bool warpToStartPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warpToStartPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000F2824 File Offset: 0x000F0A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119256, RefRangeEnd = 119258, XrefRangeStart = 119252, XrefRangeEnd = 119256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000F2878 File Offset: 0x000F0A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119258, XrefRangeEnd = 119260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignToSentryLocation(SentryLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000F28C8 File Offset: 0x000F0AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119262, RefRangeEnd = 119263, XrefRangeStart = 119260, XrefRangeEnd = 119262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignFromSentryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000F28FC File Offset: 0x000F0AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119266, RefRangeEnd = 119267, XrefRangeStart = 119263, XrefRangeEnd = 119266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000F2930 File Offset: 0x000F0B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119289, RefRangeEnd = 119291, XrefRangeStart = 119267, XrefRangeEnd = 119289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000F2964 File Offset: 0x000F0B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119291, XrefRangeEnd = 119296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000F29BC File Offset: 0x000F0BBC
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000F2A04 File Offset: 0x000F0C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119296, XrefRangeEnd = 119299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetNameAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000F2A48 File Offset: 0x000F0C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119299, XrefRangeEnd = 119303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateChatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000F2A7C File Offset: 0x000F0C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119303, XrefRangeEnd = 119309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000F2AC0 File Offset: 0x000F0CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119309, XrefRangeEnd = 119312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBodySearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000F2AFC File Offset: 0x000F0CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119316, RefRangeEnd = 119318, XrefRangeStart = 119312, XrefRangeEnd = 119316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInvestigate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000F2B38 File Offset: 0x000F0D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119347, RefRangeEnd = 119348, XrefRangeStart = 119318, XrefRangeEnd = 119347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExistingInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000F2B6C File Offset: 0x000F0D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119348, XrefRangeEnd = 119385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNewInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000F2BA0 File Offset: 0x000F0DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119385, XrefRangeEnd = 119397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBodySearchInvestigation(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartBodySearchInvestigation_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000F2BE4 File Offset: 0x000F0DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119397, XrefRangeEnd = 119402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBodySearchInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000F2C18 File Offset: 0x000F0E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119412, RefRangeEnd = 119413, XrefRangeStart = 119402, XrefRangeEnd = 119412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConductBodySearch(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000F2C5C File Offset: 0x000F0E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119418, RefRangeEnd = 119420, XrefRangeStart = 119413, XrefRangeEnd = 119418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInvestigatePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000F2CAC File Offset: 0x000F0EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119420, XrefRangeEnd = 119421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000F2CE8 File Offset: 0x000F0EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119421, XrefRangeEnd = 119422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__39_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__Awake_b__39_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000F2D1C File Offset: 0x000F0F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119422, XrefRangeEnd = 119427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000F2D5C File Offset: 0x000F0F5C
		[CallerCount(0)]
		public unsafe bool _Deactivate_b__59_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__Deactivate_b__59_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000F2D98 File Offset: 0x000F0F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119427, XrefRangeEnd = 119488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000F2DD4 File Offset: 0x000F0FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119488, XrefRangeEnd = 119489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000F2E10 File Offset: 0x000F1010
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000F2E4C File Offset: 0x000F104C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119489, XrefRangeEnd = 119509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginFootPursuit_Networked_419679943(NetworkObject target, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColleagues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_419679943_Private_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000F2E9C File Offset: 0x000F109C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119579, RefRangeEnd = 119581, XrefRangeStart = 119509, XrefRangeEnd = 119579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginFootPursuit_Networked_419679943(NetworkObject target, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColleagues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_419679943_Public_Virtual_New_Void_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000F2EF8 File Offset: 0x000F10F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119581, XrefRangeEnd = 119585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginFootPursuit_Networked_419679943(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_419679943_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x000F2F5C File Offset: 0x000F115C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 119614, RefRangeEnd = 119619, XrefRangeStart = 119585, XrefRangeEnd = 119614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginFootPursuitTest_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuitTest_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000F2FA0 File Offset: 0x000F11A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 119635, RefRangeEnd = 119641, XrefRangeStart = 119619, XrefRangeEnd = 119635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginFootPursuitTest_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuitTest_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000F2FE4 File Offset: 0x000F11E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119641, XrefRangeEnd = 119645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginFootPursuitTest_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuitTest_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000F3034 File Offset: 0x000F1234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119645, XrefRangeEnd = 119657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x000F3098 File Offset: 0x000F1298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119166, RefRangeEnd = 119168, XrefRangeStart = 119166, XrefRangeEnd = 119168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginVehiclePursuit_Networked_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_2261819652_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000F3108 File Offset: 0x000F1308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119657, XrefRangeEnd = 119662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginVehiclePursuit_Networked_2261819652(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000F316C File Offset: 0x000F136C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119662, XrefRangeEnd = 119674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginVehiclePursuit_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000F31D0 File Offset: 0x000F13D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119686, RefRangeEnd = 119689, XrefRangeStart = 119674, XrefRangeEnd = 119686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginVehiclePursuit_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000F3234 File Offset: 0x000F1434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119689, XrefRangeEnd = 119694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginVehiclePursuit_2261819652(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_2261819652_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000F3284 File Offset: 0x000F1484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119694, XrefRangeEnd = 119713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginBodySearch_Networked_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000F32C8 File Offset: 0x000F14C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119217, RefRangeEnd = 119219, XrefRangeStart = 119217, XrefRangeEnd = 119219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginBodySearch_Networked_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3323014238_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000F3318 File Offset: 0x000F1518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119713, XrefRangeEnd = 119717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginBodySearch_Networked_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000F337C File Offset: 0x000F157C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119717, XrefRangeEnd = 119736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginBodySearch_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000F33C0 File Offset: 0x000F15C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119741, RefRangeEnd = 119744, XrefRangeStart = 119736, XrefRangeEnd = 119741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginBodySearch_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000F3404 File Offset: 0x000F1604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119744, XrefRangeEnd = 119748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginBodySearch_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000F3454 File Offset: 0x000F1654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119748, XrefRangeEnd = 119767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000F3494 File Offset: 0x000F1694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119781, RefRangeEnd = 119783, XrefRangeStart = 119767, XrefRangeEnd = 119781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000F34E0 File Offset: 0x000F16E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119783, XrefRangeEnd = 119787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000F3530 File Offset: 0x000F1730
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x000F3570 File Offset: 0x000F1770
		public unsafe NetworkObject SyncAccessor_<TargetPlayerNOB>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118902, RefRangeEnd = 118903, XrefRangeStart = 118902, XrefRangeEnd = 118903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_sync___get_value__TargetPlayerNOB_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119796, RefRangeEnd = 119797, XrefRangeStart = 119787, XrefRangeEnd = 119796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_sync___set_value__TargetPlayerNOB_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000F35C0 File Offset: 0x000F17C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119797, XrefRangeEnd = 119801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Police_PoliceOfficer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000F3634 File Offset: 0x000F1834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119843, RefRangeEnd = 119844, XrefRangeStart = 119801, XrefRangeEnd = 119843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00016242 File Offset: 0x00014442
		public PoliceOfficer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x000F3670 File Offset: 0x000F1870
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x0001624B File Offset: 0x0001444B
		public unsafe static float DEACTIVATION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_DEACTIVATION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_DEACTIVATION_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x000F368C File Offset: 0x000F188C
		// (set) Token: 0x0600291B RID: 10523 RVA: 0x00016259 File Offset: 0x00014459
		public unsafe static float INVESTIGATION_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000F36A8 File Offset: 0x000F18A8
		// (set) Token: 0x0600291D RID: 10525 RVA: 0x00016267 File Offset: 0x00014467
		public unsafe static float INVESTIGATION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x000F36C4 File Offset: 0x000F18C4
		// (set) Token: 0x0600291F RID: 10527 RVA: 0x00016275 File Offset: 0x00014475
		public unsafe static float INVESTIGATION_MIN_VISIBILITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY, (void*)(&value));
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000F36E0 File Offset: 0x000F18E0
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x00016283 File Offset: 0x00014483
		public unsafe static float INVESTIGATION_CHECK_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x000F36FC File Offset: 0x000F18FC
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x00016291 File Offset: 0x00014491
		public unsafe static float BODY_SEARCH_CHANCE_DEFAULT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x000F3718 File Offset: 0x000F1918
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x0001629F File Offset: 0x0001449F
		public unsafe static float MIN_CHATTER_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x000F3734 File Offset: 0x000F1934
		// (set) Token: 0x06002927 RID: 10535 RVA: 0x000162AD File Offset: 0x000144AD
		public unsafe static float MAX_CHATTER_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x000F3750 File Offset: 0x000F1950
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x000162BB File Offset: 0x000144BB
		public unsafe static Action<VisionEventReceipt> OnPoliceVisionEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisionEventReceipt>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x000F3778 File Offset: 0x000F1978
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x000162CD File Offset: 0x000144CD
		public unsafe static List<PoliceOfficer> Officers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_Officers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_Officers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000F37A0 File Offset: 0x000F19A0
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x000162DF File Offset: 0x000144DF
		public unsafe NetworkObject _TargetPlayerNOB_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000F37D0 File Offset: 0x000F19D0
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x000162FE File Offset: 0x000144FE
		public unsafe LandVehicle AssignedVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AssignedVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AssignedVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000F3800 File Offset: 0x000F1A00
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0001631D File Offset: 0x0001451D
		public unsafe PursuitBehaviour PursuitBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000F3830 File Offset: 0x000F1A30
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x0001633C File Offset: 0x0001453C
		public unsafe VehiclePursuitBehaviour VehiclePursuitBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePursuitBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000F3860 File Offset: 0x000F1A60
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x0001635B File Offset: 0x0001455B
		public unsafe BodySearchBehaviour BodySearchBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x000F3890 File Offset: 0x000F1A90
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x0001637A File Offset: 0x0001457A
		public unsafe CheckpointBehaviour CheckpointBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000F38C0 File Offset: 0x000F1AC0
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x00016399 File Offset: 0x00014599
		public unsafe FootPatrolBehaviour FootPatrolBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000F38F0 File Offset: 0x000F1AF0
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x000163B8 File Offset: 0x000145B8
		public unsafe ProximityCircle ProxCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ProxCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProximityCircle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ProxCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000F3920 File Offset: 0x000F1B20
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x000163D7 File Offset: 0x000145D7
		public unsafe VehiclePatrolBehaviour VehiclePatrolBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x000F3950 File Offset: 0x000F1B50
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x000163F6 File Offset: 0x000145F6
		public unsafe SentryBehaviour SentryBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000F3980 File Offset: 0x000F1B80
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x00016415 File Offset: 0x00014615
		public unsafe PoliceChatterVO ChatterVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterVO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceChatterVO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterVO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000F39B0 File Offset: 0x000F1BB0
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x00016434 File Offset: 0x00014634
		public unsafe DialogueContainer CheckpointDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000F39E0 File Offset: 0x000F1BE0
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x00016453 File Offset: 0x00014653
		public unsafe AvatarEquippable BatonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BatonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BatonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000F3A10 File Offset: 0x000F1C10
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x00016472 File Offset: 0x00014672
		public unsafe AvatarEquippable TaserPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_TaserPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_TaserPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000F3A40 File Offset: 0x000F1C40
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x00016491 File Offset: 0x00014691
		public unsafe AvatarEquippable GunPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_GunPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_GunPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000F3A70 File Offset: 0x000F1C70
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x000164B0 File Offset: 0x000146B0
		public unsafe bool AutoDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate)) = value;
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000F3A98 File Offset: 0x000F1C98
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x000164CB File Offset: 0x000146CB
		public unsafe bool ChatterEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled)) = value;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000F3AC0 File Offset: 0x000F1CC0
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x000164E6 File Offset: 0x000146E6
		public unsafe float Suspicion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Suspicion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Suspicion)) = value;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000F3AE8 File Offset: 0x000F1CE8
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x00016501 File Offset: 0x00014701
		public unsafe float Leniency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Leniency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Leniency)) = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000F3B10 File Offset: 0x000F1D10
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x0001651C File Offset: 0x0001471C
		public unsafe float BodySearchChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchChance)) = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000F3B38 File Offset: 0x000F1D38
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00016537 File Offset: 0x00014737
		public unsafe float BodySearchDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration)) = value;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000F3B60 File Offset: 0x000F1D60
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00016552 File Offset: 0x00014752
		public unsafe PoliceBelt belt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_belt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceBelt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_belt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000F3B90 File Offset: 0x000F1D90
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00016571 File Offset: 0x00014771
		public unsafe float timeSinceReadyToPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool)) = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000F3BB8 File Offset: 0x000F1DB8
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0001658C File Offset: 0x0001478C
		public unsafe float timeSinceOutOfSight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight)) = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000F3BE0 File Offset: 0x000F1DE0
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x000165A7 File Offset: 0x000147A7
		public unsafe float chatterCountDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_chatterCountDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_chatterCountDown)) = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000F3C08 File Offset: 0x000F1E08
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x000165C2 File Offset: 0x000147C2
		public unsafe Investigation currentBodySearchInvestigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Investigation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000F3C38 File Offset: 0x000F1E38
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x000165E1 File Offset: 0x000147E1
		public unsafe SyncVar<NetworkObject> syncVar____TargetPlayerNOB_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x000F3C68 File Offset: 0x000F1E68
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x00016600 File Offset: 0x00014800
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000F3C90 File Offset: 0x000F1E90
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x0001661B File Offset: 0x0001481B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeFieldInfoPtr_DEACTIVATION_TIME;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_COOLDOWN;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CHATTER_INTERVAL;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CHATTER_INTERVAL;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeFieldInfoPtr_OnPoliceVisionEvent;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeFieldInfoPtr_Officers;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeFieldInfoPtr_AssignedVehicle;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeFieldInfoPtr_PursuitBehaviour;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePursuitBehaviour;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchBehaviour;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeFieldInfoPtr_CheckpointBehaviour;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeFieldInfoPtr_FootPatrolBehaviour;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeFieldInfoPtr_ProxCircle;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePatrolBehaviour;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeFieldInfoPtr_SentryBehaviour;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeFieldInfoPtr_ChatterVO;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeFieldInfoPtr_CheckpointDialogue;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeFieldInfoPtr_BatonPrefab;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeFieldInfoPtr_TaserPrefab;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeFieldInfoPtr_GunPrefab;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_AutoDeactivate;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeFieldInfoPtr_ChatterEnabled;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr_Suspicion;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeFieldInfoPtr_Leniency;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchChance;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchDuration;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeFieldInfoPtr_belt;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceReadyToPool;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceOutOfSight;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_chatterCountDown;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_currentBodySearchInvestigation;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayerNOB_Public_get_NetworkObject_0;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayerNOB_Protected_set_Void_NetworkObject_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_1;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Void_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeactivation_Private_Void_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_NetworkObject_Boolean_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_BeginFootPursuitTest_Private_Void_String_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_BeginBodySearch_LocalPlayer_Public_Void_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_BeginBodySearch_Private_Void_NetworkObject_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChatter_Private_Void_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_StartBodySearchInvestigation_Private_Void_Player_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__39_0_Private_Void_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr__Deactivate_b__59_1_Private_Boolean_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_419679943_Private_Void_NetworkObject_Boolean_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_419679943_Public_Virtual_New_Void_NetworkObject_Boolean_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_419679943_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuitTest_3615296227_Private_Void_String_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginFootPursuitTest_3615296227_Private_Void_String_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuitTest_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_2261819652_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_2261819652_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3323014238_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__TargetPlayerNOB_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__TargetPlayerNOB_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020008DB RID: 2267
		[ObfuscatedName("ScheduleOne.Police.PoliceOfficer+<<Deactivate>g__Wait|59_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique : Object
		{
			// Token: 0x0600C458 RID: 50264 RVA: 0x002FD3E0 File Offset: 0x002FB5E0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique()
			{
				Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<<Deactivate>g__Wait|59_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>1__state");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>2__current");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>4__this");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100667976);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100667977);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100667978);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100667979);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100667980);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100667981);
			}

			// Token: 0x0600C459 RID: 50265 RVA: 0x002FD4C0 File Offset: 0x002FB6C0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C45A RID: 50266 RVA: 0x002FD508 File Offset: 0x002FB708
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C45B RID: 50267 RVA: 0x002FD53C File Offset: 0x002FB73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118886, XrefRangeEnd = 118897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D49 RID: 15689
			// (get) Token: 0x0600C45C RID: 50268 RVA: 0x002FD578 File Offset: 0x002FB778
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C45D RID: 50269 RVA: 0x002FD5B8 File Offset: 0x002FB7B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118897, XrefRangeEnd = 118902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D4A RID: 15690
			// (get) Token: 0x0600C45E RID: 50270 RVA: 0x002FD5EC File Offset: 0x002FB7EC
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C45F RID: 50271 RVA: 0x0005F8E6 File Offset: 0x0005DAE6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D46 RID: 15686
			// (get) Token: 0x0600C460 RID: 50272 RVA: 0x002FD62C File Offset: 0x002FB82C
			// (set) Token: 0x0600C461 RID: 50273 RVA: 0x0005F8EF File Offset: 0x0005DAEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D47 RID: 15687
			// (get) Token: 0x0600C462 RID: 50274 RVA: 0x002FD654 File Offset: 0x002FB854
			// (set) Token: 0x0600C463 RID: 50275 RVA: 0x0005F90A File Offset: 0x0005DB0A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D48 RID: 15688
			// (get) Token: 0x0600C464 RID: 50276 RVA: 0x002FD684 File Offset: 0x002FB884
			// (set) Token: 0x0600C465 RID: 50277 RVA: 0x0005F929 File Offset: 0x0005DB29
			public unsafe PoliceOfficer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400850A RID: 34058
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400850B RID: 34059
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400850C RID: 34060
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400850D RID: 34061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400850E RID: 34062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400850F RID: 34063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008510 RID: 34064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008511 RID: 34065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008512 RID: 34066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
