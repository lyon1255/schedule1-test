using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040C RID: 1036
	public class Customer : NetworkBehaviour
	{
		// Token: 0x060058AD RID: 22701 RVA: 0x0019D4B4 File Offset: 0x0019B6B4
		// Note: this type is marked as 'beforefieldinit'.
		static Customer()
		{
			Il2CppClassPointerStore<Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer>.NativeClassPtr);
			Customer.NativeFieldInfoPtr_onCustomerUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onCustomerUnlocked");
			Customer.NativeFieldInfoPtr_UnlockedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "UnlockedCustomers");
			Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AFFINITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PROPERTY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "QUALITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_REJECTED_RELATIONSHIP_CHANGE");
			Customer.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEBUG");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_ADDICTION");
			Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_CHANCE_PER_DAY_MAX");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_COOLDOWN");
			Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MAX_COOLDOWN");
			Customer.NativeFieldInfoPtr_DEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_COOLDOWN");
			Customer.NativeFieldInfoPtr_PlayerAcceptMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerAcceptMessages");
			Customer.NativeFieldInfoPtr_PlayerRejectMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerRejectMessages");
			Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_ATTENDANCE_TOLERANCE");
			Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "OFFER_EXPIRY_TIME_MINS");
			Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_ORDER_APPEAL");
			Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ADDICTION_DRAIN_PER_DAY");
			Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "SAMPLE_REQUIRES_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_offeredContractInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offeredContractInfo");
			Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedContractTime>k__BackingField");
			Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentContract>k__BackingField");
			Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<IsAwaitingDelivery>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealCompleted>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSincePlayerApproached>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceInstantDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedDeals>k__BackingField");
			Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CompletedDeliveries>k__BackingField");
			Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<NPC>k__BackingField");
			Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<AssignedDealer>k__BackingField");
			Customer.NativeFieldInfoPtr_DealSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DealSignal");
			Customer.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AvailableInDemo");
			Customer.NativeFieldInfoPtr_customerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "customerData");
			Customer.NativeFieldInfoPtr_DefaultDeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DefaultDeliveryLocation");
			Customer.NativeFieldInfoPtr_CanRecommendFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CanRecommendFriends");
			Customer.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onUnlocked");
			Customer.NativeFieldInfoPtr_onDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onDealCompleted");
			Customer.NativeFieldInfoPtr_onContractAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onContractAssigned");
			Customer.NativeFieldInfoPtr_awaitingSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingSample");
			Customer.NativeFieldInfoPtr_sampleChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleChoice");
			Customer.NativeFieldInfoPtr_completeContractChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "completeContractChoice");
			Customer.NativeFieldInfoPtr_offerDealChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offerDealChoice");
			Customer.NativeFieldInfoPtr_awaitingDealGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingDealGreeting");
			Customer.NativeFieldInfoPtr_minsSinceUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "minsSinceUnlocked");
			Customer.NativeFieldInfoPtr_sampleOfferedToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleOfferedToday");
			Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<potentialCustomerPoI>k__BackingField");
			Customer.NativeFieldInfoPtr_currentAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "currentAffinityData");
			Customer.NativeFieldInfoPtr_pendingInstantDeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "pendingInstantDeal");
			Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Customer.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasChanged>k__BackingField");
			Customer.NativeFieldInfoPtr_consumedSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "consumedSample");
			Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674501);
			Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674502);
			Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674503);
			Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674504);
			Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674505);
			Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674506);
			Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674507);
			Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674508);
			Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674509);
			Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674510);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674511);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674512);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674513);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674514);
			Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674515);
			Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674516);
			Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674517);
			Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674518);
			Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674519);
			Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674520);
			Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674521);
			Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674522);
			Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674523);
			Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674524);
			Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674525);
			Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674526);
			Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674527);
			Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674528);
			Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674529);
			Customer.NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674530);
			Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674531);
			Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674532);
			Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674533);
			Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674534);
			Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674535);
			Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674536);
			Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674537);
			Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674538);
			Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674539);
			Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674540);
			Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674541);
			Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674542);
			Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674543);
			Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674544);
			Customer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674545);
			Customer.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674546);
			Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674547);
			Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674548);
			Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674549);
			Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674550);
			Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674551);
			Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674552);
			Customer.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674553);
			Customer.NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674554);
			Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674555);
			Customer.NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674556);
			Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674557);
			Customer.NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674558);
			Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674559);
			Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674560);
			Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674561);
			Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674562);
			Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674563);
			Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674564);
			Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674565);
			Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674566);
			Customer.NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674567);
			Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674568);
			Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674569);
			Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674570);
			Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674571);
			Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674572);
			Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674573);
			Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674574);
			Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674575);
			Customer.NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674576);
			Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674577);
			Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674578);
			Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674579);
			Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674580);
			Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674581);
			Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674582);
			Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674583);
			Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674584);
			Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674585);
			Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674586);
			Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674587);
			Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674588);
			Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674589);
			Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674590);
			Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674591);
			Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674592);
			Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674593);
			Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674594);
			Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674595);
			Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674596);
			Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674597);
			Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674598);
			Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674599);
			Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674600);
			Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674601);
			Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674602);
			Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674603);
			Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674604);
			Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674605);
			Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674606);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674607);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674608);
			Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674609);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674610);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674611);
			Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674612);
			Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674613);
			Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674614);
			Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674615);
			Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674616);
			Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674617);
			Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674618);
			Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674619);
			Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674620);
			Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674621);
			Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674622);
			Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674623);
			Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674624);
			Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674625);
			Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674626);
			Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674627);
			Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674628);
			Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674629);
			Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674630);
			Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674631);
			Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674632);
			Customer.NativeMethodInfoPtr_EndWait_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674633);
			Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674634);
			Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674635);
			Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674636);
			Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674637);
			Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674638);
			Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674639);
			Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674640);
			Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674641);
			Customer.NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674643);
			Customer.NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674644);
			Customer.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674645);
			Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674646);
			Customer.NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674647);
			Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674648);
			Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674649);
			Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674650);
			Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674651);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674652);
			Customer.NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674653);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674654);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674655);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674656);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674657);
			Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674658);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674659);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674660);
			Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674661);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674662);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674663);
			Customer.NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674664);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674665);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674666);
			Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674667);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674668);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674669);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674670);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674671);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674672);
			Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674673);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674674);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674675);
			Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674676);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674677);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674678);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674679);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674680);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674681);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674682);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674683);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674684);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674685);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674686);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674687);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674688);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674689);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674690);
			Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674691);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674692);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674693);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674694);
			Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674695);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674696);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674697);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674698);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674699);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674700);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674701);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674702);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674703);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674704);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674705);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674706);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674707);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674708);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674709);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674710);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674711);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674712);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674713);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674714);
			Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674715);
			Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674716);
			Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674717);
			Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674718);
			Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674719);
			Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674720);
			Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674721);
			Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674722);
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x0019EB28 File Offset: 0x0019CD28
		// (set) Token: 0x060058AF RID: 22703 RVA: 0x0019EB64 File Offset: 0x0019CD64
		public unsafe float CurrentAddiction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86619, RefRangeEnd = 86621, XrefRangeStart = 86619, XrefRangeEnd = 86621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 186455, RefRangeEnd = 186459, XrefRangeStart = 186448, XrefRangeEnd = 186455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x060058B0 RID: 22704 RVA: 0x0019EBA4 File Offset: 0x0019CDA4
		// (set) Token: 0x060058B1 RID: 22705 RVA: 0x0019EBE4 File Offset: 0x0019CDE4
		public unsafe ContractInfo OfferedContractInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x060058B2 RID: 22706 RVA: 0x0019EC28 File Offset: 0x0019CE28
		// (set) Token: 0x060058B3 RID: 22707 RVA: 0x0019EC64 File Offset: 0x0019CE64
		public unsafe GameDateTime OfferedContractTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x060058B4 RID: 22708 RVA: 0x0019ECA4 File Offset: 0x0019CEA4
		// (set) Token: 0x060058B5 RID: 22709 RVA: 0x0019ECE4 File Offset: 0x0019CEE4
		public unsafe Contract CurrentContract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x0019ED28 File Offset: 0x0019CF28
		// (set) Token: 0x060058B7 RID: 22711 RVA: 0x0019ED64 File Offset: 0x0019CF64
		public unsafe bool IsAwaitingDelivery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x0019EDA4 File Offset: 0x0019CFA4
		// (set) Token: 0x060058B9 RID: 22713 RVA: 0x0019EDE0 File Offset: 0x0019CFE0
		public unsafe int TimeSinceLastDealCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060058BA RID: 22714 RVA: 0x0019EE20 File Offset: 0x0019D020
		// (set) Token: 0x060058BB RID: 22715 RVA: 0x0019EE5C File Offset: 0x0019D05C
		public unsafe int TimeSinceLastDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060058BC RID: 22716 RVA: 0x0019EE9C File Offset: 0x0019D09C
		// (set) Token: 0x060058BD RID: 22717 RVA: 0x0019EED8 File Offset: 0x0019D0D8
		public unsafe int TimeSincePlayerApproached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x0019EF18 File Offset: 0x0019D118
		// (set) Token: 0x060058BF RID: 22719 RVA: 0x0019EF54 File Offset: 0x0019D154
		public unsafe int TimeSinceInstantDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060058C0 RID: 22720 RVA: 0x0019EF94 File Offset: 0x0019D194
		// (set) Token: 0x060058C1 RID: 22721 RVA: 0x0019EFD0 File Offset: 0x0019D1D0
		public unsafe int OfferedDeals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0019F010 File Offset: 0x0019D210
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x0019F04C File Offset: 0x0019D24C
		public unsafe int CompletedDeliveries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060058C4 RID: 22724 RVA: 0x0019F08C File Offset: 0x0019D28C
		// (set) Token: 0x060058C5 RID: 22725 RVA: 0x0019F0C8 File Offset: 0x0019D2C8
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 186466, RefRangeEnd = 186469, XrefRangeStart = 186459, XrefRangeEnd = 186466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x0019F108 File Offset: 0x0019D308
		// (set) Token: 0x060058C7 RID: 22727 RVA: 0x0019F148 File Offset: 0x0019D348
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0019F18C File Offset: 0x0019D38C
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x0019F1CC File Offset: 0x0019D3CC
		public unsafe Dealer AssignedDealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x0019F210 File Offset: 0x0019D410
		public unsafe CustomerData CustomerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr3) : null;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x0019F250 File Offset: 0x0019D450
		public unsafe List<ProductDefinition> OrderableProducts
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 186478, RefRangeEnd = 186502, XrefRangeStart = 186469, XrefRangeEnd = 186478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x0019F290 File Offset: 0x0019D490
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x0019F2D0 File Offset: 0x0019D4D0
		// (set) Token: 0x060058CE RID: 22734 RVA: 0x0019F310 File Offset: 0x0019D510
		public unsafe NPCPoI potentialCustomerPoI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060058CF RID: 22735 RVA: 0x0019F354 File Offset: 0x0019D554
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186502, XrefRangeEnd = 186504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x0019F38C File Offset: 0x0019D58C
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186504, XrefRangeEnd = 186506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x0019F3C4 File Offset: 0x0019D5C4
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x0019F404 File Offset: 0x0019D604
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060058D3 RID: 22739 RVA: 0x0019F440 File Offset: 0x0019D640
		// (set) Token: 0x060058D4 RID: 22740 RVA: 0x0019F480 File Offset: 0x0019D680
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166179, RefRangeEnd = 166194, XrefRangeStart = 166179, XrefRangeEnd = 166194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186506, XrefRangeEnd = 186507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x0019F4C4 File Offset: 0x0019D6C4
		// (set) Token: 0x060058D6 RID: 22742 RVA: 0x0019F504 File Offset: 0x0019D704
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186507, XrefRangeEnd = 186508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x0019F548 File Offset: 0x0019D748
		// (set) Token: 0x060058D8 RID: 22744 RVA: 0x0019F584 File Offset: 0x0019D784
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x0019F5C4 File Offset: 0x0019D7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186508, XrefRangeEnd = 186509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x0019F600 File Offset: 0x0019D800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186509, XrefRangeEnd = 186564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0019F63C File Offset: 0x0019D83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186564, XrefRangeEnd = 186645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x0019F670 File Offset: 0x0019D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186645, XrefRangeEnd = 186647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x0019F6AC File Offset: 0x0019D8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186647, XrefRangeEnd = 186671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x0019F6FC File Offset: 0x0019D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186671, XrefRangeEnd = 186679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x0019F730 File Offset: 0x0019D930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186782, RefRangeEnd = 186783, XrefRangeStart = 186679, XrefRangeEnd = 186782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x0019F764 File Offset: 0x0019D964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186813, RefRangeEnd = 186814, XrefRangeStart = 186783, XrefRangeEnd = 186813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x0019F798 File Offset: 0x0019D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186814, XrefRangeEnd = 186820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x0019F7D4 File Offset: 0x0019D9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186820, XrefRangeEnd = 186897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x0019F810 File Offset: 0x0019DA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186897, XrefRangeEnd = 186899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x0019F84C File Offset: 0x0019DA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186956, RefRangeEnd = 186957, XrefRangeStart = 186899, XrefRangeEnd = 186956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDealAttendance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x0019F880 File Offset: 0x0019DA80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186969, RefRangeEnd = 186972, XrefRangeStart = 186957, XrefRangeEnd = 186969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x0019F8E0 File Offset: 0x0019DAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186991, RefRangeEnd = 186992, XrefRangeStart = 186972, XrefRangeEnd = 186991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOfferExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x0019F914 File Offset: 0x0019DB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187111, RefRangeEnd = 187112, XrefRangeStart = 186992, XrefRangeEnd = 187111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo CheckContractGeneration(bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x0019F960 File Offset: 0x0019DB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187198, RefRangeEnd = 187199, XrefRangeStart = 187112, XrefRangeEnd = 187198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetWeightedRandomProduct(out float appeal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &appeal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x0019F9AC File Offset: 0x0019DBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187199, XrefRangeEnd = 187222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x0019FA04 File Offset: 0x0019DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187222, XrefRangeEnd = 187223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHasBeenRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x0019FA38 File Offset: 0x0019DC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187223, XrefRangeEnd = 187265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferContract(ContractInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x0019FA88 File Offset: 0x0019DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187265, XrefRangeEnd = 187285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x0019FAD8 File Offset: 0x0019DCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187285, XrefRangeEnd = 187306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExpireOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x0019FB14 File Offset: 0x0019DD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187306, XrefRangeEnd = 187318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignContract(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x0019FB64 File Offset: 0x0019DD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187318, XrefRangeEnd = 187372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offerMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAccept;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canReject;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCounterOffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x0019FBF0 File Offset: 0x0019DDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187372, XrefRangeEnd = 187393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x0019FC24 File Offset: 0x0019DE24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187414, RefRangeEnd = 187419, XrefRangeStart = 187393, XrefRangeEnd = 187414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x0019FC58 File Offset: 0x0019DE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187419, XrefRangeEnd = 187430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcceptContractClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x0019FC94 File Offset: 0x0019DE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187430, XrefRangeEnd = 187449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CounterOfferClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x0019FCD0 File Offset: 0x0019DED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187449, XrefRangeEnd = 187492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x0019FD3C File Offset: 0x0019DF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187492, XrefRangeEnd = 187505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x0019FD9C File Offset: 0x0019DF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187505, XrefRangeEnd = 187524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContractIsCounterOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x0019FDD0 File Offset: 0x0019DFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187524, XrefRangeEnd = 187593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerAcceptedContract(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x0019FE1C File Offset: 0x0019E01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187593, XrefRangeEnd = 187613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x0019FE68 File Offset: 0x0019E068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187613, XrefRangeEnd = 187649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x0019FEC8 File Offset: 0x0019E0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187649, XrefRangeEnd = 187670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x0019FEFC File Offset: 0x0019E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187670, XrefRangeEnd = 187676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractAcceptedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x0019FF38 File Offset: 0x0019E138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187676, XrefRangeEnd = 187706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x0019FFAC File Offset: 0x0019E1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187706, XrefRangeEnd = 187707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetValueProposition(ProductDefinition product, float price)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x0019FFFC File Offset: 0x0019E1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187707, XrefRangeEnd = 187736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x001A0038 File Offset: 0x0019E238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187736, XrefRangeEnd = 187757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x001A006C File Offset: 0x0019E26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187757, XrefRangeEnd = 187763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractRejectedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x001A00A8 File Offset: 0x0019E2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187763, XrefRangeEnd = 187784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsAwaitingDelivery(bool awaiting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref awaiting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x001A00F4 File Offset: 0x0019E2F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187793, RefRangeEnd = 187795, XrefRangeStart = 187784, XrefRangeEnd = 187793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDealLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x001A0130 File Offset: 0x0019E330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187801, RefRangeEnd = 187804, XrefRangeStart = 187795, XrefRangeEnd = 187801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePotentialCustomerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x001A0164 File Offset: 0x0019E364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187804, XrefRangeEnd = 187809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPotentialCustomerPoIEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x001A01A4 File Offset: 0x0019E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187809, XrefRangeEnd = 187824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryGenerateDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x001A01EC File Offset: 0x0019E3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187824, XrefRangeEnd = 187832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &accepted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x001A0258 File Offset: 0x0019E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187832, XrefRangeEnd = 187865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offeredByPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x001A02A4 File Offset: 0x0019E4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187865, XrefRangeEnd = 188020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref giveBonuses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x001A0330 File Offset: 0x0019E530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188020, XrefRangeEnd = 188036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x001A03D0 File Offset: 0x0019E5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188036, XrefRangeEnd = 188048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x001A0430 File Offset: 0x0019E630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188068, RefRangeEnd = 188070, XrefRangeStart = 188048, XrefRangeEnd = 188068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContractWellReceived(string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x001A0474 File Offset: 0x0019E674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188070, XrefRangeEnd = 188151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x001A04B8 File Offset: 0x0019E6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188151, XrefRangeEnd = 188220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x001A04FC File Offset: 0x0019E6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188220, XrefRangeEnd = 188303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendCustomer(Customer friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x001A0540 File Offset: 0x0019E740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188303, XrefRangeEnd = 188310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurrentContractEnded(EQuestState outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x001A058C File Offset: 0x0019E78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188310, XrefRangeEnd = 188399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &highestAddiction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mainTypeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchedProductCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x001A0624 File Offset: 0x0019E824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188418, RefRangeEnd = 188420, XrefRangeStart = 188399, XrefRangeEnd = 188418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAddiction(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x001A0664 File Offset: 0x0019E864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188420, XrefRangeEnd = 188433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x001A06A8 File Offset: 0x0019E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188433, XrefRangeEnd = 188445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowOfferDealOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x001A06FC File Offset: 0x0019E8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188445, XrefRangeEnd = 188454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OfferDealValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x001A0760 File Offset: 0x0019E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188454, XrefRangeEnd = 188466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantDealOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x001A079C File Offset: 0x0019E99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188549, RefRangeEnd = 188551, XrefRangeStart = 188466, XrefRangeEnd = 188549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x001A07F8 File Offset: 0x0019E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188551, XrefRangeEnd = 188582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryApproachPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x001A0840 File Offset: 0x0019EA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188582, XrefRangeEnd = 188587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x001A0874 File Offset: 0x0019EA74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188599, RefRangeEnd = 188601, XrefRangeStart = 188587, XrefRangeEnd = 188599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x001A08B8 File Offset: 0x0019EAB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188621, RefRangeEnd = 188622, XrefRangeStart = 188601, XrefRangeEnd = 188621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerRejectedProductRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x001A08EC File Offset: 0x0019EAEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188640, RefRangeEnd = 188641, XrefRangeStart = 188622, XrefRangeEnd = 188640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x001A0920 File Offset: 0x0019EB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188641, XrefRangeEnd = 188662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer_Local()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x001A0954 File Offset: 0x0019EB54
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x001A0998 File Offset: 0x0019EB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188662, XrefRangeEnd = 188664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x001A09DC File Offset: 0x0019EBDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188689, RefRangeEnd = 188691, XrefRangeStart = 188664, XrefRangeEnd = 188689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData GetCustomerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr3) : null;
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x001A0A1C File Offset: 0x0019EC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188691, XrefRangeEnd = 188697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x001A0A78 File Offset: 0x0019EC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188697, XrefRangeEnd = 188716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x001A0ACC File Offset: 0x0019ECCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188716, XrefRangeEnd = 188737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x001A0B1C File Offset: 0x0019ED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188737, XrefRangeEnd = 188745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyForHandover(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x001A0B70 File Offset: 0x0019ED70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188745, XrefRangeEnd = 188765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x001A0BD4 File Offset: 0x0019EDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188765, XrefRangeEnd = 188776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverChosen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x001A0C08 File Offset: 0x0019EE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188776, XrefRangeEnd = 188784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowDirectApproachOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x001A0C5C File Offset: 0x0019EE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188784, XrefRangeEnd = 188791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsUnlockable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x001A0CA4 File Offset: 0x0019EEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188791, XrefRangeEnd = 188809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SampleOptionValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x001A0D08 File Offset: 0x0019EF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188809, XrefRangeEnd = 188817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KnownAndRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x001A0D44 File Offset: 0x0019EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188817, XrefRangeEnd = 188818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x001A0D78 File Offset: 0x0019EF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188818, XrefRangeEnd = 188824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetSampleRequestSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x001A0DC0 File Offset: 0x0019EFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188824, XrefRangeEnd = 188842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SampleAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x001A0DFC File Offset: 0x0019EFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188876, RefRangeEnd = 188877, XrefRangeStart = 188842, XrefRangeEnd = 188876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x001A0E58 File Offset: 0x0019F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188877, XrefRangeEnd = 188907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x001A0EB8 File Offset: 0x0019F0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188907, XrefRangeEnd = 188929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleServerSide(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x001A0EFC File Offset: 0x0019F0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188929, XrefRangeEnd = 188950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x001A0F30 File Offset: 0x0019F130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188950, XrefRangeEnd = 189051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleConsumed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x001A0F64 File Offset: 0x0019F164
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189060, RefRangeEnd = 189063, XrefRangeStart = 189051, XrefRangeEnd = 189060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_EndWait_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x001A0F98 File Offset: 0x0019F198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189063, XrefRangeEnd = 189083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirectApproachRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x001A0FD4 File Offset: 0x0019F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189083, XrefRangeEnd = 189101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasSufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x001A1008 File Offset: 0x0019F208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189101, XrefRangeEnd = 189119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasInsufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x001A103C File Offset: 0x0019F23C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 189152, RefRangeEnd = 189157, XrefRangeStart = 189119, XrefRangeEnd = 189152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x001A1098 File Offset: 0x0019F298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189157, XrefRangeEnd = 189186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDrugType> GetOrderedDrugTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EDrugType>>(intPtr3) : null;
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x001A10D8 File Offset: 0x0019F2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189186, XrefRangeEnd = 189206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustAffinity(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x001A1124 File Offset: 0x0019F324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189206, XrefRangeEnd = 189216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutocreateCustomerSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x001A1158 File Offset: 0x0019F358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189216, XrefRangeEnd = 189229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x001A1194 File Offset: 0x0019F394
		[CallerCount(0)]
		public unsafe void _Awake_b__131_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x001A11C8 File Offset: 0x0019F3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189229, XrefRangeEnd = 189230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__133_1(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x001A1214 File Offset: 0x0019F414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189256, RefRangeEnd = 189257, XrefRangeStart = 189230, XrefRangeEnd = 189256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x001A1248 File Offset: 0x0019F448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189257, XrefRangeEnd = 189316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x001A12A8 File Offset: 0x0019F4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189316, XrefRangeEnd = 189317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HandoverChosen_b__207_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x001A1308 File Offset: 0x0019F508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189317, XrefRangeEnd = 189330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetOrderedDrugTypes_b__225_0(EDrugType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x001A1354 File Offset: 0x0019F554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189330, XrefRangeEnd = 189489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x001A1390 File Offset: 0x0019F590
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x001A13CC File Offset: 0x0019F5CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x001A1408 File Offset: 0x0019F608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189489, XrefRangeEnd = 189510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x001A1468 File Offset: 0x0019F668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189510, XrefRangeEnd = 189513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x001A14C8 File Offset: 0x0019F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189513, XrefRangeEnd = 189519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x001A1518 File Offset: 0x0019F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189519, XrefRangeEnd = 189531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x001A1578 File Offset: 0x0019F778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189531, XrefRangeEnd = 189537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x001A15C8 File Offset: 0x0019F7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x001A1618 File Offset: 0x0019F818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189537, XrefRangeEnd = 189538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x001A1668 File Offset: 0x0019F868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189538, XrefRangeEnd = 189542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x001A16B8 File Offset: 0x0019F8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189542, XrefRangeEnd = 189560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x001A16EC File Offset: 0x0019F8EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189567, RefRangeEnd = 189569, XrefRangeStart = 189560, XrefRangeEnd = 189567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x001A1728 File Offset: 0x0019F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189569, XrefRangeEnd = 189572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x001A178C File Offset: 0x0019F98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189572, XrefRangeEnd = 189590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x001A17C0 File Offset: 0x0019F9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189590, XrefRangeEnd = 189591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x001A17F4 File Offset: 0x0019F9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189591, XrefRangeEnd = 189594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x001A1858 File Offset: 0x0019FA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189594, XrefRangeEnd = 189612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x001A188C File Offset: 0x0019FA8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189653, RefRangeEnd = 189655, XrefRangeStart = 189612, XrefRangeEnd = 189653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x001A18C0 File Offset: 0x0019FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189655, XrefRangeEnd = 189658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x001A1910 File Offset: 0x0019FB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x001A1970 File Offset: 0x0019FB70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189743, RefRangeEnd = 189744, XrefRangeStart = 189658, XrefRangeEnd = 189743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x001A19D0 File Offset: 0x0019FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189744, XrefRangeEnd = 189750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x001A1A34 File Offset: 0x0019FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189750, XrefRangeEnd = 189768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x001A1A68 File Offset: 0x0019FC68
		[CallerCount(0)]
		public unsafe void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x001A1A9C File Offset: 0x0019FC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189768, XrefRangeEnd = 189770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x001A1AEC File Offset: 0x0019FCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x001A1B38 File Offset: 0x0019FD38
		[CallerCount(0)]
		public unsafe void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x001A1B84 File Offset: 0x0019FD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189770, XrefRangeEnd = 189772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x001A1BE8 File Offset: 0x0019FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189772, XrefRangeEnd = 189790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x001A1C1C File Offset: 0x0019FE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189790, XrefRangeEnd = 189791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x001A1C50 File Offset: 0x0019FE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189791, XrefRangeEnd = 189794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x001A1CA0 File Offset: 0x0019FEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189794, XrefRangeEnd = 189812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x001A1CD4 File Offset: 0x0019FED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x001A1D08 File Offset: 0x0019FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x001A1D58 File Offset: 0x0019FF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x001A1DF8 File Offset: 0x0019FFF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189974, RefRangeEnd = 189975, XrefRangeStart = 189812, XrefRangeEnd = 189974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x001A1E98 File Offset: 0x001A0098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189975, XrefRangeEnd = 189983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x001A1EFC File Offset: 0x001A00FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x001A1F5C File Offset: 0x001A015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189983, XrefRangeEnd = 189989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x001A1FBC File Offset: 0x001A01BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189989, XrefRangeEnd = 189997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessHandoverClient_537707335(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x001A200C File Offset: 0x001A020C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188418, RefRangeEnd = 188420, XrefRangeStart = 188418, XrefRangeEnd = 188420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x001A204C File Offset: 0x001A024C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189997, XrefRangeEnd = 189998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x001A208C File Offset: 0x001A028C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189998, XrefRangeEnd = 190001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x001A20F0 File Offset: 0x001A02F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188640, RefRangeEnd = 188641, XrefRangeStart = 188640, XrefRangeEnd = 188641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x001A2124 File Offset: 0x001A0324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190033, RefRangeEnd = 190034, XrefRangeStart = 190001, XrefRangeEnd = 190033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x001A2158 File Offset: 0x001A0358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190034, XrefRangeEnd = 190036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x001A21BC File Offset: 0x001A03BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190036, XrefRangeEnd = 190054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x001A21F0 File Offset: 0x001A03F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190063, RefRangeEnd = 190066, XrefRangeStart = 190054, XrefRangeEnd = 190063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x001A2224 File Offset: 0x001A0424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190066, XrefRangeEnd = 190069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x001A2274 File Offset: 0x001A0474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x001A22C8 File Offset: 0x001A04C8
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x001A231C File Offset: 0x001A051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190069, XrefRangeEnd = 190072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x001A236C File Offset: 0x001A056C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190072, XrefRangeEnd = 190091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x001A23B0 File Offset: 0x001A05B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 190131, RefRangeEnd = 190136, XrefRangeStart = 190091, XrefRangeEnd = 190131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x001A23F4 File Offset: 0x001A05F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190136, XrefRangeEnd = 190140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x001A2458 File Offset: 0x001A0658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190140, XrefRangeEnd = 190158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x001A248C File Offset: 0x001A068C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190165, RefRangeEnd = 190168, XrefRangeStart = 190158, XrefRangeEnd = 190165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x001A24C0 File Offset: 0x001A06C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190168, XrefRangeEnd = 190171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x001A2510 File Offset: 0x001A0710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x001A2544 File Offset: 0x001A0744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190171, XrefRangeEnd = 190179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x001A2578 File Offset: 0x001A0778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190179, XrefRangeEnd = 190188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x001A25C8 File Offset: 0x001A07C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x001A25FC File Offset: 0x001A07FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190211, RefRangeEnd = 190212, XrefRangeStart = 190188, XrefRangeEnd = 190211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x001A2630 File Offset: 0x001A0830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190212, XrefRangeEnd = 190214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x001A2680 File Offset: 0x001A0880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x001A26CC File Offset: 0x001A08CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190214, XrefRangeEnd = 190227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x001A2718 File Offset: 0x001A0918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190227, XrefRangeEnd = 190243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06005985 RID: 22917 RVA: 0x001A277C File Offset: 0x001A097C
		// (set) Token: 0x06005986 RID: 22918 RVA: 0x001A27B8 File Offset: 0x001A09B8
		public unsafe float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86619, RefRangeEnd = 86621, XrefRangeStart = 86619, XrefRangeEnd = 86621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190251, RefRangeEnd = 190252, XrefRangeStart = 190243, XrefRangeEnd = 190251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x001A2804 File Offset: 0x001A0A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190252, XrefRangeEnd = 190257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x001A2878 File Offset: 0x001A0A78
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x001A28B4 File Offset: 0x001A0AB4
		public unsafe bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190257, XrefRangeEnd = 190265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x001A2900 File Offset: 0x001A0B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190295, RefRangeEnd = 190296, XrefRangeStart = 190265, XrefRangeEnd = 190295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x0002A23B File Offset: 0x0002843B
		public Customer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x0600598C RID: 22924 RVA: 0x001A293C File Offset: 0x001A0B3C
		// (set) Token: 0x0600598D RID: 22925 RVA: 0x0002A244 File Offset: 0x00028444
		public unsafe static Action<Customer> onCustomerUnlocked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x0600598E RID: 22926 RVA: 0x001A2964 File Offset: 0x001A0B64
		// (set) Token: 0x0600598F RID: 22927 RVA: 0x0002A256 File Offset: 0x00028456
		public unsafe static List<Customer> UnlockedCustomers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x001A298C File Offset: 0x001A0B8C
		// (set) Token: 0x06005991 RID: 22929 RVA: 0x0002A268 File Offset: 0x00028468
		public unsafe static float AFFINITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x001A29A8 File Offset: 0x001A0BA8
		// (set) Token: 0x06005993 RID: 22931 RVA: 0x0002A276 File Offset: 0x00028476
		public unsafe static float PROPERTY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x001A29C4 File Offset: 0x001A0BC4
		// (set) Token: 0x06005995 RID: 22933 RVA: 0x0002A284 File Offset: 0x00028484
		public unsafe static float QUALITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06005996 RID: 22934 RVA: 0x001A29E0 File Offset: 0x001A0BE0
		// (set) Token: 0x06005997 RID: 22935 RVA: 0x0002A292 File Offset: 0x00028492
		public unsafe static float DEAL_REJECTED_RELATIONSHIP_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06005998 RID: 22936 RVA: 0x001A29FC File Offset: 0x001A0BFC
		// (set) Token: 0x06005999 RID: 22937 RVA: 0x0002A2A0 File Offset: 0x000284A0
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x001A2A24 File Offset: 0x001A0C24
		// (set) Token: 0x0600599B RID: 22939 RVA: 0x0002A2BB File Offset: 0x000284BB
		public unsafe static float APPROACH_MIN_ADDICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&value));
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x001A2A40 File Offset: 0x001A0C40
		// (set) Token: 0x0600599D RID: 22941 RVA: 0x0002A2C9 File Offset: 0x000284C9
		public unsafe static float APPROACH_CHANCE_PER_DAY_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600599E RID: 22942 RVA: 0x001A2A5C File Offset: 0x001A0C5C
		// (set) Token: 0x0600599F RID: 22943 RVA: 0x0002A2D7 File Offset: 0x000284D7
		public unsafe static float APPROACH_MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x001A2A78 File Offset: 0x001A0C78
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x0002A2E5 File Offset: 0x000284E5
		public unsafe static float APPROACH_MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x001A2A94 File Offset: 0x001A0C94
		// (set) Token: 0x060059A3 RID: 22947 RVA: 0x0002A2F3 File Offset: 0x000284F3
		public unsafe static int DEAL_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x001A2AB0 File Offset: 0x001A0CB0
		// (set) Token: 0x060059A5 RID: 22949 RVA: 0x0002A301 File Offset: 0x00028501
		public unsafe static Il2CppStringArray PlayerAcceptMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x001A2AD8 File Offset: 0x001A0CD8
		// (set) Token: 0x060059A7 RID: 22951 RVA: 0x0002A313 File Offset: 0x00028513
		public unsafe static Il2CppStringArray PlayerRejectMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x001A2B00 File Offset: 0x001A0D00
		// (set) Token: 0x060059A9 RID: 22953 RVA: 0x0002A325 File Offset: 0x00028525
		public unsafe static int DEAL_ATTENDANCE_TOLERANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&value));
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x001A2B1C File Offset: 0x001A0D1C
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x0002A333 File Offset: 0x00028533
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x001A2B38 File Offset: 0x001A0D38
		// (set) Token: 0x060059AD RID: 22957 RVA: 0x0002A341 File Offset: 0x00028541
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x001A2B54 File Offset: 0x001A0D54
		// (set) Token: 0x060059AF RID: 22959 RVA: 0x0002A34F File Offset: 0x0002854F
		public unsafe static int OFFER_EXPIRY_TIME_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x001A2B70 File Offset: 0x001A0D70
		// (set) Token: 0x060059B1 RID: 22961 RVA: 0x0002A35D File Offset: 0x0002855D
		public unsafe static float MIN_ORDER_APPEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&value));
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x060059B2 RID: 22962 RVA: 0x001A2B8C File Offset: 0x001A0D8C
		// (set) Token: 0x060059B3 RID: 22963 RVA: 0x0002A36B File Offset: 0x0002856B
		public unsafe static float ADDICTION_DRAIN_PER_DAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&value));
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x001A2BA8 File Offset: 0x001A0DA8
		// (set) Token: 0x060059B5 RID: 22965 RVA: 0x0002A379 File Offset: 0x00028579
		public unsafe static bool SAMPLE_REQUIRES_RECOMMENDATION
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x060059B6 RID: 22966 RVA: 0x001A2BC4 File Offset: 0x001A0DC4
		// (set) Token: 0x060059B7 RID: 22967 RVA: 0x0002A387 File Offset: 0x00028587
		public unsafe static float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x060059B8 RID: 22968 RVA: 0x001A2BE0 File Offset: 0x001A0DE0
		// (set) Token: 0x060059B9 RID: 22969 RVA: 0x0002A395 File Offset: 0x00028595
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060059BA RID: 22970 RVA: 0x001A2BFC File Offset: 0x001A0DFC
		// (set) Token: 0x060059BB RID: 22971 RVA: 0x0002A3A3 File Offset: 0x000285A3
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x060059BC RID: 22972 RVA: 0x001A2C18 File Offset: 0x001A0E18
		// (set) Token: 0x060059BD RID: 22973 RVA: 0x0002A3B1 File Offset: 0x000285B1
		public unsafe float _CurrentAddiction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060059BE RID: 22974 RVA: 0x001A2C40 File Offset: 0x001A0E40
		// (set) Token: 0x060059BF RID: 22975 RVA: 0x0002A3CC File Offset: 0x000285CC
		public unsafe ContractInfo offeredContractInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x001A2C70 File Offset: 0x001A0E70
		// (set) Token: 0x060059C1 RID: 22977 RVA: 0x0002A3EB File Offset: 0x000285EB
		public unsafe GameDateTime _OfferedContractTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060059C2 RID: 22978 RVA: 0x001A2C98 File Offset: 0x001A0E98
		// (set) Token: 0x060059C3 RID: 22979 RVA: 0x0002A406 File Offset: 0x00028606
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060059C4 RID: 22980 RVA: 0x001A2CC8 File Offset: 0x001A0EC8
		// (set) Token: 0x060059C5 RID: 22981 RVA: 0x0002A425 File Offset: 0x00028625
		public unsafe bool _IsAwaitingDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x060059C6 RID: 22982 RVA: 0x001A2CF0 File Offset: 0x001A0EF0
		// (set) Token: 0x060059C7 RID: 22983 RVA: 0x0002A440 File Offset: 0x00028640
		public unsafe int _TimeSinceLastDealCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x060059C8 RID: 22984 RVA: 0x001A2D18 File Offset: 0x001A0F18
		// (set) Token: 0x060059C9 RID: 22985 RVA: 0x0002A45B File Offset: 0x0002865B
		public unsafe int _TimeSinceLastDealOffered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x001A2D40 File Offset: 0x001A0F40
		// (set) Token: 0x060059CB RID: 22987 RVA: 0x0002A476 File Offset: 0x00028676
		public unsafe int _TimeSincePlayerApproached_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x060059CC RID: 22988 RVA: 0x001A2D68 File Offset: 0x001A0F68
		// (set) Token: 0x060059CD RID: 22989 RVA: 0x0002A491 File Offset: 0x00028691
		public unsafe int _TimeSinceInstantDealOffered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x001A2D90 File Offset: 0x001A0F90
		// (set) Token: 0x060059CF RID: 22991 RVA: 0x0002A4AC File Offset: 0x000286AC
		public unsafe int _OfferedDeals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x001A2DB8 File Offset: 0x001A0FB8
		// (set) Token: 0x060059D1 RID: 22993 RVA: 0x0002A4C7 File Offset: 0x000286C7
		public unsafe int _CompletedDeliveries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x001A2DE0 File Offset: 0x001A0FE0
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x0002A4E2 File Offset: 0x000286E2
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x001A2E08 File Offset: 0x001A1008
		// (set) Token: 0x060059D5 RID: 22997 RVA: 0x0002A4FD File Offset: 0x000286FD
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x001A2E38 File Offset: 0x001A1038
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x0002A51C File Offset: 0x0002871C
		public unsafe Dealer _AssignedDealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x001A2E68 File Offset: 0x001A1068
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x0002A53B File Offset: 0x0002873B
		public unsafe NPCSignal_WaitForDelivery DealSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DealSignal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_WaitForDelivery>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DealSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x001A2E98 File Offset: 0x001A1098
		// (set) Token: 0x060059DB RID: 23003 RVA: 0x0002A55A File Offset: 0x0002875A
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x001A2EC0 File Offset: 0x001A10C0
		// (set) Token: 0x060059DD RID: 23005 RVA: 0x0002A575 File Offset: 0x00028775
		public unsafe CustomerData customerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x001A2EF0 File Offset: 0x001A10F0
		// (set) Token: 0x060059DF RID: 23007 RVA: 0x0002A594 File Offset: 0x00028794
		public unsafe DeliveryLocation DefaultDeliveryLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DefaultDeliveryLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DefaultDeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060059E0 RID: 23008 RVA: 0x001A2F20 File Offset: 0x001A1120
		// (set) Token: 0x060059E1 RID: 23009 RVA: 0x0002A5B3 File Offset: 0x000287B3
		public unsafe bool CanRecommendFriends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_CanRecommendFriends);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_CanRecommendFriends)) = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x001A2F48 File Offset: 0x001A1148
		// (set) Token: 0x060059E3 RID: 23011 RVA: 0x0002A5CE File Offset: 0x000287CE
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060059E4 RID: 23012 RVA: 0x001A2F78 File Offset: 0x001A1178
		// (set) Token: 0x060059E5 RID: 23013 RVA: 0x0002A5ED File Offset: 0x000287ED
		public unsafe UnityEvent onDealCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060059E6 RID: 23014 RVA: 0x001A2FA8 File Offset: 0x001A11A8
		// (set) Token: 0x060059E7 RID: 23015 RVA: 0x0002A60C File Offset: 0x0002880C
		public unsafe UnityEvent<Contract> onContractAssigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060059E8 RID: 23016 RVA: 0x001A2FD8 File Offset: 0x001A11D8
		// (set) Token: 0x060059E9 RID: 23017 RVA: 0x0002A62B File Offset: 0x0002882B
		public unsafe bool awaitingSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample)) = value;
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060059EA RID: 23018 RVA: 0x001A3000 File Offset: 0x001A1200
		// (set) Token: 0x060059EB RID: 23019 RVA: 0x0002A646 File Offset: 0x00028846
		public unsafe DialogueController.DialogueChoice sampleChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x001A3030 File Offset: 0x001A1230
		// (set) Token: 0x060059ED RID: 23021 RVA: 0x0002A665 File Offset: 0x00028865
		public unsafe DialogueController.DialogueChoice completeContractChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x001A3060 File Offset: 0x001A1260
		// (set) Token: 0x060059EF RID: 23023 RVA: 0x0002A684 File Offset: 0x00028884
		public unsafe DialogueController.DialogueChoice offerDealChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060059F0 RID: 23024 RVA: 0x001A3090 File Offset: 0x001A1290
		// (set) Token: 0x060059F1 RID: 23025 RVA: 0x0002A6A3 File Offset: 0x000288A3
		public unsafe DialogueController.GreetingOverride awaitingDealGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x001A30C0 File Offset: 0x001A12C0
		// (set) Token: 0x060059F3 RID: 23027 RVA: 0x0002A6C2 File Offset: 0x000288C2
		public unsafe int minsSinceUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked)) = value;
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x001A30E8 File Offset: 0x001A12E8
		// (set) Token: 0x060059F5 RID: 23029 RVA: 0x0002A6DD File Offset: 0x000288DD
		public unsafe bool sampleOfferedToday
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday)) = value;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060059F6 RID: 23030 RVA: 0x001A3110 File Offset: 0x001A1310
		// (set) Token: 0x060059F7 RID: 23031 RVA: 0x0002A6F8 File Offset: 0x000288F8
		public unsafe NPCPoI _potentialCustomerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x060059F8 RID: 23032 RVA: 0x001A3140 File Offset: 0x001A1340
		// (set) Token: 0x060059F9 RID: 23033 RVA: 0x0002A717 File Offset: 0x00028917
		public unsafe CustomerAffinityData currentAffinityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x001A3170 File Offset: 0x001A1370
		// (set) Token: 0x060059FB RID: 23035 RVA: 0x0002A736 File Offset: 0x00028936
		public unsafe bool pendingInstantDeal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal)) = value;
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x060059FC RID: 23036 RVA: 0x001A3198 File Offset: 0x001A1398
		// (set) Token: 0x060059FD RID: 23037 RVA: 0x0002A751 File Offset: 0x00028951
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x001A31C8 File Offset: 0x001A13C8
		// (set) Token: 0x060059FF RID: 23039 RVA: 0x0002A770 File Offset: 0x00028970
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x001A31F8 File Offset: 0x001A13F8
		// (set) Token: 0x06005A01 RID: 23041 RVA: 0x0002A78F File Offset: 0x0002898F
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x001A3220 File Offset: 0x001A1420
		// (set) Token: 0x06005A03 RID: 23043 RVA: 0x0002A7AA File Offset: 0x000289AA
		public unsafe ProductItemInstance consumedSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06005A04 RID: 23044 RVA: 0x001A3250 File Offset: 0x001A1450
		// (set) Token: 0x06005A05 RID: 23045 RVA: 0x0002A7C9 File Offset: 0x000289C9
		public unsafe SyncVar<float> syncVar____CurrentAddiction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x001A3280 File Offset: 0x001A1480
		// (set) Token: 0x06005A07 RID: 23047 RVA: 0x0002A7E8 File Offset: 0x000289E8
		public unsafe SyncVar<bool> syncVar____HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x001A32B0 File Offset: 0x001A14B0
		// (set) Token: 0x06005A09 RID: 23049 RVA: 0x0002A807 File Offset: 0x00028A07
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x001A32D8 File Offset: 0x001A14D8
		// (set) Token: 0x06005A0B RID: 23051 RVA: 0x0002A822 File Offset: 0x00028A22
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003C64 RID: 15460
		private static readonly IntPtr NativeFieldInfoPtr_onCustomerUnlocked;

		// Token: 0x04003C65 RID: 15461
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedCustomers;

		// Token: 0x04003C66 RID: 15462
		private static readonly IntPtr NativeFieldInfoPtr_AFFINITY_MAX_EFFECT;

		// Token: 0x04003C67 RID: 15463
		private static readonly IntPtr NativeFieldInfoPtr_PROPERTY_MAX_EFFECT;

		// Token: 0x04003C68 RID: 15464
		private static readonly IntPtr NativeFieldInfoPtr_QUALITY_MAX_EFFECT;

		// Token: 0x04003C69 RID: 15465
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE;

		// Token: 0x04003C6A RID: 15466
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003C6B RID: 15467
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MIN_ADDICTION;

		// Token: 0x04003C6C RID: 15468
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX;

		// Token: 0x04003C6D RID: 15469
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN;

		// Token: 0x04003C6E RID: 15470
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN;

		// Token: 0x04003C6F RID: 15471
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_COOLDOWN;

		// Token: 0x04003C70 RID: 15472
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAcceptMessages;

		// Token: 0x04003C71 RID: 15473
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRejectMessages;

		// Token: 0x04003C72 RID: 15474
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE;

		// Token: 0x04003C73 RID: 15475
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003C74 RID: 15476
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003C75 RID: 15477
		private static readonly IntPtr NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS;

		// Token: 0x04003C76 RID: 15478
		private static readonly IntPtr NativeFieldInfoPtr_MIN_ORDER_APPEAL;

		// Token: 0x04003C77 RID: 15479
		private static readonly IntPtr NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY;

		// Token: 0x04003C78 RID: 15480
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION;

		// Token: 0x04003C79 RID: 15481
		private static readonly IntPtr NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION;

		// Token: 0x04003C7A RID: 15482
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION;

		// Token: 0x04003C7B RID: 15483
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION;

		// Token: 0x04003C7C RID: 15484
		private static readonly IntPtr NativeFieldInfoPtr__CurrentAddiction_k__BackingField;

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeFieldInfoPtr_offeredContractInfo;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeFieldInfoPtr__OfferedContractTime_k__BackingField;

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField;

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField;

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeFieldInfoPtr__OfferedDeals_k__BackingField;

		// Token: 0x04003C86 RID: 15494
		private static readonly IntPtr NativeFieldInfoPtr__CompletedDeliveries_k__BackingField;

		// Token: 0x04003C87 RID: 15495
		private static readonly IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003C88 RID: 15496
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04003C89 RID: 15497
		private static readonly IntPtr NativeFieldInfoPtr__AssignedDealer_k__BackingField;

		// Token: 0x04003C8A RID: 15498
		private static readonly IntPtr NativeFieldInfoPtr_DealSignal;

		// Token: 0x04003C8B RID: 15499
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04003C8C RID: 15500
		private static readonly IntPtr NativeFieldInfoPtr_customerData;

		// Token: 0x04003C8D RID: 15501
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDeliveryLocation;

		// Token: 0x04003C8E RID: 15502
		private static readonly IntPtr NativeFieldInfoPtr_CanRecommendFriends;

		// Token: 0x04003C8F RID: 15503
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04003C90 RID: 15504
		private static readonly IntPtr NativeFieldInfoPtr_onDealCompleted;

		// Token: 0x04003C91 RID: 15505
		private static readonly IntPtr NativeFieldInfoPtr_onContractAssigned;

		// Token: 0x04003C92 RID: 15506
		private static readonly IntPtr NativeFieldInfoPtr_awaitingSample;

		// Token: 0x04003C93 RID: 15507
		private static readonly IntPtr NativeFieldInfoPtr_sampleChoice;

		// Token: 0x04003C94 RID: 15508
		private static readonly IntPtr NativeFieldInfoPtr_completeContractChoice;

		// Token: 0x04003C95 RID: 15509
		private static readonly IntPtr NativeFieldInfoPtr_offerDealChoice;

		// Token: 0x04003C96 RID: 15510
		private static readonly IntPtr NativeFieldInfoPtr_awaitingDealGreeting;

		// Token: 0x04003C97 RID: 15511
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceUnlocked;

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeFieldInfoPtr_sampleOfferedToday;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeFieldInfoPtr_currentAffinityData;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeFieldInfoPtr_pendingInstantDeal;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeFieldInfoPtr_consumedSample;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField;

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0;

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0;

		// Token: 0x04003CA7 RID: 15527
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0;

		// Token: 0x04003CA8 RID: 15528
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0;

		// Token: 0x04003CA9 RID: 15529
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x04003CAA RID: 15530
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04003CAB RID: 15531
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04003CAC RID: 15532
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0;

		// Token: 0x04003CAD RID: 15533
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0;

		// Token: 0x04003CAE RID: 15534
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0;

		// Token: 0x04003CAF RID: 15535
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0;

		// Token: 0x04003CB0 RID: 15536
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0;

		// Token: 0x04003CB1 RID: 15537
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003CB2 RID: 15538
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0;

		// Token: 0x04003CB3 RID: 15539
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0;

		// Token: 0x04003CB4 RID: 15540
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0;

		// Token: 0x04003CB5 RID: 15541
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003CB6 RID: 15542
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0;

		// Token: 0x04003CB7 RID: 15543
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0;

		// Token: 0x04003CB8 RID: 15544
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0;

		// Token: 0x04003CB9 RID: 15545
		private static readonly IntPtr NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0;

		// Token: 0x04003CBA RID: 15546
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003CBB RID: 15547
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0;

		// Token: 0x04003CBC RID: 15548
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04003CBD RID: 15549
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x04003CBE RID: 15550
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0;

		// Token: 0x04003CBF RID: 15551
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0;

		// Token: 0x04003CC0 RID: 15552
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0;

		// Token: 0x04003CC1 RID: 15553
		private static readonly IntPtr NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0;

		// Token: 0x04003CC2 RID: 15554
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04003CC3 RID: 15555
		private static readonly IntPtr NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003CC4 RID: 15556
		private static readonly IntPtr NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0;

		// Token: 0x04003CC5 RID: 15557
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003CC6 RID: 15558
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003CC7 RID: 15559
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003CC8 RID: 15560
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003CC9 RID: 15561
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003CCA RID: 15562
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003CCB RID: 15563
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003CCC RID: 15564
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003CCD RID: 15565
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003CCE RID: 15566
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003CCF RID: 15567
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_1;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_1;

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1;

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0;

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0;

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0;

		// Token: 0x04003CF3 RID: 15603
		private static readonly IntPtr NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0;

		// Token: 0x04003CF4 RID: 15604
		private static readonly IntPtr NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1;

		// Token: 0x04003CF5 RID: 15605
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1;

		// Token: 0x04003CF6 RID: 15606
		private static readonly IntPtr NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x04003CF7 RID: 15607
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003CF8 RID: 15608
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0;

		// Token: 0x04003CF9 RID: 15609
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1;

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0;

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0;

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003D00 RID: 15616
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003D01 RID: 15617
		private static readonly IntPtr NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0;

		// Token: 0x04003D02 RID: 15618
		private static readonly IntPtr NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0;

		// Token: 0x04003D03 RID: 15619
		private static readonly IntPtr NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0;

		// Token: 0x04003D04 RID: 15620
		private static readonly IntPtr NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0;

		// Token: 0x04003D05 RID: 15621
		private static readonly IntPtr NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0;

		// Token: 0x04003D06 RID: 15622
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0;

		// Token: 0x04003D07 RID: 15623
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0;

		// Token: 0x04003D08 RID: 15624
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0;

		// Token: 0x04003D09 RID: 15625
		private static readonly IntPtr NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003D0A RID: 15626
		private static readonly IntPtr NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003D0B RID: 15627
		private static readonly IntPtr NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1;

		// Token: 0x04003D0C RID: 15628
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003D0D RID: 15629
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_0;

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0;

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0;

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1;

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0;

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeMethodInfoPtr_HandoverChosen_Public_Void_0;

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0;

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeMethodInfoPtr_SampleOffered_Public_Void_0;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0;

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeMethodInfoPtr_SampleConsumed_Private_Void_1;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr_EndWait_Private_Void_1;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0;

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003D38 RID: 15672
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D3D RID: 15677
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003D3E RID: 15678
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D3F RID: 15679
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003D40 RID: 15680
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003D41 RID: 15681
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D42 RID: 15682
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1;

		// Token: 0x04003D43 RID: 15683
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003D44 RID: 15684
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D45 RID: 15685
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D46 RID: 15686
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D47 RID: 15687
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D48 RID: 15688
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D49 RID: 15689
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D4A RID: 15690
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D4B RID: 15691
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003D4C RID: 15692
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003D4D RID: 15693
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D4E RID: 15694
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x04003D4F RID: 15695
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x04003D50 RID: 15696
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D51 RID: 15697
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003D52 RID: 15698
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003D53 RID: 15699
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D54 RID: 15700
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1;

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0;

		// Token: 0x04003D65 RID: 15717
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D66 RID: 15718
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003D67 RID: 15719
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003D68 RID: 15720
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D69 RID: 15721
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003D6A RID: 15722
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003D6B RID: 15723
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D6C RID: 15724
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003D6D RID: 15725
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003D6E RID: 15726
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D6F RID: 15727
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x04003D70 RID: 15728
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x04003D71 RID: 15729
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D72 RID: 15730
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003D73 RID: 15731
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003D74 RID: 15732
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D75 RID: 15733
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003D76 RID: 15734
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003D77 RID: 15735
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D78 RID: 15736
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0;

		// Token: 0x04003D79 RID: 15737
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0;

		// Token: 0x04003D7A RID: 15738
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D7B RID: 15739
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0;

		// Token: 0x04003D7C RID: 15740
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003D7D RID: 15741
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003D7E RID: 15742
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003D7F RID: 15743
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003D80 RID: 15744
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020009D3 RID: 2515
		[Serializable]
		public class ScheduleGroupPair : Il2CppSystem.Object
		{
			// Token: 0x0600CCCE RID: 52430 RVA: 0x00315E60 File Offset: 0x00314060
			// Note: this type is marked as 'beforefieldinit'.
			static ScheduleGroupPair()
			{
				Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ScheduleGroupPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr);
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "NormalScheduleGroup");
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "CurfewScheduleGroup");
				Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, 100674723);
			}

			// Token: 0x0600CCCF RID: 52431 RVA: 0x00315EC8 File Offset: 0x003140C8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScheduleGroupPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCD0 RID: 52432 RVA: 0x0006399D File Offset: 0x00061B9D
			public ScheduleGroupPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FCA RID: 16330
			// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x00315F04 File Offset: 0x00314104
			// (set) Token: 0x0600CCD2 RID: 52434 RVA: 0x000639A6 File Offset: 0x00061BA6
			public unsafe GameObject NormalScheduleGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCB RID: 16331
			// (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x00315F34 File Offset: 0x00314134
			// (set) Token: 0x0600CCD4 RID: 52436 RVA: 0x000639C5 File Offset: 0x00061BC5
			public unsafe GameObject CurfewScheduleGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A72 RID: 35442
			private static readonly IntPtr NativeFieldInfoPtr_NormalScheduleGroup;

			// Token: 0x04008A73 RID: 35443
			private static readonly IntPtr NativeFieldInfoPtr_CurfewScheduleGroup;

			// Token: 0x04008A74 RID: 35444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D4 RID: 2516
		[Serializable]
		public class CustomerPreference : Il2CppSystem.Object
		{
			// Token: 0x0600CCD5 RID: 52437 RVA: 0x00315F64 File Offset: 0x00314164
			// Note: this type is marked as 'beforefieldinit'.
			static CustomerPreference()
			{
				Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CustomerPreference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr);
				Customer.CustomerPreference.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "DrugType");
				Customer.CustomerPreference.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "Definition");
				Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "MinimumQuality");
				Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, 100674724);
			}

			// Token: 0x0600CCD6 RID: 52438 RVA: 0x00315FE0 File Offset: 0x003141E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomerPreference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCD7 RID: 52439 RVA: 0x000639E4 File Offset: 0x00061BE4
			public CustomerPreference(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FCC RID: 16332
			// (get) Token: 0x0600CCD8 RID: 52440 RVA: 0x0031601C File Offset: 0x0031421C
			// (set) Token: 0x0600CCD9 RID: 52441 RVA: 0x000639ED File Offset: 0x00061BED
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x17003FCD RID: 16333
			// (get) Token: 0x0600CCDA RID: 52442 RVA: 0x00316044 File Offset: 0x00314244
			// (set) Token: 0x0600CCDB RID: 52443 RVA: 0x00063A08 File Offset: 0x00061C08
			public unsafe ProductDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCE RID: 16334
			// (get) Token: 0x0600CCDC RID: 52444 RVA: 0x00316074 File Offset: 0x00314274
			// (set) Token: 0x0600CCDD RID: 52445 RVA: 0x00063A27 File Offset: 0x00061C27
			public unsafe EQuality MinimumQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality)) = value;
				}
			}

			// Token: 0x04008A75 RID: 35445
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008A76 RID: 35446
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008A77 RID: 35447
			private static readonly IntPtr NativeFieldInfoPtr_MinimumQuality;

			// Token: 0x04008A78 RID: 35448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D5 RID: 2517
		[OriginalName("Assembly-CSharp.dll", "", "ESampleFeedback")]
		public enum ESampleFeedback
		{
			// Token: 0x04008A7A RID: 35450
			WrongProduct,
			// Token: 0x04008A7B RID: 35451
			WrongQuality,
			// Token: 0x04008A7C RID: 35452
			Correct
		}

		// Token: 0x020009D6 RID: 2518
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CCDE RID: 52446 RVA: 0x0031609C File Offset: 0x0031429C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Customer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr);
				Customer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9");
				Customer.__c.NativeFieldInfoPtr___9__132_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__132_0");
				Customer.__c.NativeFieldInfoPtr___9__186_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__186_1");
				Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100674726);
				Customer.__c.NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100674727);
				Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100674728);
			}

			// Token: 0x0600CCDF RID: 52447 RVA: 0x00316140 File Offset: 0x00314340
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCE0 RID: 52448 RVA: 0x0031617C File Offset: 0x0031437C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186352, XrefRangeEnd = 186358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnValidate_b__132_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCE1 RID: 52449 RVA: 0x003161CC File Offset: 0x003143CC
			[CallerCount(0)]
			public unsafe EQuality _EvaluateDelivery_b__186_1(ProductItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCE2 RID: 52450 RVA: 0x00063A42 File Offset: 0x00061C42
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FCF RID: 16335
			// (get) Token: 0x0600CCE3 RID: 52451 RVA: 0x0031621C File Offset: 0x0031441C
			// (set) Token: 0x0600CCE4 RID: 52452 RVA: 0x00063A4B File Offset: 0x00061C4B
			public unsafe static Customer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD0 RID: 16336
			// (get) Token: 0x0600CCE5 RID: 52453 RVA: 0x00316244 File Offset: 0x00314444
			// (set) Token: 0x0600CCE6 RID: 52454 RVA: 0x00063A5D File Offset: 0x00061C5D
			public unsafe static Predicate<NPCAction> __9__132_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__132_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__132_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD1 RID: 16337
			// (get) Token: 0x0600CCE7 RID: 52455 RVA: 0x0031626C File Offset: 0x0031446C
			// (set) Token: 0x0600CCE8 RID: 52456 RVA: 0x00063A6F File Offset: 0x00061C6F
			public unsafe static Func<ProductItemInstance, EQuality> __9__186_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__186_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductItemInstance, EQuality>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__186_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A7D RID: 35453
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A7E RID: 35454
			private static readonly IntPtr NativeFieldInfoPtr___9__132_0;

			// Token: 0x04008A7F RID: 35455
			private static readonly IntPtr NativeFieldInfoPtr___9__186_1;

			// Token: 0x04008A80 RID: 35456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A81 RID: 35457
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0;

			// Token: 0x04008A82 RID: 35458
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0;
		}

		// Token: 0x020009D7 RID: 2519
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass146_0")]
		public sealed class __c__DisplayClass146_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CCE9 RID: 52457 RVA: 0x00316294 File Offset: 0x00314494
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass146_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass146_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr);
				Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, "productAppeal");
				Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, 100674729);
				Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, 100674730);
			}

			// Token: 0x0600CCEA RID: 52458 RVA: 0x003162FC File Offset: 0x003144FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass146_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCEB RID: 52459 RVA: 0x00316338 File Offset: 0x00314538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186358, XrefRangeEnd = 186362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetWeightedRandomProduct_b__0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCEC RID: 52460 RVA: 0x00063A81 File Offset: 0x00061C81
			public __c__DisplayClass146_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD2 RID: 16338
			// (get) Token: 0x0600CCED RID: 52461 RVA: 0x00316388 File Offset: 0x00314588
			// (set) Token: 0x0600CCEE RID: 52462 RVA: 0x00063A8A File Offset: 0x00061C8A
			public unsafe Dictionary<ProductDefinition, float> productAppeal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A83 RID: 35459
			private static readonly IntPtr NativeFieldInfoPtr_productAppeal;

			// Token: 0x04008A84 RID: 35460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A85 RID: 35461
			private static readonly IntPtr NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0;
		}

		// Token: 0x020009D8 RID: 2520
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CCEF RID: 52463 RVA: 0x003163B8 File Offset: 0x003145B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr);
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "alreadyRecommended");
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "dealer");
				Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, 100674731);
				Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, 100674732);
			}

			// Token: 0x0600CCF0 RID: 52464 RVA: 0x00316448 File Offset: 0x00314648
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCF1 RID: 52465 RVA: 0x00316484 File Offset: 0x00314684
			[CallerCount(0)]
			public unsafe bool _RecommendDealer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCF2 RID: 52466 RVA: 0x00063AA9 File Offset: 0x00061CA9
			public __c__DisplayClass182_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD3 RID: 16339
			// (get) Token: 0x0600CCF3 RID: 52467 RVA: 0x003164C0 File Offset: 0x003146C0
			// (set) Token: 0x0600CCF4 RID: 52468 RVA: 0x00063AB2 File Offset: 0x00061CB2
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD4 RID: 16340
			// (get) Token: 0x0600CCF5 RID: 52469 RVA: 0x003164F0 File Offset: 0x003146F0
			// (set) Token: 0x0600CCF6 RID: 52470 RVA: 0x00063AD1 File Offset: 0x00061CD1
			public unsafe bool alreadyRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended)) = value;
				}
			}

			// Token: 0x17003FD5 RID: 16341
			// (get) Token: 0x0600CCF7 RID: 52471 RVA: 0x00316518 File Offset: 0x00314718
			// (set) Token: 0x0600CCF8 RID: 52472 RVA: 0x00063AEC File Offset: 0x00061CEC
			public unsafe Dealer dealer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A86 RID: 35462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A87 RID: 35463
			private static readonly IntPtr NativeFieldInfoPtr_alreadyRecommended;

			// Token: 0x04008A88 RID: 35464
			private static readonly IntPtr NativeFieldInfoPtr_dealer;

			// Token: 0x04008A89 RID: 35465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A8A RID: 35466
			private static readonly IntPtr NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0;
		}

		// Token: 0x020009D9 RID: 2521
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_1")]
		public sealed class __c__DisplayClass182_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CCF9 RID: 52473 RVA: 0x00316548 File Offset: 0x00314748
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_1()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass182_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr);
				Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "container");
				Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "CS$<>8__locals1");
				Customer.__c__DisplayClass182_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, 100674733);
				Customer.__c__DisplayClass182_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, 100674734);
			}

			// Token: 0x0600CCFA RID: 52474 RVA: 0x003165C4 File Offset: 0x003147C4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCFB RID: 52475 RVA: 0x00316600 File Offset: 0x00314800
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186386, RefRangeEnd = 186387, XrefRangeStart = 186381, XrefRangeEnd = 186386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CCFC RID: 52476 RVA: 0x00063B0B File Offset: 0x00061D0B
			public __c__DisplayClass182_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD6 RID: 16342
			// (get) Token: 0x0600CCFD RID: 52477 RVA: 0x00316640 File Offset: 0x00314840
			// (set) Token: 0x0600CCFE RID: 52478 RVA: 0x00063B14 File Offset: 0x00061D14
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD7 RID: 16343
			// (get) Token: 0x0600CCFF RID: 52479 RVA: 0x00316670 File Offset: 0x00314870
			// (set) Token: 0x0600CD00 RID: 52480 RVA: 0x00063B33 File Offset: 0x00061D33
			public unsafe Customer.__c__DisplayClass182_0 field_Public___c__DisplayClass182_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass182_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A8B RID: 35467
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008A8C RID: 35468
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0;

			// Token: 0x04008A8D RID: 35469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A8E RID: 35470
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C4E RID: 3150
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_1+<<RecommendDealer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2FB RID: 58107 RVA: 0x00354904 File Offset: 0x00352B04
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "<<RecommendDealer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674735);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674736);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674737);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674738);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674739);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674740);
				}

				// Token: 0x0600E2FC RID: 58108 RVA: 0x003549E4 File Offset: 0x00352BE4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2FD RID: 58109 RVA: 0x00354A2C File Offset: 0x00352C2C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2FE RID: 58110 RVA: 0x00354A60 File Offset: 0x00352C60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186362, XrefRangeEnd = 186376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700466F RID: 18031
				// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x00354A9C File Offset: 0x00352C9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E300 RID: 58112 RVA: 0x00354ADC File Offset: 0x00352CDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186376, XrefRangeEnd = 186381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004670 RID: 18032
				// (get) Token: 0x0600E301 RID: 58113 RVA: 0x00354B10 File Offset: 0x00352D10
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E302 RID: 58114 RVA: 0x0006EA6C File Offset: 0x0006CC6C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700466C RID: 18028
				// (get) Token: 0x0600E303 RID: 58115 RVA: 0x00354B50 File Offset: 0x00352D50
				// (set) Token: 0x0600E304 RID: 58116 RVA: 0x0006EA75 File Offset: 0x0006CC75
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700466D RID: 18029
				// (get) Token: 0x0600E305 RID: 58117 RVA: 0x00354B78 File Offset: 0x00352D78
				// (set) Token: 0x0600E306 RID: 58118 RVA: 0x0006EA90 File Offset: 0x0006CC90
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700466E RID: 18030
				// (get) Token: 0x0600E307 RID: 58119 RVA: 0x00354BA8 File Offset: 0x00352DA8
				// (set) Token: 0x0600E308 RID: 58120 RVA: 0x0006EAAF File Offset: 0x0006CCAF
				public unsafe Customer.__c__DisplayClass182_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass182_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097E9 RID: 38889
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097EA RID: 38890
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097EB RID: 38891
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097EC RID: 38892
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097ED RID: 38893
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097EE RID: 38894
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097EF RID: 38895
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097F0 RID: 38896
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097F1 RID: 38897
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DA RID: 2522
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass183_0")]
		public sealed class __c__DisplayClass183_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD01 RID: 52481 RVA: 0x003166A0 File Offset: 0x003148A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass183_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass183_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr);
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "alreadyRecommended");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "supplier");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass183_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, 100674741);
				Customer.__c__DisplayClass183_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, 100674742);
			}

			// Token: 0x0600CD02 RID: 52482 RVA: 0x00316744 File Offset: 0x00314944
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass183_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD03 RID: 52483 RVA: 0x00316780 File Offset: 0x00314980
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186403, RefRangeEnd = 186404, XrefRangeStart = 186398, XrefRangeEnd = 186403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD04 RID: 52484 RVA: 0x00063B52 File Offset: 0x00061D52
			public __c__DisplayClass183_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD8 RID: 16344
			// (get) Token: 0x0600CD05 RID: 52485 RVA: 0x003167C0 File Offset: 0x003149C0
			// (set) Token: 0x0600CD06 RID: 52486 RVA: 0x00063B5B File Offset: 0x00061D5B
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD9 RID: 16345
			// (get) Token: 0x0600CD07 RID: 52487 RVA: 0x003167F0 File Offset: 0x003149F0
			// (set) Token: 0x0600CD08 RID: 52488 RVA: 0x00063B7A File Offset: 0x00061D7A
			public unsafe bool alreadyRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended)) = value;
				}
			}

			// Token: 0x17003FDA RID: 16346
			// (get) Token: 0x0600CD09 RID: 52489 RVA: 0x00316818 File Offset: 0x00314A18
			// (set) Token: 0x0600CD0A RID: 52490 RVA: 0x00063B95 File Offset: 0x00061D95
			public unsafe Supplier supplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FDB RID: 16347
			// (get) Token: 0x0600CD0B RID: 52491 RVA: 0x00316848 File Offset: 0x00314A48
			// (set) Token: 0x0600CD0C RID: 52492 RVA: 0x00063BB4 File Offset: 0x00061DB4
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A8F RID: 35471
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A90 RID: 35472
			private static readonly IntPtr NativeFieldInfoPtr_alreadyRecommended;

			// Token: 0x04008A91 RID: 35473
			private static readonly IntPtr NativeFieldInfoPtr_supplier;

			// Token: 0x04008A92 RID: 35474
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008A93 RID: 35475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A94 RID: 35476
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C4F RID: 3151
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass183_0+<<RecommendSupplier>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E309 RID: 58121 RVA: 0x00354BD8 File Offset: 0x00352DD8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "<<RecommendSupplier>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674743);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674744);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674745);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674746);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674747);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674748);
				}

				// Token: 0x0600E30A RID: 58122 RVA: 0x00354CB8 File Offset: 0x00352EB8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E30B RID: 58123 RVA: 0x00354D00 File Offset: 0x00352F00
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E30C RID: 58124 RVA: 0x00354D34 File Offset: 0x00352F34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186387, XrefRangeEnd = 186393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004674 RID: 18036
				// (get) Token: 0x0600E30D RID: 58125 RVA: 0x00354D70 File Offset: 0x00352F70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E30E RID: 58126 RVA: 0x00354DB0 File Offset: 0x00352FB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186393, XrefRangeEnd = 186398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004675 RID: 18037
				// (get) Token: 0x0600E30F RID: 58127 RVA: 0x00354DE4 File Offset: 0x00352FE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E310 RID: 58128 RVA: 0x0006EACE File Offset: 0x0006CCCE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004671 RID: 18033
				// (get) Token: 0x0600E311 RID: 58129 RVA: 0x00354E24 File Offset: 0x00353024
				// (set) Token: 0x0600E312 RID: 58130 RVA: 0x0006EAD7 File Offset: 0x0006CCD7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004672 RID: 18034
				// (get) Token: 0x0600E313 RID: 58131 RVA: 0x00354E4C File Offset: 0x0035304C
				// (set) Token: 0x0600E314 RID: 58132 RVA: 0x0006EAF2 File Offset: 0x0006CCF2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004673 RID: 18035
				// (get) Token: 0x0600E315 RID: 58133 RVA: 0x00354E7C File Offset: 0x0035307C
				// (set) Token: 0x0600E316 RID: 58134 RVA: 0x0006EB11 File Offset: 0x0006CD11
				public unsafe Customer.__c__DisplayClass183_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass183_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097F2 RID: 38898
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097F3 RID: 38899
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097F4 RID: 38900
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097F5 RID: 38901
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097F6 RID: 38902
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097F7 RID: 38903
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097F8 RID: 38904
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097F9 RID: 38905
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097FA RID: 38906
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DB RID: 2523
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass184_0")]
		public sealed class __c__DisplayClass184_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD0D RID: 52493 RVA: 0x00316878 File Offset: 0x00314A78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass184_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass184_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr);
				Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass184_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, 100674749);
				Customer.__c__DisplayClass184_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, 100674750);
			}

			// Token: 0x0600CD0E RID: 52494 RVA: 0x003168F4 File Offset: 0x00314AF4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass184_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD0F RID: 52495 RVA: 0x00316930 File Offset: 0x00314B30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186419, RefRangeEnd = 186420, XrefRangeStart = 186414, XrefRangeEnd = 186419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD10 RID: 52496 RVA: 0x00063BD3 File Offset: 0x00061DD3
			public __c__DisplayClass184_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDC RID: 16348
			// (get) Token: 0x0600CD11 RID: 52497 RVA: 0x00316970 File Offset: 0x00314B70
			// (set) Token: 0x0600CD12 RID: 52498 RVA: 0x00063BDC File Offset: 0x00061DDC
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FDD RID: 16349
			// (get) Token: 0x0600CD13 RID: 52499 RVA: 0x003169A0 File Offset: 0x00314BA0
			// (set) Token: 0x0600CD14 RID: 52500 RVA: 0x00063BFB File Offset: 0x00061DFB
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A95 RID: 35477
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A96 RID: 35478
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008A97 RID: 35479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A98 RID: 35480
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C50 RID: 3152
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass184_0+<<RecommendCustomer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E317 RID: 58135 RVA: 0x00354EAC File Offset: 0x003530AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "<<RecommendCustomer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674751);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674752);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674753);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674754);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674755);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674756);
				}

				// Token: 0x0600E318 RID: 58136 RVA: 0x00354F8C File Offset: 0x0035318C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E319 RID: 58137 RVA: 0x00354FD4 File Offset: 0x003531D4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E31A RID: 58138 RVA: 0x00355008 File Offset: 0x00353208
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186404, XrefRangeEnd = 186409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004679 RID: 18041
				// (get) Token: 0x0600E31B RID: 58139 RVA: 0x00355044 File Offset: 0x00353244
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E31C RID: 58140 RVA: 0x00355084 File Offset: 0x00353284
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186409, XrefRangeEnd = 186414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700467A RID: 18042
				// (get) Token: 0x0600E31D RID: 58141 RVA: 0x003550B8 File Offset: 0x003532B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E31E RID: 58142 RVA: 0x0006EB30 File Offset: 0x0006CD30
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004676 RID: 18038
				// (get) Token: 0x0600E31F RID: 58143 RVA: 0x003550F8 File Offset: 0x003532F8
				// (set) Token: 0x0600E320 RID: 58144 RVA: 0x0006EB39 File Offset: 0x0006CD39
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004677 RID: 18039
				// (get) Token: 0x0600E321 RID: 58145 RVA: 0x00355120 File Offset: 0x00353320
				// (set) Token: 0x0600E322 RID: 58146 RVA: 0x0006EB54 File Offset: 0x0006CD54
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004678 RID: 18040
				// (get) Token: 0x0600E323 RID: 58147 RVA: 0x00355150 File Offset: 0x00353350
				// (set) Token: 0x0600E324 RID: 58148 RVA: 0x0006EB73 File Offset: 0x0006CD73
				public unsafe Customer.__c__DisplayClass184_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass184_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097FB RID: 38907
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097FC RID: 38908
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097FD RID: 38909
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097FE RID: 38910
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097FF RID: 38911
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009800 RID: 38912
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009801 RID: 38913
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009802 RID: 38914
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009803 RID: 38915
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DC RID: 2524
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass186_0")]
		public sealed class __c__DisplayClass186_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD15 RID: 52501 RVA: 0x003169D0 File Offset: 0x00314BD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass186_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass186_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr);
				Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, "entry");
				Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, 100674757);
				Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, 100674758);
			}

			// Token: 0x0600CD16 RID: 52502 RVA: 0x00316A38 File Offset: 0x00314C38
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass186_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD17 RID: 52503 RVA: 0x00316A74 File Offset: 0x00314C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EvaluateDelivery_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD18 RID: 52504 RVA: 0x00063C1A File Offset: 0x00061E1A
			public __c__DisplayClass186_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDE RID: 16350
			// (get) Token: 0x0600CD19 RID: 52505 RVA: 0x00316AC4 File Offset: 0x00314CC4
			// (set) Token: 0x0600CD1A RID: 52506 RVA: 0x00063C23 File Offset: 0x00061E23
			public unsafe ProductList.Entry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A99 RID: 35481
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04008A9A RID: 35482
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A9B RID: 35483
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x020009DD RID: 2525
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass188_0")]
		public sealed class __c__DisplayClass188_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD1B RID: 52507 RVA: 0x00316AF4 File Offset: 0x00314CF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass188_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass188_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr);
				Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "item");
				Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, 100674759);
				Customer.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, 100674760);
			}

			// Token: 0x0600CD1C RID: 52508 RVA: 0x00316B70 File Offset: 0x00314D70
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass188_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD1D RID: 52509 RVA: 0x00316BAC File Offset: 0x00314DAC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 186438, RefRangeEnd = 186440, XrefRangeStart = 186433, XrefRangeEnd = 186438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD1E RID: 52510 RVA: 0x00063C42 File Offset: 0x00061E42
			public __c__DisplayClass188_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDF RID: 16351
			// (get) Token: 0x0600CD1F RID: 52511 RVA: 0x00316BEC File Offset: 0x00314DEC
			// (set) Token: 0x0600CD20 RID: 52512 RVA: 0x00063C4B File Offset: 0x00061E4B
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE0 RID: 16352
			// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x00316C1C File Offset: 0x00314E1C
			// (set) Token: 0x0600CD22 RID: 52514 RVA: 0x00063C6A File Offset: 0x00061E6A
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A9C RID: 35484
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008A9D RID: 35485
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A9E RID: 35486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A9F RID: 35487
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C51 RID: 3153
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass188_0+<<ConsumeProduct>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E325 RID: 58149 RVA: 0x00355180 File Offset: 0x00353380
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "<<ConsumeProduct>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674761);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674762);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674763);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674764);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674765);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674766);
				}

				// Token: 0x0600E326 RID: 58150 RVA: 0x00355260 File Offset: 0x00353460
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E327 RID: 58151 RVA: 0x003552A8 File Offset: 0x003534A8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E328 RID: 58152 RVA: 0x003552DC File Offset: 0x003534DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186420, XrefRangeEnd = 186428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700467E RID: 18046
				// (get) Token: 0x0600E329 RID: 58153 RVA: 0x00355318 File Offset: 0x00353518
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E32A RID: 58154 RVA: 0x00355358 File Offset: 0x00353558
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186428, XrefRangeEnd = 186433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700467F RID: 18047
				// (get) Token: 0x0600E32B RID: 58155 RVA: 0x0035538C File Offset: 0x0035358C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E32C RID: 58156 RVA: 0x0006EB92 File Offset: 0x0006CD92
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700467B RID: 18043
				// (get) Token: 0x0600E32D RID: 58157 RVA: 0x003553CC File Offset: 0x003535CC
				// (set) Token: 0x0600E32E RID: 58158 RVA: 0x0006EB9B File Offset: 0x0006CD9B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700467C RID: 18044
				// (get) Token: 0x0600E32F RID: 58159 RVA: 0x003553F4 File Offset: 0x003535F4
				// (set) Token: 0x0600E330 RID: 58160 RVA: 0x0006EBB6 File Offset: 0x0006CDB6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700467D RID: 18045
				// (get) Token: 0x0600E331 RID: 58161 RVA: 0x00355424 File Offset: 0x00353624
				// (set) Token: 0x0600E332 RID: 58162 RVA: 0x0006EBD5 File Offset: 0x0006CDD5
				public unsafe Customer.__c__DisplayClass188_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass188_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009804 RID: 38916
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009805 RID: 38917
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009806 RID: 38918
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009807 RID: 38919
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009808 RID: 38920
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009809 RID: 38921
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400980A RID: 38922
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400980B RID: 38923
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400980C RID: 38924
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DE RID: 2526
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass224_0")]
		public sealed class __c__DisplayClass224_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD23 RID: 52515 RVA: 0x00316C4C File Offset: 0x00314E4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass224_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass224_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr);
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "i");
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "<>9__0");
				Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, 100674767);
				Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, 100674768);
			}

			// Token: 0x0600CD24 RID: 52516 RVA: 0x00316CDC File Offset: 0x00314EDC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass224_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD25 RID: 52517 RVA: 0x00316D18 File Offset: 0x00314F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186440, XrefRangeEnd = 186448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductEnjoyment_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD26 RID: 52518 RVA: 0x00063C89 File Offset: 0x00061E89
			public __c__DisplayClass224_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE1 RID: 16353
			// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x00316D68 File Offset: 0x00314F68
			// (set) Token: 0x0600CD28 RID: 52520 RVA: 0x00063C92 File Offset: 0x00061E92
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE2 RID: 16354
			// (get) Token: 0x0600CD29 RID: 52521 RVA: 0x00316D98 File Offset: 0x00314F98
			// (set) Token: 0x0600CD2A RID: 52522 RVA: 0x00063CB1 File Offset: 0x00061EB1
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17003FE3 RID: 16355
			// (get) Token: 0x0600CD2B RID: 52523 RVA: 0x00316DC0 File Offset: 0x00314FC0
			// (set) Token: 0x0600CD2C RID: 52524 RVA: 0x00063CCC File Offset: 0x00061ECC
			public unsafe Predicate<Property> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Property>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AA0 RID: 35488
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AA1 RID: 35489
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008AA2 RID: 35490
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008AA3 RID: 35491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AA4 RID: 35492
			private static readonly IntPtr NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x020009DF RID: 2527
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass225_0")]
		public sealed class __c__DisplayClass225_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD2D RID: 52525 RVA: 0x00316DF0 File Offset: 0x00314FF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass225_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass225_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr);
				Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, "x");
				Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, 100674769);
				Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, 100674770);
			}

			// Token: 0x0600CD2E RID: 52526 RVA: 0x00316E58 File Offset: 0x00315058
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass225_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD2F RID: 52527 RVA: 0x00316E94 File Offset: 0x00315094
			[CallerCount(0)]
			public unsafe bool _GetOrderedDrugTypes_b__1(ProductTypeAffinity y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD30 RID: 52528 RVA: 0x00063CEB File Offset: 0x00061EEB
			public __c__DisplayClass225_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE4 RID: 16356
			// (get) Token: 0x0600CD31 RID: 52529 RVA: 0x00316EE4 File Offset: 0x003150E4
			// (set) Token: 0x0600CD32 RID: 52530 RVA: 0x00063CF4 File Offset: 0x00061EF4
			public unsafe EDrugType x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04008AA5 RID: 35493
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008AA6 RID: 35494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AA7 RID: 35495
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x020009E0 RID: 2528
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass226_0")]
		public sealed class __c__DisplayClass226_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD33 RID: 52531 RVA: 0x00316F0C File Offset: 0x0031510C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass226_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass226_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr);
				Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, "drugType");
				Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, 100674771);
				Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, 100674772);
			}

			// Token: 0x0600CD34 RID: 52532 RVA: 0x00316F74 File Offset: 0x00315174
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass226_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD35 RID: 52533 RVA: 0x00316FB0 File Offset: 0x003151B0
			[CallerCount(0)]
			public unsafe bool _AdjustAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD36 RID: 52534 RVA: 0x00063D0F File Offset: 0x00061F0F
			public __c__DisplayClass226_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE5 RID: 16357
			// (get) Token: 0x0600CD37 RID: 52535 RVA: 0x00317000 File Offset: 0x00315200
			// (set) Token: 0x0600CD38 RID: 52536 RVA: 0x00063D18 File Offset: 0x00061F18
			public unsafe EDrugType drugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04008AA8 RID: 35496
			private static readonly IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04008AA9 RID: 35497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AAA RID: 35498
			private static readonly IntPtr NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
