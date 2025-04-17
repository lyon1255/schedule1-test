using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E4 RID: 996
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x06005025 RID: 20517 RVA: 0x0017EE5C File Offset: 0x0017D05C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCrimeData()
		{
			Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCrimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr);
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_INVESTIGATING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_LETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MIN");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MAX");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIFETIME");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIMIT");
			PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NearestOfficer");
			PlayerCrimeData.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Player");
			PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "onPursuitEscapedSound");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_Pursuers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Pursuers");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentArrestProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentBodySearchProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSincePursuitStart");
			PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "CurrentPursuitLevelDuration");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSinceSighted");
			PlayerCrimeData.NativeFieldInfoPtr_Crimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Crimes");
			PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "BodySearchPending");
			PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<TimeSinceLastBodySearch>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<EvadedArrest>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "timeSinceLastShot");
			PlayerCrimeData.NativeFieldInfoPtr_Collisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Collisions");
			PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "_lightCombatTrack");
			PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "_heavyCombatTrack");
			PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "outOfSightTimeToDipMusic");
			PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "minMusicVolume");
			PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "musicChangeRate_Down");
			PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "musicChangeRate_Up");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673362);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673363);
			PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673364);
			PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673365);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673366);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673367);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673368);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673369);
			PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673370);
			PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673371);
			PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673372);
			PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673373);
			PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673374);
			PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673375);
			PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673376);
			PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673377);
			PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673378);
			PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673379);
			PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673380);
			PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673381);
			PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673382);
			PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673383);
			PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673384);
			PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673385);
			PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673386);
			PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673387);
			PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673388);
			PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673389);
			PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673390);
			PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673391);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673392);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673393);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateMusic_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673394);
			PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673395);
			PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673396);
			PlayerCrimeData.NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673397);
			PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673398);
			PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673399);
			PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673400);
			PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673401);
			PlayerCrimeData.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673402);
			PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673403);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673404);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673405);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673406);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673407);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673408);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673409);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673410);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673411);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673412);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673413);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673414);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673415);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673416);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673417);
			PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673418);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673419);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673420);
			PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673421);
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x0017F620 File Offset: 0x0017D820
		// (set) Token: 0x06005027 RID: 20519 RVA: 0x0017F65C File Offset: 0x0017D85C
		public unsafe PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60909, RefRangeEnd = 60949, XrefRangeStart = 60909, XrefRangeEnd = 60949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 174446, RefRangeEnd = 174447, XrefRangeStart = 174413, XrefRangeEnd = 174446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x0017F69C File Offset: 0x0017D89C
		// (set) Token: 0x06005029 RID: 20521 RVA: 0x0017F6D8 File Offset: 0x0017D8D8
		public unsafe Vector3 LastKnownPosition
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 174447, RefRangeEnd = 174458, XrefRangeStart = 174447, XrefRangeEnd = 174447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174458, XrefRangeEnd = 174466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x0017F718 File Offset: 0x0017D918
		// (set) Token: 0x0600502B RID: 20523 RVA: 0x0017F754 File Offset: 0x0017D954
		public unsafe float CurrentArrestProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x0017F794 File Offset: 0x0017D994
		// (set) Token: 0x0600502D RID: 20525 RVA: 0x0017F7D0 File Offset: 0x0017D9D0
		public unsafe float CurrentBodySearchProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x0017F810 File Offset: 0x0017DA10
		// (set) Token: 0x0600502F RID: 20527 RVA: 0x0017F84C File Offset: 0x0017DA4C
		public unsafe float TimeSinceLastBodySearch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x0017F88C File Offset: 0x0017DA8C
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x0017F8C8 File Offset: 0x0017DAC8
		public unsafe bool EvadedArrest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x0017F908 File Offset: 0x0017DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174466, XrefRangeEnd = 174467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x0017F944 File Offset: 0x0017DB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174467, XrefRangeEnd = 174487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x0017F978 File Offset: 0x0017DB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174487, XrefRangeEnd = 174501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x0017F9AC File Offset: 0x0017DBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174501, XrefRangeEnd = 174594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x0017F9E8 File Offset: 0x0017DBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174594, XrefRangeEnd = 174613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x0017FA24 File Offset: 0x0017DC24
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 174648, RefRangeEnd = 174678, XrefRangeStart = 174613, XrefRangeEnd = 174648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x0017FA64 File Offset: 0x0017DC64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 174696, RefRangeEnd = 174703, XrefRangeStart = 174678, XrefRangeEnd = 174696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x0017FA98 File Offset: 0x0017DC98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174707, RefRangeEnd = 174708, XrefRangeStart = 174703, XrefRangeEnd = 174707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deescalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x0017FACC File Offset: 0x0017DCCC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 174730, RefRangeEnd = 174746, XrefRangeStart = 174708, XrefRangeEnd = 174730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x0017FB0C File Offset: 0x0017DD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174748, RefRangeEnd = 174749, XrefRangeStart = 174746, XrefRangeEnd = 174748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x0017FB4C File Offset: 0x0017DD4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174749, RefRangeEnd = 174752, XrefRangeStart = 174749, XrefRangeEnd = 174749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodysearchCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x0017FB80 File Offset: 0x0017DD80
		[CallerCount(0)]
		public unsafe void SetBodySearchProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x0017FBC0 File Offset: 0x0017DDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174752, XrefRangeEnd = 174754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x0017FBF4 File Offset: 0x0017DDF4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 174781, RefRangeEnd = 174797, XrefRangeStart = 174754, XrefRangeEnd = 174781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCrime(Crime crime, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x0017FC44 File Offset: 0x0017DE44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174800, RefRangeEnd = 174802, XrefRangeStart = 174797, XrefRangeEnd = 174800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x0017FC78 File Offset: 0x0017DE78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174814, RefRangeEnd = 174816, XrefRangeStart = 174802, XrefRangeEnd = 174814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCrimeOnRecord(Type crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x0017FCC8 File Offset: 0x0017DEC8
		[CallerCount(0)]
		public unsafe void SetEvaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x0017FCFC File Offset: 0x0017DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174816, XrefRangeEnd = 174820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x0017FD30 File Offset: 0x0017DF30
		[CallerCount(0)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x0017FD64 File Offset: 0x0017DF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174820, XrefRangeEnd = 174839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x0017FD98 File Offset: 0x0017DF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174839, XrefRangeEnd = 174845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateMusic_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x0017FDCC File Offset: 0x0017DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174845, XrefRangeEnd = 174859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeoutPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x0017FE00 File Offset: 0x0017E000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174859, RefRangeEnd = 174862, XrefRangeStart = 174859, XrefRangeEnd = 174859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x0017FE3C File Offset: 0x0017E03C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174862, RefRangeEnd = 174863, XrefRangeStart = 174862, XrefRangeEnd = 174862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetShotAccuracy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x0017FE70 File Offset: 0x0017E070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174903, RefRangeEnd = 174904, XrefRangeStart = 174863, XrefRangeEnd = 174903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShotAccuracyMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x0017FEAC File Offset: 0x0017E0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174915, RefRangeEnd = 174916, XrefRangeStart = 174904, XrefRangeEnd = 174915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVehicleCollision(NPC victim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x0017FEF0 File Offset: 0x0017E0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174916, XrefRangeEnd = 174937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNearestOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x0017FF24 File Offset: 0x0017E124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174937, XrefRangeEnd = 174961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCrimeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x0017FF60 File Offset: 0x0017E160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174961, XrefRangeEnd = 174962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__53_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x0017FF94 File Offset: 0x0017E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174962, XrefRangeEnd = 174967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _CheckNearestOfficer_b__79_0(PoliceOfficer x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x0017FFE4 File Offset: 0x0017E1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174967, XrefRangeEnd = 175012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00180020 File Offset: 0x0017E220
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x0018005C File Offset: 0x0017E25C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x00180098 File Offset: 0x0017E298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175012, XrefRangeEnd = 175041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x001800D8 File Offset: 0x0017E2D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175048, RefRangeEnd = 175050, XrefRangeStart = 175041, XrefRangeEnd = 175048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00180118 File Offset: 0x0017E318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175050, XrefRangeEnd = 175055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x0018017C File Offset: 0x0017E37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175086, RefRangeEnd = 175088, XrefRangeStart = 175055, XrefRangeEnd = 175086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x001801BC File Offset: 0x0017E3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175095, RefRangeEnd = 175096, XrefRangeStart = 175088, XrefRangeEnd = 175095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x001801FC File Offset: 0x0017E3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175096, XrefRangeEnd = 175103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00180260 File Offset: 0x0017E460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175103, XrefRangeEnd = 175122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x001802A0 File Offset: 0x0017E4A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175131, RefRangeEnd = 175134, XrefRangeStart = 175122, XrefRangeEnd = 175131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x001802E0 File Offset: 0x0017E4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175134, XrefRangeEnd = 175137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600505C RID: 20572 RVA: 0x00180330 File Offset: 0x0017E530
		// (set) Token: 0x0600505D RID: 20573 RVA: 0x0018036C File Offset: 0x0017E56C
		public unsafe PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60909, RefRangeEnd = 60949, XrefRangeStart = 60909, XrefRangeEnd = 60949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175145, RefRangeEnd = 175146, XrefRangeStart = 175137, XrefRangeEnd = 175145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x001803B8 File Offset: 0x0017E5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175146, XrefRangeEnd = 175151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600505F RID: 20575 RVA: 0x0018042C File Offset: 0x0017E62C
		// (set) Token: 0x06005060 RID: 20576 RVA: 0x00180468 File Offset: 0x0017E668
		public unsafe Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 174447, RefRangeEnd = 174458, XrefRangeStart = 174447, XrefRangeEnd = 174458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175151, XrefRangeEnd = 175159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x001804B4 File Offset: 0x0017E6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175224, RefRangeEnd = 175225, XrefRangeStart = 175159, XrefRangeEnd = 175224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00026215 File Offset: 0x00024415
		public PlayerCrimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x001804E8 File Offset: 0x0017E6E8
		// (set) Token: 0x06005064 RID: 20580 RVA: 0x0002621E File Offset: 0x0002441E
		public unsafe static float SEARCH_TIME_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06005065 RID: 20581 RVA: 0x00180504 File Offset: 0x0017E704
		// (set) Token: 0x06005066 RID: 20582 RVA: 0x0002622C File Offset: 0x0002442C
		public unsafe static float SEARCH_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x00180520 File Offset: 0x0017E720
		// (set) Token: 0x06005068 RID: 20584 RVA: 0x0002623A File Offset: 0x0002443A
		public unsafe static float SEARCH_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06005069 RID: 20585 RVA: 0x0018053C File Offset: 0x0017E73C
		// (set) Token: 0x0600506A RID: 20586 RVA: 0x00026248 File Offset: 0x00024448
		public unsafe static float SEARCH_TIME_LETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&value));
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600506B RID: 20587 RVA: 0x00180558 File Offset: 0x0017E758
		// (set) Token: 0x0600506C RID: 20588 RVA: 0x00026256 File Offset: 0x00024456
		public unsafe static float ESCALATION_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600506D RID: 20589 RVA: 0x00180574 File Offset: 0x0017E774
		// (set) Token: 0x0600506E RID: 20590 RVA: 0x00026264 File Offset: 0x00024464
		public unsafe static float ESCALATION_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600506F RID: 20591 RVA: 0x00180590 File Offset: 0x0017E790
		// (set) Token: 0x06005070 RID: 20592 RVA: 0x00026272 File Offset: 0x00024472
		public unsafe static float SHOT_COOLDOWN_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06005071 RID: 20593 RVA: 0x001805AC File Offset: 0x0017E7AC
		// (set) Token: 0x06005072 RID: 20594 RVA: 0x00026280 File Offset: 0x00024480
		public unsafe static float SHOT_COOLDOWN_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06005073 RID: 20595 RVA: 0x001805C8 File Offset: 0x0017E7C8
		// (set) Token: 0x06005074 RID: 20596 RVA: 0x0002628E File Offset: 0x0002448E
		public unsafe static float VEHICLE_COLLISION_LIFETIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&value));
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x001805E4 File Offset: 0x0017E7E4
		// (set) Token: 0x06005076 RID: 20598 RVA: 0x0002629C File Offset: 0x0002449C
		public unsafe static float VEHICLE_COLLISION_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x00180600 File Offset: 0x0017E800
		// (set) Token: 0x06005078 RID: 20600 RVA: 0x000262AA File Offset: 0x000244AA
		public unsafe PoliceOfficer NearestOfficer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06005079 RID: 20601 RVA: 0x00180630 File Offset: 0x0017E830
		// (set) Token: 0x0600507A RID: 20602 RVA: 0x000262C9 File Offset: 0x000244C9
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x0600507B RID: 20603 RVA: 0x00180660 File Offset: 0x0017E860
		// (set) Token: 0x0600507C RID: 20604 RVA: 0x000262E8 File Offset: 0x000244E8
		public unsafe AudioSourceController onPursuitEscapedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x00180690 File Offset: 0x0017E890
		// (set) Token: 0x0600507E RID: 20606 RVA: 0x00026307 File Offset: 0x00024507
		public unsafe PlayerCrimeData.EPursuitLevel _CurrentPursuitLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x001806B8 File Offset: 0x0017E8B8
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x00026322 File Offset: 0x00024522
		public unsafe Vector3 _LastKnownPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x001806E0 File Offset: 0x0017E8E0
		// (set) Token: 0x06005082 RID: 20610 RVA: 0x0002633D File Offset: 0x0002453D
		public unsafe List<PoliceOfficer> Pursuers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x00180710 File Offset: 0x0017E910
		// (set) Token: 0x06005084 RID: 20612 RVA: 0x0002635C File Offset: 0x0002455C
		public unsafe float _CurrentArrestProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x00180738 File Offset: 0x0017E938
		// (set) Token: 0x06005086 RID: 20614 RVA: 0x00026377 File Offset: 0x00024577
		public unsafe float _CurrentBodySearchProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x00180760 File Offset: 0x0017E960
		// (set) Token: 0x06005088 RID: 20616 RVA: 0x00026392 File Offset: 0x00024592
		public unsafe float TimeSincePursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart)) = value;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06005089 RID: 20617 RVA: 0x00180788 File Offset: 0x0017E988
		// (set) Token: 0x0600508A RID: 20618 RVA: 0x000263AD File Offset: 0x000245AD
		public unsafe float CurrentPursuitLevelDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x001807B0 File Offset: 0x0017E9B0
		// (set) Token: 0x0600508C RID: 20620 RVA: 0x000263C8 File Offset: 0x000245C8
		public unsafe float TimeSinceSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted)) = value;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x001807D8 File Offset: 0x0017E9D8
		// (set) Token: 0x0600508E RID: 20622 RVA: 0x000263E3 File Offset: 0x000245E3
		public unsafe Dictionary<Crime, int> Crimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x00180808 File Offset: 0x0017EA08
		// (set) Token: 0x06005090 RID: 20624 RVA: 0x00026402 File Offset: 0x00024602
		public unsafe bool BodySearchPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending)) = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06005091 RID: 20625 RVA: 0x00180830 File Offset: 0x0017EA30
		// (set) Token: 0x06005092 RID: 20626 RVA: 0x0002641D File Offset: 0x0002461D
		public unsafe float _TimeSinceLastBodySearch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField)) = value;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x00180858 File Offset: 0x0017EA58
		// (set) Token: 0x06005094 RID: 20628 RVA: 0x00026438 File Offset: 0x00024638
		public unsafe bool _EvadedArrest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField)) = value;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06005095 RID: 20629 RVA: 0x00180880 File Offset: 0x0017EA80
		// (set) Token: 0x06005096 RID: 20630 RVA: 0x00026453 File Offset: 0x00024653
		public unsafe float timeSinceLastShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x001808A8 File Offset: 0x0017EAA8
		// (set) Token: 0x06005098 RID: 20632 RVA: 0x0002646E File Offset: 0x0002466E
		public unsafe List<PlayerCrimeData.VehicleCollisionInstance> Collisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerCrimeData.VehicleCollisionInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06005099 RID: 20633 RVA: 0x001808D8 File Offset: 0x0017EAD8
		// (set) Token: 0x0600509A RID: 20634 RVA: 0x0002648D File Offset: 0x0002468D
		public unsafe MusicTrack _lightCombatTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x0600509B RID: 20635 RVA: 0x00180908 File Offset: 0x0017EB08
		// (set) Token: 0x0600509C RID: 20636 RVA: 0x000264AC File Offset: 0x000246AC
		public unsafe MusicTrack _heavyCombatTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x00180938 File Offset: 0x0017EB38
		// (set) Token: 0x0600509E RID: 20638 RVA: 0x000264CB File Offset: 0x000246CB
		public unsafe float outOfSightTimeToDipMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic)) = value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x00180960 File Offset: 0x0017EB60
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x000264E6 File Offset: 0x000246E6
		public unsafe float minMusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume)) = value;
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x060050A1 RID: 20641 RVA: 0x00180988 File Offset: 0x0017EB88
		// (set) Token: 0x060050A2 RID: 20642 RVA: 0x00026501 File Offset: 0x00024701
		public unsafe float musicChangeRate_Down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down)) = value;
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x001809B0 File Offset: 0x0017EBB0
		// (set) Token: 0x060050A4 RID: 20644 RVA: 0x0002651C File Offset: 0x0002471C
		public unsafe float musicChangeRate_Up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up)) = value;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x001809D8 File Offset: 0x0017EBD8
		// (set) Token: 0x060050A6 RID: 20646 RVA: 0x00026537 File Offset: 0x00024737
		public unsafe SyncVar<PlayerCrimeData.EPursuitLevel> syncVar____CurrentPursuitLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<PlayerCrimeData.EPursuitLevel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x00180A08 File Offset: 0x0017EC08
		// (set) Token: 0x060050A8 RID: 20648 RVA: 0x00026556 File Offset: 0x00024756
		public unsafe SyncVar<Vector3> syncVar____LastKnownPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00180A38 File Offset: 0x0017EC38
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00026575 File Offset: 0x00024775
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x00180A60 File Offset: 0x0017EC60
		// (set) Token: 0x060050AC RID: 20652 RVA: 0x00026590 File Offset: 0x00024790
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003660 RID: 13920
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING;

		// Token: 0x04003661 RID: 13921
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_ARRESTING;

		// Token: 0x04003662 RID: 13922
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL;

		// Token: 0x04003663 RID: 13923
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_LETHAL;

		// Token: 0x04003664 RID: 13924
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING;

		// Token: 0x04003665 RID: 13925
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL;

		// Token: 0x04003666 RID: 13926
		private static readonly IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MIN;

		// Token: 0x04003667 RID: 13927
		private static readonly IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MAX;

		// Token: 0x04003668 RID: 13928
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME;

		// Token: 0x04003669 RID: 13929
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT;

		// Token: 0x0400366A RID: 13930
		private static readonly IntPtr NativeFieldInfoPtr_NearestOfficer;

		// Token: 0x0400366B RID: 13931
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x0400366C RID: 13932
		private static readonly IntPtr NativeFieldInfoPtr_onPursuitEscapedSound;

		// Token: 0x0400366D RID: 13933
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField;

		// Token: 0x0400366E RID: 13934
		private static readonly IntPtr NativeFieldInfoPtr__LastKnownPosition_k__BackingField;

		// Token: 0x0400366F RID: 13935
		private static readonly IntPtr NativeFieldInfoPtr_Pursuers;

		// Token: 0x04003670 RID: 13936
		private static readonly IntPtr NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField;

		// Token: 0x04003671 RID: 13937
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField;

		// Token: 0x04003672 RID: 13938
		private static readonly IntPtr NativeFieldInfoPtr_TimeSincePursuitStart;

		// Token: 0x04003673 RID: 13939
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPursuitLevelDuration;

		// Token: 0x04003674 RID: 13940
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSighted;

		// Token: 0x04003675 RID: 13941
		private static readonly IntPtr NativeFieldInfoPtr_Crimes;

		// Token: 0x04003676 RID: 13942
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchPending;

		// Token: 0x04003677 RID: 13943
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField;

		// Token: 0x04003678 RID: 13944
		private static readonly IntPtr NativeFieldInfoPtr__EvadedArrest_k__BackingField;

		// Token: 0x04003679 RID: 13945
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x0400367A RID: 13946
		private static readonly IntPtr NativeFieldInfoPtr_Collisions;

		// Token: 0x0400367B RID: 13947
		private static readonly IntPtr NativeFieldInfoPtr__lightCombatTrack;

		// Token: 0x0400367C RID: 13948
		private static readonly IntPtr NativeFieldInfoPtr__heavyCombatTrack;

		// Token: 0x0400367D RID: 13949
		private static readonly IntPtr NativeFieldInfoPtr_outOfSightTimeToDipMusic;

		// Token: 0x0400367E RID: 13950
		private static readonly IntPtr NativeFieldInfoPtr_minMusicVolume;

		// Token: 0x0400367F RID: 13951
		private static readonly IntPtr NativeFieldInfoPtr_musicChangeRate_Down;

		// Token: 0x04003680 RID: 13952
		private static readonly IntPtr NativeFieldInfoPtr_musicChangeRate_Up;

		// Token: 0x04003681 RID: 13953
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField;

		// Token: 0x04003682 RID: 13954
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField;

		// Token: 0x04003683 RID: 13955
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003684 RID: 13956
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003685 RID: 13957
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0;

		// Token: 0x04003686 RID: 13958
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0;

		// Token: 0x04003687 RID: 13959
		private static readonly IntPtr NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0;

		// Token: 0x04003688 RID: 13960
		private static readonly IntPtr NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04003689 RID: 13961
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0;

		// Token: 0x0400368A RID: 13962
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0;

		// Token: 0x0400368B RID: 13963
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0;

		// Token: 0x0400368C RID: 13964
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0;

		// Token: 0x0400368D RID: 13965
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0;

		// Token: 0x0400368E RID: 13966
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0;

		// Token: 0x0400368F RID: 13967
		private static readonly IntPtr NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0;

		// Token: 0x04003690 RID: 13968
		private static readonly IntPtr NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0;

		// Token: 0x04003691 RID: 13969
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003692 RID: 13970
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04003693 RID: 13971
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003694 RID: 13972
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003695 RID: 13973
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04003696 RID: 13974
		private static readonly IntPtr NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0;

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Void_0;

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeMethodInfoPtr_Deescalate_Public_Void_0;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0;

		// Token: 0x0400369A RID: 13978
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0;

		// Token: 0x0400369B RID: 13979
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0;

		// Token: 0x0400369C RID: 13980
		private static readonly IntPtr NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0;

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Private_Void_1;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeMethodInfoPtr_ClearCrimes_Public_Void_0;

		// Token: 0x040036A0 RID: 13984
		private static readonly IntPtr NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0;

		// Token: 0x040036A1 RID: 13985
		private static readonly IntPtr NativeMethodInfoPtr_SetEvaded_Public_Void_0;

		// Token: 0x040036A2 RID: 13986
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepStart_Private_Void_1;

		// Token: 0x040036A3 RID: 13987
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_1;

		// Token: 0x040036A4 RID: 13988
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeout_Private_Void_1;

		// Token: 0x040036A5 RID: 13989
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusic_Private_Void_1;

		// Token: 0x040036A6 RID: 13990
		private static readonly IntPtr NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1;

		// Token: 0x040036A7 RID: 13991
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Public_Single_0;

		// Token: 0x040036A8 RID: 13992
		private static readonly IntPtr NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0;

		// Token: 0x040036A9 RID: 13993
		private static readonly IntPtr NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0;

		// Token: 0x040036AA RID: 13994
		private static readonly IntPtr NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0;

		// Token: 0x040036AB RID: 13995
		private static readonly IntPtr NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1;

		// Token: 0x040036AC RID: 13996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036AD RID: 13997
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1;

		// Token: 0x040036AE RID: 13998
		private static readonly IntPtr NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0;

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040036B0 RID: 14000
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040036B1 RID: 14001
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040036B2 RID: 14002
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0;

		// Token: 0x040036B3 RID: 14003
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0;

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0;

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0;

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0;

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0;

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0;

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x0200099D RID: 2461
		public class VehicleCollisionInstance : Il2CppSystem.Object
		{
			// Token: 0x0600CB19 RID: 51993 RVA: 0x00310FB0 File Offset: 0x0030F1B0
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleCollisionInstance()
			{
				Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VehicleCollisionInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr);
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "Victim");
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "TimeSince");
				PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, 100673422);
			}

			// Token: 0x0600CB1A RID: 51994 RVA: 0x00311018 File Offset: 0x0030F218
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70198, RefRangeEnd = 70199, XrefRangeStart = 70198, XrefRangeEnd = 70199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleCollisionInstance(NPC victim, float timeSince) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSince;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB1B RID: 51995 RVA: 0x00062C67 File Offset: 0x00060E67
			public VehicleCollisionInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F48 RID: 16200
			// (get) Token: 0x0600CB1C RID: 51996 RVA: 0x00311074 File Offset: 0x0030F274
			// (set) Token: 0x0600CB1D RID: 51997 RVA: 0x00062C70 File Offset: 0x00060E70
			public unsafe NPC Victim
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F49 RID: 16201
			// (get) Token: 0x0600CB1E RID: 51998 RVA: 0x003110A4 File Offset: 0x0030F2A4
			// (set) Token: 0x0600CB1F RID: 51999 RVA: 0x00062C8F File Offset: 0x00060E8F
			public unsafe float TimeSince
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince)) = value;
				}
			}

			// Token: 0x04008953 RID: 35155
			private static readonly IntPtr NativeFieldInfoPtr_Victim;

			// Token: 0x04008954 RID: 35156
			private static readonly IntPtr NativeFieldInfoPtr_TimeSince;

			// Token: 0x04008955 RID: 35157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0;
		}

		// Token: 0x0200099E RID: 2462
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitLevel")]
		public enum EPursuitLevel
		{
			// Token: 0x04008957 RID: 35159
			None,
			// Token: 0x04008958 RID: 35160
			Investigating,
			// Token: 0x04008959 RID: 35161
			Arresting,
			// Token: 0x0400895A RID: 35162
			NonLethal,
			// Token: 0x0400895B RID: 35163
			Lethal
		}

		// Token: 0x0200099F RID: 2463
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCrimeData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CB20 RID: 52000 RVA: 0x003110CC File Offset: 0x0030F2CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr);
				PlayerCrimeData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9");
				PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9__53_1");
				PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9__53_2");
				PlayerCrimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673424);
				PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673425);
				PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673426);
			}

			// Token: 0x0600CB21 RID: 52001 RVA: 0x00311170 File Offset: 0x0030F370
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB22 RID: 52002 RVA: 0x003111AC File Offset: 0x0030F3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174405, XrefRangeEnd = 174409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__53_1(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB23 RID: 52003 RVA: 0x003111FC File Offset: 0x0030F3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174409, XrefRangeEnd = 174413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__53_2(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB24 RID: 52004 RVA: 0x00062CAA File Offset: 0x00060EAA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4A RID: 16202
			// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x0031124C File Offset: 0x0030F44C
			// (set) Token: 0x0600CB26 RID: 52006 RVA: 0x00062CB3 File Offset: 0x00060EB3
			public unsafe static PlayerCrimeData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCrimeData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F4B RID: 16203
			// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x00311274 File Offset: 0x0030F474
			// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x00062CC5 File Offset: 0x00060EC5
			public unsafe static Predicate<MusicTrack> __9__53_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<MusicTrack>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F4C RID: 16204
			// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x0031129C File Offset: 0x0030F49C
			// (set) Token: 0x0600CB2A RID: 52010 RVA: 0x00062CD7 File Offset: 0x00060ED7
			public unsafe static Predicate<MusicTrack> __9__53_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<MusicTrack>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400895C RID: 35164
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400895D RID: 35165
			private static readonly IntPtr NativeFieldInfoPtr___9__53_1;

			// Token: 0x0400895E RID: 35166
			private static readonly IntPtr NativeFieldInfoPtr___9__53_2;

			// Token: 0x0400895F RID: 35167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008960 RID: 35168
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0;

			// Token: 0x04008961 RID: 35169
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0;
		}
	}
}
