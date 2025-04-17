using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A6 RID: 1190
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x060067D8 RID: 26584 RVA: 0x001D2DC8 File Offset: 0x001D0FC8
		// Note: this type is marked as 'beforefieldinit'.
		static RTBGameController()
		{
			Il2CppClassPointerStore<RTBGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "RTBGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr);
			RTBGameController.NativeFieldInfoPtr_BET_MINIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "BET_MINIMUM");
			RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "BET_MAXIMUM");
			RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ANSWER_MAX_TIME");
			RTBGameController.NativeFieldInfoPtr_PlayCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "PlayCameraTransform");
			RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "FocusedCameraTransform");
			RTBGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "Cards");
			RTBGameController.NativeFieldInfoPtr_CardDefaultPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "CardDefaultPositions");
			RTBGameController.NativeFieldInfoPtr_ActiveCardPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ActiveCardPosition");
			RTBGameController.NativeFieldInfoPtr_DockedCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "DockedCardPositions");
			RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_onStageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onStageChange");
			RTBGameController.NativeFieldInfoPtr_onQuestionReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionReady");
			RTBGameController.NativeFieldInfoPtr_onQuestionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionDone");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerCorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerIncorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<IsQuestionActive>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBetMultiplier>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<RemainingAnswerTime>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "playersInCurrentRound");
			RTBGameController.NativeFieldInfoPtr_cardsInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "cardsInDeck");
			RTBGameController.NativeFieldInfoPtr_drawnCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "drawnCards");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676491);
			RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676492);
			RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676493);
			RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676494);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676495);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676496);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676497);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676498);
			RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676499);
			RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676500);
			RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676501);
			RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676502);
			RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676503);
			RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676504);
			RTBGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676505);
			RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676506);
			RTBGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676507);
			RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676508);
			RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676509);
			RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676510);
			RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676511);
			RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676512);
			RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676513);
			RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676514);
			RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676515);
			RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676516);
			RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676517);
			RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676518);
			RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676519);
			RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676520);
			RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676521);
			RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676522);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676523);
			RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676524);
			RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676525);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676526);
			RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676527);
			RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676528);
			RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676529);
			RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676530);
			RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676531);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676532);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676533);
			RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676534);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676535);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676536);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676537);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676538);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676539);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676540);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676541);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676542);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676543);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676544);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676545);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676546);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676547);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676548);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676549);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676550);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676551);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676552);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676553);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676554);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676555);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676556);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676557);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676558);
			RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676559);
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x001D3564 File Offset: 0x001D1764
		// (set) Token: 0x060067DA RID: 26586 RVA: 0x001D35A0 File Offset: 0x001D17A0
		public unsafe RTBGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x060067DB RID: 26587 RVA: 0x001D35E0 File Offset: 0x001D17E0
		// (set) Token: 0x060067DC RID: 26588 RVA: 0x001D361C File Offset: 0x001D181C
		public unsafe bool IsQuestionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x001D365C File Offset: 0x001D185C
		// (set) Token: 0x060067DE RID: 26590 RVA: 0x001D3698 File Offset: 0x001D1898
		public unsafe float LocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x001D36D8 File Offset: 0x001D18D8
		// (set) Token: 0x060067E0 RID: 26592 RVA: 0x001D3714 File Offset: 0x001D1914
		public unsafe float LocalPlayerBetMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x001D3754 File Offset: 0x001D1954
		public unsafe float MultipliedLocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x001D3790 File Offset: 0x001D1990
		// (set) Token: 0x060067E3 RID: 26595 RVA: 0x001D37CC File Offset: 0x001D19CC
		public unsafe float RemainingAnswerTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x001D380C File Offset: 0x001D1A0C
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 210485, RefRangeEnd = 210497, XrefRangeStart = 210477, XrefRangeEnd = 210485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x001D3848 File Offset: 0x001D1A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210497, XrefRangeEnd = 210499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x001D3884 File Offset: 0x001D1A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210499, XrefRangeEnd = 210506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x001D38C0 File Offset: 0x001D1AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210506, XrefRangeEnd = 210515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x001D38FC File Offset: 0x001D1AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210515, XrefRangeEnd = 210518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x001D394C File Offset: 0x001D1B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210518, XrefRangeEnd = 210548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x001D3988 File Offset: 0x001D1B88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 210570, RefRangeEnd = 210575, XrefRangeStart = 210548, XrefRangeEnd = 210570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStage(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x001D39C8 File Offset: 0x001D1BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210592, RefRangeEnd = 210593, XrefRangeStart = 210575, XrefRangeEnd = 210592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunRound(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x001D3A08 File Offset: 0x001D1C08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210613, RefRangeEnd = 210616, XrefRangeStart = 210593, XrefRangeEnd = 210613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x001D3A48 File Offset: 0x001D1C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210640, RefRangeEnd = 210641, XrefRangeStart = 210616, XrefRangeEnd = 210640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x001D3A7C File Offset: 0x001D1C7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 210685, RefRangeEnd = 210691, XrefRangeStart = 210641, XrefRangeEnd = 210685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x001D3AC8 File Offset: 0x001D1CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210692, RefRangeEnd = 210693, XrefRangeStart = 210691, XrefRangeEnd = 210692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x001D3B04 File Offset: 0x001D1D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210705, RefRangeEnd = 210706, XrefRangeStart = 210693, XrefRangeEnd = 210705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x001D3B5C File Offset: 0x001D1D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210706, XrefRangeEnd = 210728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAnswer(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x001D3B9C File Offset: 0x001D1D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210728, XrefRangeEnd = 210749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x001D3BD0 File Offset: 0x001D1DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210812, RefRangeEnd = 210813, XrefRangeStart = 210749, XrefRangeEnd = 210812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			question = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			answers = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x001D3C4C File Offset: 0x001D1E4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 210835, RefRangeEnd = 210840, XrefRangeStart = 210813, XrefRangeEnd = 210835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x001D3C80 File Offset: 0x001D1E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210840, XrefRangeEnd = 210862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x001D3CC4 File Offset: 0x001D1EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210862, XrefRangeEnd = 210884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x001D3D08 File Offset: 0x001D1F08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210906, RefRangeEnd = 210909, XrefRangeStart = 210884, XrefRangeEnd = 210906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x001D3D4C File Offset: 0x001D1F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210909, XrefRangeEnd = 210920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardData PullCardFromDeck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x001D3D88 File Offset: 0x001D1F88
		[CallerCount(0)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x001D3DC8 File Offset: 0x001D1FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210920, XrefRangeEnd = 210923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x001D3E04 File Offset: 0x001D2004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210936, RefRangeEnd = 210938, XrefRangeStart = 210923, XrefRangeEnd = 210936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x001D3E40 File Offset: 0x001D2040
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210944, RefRangeEnd = 210947, XrefRangeStart = 210938, XrefRangeEnd = 210944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerAnswer(float answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x001D3E80 File Offset: 0x001D2080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210947, XrefRangeEnd = 210964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAnsweredPlayersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x001D3EBC File Offset: 0x001D20BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210964, XrefRangeEnd = 210975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x001D3EF0 File Offset: 0x001D20F0
		[CallerCount(0)]
		public unsafe int GetCardNumberValue(PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x001D3F3C File Offset: 0x001D213C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210975, RefRangeEnd = 210976, XrefRangeStart = 210975, XrefRangeEnd = 210975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x001D3F7C File Offset: 0x001D217C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210976, XrefRangeEnd = 210996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x001D3FB8 File Offset: 0x001D21B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210996, XrefRangeEnd = 211047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x001D3FF4 File Offset: 0x001D21F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211047, XrefRangeEnd = 211048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x001D4030 File Offset: 0x001D2230
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x001D406C File Offset: 0x001D226C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211048, XrefRangeEnd = 211067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x001D40AC File Offset: 0x001D22AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211083, RefRangeEnd = 211085, XrefRangeStart = 211067, XrefRangeEnd = 211083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x001D40EC File Offset: 0x001D22EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211085, XrefRangeEnd = 211089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x001D413C File Offset: 0x001D233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211089, XrefRangeEnd = 211108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x001D417C File Offset: 0x001D237C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x001D41BC File Offset: 0x001D23BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211108, XrefRangeEnd = 211111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x001D420C File Offset: 0x001D240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211111, XrefRangeEnd = 211129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x001D4240 File Offset: 0x001D2440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211129, XrefRangeEnd = 211133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x001D4274 File Offset: 0x001D2474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211133, XrefRangeEnd = 211139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x001D42C4 File Offset: 0x001D24C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211139, XrefRangeEnd = 211158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x001D4304 File Offset: 0x001D2504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211178, RefRangeEnd = 211181, XrefRangeStart = 211158, XrefRangeEnd = 211178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x001D4344 File Offset: 0x001D2544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211181, XrefRangeEnd = 211185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x001D4394 File Offset: 0x001D2594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211185, XrefRangeEnd = 211203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x001D43C8 File Offset: 0x001D25C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211211, RefRangeEnd = 211216, XrefRangeStart = 211203, XrefRangeEnd = 211211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x001D43FC File Offset: 0x001D25FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211216, XrefRangeEnd = 211219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x001D444C File Offset: 0x001D264C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211219, XrefRangeEnd = 211238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x001D4490 File Offset: 0x001D2690
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211251, RefRangeEnd = 211254, XrefRangeStart = 211238, XrefRangeEnd = 211251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x001D44D4 File Offset: 0x001D26D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211254, XrefRangeEnd = 211258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x001D4524 File Offset: 0x001D2724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211258, XrefRangeEnd = 211277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x001D4568 File Offset: 0x001D2768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210906, RefRangeEnd = 210909, XrefRangeStart = 210906, XrefRangeEnd = 210909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x001D45AC File Offset: 0x001D27AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211277, XrefRangeEnd = 211281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x001D4610 File Offset: 0x001D2810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211281, XrefRangeEnd = 211300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x001D4654 File Offset: 0x001D2854
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211316, RefRangeEnd = 211319, XrefRangeStart = 211300, XrefRangeEnd = 211316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x001D4698 File Offset: 0x001D2898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211319, XrefRangeEnd = 211323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x001D46E8 File Offset: 0x001D28E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211323, XrefRangeEnd = 211325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x00030FB3 File Offset: 0x0002F1B3
		public RTBGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x0600681F RID: 26655 RVA: 0x001D4724 File Offset: 0x001D2924
		// (set) Token: 0x06006820 RID: 26656 RVA: 0x00030FBC File Offset: 0x0002F1BC
		public unsafe static int BET_MINIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x001D4740 File Offset: 0x001D2940
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x00030FCA File Offset: 0x0002F1CA
		public unsafe static int BET_MAXIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x001D475C File Offset: 0x001D295C
		// (set) Token: 0x06006824 RID: 26660 RVA: 0x00030FD8 File Offset: 0x0002F1D8
		public unsafe static float ANSWER_MAX_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x001D4778 File Offset: 0x001D2978
		// (set) Token: 0x06006826 RID: 26662 RVA: 0x00030FE6 File Offset: 0x0002F1E6
		public unsafe Transform PlayCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x001D47A8 File Offset: 0x001D29A8
		// (set) Token: 0x06006828 RID: 26664 RVA: 0x00031005 File Offset: 0x0002F205
		public unsafe Transform FocusedCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x001D47D8 File Offset: 0x001D29D8
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x00031024 File Offset: 0x0002F224
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x001D4808 File Offset: 0x001D2A08
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x00031043 File Offset: 0x0002F243
		public unsafe Il2CppReferenceArray<Transform> CardDefaultPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x001D4838 File Offset: 0x001D2A38
		// (set) Token: 0x0600682E RID: 26670 RVA: 0x00031062 File Offset: 0x0002F262
		public unsafe Transform ActiveCardPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x001D4868 File Offset: 0x001D2A68
		// (set) Token: 0x06006830 RID: 26672 RVA: 0x00031081 File Offset: 0x0002F281
		public unsafe Il2CppReferenceArray<Transform> DockedCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x001D4898 File Offset: 0x001D2A98
		// (set) Token: 0x06006832 RID: 26674 RVA: 0x000310A0 File Offset: 0x0002F2A0
		public unsafe RTBGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x001D48C0 File Offset: 0x001D2AC0
		// (set) Token: 0x06006834 RID: 26676 RVA: 0x000310BB File Offset: 0x0002F2BB
		public unsafe Action<RTBGameController.EStage> onStageChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RTBGameController.EStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x001D48F0 File Offset: 0x001D2AF0
		// (set) Token: 0x06006836 RID: 26678 RVA: 0x000310DA File Offset: 0x0002F2DA
		public unsafe Action<string, Il2CppStringArray> onQuestionReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06006837 RID: 26679 RVA: 0x001D4920 File Offset: 0x001D2B20
		// (set) Token: 0x06006838 RID: 26680 RVA: 0x000310F9 File Offset: 0x0002F2F9
		public unsafe Action onQuestionDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06006839 RID: 26681 RVA: 0x001D4950 File Offset: 0x001D2B50
		// (set) Token: 0x0600683A RID: 26682 RVA: 0x00031118 File Offset: 0x0002F318
		public unsafe Action onLocalPlayerCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x001D4980 File Offset: 0x001D2B80
		// (set) Token: 0x0600683C RID: 26684 RVA: 0x00031137 File Offset: 0x0002F337
		public unsafe Action onLocalPlayerIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x001D49B0 File Offset: 0x001D2BB0
		// (set) Token: 0x0600683E RID: 26686 RVA: 0x00031156 File Offset: 0x0002F356
		public unsafe Action onLocalPlayerBetChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600683F RID: 26687 RVA: 0x001D49E0 File Offset: 0x001D2BE0
		// (set) Token: 0x06006840 RID: 26688 RVA: 0x00031175 File Offset: 0x0002F375
		public unsafe Action onLocalPlayerExitRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06006841 RID: 26689 RVA: 0x001D4A10 File Offset: 0x001D2C10
		// (set) Token: 0x06006842 RID: 26690 RVA: 0x00031194 File Offset: 0x0002F394
		public unsafe bool _IsQuestionActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06006843 RID: 26691 RVA: 0x001D4A38 File Offset: 0x001D2C38
		// (set) Token: 0x06006844 RID: 26692 RVA: 0x000311AF File Offset: 0x0002F3AF
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06006845 RID: 26693 RVA: 0x001D4A60 File Offset: 0x001D2C60
		// (set) Token: 0x06006846 RID: 26694 RVA: 0x000311CA File Offset: 0x0002F3CA
		public unsafe float _LocalPlayerBetMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06006847 RID: 26695 RVA: 0x001D4A88 File Offset: 0x001D2C88
		// (set) Token: 0x06006848 RID: 26696 RVA: 0x000311E5 File Offset: 0x0002F3E5
		public unsafe float _RemainingAnswerTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06006849 RID: 26697 RVA: 0x001D4AB0 File Offset: 0x001D2CB0
		// (set) Token: 0x0600684A RID: 26698 RVA: 0x00031200 File Offset: 0x0002F400
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x001D4AE0 File Offset: 0x001D2CE0
		// (set) Token: 0x0600684C RID: 26700 RVA: 0x0003121F File Offset: 0x0002F41F
		public unsafe List<PlayingCard.CardData> cardsInDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x0600684D RID: 26701 RVA: 0x001D4B10 File Offset: 0x001D2D10
		// (set) Token: 0x0600684E RID: 26702 RVA: 0x0003123E File Offset: 0x0002F43E
		public unsafe List<PlayingCard.CardData> drawnCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x0600684F RID: 26703 RVA: 0x001D4B40 File Offset: 0x001D2D40
		// (set) Token: 0x06006850 RID: 26704 RVA: 0x0003125D File Offset: 0x0002F45D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06006851 RID: 26705 RVA: 0x001D4B68 File Offset: 0x001D2D68
		// (set) Token: 0x06006852 RID: 26706 RVA: 0x00031278 File Offset: 0x0002F478
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004724 RID: 18212
		private static readonly IntPtr NativeFieldInfoPtr_BET_MINIMUM;

		// Token: 0x04004725 RID: 18213
		private static readonly IntPtr NativeFieldInfoPtr_BET_MAXIMUM;

		// Token: 0x04004726 RID: 18214
		private static readonly IntPtr NativeFieldInfoPtr_ANSWER_MAX_TIME;

		// Token: 0x04004727 RID: 18215
		private static readonly IntPtr NativeFieldInfoPtr_PlayCameraTransform;

		// Token: 0x04004728 RID: 18216
		private static readonly IntPtr NativeFieldInfoPtr_FocusedCameraTransform;

		// Token: 0x04004729 RID: 18217
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x0400472A RID: 18218
		private static readonly IntPtr NativeFieldInfoPtr_CardDefaultPositions;

		// Token: 0x0400472B RID: 18219
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCardPosition;

		// Token: 0x0400472C RID: 18220
		private static readonly IntPtr NativeFieldInfoPtr_DockedCardPositions;

		// Token: 0x0400472D RID: 18221
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x0400472E RID: 18222
		private static readonly IntPtr NativeFieldInfoPtr_onStageChange;

		// Token: 0x0400472F RID: 18223
		private static readonly IntPtr NativeFieldInfoPtr_onQuestionReady;

		// Token: 0x04004730 RID: 18224
		private static readonly IntPtr NativeFieldInfoPtr_onQuestionDone;

		// Token: 0x04004731 RID: 18225
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerCorrect;

		// Token: 0x04004732 RID: 18226
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerIncorrect;

		// Token: 0x04004733 RID: 18227
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x04004734 RID: 18228
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x04004735 RID: 18229
		private static readonly IntPtr NativeFieldInfoPtr__IsQuestionActive_k__BackingField;

		// Token: 0x04004736 RID: 18230
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x04004737 RID: 18231
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField;

		// Token: 0x04004738 RID: 18232
		private static readonly IntPtr NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField;

		// Token: 0x04004739 RID: 18233
		private static readonly IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x0400473A RID: 18234
		private static readonly IntPtr NativeFieldInfoPtr_cardsInDeck;

		// Token: 0x0400473B RID: 18235
		private static readonly IntPtr NativeFieldInfoPtr_drawnCards;

		// Token: 0x0400473C RID: 18236
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400473D RID: 18237
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400473E RID: 18238
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x0400473F RID: 18239
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x04004740 RID: 18240
		private static readonly IntPtr NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0;

		// Token: 0x04004741 RID: 18241
		private static readonly IntPtr NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0;

		// Token: 0x04004742 RID: 18242
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x04004743 RID: 18243
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0;

		// Token: 0x04004744 RID: 18244
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0;

		// Token: 0x04004745 RID: 18245
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0;

		// Token: 0x04004746 RID: 18246
		private static readonly IntPtr NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0;

		// Token: 0x04004747 RID: 18247
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0;

		// Token: 0x04004748 RID: 18248
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0;

		// Token: 0x04004749 RID: 18249
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x0400474A RID: 18250
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400474B RID: 18251
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x0400474C RID: 18252
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_1;

		// Token: 0x0400474D RID: 18253
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x0400474E RID: 18254
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x0400474F RID: 18255
		private static readonly IntPtr NativeMethodInfoPtr_SetStage_Private_Void_EStage_0;

		// Token: 0x04004750 RID: 18256
		private static readonly IntPtr NativeMethodInfoPtr_RunRound_Private_Void_EStage_0;

		// Token: 0x04004751 RID: 18257
		private static readonly IntPtr NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0;

		// Token: 0x04004752 RID: 18258
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04004753 RID: 18259
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0;

		// Token: 0x04004754 RID: 18260
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x04004755 RID: 18261
		private static readonly IntPtr NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0;

		// Token: 0x04004756 RID: 18262
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0;

		// Token: 0x04004757 RID: 18263
		private static readonly IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x04004758 RID: 18264
		private static readonly IntPtr NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0;

		// Token: 0x04004759 RID: 18265
		private static readonly IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x0400475A RID: 18266
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400475B RID: 18267
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400475C RID: 18268
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400475D RID: 18269
		private static readonly IntPtr NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0;

		// Token: 0x0400475E RID: 18270
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x0400475F RID: 18271
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x04004760 RID: 18272
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x04004761 RID: 18273
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0;

		// Token: 0x04004762 RID: 18274
		private static readonly IntPtr NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0;

		// Token: 0x04004763 RID: 18275
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0;

		// Token: 0x04004764 RID: 18276
		private static readonly IntPtr NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0;

		// Token: 0x04004765 RID: 18277
		private static readonly IntPtr NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0;

		// Token: 0x04004766 RID: 18278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004767 RID: 18279
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004768 RID: 18280
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004769 RID: 18281
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400476A RID: 18282
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x0400476B RID: 18283
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x0400476C RID: 18284
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400476D RID: 18285
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x0400476E RID: 18286
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x0400476F RID: 18287
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004770 RID: 18288
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x04004771 RID: 18289
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x04004772 RID: 18290
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004773 RID: 18291
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x04004774 RID: 18292
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x04004775 RID: 18293
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004776 RID: 18294
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0;

		// Token: 0x04004777 RID: 18295
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0;

		// Token: 0x04004778 RID: 18296
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004779 RID: 18297
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400477A RID: 18298
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400477B RID: 18299
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400477C RID: 18300
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400477D RID: 18301
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400477E RID: 18302
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400477F RID: 18303
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004780 RID: 18304
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004781 RID: 18305
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004782 RID: 18306
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A48 RID: 2632
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04008C57 RID: 35927
			WaitingForPlayers,
			// Token: 0x04008C58 RID: 35928
			RedOrBlack,
			// Token: 0x04008C59 RID: 35929
			HigherOrLower,
			// Token: 0x04008C5A RID: 35930
			InsideOrOutside,
			// Token: 0x04008C5B RID: 35931
			Suit
		}

		// Token: 0x02000A49 RID: 2633
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D001 RID: 53249 RVA: 0x0031EB3C File Offset: 0x0031CD3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "stage");
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676560);
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676561);
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676562);
			}

			// Token: 0x0600D002 RID: 53250 RVA: 0x0031EBCC File Offset: 0x0031CDCC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D003 RID: 53251 RVA: 0x0031EC08 File Offset: 0x0031CE08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210449, XrefRangeEnd = 210454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D004 RID: 53252 RVA: 0x0031EC48 File Offset: 0x0031CE48
			[CallerCount(0)]
			public unsafe bool _RunRound_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D005 RID: 53253 RVA: 0x00065367 File Offset: 0x00063567
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409C RID: 16540
			// (get) Token: 0x0600D006 RID: 53254 RVA: 0x0031EC84 File Offset: 0x0031CE84
			// (set) Token: 0x0600D007 RID: 53255 RVA: 0x00065370 File Offset: 0x00063570
			public unsafe RTBGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700409D RID: 16541
			// (get) Token: 0x0600D008 RID: 53256 RVA: 0x0031ECB4 File Offset: 0x0031CEB4
			// (set) Token: 0x0600D009 RID: 53257 RVA: 0x0006538F File Offset: 0x0006358F
			public unsafe RTBGameController.EStage stage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage)) = value;
				}
			}

			// Token: 0x04008C5C RID: 35932
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C5D RID: 35933
			private static readonly IntPtr NativeFieldInfoPtr_stage;

			// Token: 0x04008C5E RID: 35934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C5F RID: 35935
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008C60 RID: 35936
			private static readonly IntPtr NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0;

			// Token: 0x02000C5A RID: 3162
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass50_0+<<RunRound>g__RunRound|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3AC RID: 58284 RVA: 0x00356BD4 File Offset: 0x00354DD4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "<<RunRound>g__RunRound|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<activeCard>5__2");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676563);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676564);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676565);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676566);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676567);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676568);
				}

				// Token: 0x0600E3AD RID: 58285 RVA: 0x00356CC8 File Offset: 0x00354EC8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3AE RID: 58286 RVA: 0x00356D10 File Offset: 0x00354F10
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3AF RID: 58287 RVA: 0x00356D44 File Offset: 0x00354F44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210266, XrefRangeEnd = 210444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046AD RID: 18093
				// (get) Token: 0x0600E3B0 RID: 58288 RVA: 0x00356D80 File Offset: 0x00354F80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3B1 RID: 58289 RVA: 0x00356DC0 File Offset: 0x00354FC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210444, XrefRangeEnd = 210449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046AE RID: 18094
				// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x00356DF4 File Offset: 0x00354FF4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3B3 RID: 58291 RVA: 0x0006EFA6 File Offset: 0x0006D1A6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046A9 RID: 18089
				// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x00356E34 File Offset: 0x00355034
				// (set) Token: 0x0600E3B5 RID: 58293 RVA: 0x0006EFAF File Offset: 0x0006D1AF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046AA RID: 18090
				// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x00356E5C File Offset: 0x0035505C
				// (set) Token: 0x0600E3B7 RID: 58295 RVA: 0x0006EFCA File Offset: 0x0006D1CA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046AB RID: 18091
				// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x00356E8C File Offset: 0x0035508C
				// (set) Token: 0x0600E3B9 RID: 58297 RVA: 0x0006EFE9 File Offset: 0x0006D1E9
				public unsafe RTBGameController.__c__DisplayClass50_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass50_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046AC RID: 18092
				// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x00356EBC File Offset: 0x003550BC
				// (set) Token: 0x0600E3BB RID: 58299 RVA: 0x0006F008 File Offset: 0x0006D208
				public unsafe PlayingCard _activeCard_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009856 RID: 38998
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009857 RID: 38999
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009858 RID: 39000
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009859 RID: 39001
				private static readonly IntPtr NativeFieldInfoPtr__activeCard_5__2;

				// Token: 0x0400985A RID: 39002
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400985B RID: 39003
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400985C RID: 39004
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400985D RID: 39005
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400985E RID: 39006
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400985F RID: 39007
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A4A RID: 2634
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D00A RID: 53258 RVA: 0x0031ECDC File Offset: 0x0031CEDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "cameraDelay");
				RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, 100676569);
				RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, 100676570);
			}

			// Token: 0x0600D00B RID: 53259 RVA: 0x0031ED58 File Offset: 0x0031CF58
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D00C RID: 53260 RVA: 0x0031ED94 File Offset: 0x0031CF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210472, XrefRangeEnd = 210477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D00D RID: 53261 RVA: 0x000653AA File Offset: 0x000635AA
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409E RID: 16542
			// (get) Token: 0x0600D00E RID: 53262 RVA: 0x0031EDD4 File Offset: 0x0031CFD4
			// (set) Token: 0x0600D00F RID: 53263 RVA: 0x000653B3 File Offset: 0x000635B3
			public unsafe float cameraDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x1700409F RID: 16543
			// (get) Token: 0x0600D010 RID: 53264 RVA: 0x0031EDFC File Offset: 0x0031CFFC
			// (set) Token: 0x0600D011 RID: 53265 RVA: 0x000653CE File Offset: 0x000635CE
			public unsafe RTBGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C61 RID: 35937
			private static readonly IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04008C62 RID: 35938
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C63 RID: 35939
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C64 RID: 35940
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5B RID: 3163
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass53_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3BC RID: 58300 RVA: 0x00356EEC File Offset: 0x003550EC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676571);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676572);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676573);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676574);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676575);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676576);
				}

				// Token: 0x0600E3BD RID: 58301 RVA: 0x00356FCC File Offset: 0x003551CC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3BE RID: 58302 RVA: 0x00357014 File Offset: 0x00355214
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3BF RID: 58303 RVA: 0x00357048 File Offset: 0x00355248
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210454, XrefRangeEnd = 210467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046B2 RID: 18098
				// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x00357084 File Offset: 0x00355284
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3C1 RID: 58305 RVA: 0x003570C4 File Offset: 0x003552C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210467, XrefRangeEnd = 210472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046B3 RID: 18099
				// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x003570F8 File Offset: 0x003552F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3C3 RID: 58307 RVA: 0x0006F027 File Offset: 0x0006D227
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046AF RID: 18095
				// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x00357138 File Offset: 0x00355338
				// (set) Token: 0x0600E3C5 RID: 58309 RVA: 0x0006F030 File Offset: 0x0006D230
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046B0 RID: 18096
				// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x00357160 File Offset: 0x00355360
				// (set) Token: 0x0600E3C7 RID: 58311 RVA: 0x0006F04B File Offset: 0x0006D24B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046B1 RID: 18097
				// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x00357190 File Offset: 0x00355390
				// (set) Token: 0x0600E3C9 RID: 58313 RVA: 0x0006F06A File Offset: 0x0006D26A
				public unsafe RTBGameController.__c__DisplayClass53_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass53_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009860 RID: 39008
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009861 RID: 39009
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009862 RID: 39010
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009863 RID: 39011
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009864 RID: 39012
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009865 RID: 39013
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009866 RID: 39014
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009867 RID: 39015
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009868 RID: 39016
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
