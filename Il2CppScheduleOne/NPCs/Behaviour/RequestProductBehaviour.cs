using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000361 RID: 865
	public class RequestProductBehaviour : Behaviour
	{
		// Token: 0x06004327 RID: 17191 RVA: 0x0014DFC8 File Offset: 0x0014C1C8
		// Note: this type is marked as 'beforefieldinit'.
		static RequestProductBehaviour()
		{
			Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "RequestProductBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr);
			RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "CONVERSATION_RANGE");
			RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "FOLLOW_MAX_RANGE");
			RequestProductBehaviour.NativeFieldInfoPtr_MINS_TO_ASK_AGAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "MINS_TO_ASK_AGAIN");
			RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<State>k__BackingField");
			RequestProductBehaviour.NativeFieldInfoPtr_minsSinceLastDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "minsSinceLastDialogue");
			RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "requestGreeting");
			RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "acceptRequestChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_followChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "followChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "rejectChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted");
			RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted");
			RequestProductBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671493);
			RequestProductBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671494);
			RequestProductBehaviour.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671495);
			RequestProductBehaviour.NativeMethodInfoPtr_set_State_Private_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671496);
			RequestProductBehaviour.NativeMethodInfoPtr_get_customer_Private_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671497);
			RequestProductBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671498);
			RequestProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671499);
			RequestProductBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671500);
			RequestProductBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671501);
			RequestProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671502);
			RequestProductBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671503);
			RequestProductBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671504);
			RequestProductBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671505);
			RequestProductBehaviour.NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671506);
			RequestProductBehaviour.NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671507);
			RequestProductBehaviour.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671508);
			RequestProductBehaviour.NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671509);
			RequestProductBehaviour.NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671510);
			RequestProductBehaviour.NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671511);
			RequestProductBehaviour.NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671512);
			RequestProductBehaviour.NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671513);
			RequestProductBehaviour.NativeMethodInfoPtr_RequestAccepted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671514);
			RequestProductBehaviour.NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671515);
			RequestProductBehaviour.NativeMethodInfoPtr_Follow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671516);
			RequestProductBehaviour.NativeMethodInfoPtr_RequestRejected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671517);
			RequestProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671518);
			RequestProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671519);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671520);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671521);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671522);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671523);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671524);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671525);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671526);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671527);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671528);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671529);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671530);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671531);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671532);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671533);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671534);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671535);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671536);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671537);
			RequestProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671538);
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x0014E480 File Offset: 0x0014C680
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x0014E4C0 File Offset: 0x0014C6C0
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x0014E504 File Offset: 0x0014C704
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x0014E540 File Offset: 0x0014C740
		public unsafe RequestProductBehaviour.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_set_State_Private_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x0014E580 File Offset: 0x0014C780
		public unsafe Customer customer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 153512, RefRangeEnd = 153513, XrefRangeStart = 153507, XrefRangeEnd = 153512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_customer_Private_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr3) : null;
			}
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x0014E5C0 File Offset: 0x0014C7C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153542, RefRangeEnd = 153543, XrefRangeStart = 153513, XrefRangeEnd = 153542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignTarget(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x0014E604 File Offset: 0x0014C804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153543, XrefRangeEnd = 153544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x0014E640 File Offset: 0x0014C840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153544, XrefRangeEnd = 153586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x0014E67C File Offset: 0x0014C87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153586, XrefRangeEnd = 153594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x0014E6B8 File Offset: 0x0014C8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x0014E6F4 File Offset: 0x0014C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153594, XrefRangeEnd = 153660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x0014E730 File Offset: 0x0014C930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153673, RefRangeEnd = 153674, XrefRangeStart = 153660, XrefRangeEnd = 153673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetDestinationValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x0014E76C File Offset: 0x0014C96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153688, RefRangeEnd = 153689, XrefRangeStart = 153674, XrefRangeEnd = 153688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNewDestination(out Vector3 dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &dest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x0014E7B8 File Offset: 0x0014C9B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153694, RefRangeEnd = 153696, XrefRangeStart = 153689, XrefRangeEnd = 153694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTargetValid(Player player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x0014E7FC File Offset: 0x0014C9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153720, RefRangeEnd = 153722, XrefRangeStart = 153696, XrefRangeEnd = 153720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x0014E838 File Offset: 0x0014CA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153822, RefRangeEnd = 153823, XrefRangeStart = 153722, XrefRangeEnd = 153822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x0014E86C File Offset: 0x0014CA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153823, XrefRangeEnd = 153844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartInitialDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x0014E8A0 File Offset: 0x0014CAA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 153865, RefRangeEnd = 153869, XrefRangeStart = 153844, XrefRangeEnd = 153865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInitialDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x0014E8D4 File Offset: 0x0014CAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153869, XrefRangeEnd = 153890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartFollowUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x0014E908 File Offset: 0x0014CB08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153911, RefRangeEnd = 153914, XrefRangeStart = 153890, XrefRangeEnd = 153911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFollowUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x0014E93C File Offset: 0x0014CB3C
		[CallerCount(0)]
		public unsafe bool DialogueActive(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x0014E988 File Offset: 0x0014CB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153914, XrefRangeEnd = 153938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RequestAccepted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x0014E9BC File Offset: 0x0014CBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153938, XrefRangeEnd = 154005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x0014EA1C File Offset: 0x0014CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154005, XrefRangeEnd = 154022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Follow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_Follow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x0014EA50 File Offset: 0x0014CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154022, XrefRangeEnd = 154029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RequestRejected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x0014EA84 File Offset: 0x0014CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestProductBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x0014EAC0 File Offset: 0x0014CCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154029, XrefRangeEnd = 154034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x0014EB00 File Offset: 0x0014CD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154034, XrefRangeEnd = 154067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x0014EB3C File Offset: 0x0014CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x0014EB78 File Offset: 0x0014CD78
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x0014EBB4 File Offset: 0x0014CDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154067, XrefRangeEnd = 154086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x0014EBF8 File Offset: 0x0014CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154086, XrefRangeEnd = 154096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AssignTarget_3323014238(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0014EC3C File Offset: 0x0014CE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154096, XrefRangeEnd = 154107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x0014EC8C File Offset: 0x0014CE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154107, XrefRangeEnd = 154125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0014ECC0 File Offset: 0x0014CEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154125, XrefRangeEnd = 154126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0014ECF4 File Offset: 0x0014CEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154126, XrefRangeEnd = 154129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x0014ED58 File Offset: 0x0014CF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154129, XrefRangeEnd = 154147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x0014ED8C File Offset: 0x0014CF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154166, RefRangeEnd = 154168, XrefRangeStart = 154147, XrefRangeEnd = 154166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x0014EDC0 File Offset: 0x0014CFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154168, XrefRangeEnd = 154171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x0014EE10 File Offset: 0x0014D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154171, XrefRangeEnd = 154189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x0014EE44 File Offset: 0x0014D044
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153911, RefRangeEnd = 153914, XrefRangeStart = 153911, XrefRangeEnd = 153914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x0014EE78 File Offset: 0x0014D078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154189, XrefRangeEnd = 154192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x0014EEDC File Offset: 0x0014D0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154192, XrefRangeEnd = 154210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x0014EF10 File Offset: 0x0014D110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154229, RefRangeEnd = 154232, XrefRangeStart = 154210, XrefRangeEnd = 154229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x0014EF44 File Offset: 0x0014D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154232, XrefRangeEnd = 154235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x0014EF94 File Offset: 0x0014D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00020E8F File Offset: 0x0001F08F
		public RequestProductBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x0014EFD0 File Offset: 0x0014D1D0
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x00020E98 File Offset: 0x0001F098
		public unsafe static float CONVERSATION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x0014EFEC File Offset: 0x0014D1EC
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x00020EA6 File Offset: 0x0001F0A6
		public unsafe static float FOLLOW_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x0014F008 File Offset: 0x0014D208
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		public unsafe static int MINS_TO_ASK_AGAIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_MINS_TO_ASK_AGAIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_MINS_TO_ASK_AGAIN, (void*)(&value));
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x0014F024 File Offset: 0x0014D224
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x00020EC2 File Offset: 0x0001F0C2
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x0014F054 File Offset: 0x0014D254
		// (set) Token: 0x06004360 RID: 17248 RVA: 0x00020EE1 File Offset: 0x0001F0E1
		public unsafe RequestProductBehaviour.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x0014F07C File Offset: 0x0014D27C
		// (set) Token: 0x06004362 RID: 17250 RVA: 0x00020EFC File Offset: 0x0001F0FC
		public unsafe int minsSinceLastDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_minsSinceLastDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_minsSinceLastDialogue)) = value;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x0014F0A4 File Offset: 0x0014D2A4
		// (set) Token: 0x06004364 RID: 17252 RVA: 0x00020F17 File Offset: 0x0001F117
		public unsafe DialogueController.GreetingOverride requestGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x0014F0D4 File Offset: 0x0014D2D4
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x00020F36 File Offset: 0x0001F136
		public unsafe DialogueController.DialogueChoice acceptRequestChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x0014F104 File Offset: 0x0014D304
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x00020F55 File Offset: 0x0001F155
		public unsafe DialogueController.DialogueChoice followChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_followChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_followChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x0014F134 File Offset: 0x0014D334
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x00020F74 File Offset: 0x0001F174
		public unsafe DialogueController.DialogueChoice rejectChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x0014F164 File Offset: 0x0014D364
		// (set) Token: 0x0600436C RID: 17260 RVA: 0x00020F93 File Offset: 0x0001F193
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x0014F18C File Offset: 0x0014D38C
		// (set) Token: 0x0600436E RID: 17262 RVA: 0x00020FAE File Offset: 0x0001F1AE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeFieldInfoPtr_CONVERSATION_RANGE;

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeFieldInfoPtr_FOLLOW_MAX_RANGE;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeFieldInfoPtr_MINS_TO_ASK_AGAIN;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceLastDialogue;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeFieldInfoPtr_requestGreeting;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeFieldInfoPtr_acceptRequestChoice;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeFieldInfoPtr_followChoice;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeFieldInfoPtr_rejectChoice;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0;

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_EState_0;

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeMethodInfoPtr_get_customer_Private_get_Customer_0;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_RequestAccepted_Private_Void_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeMethodInfoPtr_Follow_Private_Void_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeMethodInfoPtr_RequestRejected_Private_Void_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000964 RID: 2404
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400882A RID: 34858
			InitialApproach,
			// Token: 0x0400882B RID: 34859
			FollowPlayer
		}

		// Token: 0x02000965 RID: 2405
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.RequestProductBehaviour+<<HandoverClosed>g__Wait|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C92A RID: 51498 RVA: 0x0030B628 File Offset: 0x00309828
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
			{
				Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<<HandoverClosed>g__Wait|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671539);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671540);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671541);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671542);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671543);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671544);
			}

			// Token: 0x0600C92B RID: 51499 RVA: 0x0030B708 File Offset: 0x00309908
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C92C RID: 51500 RVA: 0x0030B750 File Offset: 0x00309950
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C92D RID: 51501 RVA: 0x0030B784 File Offset: 0x00309984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153497, XrefRangeEnd = 153502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EC6 RID: 16070
			// (get) Token: 0x0600C92E RID: 51502 RVA: 0x0030B7C0 File Offset: 0x003099C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C92F RID: 51503 RVA: 0x0030B800 File Offset: 0x00309A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153502, XrefRangeEnd = 153507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EC7 RID: 16071
			// (get) Token: 0x0600C930 RID: 51504 RVA: 0x0030B834 File Offset: 0x00309A34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C931 RID: 51505 RVA: 0x00061D9D File Offset: 0x0005FF9D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC3 RID: 16067
			// (get) Token: 0x0600C932 RID: 51506 RVA: 0x0030B874 File Offset: 0x00309A74
			// (set) Token: 0x0600C933 RID: 51507 RVA: 0x00061DA6 File Offset: 0x0005FFA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EC4 RID: 16068
			// (get) Token: 0x0600C934 RID: 51508 RVA: 0x0030B89C File Offset: 0x00309A9C
			// (set) Token: 0x0600C935 RID: 51509 RVA: 0x00061DC1 File Offset: 0x0005FFC1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC5 RID: 16069
			// (get) Token: 0x0600C936 RID: 51510 RVA: 0x0030B8CC File Offset: 0x00309ACC
			// (set) Token: 0x0600C937 RID: 51511 RVA: 0x00061DE0 File Offset: 0x0005FFE0
			public unsafe RequestProductBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400882C RID: 34860
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400882D RID: 34861
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400882E RID: 34862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400882F RID: 34863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008830 RID: 34864
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008831 RID: 34865
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008832 RID: 34866
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008833 RID: 34867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008834 RID: 34868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
