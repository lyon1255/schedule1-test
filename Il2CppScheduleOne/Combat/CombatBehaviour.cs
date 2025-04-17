using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000497 RID: 1175
	public class CombatBehaviour : Il2CppScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x060065A1 RID: 26017 RVA: 0x001CA2E8 File Offset: 0x001C84E8
		// Note: this type is marked as 'beforefieldinit'.
		static CombatBehaviour()
		{
			Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr);
			CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_SPEED");
			CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "REACHED_DESTINATION_DISTANCE");
			CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TimeSinceTargetReacquired>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpRange");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpTime");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpAfterSuccessfulHits");
			CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "PlayAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultMovementSpeed");
			CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultWeapon");
			CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "VirtualPunchWeapon");
			CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultSearchTime");
			CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "overrideTargetDistance");
			CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "targetDistanceOverride");
			CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "isTargetRecentlyVisible");
			CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "isTargetImmediatelyVisible");
			CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "playerSightedDuration");
			CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "lastKnownTargetPosition");
			CombatBehaviour.NativeFieldInfoPtr_currentWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentWeapon");
			CombatBehaviour.NativeFieldInfoPtr_successfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "successfulHits");
			CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			CombatBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "searchRoutine");
			CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "hasSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "nextAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676146);
			CombatBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676147);
			CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676148);
			CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676149);
			CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676150);
			CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676151);
			CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676152);
			CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676153);
			CombatBehaviour.NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676154);
			CombatBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676155);
			CombatBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676156);
			CombatBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676157);
			CombatBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676158);
			CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676159);
			CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676160);
			CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676161);
			CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676162);
			CombatBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676163);
			CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676164);
			CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676165);
			CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676166);
			CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676167);
			CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676168);
			CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676169);
			CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676170);
			CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676171);
			CombatBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676172);
			CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676173);
			CombatBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676174);
			CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676175);
			CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676176);
			CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676177);
			CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676178);
			CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676179);
			CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676180);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676181);
			CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676182);
			CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676183);
			CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676184);
			CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676185);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676186);
			CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676187);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676188);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676189);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676190);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676191);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676192);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676193);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676194);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676195);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676196);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676197);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676198);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676199);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676200);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676201);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676202);
			CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676203);
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x001CAA48 File Offset: 0x001C8C48
		// (set) Token: 0x060065A3 RID: 26019 RVA: 0x001CAA88 File Offset: 0x001C8C88
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x001CAACC File Offset: 0x001C8CCC
		// (set) Token: 0x060065A5 RID: 26021 RVA: 0x001CAB08 File Offset: 0x001C8D08
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x060065A6 RID: 26022 RVA: 0x001CAB48 File Offset: 0x001C8D48
		// (set) Token: 0x060065A7 RID: 26023 RVA: 0x001CAB84 File Offset: 0x001C8D84
		public unsafe float TimeSinceTargetReacquired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x001CABC4 File Offset: 0x001C8DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205960, XrefRangeEnd = 205977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x001CAC00 File Offset: 0x001C8E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205977, XrefRangeEnd = 205982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x001CAC50 File Offset: 0x001C8E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205982, XrefRangeEnd = 205987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x001CACB0 File Offset: 0x001C8EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205987, XrefRangeEnd = 205994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x001CACEC File Offset: 0x001C8EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205994, XrefRangeEnd = 205995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x001CAD28 File Offset: 0x001C8F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205995, XrefRangeEnd = 205997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x001CAD64 File Offset: 0x001C8F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205997, XrefRangeEnd = 205999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x001CADA0 File Offset: 0x001C8FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x001CADDC File Offset: 0x001C8FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205999, XrefRangeEnd = 206024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x001CAE18 File Offset: 0x001C9018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206052, RefRangeEnd = 206054, XrefRangeStart = 206024, XrefRangeEnd = 206052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x001CAE4C File Offset: 0x001C904C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206054, XrefRangeEnd = 206119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x001CAE88 File Offset: 0x001C9088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206119, XrefRangeEnd = 206122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x001CAEC4 File Offset: 0x001C90C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206122, XrefRangeEnd = 206124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x001CAEF8 File Offset: 0x001C90F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206124, XrefRangeEnd = 206131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x001CAF34 File Offset: 0x001C9134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206131, XrefRangeEnd = 206140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMovementSpeed(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x001CAF74 File Offset: 0x001C9174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206140, XrefRangeEnd = 206162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWeapon(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x001CAFC4 File Offset: 0x001C91C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206183, RefRangeEnd = 206185, XrefRangeStart = 206162, XrefRangeEnd = 206183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWeapon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x001CAFF8 File Offset: 0x001C91F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206185, XrefRangeEnd = 206190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadyToAttack(bool checkTarget = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x001CB04C File Offset: 0x001C924C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206190, XrefRangeEnd = 206211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x001CB088 File Offset: 0x001C9288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206211, XrefRangeEnd = 206212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SucessfulHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x001CB0BC File Offset: 0x001C92BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206233, RefRangeEnd = 206235, XrefRangeStart = 206212, XrefRangeEnd = 206233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x001CB0F0 File Offset: 0x001C92F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206235, XrefRangeEnd = 206239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x001CB124 File Offset: 0x001C9324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x001CB160 File Offset: 0x001C9360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206239, XrefRangeEnd = 206247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x001CB1A4 File Offset: 0x001C93A4
		[CallerCount(0)]
		public unsafe virtual float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x001CB1EC File Offset: 0x001C93EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206247, XrefRangeEnd = 206269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x001CB220 File Offset: 0x001C9420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206281, RefRangeEnd = 206283, XrefRangeStart = 206269, XrefRangeEnd = 206281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x001CB254 File Offset: 0x001C9454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206283, XrefRangeEnd = 206288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x001CB294 File Offset: 0x001C9494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206288, XrefRangeEnd = 206301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x001CB2D0 File Offset: 0x001C94D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206301, XrefRangeEnd = 206309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x001CB30C File Offset: 0x001C950C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206309, XrefRangeEnd = 206318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionToTargetRange(Vector3 origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x001CB34C File Offset: 0x001C954C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206337, RefRangeEnd = 206339, XrefRangeStart = 206318, XrefRangeEnd = 206337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x001CB3B4 File Offset: 0x001C95B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206343, RefRangeEnd = 206345, XrefRangeStart = 206339, XrefRangeEnd = 206343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMinTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x001CB3F0 File Offset: 0x001C95F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206349, RefRangeEnd = 206350, XrefRangeStart = 206345, XrefRangeEnd = 206349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMaxTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x001CB42C File Offset: 0x001C962C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206350, XrefRangeEnd = 206359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetInRange(Vector3 origin = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x001CB478 File Offset: 0x001C9678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206359, XrefRangeEnd = 206364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x001CB4B4 File Offset: 0x001C96B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206364, XrefRangeEnd = 206390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x001CB4F0 File Offset: 0x001C96F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206390, XrefRangeEnd = 206391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x001CB52C File Offset: 0x001C972C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x001CB568 File Offset: 0x001C9768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206420, RefRangeEnd = 206421, XrefRangeStart = 206391, XrefRangeEnd = 206420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x001CB5BC File Offset: 0x001C97BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206421, XrefRangeEnd = 206425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x001CB61C File Offset: 0x001C981C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206425, XrefRangeEnd = 206433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x001CB66C File Offset: 0x001C986C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206433, XrefRangeEnd = 206452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x001CB6B0 File Offset: 0x001C98B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206491, RefRangeEnd = 206493, XrefRangeStart = 206452, XrefRangeEnd = 206491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x001CB700 File Offset: 0x001C9900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206493, XrefRangeEnd = 206497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x001CB750 File Offset: 0x001C9950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206497, XrefRangeEnd = 206515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x001CB784 File Offset: 0x001C9984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206536, RefRangeEnd = 206538, XrefRangeStart = 206515, XrefRangeEnd = 206536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x001CB7B8 File Offset: 0x001C99B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206538, XrefRangeEnd = 206541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x001CB808 File Offset: 0x001C9A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206541, XrefRangeEnd = 206559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x001CB83C File Offset: 0x001C9A3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206563, RefRangeEnd = 206565, XrefRangeStart = 206559, XrefRangeEnd = 206563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x001CB878 File Offset: 0x001C9A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206565, XrefRangeEnd = 206568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x001CB8C8 File Offset: 0x001C9AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206568, XrefRangeEnd = 206585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x0003016E File Offset: 0x0002E36E
		public CombatBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060065DD RID: 26077 RVA: 0x001CB904 File Offset: 0x001C9B04
		// (set) Token: 0x060065DE RID: 26078 RVA: 0x00030177 File Offset: 0x0002E377
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x001CB920 File Offset: 0x001C9B20
		// (set) Token: 0x060065E0 RID: 26080 RVA: 0x00030185 File Offset: 0x0002E385
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060065E1 RID: 26081 RVA: 0x001CB93C File Offset: 0x001C9B3C
		// (set) Token: 0x060065E2 RID: 26082 RVA: 0x00030193 File Offset: 0x0002E393
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060065E3 RID: 26083 RVA: 0x001CB958 File Offset: 0x001C9B58
		// (set) Token: 0x060065E4 RID: 26084 RVA: 0x000301A1 File Offset: 0x0002E3A1
		public unsafe static float SEARCH_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x060065E5 RID: 26085 RVA: 0x001CB974 File Offset: 0x001C9B74
		// (set) Token: 0x060065E6 RID: 26086 RVA: 0x000301AF File Offset: 0x0002E3AF
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x060065E7 RID: 26087 RVA: 0x001CB990 File Offset: 0x001C9B90
		// (set) Token: 0x060065E8 RID: 26088 RVA: 0x000301BD File Offset: 0x0002E3BD
		public unsafe static float REACHED_DESTINATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x060065E9 RID: 26089 RVA: 0x001CB9AC File Offset: 0x001C9BAC
		// (set) Token: 0x060065EA RID: 26090 RVA: 0x000301CB File Offset: 0x0002E3CB
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x001CB9DC File Offset: 0x001C9BDC
		// (set) Token: 0x060065EC RID: 26092 RVA: 0x000301EA File Offset: 0x0002E3EA
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x060065ED RID: 26093 RVA: 0x001CBA04 File Offset: 0x001C9C04
		// (set) Token: 0x060065EE RID: 26094 RVA: 0x00030205 File Offset: 0x0002E405
		public unsafe float _TimeSinceTargetReacquired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x060065EF RID: 26095 RVA: 0x001CBA2C File Offset: 0x001C9C2C
		// (set) Token: 0x060065F0 RID: 26096 RVA: 0x00030220 File Offset: 0x0002E420
		public unsafe float GiveUpRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange)) = value;
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x001CBA54 File Offset: 0x001C9C54
		// (set) Token: 0x060065F2 RID: 26098 RVA: 0x0003023B File Offset: 0x0002E43B
		public unsafe float GiveUpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpTime)) = value;
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060065F3 RID: 26099 RVA: 0x001CBA7C File Offset: 0x001C9C7C
		// (set) Token: 0x060065F4 RID: 26100 RVA: 0x00030256 File Offset: 0x0002E456
		public unsafe int GiveUpAfterSuccessfulHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits)) = value;
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x060065F5 RID: 26101 RVA: 0x001CBAA4 File Offset: 0x001C9CA4
		// (set) Token: 0x060065F6 RID: 26102 RVA: 0x00030271 File Offset: 0x0002E471
		public unsafe bool PlayAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO)) = value;
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x060065F7 RID: 26103 RVA: 0x001CBACC File Offset: 0x001C9CCC
		// (set) Token: 0x060065F8 RID: 26104 RVA: 0x0003028C File Offset: 0x0002E48C
		public unsafe float DefaultMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed)) = value;
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x001CBAF4 File Offset: 0x001C9CF4
		// (set) Token: 0x060065FA RID: 26106 RVA: 0x000302A7 File Offset: 0x0002E4A7
		public unsafe AvatarWeapon DefaultWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x060065FB RID: 26107 RVA: 0x001CBB24 File Offset: 0x001C9D24
		// (set) Token: 0x060065FC RID: 26108 RVA: 0x000302C6 File Offset: 0x0002E4C6
		public unsafe AvatarMeleeWeapon VirtualPunchWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x001CBB54 File Offset: 0x001C9D54
		// (set) Token: 0x060065FE RID: 26110 RVA: 0x000302E5 File Offset: 0x0002E4E5
		public unsafe float DefaultSearchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime)) = value;
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x001CBB7C File Offset: 0x001C9D7C
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x00030300 File Offset: 0x0002E500
		public unsafe bool overrideTargetDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance)) = value;
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x001CBBA4 File Offset: 0x001C9DA4
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x0003031B File Offset: 0x0002E51B
		public unsafe float targetDistanceOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride)) = value;
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06006603 RID: 26115 RVA: 0x001CBBCC File Offset: 0x001C9DCC
		// (set) Token: 0x06006604 RID: 26116 RVA: 0x00030336 File Offset: 0x0002E536
		public unsafe bool isTargetRecentlyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible)) = value;
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06006605 RID: 26117 RVA: 0x001CBBF4 File Offset: 0x001C9DF4
		// (set) Token: 0x06006606 RID: 26118 RVA: 0x00030351 File Offset: 0x0002E551
		public unsafe bool isTargetImmediatelyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible)) = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06006607 RID: 26119 RVA: 0x001CBC1C File Offset: 0x001C9E1C
		// (set) Token: 0x06006608 RID: 26120 RVA: 0x0003036C File Offset: 0x0002E56C
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06006609 RID: 26121 RVA: 0x001CBC44 File Offset: 0x001C9E44
		// (set) Token: 0x0600660A RID: 26122 RVA: 0x00030387 File Offset: 0x0002E587
		public unsafe float playerSightedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x001CBC6C File Offset: 0x001C9E6C
		// (set) Token: 0x0600660C RID: 26124 RVA: 0x000303A2 File Offset: 0x0002E5A2
		public unsafe Vector3 lastKnownTargetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition)) = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x0600660D RID: 26125 RVA: 0x001CBC94 File Offset: 0x001C9E94
		// (set) Token: 0x0600660E RID: 26126 RVA: 0x000303BD File Offset: 0x0002E5BD
		public unsafe AvatarWeapon currentWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x001CBCC4 File Offset: 0x001C9EC4
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x000303DC File Offset: 0x0002E5DC
		public unsafe int successfulHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits)) = value;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x001CBCEC File Offset: 0x001C9EEC
		// (set) Token: 0x06006612 RID: 26130 RVA: 0x000303F7 File Offset: 0x0002E5F7
		public unsafe int consecutiveMissedShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x001CBD14 File Offset: 0x001C9F14
		// (set) Token: 0x06006614 RID: 26132 RVA: 0x00030412 File Offset: 0x0002E612
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x001CBD44 File Offset: 0x001C9F44
		// (set) Token: 0x06006616 RID: 26134 RVA: 0x00030431 File Offset: 0x0002E631
		public unsafe Coroutine searchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x001CBD74 File Offset: 0x001C9F74
		// (set) Token: 0x06006618 RID: 26136 RVA: 0x00030450 File Offset: 0x0002E650
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06006619 RID: 26137 RVA: 0x001CBD9C File Offset: 0x001C9F9C
		// (set) Token: 0x0600661A RID: 26138 RVA: 0x0003046B File Offset: 0x0002E66B
		public unsafe bool hasSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600661B RID: 26139 RVA: 0x001CBDC4 File Offset: 0x001C9FC4
		// (set) Token: 0x0600661C RID: 26140 RVA: 0x00030486 File Offset: 0x0002E686
		public unsafe float nextAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x0600661D RID: 26141 RVA: 0x001CBDEC File Offset: 0x001C9FEC
		// (set) Token: 0x0600661E RID: 26142 RVA: 0x000304A1 File Offset: 0x0002E6A1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600661F RID: 26143 RVA: 0x001CBE14 File Offset: 0x001CA014
		// (set) Token: 0x06006620 RID: 26144 RVA: 0x000304BC File Offset: 0x0002E6BC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004559 RID: 17753
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x0400455A RID: 17754
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x0400455B RID: 17755
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x0400455C RID: 17756
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_SPEED;

		// Token: 0x0400455D RID: 17757
		private static readonly IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x0400455E RID: 17758
		private static readonly IntPtr NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE;

		// Token: 0x0400455F RID: 17759
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04004560 RID: 17760
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04004561 RID: 17761
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField;

		// Token: 0x04004562 RID: 17762
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpRange;

		// Token: 0x04004563 RID: 17763
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpTime;

		// Token: 0x04004564 RID: 17764
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpAfterSuccessfulHits;

		// Token: 0x04004565 RID: 17765
		private static readonly IntPtr NativeFieldInfoPtr_PlayAngryVO;

		// Token: 0x04004566 RID: 17766
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMovementSpeed;

		// Token: 0x04004567 RID: 17767
		private static readonly IntPtr NativeFieldInfoPtr_DefaultWeapon;

		// Token: 0x04004568 RID: 17768
		private static readonly IntPtr NativeFieldInfoPtr_VirtualPunchWeapon;

		// Token: 0x04004569 RID: 17769
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSearchTime;

		// Token: 0x0400456A RID: 17770
		private static readonly IntPtr NativeFieldInfoPtr_overrideTargetDistance;

		// Token: 0x0400456B RID: 17771
		private static readonly IntPtr NativeFieldInfoPtr_targetDistanceOverride;

		// Token: 0x0400456C RID: 17772
		private static readonly IntPtr NativeFieldInfoPtr_isTargetRecentlyVisible;

		// Token: 0x0400456D RID: 17773
		private static readonly IntPtr NativeFieldInfoPtr_isTargetImmediatelyVisible;

		// Token: 0x0400456E RID: 17774
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x0400456F RID: 17775
		private static readonly IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x04004570 RID: 17776
		private static readonly IntPtr NativeFieldInfoPtr_lastKnownTargetPosition;

		// Token: 0x04004571 RID: 17777
		private static readonly IntPtr NativeFieldInfoPtr_currentWeapon;

		// Token: 0x04004572 RID: 17778
		private static readonly IntPtr NativeFieldInfoPtr_successfulHits;

		// Token: 0x04004573 RID: 17779
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x04004574 RID: 17780
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x04004575 RID: 17781
		private static readonly IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x04004576 RID: 17782
		private static readonly IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x04004577 RID: 17783
		private static readonly IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x04004578 RID: 17784
		private static readonly IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x04004579 RID: 17785
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400457A RID: 17786
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400457B RID: 17787
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x0400457C RID: 17788
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x0400457D RID: 17789
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x0400457E RID: 17790
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x0400457F RID: 17791
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0;

		// Token: 0x04004580 RID: 17792
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0;

		// Token: 0x04004581 RID: 17793
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004582 RID: 17794
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004583 RID: 17795
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04004584 RID: 17796
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04004585 RID: 17797
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04004586 RID: 17798
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04004587 RID: 17799
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04004588 RID: 17800
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04004589 RID: 17801
		private static readonly IntPtr NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0;

		// Token: 0x0400458A RID: 17802
		private static readonly IntPtr NativeMethodInfoPtr_EndCombat_Protected_Void_0;

		// Token: 0x0400458B RID: 17803
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x0400458C RID: 17804
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400458D RID: 17805
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0;

		// Token: 0x0400458E RID: 17806
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x0400458F RID: 17807
		private static readonly IntPtr NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0;

		// Token: 0x04004590 RID: 17808
		private static readonly IntPtr NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0;

		// Token: 0x04004591 RID: 17809
		private static readonly IntPtr NativeMethodInfoPtr_ClearWeapon_Protected_Void_0;

		// Token: 0x04004592 RID: 17810
		private static readonly IntPtr NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04004593 RID: 17811
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0;

		// Token: 0x04004594 RID: 17812
		private static readonly IntPtr NativeMethodInfoPtr_SucessfulHit_Protected_Void_0;

		// Token: 0x04004595 RID: 17813
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0;

		// Token: 0x04004596 RID: 17814
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x04004597 RID: 17815
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0;

		// Token: 0x04004598 RID: 17816
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04004599 RID: 17817
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0;

		// Token: 0x0400459A RID: 17818
		private static readonly IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x0400459B RID: 17819
		private static readonly IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x0400459C RID: 17820
		private static readonly IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x0400459D RID: 17821
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x0400459E RID: 17822
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0;

		// Token: 0x0400459F RID: 17823
		private static readonly IntPtr NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0;

		// Token: 0x040045A0 RID: 17824
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0;

		// Token: 0x040045A1 RID: 17825
		private static readonly IntPtr NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0;

		// Token: 0x040045A2 RID: 17826
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0;

		// Token: 0x040045A3 RID: 17827
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0;

		// Token: 0x040045A4 RID: 17828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045A5 RID: 17829
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045A6 RID: 17830
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045A7 RID: 17831
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045A8 RID: 17832
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040045A9 RID: 17833
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040045AA RID: 17834
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045AB RID: 17835
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0;

		// Token: 0x040045AC RID: 17836
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0;

		// Token: 0x040045AD RID: 17837
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045AE RID: 17838
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0;

		// Token: 0x040045AF RID: 17839
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0;

		// Token: 0x040045B0 RID: 17840
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045B1 RID: 17841
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0;

		// Token: 0x040045B2 RID: 17842
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040045B3 RID: 17843
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045B4 RID: 17844
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A30 RID: 2608
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<SearchRoutine>d__68")]
		public sealed class _SearchRoutine_d__68 : Il2CppSystem.Object
		{
			// Token: 0x0600CF70 RID: 53104 RVA: 0x0031D270 File Offset: 0x0031B470
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__68()
			{
				Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<SearchRoutine>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr);
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>1__state");
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>2__current");
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>4__this");
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676204);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676205);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676206);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676207);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676208);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676209);
			}

			// Token: 0x0600CF71 RID: 53105 RVA: 0x0031D350 File Offset: 0x0031B550
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__68(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF72 RID: 53106 RVA: 0x0031D398 File Offset: 0x0031B598
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF73 RID: 53107 RVA: 0x0031D3CC File Offset: 0x0031B5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205954, XrefRangeEnd = 205955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700407A RID: 16506
			// (get) Token: 0x0600CF74 RID: 53108 RVA: 0x0031D408 File Offset: 0x0031B608
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF75 RID: 53109 RVA: 0x0031D448 File Offset: 0x0031B648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205955, XrefRangeEnd = 205960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700407B RID: 16507
			// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x0031D47C File Offset: 0x0031B67C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF77 RID: 53111 RVA: 0x00064EE5 File Offset: 0x000630E5
			public _SearchRoutine_d__68(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004077 RID: 16503
			// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x0031D4BC File Offset: 0x0031B6BC
			// (set) Token: 0x0600CF79 RID: 53113 RVA: 0x00064EEE File Offset: 0x000630EE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004078 RID: 16504
			// (get) Token: 0x0600CF7A RID: 53114 RVA: 0x0031D4E4 File Offset: 0x0031B6E4
			// (set) Token: 0x0600CF7B RID: 53115 RVA: 0x00064F09 File Offset: 0x00063109
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004079 RID: 16505
			// (get) Token: 0x0600CF7C RID: 53116 RVA: 0x0031D514 File Offset: 0x0031B714
			// (set) Token: 0x0600CF7D RID: 53117 RVA: 0x00064F28 File Offset: 0x00063128
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BE9 RID: 35817
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BEA RID: 35818
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BEB RID: 35819
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BEC RID: 35820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BED RID: 35821
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BEE RID: 35822
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BEF RID: 35823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BF0 RID: 35824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BF1 RID: 35825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
