using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035F RID: 863
	public class PursuitBehaviour : Behaviour
	{
		// Token: 0x0600428D RID: 17037 RVA: 0x0014C078 File Offset: 0x0014A278
		// Note: this type is marked as 'beforefieldinit'.
		static PursuitBehaviour()
		{
			Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr);
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_RANGE");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_INVESTIGATING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_ARRESTING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_CHASE");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_SHOOTING");
			PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_MAX_DISTANCE");
			PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "LEAVE_ARREST_CIRCLE_LIMIT");
			PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "isTargetVisible");
			PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "isTargetStrictlyVisible");
			PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "arrestingEnabled");
			PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentPursuitLevelDuration");
			PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeWithinArrestRange");
			PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "playerSightedDuration");
			PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "distanceOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "searchRoutine");
			PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentSearchDestination");
			PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "hasSearchDestination");
			PursuitBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "officer");
			PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "targetWasDrivingOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "wasInArrestCircleLastFrame");
			PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "leaveArrestCircleCount");
			PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "rangedWeapon");
			PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "nextAngryVO");
			PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "syncVar___isTargetVisible");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671415);
			PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671416);
			PursuitBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671417);
			PursuitBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671418);
			PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671419);
			PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671420);
			PursuitBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671421);
			PursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671422);
			PursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671423);
			PursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671424);
			PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671425);
			PursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671426);
			PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671427);
			PursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671428);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671429);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671430);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671431);
			PursuitBehaviour.NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671432);
			PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671433);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671434);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671435);
			PursuitBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671436);
			PursuitBehaviour.NativeMethodInfoPtr_CanShoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671437);
			PursuitBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671438);
			PursuitBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671439);
			PursuitBehaviour.NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671440);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671441);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671442);
			PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671443);
			PursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671444);
			PursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671445);
			PursuitBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671446);
			PursuitBehaviour.NativeMethodInfoPtr_ClearEquippables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671447);
			PursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671448);
			PursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671449);
			PursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671450);
			PursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671451);
			PursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671452);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671453);
			PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671454);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671455);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671456);
			PursuitBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671457);
			PursuitBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671458);
			PursuitBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671459);
			PursuitBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671460);
			PursuitBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671461);
			PursuitBehaviour.NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671462);
			PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671463);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671464);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671465);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671466);
			PursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671467);
			PursuitBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671468);
			PursuitBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671469);
			PursuitBehaviour.NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671470);
			PursuitBehaviour.NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671471);
			PursuitBehaviour.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671472);
			PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671473);
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x0014C83C File Offset: 0x0014AA3C
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x0014C87C File Offset: 0x0014AA7C
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x0014C8C0 File Offset: 0x0014AAC0
		// (set) Token: 0x06004291 RID: 17041 RVA: 0x0014C8FC File Offset: 0x0014AAFC
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x0014C93C File Offset: 0x0014AB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152836, XrefRangeEnd = 152837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x0014C978 File Offset: 0x0014AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152837, XrefRangeEnd = 152859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x0014C9AC File Offset: 0x0014ABAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152859, XrefRangeEnd = 152864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x0014C9FC File Offset: 0x0014ABFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152864, XrefRangeEnd = 152866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x0014CA5C File Offset: 0x0014AC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152866, XrefRangeEnd = 152888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x0014CA98 File Offset: 0x0014AC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152888, XrefRangeEnd = 152910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x0014CAD4 File Offset: 0x0014ACD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152910, XrefRangeEnd = 152915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0014CB10 File Offset: 0x0014AD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152915, XrefRangeEnd = 152939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x0014CB4C File Offset: 0x0014AD4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152944, RefRangeEnd = 152946, XrefRangeStart = 152939, XrefRangeEnd = 152944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x0014CB88 File Offset: 0x0014AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152946, XrefRangeEnd = 152948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x0014CBC4 File Offset: 0x0014ADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152948, XrefRangeEnd = 152969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInvestigatingBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x0014CC00 File Offset: 0x0014AE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152969, XrefRangeEnd = 153001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x0014CC3C File Offset: 0x0014AE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153017, RefRangeEnd = 153018, XrefRangeStart = 153001, XrefRangeEnd = 153017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArrest(float tick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x0014CC7C File Offset: 0x0014AE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153018, XrefRangeEnd = 153023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewArrestDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x0014CCB8 File Offset: 0x0014AEB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153051, RefRangeEnd = 153054, XrefRangeStart = 153023, XrefRangeEnd = 153051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x0014CCEC File Offset: 0x0014AEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153054, XrefRangeEnd = 153058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateNonLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x0014CD28 File Offset: 0x0014AF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x0014CD64 File Offset: 0x0014AF64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153063, RefRangeEnd = 153065, XrefRangeStart = 153058, XrefRangeEnd = 153063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0014CDA4 File Offset: 0x0014AFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153070, RefRangeEnd = 153071, XrefRangeStart = 153065, XrefRangeEnd = 153070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_CanShoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x0014CDE0 File Offset: 0x0014AFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153118, RefRangeEnd = 153119, XrefRangeStart = 153071, XrefRangeEnd = 153118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x0014CE1C File Offset: 0x0014B01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153124, RefRangeEnd = 153125, XrefRangeStart = 153119, XrefRangeEnd = 153124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeaponRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x0014CE5C File Offset: 0x0014B05C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153127, RefRangeEnd = 153129, XrefRangeStart = 153125, XrefRangeEnd = 153127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x0014CE90 File Offset: 0x0014B090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153129, XrefRangeEnd = 153136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x0014CECC File Offset: 0x0014B0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153136, XrefRangeEnd = 153160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x0014CF08 File Offset: 0x0014B108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153160, XrefRangeEnd = 153162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x0014CF44 File Offset: 0x0014B144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153162, XrefRangeEnd = 153164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x0014CF80 File Offset: 0x0014B180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153164, XrefRangeEnd = 153166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x0014CFBC File Offset: 0x0014B1BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153200, RefRangeEnd = 153202, XrefRangeStart = 153166, XrefRangeEnd = 153200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x0014CFF0 File Offset: 0x0014B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153202, XrefRangeEnd = 153213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEquippables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearEquippables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x0014D024 File Offset: 0x0014B224
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153239, RefRangeEnd = 153242, XrefRangeStart = 153213, XrefRangeEnd = 153239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x0014D058 File Offset: 0x0014B258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153246, RefRangeEnd = 153247, XrefRangeStart = 153242, XrefRangeEnd = 153246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x0014D08C File Offset: 0x0014B28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153247, XrefRangeEnd = 153250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x0014D0C8 File Offset: 0x0014B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153250, XrefRangeEnd = 153260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x0014D10C File Offset: 0x0014B30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153260, XrefRangeEnd = 153265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x0014D150 File Offset: 0x0014B350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153265, XrefRangeEnd = 153289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x0014D18C File Offset: 0x0014B38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153289, RefRangeEnd = 153290, XrefRangeStart = 153289, XrefRangeEnd = 153289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetArrestProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x0014D1C0 File Offset: 0x0014B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153290, XrefRangeEnd = 153292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x0014D200 File Offset: 0x0014B400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153292, XrefRangeEnd = 153293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x0014D240 File Offset: 0x0014B440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153301, RefRangeEnd = 153303, XrefRangeStart = 153293, XrefRangeEnd = 153301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0014D274 File Offset: 0x0014B474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153303, XrefRangeEnd = 153305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x0014D2A8 File Offset: 0x0014B4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153305, XrefRangeEnd = 153310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0014D2E8 File Offset: 0x0014B4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153310, XrefRangeEnd = 153323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x0014D324 File Offset: 0x0014B524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153342, RefRangeEnd = 153345, XrefRangeStart = 153323, XrefRangeEnd = 153342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0014D38C File Offset: 0x0014B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153345, XrefRangeEnd = 153346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorldspaceIconsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x0014D3CC File Offset: 0x0014B5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153346, XrefRangeEnd = 153349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x0014D408 File Offset: 0x0014B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153349, XrefRangeEnd = 153373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x0014D444 File Offset: 0x0014B644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153373, XrefRangeEnd = 153374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x0014D480 File Offset: 0x0014B680
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x0014D4BC File Offset: 0x0014B6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153403, RefRangeEnd = 153404, XrefRangeStart = 153374, XrefRangeEnd = 153403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0014D510 File Offset: 0x0014B710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153421, RefRangeEnd = 153423, XrefRangeStart = 153404, XrefRangeEnd = 153421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0014D570 File Offset: 0x0014B770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153423, XrefRangeEnd = 153428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060042C5 RID: 17093 RVA: 0x0014D5C0 File Offset: 0x0014B7C0
		// (set) Token: 0x060042C6 RID: 17094 RVA: 0x0014D5FC File Offset: 0x0014B7FC
		public unsafe bool SyncAccessor_isTargetVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 153436, RefRangeEnd = 153440, XrefRangeStart = 153428, XrefRangeEnd = 153436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x0014D648 File Offset: 0x0014B848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153440, XrefRangeEnd = 153443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x0014D6BC File Offset: 0x0014B8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153487, RefRangeEnd = 153488, XrefRangeStart = 153443, XrefRangeEnd = 153487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x00020A93 File Offset: 0x0001EC93
		public PursuitBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x0014D6F8 File Offset: 0x0014B8F8
		// (set) Token: 0x060042CB RID: 17099 RVA: 0x00020A9C File Offset: 0x0001EC9C
		public unsafe static float ARREST_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x0014D714 File Offset: 0x0014B914
		// (set) Token: 0x060042CD RID: 17101 RVA: 0x00020AAA File Offset: 0x0001ECAA
		public unsafe static float ARREST_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x060042CE RID: 17102 RVA: 0x0014D730 File Offset: 0x0014B930
		// (set) Token: 0x060042CF RID: 17103 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x0014D74C File Offset: 0x0014B94C
		// (set) Token: 0x060042D1 RID: 17105 RVA: 0x00020AC6 File Offset: 0x0001ECC6
		public unsafe static float MOVE_SPEED_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x0014D768 File Offset: 0x0014B968
		// (set) Token: 0x060042D3 RID: 17107 RVA: 0x00020AD4 File Offset: 0x0001ECD4
		public unsafe static float MOVE_SPEED_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x0014D784 File Offset: 0x0014B984
		// (set) Token: 0x060042D5 RID: 17109 RVA: 0x00020AE2 File Offset: 0x0001ECE2
		public unsafe static float MOVE_SPEED_CHASE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&value));
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x0014D7A0 File Offset: 0x0014B9A0
		// (set) Token: 0x060042D7 RID: 17111 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public unsafe static float MOVE_SPEED_SHOOTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING, (void*)(&value));
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x0014D7BC File Offset: 0x0014B9BC
		// (set) Token: 0x060042D9 RID: 17113 RVA: 0x00020AFE File Offset: 0x0001ECFE
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x0014D7D8 File Offset: 0x0014B9D8
		// (set) Token: 0x060042DB RID: 17115 RVA: 0x00020B0C File Offset: 0x0001ED0C
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x0014D7F4 File Offset: 0x0014B9F4
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x00020B1A File Offset: 0x0001ED1A
		public unsafe static float ARREST_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x0014D810 File Offset: 0x0014BA10
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x00020B28 File Offset: 0x0001ED28
		public unsafe static int LEAVE_ARREST_CIRCLE_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x0014D82C File Offset: 0x0014BA2C
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x00020B36 File Offset: 0x0001ED36
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x0014D848 File Offset: 0x0014BA48
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x00020B44 File Offset: 0x0001ED44
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x0014D878 File Offset: 0x0014BA78
		// (set) Token: 0x060042E5 RID: 17125 RVA: 0x00020B63 File Offset: 0x0001ED63
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x0014D8A0 File Offset: 0x0014BAA0
		// (set) Token: 0x060042E7 RID: 17127 RVA: 0x00020B7E File Offset: 0x0001ED7E
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x0014D8C8 File Offset: 0x0014BAC8
		// (set) Token: 0x060042E9 RID: 17129 RVA: 0x00020B99 File Offset: 0x0001ED99
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x0014D8F0 File Offset: 0x0014BAF0
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public unsafe bool isTargetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible)) = value;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x0014D918 File Offset: 0x0014BB18
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x00020BCF File Offset: 0x0001EDCF
		public unsafe bool isTargetStrictlyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible)) = value;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0014D940 File Offset: 0x0014BB40
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x00020BEA File Offset: 0x0001EDEA
		public unsafe bool arrestingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled)) = value;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0014D968 File Offset: 0x0014BB68
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00020C05 File Offset: 0x0001EE05
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x0014D990 File Offset: 0x0014BB90
		// (set) Token: 0x060042F3 RID: 17139 RVA: 0x00020C20 File Offset: 0x0001EE20
		public unsafe float currentPursuitLevelDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x0014D9B8 File Offset: 0x0014BBB8
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00020C3B File Offset: 0x0001EE3B
		public unsafe float timeWithinArrestRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange)) = value;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x0014D9E0 File Offset: 0x0014BBE0
		// (set) Token: 0x060042F7 RID: 17143 RVA: 0x00020C56 File Offset: 0x0001EE56
		public unsafe float playerSightedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x0014DA08 File Offset: 0x0014BC08
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x00020C71 File Offset: 0x0001EE71
		public unsafe float distanceOnPursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart)) = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x0014DA30 File Offset: 0x0014BC30
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00020C8C File Offset: 0x0001EE8C
		public unsafe Coroutine searchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_searchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0014DA60 File Offset: 0x0014BC60
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x00020CAB File Offset: 0x0001EEAB
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x0014DA90 File Offset: 0x0014BC90
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x00020CCA File Offset: 0x0001EECA
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x0014DAB8 File Offset: 0x0014BCB8
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x00020CE5 File Offset: 0x0001EEE5
		public unsafe bool hasSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x0014DAE0 File Offset: 0x0014BCE0
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x00020D00 File Offset: 0x0001EF00
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x0014DB10 File Offset: 0x0014BD10
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x00020D1F File Offset: 0x0001EF1F
		public unsafe bool targetWasDrivingOnPursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart)) = value;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0014DB38 File Offset: 0x0014BD38
		// (set) Token: 0x06004307 RID: 17159 RVA: 0x00020D3A File Offset: 0x0001EF3A
		public unsafe bool wasInArrestCircleLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame)) = value;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x0014DB60 File Offset: 0x0014BD60
		// (set) Token: 0x06004309 RID: 17161 RVA: 0x00020D55 File Offset: 0x0001EF55
		public unsafe int leaveArrestCircleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount)) = value;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x0014DB88 File Offset: 0x0014BD88
		// (set) Token: 0x0600430B RID: 17163 RVA: 0x00020D70 File Offset: 0x0001EF70
		public unsafe AvatarRangedWeapon rangedWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600430C RID: 17164 RVA: 0x0014DBB8 File Offset: 0x0014BDB8
		// (set) Token: 0x0600430D RID: 17165 RVA: 0x00020D8F File Offset: 0x0001EF8F
		public unsafe int consecutiveMissedShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x0014DBE0 File Offset: 0x0014BDE0
		// (set) Token: 0x0600430F RID: 17167 RVA: 0x00020DAA File Offset: 0x0001EFAA
		public unsafe float nextAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x0014DC08 File Offset: 0x0014BE08
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x00020DC5 File Offset: 0x0001EFC5
		public unsafe SyncVar<bool> syncVar___isTargetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x0014DC38 File Offset: 0x0014BE38
		// (set) Token: 0x06004313 RID: 17171 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06004314 RID: 17172 RVA: 0x0014DC60 File Offset: 0x0014BE60
		// (set) Token: 0x06004315 RID: 17173 RVA: 0x00020DFF File Offset: 0x0001EFFF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_RANGE;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_TIME;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_ARRESTING;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_CHASE;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_SHOOTING;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_MAX_DISTANCE;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeFieldInfoPtr_isTargetVisible;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeFieldInfoPtr_isTargetStrictlyVisible;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeFieldInfoPtr_arrestingEnabled;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeFieldInfoPtr_currentPursuitLevelDuration;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinArrestRange;

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeFieldInfoPtr_distanceOnPursuitStart;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeFieldInfoPtr_targetWasDrivingOnPursuitStart;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeFieldInfoPtr_wasInArrestCircleLastFrame;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeFieldInfoPtr_leaveArrestCircleCount;

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeapon;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___isTargetVisible;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_CanShoot_Private_Boolean_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Private_Boolean_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeMethodInfoPtr_ClearEquippables_Private_Void_0;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000961 RID: 2401
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitAction")]
		public enum EPursuitAction
		{
			// Token: 0x04008810 RID: 34832
			None,
			// Token: 0x04008811 RID: 34833
			Move,
			// Token: 0x04008812 RID: 34834
			Shoot,
			// Token: 0x04008813 RID: 34835
			MoveAndShoot
		}

		// Token: 0x02000962 RID: 2402
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PursuitBehaviour+<RangedWeaponRoutine>d__59")]
		public sealed class _RangedWeaponRoutine_d__59 : Il2CppSystem.Object
		{
			// Token: 0x0600C908 RID: 51464 RVA: 0x0030AFCC File Offset: 0x003091CC
			// Note: this type is marked as 'beforefieldinit'.
			static _RangedWeaponRoutine_d__59()
			{
				Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<RangedWeaponRoutine>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>1__state");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>2__current");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>4__this");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentAction>5__2");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentActionDuration>5__3");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentActionTime>5__4");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671474);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671475);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671476);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671477);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671478);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671479);
			}

			// Token: 0x0600C909 RID: 51465 RVA: 0x0030B0E8 File Offset: 0x003092E8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RangedWeaponRoutine_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C90A RID: 51466 RVA: 0x0030B130 File Offset: 0x00309330
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C90B RID: 51467 RVA: 0x0030B164 File Offset: 0x00309364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152709, XrefRangeEnd = 152825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EBC RID: 16060
			// (get) Token: 0x0600C90C RID: 51468 RVA: 0x0030B1A0 File Offset: 0x003093A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C90D RID: 51469 RVA: 0x0030B1E0 File Offset: 0x003093E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152825, XrefRangeEnd = 152830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EBD RID: 16061
			// (get) Token: 0x0600C90E RID: 51470 RVA: 0x0030B214 File Offset: 0x00309414
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C90F RID: 51471 RVA: 0x00061C88 File Offset: 0x0005FE88
			public _RangedWeaponRoutine_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB6 RID: 16054
			// (get) Token: 0x0600C910 RID: 51472 RVA: 0x0030B254 File Offset: 0x00309454
			// (set) Token: 0x0600C911 RID: 51473 RVA: 0x00061C91 File Offset: 0x0005FE91
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EB7 RID: 16055
			// (get) Token: 0x0600C912 RID: 51474 RVA: 0x0030B27C File Offset: 0x0030947C
			// (set) Token: 0x0600C913 RID: 51475 RVA: 0x00061CAC File Offset: 0x0005FEAC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB8 RID: 16056
			// (get) Token: 0x0600C914 RID: 51476 RVA: 0x0030B2AC File Offset: 0x003094AC
			// (set) Token: 0x0600C915 RID: 51477 RVA: 0x00061CCB File Offset: 0x0005FECB
			public unsafe PursuitBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB9 RID: 16057
			// (get) Token: 0x0600C916 RID: 51478 RVA: 0x0030B2DC File Offset: 0x003094DC
			// (set) Token: 0x0600C917 RID: 51479 RVA: 0x00061CEA File Offset: 0x0005FEEA
			public unsafe PursuitBehaviour.EPursuitAction _currentAction_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2)) = value;
				}
			}

			// Token: 0x17003EBA RID: 16058
			// (get) Token: 0x0600C918 RID: 51480 RVA: 0x0030B304 File Offset: 0x00309504
			// (set) Token: 0x0600C919 RID: 51481 RVA: 0x00061D05 File Offset: 0x0005FF05
			public unsafe float _currentActionDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3)) = value;
				}
			}

			// Token: 0x17003EBB RID: 16059
			// (get) Token: 0x0600C91A RID: 51482 RVA: 0x0030B32C File Offset: 0x0030952C
			// (set) Token: 0x0600C91B RID: 51483 RVA: 0x00061D20 File Offset: 0x0005FF20
			public unsafe float _currentActionTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4)) = value;
				}
			}

			// Token: 0x04008814 RID: 34836
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008815 RID: 34837
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008816 RID: 34838
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008817 RID: 34839
			private static readonly IntPtr NativeFieldInfoPtr__currentAction_5__2;

			// Token: 0x04008818 RID: 34840
			private static readonly IntPtr NativeFieldInfoPtr__currentActionDuration_5__3;

			// Token: 0x04008819 RID: 34841
			private static readonly IntPtr NativeFieldInfoPtr__currentActionTime_5__4;

			// Token: 0x0400881A RID: 34842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400881B RID: 34843
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400881C RID: 34844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400881D RID: 34845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400881E RID: 34846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400881F RID: 34847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000963 RID: 2403
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PursuitBehaviour+<SearchRoutine>d__82")]
		public sealed class _SearchRoutine_d__82 : Il2CppSystem.Object
		{
			// Token: 0x0600C91C RID: 51484 RVA: 0x0030B354 File Offset: 0x00309554
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__82()
			{
				Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<SearchRoutine>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr);
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>1__state");
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>2__current");
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>4__this");
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671480);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671481);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671482);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671483);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671484);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671485);
			}

			// Token: 0x0600C91D RID: 51485 RVA: 0x0030B434 File Offset: 0x00309634
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__82(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C91E RID: 51486 RVA: 0x0030B47C File Offset: 0x0030967C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C91F RID: 51487 RVA: 0x0030B4B0 File Offset: 0x003096B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152830, XrefRangeEnd = 152831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EC1 RID: 16065
			// (get) Token: 0x0600C920 RID: 51488 RVA: 0x0030B4EC File Offset: 0x003096EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C921 RID: 51489 RVA: 0x0030B52C File Offset: 0x0030972C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152831, XrefRangeEnd = 152836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EC2 RID: 16066
			// (get) Token: 0x0600C922 RID: 51490 RVA: 0x0030B560 File Offset: 0x00309760
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C923 RID: 51491 RVA: 0x00061D3B File Offset: 0x0005FF3B
			public _SearchRoutine_d__82(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EBE RID: 16062
			// (get) Token: 0x0600C924 RID: 51492 RVA: 0x0030B5A0 File Offset: 0x003097A0
			// (set) Token: 0x0600C925 RID: 51493 RVA: 0x00061D44 File Offset: 0x0005FF44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EBF RID: 16063
			// (get) Token: 0x0600C926 RID: 51494 RVA: 0x0030B5C8 File Offset: 0x003097C8
			// (set) Token: 0x0600C927 RID: 51495 RVA: 0x00061D5F File Offset: 0x0005FF5F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC0 RID: 16064
			// (get) Token: 0x0600C928 RID: 51496 RVA: 0x0030B5F8 File Offset: 0x003097F8
			// (set) Token: 0x0600C929 RID: 51497 RVA: 0x00061D7E File Offset: 0x0005FF7E
			public unsafe PursuitBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008820 RID: 34848
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008821 RID: 34849
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008822 RID: 34850
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008823 RID: 34851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008824 RID: 34852
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008825 RID: 34853
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008826 RID: 34854
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008827 RID: 34855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008828 RID: 34856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
