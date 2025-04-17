using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000507 RID: 1287
	public class VehicleAgent : MonoBehaviour
	{
		// Token: 0x06007128 RID: 28968 RVA: 0x001F0A50 File Offset: 0x001EEC50
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAgent()
		{
			Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr);
			VehicleAgent.NativeFieldInfoPtr_VehicleGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "VehicleGraphName");
			VehicleAgent.NativeFieldInfoPtr_RoadGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RoadGraphName");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPath");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPathWhenReversing");
			VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MainGraphSamplePoint");
			VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MinRenavigationRate");
			VehicleAgent.NativeFieldInfoPtr_Steer_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_P");
			VehicleAgent.NativeFieldInfoPtr_Steer_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_I");
			VehicleAgent.NativeFieldInfoPtr_Steer_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_D");
			VehicleAgent.NativeFieldInfoPtr_Throttle_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_P");
			VehicleAgent.NativeFieldInfoPtr_Throttle_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_I");
			VehicleAgent.NativeFieldInfoPtr_Throttle_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_D");
			VehicleAgent.NativeFieldInfoPtr_Steer_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_Rate");
			VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxAxlePositionShift");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MIN_RANGE");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MAX_RANGE");
			VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MAX_STEER_ANGLE_OVERRIDE");
			VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "KINEMATIC_MODE_MIN_DISTANCE");
			VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "INFREQUENT_UPDATE_RATE");
			VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DEBUG_MODE");
			VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<KinematicMode>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<AutoDriving>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<TargetLocation>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Flags");
			VehicleAgent.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "roadSeeker");
			VehicleAgent.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "generalSeeker");
			VehicleAgent.NativeFieldInfoPtr_CTE_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "CTE_Origin");
			VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "FrontAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RearAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_sensor_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FL");
			VehicleAgent.NativeFieldInfoPtr_sensor_FM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FM");
			VehicleAgent.NativeFieldInfoPtr_sensor_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepMask");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FR");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RR");
			VehicleAgent.NativeFieldInfoPtr_leftWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "leftWheel");
			VehicleAgent.NativeFieldInfoPtr_rightWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "rightWheel");
			VehicleAgent.NativeFieldInfoPtr_sweepSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepSegment");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMin");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMax");
			VehicleAgent.NativeFieldInfoPtr_aheadPointSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "aheadPointSamples");
			VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationDistanceSlowThreshold");
			VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationArrivalThreshold");
			VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerTargetFollowRate");
			VehicleAgent.NativeFieldInfoPtr_steerPID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerPID");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMinRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMaxRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionDivisor");
			VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurnSpeedReductionAngleThreshold");
			VehicleAgent.NativeFieldInfoPtr_minTurningSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurningSpeed");
			VehicleAgent.NativeFieldInfoPtr_throttleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMin");
			VehicleAgent.NativeFieldInfoPtr_throttleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMax");
			VehicleAgent.NativeFieldInfoPtr_throttlePID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttlePID");
			VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "UnmarkedSpeed");
			VehicleAgent.NativeFieldInfoPtr_ReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "ReverseSpeed");
			VehicleAgent.NativeFieldInfoPtr_speedReductionTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "speedReductionTracker");
			VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitModeEnabled");
			VehicleAgent.NativeFieldInfoPtr_PursuitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTarget");
			VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitDistanceUpdateThreshold");
			VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTargetLastPosition");
			VehicleAgent.NativeFieldInfoPtr_Teleporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Teleporter");
			VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PositionHistoryTracker");
			VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckTimeThreshold");
			VehicleAgent.NativeFieldInfoPtr_StuckSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckSamples");
			VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckDistanceThreshold");
			VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "storedNavigationCallback");
			VehicleAgent.NativeFieldInfoPtr_currentSpeedZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentSpeedZone");
			VehicleAgent.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicle");
			VehicleAgent.NativeFieldInfoPtr_wheelbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelbase");
			VehicleAgent.NativeFieldInfoPtr_wheeltrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheeltrack");
			VehicleAgent.NativeFieldInfoPtr_vehicleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleLength");
			VehicleAgent.NativeFieldInfoPtr_vehicleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleWidth");
			VehicleAgent.NativeFieldInfoPtr_turnRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnRadius");
			VehicleAgent.NativeFieldInfoPtr_sweepTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTrack");
			VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelBottomOffset");
			VehicleAgent.NativeFieldInfoPtr_targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSpeed");
			VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSteerAngle_Normalized");
			VehicleAgent.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "lateralOffset");
			VehicleAgent.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "path");
			VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "timeSinceLastNavigationCall");
			VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTestFailedTime");
			VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentNavigationSettings");
			VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "navigationCalculationRoutine");
			VehicleAgent.NativeFieldInfoPtr_reverseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "reverseCoroutine");
			VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677524);
			VehicleAgent.NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677525);
			VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677526);
			VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677527);
			VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677528);
			VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677529);
			VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677530);
			VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677531);
			VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677532);
			VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677533);
			VehicleAgent.NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677534);
			VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677535);
			VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677536);
			VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677537);
			VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677538);
			VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677539);
			VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677540);
			VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677541);
			VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677542);
			VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677543);
			VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677544);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677545);
			VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677546);
			VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677547);
			VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677548);
			VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677549);
			VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677550);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677551);
			VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677552);
			VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677553);
			VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677554);
			VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677555);
			VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677556);
			VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677557);
			VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677558);
			VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677559);
			VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677560);
			VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677561);
			VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677562);
			VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677563);
			VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677564);
			VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677565);
			VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677566);
			VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677567);
			VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677568);
			VehicleAgent.NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677570);
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x001F14F8 File Offset: 0x001EF6F8
		// (set) Token: 0x0600712A RID: 28970 RVA: 0x001F1534 File Offset: 0x001EF734
		public unsafe bool KinematicMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600712B RID: 28971 RVA: 0x001F1574 File Offset: 0x001EF774
		// (set) Token: 0x0600712C RID: 28972 RVA: 0x001F15B0 File Offset: 0x001EF7B0
		public unsafe bool AutoDriving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600712D RID: 28973 RVA: 0x001F15F0 File Offset: 0x001EF7F0
		public unsafe bool IsReversing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x001F162C File Offset: 0x001EF82C
		// (set) Token: 0x0600712F RID: 28975 RVA: 0x001F1668 File Offset: 0x001EF868
		public unsafe Vector3 TargetLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x001F16A8 File Offset: 0x001EF8A8
		public unsafe float sampleStepSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222437, RefRangeEnd = 222439, XrefRangeStart = 222436, XrefRangeEnd = 222437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06007131 RID: 28977 RVA: 0x001F16E4 File Offset: 0x001EF8E4
		public unsafe float turnSpeedReductionRange
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222439, XrefRangeEnd = 222440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x001F1720 File Offset: 0x001EF920
		public unsafe float maxSteerAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222440, XrefRangeEnd = 222442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06007133 RID: 28979 RVA: 0x001F175C File Offset: 0x001EF95C
		public unsafe Vector3 FrontOfVehiclePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222442, XrefRangeEnd = 222446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x001F1798 File Offset: 0x001EF998
		public unsafe bool NavigationCalculationInProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222446, RefRangeEnd = 222447, XrefRangeStart = 222446, XrefRangeEnd = 222446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x001F17D4 File Offset: 0x001EF9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222447, XrefRangeEnd = 222466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x001F1808 File Offset: 0x001EFA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222466, XrefRangeEnd = 222476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x001F1844 File Offset: 0x001EFA44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222561, RefRangeEnd = 222562, XrefRangeStart = 222476, XrefRangeEnd = 222561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeVehicleData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x001F1878 File Offset: 0x001EFA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222562, XrefRangeEnd = 222594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x001F18B4 File Offset: 0x001EFAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222594, XrefRangeEnd = 222623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x001F18E8 File Offset: 0x001EFAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222623, XrefRangeEnd = 222637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x001F191C File Offset: 0x001EFB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222729, RefRangeEnd = 222730, XrefRangeStart = 222637, XrefRangeEnd = 222729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateKinematic(float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x001F195C File Offset: 0x001EFB5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222786, RefRangeEnd = 222788, XrefRangeStart = 222730, XrefRangeEnd = 222786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxleGroundHit(bool front)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref front;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x001F19A8 File Offset: 0x001EFBA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222803, RefRangeEnd = 222804, XrefRangeStart = 222788, XrefRangeEnd = 222803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSweep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x001F19DC File Offset: 0x001EFBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222905, RefRangeEnd = 222906, XrefRangeStart = 222804, XrefRangeEnd = 222905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedReduction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x001F1A10 File Offset: 0x001EFC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222906, XrefRangeEnd = 222919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePursuitMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x001F1A44 File Offset: 0x001EFC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222919, XrefRangeEnd = 222943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStuckDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x001F1A78 File Offset: 0x001EFC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222972, RefRangeEnd = 222973, XrefRangeStart = 222943, XrefRangeEnd = 222972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDistanceFromPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x001F1AAC File Offset: 0x001EFCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222973, XrefRangeEnd = 222983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOvertaking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x001F1AE0 File Offset: 0x001EFCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222983, XrefRangeEnd = 223023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshSpeedZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x001F1B1C File Offset: 0x001EFD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223023, XrefRangeEnd = 223032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x001F1B58 File Offset: 0x001EFD58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223088, RefRangeEnd = 223089, XrefRangeStart = 223032, XrefRangeEnd = 223088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSteering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x001F1B8C File Offset: 0x001EFD8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 223113, RefRangeEnd = 223119, XrefRangeStart = 223089, XrefRangeEnd = 223113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(Vector3 location, NavigationSettings settings = null, VehicleAgent.NavigationCallback callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x001F1BF0 File Offset: 0x001EFDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223119, XrefRangeEnd = 223124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x001F1C40 File Offset: 0x001EFE40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223129, RefRangeEnd = 223131, XrefRangeStart = 223124, XrefRangeEnd = 223129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDriving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x001F1C74 File Offset: 0x001EFE74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 223133, RefRangeEnd = 223138, XrefRangeStart = 223131, XrefRangeEnd = 223133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopNavigating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x001F1CA8 File Offset: 0x001EFEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223139, RefRangeEnd = 223140, XrefRangeStart = 223138, XrefRangeEnd = 223139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNavigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x001F1CDC File Offset: 0x001EFEDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223221, RefRangeEnd = 223223, XrefRangeStart = 223140, XrefRangeEnd = 223221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SweepTurn(VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sweepAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steerAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x001F1D70 File Offset: 0x001EFF70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223359, RefRangeEnd = 223361, XrefRangeStart = 223223, XrefRangeEnd = 223359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetterSweepTurn(VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steerAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x001F1DF8 File Offset: 0x001EFFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223361, XrefRangeEnd = 223370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartReverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x001F1E2C File Offset: 0x001F002C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223370, XrefRangeEnd = 223375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x001F1E6C File Offset: 0x001F006C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223383, RefRangeEnd = 223386, XrefRangeStart = 223375, XrefRangeEnd = 223383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopReversing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x001F1EA0 File Offset: 0x001F00A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223386, XrefRangeEnd = 223444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider GetClosestForwardObstruction(out float obstructionDist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &obstructionDist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x001F1EEC File Offset: 0x001F00EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223445, RefRangeEnd = 223447, XrefRangeStart = 223444, XrefRangeEnd = 223445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x001F1F28 File Offset: 0x001F0128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223471, RefRangeEnd = 223474, XrefRangeStart = 223447, XrefRangeEnd = 223471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceFromVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x001F1F64 File Offset: 0x001F0164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223485, RefRangeEnd = 223486, XrefRangeStart = 223474, XrefRangeEnd = 223485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPathLateralDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x001F1FA0 File Offset: 0x001F01A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223505, RefRangeEnd = 223507, XrefRangeStart = 223486, XrefRangeEnd = 223505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsStuck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x001F1FDC File Offset: 0x001F01DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223507, XrefRangeEnd = 223512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAgent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x001F2018 File Offset: 0x001F0218
		[CallerCount(0)]
		public unsafe bool _Reverse_b__139_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00035BFA File Offset: 0x00033DFA
		public VehicleAgent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06007158 RID: 29016 RVA: 0x001F2054 File Offset: 0x001F0254
		// (set) Token: 0x06007159 RID: 29017 RVA: 0x00035C03 File Offset: 0x00033E03
		public unsafe static string VehicleGraphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600715A RID: 29018 RVA: 0x001F2074 File Offset: 0x001F0274
		// (set) Token: 0x0600715B RID: 29019 RVA: 0x00035C15 File Offset: 0x00033E15
		public unsafe static string RoadGraphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600715C RID: 29020 RVA: 0x001F2094 File Offset: 0x001F0294
		// (set) Token: 0x0600715D RID: 29021 RVA: 0x00035C27 File Offset: 0x00033E27
		public unsafe static float MaxDistanceFromPath
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&value));
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600715E RID: 29022 RVA: 0x001F20B0 File Offset: 0x001F02B0
		// (set) Token: 0x0600715F RID: 29023 RVA: 0x00035C35 File Offset: 0x00033E35
		public unsafe static float MaxDistanceFromPathWhenReversing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&value));
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06007160 RID: 29024 RVA: 0x001F20CC File Offset: 0x001F02CC
		// (set) Token: 0x06007161 RID: 29025 RVA: 0x00035C43 File Offset: 0x00033E43
		public unsafe static Vector3 MainGraphSamplePoint
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&value));
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06007162 RID: 29026 RVA: 0x001F20E8 File Offset: 0x001F02E8
		// (set) Token: 0x06007163 RID: 29027 RVA: 0x00035C51 File Offset: 0x00033E51
		public unsafe static float MinRenavigationRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&value));
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x06007164 RID: 29028 RVA: 0x001F2104 File Offset: 0x001F0304
		// (set) Token: 0x06007165 RID: 29029 RVA: 0x00035C5F File Offset: 0x00033E5F
		public unsafe static float Steer_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&value));
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x001F2120 File Offset: 0x001F0320
		// (set) Token: 0x06007167 RID: 29031 RVA: 0x00035C6D File Offset: 0x00033E6D
		public unsafe static float Steer_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&value));
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x001F213C File Offset: 0x001F033C
		// (set) Token: 0x06007169 RID: 29033 RVA: 0x00035C7B File Offset: 0x00033E7B
		public unsafe static float Steer_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&value));
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x001F2158 File Offset: 0x001F0358
		// (set) Token: 0x0600716B RID: 29035 RVA: 0x00035C89 File Offset: 0x00033E89
		public unsafe static float Throttle_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&value));
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600716C RID: 29036 RVA: 0x001F2174 File Offset: 0x001F0374
		// (set) Token: 0x0600716D RID: 29037 RVA: 0x00035C97 File Offset: 0x00033E97
		public unsafe static float Throttle_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&value));
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x001F2190 File Offset: 0x001F0390
		// (set) Token: 0x0600716F RID: 29039 RVA: 0x00035CA5 File Offset: 0x00033EA5
		public unsafe static float Throttle_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&value));
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x001F21AC File Offset: 0x001F03AC
		// (set) Token: 0x06007171 RID: 29041 RVA: 0x00035CB3 File Offset: 0x00033EB3
		public unsafe static float Steer_Rate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&value));
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x001F21C8 File Offset: 0x001F03C8
		// (set) Token: 0x06007173 RID: 29043 RVA: 0x00035CC1 File Offset: 0x00033EC1
		public unsafe static float MaxAxlePositionShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&value));
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06007174 RID: 29044 RVA: 0x001F21E4 File Offset: 0x001F03E4
		// (set) Token: 0x06007175 RID: 29045 RVA: 0x00035CCF File Offset: 0x00033ECF
		public unsafe static float OBSTACLE_MIN_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06007176 RID: 29046 RVA: 0x001F2200 File Offset: 0x001F0400
		// (set) Token: 0x06007177 RID: 29047 RVA: 0x00035CDD File Offset: 0x00033EDD
		public unsafe static float OBSTACLE_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06007178 RID: 29048 RVA: 0x001F221C File Offset: 0x001F041C
		// (set) Token: 0x06007179 RID: 29049 RVA: 0x00035CEB File Offset: 0x00033EEB
		public unsafe static float MAX_STEER_ANGLE_OVERRIDE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&value));
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x001F2238 File Offset: 0x001F0438
		// (set) Token: 0x0600717B RID: 29051 RVA: 0x00035CF9 File Offset: 0x00033EF9
		public unsafe static float KINEMATIC_MODE_MIN_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x001F2254 File Offset: 0x001F0454
		// (set) Token: 0x0600717D RID: 29053 RVA: 0x00035D07 File Offset: 0x00033F07
		public unsafe static float INFREQUENT_UPDATE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&value));
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x001F2270 File Offset: 0x001F0470
		// (set) Token: 0x0600717F RID: 29055 RVA: 0x00035D15 File Offset: 0x00033F15
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06007180 RID: 29056 RVA: 0x001F2298 File Offset: 0x001F0498
		// (set) Token: 0x06007181 RID: 29057 RVA: 0x00035D30 File Offset: 0x00033F30
		public unsafe bool _KinematicMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06007182 RID: 29058 RVA: 0x001F22C0 File Offset: 0x001F04C0
		// (set) Token: 0x06007183 RID: 29059 RVA: 0x00035D4B File Offset: 0x00033F4B
		public unsafe bool _AutoDriving_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField)) = value;
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06007184 RID: 29060 RVA: 0x001F22E8 File Offset: 0x001F04E8
		// (set) Token: 0x06007185 RID: 29061 RVA: 0x00035D66 File Offset: 0x00033F66
		public unsafe Vector3 _TargetLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06007186 RID: 29062 RVA: 0x001F2310 File Offset: 0x001F0510
		// (set) Token: 0x06007187 RID: 29063 RVA: 0x00035D81 File Offset: 0x00033F81
		public unsafe DriveFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06007188 RID: 29064 RVA: 0x001F2340 File Offset: 0x001F0540
		// (set) Token: 0x06007189 RID: 29065 RVA: 0x00035DA0 File Offset: 0x00033FA0
		public unsafe Seeker roadSeeker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600718A RID: 29066 RVA: 0x001F2370 File Offset: 0x001F0570
		// (set) Token: 0x0600718B RID: 29067 RVA: 0x00035DBF File Offset: 0x00033FBF
		public unsafe Seeker generalSeeker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600718C RID: 29068 RVA: 0x001F23A0 File Offset: 0x001F05A0
		// (set) Token: 0x0600718D RID: 29069 RVA: 0x00035DDE File Offset: 0x00033FDE
		public unsafe Transform CTE_Origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600718E RID: 29070 RVA: 0x001F23D0 File Offset: 0x001F05D0
		// (set) Token: 0x0600718F RID: 29071 RVA: 0x00035DFD File Offset: 0x00033FFD
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06007190 RID: 29072 RVA: 0x001F2400 File Offset: 0x001F0600
		// (set) Token: 0x06007191 RID: 29073 RVA: 0x00035E1C File Offset: 0x0003401C
		public unsafe Transform RearAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x001F2430 File Offset: 0x001F0630
		// (set) Token: 0x06007193 RID: 29075 RVA: 0x00035E3B File Offset: 0x0003403B
		public unsafe Sensor sensor_FL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x06007194 RID: 29076 RVA: 0x001F2460 File Offset: 0x001F0660
		// (set) Token: 0x06007195 RID: 29077 RVA: 0x00035E5A File Offset: 0x0003405A
		public unsafe Sensor sensor_FM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06007196 RID: 29078 RVA: 0x001F2490 File Offset: 0x001F0690
		// (set) Token: 0x06007197 RID: 29079 RVA: 0x00035E79 File Offset: 0x00034079
		public unsafe Sensor sensor_FR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06007198 RID: 29080 RVA: 0x001F24C0 File Offset: 0x001F06C0
		// (set) Token: 0x06007199 RID: 29081 RVA: 0x00035E98 File Offset: 0x00034098
		public unsafe Sensor sensor_RR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x001F24F0 File Offset: 0x001F06F0
		// (set) Token: 0x0600719B RID: 29083 RVA: 0x00035EB7 File Offset: 0x000340B7
		public unsafe Sensor sensor_RL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x001F2520 File Offset: 0x001F0720
		// (set) Token: 0x0600719D RID: 29085 RVA: 0x00035ED6 File Offset: 0x000340D6
		public unsafe LayerMask sweepMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask)) = value;
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600719E RID: 29086 RVA: 0x001F2548 File Offset: 0x001F0748
		// (set) Token: 0x0600719F RID: 29087 RVA: 0x00035EF1 File Offset: 0x000340F1
		public unsafe Transform sweepOrigin_FL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x001F2578 File Offset: 0x001F0778
		// (set) Token: 0x060071A1 RID: 29089 RVA: 0x00035F10 File Offset: 0x00034110
		public unsafe Transform sweepOrigin_FR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x001F25A8 File Offset: 0x001F07A8
		// (set) Token: 0x060071A3 RID: 29091 RVA: 0x00035F2F File Offset: 0x0003412F
		public unsafe Transform sweepOrigin_RL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x001F25D8 File Offset: 0x001F07D8
		// (set) Token: 0x060071A5 RID: 29093 RVA: 0x00035F4E File Offset: 0x0003414E
		public unsafe Transform sweepOrigin_RR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x060071A6 RID: 29094 RVA: 0x001F2608 File Offset: 0x001F0808
		// (set) Token: 0x060071A7 RID: 29095 RVA: 0x00035F6D File Offset: 0x0003416D
		public unsafe Wheel leftWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x060071A8 RID: 29096 RVA: 0x001F2638 File Offset: 0x001F0838
		// (set) Token: 0x060071A9 RID: 29097 RVA: 0x00035F8C File Offset: 0x0003418C
		public unsafe Wheel rightWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x060071AA RID: 29098 RVA: 0x001F2668 File Offset: 0x001F0868
		// (set) Token: 0x060071AB RID: 29099 RVA: 0x00035FAB File Offset: 0x000341AB
		public unsafe static float sweepSegment
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&value));
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x060071AC RID: 29100 RVA: 0x001F2684 File Offset: 0x001F0884
		// (set) Token: 0x060071AD RID: 29101 RVA: 0x00035FB9 File Offset: 0x000341B9
		public unsafe float sampleStepSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin)) = value;
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x060071AE RID: 29102 RVA: 0x001F26AC File Offset: 0x001F08AC
		// (set) Token: 0x060071AF RID: 29103 RVA: 0x00035FD4 File Offset: 0x000341D4
		public unsafe float sampleStepSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax)) = value;
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x060071B0 RID: 29104 RVA: 0x001F26D4 File Offset: 0x001F08D4
		// (set) Token: 0x060071B1 RID: 29105 RVA: 0x00035FEF File Offset: 0x000341EF
		public unsafe int aheadPointSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples)) = value;
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x060071B2 RID: 29106 RVA: 0x001F26FC File Offset: 0x001F08FC
		// (set) Token: 0x060071B3 RID: 29107 RVA: 0x0003600A File Offset: 0x0003420A
		public unsafe static float DestinationDistanceSlowThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x060071B4 RID: 29108 RVA: 0x001F2718 File Offset: 0x001F0918
		// (set) Token: 0x060071B5 RID: 29109 RVA: 0x00036018 File Offset: 0x00034218
		public unsafe static float DestinationArrivalThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x060071B6 RID: 29110 RVA: 0x001F2734 File Offset: 0x001F0934
		// (set) Token: 0x060071B7 RID: 29111 RVA: 0x00036026 File Offset: 0x00034226
		public unsafe float steerTargetFollowRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate)) = value;
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x060071B8 RID: 29112 RVA: 0x001F275C File Offset: 0x001F095C
		// (set) Token: 0x060071B9 RID: 29113 RVA: 0x00036041 File Offset: 0x00034241
		public unsafe SteerPID steerPID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteerPID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x060071BA RID: 29114 RVA: 0x001F278C File Offset: 0x001F098C
		// (set) Token: 0x060071BB RID: 29115 RVA: 0x00036060 File Offset: 0x00034260
		public unsafe float turnSpeedReductionMinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange)) = value;
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x060071BC RID: 29116 RVA: 0x001F27B4 File Offset: 0x001F09B4
		// (set) Token: 0x060071BD RID: 29117 RVA: 0x0003607B File Offset: 0x0003427B
		public unsafe float turnSpeedReductionMaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange)) = value;
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x060071BE RID: 29118 RVA: 0x001F27DC File Offset: 0x001F09DC
		// (set) Token: 0x060071BF RID: 29119 RVA: 0x00036096 File Offset: 0x00034296
		public unsafe float turnSpeedReductionDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor)) = value;
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x060071C0 RID: 29120 RVA: 0x001F2804 File Offset: 0x001F0A04
		// (set) Token: 0x060071C1 RID: 29121 RVA: 0x000360B1 File Offset: 0x000342B1
		public unsafe float minTurnSpeedReductionAngleThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold)) = value;
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x060071C2 RID: 29122 RVA: 0x001F282C File Offset: 0x001F0A2C
		// (set) Token: 0x060071C3 RID: 29123 RVA: 0x000360CC File Offset: 0x000342CC
		public unsafe float minTurningSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed)) = value;
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x060071C4 RID: 29124 RVA: 0x001F2854 File Offset: 0x001F0A54
		// (set) Token: 0x060071C5 RID: 29125 RVA: 0x000360E7 File Offset: 0x000342E7
		public unsafe float throttleMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin)) = value;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x060071C6 RID: 29126 RVA: 0x001F287C File Offset: 0x001F0A7C
		// (set) Token: 0x060071C7 RID: 29127 RVA: 0x00036102 File Offset: 0x00034302
		public unsafe float throttleMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax)) = value;
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x060071C8 RID: 29128 RVA: 0x001F28A4 File Offset: 0x001F0AA4
		// (set) Token: 0x060071C9 RID: 29129 RVA: 0x0003611D File Offset: 0x0003431D
		public unsafe PID throttlePID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x060071CA RID: 29130 RVA: 0x001F28D4 File Offset: 0x001F0AD4
		// (set) Token: 0x060071CB RID: 29131 RVA: 0x0003613C File Offset: 0x0003433C
		public unsafe static float UnmarkedSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x060071CC RID: 29132 RVA: 0x001F28F0 File Offset: 0x001F0AF0
		// (set) Token: 0x060071CD RID: 29133 RVA: 0x0003614A File Offset: 0x0003434A
		public unsafe static float ReverseSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x060071CE RID: 29134 RVA: 0x001F290C File Offset: 0x001F0B0C
		// (set) Token: 0x060071CF RID: 29135 RVA: 0x00036158 File Offset: 0x00034358
		public unsafe ValueTracker speedReductionTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x060071D0 RID: 29136 RVA: 0x001F293C File Offset: 0x001F0B3C
		// (set) Token: 0x060071D1 RID: 29137 RVA: 0x00036177 File Offset: 0x00034377
		public unsafe bool PursuitModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled)) = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x001F2964 File Offset: 0x001F0B64
		// (set) Token: 0x060071D3 RID: 29139 RVA: 0x00036192 File Offset: 0x00034392
		public unsafe Transform PursuitTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x001F2994 File Offset: 0x001F0B94
		// (set) Token: 0x060071D5 RID: 29141 RVA: 0x000361B1 File Offset: 0x000343B1
		public unsafe float PursuitDistanceUpdateThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold)) = value;
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x060071D6 RID: 29142 RVA: 0x001F29BC File Offset: 0x001F0BBC
		// (set) Token: 0x060071D7 RID: 29143 RVA: 0x000361CC File Offset: 0x000343CC
		public unsafe Vector3 PursuitTargetLastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition)) = value;
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x001F29E4 File Offset: 0x001F0BE4
		// (set) Token: 0x060071D9 RID: 29145 RVA: 0x000361E7 File Offset: 0x000343E7
		public unsafe VehicleTeleporter Teleporter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleTeleporter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x060071DA RID: 29146 RVA: 0x001F2A14 File Offset: 0x001F0C14
		// (set) Token: 0x060071DB RID: 29147 RVA: 0x00036206 File Offset: 0x00034406
		public unsafe PositionHistoryTracker PositionHistoryTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionHistoryTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x001F2A44 File Offset: 0x001F0C44
		// (set) Token: 0x060071DD RID: 29149 RVA: 0x00036225 File Offset: 0x00034425
		public unsafe float StuckTimeThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold)) = value;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x001F2A6C File Offset: 0x001F0C6C
		// (set) Token: 0x060071DF RID: 29151 RVA: 0x00036240 File Offset: 0x00034440
		public unsafe int StuckSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples)) = value;
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x001F2A94 File Offset: 0x001F0C94
		// (set) Token: 0x060071E1 RID: 29153 RVA: 0x0003625B File Offset: 0x0003445B
		public unsafe float StuckDistanceThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold)) = value;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x060071E2 RID: 29154 RVA: 0x001F2ABC File Offset: 0x001F0CBC
		// (set) Token: 0x060071E3 RID: 29155 RVA: 0x00036276 File Offset: 0x00034476
		public unsafe VehicleAgent.NavigationCallback storedNavigationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.NavigationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x060071E4 RID: 29156 RVA: 0x001F2AEC File Offset: 0x001F0CEC
		// (set) Token: 0x060071E5 RID: 29157 RVA: 0x00036295 File Offset: 0x00034495
		public unsafe SpeedZone currentSpeedZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpeedZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x060071E6 RID: 29158 RVA: 0x001F2B1C File Offset: 0x001F0D1C
		// (set) Token: 0x060071E7 RID: 29159 RVA: 0x000362B4 File Offset: 0x000344B4
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x060071E8 RID: 29160 RVA: 0x001F2B4C File Offset: 0x001F0D4C
		// (set) Token: 0x060071E9 RID: 29161 RVA: 0x000362D3 File Offset: 0x000344D3
		public unsafe float wheelbase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase)) = value;
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x060071EA RID: 29162 RVA: 0x001F2B74 File Offset: 0x001F0D74
		// (set) Token: 0x060071EB RID: 29163 RVA: 0x000362EE File Offset: 0x000344EE
		public unsafe float wheeltrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack)) = value;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x060071EC RID: 29164 RVA: 0x001F2B9C File Offset: 0x001F0D9C
		// (set) Token: 0x060071ED RID: 29165 RVA: 0x00036309 File Offset: 0x00034509
		public unsafe float vehicleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength)) = value;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x001F2BC4 File Offset: 0x001F0DC4
		// (set) Token: 0x060071EF RID: 29167 RVA: 0x00036324 File Offset: 0x00034524
		public unsafe float vehicleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth)) = value;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x060071F0 RID: 29168 RVA: 0x001F2BEC File Offset: 0x001F0DEC
		// (set) Token: 0x060071F1 RID: 29169 RVA: 0x0003633F File Offset: 0x0003453F
		public unsafe float turnRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius)) = value;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x060071F2 RID: 29170 RVA: 0x001F2C14 File Offset: 0x001F0E14
		// (set) Token: 0x060071F3 RID: 29171 RVA: 0x0003635A File Offset: 0x0003455A
		public unsafe float sweepTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack)) = value;
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x001F2C3C File Offset: 0x001F0E3C
		// (set) Token: 0x060071F5 RID: 29173 RVA: 0x00036375 File Offset: 0x00034575
		public unsafe float wheelBottomOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset)) = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x060071F6 RID: 29174 RVA: 0x001F2C64 File Offset: 0x001F0E64
		// (set) Token: 0x060071F7 RID: 29175 RVA: 0x00036390 File Offset: 0x00034590
		public unsafe float targetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed)) = value;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x060071F8 RID: 29176 RVA: 0x001F2C8C File Offset: 0x001F0E8C
		// (set) Token: 0x060071F9 RID: 29177 RVA: 0x000363AB File Offset: 0x000345AB
		public unsafe float targetSteerAngle_Normalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized)) = value;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x001F2CB4 File Offset: 0x001F0EB4
		// (set) Token: 0x060071FB RID: 29179 RVA: 0x000363C6 File Offset: 0x000345C6
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x001F2CDC File Offset: 0x001F0EDC
		// (set) Token: 0x060071FD RID: 29181 RVA: 0x000363E1 File Offset: 0x000345E1
		public unsafe PathSmoothingUtility.SmoothedPath path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x060071FE RID: 29182 RVA: 0x001F2D0C File Offset: 0x001F0F0C
		// (set) Token: 0x060071FF RID: 29183 RVA: 0x00036400 File Offset: 0x00034600
		public unsafe float timeSinceLastNavigationCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall)) = value;
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06007200 RID: 29184 RVA: 0x001F2D34 File Offset: 0x001F0F34
		// (set) Token: 0x06007201 RID: 29185 RVA: 0x0003641B File Offset: 0x0003461B
		public unsafe float sweepTestFailedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime)) = value;
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06007202 RID: 29186 RVA: 0x001F2D5C File Offset: 0x001F0F5C
		// (set) Token: 0x06007203 RID: 29187 RVA: 0x00036436 File Offset: 0x00034636
		public unsafe NavigationSettings currentNavigationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06007204 RID: 29188 RVA: 0x001F2D8C File Offset: 0x001F0F8C
		// (set) Token: 0x06007205 RID: 29189 RVA: 0x00036455 File Offset: 0x00034655
		public unsafe Coroutine navigationCalculationRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06007206 RID: 29190 RVA: 0x001F2DBC File Offset: 0x001F0FBC
		// (set) Token: 0x06007207 RID: 29191 RVA: 0x00036474 File Offset: 0x00034674
		public unsafe Coroutine reverseCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D49 RID: 19785
		private static readonly IntPtr NativeFieldInfoPtr_VehicleGraphName;

		// Token: 0x04004D4A RID: 19786
		private static readonly IntPtr NativeFieldInfoPtr_RoadGraphName;

		// Token: 0x04004D4B RID: 19787
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPath;

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeFieldInfoPtr_MainGraphSamplePoint;

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeFieldInfoPtr_MinRenavigationRate;

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeFieldInfoPtr_Steer_P;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeFieldInfoPtr_Steer_I;

		// Token: 0x04004D51 RID: 19793
		private static readonly IntPtr NativeFieldInfoPtr_Steer_D;

		// Token: 0x04004D52 RID: 19794
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_P;

		// Token: 0x04004D53 RID: 19795
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_I;

		// Token: 0x04004D54 RID: 19796
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_D;

		// Token: 0x04004D55 RID: 19797
		private static readonly IntPtr NativeFieldInfoPtr_Steer_Rate;

		// Token: 0x04004D56 RID: 19798
		private static readonly IntPtr NativeFieldInfoPtr_MaxAxlePositionShift;

		// Token: 0x04004D57 RID: 19799
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_MIN_RANGE;

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_MAX_RANGE;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeFieldInfoPtr__KinematicMode_k__BackingField;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeFieldInfoPtr__AutoDriving_k__BackingField;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeFieldInfoPtr__TargetLocation_k__BackingField;

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeFieldInfoPtr_CTE_Origin;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FL;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FM;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FR;

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeFieldInfoPtr_sensor_RR;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeFieldInfoPtr_sensor_RL;

		// Token: 0x04004D6B RID: 19819
		private static readonly IntPtr NativeFieldInfoPtr_sweepMask;

		// Token: 0x04004D6C RID: 19820
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_FL;

		// Token: 0x04004D6D RID: 19821
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_FR;

		// Token: 0x04004D6E RID: 19822
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_RL;

		// Token: 0x04004D6F RID: 19823
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_RR;

		// Token: 0x04004D70 RID: 19824
		private static readonly IntPtr NativeFieldInfoPtr_leftWheel;

		// Token: 0x04004D71 RID: 19825
		private static readonly IntPtr NativeFieldInfoPtr_rightWheel;

		// Token: 0x04004D72 RID: 19826
		private static readonly IntPtr NativeFieldInfoPtr_sweepSegment;

		// Token: 0x04004D73 RID: 19827
		private static readonly IntPtr NativeFieldInfoPtr_sampleStepSizeMin;

		// Token: 0x04004D74 RID: 19828
		private static readonly IntPtr NativeFieldInfoPtr_sampleStepSizeMax;

		// Token: 0x04004D75 RID: 19829
		private static readonly IntPtr NativeFieldInfoPtr_aheadPointSamples;

		// Token: 0x04004D76 RID: 19830
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDistanceSlowThreshold;

		// Token: 0x04004D77 RID: 19831
		private static readonly IntPtr NativeFieldInfoPtr_DestinationArrivalThreshold;

		// Token: 0x04004D78 RID: 19832
		private static readonly IntPtr NativeFieldInfoPtr_steerTargetFollowRate;

		// Token: 0x04004D79 RID: 19833
		private static readonly IntPtr NativeFieldInfoPtr_steerPID;

		// Token: 0x04004D7A RID: 19834
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionMinRange;

		// Token: 0x04004D7B RID: 19835
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionMaxRange;

		// Token: 0x04004D7C RID: 19836
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionDivisor;

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeFieldInfoPtr_minTurningSpeed;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeFieldInfoPtr_throttleMin;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeFieldInfoPtr_throttleMax;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeFieldInfoPtr_throttlePID;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeFieldInfoPtr_UnmarkedSpeed;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeFieldInfoPtr_ReverseSpeed;

		// Token: 0x04004D84 RID: 19844
		private static readonly IntPtr NativeFieldInfoPtr_speedReductionTracker;

		// Token: 0x04004D85 RID: 19845
		private static readonly IntPtr NativeFieldInfoPtr_PursuitModeEnabled;

		// Token: 0x04004D86 RID: 19846
		private static readonly IntPtr NativeFieldInfoPtr_PursuitTarget;

		// Token: 0x04004D87 RID: 19847
		private static readonly IntPtr NativeFieldInfoPtr_PursuitDistanceUpdateThreshold;

		// Token: 0x04004D88 RID: 19848
		private static readonly IntPtr NativeFieldInfoPtr_PursuitTargetLastPosition;

		// Token: 0x04004D89 RID: 19849
		private static readonly IntPtr NativeFieldInfoPtr_Teleporter;

		// Token: 0x04004D8A RID: 19850
		private static readonly IntPtr NativeFieldInfoPtr_PositionHistoryTracker;

		// Token: 0x04004D8B RID: 19851
		private static readonly IntPtr NativeFieldInfoPtr_StuckTimeThreshold;

		// Token: 0x04004D8C RID: 19852
		private static readonly IntPtr NativeFieldInfoPtr_StuckSamples;

		// Token: 0x04004D8D RID: 19853
		private static readonly IntPtr NativeFieldInfoPtr_StuckDistanceThreshold;

		// Token: 0x04004D8E RID: 19854
		private static readonly IntPtr NativeFieldInfoPtr_storedNavigationCallback;

		// Token: 0x04004D8F RID: 19855
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeedZone;

		// Token: 0x04004D90 RID: 19856
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D91 RID: 19857
		private static readonly IntPtr NativeFieldInfoPtr_wheelbase;

		// Token: 0x04004D92 RID: 19858
		private static readonly IntPtr NativeFieldInfoPtr_wheeltrack;

		// Token: 0x04004D93 RID: 19859
		private static readonly IntPtr NativeFieldInfoPtr_vehicleLength;

		// Token: 0x04004D94 RID: 19860
		private static readonly IntPtr NativeFieldInfoPtr_vehicleWidth;

		// Token: 0x04004D95 RID: 19861
		private static readonly IntPtr NativeFieldInfoPtr_turnRadius;

		// Token: 0x04004D96 RID: 19862
		private static readonly IntPtr NativeFieldInfoPtr_sweepTrack;

		// Token: 0x04004D97 RID: 19863
		private static readonly IntPtr NativeFieldInfoPtr_wheelBottomOffset;

		// Token: 0x04004D98 RID: 19864
		private static readonly IntPtr NativeFieldInfoPtr_targetSpeed;

		// Token: 0x04004D99 RID: 19865
		private static readonly IntPtr NativeFieldInfoPtr_targetSteerAngle_Normalized;

		// Token: 0x04004D9A RID: 19866
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04004D9B RID: 19867
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04004D9C RID: 19868
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastNavigationCall;

		// Token: 0x04004D9D RID: 19869
		private static readonly IntPtr NativeFieldInfoPtr_sweepTestFailedTime;

		// Token: 0x04004D9E RID: 19870
		private static readonly IntPtr NativeFieldInfoPtr_currentNavigationSettings;

		// Token: 0x04004D9F RID: 19871
		private static readonly IntPtr NativeFieldInfoPtr_navigationCalculationRoutine;

		// Token: 0x04004DA0 RID: 19872
		private static readonly IntPtr NativeFieldInfoPtr_reverseCoroutine;

		// Token: 0x04004DA1 RID: 19873
		private static readonly IntPtr NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0;

		// Token: 0x04004DA2 RID: 19874
		private static readonly IntPtr NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0;

		// Token: 0x04004DA3 RID: 19875
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0;

		// Token: 0x04004DA4 RID: 19876
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0;

		// Token: 0x04004DA5 RID: 19877
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0;

		// Token: 0x04004DA6 RID: 19878
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0;

		// Token: 0x04004DA7 RID: 19879
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0;

		// Token: 0x04004DA8 RID: 19880
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0;

		// Token: 0x04004DA9 RID: 19881
		private static readonly IntPtr NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0;

		// Token: 0x04004DAA RID: 19882
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0;

		// Token: 0x04004DAB RID: 19883
		private static readonly IntPtr NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0;

		// Token: 0x04004DAC RID: 19884
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0;

		// Token: 0x04004DAD RID: 19885
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004DAE RID: 19886
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004DAF RID: 19887
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0;

		// Token: 0x04004DB0 RID: 19888
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004DB1 RID: 19889
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0;

		// Token: 0x04004DB2 RID: 19890
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04004DB3 RID: 19891
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0;

		// Token: 0x04004DB4 RID: 19892
		private static readonly IntPtr NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0;

		// Token: 0x04004DB5 RID: 19893
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSweep_Private_Void_0;

		// Token: 0x04004DB6 RID: 19894
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0;

		// Token: 0x04004DB7 RID: 19895
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0;

		// Token: 0x04004DB8 RID: 19896
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0;

		// Token: 0x04004DB9 RID: 19897
		private static readonly IntPtr NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0;

		// Token: 0x04004DBA RID: 19898
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0;

		// Token: 0x04004DBB RID: 19899
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0;

		// Token: 0x04004DBC RID: 19900
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0;

		// Token: 0x04004DBD RID: 19901
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSteering_Protected_Void_0;

		// Token: 0x04004DBE RID: 19902
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0;

		// Token: 0x04004DBF RID: 19903
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0;

		// Token: 0x04004DC0 RID: 19904
		private static readonly IntPtr NativeMethodInfoPtr_EndDriving_Private_Void_0;

		// Token: 0x04004DC1 RID: 19905
		private static readonly IntPtr NativeMethodInfoPtr_StopNavigating_Public_Void_0;

		// Token: 0x04004DC2 RID: 19906
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0;

		// Token: 0x04004DC3 RID: 19907
		private static readonly IntPtr NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0;

		// Token: 0x04004DC4 RID: 19908
		private static readonly IntPtr NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0;

		// Token: 0x04004DC5 RID: 19909
		private static readonly IntPtr NativeMethodInfoPtr_StartReverse_Public_Void_0;

		// Token: 0x04004DC6 RID: 19910
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_IEnumerator_0;

		// Token: 0x04004DC7 RID: 19911
		private static readonly IntPtr NativeMethodInfoPtr_StopReversing_Private_Void_0;

		// Token: 0x04004DC8 RID: 19912
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0;

		// Token: 0x04004DC9 RID: 19913
		private static readonly IntPtr NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0;

		// Token: 0x04004DCA RID: 19914
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0;

		// Token: 0x04004DCB RID: 19915
		private static readonly IntPtr NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0;

		// Token: 0x04004DCC RID: 19916
		private static readonly IntPtr NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0;

		// Token: 0x04004DCD RID: 19917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004DCE RID: 19918
		private static readonly IntPtr NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0;

		// Token: 0x02000A78 RID: 2680
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationResult")]
		public enum ENavigationResult
		{
			// Token: 0x04008D69 RID: 36201
			Failed,
			// Token: 0x04008D6A RID: 36202
			Complete,
			// Token: 0x04008D6B RID: 36203
			Stopped
		}

		// Token: 0x02000A79 RID: 2681
		[OriginalName("Assembly-CSharp.dll", "", "EAgentStatus")]
		public enum EAgentStatus
		{
			// Token: 0x04008D6D RID: 36205
			Inactive,
			// Token: 0x04008D6E RID: 36206
			MovingToRoad,
			// Token: 0x04008D6F RID: 36207
			OnRoad
		}

		// Token: 0x02000A7A RID: 2682
		[OriginalName("Assembly-CSharp.dll", "", "EPathGroupStatus")]
		public enum EPathGroupStatus
		{
			// Token: 0x04008D71 RID: 36209
			Inactive,
			// Token: 0x04008D72 RID: 36210
			Calculating
		}

		// Token: 0x02000A7B RID: 2683
		[OriginalName("Assembly-CSharp.dll", "", "ESweepType")]
		public enum ESweepType
		{
			// Token: 0x04008D74 RID: 36212
			FL,
			// Token: 0x04008D75 RID: 36213
			FR,
			// Token: 0x04008D76 RID: 36214
			RL,
			// Token: 0x04008D77 RID: 36215
			RR
		}

		// Token: 0x02000A7C RID: 2684
		public sealed class NavigationCallback : MulticastDelegate
		{
			// Token: 0x0600D1A6 RID: 53670 RVA: 0x003231A0 File Offset: 0x003213A0
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCallback()
			{
				Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "NavigationCallback");
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677571);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677572);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677573);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677574);
			}

			// Token: 0x0600D1A7 RID: 53671 RVA: 0x00323214 File Offset: 0x00321414
			[CallerCount(97)]
			[CachedScanResults(RefRangeStart = 222303, RefRangeEnd = 222400, XrefRangeStart = 222300, XrefRangeEnd = 222303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1A8 RID: 53672 RVA: 0x00323270 File Offset: 0x00321470
			[CallerCount(0)]
			public unsafe void Invoke(VehicleAgent.ENavigationResult status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1A9 RID: 53673 RVA: 0x003232B0 File Offset: 0x003214B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222400, XrefRangeEnd = 222404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VehicleAgent.ENavigationResult status, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D1AA RID: 53674 RVA: 0x00323320 File Offset: 0x00321520
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1AB RID: 53675 RVA: 0x000661A2 File Offset: 0x000643A2
			public NavigationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D1AC RID: 53676 RVA: 0x000661AB File Offset: 0x000643AB
			public static implicit operator VehicleAgent.NavigationCallback(Action<VehicleAgent.ENavigationResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VehicleAgent.NavigationCallback>(A_0);
			}

			// Token: 0x0600D1AD RID: 53677 RVA: 0x000661B3 File Offset: 0x000643B3
			public static VehicleAgent.NavigationCallback operator +(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VehicleAgent.NavigationCallback>();
			}

			// Token: 0x0600D1AE RID: 53678 RVA: 0x000661C1 File Offset: 0x000643C1
			public static VehicleAgent.NavigationCallback operator -(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VehicleAgent.NavigationCallback>();
				}
				return result;
			}

			// Token: 0x04008D78 RID: 36216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D79 RID: 36217
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0;

			// Token: 0x04008D7A RID: 36218
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0;

			// Token: 0x04008D7B RID: 36219
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A7D RID: 2685
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D1AF RID: 53679 RVA: 0x00323364 File Offset: 0x00321564
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr);
				VehicleAgent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9");
				VehicleAgent.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__120_0");
				VehicleAgent.__c.NativeFieldInfoPtr___9__121_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__121_0");
				VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677576);
				VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677577);
				VehicleAgent.__c.NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677578);
			}

			// Token: 0x0600D1B0 RID: 53680 RVA: 0x00323408 File Offset: 0x00321608
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1B1 RID: 53681 RVA: 0x00323444 File Offset: 0x00321644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222404, XrefRangeEnd = 222405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateKinematic_b__120_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1B2 RID: 53682 RVA: 0x00323490 File Offset: 0x00321690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetAxleGroundHit_b__121_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1B3 RID: 53683 RVA: 0x000661D2 File Offset: 0x000643D2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004116 RID: 16662
			// (get) Token: 0x0600D1B4 RID: 53684 RVA: 0x003234DC File Offset: 0x003216DC
			// (set) Token: 0x0600D1B5 RID: 53685 RVA: 0x000661DB File Offset: 0x000643DB
			public unsafe static VehicleAgent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004117 RID: 16663
			// (get) Token: 0x0600D1B6 RID: 53686 RVA: 0x00323504 File Offset: 0x00321704
			// (set) Token: 0x0600D1B7 RID: 53687 RVA: 0x000661ED File Offset: 0x000643ED
			public unsafe static Func<RaycastHit, float> __9__120_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004118 RID: 16664
			// (get) Token: 0x0600D1B8 RID: 53688 RVA: 0x0032352C File Offset: 0x0032172C
			// (set) Token: 0x0600D1B9 RID: 53689 RVA: 0x000661FF File Offset: 0x000643FF
			public unsafe static Func<RaycastHit, float> __9__121_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__121_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__121_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D7C RID: 36220
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D7D RID: 36221
			private static readonly IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x04008D7E RID: 36222
			private static readonly IntPtr NativeFieldInfoPtr___9__121_0;

			// Token: 0x04008D7F RID: 36223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D80 RID: 36224
			private static readonly IntPtr NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0;

			// Token: 0x04008D81 RID: 36225
			private static readonly IntPtr NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000A7E RID: 2686
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass136_0")]
		public sealed class __c__DisplayClass136_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1BA RID: 53690 RVA: 0x00323554 File Offset: 0x00321754
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass136_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass136_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, 100677579);
				VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, 100677580);
			}

			// Token: 0x0600D1BB RID: 53691 RVA: 0x003235D0 File Offset: 0x003217D0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass136_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1BC RID: 53692 RVA: 0x0032360C File Offset: 0x0032180C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222405, XrefRangeEnd = 222411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _SweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1BD RID: 53693 RVA: 0x00066211 File Offset: 0x00064411
			public __c__DisplayClass136_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004119 RID: 16665
			// (get) Token: 0x0600D1BE RID: 53694 RVA: 0x00323658 File Offset: 0x00321858
			// (set) Token: 0x0600D1BF RID: 53695 RVA: 0x0006621A File Offset: 0x0006441A
			public unsafe Vector3 castStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x1700411A RID: 16666
			// (get) Token: 0x0600D1C0 RID: 53696 RVA: 0x00323680 File Offset: 0x00321880
			// (set) Token: 0x0600D1C1 RID: 53697 RVA: 0x00066235 File Offset: 0x00064435
			public unsafe Func<RaycastHit, float> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D82 RID: 36226
			private static readonly IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04008D83 RID: 36227
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008D84 RID: 36228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D85 RID: 36229
			private static readonly IntPtr NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000A7F RID: 2687
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass137_0")]
		public sealed class __c__DisplayClass137_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1C2 RID: 53698 RVA: 0x003236B0 File Offset: 0x003218B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass137_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass137_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, 100677581);
				VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, 100677582);
			}

			// Token: 0x0600D1C3 RID: 53699 RVA: 0x0032372C File Offset: 0x0032192C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass137_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C4 RID: 53700 RVA: 0x00323768 File Offset: 0x00321968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _BetterSweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1C5 RID: 53701 RVA: 0x00066254 File Offset: 0x00064454
			public __c__DisplayClass137_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700411B RID: 16667
			// (get) Token: 0x0600D1C6 RID: 53702 RVA: 0x003237B4 File Offset: 0x003219B4
			// (set) Token: 0x0600D1C7 RID: 53703 RVA: 0x0006625D File Offset: 0x0006445D
			public unsafe Vector3 castStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x1700411C RID: 16668
			// (get) Token: 0x0600D1C8 RID: 53704 RVA: 0x003237DC File Offset: 0x003219DC
			// (set) Token: 0x0600D1C9 RID: 53705 RVA: 0x00066278 File Offset: 0x00064478
			public unsafe Func<RaycastHit, float> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D86 RID: 36230
			private static readonly IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04008D87 RID: 36231
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008D88 RID: 36232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D89 RID: 36233
			private static readonly IntPtr NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000A80 RID: 2688
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<Reverse>d__139")]
		public sealed class _Reverse_d__139 : Il2CppSystem.Object
		{
			// Token: 0x0600D1CA RID: 53706 RVA: 0x0032380C File Offset: 0x00321A0C
			// Note: this type is marked as 'beforefieldinit'.
			static _Reverse_d__139()
			{
				Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<Reverse>d__139");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr);
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>1__state");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>2__current");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>4__this");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<futureTarget>5__2");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<steerAngleNormal>5__3");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<frontWheel>5__4");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<sweepAngle>5__5");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<reverseSweepDistanceMin>5__6");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<canBeginSwing>5__7");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<faceTarget>5__8");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<continueReversing>5__9");
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677583);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677584);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677585);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677586);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677587);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677588);
			}

			// Token: 0x0600D1CB RID: 53707 RVA: 0x0032398C File Offset: 0x00321B8C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reverse_d__139(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1CC RID: 53708 RVA: 0x003239D4 File Offset: 0x00321BD4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1CD RID: 53709 RVA: 0x00323A08 File Offset: 0x00321C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222411, XrefRangeEnd = 222431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004128 RID: 16680
			// (get) Token: 0x0600D1CE RID: 53710 RVA: 0x00323A44 File Offset: 0x00321C44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1CF RID: 53711 RVA: 0x00323A84 File Offset: 0x00321C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222431, XrefRangeEnd = 222436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004129 RID: 16681
			// (get) Token: 0x0600D1D0 RID: 53712 RVA: 0x00323AB8 File Offset: 0x00321CB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1D1 RID: 53713 RVA: 0x00066297 File Offset: 0x00064497
			public _Reverse_d__139(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700411D RID: 16669
			// (get) Token: 0x0600D1D2 RID: 53714 RVA: 0x00323AF8 File Offset: 0x00321CF8
			// (set) Token: 0x0600D1D3 RID: 53715 RVA: 0x000662A0 File Offset: 0x000644A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700411E RID: 16670
			// (get) Token: 0x0600D1D4 RID: 53716 RVA: 0x00323B20 File Offset: 0x00321D20
			// (set) Token: 0x0600D1D5 RID: 53717 RVA: 0x000662BB File Offset: 0x000644BB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700411F RID: 16671
			// (get) Token: 0x0600D1D6 RID: 53718 RVA: 0x00323B50 File Offset: 0x00321D50
			// (set) Token: 0x0600D1D7 RID: 53719 RVA: 0x000662DA File Offset: 0x000644DA
			public unsafe VehicleAgent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004120 RID: 16672
			// (get) Token: 0x0600D1D8 RID: 53720 RVA: 0x00323B80 File Offset: 0x00321D80
			// (set) Token: 0x0600D1D9 RID: 53721 RVA: 0x000662F9 File Offset: 0x000644F9
			public unsafe Vector3 _futureTarget_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2)) = value;
				}
			}

			// Token: 0x17004121 RID: 16673
			// (get) Token: 0x0600D1DA RID: 53722 RVA: 0x00323BA8 File Offset: 0x00321DA8
			// (set) Token: 0x0600D1DB RID: 53723 RVA: 0x00066314 File Offset: 0x00064514
			public unsafe float _steerAngleNormal_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3)) = value;
				}
			}

			// Token: 0x17004122 RID: 16674
			// (get) Token: 0x0600D1DC RID: 53724 RVA: 0x00323BD0 File Offset: 0x00321DD0
			// (set) Token: 0x0600D1DD RID: 53725 RVA: 0x0006632F File Offset: 0x0006452F
			public unsafe VehicleAgent.ESweepType _frontWheel_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4)) = value;
				}
			}

			// Token: 0x17004123 RID: 16675
			// (get) Token: 0x0600D1DE RID: 53726 RVA: 0x00323BF8 File Offset: 0x00321DF8
			// (set) Token: 0x0600D1DF RID: 53727 RVA: 0x0006634A File Offset: 0x0006454A
			public unsafe float _sweepAngle_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5)) = value;
				}
			}

			// Token: 0x17004124 RID: 16676
			// (get) Token: 0x0600D1E0 RID: 53728 RVA: 0x00323C20 File Offset: 0x00321E20
			// (set) Token: 0x0600D1E1 RID: 53729 RVA: 0x00066365 File Offset: 0x00064565
			public unsafe float _reverseSweepDistanceMin_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6)) = value;
				}
			}

			// Token: 0x17004125 RID: 16677
			// (get) Token: 0x0600D1E2 RID: 53730 RVA: 0x00323C48 File Offset: 0x00321E48
			// (set) Token: 0x0600D1E3 RID: 53731 RVA: 0x00066380 File Offset: 0x00064580
			public unsafe bool _canBeginSwing_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7)) = value;
				}
			}

			// Token: 0x17004126 RID: 16678
			// (get) Token: 0x0600D1E4 RID: 53732 RVA: 0x00323C70 File Offset: 0x00321E70
			// (set) Token: 0x0600D1E5 RID: 53733 RVA: 0x0006639B File Offset: 0x0006459B
			public unsafe Vector3 _faceTarget_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8)) = value;
				}
			}

			// Token: 0x17004127 RID: 16679
			// (get) Token: 0x0600D1E6 RID: 53734 RVA: 0x00323C98 File Offset: 0x00321E98
			// (set) Token: 0x0600D1E7 RID: 53735 RVA: 0x000663B6 File Offset: 0x000645B6
			public unsafe bool _continueReversing_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9)) = value;
				}
			}

			// Token: 0x04008D8A RID: 36234
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D8B RID: 36235
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D8C RID: 36236
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D8D RID: 36237
			private static readonly IntPtr NativeFieldInfoPtr__futureTarget_5__2;

			// Token: 0x04008D8E RID: 36238
			private static readonly IntPtr NativeFieldInfoPtr__steerAngleNormal_5__3;

			// Token: 0x04008D8F RID: 36239
			private static readonly IntPtr NativeFieldInfoPtr__frontWheel_5__4;

			// Token: 0x04008D90 RID: 36240
			private static readonly IntPtr NativeFieldInfoPtr__sweepAngle_5__5;

			// Token: 0x04008D91 RID: 36241
			private static readonly IntPtr NativeFieldInfoPtr__reverseSweepDistanceMin_5__6;

			// Token: 0x04008D92 RID: 36242
			private static readonly IntPtr NativeFieldInfoPtr__canBeginSwing_5__7;

			// Token: 0x04008D93 RID: 36243
			private static readonly IntPtr NativeFieldInfoPtr__faceTarget_5__8;

			// Token: 0x04008D94 RID: 36244
			private static readonly IntPtr NativeFieldInfoPtr__continueReversing_5__9;

			// Token: 0x04008D95 RID: 36245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D96 RID: 36246
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D97 RID: 36247
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D98 RID: 36248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D99 RID: 36249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D9A RID: 36250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
