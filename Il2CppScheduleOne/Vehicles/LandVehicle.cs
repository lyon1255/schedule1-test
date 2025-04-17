using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E0 RID: 1248
	public class LandVehicle : NetworkBehaviour
	{
		// Token: 0x06006CFD RID: 27901 RVA: 0x001E33A0 File Offset: 0x001E15A0
		// Note: this type is marked as 'beforefieldinit'.
		static LandVehicle()
		{
			Il2CppClassPointerStore<LandVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LandVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr);
			LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "KINEMATIC_THRESHOLD_DISTANCE");
			LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "MAX_TURNOVER_SPEED");
			LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TURNOVER_FORCE");
			LandVehicle.NativeFieldInfoPtr_USE_WHEEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "USE_WHEEL");
			LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SPEED_DISPLAY_MULTIPLIER");
			LandVehicle.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DEBUG");
			LandVehicle.NativeFieldInfoPtr_vehicleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleName");
			LandVehicle.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleCode");
			LandVehicle.NativeFieldInfoPtr_vehiclePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehiclePrice");
			LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsPlayerOwned>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsVisible>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "UseHumanoidCollider");
			LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<GUID>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SpawnAsPlayerOwned");
			LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<DistanceToLocalCamera>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_vehicleModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleModel");
			LandVehicle.NativeFieldInfoPtr_driveWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "driveWheels");
			LandVehicle.NativeFieldInfoPtr_steerWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerWheels");
			LandVehicle.NativeFieldInfoPtr_handbrakeWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handbrakeWheels");
			LandVehicle.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "wheels");
			LandVehicle.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "intObj");
			LandVehicle.NativeFieldInfoPtr_exitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "exitPoints");
			LandVehicle.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "rb");
			LandVehicle.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Seats");
			LandVehicle.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "boundingBox");
			LandVehicle.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Agent");
			LandVehicle.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VelocityCalculator");
			LandVehicle.NativeFieldInfoPtr_Trunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Trunk");
			LandVehicle.NativeFieldInfoPtr_NavMeshObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavMeshObstacle");
			LandVehicle.NativeFieldInfoPtr_NavmeshCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavmeshCut");
			LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "HumanoidColliderContainer");
			LandVehicle.NativeFieldInfoPtr_POI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "POI");
			LandVehicle.NativeFieldInfoPtr_centerOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "centerOfMass");
			LandVehicle.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "cameraOrigin");
			LandVehicle.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lights");
			LandVehicle.NativeFieldInfoPtr_maxSteeringAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "maxSteeringAngle");
			LandVehicle.NativeFieldInfoPtr_steerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerRate");
			LandVehicle.NativeFieldInfoPtr_flipSteer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "flipSteer");
			LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<MaxSteerAngleOverridden>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OverriddenMaxSteerAngle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_motorTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "motorTorque");
			LandVehicle.NativeFieldInfoPtr_TopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TopSpeed");
			LandVehicle.NativeFieldInfoPtr_diffGearing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "diffGearing");
			LandVehicle.NativeFieldInfoPtr_handBrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handBrakeForce");
			LandVehicle.NativeFieldInfoPtr_brakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "brakeForce");
			LandVehicle.NativeFieldInfoPtr_downforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "downforce");
			LandVehicle.NativeFieldInfoPtr_reverseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "reverseMultiplier");
			LandVehicle.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BodyMeshes");
			LandVehicle.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DefaultColor");
			LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OwnedColor>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_DisplayedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DisplayedColor");
			LandVehicle.NativeFieldInfoPtr_outlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "outlineRenderers");
			LandVehicle.NativeFieldInfoPtr_outlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "outlineEffect");
			LandVehicle.NativeFieldInfoPtr_overrideControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "overrideControls");
			LandVehicle.NativeFieldInfoPtr_throttleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "throttleOverride");
			LandVehicle.NativeFieldInfoPtr_steerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerOverride");
			LandVehicle.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Storage");
			LandVehicle.NativeFieldInfoPtr_localPlayerSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "localPlayerSeat");
			LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<localPlayerIsDriver>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<localPlayerIsInVehicle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isOccupied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OccupantNPCs>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<speed_Kmh>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_previousSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeeds");
			LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeedsSampleSize");
			LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<currentThrottle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_currentSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "currentSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFrameSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastReplicatedSteerAngle");
			LandVehicle.NativeFieldInfoPtr_justExitedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "justExitedVehicle");
			LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<brakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isStatic>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<handbrakeApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFramePosition");
			LandVehicle.NativeFieldInfoPtr_closestExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "closestExitPoint");
			LandVehicle.NativeFieldInfoPtr_CurrentParkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "CurrentParkData");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingLot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingSpot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "loader");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<HasChanged>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onPlayerEnterVehicle");
			LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onPlayerExitVehicle");
			LandVehicle.NativeFieldInfoPtr_onVehicleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStart");
			LandVehicle.NativeFieldInfoPtr_onVehicleStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStop");
			LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onHandbrakeApplied");
			LandVehicle.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onCollision");
			LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___currentSteerAngle");
			LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<brakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<isReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677070);
			LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677071);
			LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677072);
			LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677073);
			LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677074);
			LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677075);
			LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677076);
			LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677077);
			LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677078);
			LandVehicle.NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677079);
			LandVehicle.NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677080);
			LandVehicle.NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677081);
			LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677082);
			LandVehicle.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677083);
			LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677084);
			LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677085);
			LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677086);
			LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677087);
			LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677088);
			LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677089);
			LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677090);
			LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677091);
			LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677092);
			LandVehicle.NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677093);
			LandVehicle.NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677094);
			LandVehicle.NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677095);
			LandVehicle.NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677096);
			LandVehicle.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677097);
			LandVehicle.NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677098);
			LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677099);
			LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677100);
			LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677101);
			LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677102);
			LandVehicle.NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677103);
			LandVehicle.NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677104);
			LandVehicle.NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677105);
			LandVehicle.NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677106);
			LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677107);
			LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677108);
			LandVehicle.NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677109);
			LandVehicle.NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677110);
			LandVehicle.NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677111);
			LandVehicle.NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677112);
			LandVehicle.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677113);
			LandVehicle.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677114);
			LandVehicle.NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677115);
			LandVehicle.NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677116);
			LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677117);
			LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677118);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677119);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677120);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677121);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677122);
			LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677123);
			LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677124);
			LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677125);
			LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677126);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677127);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677128);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677129);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677130);
			LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677131);
			LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677132);
			LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677133);
			LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677134);
			LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677135);
			LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677136);
			LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677137);
			LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677138);
			LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677139);
			LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677140);
			LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677141);
			LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677142);
			LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677143);
			LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677144);
			LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677145);
			LandVehicle.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677146);
			LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677147);
			LandVehicle.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677148);
			LandVehicle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677149);
			LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677150);
			LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677151);
			LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677152);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677153);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677154);
			LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677155);
			LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677156);
			LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677157);
			LandVehicle.NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677158);
			LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677159);
			LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677160);
			LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677161);
			LandVehicle.NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677162);
			LandVehicle.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677163);
			LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677164);
			LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677165);
			LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677166);
			LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677167);
			LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677168);
			LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677169);
			LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677170);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677171);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677172);
			LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677173);
			LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677174);
			LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677175);
			LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677176);
			LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677177);
			LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677178);
			LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677179);
			LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677180);
			LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677181);
			LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677182);
			LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677183);
			LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677184);
			LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677185);
			LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677186);
			LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677187);
			LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677188);
			LandVehicle.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677189);
			LandVehicle.NativeMethodInfoPtr_HideOutline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677190);
			LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677191);
			LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677192);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677193);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677194);
			LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677195);
			LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677196);
			LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677197);
			LandVehicle.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677198);
			LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677199);
			LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677200);
			LandVehicle.NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677201);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677202);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677203);
			LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677204);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677205);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677206);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677207);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677208);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677209);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677210);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677211);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677212);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677213);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677214);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677215);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677216);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677217);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677218);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677219);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677220);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677221);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677222);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677223);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677224);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677225);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677226);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677227);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677228);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677229);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677230);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677231);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677232);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677233);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677234);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677235);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677236);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677237);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677238);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677239);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677240);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677241);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677242);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677243);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677244);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677245);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677246);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677247);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677248);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677249);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677250);
			LandVehicle.NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677251);
			LandVehicle.NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677252);
			LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677253);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677254);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677255);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677256);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677257);
			LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677258);
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06006CFE RID: 27902 RVA: 0x001E49EC File Offset: 0x001E2BEC
		public unsafe string VehicleName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x001E4A24 File Offset: 0x001E2C24
		public unsafe string VehicleCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x001E4A5C File Offset: 0x001E2C5C
		public unsafe float VehiclePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x001E4A98 File Offset: 0x001E2C98
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x001E4AD4 File Offset: 0x001E2CD4
		public unsafe bool IsPlayerOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x001E4B14 File Offset: 0x001E2D14
		// (set) Token: 0x06006D04 RID: 27908 RVA: 0x001E4B50 File Offset: 0x001E2D50
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x001E4B90 File Offset: 0x001E2D90
		// (set) Token: 0x06006D06 RID: 27910 RVA: 0x001E4BCC File Offset: 0x001E2DCC
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06006D07 RID: 27911 RVA: 0x001E4C0C File Offset: 0x001E2E0C
		// (set) Token: 0x06006D08 RID: 27912 RVA: 0x001E4C48 File Offset: 0x001E2E48
		public unsafe float DistanceToLocalCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06006D09 RID: 27913 RVA: 0x001E4C88 File Offset: 0x001E2E88
		public unsafe Vector3 boundingBoxDimensions
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 217539, RefRangeEnd = 217548, XrefRangeStart = 217530, XrefRangeEnd = 217539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06006D0A RID: 27914 RVA: 0x001E4CC4 File Offset: 0x001E2EC4
		public unsafe Transform driverEntryPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217548, XrefRangeEnd = 217552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06006D0B RID: 27915 RVA: 0x001E4D04 File Offset: 0x001E2F04
		public unsafe Rigidbody Rb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06006D0C RID: 27916 RVA: 0x001E4D44 File Offset: 0x001E2F44
		public unsafe float ActualMaxSteeringAngle
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 217552, RefRangeEnd = 217560, XrefRangeStart = 217552, XrefRangeEnd = 217552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x001E4D80 File Offset: 0x001E2F80
		// (set) Token: 0x06006D0E RID: 27918 RVA: 0x001E4DBC File Offset: 0x001E2FBC
		public unsafe bool MaxSteerAngleOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x001E4DFC File Offset: 0x001E2FFC
		// (set) Token: 0x06006D10 RID: 27920 RVA: 0x001E4E38 File Offset: 0x001E3038
		public unsafe float OverriddenMaxSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x001E4E78 File Offset: 0x001E3078
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x001E4EB4 File Offset: 0x001E30B4
		public unsafe EVehicleColor OwnedColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x001E4EF4 File Offset: 0x001E30F4
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06006D14 RID: 27924 RVA: 0x001E4F30 File Offset: 0x001E3130
		public unsafe int CurrentPlayerOccupancy
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 217578, RefRangeEnd = 217582, XrefRangeStart = 217560, XrefRangeEnd = 217578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x001E4F6C File Offset: 0x001E316C
		// (set) Token: 0x06006D16 RID: 27926 RVA: 0x001E4FA8 File Offset: 0x001E31A8
		public unsafe bool localPlayerIsDriver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x001E4FE8 File Offset: 0x001E31E8
		// (set) Token: 0x06006D18 RID: 27928 RVA: 0x001E5024 File Offset: 0x001E3224
		public unsafe bool localPlayerIsInVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x001E5064 File Offset: 0x001E3264
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x001E50A0 File Offset: 0x001E32A0
		public unsafe bool isOccupied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x001E50E0 File Offset: 0x001E32E0
		public unsafe Player DriverPlayer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 217586, RefRangeEnd = 217600, XrefRangeStart = 217582, XrefRangeEnd = 217586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06006D1C RID: 27932 RVA: 0x001E5120 File Offset: 0x001E3320
		public unsafe List<Player> OccupantPlayers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217638, RefRangeEnd = 217640, XrefRangeStart = 217600, XrefRangeEnd = 217638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x001E5160 File Offset: 0x001E3360
		// (set) Token: 0x06006D1E RID: 27934 RVA: 0x001E51A0 File Offset: 0x001E33A0
		public unsafe Il2CppReferenceArray<NPC> OccupantNPCs
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166356, RefRangeEnd = 166371, XrefRangeStart = 166356, XrefRangeEnd = 166371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06006D1F RID: 27935 RVA: 0x001E51E4 File Offset: 0x001E33E4
		// (set) Token: 0x06006D20 RID: 27936 RVA: 0x001E5220 File Offset: 0x001E3420
		public unsafe float speed_Kmh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06006D21 RID: 27937 RVA: 0x001E5260 File Offset: 0x001E3460
		public unsafe float speed_Ms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06006D22 RID: 27938 RVA: 0x001E529C File Offset: 0x001E349C
		public unsafe float speed_Mph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06006D23 RID: 27939 RVA: 0x001E52D8 File Offset: 0x001E34D8
		// (set) Token: 0x06006D24 RID: 27940 RVA: 0x001E5314 File Offset: 0x001E3514
		public unsafe float currentThrottle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06006D25 RID: 27941 RVA: 0x001E5354 File Offset: 0x001E3554
		// (set) Token: 0x06006D26 RID: 27942 RVA: 0x001E5390 File Offset: 0x001E3590
		public unsafe bool brakesApplied
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217640, RefRangeEnd = 217642, XrefRangeStart = 217640, XrefRangeEnd = 217640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217649, RefRangeEnd = 217654, XrefRangeStart = 217642, XrefRangeEnd = 217649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06006D27 RID: 27943 RVA: 0x001E53D0 File Offset: 0x001E35D0
		// (set) Token: 0x06006D28 RID: 27944 RVA: 0x001E540C File Offset: 0x001E360C
		public unsafe bool isReversing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217654, RefRangeEnd = 217656, XrefRangeStart = 217654, XrefRangeEnd = 217654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217663, RefRangeEnd = 217666, XrefRangeStart = 217656, XrefRangeEnd = 217663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06006D29 RID: 27945 RVA: 0x001E544C File Offset: 0x001E364C
		// (set) Token: 0x06006D2A RID: 27946 RVA: 0x001E5488 File Offset: 0x001E3688
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06006D2B RID: 27947 RVA: 0x001E54C8 File Offset: 0x001E36C8
		// (set) Token: 0x06006D2C RID: 27948 RVA: 0x001E5504 File Offset: 0x001E3704
		public unsafe bool handbrakeApplied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06006D2D RID: 27949 RVA: 0x001E5544 File Offset: 0x001E3744
		public unsafe float boundingBaseOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217666, XrefRangeEnd = 217671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06006D2E RID: 27950 RVA: 0x001E5580 File Offset: 0x001E3780
		public unsafe bool isParked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217675, RefRangeEnd = 217676, XrefRangeStart = 217671, XrefRangeEnd = 217675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06006D2F RID: 27951 RVA: 0x001E55BC File Offset: 0x001E37BC
		// (set) Token: 0x06006D30 RID: 27952 RVA: 0x001E55FC File Offset: 0x001E37FC
		public unsafe ParkingLot CurrentParkingLot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217676, XrefRangeEnd = 217677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x001E5640 File Offset: 0x001E3840
		// (set) Token: 0x06006D32 RID: 27954 RVA: 0x001E5680 File Offset: 0x001E3880
		public unsafe ParkingSpot CurrentParkingSpot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118902, RefRangeEnd = 118903, XrefRangeStart = 118902, XrefRangeEnd = 118903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x001E56C4 File Offset: 0x001E38C4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217682, RefRangeEnd = 217684, XrefRangeStart = 217677, XrefRangeEnd = 217682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06006D34 RID: 27956 RVA: 0x001E56FC File Offset: 0x001E38FC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217684, XrefRangeEnd = 217686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x001E5734 File Offset: 0x001E3934
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x001E5774 File Offset: 0x001E3974
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x001E57B0 File Offset: 0x001E39B0
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x001E57F0 File Offset: 0x001E39F0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217686, XrefRangeEnd = 217687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x001E5834 File Offset: 0x001E3A34
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x001E5874 File Offset: 0x001E3A74
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217687, XrefRangeEnd = 217688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06006D3B RID: 27963 RVA: 0x001E58B8 File Offset: 0x001E3AB8
		// (set) Token: 0x06006D3C RID: 27964 RVA: 0x001E58F4 File Offset: 0x001E3AF4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x001E5934 File Offset: 0x001E3B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217689, RefRangeEnd = 217690, XrefRangeStart = 217688, XrefRangeEnd = 217689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x001E5970 File Offset: 0x001E3B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217690, XrefRangeEnd = 217696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x001E59AC File Offset: 0x001E3BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217696, XrefRangeEnd = 217702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x001E59E8 File Offset: 0x001E3BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217702, XrefRangeEnd = 217716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x001E5A38 File Offset: 0x001E3C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217716, XrefRangeEnd = 217723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x001E5A74 File Offset: 0x001E3C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217765, RefRangeEnd = 217768, XrefRangeStart = 217723, XrefRangeEnd = 217765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x001E5AC4 File Offset: 0x001E3CC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217778, RefRangeEnd = 217784, XrefRangeStart = 217768, XrefRangeEnd = 217778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x001E5AF8 File Offset: 0x001E3CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217788, RefRangeEnd = 217789, XrefRangeStart = 217784, XrefRangeEnd = 217788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x001E5B38 File Offset: 0x001E3D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217789, XrefRangeEnd = 217913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x001E5B74 File Offset: 0x001E3D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217913, XrefRangeEnd = 217914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x001E5BB8 File Offset: 0x001E3DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217914, XrefRangeEnd = 217968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x001E5BF4 File Offset: 0x001E3DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217968, XrefRangeEnd = 217969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x001E5C38 File Offset: 0x001E3E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218014, RefRangeEnd = 218015, XrefRangeStart = 217969, XrefRangeEnd = 218014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x001E5C74 File Offset: 0x001E3E74
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x001E5CA8 File Offset: 0x001E3EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218108, RefRangeEnd = 218109, XrefRangeStart = 218015, XrefRangeEnd = 218108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x001E5CE4 File Offset: 0x001E3EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218109, XrefRangeEnd = 218130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x001E5D20 File Offset: 0x001E3F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218130, XrefRangeEnd = 218142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x001E5D5C File Offset: 0x001E3F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218142, XrefRangeEnd = 218145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x001E5DA0 File Offset: 0x001E3FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218145, XrefRangeEnd = 218164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x001E5DF0 File Offset: 0x001E3FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218164, XrefRangeEnd = 218182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOwnerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x001E5E2C File Offset: 0x001E402C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218184, RefRangeEnd = 218185, XrefRangeStart = 218182, XrefRangeEnd = 218184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x001E5E78 File Offset: 0x001E4078
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 218192, RefRangeEnd = 218199, XrefRangeStart = 218185, XrefRangeEnd = 218192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x001E5EC4 File Offset: 0x001E40C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218199, XrefRangeEnd = 218227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x001E5EF8 File Offset: 0x001E40F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218227, XrefRangeEnd = 218232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x001E5F34 File Offset: 0x001E4134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218232, XrefRangeEnd = 218291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x001E5F70 File Offset: 0x001E4170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218294, RefRangeEnd = 218296, XrefRangeStart = 218291, XrefRangeEnd = 218294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x001E5FA4 File Offset: 0x001E41A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218296, XrefRangeEnd = 218315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSteeringAngle(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x001E5FE4 File Offset: 0x001E41E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218315, XrefRangeEnd = 218385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x001E6020 File Offset: 0x001E4220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218385, XrefRangeEnd = 218387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplySteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x001E605C File Offset: 0x001E425C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218387, XrefRangeEnd = 218395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelaySetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x001E609C File Offset: 0x001E429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218395, XrefRangeEnd = 218411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x001E60E8 File Offset: 0x001E42E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218422, RefRangeEnd = 218426, XrefRangeStart = 218411, XrefRangeEnd = 218422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001E6148 File Offset: 0x001E4348
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218443, RefRangeEnd = 218446, XrefRangeStart = 218426, XrefRangeEnd = 218443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Quaternion>>(intPtr3) : null;
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001E61A8 File Offset: 0x001E43A8
		[CallerCount(0)]
		public unsafe float GetVehicleValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x001E61E4 File Offset: 0x001E43E4
		[CallerCount(0)]
		public unsafe void OverrideMaxSteerAngle(float maxAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x001E6224 File Offset: 0x001E4424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218446, RefRangeEnd = 218447, XrefRangeStart = 218446, XrefRangeEnd = 218446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMaxSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x001E6258 File Offset: 0x001E4458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218447, XrefRangeEnd = 218450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObstaclesActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x001E6298 File Offset: 0x001E4498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218450, XrefRangeEnd = 218452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr3) : null;
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x001E62D8 File Offset: 0x001E44D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218498, RefRangeEnd = 218502, XrefRangeStart = 218452, XrefRangeEnd = 218498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x001E633C File Offset: 0x001E453C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218525, RefRangeEnd = 218527, XrefRangeStart = 218502, XrefRangeEnd = 218525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x001E638C File Offset: 0x001E458C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218527, XrefRangeEnd = 218532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x001E63C0 File Offset: 0x001E45C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218532, XrefRangeEnd = 218534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x001E63F4 File Offset: 0x001E45F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218591, RefRangeEnd = 218592, XrefRangeStart = 218534, XrefRangeEnd = 218591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x001E6428 File Offset: 0x001E4628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218651, RefRangeEnd = 218655, XrefRangeStart = 218592, XrefRangeEnd = 218651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x001E645C File Offset: 0x001E465C
		[CallerCount(0)]
		public unsafe void EndJustExited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x001E6490 File Offset: 0x001E4690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218659, RefRangeEnd = 218660, XrefRangeStart = 218655, XrefRangeEnd = 218659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetExitPoint(int seatIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x001E64DC File Offset: 0x001E46DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218660, XrefRangeEnd = 218676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetClosestExitPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x001E6528 File Offset: 0x001E4728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218713, RefRangeEnd = 218714, XrefRangeStart = 218676, XrefRangeEnd = 218713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(possibleExitPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x001E6578 File Offset: 0x001E4778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218748, RefRangeEnd = 218749, XrefRangeStart = 218714, XrefRangeEnd = 218748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x001E65BC File Offset: 0x001E47BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218781, RefRangeEnd = 218782, XrefRangeStart = 218749, XrefRangeEnd = 218781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x001E6600 File Offset: 0x001E4800
		[CallerCount(0)]
		public unsafe virtual bool CanBeRecovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x001E6648 File Offset: 0x001E4848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218782, XrefRangeEnd = 218798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecoverVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x001E6684 File Offset: 0x001E4884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218819, RefRangeEnd = 218820, XrefRangeStart = 218798, XrefRangeEnd = 218819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOwnedColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x001E66C4 File Offset: 0x001E48C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218820, XrefRangeEnd = 218862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x001E6720 File Offset: 0x001E4920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218862, XrefRangeEnd = 218879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x001E676C File Offset: 0x001E496C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218879, RefRangeEnd = 218880, XrefRangeStart = 218879, XrefRangeEnd = 218879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOwnedColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x001E67A0 File Offset: 0x001E49A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218923, RefRangeEnd = 218926, XrefRangeStart = 218880, XrefRangeEnd = 218923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x001E67E0 File Offset: 0x001E49E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218931, RefRangeEnd = 218933, XrefRangeStart = 218926, XrefRangeEnd = 218931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_HideOutline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x001E6814 File Offset: 0x001E4A14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218975, RefRangeEnd = 218977, XrefRangeStart = 218933, XrefRangeEnd = 218975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x001E6868 File Offset: 0x001E4A68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 219012, RefRangeEnd = 219018, XrefRangeStart = 218977, XrefRangeEnd = 219012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x001E68CC File Offset: 0x001E4ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219060, RefRangeEnd = 219061, XrefRangeStart = 219018, XrefRangeEnd = 219060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x001E691C File Offset: 0x001E4B1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 219079, RefRangeEnd = 219085, XrefRangeStart = 219061, XrefRangeEnd = 219079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark(bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x001E695C File Offset: 0x001E4B5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219092, RefRangeEnd = 219096, XrefRangeStart = 219085, XrefRangeEnd = 219092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x001E699C File Offset: 0x001E4B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219096, XrefRangeEnd = 219110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x001E69DC File Offset: 0x001E4BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219110, XrefRangeEnd = 219119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x001E6A20 File Offset: 0x001E4C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219147, RefRangeEnd = 219149, XrefRangeStart = 219119, XrefRangeEnd = 219147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x001E6A7C File Offset: 0x001E4C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219180, RefRangeEnd = 219181, XrefRangeStart = 219149, XrefRangeEnd = 219180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(VehicleData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x001E6ADC File Offset: 0x001E4CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219268, RefRangeEnd = 219270, XrefRangeStart = 219181, XrefRangeEnd = 219268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x001E6B18 File Offset: 0x001E4D18
		[CallerCount(0)]
		public unsafe bool _ApplyColor_b__249_0(VehicleColors.VehicleColorData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x001E6B68 File Offset: 0x001E4D68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219406, RefRangeEnd = 219408, XrefRangeStart = 219270, XrefRangeEnd = 219406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x001E6BA4 File Offset: 0x001E4DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219408, RefRangeEnd = 219409, XrefRangeStart = 219408, XrefRangeEnd = 219408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x001E6BE0 File Offset: 0x001E4DE0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x001E6C1C File Offset: 0x001E4E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219409, XrefRangeEnd = 219428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x001E6C6C File Offset: 0x001E4E6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219439, RefRangeEnd = 219442, XrefRangeStart = 219428, XrefRangeEnd = 219439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x001E6CBC File Offset: 0x001E4EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219442, XrefRangeEnd = 219445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x001E6D0C File Offset: 0x001E4F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219445, XrefRangeEnd = 219464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x001E6D5C File Offset: 0x001E4F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219464, XrefRangeEnd = 219467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x001E6DAC File Offset: 0x001E4FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x001E6DF0 File Offset: 0x001E4FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219467, XrefRangeEnd = 219469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x001E6E40 File Offset: 0x001E5040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219469, XrefRangeEnd = 219472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x001E6EA4 File Offset: 0x001E50A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x001E6ED8 File Offset: 0x001E50D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219497, RefRangeEnd = 219498, XrefRangeStart = 219472, XrefRangeEnd = 219497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x001E6F14 File Offset: 0x001E5114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219498, XrefRangeEnd = 219500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x001E6F64 File Offset: 0x001E5164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219533, RefRangeEnd = 219535, XrefRangeStart = 219500, XrefRangeEnd = 219533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x001E6FB0 File Offset: 0x001E51B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219535, XrefRangeEnd = 219536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x001E6FFC File Offset: 0x001E51FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219536, XrefRangeEnd = 219544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x001E7060 File Offset: 0x001E5260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219568, RefRangeEnd = 219569, XrefRangeStart = 219544, XrefRangeEnd = 219568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x001E70AC File Offset: 0x001E52AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219569, XrefRangeEnd = 219575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x001E70F8 File Offset: 0x001E52F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219575, XrefRangeEnd = 219588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x001E7148 File Offset: 0x001E5348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x001E7188 File Offset: 0x001E5388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219588, XrefRangeEnd = 219595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x001E71C8 File Offset: 0x001E53C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219595, XrefRangeEnd = 219604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x001E722C File Offset: 0x001E542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219604, XrefRangeEnd = 219625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x001E7290 File Offset: 0x001E5490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219654, RefRangeEnd = 219657, XrefRangeStart = 219625, XrefRangeEnd = 219654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x001E72F4 File Offset: 0x001E54F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219657, XrefRangeEnd = 219663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x001E7344 File Offset: 0x001E5544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219663, XrefRangeEnd = 219675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x001E73A8 File Offset: 0x001E55A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219675, XrefRangeEnd = 219681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x001E73F8 File Offset: 0x001E55F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219681, XrefRangeEnd = 219702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x001E7448 File Offset: 0x001E5648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219702, XrefRangeEnd = 219703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x001E7498 File Offset: 0x001E5698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219703, XrefRangeEnd = 219709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x001E74FC File Offset: 0x001E56FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219709, XrefRangeEnd = 219728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x001E753C File Offset: 0x001E573C
		[CallerCount(0)]
		public unsafe void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x001E757C File Offset: 0x001E577C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219728, XrefRangeEnd = 219731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x001E75E0 File Offset: 0x001E57E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219731, XrefRangeEnd = 219750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x001E7630 File Offset: 0x001E5830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219750, XrefRangeEnd = 219751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x001E768C File Offset: 0x001E588C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219751, XrefRangeEnd = 219755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x001E76DC File Offset: 0x001E58DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219755, XrefRangeEnd = 219774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x001E772C File Offset: 0x001E592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219774, XrefRangeEnd = 219778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x001E777C File Offset: 0x001E597C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219778, XrefRangeEnd = 219797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x001E77D0 File Offset: 0x001E59D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219797, XrefRangeEnd = 219798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x001E7824 File Offset: 0x001E5A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219798, XrefRangeEnd = 219802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x001E7874 File Offset: 0x001E5A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219802, XrefRangeEnd = 219821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x001E78C8 File Offset: 0x001E5AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219821, XrefRangeEnd = 219825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x001E7918 File Offset: 0x001E5B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219825, XrefRangeEnd = 219844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x001E7968 File Offset: 0x001E5B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219844, XrefRangeEnd = 219845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x001E79B8 File Offset: 0x001E5BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219845, XrefRangeEnd = 219848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x001E7A08 File Offset: 0x001E5C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219848, XrefRangeEnd = 219867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x001E7A58 File Offset: 0x001E5C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219867, XrefRangeEnd = 219870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x001E7AA8 File Offset: 0x001E5CA8
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x001E7AE4 File Offset: 0x001E5CE4
		public unsafe float SyncAccessor_currentSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 219878, RefRangeEnd = 219882, XrefRangeStart = 219870, XrefRangeEnd = 219878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x001E7B30 File Offset: 0x001E5D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219882, XrefRangeEnd = 219887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006DB6 RID: 28086 RVA: 0x001E7BA4 File Offset: 0x001E5DA4
		// (set) Token: 0x06006DB7 RID: 28087 RVA: 0x001E7BE0 File Offset: 0x001E5DE0
		public unsafe bool SyncAccessor_<brakesApplied>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217640, RefRangeEnd = 217642, XrefRangeStart = 217640, XrefRangeEnd = 217642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219887, XrefRangeEnd = 219895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06006DB8 RID: 28088 RVA: 0x001E7C2C File Offset: 0x001E5E2C
		// (set) Token: 0x06006DB9 RID: 28089 RVA: 0x001E7C68 File Offset: 0x001E5E68
		public unsafe bool SyncAccessor_<isReversing>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217654, RefRangeEnd = 217656, XrefRangeStart = 217654, XrefRangeEnd = 217656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219895, XrefRangeEnd = 219903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x001E7CB4 File Offset: 0x001E5EB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219945, RefRangeEnd = 219948, XrefRangeStart = 219903, XrefRangeEnd = 219945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x0003397F File Offset: 0x00031B7F
		public LandVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06006DBC RID: 28092 RVA: 0x001E7CF0 File Offset: 0x001E5EF0
		// (set) Token: 0x06006DBD RID: 28093 RVA: 0x00033988 File Offset: 0x00031B88
		public unsafe static float KINEMATIC_THRESHOLD_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06006DBE RID: 28094 RVA: 0x001E7D0C File Offset: 0x001E5F0C
		// (set) Token: 0x06006DBF RID: 28095 RVA: 0x00033996 File Offset: 0x00031B96
		public unsafe static float MAX_TURNOVER_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x001E7D28 File Offset: 0x001E5F28
		// (set) Token: 0x06006DC1 RID: 28097 RVA: 0x000339A4 File Offset: 0x00031BA4
		public unsafe static float TURNOVER_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&value));
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06006DC2 RID: 28098 RVA: 0x001E7D44 File Offset: 0x001E5F44
		// (set) Token: 0x06006DC3 RID: 28099 RVA: 0x000339B2 File Offset: 0x00031BB2
		public unsafe static bool USE_WHEEL
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&value));
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06006DC4 RID: 28100 RVA: 0x001E7D60 File Offset: 0x001E5F60
		// (set) Token: 0x06006DC5 RID: 28101 RVA: 0x000339C0 File Offset: 0x00031BC0
		public unsafe static float SPEED_DISPLAY_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x001E7D7C File Offset: 0x001E5F7C
		// (set) Token: 0x06006DC7 RID: 28103 RVA: 0x000339CE File Offset: 0x00031BCE
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06006DC8 RID: 28104 RVA: 0x001E7DA4 File Offset: 0x001E5FA4
		// (set) Token: 0x06006DC9 RID: 28105 RVA: 0x000339E9 File Offset: 0x00031BE9
		public unsafe string vehicleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06006DCA RID: 28106 RVA: 0x001E7DCC File Offset: 0x001E5FCC
		// (set) Token: 0x06006DCB RID: 28107 RVA: 0x00033A08 File Offset: 0x00031C08
		public unsafe string vehicleCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06006DCC RID: 28108 RVA: 0x001E7DF4 File Offset: 0x001E5FF4
		// (set) Token: 0x06006DCD RID: 28109 RVA: 0x00033A27 File Offset: 0x00031C27
		public unsafe float vehiclePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice)) = value;
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06006DCE RID: 28110 RVA: 0x001E7E1C File Offset: 0x001E601C
		// (set) Token: 0x06006DCF RID: 28111 RVA: 0x00033A42 File Offset: 0x00031C42
		public unsafe bool _IsPlayerOwned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06006DD0 RID: 28112 RVA: 0x001E7E44 File Offset: 0x001E6044
		// (set) Token: 0x06006DD1 RID: 28113 RVA: 0x00033A5D File Offset: 0x00031C5D
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x001E7E6C File Offset: 0x001E606C
		// (set) Token: 0x06006DD3 RID: 28115 RVA: 0x00033A78 File Offset: 0x00031C78
		public unsafe bool UseHumanoidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider)) = value;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06006DD4 RID: 28116 RVA: 0x001E7E94 File Offset: 0x001E6094
		// (set) Token: 0x06006DD5 RID: 28117 RVA: 0x00033A93 File Offset: 0x00031C93
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06006DD6 RID: 28118 RVA: 0x001E7EBC File Offset: 0x001E60BC
		// (set) Token: 0x06006DD7 RID: 28119 RVA: 0x00033AAE File Offset: 0x00031CAE
		public unsafe bool SpawnAsPlayerOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned)) = value;
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x001E7EE4 File Offset: 0x001E60E4
		// (set) Token: 0x06006DD9 RID: 28121 RVA: 0x00033AC9 File Offset: 0x00031CC9
		public unsafe float _DistanceToLocalCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField)) = value;
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06006DDA RID: 28122 RVA: 0x001E7F0C File Offset: 0x001E610C
		// (set) Token: 0x06006DDB RID: 28123 RVA: 0x00033AE4 File Offset: 0x00031CE4
		public unsafe GameObject vehicleModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x001E7F3C File Offset: 0x001E613C
		// (set) Token: 0x06006DDD RID: 28125 RVA: 0x00033B03 File Offset: 0x00031D03
		public unsafe Il2CppReferenceArray<WheelCollider> driveWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x001E7F6C File Offset: 0x001E616C
		// (set) Token: 0x06006DDF RID: 28127 RVA: 0x00033B22 File Offset: 0x00031D22
		public unsafe Il2CppReferenceArray<WheelCollider> steerWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x001E7F9C File Offset: 0x001E619C
		// (set) Token: 0x06006DE1 RID: 28129 RVA: 0x00033B41 File Offset: 0x00031D41
		public unsafe Il2CppReferenceArray<WheelCollider> handbrakeWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x001E7FCC File Offset: 0x001E61CC
		// (set) Token: 0x06006DE3 RID: 28131 RVA: 0x00033B60 File Offset: 0x00031D60
		public unsafe List<Wheel> wheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Wheel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x001E7FFC File Offset: 0x001E61FC
		// (set) Token: 0x06006DE5 RID: 28133 RVA: 0x00033B7F File Offset: 0x00031D7F
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x001E802C File Offset: 0x001E622C
		// (set) Token: 0x06006DE7 RID: 28135 RVA: 0x00033B9E File Offset: 0x00031D9E
		public unsafe List<Transform> exitPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06006DE8 RID: 28136 RVA: 0x001E805C File Offset: 0x001E625C
		// (set) Token: 0x06006DE9 RID: 28137 RVA: 0x00033BBD File Offset: 0x00031DBD
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06006DEA RID: 28138 RVA: 0x001E808C File Offset: 0x001E628C
		// (set) Token: 0x06006DEB RID: 28139 RVA: 0x00033BDC File Offset: 0x00031DDC
		public unsafe Il2CppReferenceArray<VehicleSeat> Seats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleSeat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06006DEC RID: 28140 RVA: 0x001E80BC File Offset: 0x001E62BC
		// (set) Token: 0x06006DED RID: 28141 RVA: 0x00033BFB File Offset: 0x00031DFB
		public unsafe BoxCollider boundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x001E80EC File Offset: 0x001E62EC
		// (set) Token: 0x06006DEF RID: 28143 RVA: 0x00033C1A File Offset: 0x00031E1A
		public unsafe VehicleAgent Agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06006DF0 RID: 28144 RVA: 0x001E811C File Offset: 0x001E631C
		// (set) Token: 0x06006DF1 RID: 28145 RVA: 0x00033C39 File Offset: 0x00031E39
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06006DF2 RID: 28146 RVA: 0x001E814C File Offset: 0x001E634C
		// (set) Token: 0x06006DF3 RID: 28147 RVA: 0x00033C58 File Offset: 0x00031E58
		public unsafe StorageDoorAnimation Trunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageDoorAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x001E817C File Offset: 0x001E637C
		// (set) Token: 0x06006DF5 RID: 28149 RVA: 0x00033C77 File Offset: 0x00031E77
		public unsafe NavMeshObstacle NavMeshObstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06006DF6 RID: 28150 RVA: 0x001E81AC File Offset: 0x001E63AC
		// (set) Token: 0x06006DF7 RID: 28151 RVA: 0x00033C96 File Offset: 0x00031E96
		public unsafe NavmeshCut NavmeshCut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavmeshCut>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06006DF8 RID: 28152 RVA: 0x001E81DC File Offset: 0x001E63DC
		// (set) Token: 0x06006DF9 RID: 28153 RVA: 0x00033CB5 File Offset: 0x00031EB5
		public unsafe VehicleHumanoidCollider HumanoidColliderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleHumanoidCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06006DFA RID: 28154 RVA: 0x001E820C File Offset: 0x001E640C
		// (set) Token: 0x06006DFB RID: 28155 RVA: 0x00033CD4 File Offset: 0x00031ED4
		public unsafe POI POI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06006DFC RID: 28156 RVA: 0x001E823C File Offset: 0x001E643C
		// (set) Token: 0x06006DFD RID: 28157 RVA: 0x00033CF3 File Offset: 0x00031EF3
		public unsafe Transform centerOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06006DFE RID: 28158 RVA: 0x001E826C File Offset: 0x001E646C
		// (set) Token: 0x06006DFF RID: 28159 RVA: 0x00033D12 File Offset: 0x00031F12
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06006E00 RID: 28160 RVA: 0x001E829C File Offset: 0x001E649C
		// (set) Token: 0x06006E01 RID: 28161 RVA: 0x00033D31 File Offset: 0x00031F31
		public unsafe VehicleLights lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06006E02 RID: 28162 RVA: 0x001E82CC File Offset: 0x001E64CC
		// (set) Token: 0x06006E03 RID: 28163 RVA: 0x00033D50 File Offset: 0x00031F50
		public unsafe float maxSteeringAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle)) = value;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06006E04 RID: 28164 RVA: 0x001E82F4 File Offset: 0x001E64F4
		// (set) Token: 0x06006E05 RID: 28165 RVA: 0x00033D6B File Offset: 0x00031F6B
		public unsafe float steerRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate)) = value;
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06006E06 RID: 28166 RVA: 0x001E831C File Offset: 0x001E651C
		// (set) Token: 0x06006E07 RID: 28167 RVA: 0x00033D86 File Offset: 0x00031F86
		public unsafe bool flipSteer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer)) = value;
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06006E08 RID: 28168 RVA: 0x001E8344 File Offset: 0x001E6544
		// (set) Token: 0x06006E09 RID: 28169 RVA: 0x00033DA1 File Offset: 0x00031FA1
		public unsafe bool _MaxSteerAngleOverridden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06006E0A RID: 28170 RVA: 0x001E836C File Offset: 0x001E656C
		// (set) Token: 0x06006E0B RID: 28171 RVA: 0x00033DBC File Offset: 0x00031FBC
		public unsafe float _OverriddenMaxSteerAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06006E0C RID: 28172 RVA: 0x001E8394 File Offset: 0x001E6594
		// (set) Token: 0x06006E0D RID: 28173 RVA: 0x00033DD7 File Offset: 0x00031FD7
		public unsafe AnimationCurve motorTorque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06006E0E RID: 28174 RVA: 0x001E83C4 File Offset: 0x001E65C4
		// (set) Token: 0x06006E0F RID: 28175 RVA: 0x00033DF6 File Offset: 0x00031FF6
		public unsafe float TopSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed)) = value;
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06006E10 RID: 28176 RVA: 0x001E83EC File Offset: 0x001E65EC
		// (set) Token: 0x06006E11 RID: 28177 RVA: 0x00033E11 File Offset: 0x00032011
		public unsafe float diffGearing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing)) = value;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06006E12 RID: 28178 RVA: 0x001E8414 File Offset: 0x001E6614
		// (set) Token: 0x06006E13 RID: 28179 RVA: 0x00033E2C File Offset: 0x0003202C
		public unsafe float handBrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce)) = value;
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06006E14 RID: 28180 RVA: 0x001E843C File Offset: 0x001E663C
		// (set) Token: 0x06006E15 RID: 28181 RVA: 0x00033E47 File Offset: 0x00032047
		public unsafe AnimationCurve brakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x001E846C File Offset: 0x001E666C
		// (set) Token: 0x06006E17 RID: 28183 RVA: 0x00033E66 File Offset: 0x00032066
		public unsafe float downforce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce)) = value;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06006E18 RID: 28184 RVA: 0x001E8494 File Offset: 0x001E6694
		// (set) Token: 0x06006E19 RID: 28185 RVA: 0x00033E81 File Offset: 0x00032081
		public unsafe float reverseMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier)) = value;
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x001E84BC File Offset: 0x001E66BC
		// (set) Token: 0x06006E1B RID: 28187 RVA: 0x00033E9C File Offset: 0x0003209C
		public unsafe Il2CppReferenceArray<LandVehicle.BodyMesh> BodyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BodyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle.BodyMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x001E84EC File Offset: 0x001E66EC
		// (set) Token: 0x06006E1D RID: 28189 RVA: 0x00033EBB File Offset: 0x000320BB
		public unsafe EVehicleColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06006E1E RID: 28190 RVA: 0x001E8514 File Offset: 0x001E6714
		// (set) Token: 0x06006E1F RID: 28191 RVA: 0x00033ED6 File Offset: 0x000320D6
		public unsafe EVehicleColor _OwnedColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField)) = value;
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06006E20 RID: 28192 RVA: 0x001E853C File Offset: 0x001E673C
		// (set) Token: 0x06006E21 RID: 28193 RVA: 0x00033EF1 File Offset: 0x000320F1
		public unsafe EVehicleColor DisplayedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DisplayedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DisplayedColor)) = value;
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x001E8564 File Offset: 0x001E6764
		// (set) Token: 0x06006E23 RID: 28195 RVA: 0x00033F0C File Offset: 0x0003210C
		public unsafe List<GameObject> outlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06006E24 RID: 28196 RVA: 0x001E8594 File Offset: 0x001E6794
		// (set) Token: 0x06006E25 RID: 28197 RVA: 0x00033F2B File Offset: 0x0003212B
		public unsafe Outlinable outlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06006E26 RID: 28198 RVA: 0x001E85C4 File Offset: 0x001E67C4
		// (set) Token: 0x06006E27 RID: 28199 RVA: 0x00033F4A File Offset: 0x0003214A
		public unsafe bool overrideControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls)) = value;
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06006E28 RID: 28200 RVA: 0x001E85EC File Offset: 0x001E67EC
		// (set) Token: 0x06006E29 RID: 28201 RVA: 0x00033F65 File Offset: 0x00032165
		public unsafe float throttleOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride)) = value;
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06006E2A RID: 28202 RVA: 0x001E8614 File Offset: 0x001E6814
		// (set) Token: 0x06006E2B RID: 28203 RVA: 0x00033F80 File Offset: 0x00032180
		public unsafe float steerOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride)) = value;
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06006E2C RID: 28204 RVA: 0x001E863C File Offset: 0x001E683C
		// (set) Token: 0x06006E2D RID: 28205 RVA: 0x00033F9B File Offset: 0x0003219B
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x001E866C File Offset: 0x001E686C
		// (set) Token: 0x06006E2F RID: 28207 RVA: 0x00033FBA File Offset: 0x000321BA
		public unsafe VehicleSeat localPlayerSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x001E869C File Offset: 0x001E689C
		// (set) Token: 0x06006E31 RID: 28209 RVA: 0x00033FD9 File Offset: 0x000321D9
		public unsafe bool _localPlayerIsDriver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField)) = value;
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06006E32 RID: 28210 RVA: 0x001E86C4 File Offset: 0x001E68C4
		// (set) Token: 0x06006E33 RID: 28211 RVA: 0x00033FF4 File Offset: 0x000321F4
		public unsafe bool _localPlayerIsInVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField)) = value;
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06006E34 RID: 28212 RVA: 0x001E86EC File Offset: 0x001E68EC
		// (set) Token: 0x06006E35 RID: 28213 RVA: 0x0003400F File Offset: 0x0003220F
		public unsafe bool _isOccupied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField)) = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06006E36 RID: 28214 RVA: 0x001E8714 File Offset: 0x001E6914
		// (set) Token: 0x06006E37 RID: 28215 RVA: 0x0003402A File Offset: 0x0003222A
		public unsafe Il2CppReferenceArray<NPC> _OccupantNPCs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06006E38 RID: 28216 RVA: 0x001E8744 File Offset: 0x001E6944
		// (set) Token: 0x06006E39 RID: 28217 RVA: 0x00034049 File Offset: 0x00032249
		public unsafe float _speed_Kmh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField)) = value;
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x001E876C File Offset: 0x001E696C
		// (set) Token: 0x06006E3B RID: 28219 RVA: 0x00034064 File Offset: 0x00032264
		public unsafe List<float> previousSpeeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06006E3C RID: 28220 RVA: 0x001E879C File Offset: 0x001E699C
		// (set) Token: 0x06006E3D RID: 28221 RVA: 0x00034083 File Offset: 0x00032283
		public unsafe int previousSpeedsSampleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize)) = value;
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06006E3E RID: 28222 RVA: 0x001E87C4 File Offset: 0x001E69C4
		// (set) Token: 0x06006E3F RID: 28223 RVA: 0x0003409E File Offset: 0x0003229E
		public unsafe float _currentThrottle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField)) = value;
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06006E40 RID: 28224 RVA: 0x001E87EC File Offset: 0x001E69EC
		// (set) Token: 0x06006E41 RID: 28225 RVA: 0x000340B9 File Offset: 0x000322B9
		public unsafe float currentSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_currentSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_currentSteerAngle)) = value;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06006E42 RID: 28226 RVA: 0x001E8814 File Offset: 0x001E6A14
		// (set) Token: 0x06006E43 RID: 28227 RVA: 0x000340D4 File Offset: 0x000322D4
		public unsafe float lastFrameSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle)) = value;
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x001E883C File Offset: 0x001E6A3C
		// (set) Token: 0x06006E45 RID: 28229 RVA: 0x000340EF File Offset: 0x000322EF
		public unsafe float lastReplicatedSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle)) = value;
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06006E46 RID: 28230 RVA: 0x001E8864 File Offset: 0x001E6A64
		// (set) Token: 0x06006E47 RID: 28231 RVA: 0x0003410A File Offset: 0x0003230A
		public unsafe bool justExitedVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle)) = value;
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06006E48 RID: 28232 RVA: 0x001E888C File Offset: 0x001E6A8C
		// (set) Token: 0x06006E49 RID: 28233 RVA: 0x00034125 File Offset: 0x00032325
		public unsafe bool _brakesApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06006E4A RID: 28234 RVA: 0x001E88B4 File Offset: 0x001E6AB4
		// (set) Token: 0x06006E4B RID: 28235 RVA: 0x00034140 File Offset: 0x00032340
		public unsafe bool _isReversing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField)) = value;
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x001E88DC File Offset: 0x001E6ADC
		// (set) Token: 0x06006E4D RID: 28237 RVA: 0x0003415B File Offset: 0x0003235B
		public unsafe bool _isStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006E4E RID: 28238 RVA: 0x001E8904 File Offset: 0x001E6B04
		// (set) Token: 0x06006E4F RID: 28239 RVA: 0x00034176 File Offset: 0x00032376
		public unsafe bool _handbrakeApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06006E50 RID: 28240 RVA: 0x001E892C File Offset: 0x001E6B2C
		// (set) Token: 0x06006E51 RID: 28241 RVA: 0x00034191 File Offset: 0x00032391
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x001E8954 File Offset: 0x001E6B54
		// (set) Token: 0x06006E53 RID: 28243 RVA: 0x000341AC File Offset: 0x000323AC
		public unsafe Transform closestExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x001E8984 File Offset: 0x001E6B84
		// (set) Token: 0x06006E55 RID: 28245 RVA: 0x000341CB File Offset: 0x000323CB
		public unsafe ParkData CurrentParkData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x001E89B4 File Offset: 0x001E6BB4
		// (set) Token: 0x06006E57 RID: 28247 RVA: 0x000341EA File Offset: 0x000323EA
		public unsafe ParkingLot _CurrentParkingLot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06006E58 RID: 28248 RVA: 0x001E89E4 File Offset: 0x001E6BE4
		// (set) Token: 0x06006E59 RID: 28249 RVA: 0x00034209 File Offset: 0x00032409
		public unsafe ParkingSpot _CurrentParkingSpot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06006E5A RID: 28250 RVA: 0x001E8A14 File Offset: 0x001E6C14
		// (set) Token: 0x06006E5B RID: 28251 RVA: 0x00034228 File Offset: 0x00032428
		public unsafe VehicleLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06006E5C RID: 28252 RVA: 0x001E8A44 File Offset: 0x001E6C44
		// (set) Token: 0x06006E5D RID: 28253 RVA: 0x00034247 File Offset: 0x00032447
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06006E5E RID: 28254 RVA: 0x001E8A74 File Offset: 0x001E6C74
		// (set) Token: 0x06006E5F RID: 28255 RVA: 0x00034266 File Offset: 0x00032466
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06006E60 RID: 28256 RVA: 0x001E8AA4 File Offset: 0x001E6CA4
		// (set) Token: 0x06006E61 RID: 28257 RVA: 0x00034285 File Offset: 0x00032485
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06006E62 RID: 28258 RVA: 0x001E8ACC File Offset: 0x001E6CCC
		// (set) Token: 0x06006E63 RID: 28259 RVA: 0x000342A0 File Offset: 0x000324A0
		public unsafe LandVehicle.VehiclePlayerEvent onPlayerEnterVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.VehiclePlayerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x001E8AFC File Offset: 0x001E6CFC
		// (set) Token: 0x06006E65 RID: 28261 RVA: 0x000342BF File Offset: 0x000324BF
		public unsafe LandVehicle.VehiclePlayerEvent onPlayerExitVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.VehiclePlayerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06006E66 RID: 28262 RVA: 0x001E8B2C File Offset: 0x001E6D2C
		// (set) Token: 0x06006E67 RID: 28263 RVA: 0x000342DE File Offset: 0x000324DE
		public unsafe UnityEvent onVehicleStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x001E8B5C File Offset: 0x001E6D5C
		// (set) Token: 0x06006E69 RID: 28265 RVA: 0x000342FD File Offset: 0x000324FD
		public unsafe UnityEvent onVehicleStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x001E8B8C File Offset: 0x001E6D8C
		// (set) Token: 0x06006E6B RID: 28267 RVA: 0x0003431C File Offset: 0x0003251C
		public unsafe UnityEvent onHandbrakeApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06006E6C RID: 28268 RVA: 0x001E8BBC File Offset: 0x001E6DBC
		// (set) Token: 0x06006E6D RID: 28269 RVA: 0x0003433B File Offset: 0x0003253B
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x001E8BEC File Offset: 0x001E6DEC
		// (set) Token: 0x06006E6F RID: 28271 RVA: 0x0003435A File Offset: 0x0003255A
		public unsafe SyncVar<float> syncVar___currentSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x001E8C1C File Offset: 0x001E6E1C
		// (set) Token: 0x06006E71 RID: 28273 RVA: 0x00034379 File Offset: 0x00032579
		public unsafe SyncVar<bool> syncVar____brakesApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06006E72 RID: 28274 RVA: 0x001E8C4C File Offset: 0x001E6E4C
		// (set) Token: 0x06006E73 RID: 28275 RVA: 0x00034398 File Offset: 0x00032598
		public unsafe SyncVar<bool> syncVar____isReversing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06006E74 RID: 28276 RVA: 0x001E8C7C File Offset: 0x001E6E7C
		// (set) Token: 0x06006E75 RID: 28277 RVA: 0x000343B7 File Offset: 0x000325B7
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06006E76 RID: 28278 RVA: 0x001E8CA4 File Offset: 0x001E6EA4
		// (set) Token: 0x06006E77 RID: 28279 RVA: 0x000343D2 File Offset: 0x000325D2
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004A81 RID: 19073
		private static readonly IntPtr NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE;

		// Token: 0x04004A82 RID: 19074
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TURNOVER_SPEED;

		// Token: 0x04004A83 RID: 19075
		private static readonly IntPtr NativeFieldInfoPtr_TURNOVER_FORCE;

		// Token: 0x04004A84 RID: 19076
		private static readonly IntPtr NativeFieldInfoPtr_USE_WHEEL;

		// Token: 0x04004A85 RID: 19077
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER;

		// Token: 0x04004A86 RID: 19078
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004A87 RID: 19079
		private static readonly IntPtr NativeFieldInfoPtr_vehicleName;

		// Token: 0x04004A88 RID: 19080
		private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

		// Token: 0x04004A89 RID: 19081
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePrice;

		// Token: 0x04004A8A RID: 19082
		private static readonly IntPtr NativeFieldInfoPtr__IsPlayerOwned_k__BackingField;

		// Token: 0x04004A8B RID: 19083
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x04004A8C RID: 19084
		private static readonly IntPtr NativeFieldInfoPtr_UseHumanoidCollider;

		// Token: 0x04004A8D RID: 19085
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004A8E RID: 19086
		private static readonly IntPtr NativeFieldInfoPtr_SpawnAsPlayerOwned;

		// Token: 0x04004A8F RID: 19087
		private static readonly IntPtr NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField;

		// Token: 0x04004A90 RID: 19088
		private static readonly IntPtr NativeFieldInfoPtr_vehicleModel;

		// Token: 0x04004A91 RID: 19089
		private static readonly IntPtr NativeFieldInfoPtr_driveWheels;

		// Token: 0x04004A92 RID: 19090
		private static readonly IntPtr NativeFieldInfoPtr_steerWheels;

		// Token: 0x04004A93 RID: 19091
		private static readonly IntPtr NativeFieldInfoPtr_handbrakeWheels;

		// Token: 0x04004A94 RID: 19092
		private static readonly IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04004A95 RID: 19093
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04004A96 RID: 19094
		private static readonly IntPtr NativeFieldInfoPtr_exitPoints;

		// Token: 0x04004A97 RID: 19095
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04004A98 RID: 19096
		private static readonly IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04004A99 RID: 19097
		private static readonly IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x04004A9A RID: 19098
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x04004A9B RID: 19099
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04004A9C RID: 19100
		private static readonly IntPtr NativeFieldInfoPtr_Trunk;

		// Token: 0x04004A9D RID: 19101
		private static readonly IntPtr NativeFieldInfoPtr_NavMeshObstacle;

		// Token: 0x04004A9E RID: 19102
		private static readonly IntPtr NativeFieldInfoPtr_NavmeshCut;

		// Token: 0x04004A9F RID: 19103
		private static readonly IntPtr NativeFieldInfoPtr_HumanoidColliderContainer;

		// Token: 0x04004AA0 RID: 19104
		private static readonly IntPtr NativeFieldInfoPtr_POI;

		// Token: 0x04004AA1 RID: 19105
		private static readonly IntPtr NativeFieldInfoPtr_centerOfMass;

		// Token: 0x04004AA2 RID: 19106
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04004AA3 RID: 19107
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04004AA4 RID: 19108
		private static readonly IntPtr NativeFieldInfoPtr_maxSteeringAngle;

		// Token: 0x04004AA5 RID: 19109
		private static readonly IntPtr NativeFieldInfoPtr_steerRate;

		// Token: 0x04004AA6 RID: 19110
		private static readonly IntPtr NativeFieldInfoPtr_flipSteer;

		// Token: 0x04004AA7 RID: 19111
		private static readonly IntPtr NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField;

		// Token: 0x04004AA8 RID: 19112
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField;

		// Token: 0x04004AA9 RID: 19113
		private static readonly IntPtr NativeFieldInfoPtr_motorTorque;

		// Token: 0x04004AAA RID: 19114
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed;

		// Token: 0x04004AAB RID: 19115
		private static readonly IntPtr NativeFieldInfoPtr_diffGearing;

		// Token: 0x04004AAC RID: 19116
		private static readonly IntPtr NativeFieldInfoPtr_handBrakeForce;

		// Token: 0x04004AAD RID: 19117
		private static readonly IntPtr NativeFieldInfoPtr_brakeForce;

		// Token: 0x04004AAE RID: 19118
		private static readonly IntPtr NativeFieldInfoPtr_downforce;

		// Token: 0x04004AAF RID: 19119
		private static readonly IntPtr NativeFieldInfoPtr_reverseMultiplier;

		// Token: 0x04004AB0 RID: 19120
		private static readonly IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04004AB1 RID: 19121
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x04004AB2 RID: 19122
		private static readonly IntPtr NativeFieldInfoPtr__OwnedColor_k__BackingField;

		// Token: 0x04004AB3 RID: 19123
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedColor;

		// Token: 0x04004AB4 RID: 19124
		private static readonly IntPtr NativeFieldInfoPtr_outlineRenderers;

		// Token: 0x04004AB5 RID: 19125
		private static readonly IntPtr NativeFieldInfoPtr_outlineEffect;

		// Token: 0x04004AB6 RID: 19126
		private static readonly IntPtr NativeFieldInfoPtr_overrideControls;

		// Token: 0x04004AB7 RID: 19127
		private static readonly IntPtr NativeFieldInfoPtr_throttleOverride;

		// Token: 0x04004AB8 RID: 19128
		private static readonly IntPtr NativeFieldInfoPtr_steerOverride;

		// Token: 0x04004AB9 RID: 19129
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04004ABA RID: 19130
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerSeat;

		// Token: 0x04004ABB RID: 19131
		private static readonly IntPtr NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField;

		// Token: 0x04004ABC RID: 19132
		private static readonly IntPtr NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField;

		// Token: 0x04004ABD RID: 19133
		private static readonly IntPtr NativeFieldInfoPtr__isOccupied_k__BackingField;

		// Token: 0x04004ABE RID: 19134
		private static readonly IntPtr NativeFieldInfoPtr__OccupantNPCs_k__BackingField;

		// Token: 0x04004ABF RID: 19135
		private static readonly IntPtr NativeFieldInfoPtr__speed_Kmh_k__BackingField;

		// Token: 0x04004AC0 RID: 19136
		private static readonly IntPtr NativeFieldInfoPtr_previousSpeeds;

		// Token: 0x04004AC1 RID: 19137
		private static readonly IntPtr NativeFieldInfoPtr_previousSpeedsSampleSize;

		// Token: 0x04004AC2 RID: 19138
		private static readonly IntPtr NativeFieldInfoPtr__currentThrottle_k__BackingField;

		// Token: 0x04004AC3 RID: 19139
		private static readonly IntPtr NativeFieldInfoPtr_currentSteerAngle;

		// Token: 0x04004AC4 RID: 19140
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameSteerAngle;

		// Token: 0x04004AC5 RID: 19141
		private static readonly IntPtr NativeFieldInfoPtr_lastReplicatedSteerAngle;

		// Token: 0x04004AC6 RID: 19142
		private static readonly IntPtr NativeFieldInfoPtr_justExitedVehicle;

		// Token: 0x04004AC7 RID: 19143
		private static readonly IntPtr NativeFieldInfoPtr__brakesApplied_k__BackingField;

		// Token: 0x04004AC8 RID: 19144
		private static readonly IntPtr NativeFieldInfoPtr__isReversing_k__BackingField;

		// Token: 0x04004AC9 RID: 19145
		private static readonly IntPtr NativeFieldInfoPtr__isStatic_k__BackingField;

		// Token: 0x04004ACA RID: 19146
		private static readonly IntPtr NativeFieldInfoPtr__handbrakeApplied_k__BackingField;

		// Token: 0x04004ACB RID: 19147
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004ACC RID: 19148
		private static readonly IntPtr NativeFieldInfoPtr_closestExitPoint;

		// Token: 0x04004ACD RID: 19149
		private static readonly IntPtr NativeFieldInfoPtr_CurrentParkData;

		// Token: 0x04004ACE RID: 19150
		private static readonly IntPtr NativeFieldInfoPtr__CurrentParkingLot_k__BackingField;

		// Token: 0x04004ACF RID: 19151
		private static readonly IntPtr NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField;

		// Token: 0x04004AD0 RID: 19152
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004AD1 RID: 19153
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004AD2 RID: 19154
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004AD3 RID: 19155
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004AD4 RID: 19156
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerEnterVehicle;

		// Token: 0x04004AD5 RID: 19157
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerExitVehicle;

		// Token: 0x04004AD6 RID: 19158
		private static readonly IntPtr NativeFieldInfoPtr_onVehicleStart;

		// Token: 0x04004AD7 RID: 19159
		private static readonly IntPtr NativeFieldInfoPtr_onVehicleStop;

		// Token: 0x04004AD8 RID: 19160
		private static readonly IntPtr NativeFieldInfoPtr_onHandbrakeApplied;

		// Token: 0x04004AD9 RID: 19161
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x04004ADA RID: 19162
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___currentSteerAngle;

		// Token: 0x04004ADB RID: 19163
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField;

		// Token: 0x04004ADC RID: 19164
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____isReversing_k__BackingField;

		// Token: 0x04004ADD RID: 19165
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004ADE RID: 19166
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004ADF RID: 19167
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleName_Public_get_String_0;

		// Token: 0x04004AE0 RID: 19168
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0;

		// Token: 0x04004AE1 RID: 19169
		private static readonly IntPtr NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0;

		// Token: 0x04004AE2 RID: 19170
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0;

		// Token: 0x04004AE3 RID: 19171
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04004AE4 RID: 19172
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04004AE5 RID: 19173
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04004AE6 RID: 19174
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004AE7 RID: 19175
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004AE8 RID: 19176
		private static readonly IntPtr NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0;

		// Token: 0x04004AE9 RID: 19177
		private static readonly IntPtr NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0;

		// Token: 0x04004AEA RID: 19178
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0;

		// Token: 0x04004AEB RID: 19179
		private static readonly IntPtr NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0;

		// Token: 0x04004AEC RID: 19180
		private static readonly IntPtr NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0;

		// Token: 0x04004AED RID: 19181
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0;

		// Token: 0x04004AEE RID: 19182
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0;

		// Token: 0x04004AEF RID: 19183
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0;

		// Token: 0x04004AF0 RID: 19184
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0;

		// Token: 0x04004AF1 RID: 19185
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0;

		// Token: 0x04004AF2 RID: 19186
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0;

		// Token: 0x04004AF3 RID: 19187
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0;

		// Token: 0x04004AF4 RID: 19188
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04004AF5 RID: 19189
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0;

		// Token: 0x04004AF6 RID: 19190
		private static readonly IntPtr NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0;

		// Token: 0x04004AF7 RID: 19191
		private static readonly IntPtr NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0;

		// Token: 0x04004AF8 RID: 19192
		private static readonly IntPtr NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0;

		// Token: 0x04004AF9 RID: 19193
		private static readonly IntPtr NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0;

		// Token: 0x04004AFA RID: 19194
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04004AFB RID: 19195
		private static readonly IntPtr NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0;

		// Token: 0x04004AFC RID: 19196
		private static readonly IntPtr NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0;

		// Token: 0x04004AFD RID: 19197
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0;

		// Token: 0x04004AFE RID: 19198
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04004AFF RID: 19199
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04004B00 RID: 19200
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0;

		// Token: 0x04004B01 RID: 19201
		private static readonly IntPtr NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0;

		// Token: 0x04004B02 RID: 19202
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0;

		// Token: 0x04004B03 RID: 19203
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0;

		// Token: 0x04004B04 RID: 19204
		private static readonly IntPtr NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0;

		// Token: 0x04004B05 RID: 19205
		private static readonly IntPtr NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0;

		// Token: 0x04004B06 RID: 19206
		private static readonly IntPtr NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0;

		// Token: 0x04004B07 RID: 19207
		private static readonly IntPtr NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0;

		// Token: 0x04004B08 RID: 19208
		private static readonly IntPtr NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0;

		// Token: 0x04004B09 RID: 19209
		private static readonly IntPtr NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0;

		// Token: 0x04004B0A RID: 19210
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04004B0B RID: 19211
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0;

		// Token: 0x04004B0C RID: 19212
		private static readonly IntPtr NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0;

		// Token: 0x04004B0D RID: 19213
		private static readonly IntPtr NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0;

		// Token: 0x04004B0E RID: 19214
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0;

		// Token: 0x04004B0F RID: 19215
		private static readonly IntPtr NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0;

		// Token: 0x04004B10 RID: 19216
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0;

		// Token: 0x04004B11 RID: 19217
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0;

		// Token: 0x04004B12 RID: 19218
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0;

		// Token: 0x04004B13 RID: 19219
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0;

		// Token: 0x04004B14 RID: 19220
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004B15 RID: 19221
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004B16 RID: 19222
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004B17 RID: 19223
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004B18 RID: 19224
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004B19 RID: 19225
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004B1A RID: 19226
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004B1B RID: 19227
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004B1C RID: 19228
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004B1D RID: 19229
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004B1E RID: 19230
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004B1F RID: 19231
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004B20 RID: 19232
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004B21 RID: 19233
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004B22 RID: 19234
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04004B23 RID: 19235
		private static readonly IntPtr NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B24 RID: 19236
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPoI_Private_Void_0;

		// Token: 0x04004B25 RID: 19237
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004B26 RID: 19238
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004B27 RID: 19239
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004B28 RID: 19240
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004B29 RID: 19241
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

		// Token: 0x04004B2A RID: 19242
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004B2B RID: 19243
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004B2C RID: 19244
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004B2D RID: 19245
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04004B2E RID: 19246
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004B2F RID: 19247
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04004B30 RID: 19248
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04004B31 RID: 19249
		private static readonly IntPtr NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1;

		// Token: 0x04004B32 RID: 19250
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B33 RID: 19251
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B34 RID: 19252
		private static readonly IntPtr NativeMethodInfoPtr_DestroyVehicle_Public_Void_0;

		// Token: 0x04004B35 RID: 19253
		private static readonly IntPtr NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B36 RID: 19254
		private static readonly IntPtr NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B37 RID: 19255
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0;

		// Token: 0x04004B38 RID: 19256
		private static readonly IntPtr NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0;

		// Token: 0x04004B39 RID: 19257
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B3A RID: 19258
		private static readonly IntPtr NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B3B RID: 19259
		private static readonly IntPtr NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0;

		// Token: 0x04004B3C RID: 19260
		private static readonly IntPtr NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004B3D RID: 19261
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0;

		// Token: 0x04004B3E RID: 19262
		private static readonly IntPtr NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0;

		// Token: 0x04004B3F RID: 19263
		private static readonly IntPtr NativeMethodInfoPtr_GetVehicleValue_Public_Single_0;

		// Token: 0x04004B40 RID: 19264
		private static readonly IntPtr NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0;

		// Token: 0x04004B41 RID: 19265
		private static readonly IntPtr NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0;

		// Token: 0x04004B42 RID: 19266
		private static readonly IntPtr NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0;

		// Token: 0x04004B43 RID: 19267
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0;

		// Token: 0x04004B44 RID: 19268
		private static readonly IntPtr NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B45 RID: 19269
		private static readonly IntPtr NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004B46 RID: 19270
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004B47 RID: 19271
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004B48 RID: 19272
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_0;

		// Token: 0x04004B49 RID: 19273
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_0;

		// Token: 0x04004B4A RID: 19274
		private static readonly IntPtr NativeMethodInfoPtr_EndJustExited_Private_Void_0;

		// Token: 0x04004B4B RID: 19275
		private static readonly IntPtr NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0;

		// Token: 0x04004B4C RID: 19276
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0;

		// Token: 0x04004B4D RID: 19277
		private static readonly IntPtr NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0;

		// Token: 0x04004B4E RID: 19278
		private static readonly IntPtr NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04004B4F RID: 19279
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04004B50 RID: 19280
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0;

		// Token: 0x04004B51 RID: 19281
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0;

		// Token: 0x04004B52 RID: 19282
		private static readonly IntPtr NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0;

		// Token: 0x04004B53 RID: 19283
		private static readonly IntPtr NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B54 RID: 19284
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0;

		// Token: 0x04004B55 RID: 19285
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0;

		// Token: 0x04004B56 RID: 19286
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x04004B57 RID: 19287
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Void_0;

		// Token: 0x04004B58 RID: 19288
		private static readonly IntPtr NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B59 RID: 19289
		private static readonly IntPtr NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0;

		// Token: 0x04004B5A RID: 19290
		private static readonly IntPtr NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B5B RID: 19291
		private static readonly IntPtr NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0;

		// Token: 0x04004B5C RID: 19292
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04004B5D RID: 19293
		private static readonly IntPtr NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0;

		// Token: 0x04004B5E RID: 19294
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004B5F RID: 19295
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004B60 RID: 19296
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0;

		// Token: 0x04004B61 RID: 19297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004B62 RID: 19298
		private static readonly IntPtr NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0;

		// Token: 0x04004B63 RID: 19299
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004B64 RID: 19300
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004B65 RID: 19301
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004B66 RID: 19302
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B67 RID: 19303
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B68 RID: 19304
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B69 RID: 19305
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B6A RID: 19306
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B6B RID: 19307
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04004B6C RID: 19308
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04004B6D RID: 19309
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B6E RID: 19310
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0;

		// Token: 0x04004B6F RID: 19311
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1;

		// Token: 0x04004B70 RID: 19312
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B71 RID: 19313
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04004B72 RID: 19314
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B73 RID: 19315
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B74 RID: 19316
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04004B75 RID: 19317
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B76 RID: 19318
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B77 RID: 19319
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04004B78 RID: 19320
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04004B79 RID: 19321
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B7A RID: 19322
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B7B RID: 19323
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B7C RID: 19324
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B7D RID: 19325
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B7E RID: 19326
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B7F RID: 19327
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004B80 RID: 19328
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004B81 RID: 19329
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B82 RID: 19330
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0;

		// Token: 0x04004B83 RID: 19331
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0;

		// Token: 0x04004B84 RID: 19332
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B85 RID: 19333
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B86 RID: 19334
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B87 RID: 19335
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B88 RID: 19336
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B89 RID: 19337
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B8A RID: 19338
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B8B RID: 19339
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B8C RID: 19340
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B8D RID: 19341
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B8E RID: 19342
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B8F RID: 19343
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B90 RID: 19344
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B91 RID: 19345
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B92 RID: 19346
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B93 RID: 19347
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B94 RID: 19348
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0;

		// Token: 0x04004B95 RID: 19349
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004B96 RID: 19350
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004B97 RID: 19351
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004B98 RID: 19352
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004B99 RID: 19353
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004B9A RID: 19354
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004B9B RID: 19355
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A65 RID: 2661
		[Serializable]
		public class BodyMesh : Il2CppSystem.Object
		{
			// Token: 0x0600D0E6 RID: 53478 RVA: 0x00321070 File Offset: 0x0031F270
			// Note: this type is marked as 'beforefieldinit'.
			static BodyMesh()
			{
				Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BodyMesh");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr);
				LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, "Renderer");
				LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, "MaterialIndex");
				LandVehicle.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, 100677259);
			}

			// Token: 0x0600D0E7 RID: 53479 RVA: 0x003210D8 File Offset: 0x0031F2D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BodyMesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0E8 RID: 53480 RVA: 0x00065B50 File Offset: 0x00063D50
			public BodyMesh(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E2 RID: 16610
			// (get) Token: 0x0600D0E9 RID: 53481 RVA: 0x00321114 File Offset: 0x0031F314
			// (set) Token: 0x0600D0EA RID: 53482 RVA: 0x00065B59 File Offset: 0x00063D59
			public unsafe MeshRenderer Renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E3 RID: 16611
			// (get) Token: 0x0600D0EB RID: 53483 RVA: 0x00321144 File Offset: 0x0031F344
			// (set) Token: 0x0600D0EC RID: 53484 RVA: 0x00065B78 File Offset: 0x00063D78
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x04008CF9 RID: 36089
			private static readonly IntPtr NativeFieldInfoPtr_Renderer;

			// Token: 0x04008CFA RID: 36090
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x04008CFB RID: 36091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A66 RID: 2662
		public sealed class VehiclePlayerEvent : MulticastDelegate
		{
			// Token: 0x0600D0ED RID: 53485 RVA: 0x0032116C File Offset: 0x0031F36C
			// Note: this type is marked as 'beforefieldinit'.
			static VehiclePlayerEvent()
			{
				Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VehiclePlayerEvent");
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677260);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677261);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677262);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677263);
			}

			// Token: 0x0600D0EE RID: 53486 RVA: 0x003211E0 File Offset: 0x0031F3E0
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106407, RefRangeEnd = 106486, XrefRangeStart = 106407, XrefRangeEnd = 106486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehiclePlayerEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0EF RID: 53487 RVA: 0x0032123C File Offset: 0x0031F43C
			[CallerCount(0)]
			public unsafe void Invoke(Player player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0F0 RID: 53488 RVA: 0x00321280 File Offset: 0x0031F480
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Player player, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D0F1 RID: 53489 RVA: 0x003212F4 File Offset: 0x0031F4F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0F2 RID: 53490 RVA: 0x00065B93 File Offset: 0x00063D93
			public VehiclePlayerEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D0F3 RID: 53491 RVA: 0x00065B9C File Offset: 0x00063D9C
			public static implicit operator LandVehicle.VehiclePlayerEvent(Action<Player> A_0)
			{
				return DelegateSupport.ConvertDelegate<LandVehicle.VehiclePlayerEvent>(A_0);
			}

			// Token: 0x0600D0F4 RID: 53492 RVA: 0x00065BA4 File Offset: 0x00063DA4
			public static LandVehicle.VehiclePlayerEvent operator +(LandVehicle.VehiclePlayerEvent A_0, LandVehicle.VehiclePlayerEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LandVehicle.VehiclePlayerEvent>();
			}

			// Token: 0x0600D0F5 RID: 53493 RVA: 0x00065BB2 File Offset: 0x00063DB2
			public static LandVehicle.VehiclePlayerEvent operator -(LandVehicle.VehiclePlayerEvent A_0, LandVehicle.VehiclePlayerEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<LandVehicle.VehiclePlayerEvent>();
				}
				return result;
			}

			// Token: 0x04008CFC RID: 36092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008CFD RID: 36093
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0;

			// Token: 0x04008CFE RID: 36094
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0;

			// Token: 0x04008CFF RID: 36095
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A67 RID: 2663
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0F6 RID: 53494 RVA: 0x00321338 File Offset: 0x0031F538
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr);
				LandVehicle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9");
				LandVehicle.__c.NativeFieldInfoPtr___9__96_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__96_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__113_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__113_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__113_1");
				LandVehicle.__c.NativeFieldInfoPtr___9__233_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__233_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__243_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__243_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__244_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__244_0");
				LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677265);
				LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677266);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677267);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677268);
				LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677269);
				LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677270);
				LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677271);
			}

			// Token: 0x0600D0F7 RID: 53495 RVA: 0x0032147C File Offset: 0x0031F67C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0F8 RID: 53496 RVA: 0x003214B8 File Offset: 0x0031F6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217501, XrefRangeEnd = 217506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerOccupancy_b__96_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0F9 RID: 53497 RVA: 0x00321508 File Offset: 0x0031F708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_OccupantPlayers_b__113_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0FA RID: 53498 RVA: 0x00321558 File Offset: 0x0031F758
			[CallerCount(0)]
			public unsafe Player _get_OccupantPlayers_b__113_1(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}

			// Token: 0x0600D0FB RID: 53499 RVA: 0x003215A8 File Offset: 0x0031F7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetSeatOccupant_b__233_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0FC RID: 53500 RVA: 0x003215F8 File Offset: 0x0031F7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217506, XrefRangeEnd = 217510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddNPCOccupant_b__243_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0FD RID: 53501 RVA: 0x00321648 File Offset: 0x0031F848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217510, XrefRangeEnd = 217514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNPCOccupant_b__244_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0FE RID: 53502 RVA: 0x00065BC3 File Offset: 0x00063DC3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E4 RID: 16612
			// (get) Token: 0x0600D0FF RID: 53503 RVA: 0x00321698 File Offset: 0x0031F898
			// (set) Token: 0x0600D100 RID: 53504 RVA: 0x00065BCC File Offset: 0x00063DCC
			public unsafe static LandVehicle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E5 RID: 16613
			// (get) Token: 0x0600D101 RID: 53505 RVA: 0x003216C0 File Offset: 0x0031F8C0
			// (set) Token: 0x0600D102 RID: 53506 RVA: 0x00065BDE File Offset: 0x00063DDE
			public unsafe static Func<VehicleSeat, bool> __9__96_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__96_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__96_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E6 RID: 16614
			// (get) Token: 0x0600D103 RID: 53507 RVA: 0x003216E8 File Offset: 0x0031F8E8
			// (set) Token: 0x0600D104 RID: 53508 RVA: 0x00065BF0 File Offset: 0x00063DF0
			public unsafe static Func<VehicleSeat, bool> __9__113_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E7 RID: 16615
			// (get) Token: 0x0600D105 RID: 53509 RVA: 0x00321710 File Offset: 0x0031F910
			// (set) Token: 0x0600D106 RID: 53510 RVA: 0x00065C02 File Offset: 0x00063E02
			public unsafe static Func<VehicleSeat, Player> __9__113_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, Player>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E8 RID: 16616
			// (get) Token: 0x0600D107 RID: 53511 RVA: 0x00321738 File Offset: 0x0031F938
			// (set) Token: 0x0600D108 RID: 53512 RVA: 0x00065C14 File Offset: 0x00063E14
			public unsafe static Func<VehicleSeat, bool> __9__233_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__233_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__233_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E9 RID: 16617
			// (get) Token: 0x0600D109 RID: 53513 RVA: 0x00321760 File Offset: 0x0031F960
			// (set) Token: 0x0600D10A RID: 53514 RVA: 0x00065C26 File Offset: 0x00063E26
			public unsafe static Func<NPC, bool> __9__243_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__243_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__243_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EA RID: 16618
			// (get) Token: 0x0600D10B RID: 53515 RVA: 0x00321788 File Offset: 0x0031F988
			// (set) Token: 0x0600D10C RID: 53516 RVA: 0x00065C38 File Offset: 0x00063E38
			public unsafe static Func<NPC, bool> __9__244_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__244_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__244_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D00 RID: 36096
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D01 RID: 36097
			private static readonly IntPtr NativeFieldInfoPtr___9__96_0;

			// Token: 0x04008D02 RID: 36098
			private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x04008D03 RID: 36099
			private static readonly IntPtr NativeFieldInfoPtr___9__113_1;

			// Token: 0x04008D04 RID: 36100
			private static readonly IntPtr NativeFieldInfoPtr___9__233_0;

			// Token: 0x04008D05 RID: 36101
			private static readonly IntPtr NativeFieldInfoPtr___9__243_0;

			// Token: 0x04008D06 RID: 36102
			private static readonly IntPtr NativeFieldInfoPtr___9__244_0;

			// Token: 0x04008D07 RID: 36103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D08 RID: 36104
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04008D09 RID: 36105
			private static readonly IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04008D0A RID: 36106
			private static readonly IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0;

			// Token: 0x04008D0B RID: 36107
			private static readonly IntPtr NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04008D0C RID: 36108
			private static readonly IntPtr NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0;

			// Token: 0x04008D0D RID: 36109
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000A68 RID: 2664
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c__DisplayClass224_0")]
		public sealed class __c__DisplayClass224_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D10D RID: 53517 RVA: 0x003217B0 File Offset: 0x0031F9B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass224_0()
			{
				Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c__DisplayClass224_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr);
				LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "<>4__this");
				LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "stat");
				LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, 100677272);
				LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, 100677273);
			}

			// Token: 0x0600D10E RID: 53518 RVA: 0x0032182C File Offset: 0x0031FA2C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass224_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D10F RID: 53519 RVA: 0x00321868 File Offset: 0x0031FA68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217529, RefRangeEnd = 217530, XrefRangeStart = 217524, XrefRangeEnd = 217529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D110 RID: 53520 RVA: 0x00065C4A File Offset: 0x00063E4A
			public __c__DisplayClass224_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040EB RID: 16619
			// (get) Token: 0x0600D111 RID: 53521 RVA: 0x003218A8 File Offset: 0x0031FAA8
			// (set) Token: 0x0600D112 RID: 53522 RVA: 0x00065C53 File Offset: 0x00063E53
			public unsafe LandVehicle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EC RID: 16620
			// (get) Token: 0x0600D113 RID: 53523 RVA: 0x003218D8 File Offset: 0x0031FAD8
			// (set) Token: 0x0600D114 RID: 53524 RVA: 0x00065C72 File Offset: 0x00063E72
			public unsafe bool stat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat)) = value;
				}
			}

			// Token: 0x04008D0E RID: 36110
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D0F RID: 36111
			private static readonly IntPtr NativeFieldInfoPtr_stat;

			// Token: 0x04008D10 RID: 36112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D11 RID: 36113
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C5F RID: 3167
			[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c__DisplayClass224_0+<<DelaySetStatic>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3EF RID: 58351 RVA: 0x00357898 File Offset: 0x00355A98
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "<<DelaySetStatic>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677274);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677275);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677276);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677277);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677278);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677279);
				}

				// Token: 0x0600E3F0 RID: 58352 RVA: 0x00357978 File Offset: 0x00355B78
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3F1 RID: 58353 RVA: 0x003579C0 File Offset: 0x00355BC0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3F2 RID: 58354 RVA: 0x003579F4 File Offset: 0x00355BF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217514, XrefRangeEnd = 217519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046C4 RID: 18116
				// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x00357A30 File Offset: 0x00355C30
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3F4 RID: 58356 RVA: 0x00357A70 File Offset: 0x00355C70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217519, XrefRangeEnd = 217524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046C5 RID: 18117
				// (get) Token: 0x0600E3F5 RID: 58357 RVA: 0x00357AA4 File Offset: 0x00355CA4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3F6 RID: 58358 RVA: 0x0006F1A7 File Offset: 0x0006D3A7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046C1 RID: 18113
				// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x00357AE4 File Offset: 0x00355CE4
				// (set) Token: 0x0600E3F8 RID: 58360 RVA: 0x0006F1B0 File Offset: 0x0006D3B0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046C2 RID: 18114
				// (get) Token: 0x0600E3F9 RID: 58361 RVA: 0x00357B0C File Offset: 0x00355D0C
				// (set) Token: 0x0600E3FA RID: 58362 RVA: 0x0006F1CB File Offset: 0x0006D3CB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046C3 RID: 18115
				// (get) Token: 0x0600E3FB RID: 58363 RVA: 0x00357B3C File Offset: 0x00355D3C
				// (set) Token: 0x0600E3FC RID: 58364 RVA: 0x0006F1EA File Offset: 0x0006D3EA
				public unsafe LandVehicle.__c__DisplayClass224_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c__DisplayClass224_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400987F RID: 39039
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009880 RID: 39040
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009881 RID: 39041
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009882 RID: 39042
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009883 RID: 39043
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009884 RID: 39044
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009885 RID: 39045
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009886 RID: 39046
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009887 RID: 39047
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
