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
	// Token: 0x0200049F RID: 1183
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x0600664C RID: 26188 RVA: 0x001CC73C File Offset: 0x001CA93C
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackGameController()
		{
			Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "BlackjackGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr);
			BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BET_MINIMUM");
			BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BET_MAXIMUM");
			BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "PAYOUT_RATIO");
			BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BLACKJACK_PAYOUT_RATIO");
			BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<PlayerTurn>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<DealerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBlackjack>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBust>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Cards");
			BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DefaultCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FocusedCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FinalCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player1CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player2CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player3CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player4CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DealerCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playersInCurrentRound");
			BlackjackGameController.NativeFieldInfoPtr_playStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playStack");
			BlackjackGameController.NativeFieldInfoPtr_player1Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player1Hand");
			BlackjackGameController.NativeFieldInfoPtr_player2Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player2Hand");
			BlackjackGameController.NativeFieldInfoPtr_player3Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player3Hand");
			BlackjackGameController.NativeFieldInfoPtr_player4Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player4Hand");
			BlackjackGameController.NativeFieldInfoPtr_dealerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "dealerHand");
			BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "cardValuesInDeck");
			BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "drawnCardsValues");
			BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFocusCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFinalCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onInitialCardsDealt");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerReadyForInput");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBust");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerRoundCompleted");
			BlackjackGameController.NativeFieldInfoPtr_roundEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "roundEnded");
			BlackjackGameController.NativeFieldInfoPtr_gameRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "gameRoutine");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676239);
			BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676240);
			BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676241);
			BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676242);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676243);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676244);
			BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676245);
			BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676246);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676247);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676248);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676249);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676250);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676251);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676252);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676253);
			BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676254);
			BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676255);
			BlackjackGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676256);
			BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676257);
			BlackjackGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676258);
			BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676259);
			BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676260);
			BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676261);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676262);
			BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676263);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676264);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676265);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676266);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676267);
			BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676268);
			BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676269);
			BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676270);
			BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676271);
			BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676272);
			BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676273);
			BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676274);
			BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676275);
			BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676276);
			BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676277);
			BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676278);
			BlackjackGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676279);
			BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676280);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676281);
			BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676282);
			BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676283);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676284);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676285);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676286);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676287);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676288);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676289);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676290);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676291);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676292);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676293);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676294);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676295);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676296);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676297);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676298);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676299);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676300);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676301);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676302);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676303);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676304);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676305);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676306);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676307);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676308);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676309);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676310);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676311);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676312);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676313);
			BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676314);
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x001CD090 File Offset: 0x001CB290
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x001CD0CC File Offset: 0x001CB2CC
		public unsafe BlackjackGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x001CD10C File Offset: 0x001CB30C
		// (set) Token: 0x06006650 RID: 26192 RVA: 0x001CD14C File Offset: 0x001CB34C
		public unsafe Player PlayerTurn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x001CD190 File Offset: 0x001CB390
		// (set) Token: 0x06006652 RID: 26194 RVA: 0x001CD1CC File Offset: 0x001CB3CC
		public unsafe float LocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06006653 RID: 26195 RVA: 0x001CD20C File Offset: 0x001CB40C
		// (set) Token: 0x06006654 RID: 26196 RVA: 0x001CD248 File Offset: 0x001CB448
		public unsafe int DealerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x001CD288 File Offset: 0x001CB488
		// (set) Token: 0x06006656 RID: 26198 RVA: 0x001CD2C4 File Offset: 0x001CB4C4
		public unsafe int LocalPlayerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x001CD304 File Offset: 0x001CB504
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x001CD340 File Offset: 0x001CB540
		public unsafe bool IsLocalPlayerBlackjack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x001CD380 File Offset: 0x001CB580
		// (set) Token: 0x0600665A RID: 26202 RVA: 0x001CD3BC File Offset: 0x001CB5BC
		public unsafe bool IsLocalPlayerBust
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x001CD3FC File Offset: 0x001CB5FC
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 207198, RefRangeEnd = 207203, XrefRangeStart = 207190, XrefRangeEnd = 207198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x001CD438 File Offset: 0x001CB638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207203, XrefRangeEnd = 207204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x001CD474 File Offset: 0x001CB674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207204, XrefRangeEnd = 207225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x001CD4B0 File Offset: 0x001CB6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207225, XrefRangeEnd = 207234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x001CD4EC File Offset: 0x001CB6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207234, XrefRangeEnd = 207236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x001CD53C File Offset: 0x001CB73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207236, XrefRangeEnd = 207297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x001CD578 File Offset: 0x001CB778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207328, RefRangeEnd = 207330, XrefRangeStart = 207297, XrefRangeEnd = 207328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Player> GetClockwisePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x001CD5B8 File Offset: 0x001CB7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207330, XrefRangeEnd = 207351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x001CD5EC File Offset: 0x001CB7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207376, RefRangeEnd = 207378, XrefRangeStart = 207351, XrefRangeEnd = 207376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x001CD64C File Offset: 0x001CB84C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207378, RefRangeEnd = 207381, XrefRangeStart = 207378, XrefRangeEnd = 207378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Transform> GetPlayerCardPositions(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x001CD698 File Offset: 0x001CB898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207401, RefRangeEnd = 207402, XrefRangeStart = 207381, XrefRangeEnd = 207401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoundEnded(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x001CD6D8 File Offset: 0x001CB8D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207426, RefRangeEnd = 207429, XrefRangeStart = 207402, XrefRangeEnd = 207426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x001CD728 File Offset: 0x001CB928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207429, XrefRangeEnd = 207453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x001CD778 File Offset: 0x001CB978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207475, RefRangeEnd = 207477, XrefRangeStart = 207453, XrefRangeEnd = 207475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToDealerHand(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x001CD7BC File Offset: 0x001CB9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207477, RefRangeEnd = 207478, XrefRangeStart = 207477, XrefRangeEnd = 207477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr3) : null;
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x001CD808 File Offset: 0x001CBA08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207506, RefRangeEnd = 207509, XrefRangeStart = 207478, XrefRangeEnd = 207506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countFaceDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x001CD864 File Offset: 0x001CBA64
		[CallerCount(0)]
		public unsafe int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aceAsEleven;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x001CD8C0 File Offset: 0x001CBAC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207528, RefRangeEnd = 207533, XrefRangeStart = 207509, XrefRangeEnd = 207528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard DrawCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr3) : null;
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x001CD900 File Offset: 0x001CBB00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207566, RefRangeEnd = 207571, XrefRangeStart = 207533, XrefRangeEnd = 207566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x001CD934 File Offset: 0x001CBB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207593, RefRangeEnd = 207594, XrefRangeStart = 207571, XrefRangeEnd = 207593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x001CD968 File Offset: 0x001CBB68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207640, RefRangeEnd = 207643, XrefRangeStart = 207594, XrefRangeEnd = 207640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x001CD9B4 File Offset: 0x001CBBB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207643, RefRangeEnd = 207644, XrefRangeStart = 207643, XrefRangeEnd = 207643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x001CDA0C File Offset: 0x001CBC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207644, XrefRangeEnd = 207645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x001CDA48 File Offset: 0x001CBC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207645, XrefRangeEnd = 207667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x001CDA8C File Offset: 0x001CBC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207667, XrefRangeEnd = 207689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x001CDAD0 File Offset: 0x001CBCD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207711, RefRangeEnd = 207714, XrefRangeStart = 207689, XrefRangeEnd = 207711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x001CDB14 File Offset: 0x001CBD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207714, RefRangeEnd = 207716, XrefRangeStart = 207714, XrefRangeEnd = 207714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x001CDB54 File Offset: 0x001CBD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207716, XrefRangeEnd = 207731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x001CDB90 File Offset: 0x001CBD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207731, XrefRangeEnd = 207744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x001CDBCC File Offset: 0x001CBDCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207763, RefRangeEnd = 207764, XrefRangeStart = 207744, XrefRangeEnd = 207763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x001CDC00 File Offset: 0x001CBE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207764, XrefRangeEnd = 207816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x001CDC3C File Offset: 0x001CBE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207816, XrefRangeEnd = 207872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x001CDC78 File Offset: 0x001CBE78
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x001CDCB4 File Offset: 0x001CBEB4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x001CDCF0 File Offset: 0x001CBEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207872, XrefRangeEnd = 207890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x001CDD24 File Offset: 0x001CBF24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207947, RefRangeEnd = 207952, XrefRangeStart = 207890, XrefRangeEnd = 207947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x001CDD58 File Offset: 0x001CBF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207952, XrefRangeEnd = 207955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x001CDDA8 File Offset: 0x001CBFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207955, XrefRangeEnd = 207968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x001CDE08 File Offset: 0x001CC008
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207976, RefRangeEnd = 207978, XrefRangeStart = 207968, XrefRangeEnd = 207976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x001CDE68 File Offset: 0x001CC068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207978, XrefRangeEnd = 207984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x001CDEB8 File Offset: 0x001CC0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207984, XrefRangeEnd = 208003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x001CDEF8 File Offset: 0x001CC0F8
		[CallerCount(0)]
		public unsafe void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x001CDF38 File Offset: 0x001CC138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208003, XrefRangeEnd = 208005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x001CDF88 File Offset: 0x001CC188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208005, XrefRangeEnd = 208026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x001CDFD8 File Offset: 0x001CC1D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208050, RefRangeEnd = 208053, XrefRangeStart = 208026, XrefRangeEnd = 208050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x001CE028 File Offset: 0x001CC228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208053, XrefRangeEnd = 208059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x001CE078 File Offset: 0x001CC278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208059, XrefRangeEnd = 208078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x001CE0BC File Offset: 0x001CC2BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208102, RefRangeEnd = 208104, XrefRangeStart = 208078, XrefRangeEnd = 208102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x001CE100 File Offset: 0x001CC300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208104, XrefRangeEnd = 208108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x001CE150 File Offset: 0x001CC350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208108, XrefRangeEnd = 208126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x001CE184 File Offset: 0x001CC384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208126, XrefRangeEnd = 208128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x001CE1B8 File Offset: 0x001CC3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208128, XrefRangeEnd = 208132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x001CE208 File Offset: 0x001CC408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208132, XrefRangeEnd = 208151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x001CE24C File Offset: 0x001CC44C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208172, RefRangeEnd = 208175, XrefRangeStart = 208151, XrefRangeEnd = 208172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x001CE290 File Offset: 0x001CC490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208175, XrefRangeEnd = 208179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x001CE2E0 File Offset: 0x001CC4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208179, XrefRangeEnd = 208198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x001CE324 File Offset: 0x001CC524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207711, RefRangeEnd = 207714, XrefRangeStart = 207711, XrefRangeEnd = 207714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x001CE368 File Offset: 0x001CC568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208198, XrefRangeEnd = 208202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x001CE3CC File Offset: 0x001CC5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208202, XrefRangeEnd = 208221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x001CE410 File Offset: 0x001CC610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208242, RefRangeEnd = 208245, XrefRangeStart = 208221, XrefRangeEnd = 208242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x001CE454 File Offset: 0x001CC654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208245, XrefRangeEnd = 208249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x001CE4A4 File Offset: 0x001CC6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208272, RefRangeEnd = 208273, XrefRangeStart = 208249, XrefRangeEnd = 208272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x000305FE File Offset: 0x0002E7FE
		public BlackjackGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x001CE4E0 File Offset: 0x001CC6E0
		// (set) Token: 0x0600669B RID: 26267 RVA: 0x00030607 File Offset: 0x0002E807
		public unsafe static int BET_MINIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x001CE4FC File Offset: 0x001CC6FC
		// (set) Token: 0x0600669D RID: 26269 RVA: 0x00030615 File Offset: 0x0002E815
		public unsafe static int BET_MAXIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x001CE518 File Offset: 0x001CC718
		// (set) Token: 0x0600669F RID: 26271 RVA: 0x00030623 File Offset: 0x0002E823
		public unsafe static float PAYOUT_RATIO
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO, (void*)(&value));
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x001CE534 File Offset: 0x001CC734
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x00030631 File Offset: 0x0002E831
		public unsafe static float BLACKJACK_PAYOUT_RATIO
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO, (void*)(&value));
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x001CE550 File Offset: 0x001CC750
		// (set) Token: 0x060066A3 RID: 26275 RVA: 0x0003063F File Offset: 0x0002E83F
		public unsafe BlackjackGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x001CE578 File Offset: 0x001CC778
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x0003065A File Offset: 0x0002E85A
		public unsafe Player _PlayerTurn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x001CE5A8 File Offset: 0x001CC7A8
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x00030679 File Offset: 0x0002E879
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x001CE5D0 File Offset: 0x001CC7D0
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x00030694 File Offset: 0x0002E894
		public unsafe int _DealerScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x001CE5F8 File Offset: 0x001CC7F8
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x000306AF File Offset: 0x0002E8AF
		public unsafe int _LocalPlayerScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x001CE620 File Offset: 0x001CC820
		// (set) Token: 0x060066AD RID: 26285 RVA: 0x000306CA File Offset: 0x0002E8CA
		public unsafe bool _IsLocalPlayerBlackjack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x001CE648 File Offset: 0x001CC848
		// (set) Token: 0x060066AF RID: 26287 RVA: 0x000306E5 File Offset: 0x0002E8E5
		public unsafe bool _IsLocalPlayerBust_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x060066B0 RID: 26288 RVA: 0x001CE670 File Offset: 0x001CC870
		// (set) Token: 0x060066B1 RID: 26289 RVA: 0x00030700 File Offset: 0x0002E900
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x060066B2 RID: 26290 RVA: 0x001CE6A0 File Offset: 0x001CC8A0
		// (set) Token: 0x060066B3 RID: 26291 RVA: 0x0003071F File Offset: 0x0002E91F
		public unsafe Il2CppReferenceArray<Transform> DefaultCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x001CE6D0 File Offset: 0x001CC8D0
		// (set) Token: 0x060066B5 RID: 26293 RVA: 0x0003073E File Offset: 0x0002E93E
		public unsafe Il2CppReferenceArray<Transform> FocusedCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x060066B6 RID: 26294 RVA: 0x001CE700 File Offset: 0x001CC900
		// (set) Token: 0x060066B7 RID: 26295 RVA: 0x0003075D File Offset: 0x0002E95D
		public unsafe Il2CppReferenceArray<Transform> FinalCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x060066B8 RID: 26296 RVA: 0x001CE730 File Offset: 0x001CC930
		// (set) Token: 0x060066B9 RID: 26297 RVA: 0x0003077C File Offset: 0x0002E97C
		public unsafe Il2CppReferenceArray<Transform> Player1CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x060066BA RID: 26298 RVA: 0x001CE760 File Offset: 0x001CC960
		// (set) Token: 0x060066BB RID: 26299 RVA: 0x0003079B File Offset: 0x0002E99B
		public unsafe Il2CppReferenceArray<Transform> Player2CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x060066BC RID: 26300 RVA: 0x001CE790 File Offset: 0x001CC990
		// (set) Token: 0x060066BD RID: 26301 RVA: 0x000307BA File Offset: 0x0002E9BA
		public unsafe Il2CppReferenceArray<Transform> Player3CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x060066BE RID: 26302 RVA: 0x001CE7C0 File Offset: 0x001CC9C0
		// (set) Token: 0x060066BF RID: 26303 RVA: 0x000307D9 File Offset: 0x0002E9D9
		public unsafe Il2CppReferenceArray<Transform> Player4CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x060066C0 RID: 26304 RVA: 0x001CE7F0 File Offset: 0x001CC9F0
		// (set) Token: 0x060066C1 RID: 26305 RVA: 0x000307F8 File Offset: 0x0002E9F8
		public unsafe Il2CppReferenceArray<Transform> DealerCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x001CE820 File Offset: 0x001CCA20
		// (set) Token: 0x060066C3 RID: 26307 RVA: 0x00030817 File Offset: 0x0002EA17
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x060066C4 RID: 26308 RVA: 0x001CE850 File Offset: 0x001CCA50
		// (set) Token: 0x060066C5 RID: 26309 RVA: 0x00030836 File Offset: 0x0002EA36
		public unsafe List<PlayingCard> playStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x060066C6 RID: 26310 RVA: 0x001CE880 File Offset: 0x001CCA80
		// (set) Token: 0x060066C7 RID: 26311 RVA: 0x00030855 File Offset: 0x0002EA55
		public unsafe List<PlayingCard> player1Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x060066C8 RID: 26312 RVA: 0x001CE8B0 File Offset: 0x001CCAB0
		// (set) Token: 0x060066C9 RID: 26313 RVA: 0x00030874 File Offset: 0x0002EA74
		public unsafe List<PlayingCard> player2Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x060066CA RID: 26314 RVA: 0x001CE8E0 File Offset: 0x001CCAE0
		// (set) Token: 0x060066CB RID: 26315 RVA: 0x00030893 File Offset: 0x0002EA93
		public unsafe List<PlayingCard> player3Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x060066CC RID: 26316 RVA: 0x001CE910 File Offset: 0x001CCB10
		// (set) Token: 0x060066CD RID: 26317 RVA: 0x000308B2 File Offset: 0x0002EAB2
		public unsafe List<PlayingCard> player4Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x060066CE RID: 26318 RVA: 0x001CE940 File Offset: 0x001CCB40
		// (set) Token: 0x060066CF RID: 26319 RVA: 0x000308D1 File Offset: 0x0002EAD1
		public unsafe List<PlayingCard> dealerHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x060066D0 RID: 26320 RVA: 0x001CE970 File Offset: 0x001CCB70
		// (set) Token: 0x060066D1 RID: 26321 RVA: 0x000308F0 File Offset: 0x0002EAF0
		public unsafe List<PlayingCard.CardData> cardValuesInDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x060066D2 RID: 26322 RVA: 0x001CE9A0 File Offset: 0x001CCBA0
		// (set) Token: 0x060066D3 RID: 26323 RVA: 0x0003090F File Offset: 0x0002EB0F
		public unsafe List<PlayingCard.CardData> drawnCardsValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x060066D4 RID: 26324 RVA: 0x001CE9D0 File Offset: 0x001CCBD0
		// (set) Token: 0x060066D5 RID: 26325 RVA: 0x0003092E File Offset: 0x0002EB2E
		public unsafe Transform localFocusCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x001CEA00 File Offset: 0x001CCC00
		// (set) Token: 0x060066D7 RID: 26327 RVA: 0x0003094D File Offset: 0x0002EB4D
		public unsafe Transform localFinalCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x060066D8 RID: 26328 RVA: 0x001CEA30 File Offset: 0x001CCC30
		// (set) Token: 0x060066D9 RID: 26329 RVA: 0x0003096C File Offset: 0x0002EB6C
		public unsafe Action onLocalPlayerBetChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x060066DA RID: 26330 RVA: 0x001CEA60 File Offset: 0x001CCC60
		// (set) Token: 0x060066DB RID: 26331 RVA: 0x0003098B File Offset: 0x0002EB8B
		public unsafe Action onLocalPlayerExitRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x001CEA90 File Offset: 0x001CCC90
		// (set) Token: 0x060066DD RID: 26333 RVA: 0x000309AA File Offset: 0x0002EBAA
		public unsafe Action onInitialCardsDealt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x001CEAC0 File Offset: 0x001CCCC0
		// (set) Token: 0x060066DF RID: 26335 RVA: 0x000309C9 File Offset: 0x0002EBC9
		public unsafe Action onLocalPlayerReadyForInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x001CEAF0 File Offset: 0x001CCCF0
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x000309E8 File Offset: 0x0002EBE8
		public unsafe Action onLocalPlayerBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x001CEB20 File Offset: 0x001CCD20
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x00030A07 File Offset: 0x0002EC07
		public unsafe Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BlackjackGameController.EPayoutType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x001CEB50 File Offset: 0x001CCD50
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x00030A26 File Offset: 0x0002EC26
		public unsafe bool roundEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded)) = value;
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x001CEB78 File Offset: 0x001CCD78
		// (set) Token: 0x060066E7 RID: 26343 RVA: 0x00030A41 File Offset: 0x0002EC41
		public unsafe Coroutine gameRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x001CEBA8 File Offset: 0x001CCDA8
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x00030A60 File Offset: 0x0002EC60
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x001CEBD0 File Offset: 0x001CCDD0
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x00030A7B File Offset: 0x0002EC7B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040045FA RID: 17914
		private static readonly IntPtr NativeFieldInfoPtr_BET_MINIMUM;

		// Token: 0x040045FB RID: 17915
		private static readonly IntPtr NativeFieldInfoPtr_BET_MAXIMUM;

		// Token: 0x040045FC RID: 17916
		private static readonly IntPtr NativeFieldInfoPtr_PAYOUT_RATIO;

		// Token: 0x040045FD RID: 17917
		private static readonly IntPtr NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO;

		// Token: 0x040045FE RID: 17918
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x040045FF RID: 17919
		private static readonly IntPtr NativeFieldInfoPtr__PlayerTurn_k__BackingField;

		// Token: 0x04004600 RID: 17920
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x04004601 RID: 17921
		private static readonly IntPtr NativeFieldInfoPtr__DealerScore_k__BackingField;

		// Token: 0x04004602 RID: 17922
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerScore_k__BackingField;

		// Token: 0x04004603 RID: 17923
		private static readonly IntPtr NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField;

		// Token: 0x04004604 RID: 17924
		private static readonly IntPtr NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField;

		// Token: 0x04004605 RID: 17925
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x04004606 RID: 17926
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCardPositions;

		// Token: 0x04004607 RID: 17927
		private static readonly IntPtr NativeFieldInfoPtr_FocusedCameraTransforms;

		// Token: 0x04004608 RID: 17928
		private static readonly IntPtr NativeFieldInfoPtr_FinalCameraTransforms;

		// Token: 0x04004609 RID: 17929
		private static readonly IntPtr NativeFieldInfoPtr_Player1CardPositions;

		// Token: 0x0400460A RID: 17930
		private static readonly IntPtr NativeFieldInfoPtr_Player2CardPositions;

		// Token: 0x0400460B RID: 17931
		private static readonly IntPtr NativeFieldInfoPtr_Player3CardPositions;

		// Token: 0x0400460C RID: 17932
		private static readonly IntPtr NativeFieldInfoPtr_Player4CardPositions;

		// Token: 0x0400460D RID: 17933
		private static readonly IntPtr NativeFieldInfoPtr_DealerCardPositions;

		// Token: 0x0400460E RID: 17934
		private static readonly IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x0400460F RID: 17935
		private static readonly IntPtr NativeFieldInfoPtr_playStack;

		// Token: 0x04004610 RID: 17936
		private static readonly IntPtr NativeFieldInfoPtr_player1Hand;

		// Token: 0x04004611 RID: 17937
		private static readonly IntPtr NativeFieldInfoPtr_player2Hand;

		// Token: 0x04004612 RID: 17938
		private static readonly IntPtr NativeFieldInfoPtr_player3Hand;

		// Token: 0x04004613 RID: 17939
		private static readonly IntPtr NativeFieldInfoPtr_player4Hand;

		// Token: 0x04004614 RID: 17940
		private static readonly IntPtr NativeFieldInfoPtr_dealerHand;

		// Token: 0x04004615 RID: 17941
		private static readonly IntPtr NativeFieldInfoPtr_cardValuesInDeck;

		// Token: 0x04004616 RID: 17942
		private static readonly IntPtr NativeFieldInfoPtr_drawnCardsValues;

		// Token: 0x04004617 RID: 17943
		private static readonly IntPtr NativeFieldInfoPtr_localFocusCameraTransform;

		// Token: 0x04004618 RID: 17944
		private static readonly IntPtr NativeFieldInfoPtr_localFinalCameraTransform;

		// Token: 0x04004619 RID: 17945
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x0400461A RID: 17946
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x0400461B RID: 17947
		private static readonly IntPtr NativeFieldInfoPtr_onInitialCardsDealt;

		// Token: 0x0400461C RID: 17948
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerReadyForInput;

		// Token: 0x0400461D RID: 17949
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBust;

		// Token: 0x0400461E RID: 17950
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerRoundCompleted;

		// Token: 0x0400461F RID: 17951
		private static readonly IntPtr NativeFieldInfoPtr_roundEnded;

		// Token: 0x04004620 RID: 17952
		private static readonly IntPtr NativeFieldInfoPtr_gameRoutine;

		// Token: 0x04004621 RID: 17953
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004622 RID: 17954
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004623 RID: 17955
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x04004624 RID: 17956
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x04004625 RID: 17957
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0;

		// Token: 0x04004626 RID: 17958
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0;

		// Token: 0x04004627 RID: 17959
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x04004628 RID: 17960
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0;

		// Token: 0x04004629 RID: 17961
		private static readonly IntPtr NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0;

		// Token: 0x0400462A RID: 17962
		private static readonly IntPtr NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0;

		// Token: 0x0400462B RID: 17963
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0;

		// Token: 0x0400462C RID: 17964
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0;

		// Token: 0x0400462D RID: 17965
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0;

		// Token: 0x0400462E RID: 17966
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0;

		// Token: 0x0400462F RID: 17967
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0;

		// Token: 0x04004630 RID: 17968
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0;

		// Token: 0x04004631 RID: 17969
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x04004632 RID: 17970
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004633 RID: 17971
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x04004634 RID: 17972
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_1;

		// Token: 0x04004635 RID: 17973
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x04004636 RID: 17974
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x04004637 RID: 17975
		private static readonly IntPtr NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0;

		// Token: 0x04004638 RID: 17976
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x04004639 RID: 17977
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x0400463A RID: 17978
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0;

		// Token: 0x0400463B RID: 17979
		private static readonly IntPtr NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0;

		// Token: 0x0400463C RID: 17980
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0;

		// Token: 0x0400463D RID: 17981
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0;

		// Token: 0x0400463E RID: 17982
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0;

		// Token: 0x0400463F RID: 17983
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0;

		// Token: 0x04004640 RID: 17984
		private static readonly IntPtr NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0;

		// Token: 0x04004641 RID: 17985
		private static readonly IntPtr NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0;

		// Token: 0x04004642 RID: 17986
		private static readonly IntPtr NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0;

		// Token: 0x04004643 RID: 17987
		private static readonly IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x04004644 RID: 17988
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04004645 RID: 17989
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0;

		// Token: 0x04004646 RID: 17990
		private static readonly IntPtr NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0;

		// Token: 0x04004647 RID: 17991
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x04004648 RID: 17992
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x04004649 RID: 17993
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400464A RID: 17994
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400464B RID: 17995
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x0400464C RID: 17996
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x0400464D RID: 17997
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x0400464E RID: 17998
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0;

		// Token: 0x0400464F RID: 17999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004650 RID: 18000
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004651 RID: 18001
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004652 RID: 18002
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004653 RID: 18003
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0;

		// Token: 0x04004654 RID: 18004
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0;

		// Token: 0x04004655 RID: 18005
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004656 RID: 18006
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x04004657 RID: 18007
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x04004658 RID: 18008
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004659 RID: 18009
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400465A RID: 18010
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400465B RID: 18011
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400465C RID: 18012
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x0400465D RID: 18013
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x0400465E RID: 18014
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400465F RID: 18015
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x04004660 RID: 18016
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x04004661 RID: 18017
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004662 RID: 18018
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x04004663 RID: 18019
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x04004664 RID: 18020
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004665 RID: 18021
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004666 RID: 18022
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004667 RID: 18023
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004668 RID: 18024
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004669 RID: 18025
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400466A RID: 18026
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400466B RID: 18027
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400466C RID: 18028
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400466D RID: 18029
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400466E RID: 18030
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A38 RID: 2616
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04008C0A RID: 35850
			WaitingForPlayers,
			// Token: 0x04008C0B RID: 35851
			Dealing,
			// Token: 0x04008C0C RID: 35852
			PlayerTurn,
			// Token: 0x04008C0D RID: 35853
			DealerTurn,
			// Token: 0x04008C0E RID: 35854
			Ending
		}

		// Token: 0x02000A39 RID: 2617
		[OriginalName("Assembly-CSharp.dll", "", "EPayoutType")]
		public enum EPayoutType
		{
			// Token: 0x04008C10 RID: 35856
			None,
			// Token: 0x04008C11 RID: 35857
			Blackjack,
			// Token: 0x04008C12 RID: 35858
			Win,
			// Token: 0x04008C13 RID: 35859
			Push
		}

		// Token: 0x02000A3A RID: 2618
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFAE RID: 53166 RVA: 0x0031DD38 File Offset: 0x0031BF38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "clockwisePlayers");
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676315);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676316);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676317);
			}

			// Token: 0x0600CFAF RID: 53167 RVA: 0x0031DDC8 File Offset: 0x0031BFC8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFB0 RID: 53168 RVA: 0x0031DE04 File Offset: 0x0031C004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207153, XrefRangeEnd = 207158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CFB1 RID: 53169 RVA: 0x0031DE44 File Offset: 0x0031C044
			[CallerCount(0)]
			public unsafe bool _StartGame_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFB2 RID: 53170 RVA: 0x000650B7 File Offset: 0x000632B7
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004087 RID: 16519
			// (get) Token: 0x0600CFB3 RID: 53171 RVA: 0x0031DE80 File Offset: 0x0031C080
			// (set) Token: 0x0600CFB4 RID: 53172 RVA: 0x000650C0 File Offset: 0x000632C0
			public unsafe List<Player> clockwisePlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004088 RID: 16520
			// (get) Token: 0x0600CFB5 RID: 53173 RVA: 0x0031DEB0 File Offset: 0x0031C0B0
			// (set) Token: 0x0600CFB6 RID: 53174 RVA: 0x000650DF File Offset: 0x000632DF
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C14 RID: 35860
			private static readonly IntPtr NativeFieldInfoPtr_clockwisePlayers;

			// Token: 0x04008C15 RID: 35861
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C16 RID: 35862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C17 RID: 35863
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008C18 RID: 35864
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0;

			// Token: 0x02000C57 RID: 3159
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0+<<StartGame>g__GameRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E370 RID: 58224 RVA: 0x00356134 File Offset: 0x00354334
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "<<StartGame>g__GameRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>8__1");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<drawSpacing>5__2");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<dealerTurn>5__3");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<i>5__4");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<playerIndex>5__5");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<turn>5__6");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676318);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676319);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676320);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676321);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676322);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676323);
				}

				// Token: 0x0600E371 RID: 58225 RVA: 0x0035628C File Offset: 0x0035448C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E372 RID: 58226 RVA: 0x003562D4 File Offset: 0x003544D4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E373 RID: 58227 RVA: 0x00356308 File Offset: 0x00354508
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206889, XrefRangeEnd = 207148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700469A RID: 18074
				// (get) Token: 0x0600E374 RID: 58228 RVA: 0x00356344 File Offset: 0x00354544
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E375 RID: 58229 RVA: 0x00356384 File Offset: 0x00354584
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207148, XrefRangeEnd = 207153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700469B RID: 18075
				// (get) Token: 0x0600E376 RID: 58230 RVA: 0x003563B8 File Offset: 0x003545B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E377 RID: 58231 RVA: 0x0006ED89 File Offset: 0x0006CF89
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004691 RID: 18065
				// (get) Token: 0x0600E378 RID: 58232 RVA: 0x003563F8 File Offset: 0x003545F8
				// (set) Token: 0x0600E379 RID: 58233 RVA: 0x0006ED92 File Offset: 0x0006CF92
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004692 RID: 18066
				// (get) Token: 0x0600E37A RID: 58234 RVA: 0x00356420 File Offset: 0x00354620
				// (set) Token: 0x0600E37B RID: 58235 RVA: 0x0006EDAD File Offset: 0x0006CFAD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004693 RID: 18067
				// (get) Token: 0x0600E37C RID: 58236 RVA: 0x00356450 File Offset: 0x00354650
				// (set) Token: 0x0600E37D RID: 58237 RVA: 0x0006EDCC File Offset: 0x0006CFCC
				public unsafe BlackjackGameController.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004694 RID: 18068
				// (get) Token: 0x0600E37E RID: 58238 RVA: 0x00356480 File Offset: 0x00354680
				// (set) Token: 0x0600E37F RID: 58239 RVA: 0x0006EDEB File Offset: 0x0006CFEB
				public unsafe BlackjackGameController.__c__DisplayClass70_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004695 RID: 18069
				// (get) Token: 0x0600E380 RID: 58240 RVA: 0x003564B0 File Offset: 0x003546B0
				// (set) Token: 0x0600E381 RID: 58241 RVA: 0x0006EE0A File Offset: 0x0006D00A
				public unsafe float _drawSpacing_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2)) = value;
					}
				}

				// Token: 0x17004696 RID: 18070
				// (get) Token: 0x0600E382 RID: 58242 RVA: 0x003564D8 File Offset: 0x003546D8
				// (set) Token: 0x0600E383 RID: 58243 RVA: 0x0006EE25 File Offset: 0x0006D025
				public unsafe int _dealerTurn_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3)) = value;
					}
				}

				// Token: 0x17004697 RID: 18071
				// (get) Token: 0x0600E384 RID: 58244 RVA: 0x00356500 File Offset: 0x00354700
				// (set) Token: 0x0600E385 RID: 58245 RVA: 0x0006EE40 File Offset: 0x0006D040
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x17004698 RID: 18072
				// (get) Token: 0x0600E386 RID: 58246 RVA: 0x00356528 File Offset: 0x00354728
				// (set) Token: 0x0600E387 RID: 58247 RVA: 0x0006EE5B File Offset: 0x0006D05B
				public unsafe int _playerIndex_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5)) = value;
					}
				}

				// Token: 0x17004699 RID: 18073
				// (get) Token: 0x0600E388 RID: 58248 RVA: 0x00356550 File Offset: 0x00354750
				// (set) Token: 0x0600E389 RID: 58249 RVA: 0x0006EE76 File Offset: 0x0006D076
				public unsafe int _turn_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6)) = value;
					}
				}

				// Token: 0x04009832 RID: 38962
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009833 RID: 38963
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009834 RID: 38964
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009835 RID: 38965
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x04009836 RID: 38966
				private static readonly IntPtr NativeFieldInfoPtr__drawSpacing_5__2;

				// Token: 0x04009837 RID: 38967
				private static readonly IntPtr NativeFieldInfoPtr__dealerTurn_5__3;

				// Token: 0x04009838 RID: 38968
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009839 RID: 38969
				private static readonly IntPtr NativeFieldInfoPtr__playerIndex_5__5;

				// Token: 0x0400983A RID: 38970
				private static readonly IntPtr NativeFieldInfoPtr__turn_5__6;

				// Token: 0x0400983B RID: 38971
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400983C RID: 38972
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400983D RID: 38973
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400983E RID: 38974
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400983F RID: 38975
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009840 RID: 38976
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A3B RID: 2619
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CFB7 RID: 53175 RVA: 0x0031DEE0 File Offset: 0x0031C0E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "player");
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "CS$<>8__locals1");
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "<>9__2");
				BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, 100676324);
				BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, 100676325);
			}

			// Token: 0x0600CFB8 RID: 53176 RVA: 0x0031DF70 File Offset: 0x0031C170
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFB9 RID: 53177 RVA: 0x0031DFAC File Offset: 0x0031C1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207158, XrefRangeEnd = 207165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFBA RID: 53178 RVA: 0x000650FE File Offset: 0x000632FE
			public __c__DisplayClass70_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004089 RID: 16521
			// (get) Token: 0x0600CFBB RID: 53179 RVA: 0x0031DFE8 File Offset: 0x0031C1E8
			// (set) Token: 0x0600CFBC RID: 53180 RVA: 0x00065107 File Offset: 0x00063307
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700408A RID: 16522
			// (get) Token: 0x0600CFBD RID: 53181 RVA: 0x0031E018 File Offset: 0x0031C218
			// (set) Token: 0x0600CFBE RID: 53182 RVA: 0x00065126 File Offset: 0x00063326
			public unsafe BlackjackGameController.__c__DisplayClass70_0 field_Public___c__DisplayClass70_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700408B RID: 16523
			// (get) Token: 0x0600CFBF RID: 53183 RVA: 0x0031E048 File Offset: 0x0031C248
			// (set) Token: 0x0600CFC0 RID: 53184 RVA: 0x00065145 File Offset: 0x00063345
			public unsafe Func<bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C19 RID: 35865
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04008C1A RID: 35866
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0;

			// Token: 0x04008C1B RID: 35867
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04008C1C RID: 35868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C1D RID: 35869
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0;
		}

		// Token: 0x02000A3C RID: 2620
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFC1 RID: 53185 RVA: 0x0031E078 File Offset: 0x0031C278
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, 100676326);
				BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, 100676327);
			}

			// Token: 0x0600CFC2 RID: 53186 RVA: 0x0031E0E0 File Offset: 0x0031C2E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFC3 RID: 53187 RVA: 0x0031E11C File Offset: 0x0031C31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207165, XrefRangeEnd = 207167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToPlayerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFC4 RID: 53188 RVA: 0x00065164 File Offset: 0x00063364
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408C RID: 16524
			// (get) Token: 0x0600CFC5 RID: 53189 RVA: 0x0031E16C File Offset: 0x0031C36C
			// (set) Token: 0x0600CFC6 RID: 53190 RVA: 0x0006516D File Offset: 0x0006336D
			public unsafe string cardID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008C1E RID: 35870
			private static readonly IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04008C1F RID: 35871
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C20 RID: 35872
			private static readonly IntPtr NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000A3D RID: 2621
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFC7 RID: 53191 RVA: 0x0031E194 File Offset: 0x0031C394
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, 100676328);
				BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, 100676329);
			}

			// Token: 0x0600CFC8 RID: 53192 RVA: 0x0031E1FC File Offset: 0x0031C3FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFC9 RID: 53193 RVA: 0x0031E238 File Offset: 0x0031C438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToDealerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFCA RID: 53194 RVA: 0x0006518C File Offset: 0x0006338C
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408D RID: 16525
			// (get) Token: 0x0600CFCB RID: 53195 RVA: 0x0031E288 File Offset: 0x0031C488
			// (set) Token: 0x0600CFCC RID: 53196 RVA: 0x00065195 File Offset: 0x00063395
			public unsafe string cardID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008C21 RID: 35873
			private static readonly IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04008C22 RID: 35874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C23 RID: 35875
			private static readonly IntPtr NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000A3E RID: 2622
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFCD RID: 53197 RVA: 0x0031E2B0 File Offset: 0x0031C4B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "cameraDelay");
				BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, 100676330);
				BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, 100676331);
			}

			// Token: 0x0600CFCE RID: 53198 RVA: 0x0031E32C File Offset: 0x0031C52C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFCF RID: 53199 RVA: 0x0031E368 File Offset: 0x0031C568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207185, XrefRangeEnd = 207190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CFD0 RID: 53200 RVA: 0x000651B4 File Offset: 0x000633B4
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408E RID: 16526
			// (get) Token: 0x0600CFD1 RID: 53201 RVA: 0x0031E3A8 File Offset: 0x0031C5A8
			// (set) Token: 0x0600CFD2 RID: 53202 RVA: 0x000651BD File Offset: 0x000633BD
			public unsafe float cameraDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x1700408F RID: 16527
			// (get) Token: 0x0600CFD3 RID: 53203 RVA: 0x0031E3D0 File Offset: 0x0031C5D0
			// (set) Token: 0x0600CFD4 RID: 53204 RVA: 0x000651D8 File Offset: 0x000633D8
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C24 RID: 35876
			private static readonly IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04008C25 RID: 35877
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C26 RID: 35878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C27 RID: 35879
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C58 RID: 3160
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass83_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E38A RID: 58250 RVA: 0x00356578 File Offset: 0x00354778
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676332);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676333);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676334);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676335);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676336);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676337);
				}

				// Token: 0x0600E38B RID: 58251 RVA: 0x00356658 File Offset: 0x00354858
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E38C RID: 58252 RVA: 0x003566A0 File Offset: 0x003548A0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E38D RID: 58253 RVA: 0x003566D4 File Offset: 0x003548D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207167, XrefRangeEnd = 207180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700469F RID: 18079
				// (get) Token: 0x0600E38E RID: 58254 RVA: 0x00356710 File Offset: 0x00354910
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E38F RID: 58255 RVA: 0x00356750 File Offset: 0x00354950
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207180, XrefRangeEnd = 207185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046A0 RID: 18080
				// (get) Token: 0x0600E390 RID: 58256 RVA: 0x00356784 File Offset: 0x00354984
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E391 RID: 58257 RVA: 0x0006EE91 File Offset: 0x0006D091
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700469C RID: 18076
				// (get) Token: 0x0600E392 RID: 58258 RVA: 0x003567C4 File Offset: 0x003549C4
				// (set) Token: 0x0600E393 RID: 58259 RVA: 0x0006EE9A File Offset: 0x0006D09A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700469D RID: 18077
				// (get) Token: 0x0600E394 RID: 58260 RVA: 0x003567EC File Offset: 0x003549EC
				// (set) Token: 0x0600E395 RID: 58261 RVA: 0x0006EEB5 File Offset: 0x0006D0B5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700469E RID: 18078
				// (get) Token: 0x0600E396 RID: 58262 RVA: 0x0035681C File Offset: 0x00354A1C
				// (set) Token: 0x0600E397 RID: 58263 RVA: 0x0006EED4 File Offset: 0x0006D0D4
				public unsafe BlackjackGameController.__c__DisplayClass83_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass83_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009841 RID: 38977
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009842 RID: 38978
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009843 RID: 38979
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009844 RID: 38980
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009845 RID: 38981
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009846 RID: 38982
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009847 RID: 38983
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009848 RID: 38984
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009849 RID: 38985
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
