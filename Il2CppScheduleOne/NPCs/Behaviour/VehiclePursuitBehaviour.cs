using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vision;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000368 RID: 872
	public class VehiclePursuitBehaviour : Behaviour
	{
		// Token: 0x060043FD RID: 17405 RVA: 0x00150EB8 File Offset: 0x0014F0B8
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePursuitBehaviour()
		{
			Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr);
			VehiclePursuitBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "EXIT_VEHICLE_MAX_SPEED");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "CLOSE_ENOUGH_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "UPDATE_FREQUENCY");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "STATIONARY_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "TIME_STATIONARY_TO_EXIT");
			VehiclePursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "RepathDistanceThresholdMap");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "vehicle");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "initialContactMade");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "aggressiveDrivingEnabled");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "isTargetVisible");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "isTargetStrictlyVisible");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "playerSightedDuration");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "consecutivePathingFailures");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeStationary");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "currentDriveTarget");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "targetChanges");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeSincePursuitStart");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "beginAsSighted");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671609);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671610);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671611);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671612);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671613);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671614);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_BeginAsSighted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671615);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671616);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671617);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671618);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671619);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671620);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_StartPursuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671621);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671622);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671623);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671624);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671625);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671626);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671627);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671628);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671629);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671630);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671631);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671632);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671633);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671634);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671635);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671636);
			VehiclePursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671637);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671638);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671639);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671640);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671641);
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x0015135C File Offset: 0x0014F55C
		// (set) Token: 0x060043FF RID: 17407 RVA: 0x0015139C File Offset: 0x0014F59C
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x001513E0 File Offset: 0x0014F5E0
		public unsafe bool isDriving
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 154540, RefRangeEnd = 154545, XrefRangeStart = 154533, XrefRangeEnd = 154540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x0015141C File Offset: 0x0014F61C
		public unsafe VehicleAgent Agent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr3) : null;
			}
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x0015145C File Offset: 0x0014F65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154545, XrefRangeEnd = 154546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00151498 File Offset: 0x0014F698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154546, XrefRangeEnd = 154568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x001514CC File Offset: 0x0014F6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154568, RefRangeEnd = 154569, XrefRangeStart = 154568, XrefRangeEnd = 154568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginAsSighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_BeginAsSighted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x00151500 File Offset: 0x0014F700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154569, XrefRangeEnd = 154576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x0015153C File Offset: 0x0014F73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154576, XrefRangeEnd = 154578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x00151578 File Offset: 0x0014F778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154578, XrefRangeEnd = 154586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x001515B4 File Offset: 0x0014F7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154586, XrefRangeEnd = 154613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x001515F0 File Offset: 0x0014F7F0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00151640 File Offset: 0x0014F840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154658, RefRangeEnd = 154660, XrefRangeStart = 154613, XrefRangeEnd = 154658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_StartPursuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00151674 File Offset: 0x0014F874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154660, XrefRangeEnd = 154663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x001516B0 File Offset: 0x0014F8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154663, XrefRangeEnd = 154680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x001516EC File Offset: 0x0014F8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154680, XrefRangeEnd = 154681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00151728 File Offset: 0x0014F928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154729, RefRangeEnd = 154730, XrefRangeStart = 154681, XrefRangeEnd = 154729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x0015175C File Offset: 0x0014F95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154730, XrefRangeEnd = 154735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00151798 File Offset: 0x0014F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154735, XrefRangeEnd = 154742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x001517CC File Offset: 0x0014F9CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 154750, RefRangeEnd = 154757, XrefRangeStart = 154742, XrefRangeEnd = 154750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlayerChasePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00151808 File Offset: 0x0014FA08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154759, RefRangeEnd = 154761, XrefRangeStart = 154757, XrefRangeEnd = 154759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAggressiveDriving(bool aggressive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aggressive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00151848 File Offset: 0x0014FA48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 154763, RefRangeEnd = 154769, XrefRangeStart = 154761, XrefRangeEnd = 154763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DriveTo(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00151888 File Offset: 0x0014FA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154769, XrefRangeEnd = 154772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x001518C8 File Offset: 0x0014FAC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154495, RefRangeEnd = 154498, XrefRangeStart = 154495, XrefRangeEnd = 154498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00151920 File Offset: 0x0014FB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x0015195C File Offset: 0x0014FB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154784, RefRangeEnd = 154785, XrefRangeStart = 154772, XrefRangeEnd = 154784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00151990 File Offset: 0x0014FB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154785, XrefRangeEnd = 154794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x001519D4 File Offset: 0x0014FBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154794, XrefRangeEnd = 154800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00151A18 File Offset: 0x0014FC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154800, XrefRangeEnd = 154803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00151A54 File Offset: 0x0014FC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154803, XrefRangeEnd = 154804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00151A90 File Offset: 0x0014FC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154804, XrefRangeEnd = 154805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00151ACC File Offset: 0x0014FCCC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00151B08 File Offset: 0x0014FD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154848, RefRangeEnd = 154849, XrefRangeStart = 154805, XrefRangeEnd = 154848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00021350 File Offset: 0x0001F550
		public VehiclePursuitBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x00151B44 File Offset: 0x0014FD44
		// (set) Token: 0x06004421 RID: 17441 RVA: 0x00021359 File Offset: 0x0001F559
		public new unsafe static float MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x00151B60 File Offset: 0x0014FD60
		// (set) Token: 0x06004423 RID: 17443 RVA: 0x00021367 File Offset: 0x0001F567
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06004424 RID: 17444 RVA: 0x00151B7C File Offset: 0x0014FD7C
		// (set) Token: 0x06004425 RID: 17445 RVA: 0x00021375 File Offset: 0x0001F575
		public unsafe static float EXIT_VEHICLE_MAX_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED, (void*)(&value));
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x00151B98 File Offset: 0x0014FD98
		// (set) Token: 0x06004427 RID: 17447 RVA: 0x00021383 File Offset: 0x0001F583
		public unsafe static float CLOSE_ENOUGH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x00151BB4 File Offset: 0x0014FDB4
		// (set) Token: 0x06004429 RID: 17449 RVA: 0x00021391 File Offset: 0x0001F591
		public unsafe static float UPDATE_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x00151BD0 File Offset: 0x0014FDD0
		// (set) Token: 0x0600442B RID: 17451 RVA: 0x0002139F File Offset: 0x0001F59F
		public unsafe static float STATIONARY_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600442C RID: 17452 RVA: 0x00151BEC File Offset: 0x0014FDEC
		// (set) Token: 0x0600442D RID: 17453 RVA: 0x000213AD File Offset: 0x0001F5AD
		public unsafe static float TIME_STATIONARY_TO_EXIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT, (void*)(&value));
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x00151C08 File Offset: 0x0014FE08
		// (set) Token: 0x0600442F RID: 17455 RVA: 0x000213BB File Offset: 0x0001F5BB
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x00151C38 File Offset: 0x0014FE38
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x000213DA File Offset: 0x0001F5DA
		public unsafe AnimationCurve RepathDistanceThresholdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x00151C68 File Offset: 0x0014FE68
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x000213F9 File Offset: 0x0001F5F9
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x00151C98 File Offset: 0x0014FE98
		// (set) Token: 0x06004435 RID: 17461 RVA: 0x00021418 File Offset: 0x0001F618
		public unsafe bool initialContactMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade)) = value;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x00151CC0 File Offset: 0x0014FEC0
		// (set) Token: 0x06004437 RID: 17463 RVA: 0x00021433 File Offset: 0x0001F633
		public unsafe bool aggressiveDrivingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled)) = value;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x00151CE8 File Offset: 0x0014FEE8
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x0002144E File Offset: 0x0001F64E
		public unsafe bool isTargetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetVisible)) = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x00151D10 File Offset: 0x0014FF10
		// (set) Token: 0x0600443B RID: 17467 RVA: 0x00021469 File Offset: 0x0001F669
		public unsafe bool isTargetStrictlyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible)) = value;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00151D38 File Offset: 0x0014FF38
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x00021484 File Offset: 0x0001F684
		public unsafe float playerSightedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x00151D60 File Offset: 0x0014FF60
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x0002149F File Offset: 0x0001F69F
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x00151D88 File Offset: 0x0014FF88
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x000214BA File Offset: 0x0001F6BA
		public new unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x00151DB0 File Offset: 0x0014FFB0
		// (set) Token: 0x06004443 RID: 17475 RVA: 0x000214D5 File Offset: 0x0001F6D5
		public unsafe float timeStationary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary)) = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x00151DD8 File Offset: 0x0014FFD8
		// (set) Token: 0x06004445 RID: 17477 RVA: 0x000214F0 File Offset: 0x0001F6F0
		public unsafe Vector3 currentDriveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget)) = value;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x00151E00 File Offset: 0x00150000
		// (set) Token: 0x06004447 RID: 17479 RVA: 0x0002150B File Offset: 0x0001F70B
		public unsafe int targetChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges)) = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x00151E28 File Offset: 0x00150028
		// (set) Token: 0x06004449 RID: 17481 RVA: 0x00021526 File Offset: 0x0001F726
		public unsafe float timeSincePursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart)) = value;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x00151E50 File Offset: 0x00150050
		// (set) Token: 0x0600444B RID: 17483 RVA: 0x00021541 File Offset: 0x0001F741
		public unsafe bool beginAsSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted)) = value;
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x00151E78 File Offset: 0x00150078
		// (set) Token: 0x0600444D RID: 17485 RVA: 0x0002155C File Offset: 0x0001F75C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x00151EA0 File Offset: 0x001500A0
		// (set) Token: 0x0600444F RID: 17487 RVA: 0x00021577 File Offset: 0x0001F777
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED;

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_FREQUENCY;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeFieldInfoPtr_STATIONARY_THRESHOLD;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeFieldInfoPtr_RepathDistanceThresholdMap;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeFieldInfoPtr_initialContactMade;

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeFieldInfoPtr_aggressiveDrivingEnabled;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeFieldInfoPtr_isTargetVisible;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeFieldInfoPtr_isTargetStrictlyVisible;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeFieldInfoPtr_timeStationary;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeFieldInfoPtr_currentDriveTarget;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeFieldInfoPtr_targetChanges;

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePursuitStart;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeFieldInfoPtr_beginAsSighted;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeMethodInfoPtr_BeginAsSighted_Public_Void_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_StartPursuit_Private_Void_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0;

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Private_Boolean_0;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Private_Void_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
