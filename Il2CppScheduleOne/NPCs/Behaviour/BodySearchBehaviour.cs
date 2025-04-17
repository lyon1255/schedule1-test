using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Product.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000341 RID: 833
	public class BodySearchBehaviour : Behaviour
	{
		// Token: 0x06003D97 RID: 15767 RVA: 0x0013940C File Offset: 0x0013760C
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchBehaviour()
		{
			Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "BodySearchBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr);
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_STEALTH_LEVEL");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_SEARCH_TIME");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_TIME_OUTSIDE_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "RANGE_TO_ESCALATE");
			BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MOVE_SPEED");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_COOLDOWN");
			BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ShowPostSearchDialogue");
			BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MaxStealthLevel");
			BodySearchBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "officer");
			BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "targetDistanceOnStart");
			BodySearchBehaviour.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "searchTime");
			BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "hasBeenInRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeOutsideRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeWithinSearchRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeSinceCantReach");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_Clear");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_ItemsFound");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670509);
			BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670510);
			BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670511);
			BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670512);
			BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670513);
			BodySearchBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670514);
			BodySearchBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670515);
			BodySearchBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670516);
			BodySearchBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670517);
			BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670518);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670519);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670520);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670521);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670522);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670523);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670524);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670525);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670526);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670527);
			BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670528);
			BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670529);
			BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670530);
			BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670531);
			BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670532);
			BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670533);
			BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670534);
			BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670535);
			BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670536);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670537);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670538);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670539);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670540);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670541);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670542);
			BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670543);
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x001398C4 File Offset: 0x00137AC4
		public unsafe static float BODY_SEARCH_TIME
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145097, XrefRangeEnd = 145102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003D99 RID: 15769 RVA: 0x001398F4 File Offset: 0x00137AF4
		// (set) Token: 0x06003D9A RID: 15770 RVA: 0x00139934 File Offset: 0x00137B34
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x00139978 File Offset: 0x00137B78
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x001399B8 File Offset: 0x00137BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145102, XrefRangeEnd = 145111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x001399F4 File Offset: 0x00137BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145111, XrefRangeEnd = 145144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00139A30 File Offset: 0x00137C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145144, XrefRangeEnd = 145161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00139A6C File Offset: 0x00137C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145161, XrefRangeEnd = 145174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00139AA8 File Offset: 0x00137CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145174, XrefRangeEnd = 145183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00139AE4 File Offset: 0x00137CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145183, XrefRangeEnd = 145195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00139B20 File Offset: 0x00137D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145243, RefRangeEnd = 145244, XrefRangeStart = 145195, XrefRangeEnd = 145243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00139B54 File Offset: 0x00137D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145244, XrefRangeEnd = 145266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00139B90 File Offset: 0x00137D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145266, XrefRangeEnd = 145287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchClean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00139BC4 File Offset: 0x00137DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145287, XrefRangeEnd = 145308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchFail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00139BF8 File Offset: 0x00137DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145330, RefRangeEnd = 145331, XrefRangeStart = 145308, XrefRangeEnd = 145330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00139C2C File Offset: 0x00137E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145331, XrefRangeEnd = 145338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00139C68 File Offset: 0x00137E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145338, XrefRangeEnd = 145362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00139CA4 File Offset: 0x00137EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145362, XrefRangeEnd = 145364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00139CE4 File Offset: 0x00137EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145364, XrefRangeEnd = 145365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00139D24 File Offset: 0x00137F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145377, RefRangeEnd = 145378, XrefRangeStart = 145365, XrefRangeEnd = 145377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00139D60 File Offset: 0x00137F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145385, RefRangeEnd = 145387, XrefRangeStart = 145378, XrefRangeEnd = 145385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00139D94 File Offset: 0x00137F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145387, XrefRangeEnd = 145392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00139DE4 File Offset: 0x00137FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145392, XrefRangeEnd = 145394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00139E44 File Offset: 0x00138044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145394, XrefRangeEnd = 145421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesPlayerContainItemsOfInterest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00139E8C File Offset: 0x0013808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145421, XrefRangeEnd = 145473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConcludeSearch(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00139ED8 File Offset: 0x001380D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145473, XrefRangeEnd = 145492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00139F14 File Offset: 0x00138114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145492, XrefRangeEnd = 145496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoItemsOfInterestFound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00139F50 File Offset: 0x00138150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145496, XrefRangeEnd = 145497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00139F8C File Offset: 0x0013818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145497, XrefRangeEnd = 145505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00139FC8 File Offset: 0x001381C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145505, XrefRangeEnd = 145506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x0013A004 File Offset: 0x00138204
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x0013A040 File Offset: 0x00138240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145535, RefRangeEnd = 145536, XrefRangeStart = 145506, XrefRangeEnd = 145535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x0013A094 File Offset: 0x00138294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145548, RefRangeEnd = 145550, XrefRangeStart = 145536, XrefRangeEnd = 145548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x0013A0F4 File Offset: 0x001382F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145550, XrefRangeEnd = 145555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x0013A144 File Offset: 0x00138344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145555, XrefRangeEnd = 145564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x0001F056 File Offset: 0x0001D256
		public BodySearchBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x0013A180 File Offset: 0x00138380
		// (set) Token: 0x06003DBD RID: 15805 RVA: 0x0001F05F File Offset: 0x0001D25F
		public unsafe static EStealthLevel MAX_STEALTH_LEVEL
		{
			get
			{
				EStealthLevel result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&value));
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x0013A19C File Offset: 0x0013839C
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x0001F06D File Offset: 0x0001D26D
		public unsafe static float BODY_SEARCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x0013A1B8 File Offset: 0x001383B8
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x0001F07B File Offset: 0x0001D27B
		public unsafe static float MAX_SEARCH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x0013A1D4 File Offset: 0x001383D4
		// (set) Token: 0x06003DC3 RID: 15811 RVA: 0x0001F089 File Offset: 0x0001D289
		public unsafe static float MAX_TIME_OUTSIDE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06003DC4 RID: 15812 RVA: 0x0013A1F0 File Offset: 0x001383F0
		// (set) Token: 0x06003DC5 RID: 15813 RVA: 0x0001F097 File Offset: 0x0001D297
		public unsafe static float RANGE_TO_ESCALATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&value));
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x0013A20C File Offset: 0x0013840C
		// (set) Token: 0x06003DC7 RID: 15815 RVA: 0x0001F0A5 File Offset: 0x0001D2A5
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x0013A228 File Offset: 0x00138428
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x0001F0B3 File Offset: 0x0001D2B3
		public unsafe static float BODY_SEARCH_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x0013A244 File Offset: 0x00138444
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x0001F0C1 File Offset: 0x0001D2C1
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x0013A274 File Offset: 0x00138474
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x0013A29C File Offset: 0x0013849C
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x0001F0FB File Offset: 0x0001D2FB
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0013A2C4 File Offset: 0x001384C4
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x0001F116 File Offset: 0x0001D316
		public unsafe bool ShowPostSearchDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue)) = value;
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x0013A2EC File Offset: 0x001384EC
		// (set) Token: 0x06003DD3 RID: 15827 RVA: 0x0001F131 File Offset: 0x0001D331
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0013A314 File Offset: 0x00138514
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x0001F14C File Offset: 0x0001D34C
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x0013A344 File Offset: 0x00138544
		// (set) Token: 0x06003DD7 RID: 15831 RVA: 0x0001F16B File Offset: 0x0001D36B
		public unsafe float targetDistanceOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart)) = value;
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x0013A36C File Offset: 0x0013856C
		// (set) Token: 0x06003DD9 RID: 15833 RVA: 0x0001F186 File Offset: 0x0001D386
		public unsafe float searchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime)) = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x0013A394 File Offset: 0x00138594
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x0001F1A1 File Offset: 0x0001D3A1
		public unsafe bool hasBeenInRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange)) = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0013A3BC File Offset: 0x001385BC
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x0001F1BC File Offset: 0x0001D3BC
		public unsafe float timeOutsideRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange)) = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x0013A3E4 File Offset: 0x001385E4
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x0001F1D7 File Offset: 0x0001D3D7
		public unsafe float timeWithinSearchRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange)) = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x0013A40C File Offset: 0x0013860C
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x0001F1F2 File Offset: 0x0001D3F2
		public unsafe float timeSinceCantReach
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach)) = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0013A434 File Offset: 0x00138634
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x0001F20D File Offset: 0x0001D40D
		public unsafe UnityEvent onSearchComplete_Clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x0013A464 File Offset: 0x00138664
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x0001F22C File Offset: 0x0001D42C
		public unsafe UnityEvent onSearchComplete_ItemsFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x0013A494 File Offset: 0x00138694
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0001F24B File Offset: 0x0001D44B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0013A4BC File Offset: 0x001386BC
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0001F266 File Offset: 0x0001D466
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEALTH_LEVEL;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_RANGE;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SEARCH_TIME;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeFieldInfoPtr_RANGE_TO_ESCALATE;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeFieldInfoPtr_ShowPostSearchDialogue;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeFieldInfoPtr_targetDistanceOnStart;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeFieldInfoPtr_searchTime;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeFieldInfoPtr_hasBeenInRange;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeFieldInfoPtr_timeOutsideRange;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinSearchRange;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCantReach;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_Clear;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_ItemsFound;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSearch_Private_Void_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_SearchClean_Private_Void_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_SearchFail_Private_Void_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
