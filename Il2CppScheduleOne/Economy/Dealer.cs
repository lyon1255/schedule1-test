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
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000411 RID: 1041
	public class Dealer : NPC
	{
		// Token: 0x06005A65 RID: 23141 RVA: 0x001A420C File Offset: 0x001A240C
		// Note: this type is marked as 'beforefieldinit'.
		static Dealer()
		{
			Il2CppClassPointerStore<Dealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Dealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer>.NativeClassPtr);
			Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_CUSTOMERS");
			Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DEAL_ARRIVAL_DELAY");
			Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OVERFLOW_SLOT_COUNT");
			Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CASH_REMINDER_THRESHOLD");
			Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RELATIONSHIP_CHANGE_PER_DEAL");
			Dealer.NativeFieldInfoPtr_onDealerRecruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onDealerRecruited");
			Dealer.NativeFieldInfoPtr_DealerLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealerLabelColor");
			Dealer.NativeFieldInfoPtr_AllDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AllDealers");
			Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<IsRecruited>k__BackingField");
			Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<ItemSlots>k__BackingField");
			Dealer.NativeFieldInfoPtr_InitialCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "InitialCustomers");
			Dealer.NativeFieldInfoPtr_InitialItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "InitialItems");
			Dealer.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Home");
			Dealer.NativeFieldInfoPtr_DealSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealSignal");
			Dealer.NativeFieldInfoPtr_HomeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeEvent");
			Dealer.NativeFieldInfoPtr_DialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DialogueController");
			Dealer.NativeFieldInfoPtr_RecruitDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RecruitDialogue");
			Dealer.NativeFieldInfoPtr_CollectCashDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CollectCashDialogue");
			Dealer.NativeFieldInfoPtr_AssignCustomersDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AssignCustomersDialogue");
			Dealer.NativeFieldInfoPtr_HomeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeName");
			Dealer.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SigningFee");
			Dealer.NativeFieldInfoPtr_Cut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Cut");
			Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SellInsufficientQualityItems");
			Dealer.NativeFieldInfoPtr_SellExcessQualityItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SellExcessQualityItems");
			Dealer.NativeFieldInfoPtr_CompletedDealsVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CompletedDealsVariable");
			Dealer.NativeFieldInfoPtr__Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_AssignedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AssignedCustomers");
			Dealer.NativeFieldInfoPtr_ActiveContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "ActiveContracts");
			Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Dealer.NativeFieldInfoPtr_onRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onRecommended");
			Dealer.NativeFieldInfoPtr_OverflowSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OverflowSlots");
			Dealer.NativeFieldInfoPtr_currentContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "currentContract");
			Dealer.NativeFieldInfoPtr_recruitChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "recruitChoice");
			Dealer.NativeFieldInfoPtr_collectCashChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "collectCashChoice");
			Dealer.NativeFieldInfoPtr_assignCustomersChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "assignCustomersChoice");
			Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<potentialDealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<dealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr_acceptedContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "acceptedContractGUIDs");
			Dealer.NativeFieldInfoPtr_itemCountOnTradeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "itemCountOnTradeStart");
			Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___acceptedContractGUIDs");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674807);
			Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674808);
			Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674809);
			Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674810);
			Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674811);
			Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674812);
			Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674813);
			Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674814);
			Dealer.NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674815);
			Dealer.NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674816);
			Dealer.NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674817);
			Dealer.NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674818);
			Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674819);
			Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674820);
			Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674821);
			Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674822);
			Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674823);
			Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674824);
			Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674825);
			Dealer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674826);
			Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674827);
			Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674828);
			Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674829);
			Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674830);
			Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674831);
			Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674832);
			Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674833);
			Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674834);
			Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674835);
			Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674836);
			Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674837);
			Dealer.NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674838);
			Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674839);
			Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674840);
			Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674841);
			Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674842);
			Dealer.NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674843);
			Dealer.NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674844);
			Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674845);
			Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674846);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674847);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674848);
			Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674849);
			Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674850);
			Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674851);
			Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674852);
			Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674853);
			Dealer.NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674854);
			Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674855);
			Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674856);
			Dealer.NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674857);
			Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674858);
			Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674859);
			Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674860);
			Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674861);
			Dealer.NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674862);
			Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674863);
			Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674864);
			Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674865);
			Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674866);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674867);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674868);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674869);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674870);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674871);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674872);
			Dealer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674873);
			Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674874);
			Dealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674875);
			Dealer.NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674877);
			Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674878);
			Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674879);
			Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674880);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674881);
			Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674882);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674883);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674884);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674885);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674886);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674887);
			Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674888);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674889);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674890);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674891);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674892);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674893);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674894);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674895);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674896);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674897);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674898);
			Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674899);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674900);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674901);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674902);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674903);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674904);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674905);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674906);
			Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674907);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674908);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674909);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674910);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674911);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674912);
			Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674913);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674914);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674915);
			Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674916);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674917);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674918);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674919);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674920);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674921);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674922);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674923);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674924);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674925);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674926);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674927);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674928);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674929);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674930);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674931);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674932);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674933);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674934);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674935);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674936);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674937);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674938);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674939);
			Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674940);
			Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674941);
			Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674942);
			Dealer.NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674943);
			Dealer.NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674944);
			Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674945);
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06005A66 RID: 23142 RVA: 0x001A5088 File Offset: 0x001A3288
		// (set) Token: 0x06005A67 RID: 23143 RVA: 0x001A50C4 File Offset: 0x001A32C4
		public unsafe bool IsRecruited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06005A68 RID: 23144 RVA: 0x001A5104 File Offset: 0x001A3304
		// (set) Token: 0x06005A69 RID: 23145 RVA: 0x001A5144 File Offset: 0x001A3344
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06005A6A RID: 23146 RVA: 0x001A5188 File Offset: 0x001A3388
		// (set) Token: 0x06005A6B RID: 23147 RVA: 0x001A51C4 File Offset: 0x001A33C4
		public unsafe float Cash
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190678, RefRangeEnd = 190680, XrefRangeStart = 190678, XrefRangeEnd = 190678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190680, XrefRangeEnd = 190687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06005A6C RID: 23148 RVA: 0x001A5204 File Offset: 0x001A3404
		// (set) Token: 0x06005A6D RID: 23149 RVA: 0x001A5240 File Offset: 0x001A3440
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06005A6E RID: 23150 RVA: 0x001A5280 File Offset: 0x001A3480
		// (set) Token: 0x06005A6F RID: 23151 RVA: 0x001A52C0 File Offset: 0x001A34C0
		public unsafe NPCPoI potentialDealerPoI
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94041, RefRangeEnd = 94045, XrefRangeStart = 94041, XrefRangeEnd = 94045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06005A70 RID: 23152 RVA: 0x001A5304 File Offset: 0x001A3504
		// (set) Token: 0x06005A71 RID: 23153 RVA: 0x001A5344 File Offset: 0x001A3544
		public unsafe NPCPoI dealerPoI
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x001A5388 File Offset: 0x001A3588
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 190688, RefRangeEnd = 190694, XrefRangeStart = 190687, XrefRangeEnd = 190688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x001A53C4 File Offset: 0x001A35C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190694, XrefRangeEnd = 190697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x001A5400 File Offset: 0x001A3600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190697, XrefRangeEnd = 190706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x001A543C File Offset: 0x001A363C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190706, XrefRangeEnd = 190764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x001A5478 File Offset: 0x001A3678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190764, XrefRangeEnd = 190781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x001A54C8 File Offset: 0x001A36C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190834, RefRangeEnd = 190835, XrefRangeStart = 190781, XrefRangeEnd = 190834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x001A54FC File Offset: 0x001A36FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190865, RefRangeEnd = 190866, XrefRangeStart = 190835, XrefRangeEnd = 190865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x001A5530 File Offset: 0x001A3730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190884, RefRangeEnd = 190885, XrefRangeStart = 190866, XrefRangeEnd = 190884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x001A556C File Offset: 0x001A376C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190906, RefRangeEnd = 190907, XrefRangeStart = 190885, XrefRangeEnd = 190906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x001A55A0 File Offset: 0x001A37A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190927, RefRangeEnd = 190930, XrefRangeStart = 190907, XrefRangeEnd = 190927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x001A55D4 File Offset: 0x001A37D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190950, RefRangeEnd = 190951, XrefRangeStart = 190930, XrefRangeEnd = 190950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialRecruitment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x001A5608 File Offset: 0x001A3808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190951, XrefRangeEnd = 190988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRecruited(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x001A5658 File Offset: 0x001A3858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190988, XrefRangeEnd = 190993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x001A56B0 File Offset: 0x001A38B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191008, RefRangeEnd = 191009, XrefRangeStart = 190993, XrefRangeEnd = 191008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePotentialDealerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x001A56EC File Offset: 0x001A38EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191009, XrefRangeEnd = 191032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x001A5720 File Offset: 0x001A3920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191032, XrefRangeEnd = 191051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x001A5754 File Offset: 0x001A3954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191051, XrefRangeEnd = 191054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCollectCash(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x001A57AC File Offset: 0x001A39AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191061, RefRangeEnd = 191064, XrefRangeStart = 191054, XrefRangeEnd = 191061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldCash;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x001A5808 File Offset: 0x001A3A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191064, XrefRangeEnd = 191071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x001A583C File Offset: 0x001A3A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191071, XrefRangeEnd = 191075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x001A5870 File Offset: 0x001A3A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191075, XrefRangeEnd = 191082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOfferRecruitment(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x001A58C8 File Offset: 0x001A3AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191124, RefRangeEnd = 191125, XrefRangeStart = 191082, XrefRangeEnd = 191124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttendStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x001A58FC File Offset: 0x001A3AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191125, XrefRangeEnd = 191167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x001A5968 File Offset: 0x001A3B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191167, XrefRangeEnd = 191184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x001A59C8 File Offset: 0x001A3BC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191206, RefRangeEnd = 191209, XrefRangeStart = 191184, XrefRangeEnd = 191206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAddCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x001A5A0C File Offset: 0x001A3C0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191251, RefRangeEnd = 191255, XrefRangeStart = 191209, XrefRangeEnd = 191251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x001A5A60 File Offset: 0x001A3C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191273, RefRangeEnd = 191274, XrefRangeStart = 191255, XrefRangeEnd = 191273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x001A5AB0 File Offset: 0x001A3CB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191296, RefRangeEnd = 191298, XrefRangeStart = 191274, XrefRangeEnd = 191296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x001A5AF4 File Offset: 0x001A3CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191320, RefRangeEnd = 191322, XrefRangeStart = 191298, XrefRangeEnd = 191320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x001A5B38 File Offset: 0x001A3D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191338, RefRangeEnd = 191339, XrefRangeStart = 191322, XrefRangeEnd = 191338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x001A5B88 File Offset: 0x001A3D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191339, XrefRangeEnd = 191340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCash(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x001A5BC8 File Offset: 0x001A3DC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191359, RefRangeEnd = 191364, XrefRangeStart = 191340, XrefRangeEnd = 191359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCash(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x001A5C08 File Offset: 0x001A3E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191364, XrefRangeEnd = 191382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompletedDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x001A5C44 File Offset: 0x001A3E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191401, RefRangeEnd = 191402, XrefRangeStart = 191382, XrefRangeEnd = 191401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitPayment(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x001A5C84 File Offset: 0x001A3E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191456, RefRangeEnd = 191457, XrefRangeStart = 191402, XrefRangeEnd = 191456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetOrderableProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x001A5CC4 File Offset: 0x001A3EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191477, RefRangeEnd = 191479, XrefRangeStart = 191457, XrefRangeEnd = 191477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x001A5D30 File Offset: 0x001A3F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191529, RefRangeEnd = 191530, XrefRangeStart = 191479, XrefRangeEnd = 191529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDealWindow GetDealWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x001A5D6C File Offset: 0x001A3F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191549, RefRangeEnd = 191550, XrefRangeStart = 191530, XrefRangeEnd = 191549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetContractCountInWindow(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x001A5DB8 File Offset: 0x001A3FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191578, RefRangeEnd = 191579, XrefRangeStart = 191550, XrefRangeEnd = 191578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractStarted(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A99 RID: 23193 RVA: 0x001A5DFC File Offset: 0x001A3FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191579, XrefRangeEnd = 191596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractEnded(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x001A5E40 File Offset: 0x001A4040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191596, XrefRangeEnd = 191618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortContracts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x001A5E74 File Offset: 0x001A4074
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecruitmentRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x001A5EB0 File Offset: 0x001A40B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191662, RefRangeEnd = 191663, XrefRangeStart = 191618, XrefRangeEnd = 191662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetQuality;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			items = ((intPtr4 == 0) ? null : new List<ItemInstance>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x001A5F30 File Offset: 0x001A4130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191839, RefRangeEnd = 191840, XrefRangeStart = 191663, XrefRangeEnd = 191839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetItems(string ID, int requiredQuantity, Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qualityCheck);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x001A5FB0 File Offset: 0x001A41B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 191849, RefRangeEnd = 191855, XrefRangeStart = 191840, XrefRangeEnd = 191849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x001A5FF0 File Offset: 0x001A41F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191873, RefRangeEnd = 191874, XrefRangeStart = 191855, XrefRangeEnd = 191873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x001A6034 File Offset: 0x001A4234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191879, RefRangeEnd = 191881, XrefRangeStart = 191874, XrefRangeEnd = 191879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryMoveOverflowItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x001A6068 File Offset: 0x001A4268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191896, RefRangeEnd = 191898, XrefRangeStart = 191881, XrefRangeEnd = 191896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalInventoryItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x001A60A4 File Offset: 0x001A42A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191898, XrefRangeEnd = 191925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x001A6108 File Offset: 0x001A4308
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191950, RefRangeEnd = 191953, XrefRangeStart = 191925, XrefRangeEnd = 191950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x001A616C File Offset: 0x001A436C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191953, XrefRangeEnd = 191978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x001A61B8 File Offset: 0x001A43B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192006, RefRangeEnd = 192009, XrefRangeStart = 191978, XrefRangeEnd = 192006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x001A6204 File Offset: 0x001A4404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192009, XrefRangeEnd = 192038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x001A6288 File Offset: 0x001A4488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192088, RefRangeEnd = 192091, XrefRangeStart = 192038, XrefRangeEnd = 192088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x001A630C File Offset: 0x001A450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192091, XrefRangeEnd = 192117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x001A6350 File Offset: 0x001A4550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192117, XrefRangeEnd = 192209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x001A63B0 File Offset: 0x001A45B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192262, RefRangeEnd = 192268, XrefRangeStart = 192209, XrefRangeEnd = 192262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x001A63EC File Offset: 0x001A45EC
		[CallerCount(0)]
		public unsafe void _Awake_b__59_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x001A6438 File Offset: 0x001A4638
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192431, RefRangeEnd = 192437, XrefRangeStart = 192268, XrefRangeEnd = 192431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x001A6474 File Offset: 0x001A4674
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192438, RefRangeEnd = 192444, XrefRangeStart = 192437, XrefRangeEnd = 192438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x001A64B0 File Offset: 0x001A46B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x001A64EC File Offset: 0x001A46EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192444, XrefRangeEnd = 192462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x001A6520 File Offset: 0x001A4720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190927, RefRangeEnd = 190930, XrefRangeStart = 190927, XrefRangeEnd = 190930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x001A6554 File Offset: 0x001A4754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192462, XrefRangeEnd = 192465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x001A65B8 File Offset: 0x001A47B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192465, XrefRangeEnd = 192483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x001A65EC File Offset: 0x001A47EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192483, XrefRangeEnd = 192484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x001A6620 File Offset: 0x001A4820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192484, XrefRangeEnd = 192487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x001A6670 File Offset: 0x001A4870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192487, XrefRangeEnd = 192505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x001A66A4 File Offset: 0x001A48A4
		[CallerCount(0)]
		public unsafe void RpcLogic___InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x001A66D8 File Offset: 0x001A48D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192505, XrefRangeEnd = 192507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x001A673C File Offset: 0x001A493C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192507, XrefRangeEnd = 192525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x001A6780 File Offset: 0x001A4980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192587, RefRangeEnd = 192590, XrefRangeStart = 192525, XrefRangeEnd = 192587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x001A67D0 File Offset: 0x001A49D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192590, XrefRangeEnd = 192593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x001A6820 File Offset: 0x001A4A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192593, XrefRangeEnd = 192611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x001A6864 File Offset: 0x001A4A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192611, XrefRangeEnd = 192614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x001A68B4 File Offset: 0x001A4AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192614, XrefRangeEnd = 192633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x001A68F8 File Offset: 0x001A4AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192633, XrefRangeEnd = 192634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x001A693C File Offset: 0x001A4B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192634, XrefRangeEnd = 192638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x001A69A0 File Offset: 0x001A4BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192638, XrefRangeEnd = 192657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x001A69F4 File Offset: 0x001A4BF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192685, RefRangeEnd = 192688, XrefRangeStart = 192657, XrefRangeEnd = 192685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x001A6A48 File Offset: 0x001A4C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192688, XrefRangeEnd = 192692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x001A6A98 File Offset: 0x001A4C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192692, XrefRangeEnd = 192711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x001A6AEC File Offset: 0x001A4CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192711, XrefRangeEnd = 192715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x001A6B3C File Offset: 0x001A4D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192715, XrefRangeEnd = 192734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x001A6B80 File Offset: 0x001A4D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191320, RefRangeEnd = 191322, XrefRangeStart = 191320, XrefRangeEnd = 191322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x001A6BC4 File Offset: 0x001A4DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192734, XrefRangeEnd = 192738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x001A6C28 File Offset: 0x001A4E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192738, XrefRangeEnd = 192757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x001A6C6C File Offset: 0x001A4E6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192785, RefRangeEnd = 192788, XrefRangeStart = 192757, XrefRangeEnd = 192785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x001A6CB0 File Offset: 0x001A4EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192788, XrefRangeEnd = 192792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x001A6D00 File Offset: 0x001A4F00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191359, RefRangeEnd = 191364, XrefRangeStart = 191359, XrefRangeEnd = 191364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x001A6D40 File Offset: 0x001A4F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192792, XrefRangeEnd = 192801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x001A6D80 File Offset: 0x001A4F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192801, XrefRangeEnd = 192812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x001A6DE4 File Offset: 0x001A4FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x001A6E18 File Offset: 0x001A5018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192827, RefRangeEnd = 192828, XrefRangeStart = 192812, XrefRangeEnd = 192827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x001A6E54 File Offset: 0x001A5054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192828, XrefRangeEnd = 192830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x001A6EB8 File Offset: 0x001A50B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191401, RefRangeEnd = 191402, XrefRangeStart = 191401, XrefRangeEnd = 191402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x001A6EF8 File Offset: 0x001A50F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192830, XrefRangeEnd = 192854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x001A6F38 File Offset: 0x001A5138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192854, XrefRangeEnd = 192880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x001A6F9C File Offset: 0x001A519C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192880, XrefRangeEnd = 192893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x001A7000 File Offset: 0x001A5200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192893, XrefRangeEnd = 192897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x001A7064 File Offset: 0x001A5264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192897, XrefRangeEnd = 192905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x001A70C8 File Offset: 0x001A52C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192905, XrefRangeEnd = 192926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x001A712C File Offset: 0x001A532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192926, XrefRangeEnd = 192932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x001A7190 File Offset: 0x001A5390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192932, XrefRangeEnd = 192940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x001A71E0 File Offset: 0x001A53E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192940, XrefRangeEnd = 192952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x001A7244 File Offset: 0x001A5444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192952, XrefRangeEnd = 192961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x001A7294 File Offset: 0x001A5494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192961, XrefRangeEnd = 192983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x001A72E0 File Offset: 0x001A54E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192983, XrefRangeEnd = 192984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x001A732C File Offset: 0x001A552C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192984, XrefRangeEnd = 192991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x001A7390 File Offset: 0x001A5590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192991, XrefRangeEnd = 193013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x001A73DC File Offset: 0x001A55DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193018, RefRangeEnd = 193019, XrefRangeStart = 193013, XrefRangeEnd = 193018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x001A7428 File Offset: 0x001A5628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193019, XrefRangeEnd = 193026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x001A7478 File Offset: 0x001A5678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193026, XrefRangeEnd = 193041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x001A74FC File Offset: 0x001A56FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193041, XrefRangeEnd = 193045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x001A7580 File Offset: 0x001A5780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193045, XrefRangeEnd = 193054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x001A75E4 File Offset: 0x001A57E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193054, XrefRangeEnd = 193068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x001A7668 File Offset: 0x001A5868
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193076, RefRangeEnd = 193079, XrefRangeStart = 193068, XrefRangeEnd = 193076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x001A76EC File Offset: 0x001A58EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193079, XrefRangeEnd = 193087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x001A773C File Offset: 0x001A593C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193087, XrefRangeEnd = 193110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x001A77C0 File Offset: 0x001A59C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193110, XrefRangeEnd = 193117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06005AEA RID: 23274 RVA: 0x001A7810 File Offset: 0x001A5A10
		// (set) Token: 0x06005AEB RID: 23275 RVA: 0x001A784C File Offset: 0x001A5A4C
		public unsafe float SyncAccessor_<Cash>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190678, RefRangeEnd = 190680, XrefRangeStart = 190678, XrefRangeEnd = 190680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 193125, RefRangeEnd = 193127, XrefRangeStart = 193117, XrefRangeEnd = 193125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x001A7898 File Offset: 0x001A5A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193127, XrefRangeEnd = 193139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x001A790C File Offset: 0x001A5B0C
		// (set) Token: 0x06005AEE RID: 23278 RVA: 0x001A794C File Offset: 0x001A5B4C
		public unsafe List<string> SyncAccessor_acceptedContractGUIDs
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184639, RefRangeEnd = 184641, XrefRangeStart = 184639, XrefRangeEnd = 184641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 193148, RefRangeEnd = 193149, XrefRangeStart = 193139, XrefRangeEnd = 193148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x001A799C File Offset: 0x001A5B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193190, RefRangeEnd = 193191, XrefRangeStart = 193149, XrefRangeEnd = 193190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x0002AB93 File Offset: 0x00028D93
		public Dealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06005AF1 RID: 23281 RVA: 0x001A79D8 File Offset: 0x001A5BD8
		// (set) Token: 0x06005AF2 RID: 23282 RVA: 0x0002AB9C File Offset: 0x00028D9C
		public unsafe static int MAX_CUSTOMERS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&value));
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06005AF3 RID: 23283 RVA: 0x001A79F4 File Offset: 0x001A5BF4
		// (set) Token: 0x06005AF4 RID: 23284 RVA: 0x0002ABAA File Offset: 0x00028DAA
		public unsafe static int DEAL_ARRIVAL_DELAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&value));
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x001A7A10 File Offset: 0x001A5C10
		// (set) Token: 0x06005AF6 RID: 23286 RVA: 0x0002ABB8 File Offset: 0x00028DB8
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06005AF7 RID: 23287 RVA: 0x001A7A2C File Offset: 0x001A5C2C
		// (set) Token: 0x06005AF8 RID: 23288 RVA: 0x0002ABC6 File Offset: 0x00028DC6
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06005AF9 RID: 23289 RVA: 0x001A7A48 File Offset: 0x001A5C48
		// (set) Token: 0x06005AFA RID: 23290 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		public unsafe static int OVERFLOW_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06005AFB RID: 23291 RVA: 0x001A7A64 File Offset: 0x001A5C64
		// (set) Token: 0x06005AFC RID: 23292 RVA: 0x0002ABE2 File Offset: 0x00028DE2
		public unsafe static float CASH_REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005AFD RID: 23293 RVA: 0x001A7A80 File Offset: 0x001A5C80
		// (set) Token: 0x06005AFE RID: 23294 RVA: 0x0002ABF0 File Offset: 0x00028DF0
		public unsafe static float RELATIONSHIP_CHANGE_PER_DEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&value));
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005AFF RID: 23295 RVA: 0x001A7A9C File Offset: 0x001A5C9C
		// (set) Token: 0x06005B00 RID: 23296 RVA: 0x0002ABFE File Offset: 0x00028DFE
		public unsafe static Action<Dealer> onDealerRecruited
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06005B01 RID: 23297 RVA: 0x001A7AC4 File Offset: 0x001A5CC4
		// (set) Token: 0x06005B02 RID: 23298 RVA: 0x0002AC10 File Offset: 0x00028E10
		public unsafe static Color32 DealerLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&value));
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06005B03 RID: 23299 RVA: 0x001A7AE0 File Offset: 0x001A5CE0
		// (set) Token: 0x06005B04 RID: 23300 RVA: 0x0002AC1E File Offset: 0x00028E1E
		public unsafe static List<Dealer> AllDealers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_AllDealers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_AllDealers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005B05 RID: 23301 RVA: 0x001A7B08 File Offset: 0x001A5D08
		// (set) Token: 0x06005B06 RID: 23302 RVA: 0x0002AC30 File Offset: 0x00028E30
		public unsafe bool _IsRecruited_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06005B07 RID: 23303 RVA: 0x001A7B30 File Offset: 0x001A5D30
		// (set) Token: 0x06005B08 RID: 23304 RVA: 0x0002AC4B File Offset: 0x00028E4B
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06005B09 RID: 23305 RVA: 0x001A7B60 File Offset: 0x001A5D60
		// (set) Token: 0x06005B0A RID: 23306 RVA: 0x0002AC6A File Offset: 0x00028E6A
		public unsafe List<Customer> InitialCustomers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialCustomers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialCustomers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06005B0B RID: 23307 RVA: 0x001A7B90 File Offset: 0x001A5D90
		// (set) Token: 0x06005B0C RID: 23308 RVA: 0x0002AC89 File Offset: 0x00028E89
		public unsafe List<ProductDefinition> InitialItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06005B0D RID: 23309 RVA: 0x001A7BC0 File Offset: 0x001A5DC0
		// (set) Token: 0x06005B0E RID: 23310 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		public unsafe NPCEnterableBuilding Home
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06005B0F RID: 23311 RVA: 0x001A7BF0 File Offset: 0x001A5DF0
		// (set) Token: 0x06005B10 RID: 23312 RVA: 0x0002ACC7 File Offset: 0x00028EC7
		public unsafe NPCSignal_HandleDeal DealSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DealSignal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_HandleDeal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DealSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06005B11 RID: 23313 RVA: 0x001A7C20 File Offset: 0x001A5E20
		// (set) Token: 0x06005B12 RID: 23314 RVA: 0x0002ACE6 File Offset: 0x00028EE6
		public unsafe NPCEvent_StayInBuilding HomeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_StayInBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06005B13 RID: 23315 RVA: 0x001A7C50 File Offset: 0x001A5E50
		// (set) Token: 0x06005B14 RID: 23316 RVA: 0x0002AD05 File Offset: 0x00028F05
		public unsafe DialogueController_Dealer DialogueController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x001A7C80 File Offset: 0x001A5E80
		// (set) Token: 0x06005B16 RID: 23318 RVA: 0x0002AD24 File Offset: 0x00028F24
		public unsafe DialogueContainer RecruitDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_RecruitDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_RecruitDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06005B17 RID: 23319 RVA: 0x001A7CB0 File Offset: 0x001A5EB0
		// (set) Token: 0x06005B18 RID: 23320 RVA: 0x0002AD43 File Offset: 0x00028F43
		public unsafe DialogueContainer CollectCashDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CollectCashDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CollectCashDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x001A7CE0 File Offset: 0x001A5EE0
		// (set) Token: 0x06005B1A RID: 23322 RVA: 0x0002AD62 File Offset: 0x00028F62
		public unsafe DialogueContainer AssignCustomersDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignCustomersDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignCustomersDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06005B1B RID: 23323 RVA: 0x001A7D10 File Offset: 0x001A5F10
		// (set) Token: 0x06005B1C RID: 23324 RVA: 0x0002AD81 File Offset: 0x00028F81
		public unsafe string HomeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x001A7D38 File Offset: 0x001A5F38
		// (set) Token: 0x06005B1E RID: 23326 RVA: 0x0002ADA0 File Offset: 0x00028FA0
		public unsafe float SigningFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x001A7D60 File Offset: 0x001A5F60
		// (set) Token: 0x06005B20 RID: 23328 RVA: 0x0002ADBB File Offset: 0x00028FBB
		public unsafe float Cut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Cut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Cut)) = value;
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06005B21 RID: 23329 RVA: 0x001A7D88 File Offset: 0x001A5F88
		// (set) Token: 0x06005B22 RID: 23330 RVA: 0x0002ADD6 File Offset: 0x00028FD6
		public unsafe bool SellInsufficientQualityItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems)) = value;
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06005B23 RID: 23331 RVA: 0x001A7DB0 File Offset: 0x001A5FB0
		// (set) Token: 0x06005B24 RID: 23332 RVA: 0x0002ADF1 File Offset: 0x00028FF1
		public unsafe bool SellExcessQualityItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellExcessQualityItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellExcessQualityItems)) = value;
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06005B25 RID: 23333 RVA: 0x001A7DD8 File Offset: 0x001A5FD8
		// (set) Token: 0x06005B26 RID: 23334 RVA: 0x0002AE0C File Offset: 0x0002900C
		public unsafe string CompletedDealsVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CompletedDealsVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CompletedDealsVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06005B27 RID: 23335 RVA: 0x001A7E00 File Offset: 0x001A6000
		// (set) Token: 0x06005B28 RID: 23336 RVA: 0x0002AE2B File Offset: 0x0002902B
		public unsafe float _Cash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06005B29 RID: 23337 RVA: 0x001A7E28 File Offset: 0x001A6028
		// (set) Token: 0x06005B2A RID: 23338 RVA: 0x0002AE46 File Offset: 0x00029046
		public unsafe List<Customer> AssignedCustomers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignedCustomers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignedCustomers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06005B2B RID: 23339 RVA: 0x001A7E58 File Offset: 0x001A6058
		// (set) Token: 0x06005B2C RID: 23340 RVA: 0x0002AE65 File Offset: 0x00029065
		public unsafe List<Contract> ActiveContracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_ActiveContracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_ActiveContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06005B2D RID: 23341 RVA: 0x001A7E88 File Offset: 0x001A6088
		// (set) Token: 0x06005B2E RID: 23342 RVA: 0x0002AE84 File Offset: 0x00029084
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06005B2F RID: 23343 RVA: 0x001A7EB0 File Offset: 0x001A60B0
		// (set) Token: 0x06005B30 RID: 23344 RVA: 0x0002AE9F File Offset: 0x0002909F
		public unsafe UnityEvent onRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onRecommended);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onRecommended), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06005B31 RID: 23345 RVA: 0x001A7EE0 File Offset: 0x001A60E0
		// (set) Token: 0x06005B32 RID: 23346 RVA: 0x0002AEBE File Offset: 0x000290BE
		public unsafe Il2CppReferenceArray<ItemSlot> OverflowSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OverflowSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OverflowSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x001A7F10 File Offset: 0x001A6110
		// (set) Token: 0x06005B34 RID: 23348 RVA: 0x0002AEDD File Offset: 0x000290DD
		public unsafe Contract currentContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06005B35 RID: 23349 RVA: 0x001A7F40 File Offset: 0x001A6140
		// (set) Token: 0x06005B36 RID: 23350 RVA: 0x0002AEFC File Offset: 0x000290FC
		public unsafe DialogueController.DialogueChoice recruitChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x001A7F70 File Offset: 0x001A6170
		// (set) Token: 0x06005B38 RID: 23352 RVA: 0x0002AF1B File Offset: 0x0002911B
		public unsafe DialogueController.DialogueChoice collectCashChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06005B39 RID: 23353 RVA: 0x001A7FA0 File Offset: 0x001A61A0
		// (set) Token: 0x06005B3A RID: 23354 RVA: 0x0002AF3A File Offset: 0x0002913A
		public unsafe DialogueController.DialogueChoice assignCustomersChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06005B3B RID: 23355 RVA: 0x001A7FD0 File Offset: 0x001A61D0
		// (set) Token: 0x06005B3C RID: 23356 RVA: 0x0002AF59 File Offset: 0x00029159
		public unsafe NPCPoI _potentialDealerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06005B3D RID: 23357 RVA: 0x001A8000 File Offset: 0x001A6200
		// (set) Token: 0x06005B3E RID: 23358 RVA: 0x0002AF78 File Offset: 0x00029178
		public unsafe NPCPoI _dealerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x001A8030 File Offset: 0x001A6230
		// (set) Token: 0x06005B40 RID: 23360 RVA: 0x0002AF97 File Offset: 0x00029197
		public unsafe List<string> acceptedContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_acceptedContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_acceptedContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06005B41 RID: 23361 RVA: 0x001A8060 File Offset: 0x001A6260
		// (set) Token: 0x06005B42 RID: 23362 RVA: 0x0002AFB6 File Offset: 0x000291B6
		public unsafe int itemCountOnTradeStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart)) = value;
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06005B43 RID: 23363 RVA: 0x001A8088 File Offset: 0x001A6288
		// (set) Token: 0x06005B44 RID: 23364 RVA: 0x0002AFD1 File Offset: 0x000291D1
		public unsafe SyncVar<float> syncVar____Cash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06005B45 RID: 23365 RVA: 0x001A80B8 File Offset: 0x001A62B8
		// (set) Token: 0x06005B46 RID: 23366 RVA: 0x0002AFF0 File Offset: 0x000291F0
		public unsafe SyncVar<List<string>> syncVar___acceptedContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06005B47 RID: 23367 RVA: 0x001A80E8 File Offset: 0x001A62E8
		// (set) Token: 0x06005B48 RID: 23368 RVA: 0x0002B00F File Offset: 0x0002920F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06005B49 RID: 23369 RVA: 0x001A8110 File Offset: 0x001A6310
		// (set) Token: 0x06005B4A RID: 23370 RVA: 0x0002B02A File Offset: 0x0002922A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003DB5 RID: 15797
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CUSTOMERS;

		// Token: 0x04003DB6 RID: 15798
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY;

		// Token: 0x04003DB7 RID: 15799
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003DB8 RID: 15800
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003DB9 RID: 15801
		private static readonly IntPtr NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT;

		// Token: 0x04003DBA RID: 15802
		private static readonly IntPtr NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD;

		// Token: 0x04003DBB RID: 15803
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL;

		// Token: 0x04003DBC RID: 15804
		private static readonly IntPtr NativeFieldInfoPtr_onDealerRecruited;

		// Token: 0x04003DBD RID: 15805
		private static readonly IntPtr NativeFieldInfoPtr_DealerLabelColor;

		// Token: 0x04003DBE RID: 15806
		private static readonly IntPtr NativeFieldInfoPtr_AllDealers;

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeFieldInfoPtr__IsRecruited_k__BackingField;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeFieldInfoPtr_InitialCustomers;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeFieldInfoPtr_InitialItems;

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeFieldInfoPtr_DealSignal;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeFieldInfoPtr_HomeEvent;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeFieldInfoPtr_DialogueController;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeFieldInfoPtr_RecruitDialogue;

		// Token: 0x04003DC8 RID: 15816
		private static readonly IntPtr NativeFieldInfoPtr_CollectCashDialogue;

		// Token: 0x04003DC9 RID: 15817
		private static readonly IntPtr NativeFieldInfoPtr_AssignCustomersDialogue;

		// Token: 0x04003DCA RID: 15818
		private static readonly IntPtr NativeFieldInfoPtr_HomeName;

		// Token: 0x04003DCB RID: 15819
		private static readonly IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003DCC RID: 15820
		private static readonly IntPtr NativeFieldInfoPtr_Cut;

		// Token: 0x04003DCD RID: 15821
		private static readonly IntPtr NativeFieldInfoPtr_SellInsufficientQualityItems;

		// Token: 0x04003DCE RID: 15822
		private static readonly IntPtr NativeFieldInfoPtr_SellExcessQualityItems;

		// Token: 0x04003DCF RID: 15823
		private static readonly IntPtr NativeFieldInfoPtr_CompletedDealsVariable;

		// Token: 0x04003DD0 RID: 15824
		private static readonly IntPtr NativeFieldInfoPtr__Cash_k__BackingField;

		// Token: 0x04003DD1 RID: 15825
		private static readonly IntPtr NativeFieldInfoPtr_AssignedCustomers;

		// Token: 0x04003DD2 RID: 15826
		private static readonly IntPtr NativeFieldInfoPtr_ActiveContracts;

		// Token: 0x04003DD3 RID: 15827
		private static readonly IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003DD4 RID: 15828
		private static readonly IntPtr NativeFieldInfoPtr_onRecommended;

		// Token: 0x04003DD5 RID: 15829
		private static readonly IntPtr NativeFieldInfoPtr_OverflowSlots;

		// Token: 0x04003DD6 RID: 15830
		private static readonly IntPtr NativeFieldInfoPtr_currentContract;

		// Token: 0x04003DD7 RID: 15831
		private static readonly IntPtr NativeFieldInfoPtr_recruitChoice;

		// Token: 0x04003DD8 RID: 15832
		private static readonly IntPtr NativeFieldInfoPtr_collectCashChoice;

		// Token: 0x04003DD9 RID: 15833
		private static readonly IntPtr NativeFieldInfoPtr_assignCustomersChoice;

		// Token: 0x04003DDA RID: 15834
		private static readonly IntPtr NativeFieldInfoPtr__potentialDealerPoI_k__BackingField;

		// Token: 0x04003DDB RID: 15835
		private static readonly IntPtr NativeFieldInfoPtr__dealerPoI_k__BackingField;

		// Token: 0x04003DDC RID: 15836
		private static readonly IntPtr NativeFieldInfoPtr_acceptedContractGUIDs;

		// Token: 0x04003DDD RID: 15837
		private static readonly IntPtr NativeFieldInfoPtr_itemCountOnTradeStart;

		// Token: 0x04003DDE RID: 15838
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Cash_k__BackingField;

		// Token: 0x04003DDF RID: 15839
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___acceptedContractGUIDs;

		// Token: 0x04003DE0 RID: 15840
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003DE1 RID: 15841
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003DE2 RID: 15842
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0;

		// Token: 0x04003DE3 RID: 15843
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0;

		// Token: 0x04003DE4 RID: 15844
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04003DE5 RID: 15845
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04003DE6 RID: 15846
		private static readonly IntPtr NativeMethodInfoPtr_get_Cash_Public_get_Single_0;

		// Token: 0x04003DE7 RID: 15847
		private static readonly IntPtr NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0;

		// Token: 0x04003DE8 RID: 15848
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003DE9 RID: 15849
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0;

		// Token: 0x04003DEA RID: 15850
		private static readonly IntPtr NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003DEB RID: 15851
		private static readonly IntPtr NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0;

		// Token: 0x04003DEC RID: 15852
		private static readonly IntPtr NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003DED RID: 15853
		private static readonly IntPtr NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0;

		// Token: 0x04003DEE RID: 15854
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003DEF RID: 15855
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1;

		// Token: 0x04003DF0 RID: 15856
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04003DF1 RID: 15857
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003DF2 RID: 15858
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003DF3 RID: 15859
		private static readonly IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_0;

		// Token: 0x04003DF4 RID: 15860
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x04003DF5 RID: 15861
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04003DF6 RID: 15862
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0;

		// Token: 0x04003DF7 RID: 15863
		private static readonly IntPtr NativeMethodInfoPtr_SetRecommended_Private_Void_0;

		// Token: 0x04003DF8 RID: 15864
		private static readonly IntPtr NativeMethodInfoPtr_InitialRecruitment_Public_Void_0;

		// Token: 0x04003DF9 RID: 15865
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003DFA RID: 15866
		private static readonly IntPtr NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003DFB RID: 15867
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0;

		// Token: 0x04003DFC RID: 15868
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x04003DFD RID: 15869
		private static readonly IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x04003DFE RID: 15870
		private static readonly IntPtr NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0;

		// Token: 0x04003DFF RID: 15871
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04003E00 RID: 15872
		private static readonly IntPtr NativeMethodInfoPtr_CollectCash_Private_Void_0;

		// Token: 0x04003E01 RID: 15873
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0;

		// Token: 0x04003E02 RID: 15874
		private static readonly IntPtr NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0;

		// Token: 0x04003E03 RID: 15875
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttendStart_Private_Void_0;

		// Token: 0x04003E04 RID: 15876
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0;

		// Token: 0x04003E05 RID: 15877
		private static readonly IntPtr NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0;

		// Token: 0x04003E06 RID: 15878
		private static readonly IntPtr NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0;

		// Token: 0x04003E07 RID: 15879
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E08 RID: 15880
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0;

		// Token: 0x04003E09 RID: 15881
		private static readonly IntPtr NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0;

		// Token: 0x04003E0A RID: 15882
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0;

		// Token: 0x04003E0B RID: 15883
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0;

		// Token: 0x04003E0C RID: 15884
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0;

		// Token: 0x04003E0D RID: 15885
		private static readonly IntPtr NativeMethodInfoPtr_SetCash_Public_Void_Single_0;

		// Token: 0x04003E0E RID: 15886
		private static readonly IntPtr NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0;

		// Token: 0x04003E0F RID: 15887
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0;

		// Token: 0x04003E10 RID: 15888
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0;

		// Token: 0x04003E11 RID: 15889
		private static readonly IntPtr NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0;

		// Token: 0x04003E12 RID: 15890
		private static readonly IntPtr NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0;

		// Token: 0x04003E13 RID: 15891
		private static readonly IntPtr NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0;

		// Token: 0x04003E14 RID: 15892
		private static readonly IntPtr NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0;

		// Token: 0x04003E15 RID: 15893
		private static readonly IntPtr NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0;

		// Token: 0x04003E16 RID: 15894
		private static readonly IntPtr NativeMethodInfoPtr_SortContracts_Private_Void_0;

		// Token: 0x04003E17 RID: 15895
		private static readonly IntPtr NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003E18 RID: 15896
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0;

		// Token: 0x04003E19 RID: 15897
		private static readonly IntPtr NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0;

		// Token: 0x04003E1A RID: 15898
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04003E1B RID: 15899
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x04003E1C RID: 15900
		private static readonly IntPtr NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0;

		// Token: 0x04003E1D RID: 15901
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0;

		// Token: 0x04003E1E RID: 15902
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E1F RID: 15903
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E20 RID: 15904
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003E21 RID: 15905
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E23 RID: 15907
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E24 RID: 15908
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003E25 RID: 15909
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04003E26 RID: 15910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0;

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0;

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0;

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E37 RID: 15927
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003E38 RID: 15928
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0;

		// Token: 0x04003E43 RID: 15939
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E44 RID: 15940
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E45 RID: 15941
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E46 RID: 15942
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E47 RID: 15943
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0;

		// Token: 0x04003E48 RID: 15944
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0;

		// Token: 0x04003E49 RID: 15945
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E4A RID: 15946
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0;

		// Token: 0x04003E4B RID: 15947
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003E4C RID: 15948
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E4D RID: 15949
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0;

		// Token: 0x04003E4E RID: 15950
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0;

		// Token: 0x04003E4F RID: 15951
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E50 RID: 15952
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E51 RID: 15953
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E52 RID: 15954
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E53 RID: 15955
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E54 RID: 15956
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E55 RID: 15957
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E56 RID: 15958
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E57 RID: 15959
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E58 RID: 15960
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003E59 RID: 15961
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003E5A RID: 15962
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E5B RID: 15963
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003E5D RID: 15965
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E5E RID: 15966
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E5F RID: 15967
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E60 RID: 15968
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E62 RID: 15970
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E63 RID: 15971
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E64 RID: 15972
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E65 RID: 15973
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E66 RID: 15974
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0;

		// Token: 0x04003E67 RID: 15975
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003E68 RID: 15976
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003E69 RID: 15977
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0;

		// Token: 0x04003E6A RID: 15978
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0;

		// Token: 0x04003E6B RID: 15979
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009E5 RID: 2533
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CD54 RID: 52564 RVA: 0x00317540 File Offset: 0x00315740
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr);
				Dealer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9");
				Dealer.__c.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__99_0");
				Dealer.__c.NativeFieldInfoPtr___9__102_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__102_0");
				Dealer.__c.NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__102_1");
				Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674947);
				Dealer.__c.NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674948);
				Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674949);
				Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674950);
			}

			// Token: 0x0600CD55 RID: 52565 RVA: 0x0031760C File Offset: 0x0031580C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD56 RID: 52566 RVA: 0x00317648 File Offset: 0x00315848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190645, XrefRangeEnd = 190647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortContracts_b__99_0(Contract x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD57 RID: 52567 RVA: 0x00317698 File Offset: 0x00315898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190647, XrefRangeEnd = 190653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetItems_b__102_0(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD58 RID: 52568 RVA: 0x003176F8 File Offset: 0x003158F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190653, XrefRangeEnd = 190659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetItems_b__102_1(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD59 RID: 52569 RVA: 0x00063DD0 File Offset: 0x00061FD0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEB RID: 16363
			// (get) Token: 0x0600CD5A RID: 52570 RVA: 0x00317758 File Offset: 0x00315958
			// (set) Token: 0x0600CD5B RID: 52571 RVA: 0x00063DD9 File Offset: 0x00061FD9
			public unsafe static Dealer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FEC RID: 16364
			// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x00317780 File Offset: 0x00315980
			// (set) Token: 0x0600CD5D RID: 52573 RVA: 0x00063DEB File Offset: 0x00061FEB
			public unsafe static Func<Contract, int> __9__99_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__99_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Contract, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__99_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FED RID: 16365
			// (get) Token: 0x0600CD5E RID: 52574 RVA: 0x003177A8 File Offset: 0x003159A8
			// (set) Token: 0x0600CD5F RID: 52575 RVA: 0x00063DFD File Offset: 0x00061FFD
			public unsafe static Comparison<ItemSlot> __9__102_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__102_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemSlot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__102_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FEE RID: 16366
			// (get) Token: 0x0600CD60 RID: 52576 RVA: 0x003177D0 File Offset: 0x003159D0
			// (set) Token: 0x0600CD61 RID: 52577 RVA: 0x00063E0F File Offset: 0x0006200F
			public unsafe static Comparison<ItemSlot> __9__102_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemSlot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__102_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AB9 RID: 35513
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ABA RID: 35514
			private static readonly IntPtr NativeFieldInfoPtr___9__99_0;

			// Token: 0x04008ABB RID: 35515
			private static readonly IntPtr NativeFieldInfoPtr___9__102_0;

			// Token: 0x04008ABC RID: 35516
			private static readonly IntPtr NativeFieldInfoPtr___9__102_1;

			// Token: 0x04008ABD RID: 35517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ABE RID: 35518
			private static readonly IntPtr NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0;

			// Token: 0x04008ABF RID: 35519
			private static readonly IntPtr NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0;

			// Token: 0x04008AC0 RID: 35520
			private static readonly IntPtr NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0;
		}

		// Token: 0x020009E6 RID: 2534
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD62 RID: 52578 RVA: 0x003177F8 File Offset: 0x003159F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr);
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "targetQuality");
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100674951);
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100674952);
			}

			// Token: 0x0600CD63 RID: 52579 RVA: 0x00317874 File Offset: 0x00315A74
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD64 RID: 52580 RVA: 0x003178B0 File Offset: 0x00315AB0
			[CallerCount(0)]
			public unsafe bool Method_Internal_Boolean_ProductItemInstance_PDM_0(ProductItemInstance product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD65 RID: 52581 RVA: 0x00063E21 File Offset: 0x00062021
			public __c__DisplayClass101_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEF RID: 16367
			// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x00317900 File Offset: 0x00315B00
			// (set) Token: 0x0600CD67 RID: 52583 RVA: 0x00063E2A File Offset: 0x0006202A
			public unsafe EQuality targetQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality)) = value;
				}
			}

			// Token: 0x17003FF0 RID: 16368
			// (get) Token: 0x0600CD68 RID: 52584 RVA: 0x00317928 File Offset: 0x00315B28
			// (set) Token: 0x0600CD69 RID: 52585 RVA: 0x00063E45 File Offset: 0x00062045
			public unsafe Dealer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AC1 RID: 35521
			private static readonly IntPtr NativeFieldInfoPtr_targetQuality;

			// Token: 0x04008AC2 RID: 35522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AC3 RID: 35523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AC4 RID: 35524
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0;
		}

		// Token: 0x020009E7 RID: 2535
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD6A RID: 52586 RVA: 0x00317958 File Offset: 0x00315B58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr);
				Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, "product");
				Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, 100674953);
				Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, 100674954);
			}

			// Token: 0x0600CD6B RID: 52587 RVA: 0x003179C0 File Offset: 0x00315BC0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD6C RID: 52588 RVA: 0x003179FC File Offset: 0x00315BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190659, XrefRangeEnd = 190661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOrderableProducts_b__0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD6D RID: 52589 RVA: 0x00063E64 File Offset: 0x00062064
			public __c__DisplayClass93_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF1 RID: 16369
			// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x00317A4C File Offset: 0x00315C4C
			// (set) Token: 0x0600CD6F RID: 52591 RVA: 0x00063E6D File Offset: 0x0006206D
			public unsafe ProductItemInstance product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AC5 RID: 35525
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04008AC6 RID: 35526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AC7 RID: 35527
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0;
		}

		// Token: 0x020009E8 RID: 2536
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass97_0")]
		public sealed class __c__DisplayClass97_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD70 RID: 52592 RVA: 0x00317A7C File Offset: 0x00315C7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass97_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass97_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr);
				Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, "contract");
				Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, 100674955);
				Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, 100674956);
			}

			// Token: 0x0600CD71 RID: 52593 RVA: 0x00317AF8 File Offset: 0x00315CF8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass97_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD72 RID: 52594 RVA: 0x00317B34 File Offset: 0x00315D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190661, XrefRangeEnd = 190678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CustomerContractStarted_b__0(EQuestState <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD73 RID: 52595 RVA: 0x00063E8C File Offset: 0x0006208C
			public __c__DisplayClass97_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF2 RID: 16370
			// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x00317B74 File Offset: 0x00315D74
			// (set) Token: 0x0600CD75 RID: 52597 RVA: 0x00063E95 File Offset: 0x00062095
			public unsafe Dealer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF3 RID: 16371
			// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x00317BA4 File Offset: 0x00315DA4
			// (set) Token: 0x0600CD77 RID: 52599 RVA: 0x00063EB4 File Offset: 0x000620B4
			public unsafe Contract contract
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AC8 RID: 35528
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AC9 RID: 35529
			private static readonly IntPtr NativeFieldInfoPtr_contract;

			// Token: 0x04008ACA RID: 35530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ACB RID: 35531
			private static readonly IntPtr NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0;
		}
	}
}
