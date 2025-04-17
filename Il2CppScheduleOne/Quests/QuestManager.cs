using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B2 RID: 434
	public class QuestManager : NetworkSingleton<QuestManager>
	{
		// Token: 0x06002589 RID: 9609 RVA: 0x000E546C File Offset: 0x000E366C
		// Note: this type is marked as 'beforefieldinit'.
		static QuestManager()
		{
			Il2CppClassPointerStore<QuestManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManager>.NativeClassPtr);
			QuestManager.NativeFieldInfoPtr_DEFAULT_QUEST_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "DEFAULT_QUEST_STATE");
			QuestManager.NativeFieldInfoPtr_DefaultQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "DefaultQuests");
			QuestManager.NativeFieldInfoPtr_QuestContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "QuestContainer");
			QuestManager.NativeFieldInfoPtr_ContractContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "ContractContainer");
			QuestManager.NativeFieldInfoPtr_QuestCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "QuestCompleteSound");
			QuestManager.NativeFieldInfoPtr_QuestEntryCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "QuestEntryCompleteSound");
			QuestManager.NativeFieldInfoPtr_ContractPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "ContractPrefab");
			QuestManager.NativeFieldInfoPtr_DeaddropCollectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "DeaddropCollectionPrefab");
			QuestManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "loader");
			QuestManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			QuestManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			QuestManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			QuestManager.NativeFieldInfoPtr_writtenContractFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "writtenContractFiles");
			QuestManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted");
			QuestManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted");
			QuestManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667457);
			QuestManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667458);
			QuestManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667459);
			QuestManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667460);
			QuestManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667461);
			QuestManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667462);
			QuestManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667463);
			QuestManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667464);
			QuestManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667465);
			QuestManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667466);
			QuestManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667467);
			QuestManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667468);
			QuestManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667469);
			QuestManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667470);
			QuestManager.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667471);
			QuestManager.NativeMethodInfoPtr_SendContractAccepted_Public_Void_NetworkObject_ContractInfo_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667472);
			QuestManager.NativeMethodInfoPtr_CreateContract_Networked_Public_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667473);
			QuestManager.NativeMethodInfoPtr_CreateContract_Local_Public_Contract_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Boolean_NetworkObject_Single_ProductList_String_QuestWindowConfig_Boolean_GameDateTime_Int32_GameDateTime_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667474);
			QuestManager.NativeMethodInfoPtr_SendQuestAction_Public_Void_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667475);
			QuestManager.NativeMethodInfoPtr_ReceiveQuestAction_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667476);
			QuestManager.NativeMethodInfoPtr_SendQuestState_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667477);
			QuestManager.NativeMethodInfoPtr_ReceiveQuestState_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667478);
			QuestManager.NativeMethodInfoPtr_SetQuestTracked_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667479);
			QuestManager.NativeMethodInfoPtr_SendQuestEntryState_Public_Void_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667480);
			QuestManager.NativeMethodInfoPtr_ReceiveQuestEntryState_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667481);
			QuestManager.NativeMethodInfoPtr_PrintQuestStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667482);
			QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667483);
			QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_DeaddropQuest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667484);
			QuestManager.NativeMethodInfoPtr_PlayCompleteQuestSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667485);
			QuestManager.NativeMethodInfoPtr_PlayCompleteQuestEntrySound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667486);
			QuestManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667487);
			QuestManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667488);
			QuestManager.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667489);
			QuestManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667490);
			QuestManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667491);
			QuestManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667492);
			QuestManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667493);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_1030683829_Private_Void_NetworkObject_ContractInfo_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667494);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_1030683829_Public_Void_NetworkObject_ContractInfo_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667495);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_1030683829_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667496);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateContract_Networked_1113640585_Private_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667497);
			QuestManager.NativeMethodInfoPtr_RpcLogic___CreateContract_Networked_1113640585_Public_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667498);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateContract_Networked_1113640585_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667499);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateContract_Networked_1113640585_Private_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667500);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateContract_Networked_1113640585_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667501);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestAction_2848227116_Private_Void_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667502);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestAction_2848227116_Public_Void_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667503);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestAction_2848227116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667504);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667505);
			QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667506);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667507);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667508);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667509);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestState_4117703421_Private_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667510);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestState_4117703421_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667511);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestState_4117703421_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667512);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667513);
			QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667514);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667515);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667516);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667517);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667518);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667519);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_SetQuestTracked_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667520);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestEntryState_375159588_Private_Void_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667521);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestEntryState_375159588_Public_Void_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667522);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestEntryState_375159588_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667523);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667524);
			QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667525);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667526);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667527);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667528);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667529);
			QuestManager.NativeMethodInfoPtr_RpcLogic___CreateDeaddropCollectionQuest_3895153758_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667530);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667531);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667532);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667533);
			QuestManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667534);
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000E5BE0 File Offset: 0x000E3DE0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115133, XrefRangeEnd = 115135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000E5C18 File Offset: 0x000E3E18
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115135, XrefRangeEnd = 115137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x000E5C50 File Offset: 0x000E3E50
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000E5C90 File Offset: 0x000E3E90
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x000E5CCC File Offset: 0x000E3ECC
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x000E5D0C File Offset: 0x000E3F0C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115137, XrefRangeEnd = 115138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000E5D50 File Offset: 0x000E3F50
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x000E5D90 File Offset: 0x000E3F90
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115149, XrefRangeEnd = 115150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000E5DD4 File Offset: 0x000E3FD4
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x000E5E10 File Offset: 0x000E4010
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000E5E50 File Offset: 0x000E4050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115151, XrefRangeEnd = 115172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000E5E8C File Offset: 0x000E408C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115172, XrefRangeEnd = 115178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000E5EC8 File Offset: 0x000E40C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115178, XrefRangeEnd = 115184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000E5F04 File Offset: 0x000E4104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115184, XrefRangeEnd = 115194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x000E5F54 File Offset: 0x000E4154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115194, XrefRangeEnd = 115208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000E5F88 File Offset: 0x000E4188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115221, RefRangeEnd = 115222, XrefRangeStart = 115208, XrefRangeEnd = 115221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendContractAccepted(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref track;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendContractAccepted_Public_Void_NetworkObject_ContractInfo_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000E6000 File Offset: 0x000E4200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115276, RefRangeEnd = 115278, XrefRangeStart = 115222, XrefRangeEnd = 115276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateContract_Networked(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateContract_Networked_Public_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000E60B8 File Offset: 0x000E42B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115306, RefRangeEnd = 115308, XrefRangeStart = 115278, XrefRangeEnd = 115306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract CreateContract_Local(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, bool tracked, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, Dealer dealer = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateContract_Local_Public_Contract_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Boolean_NetworkObject_Single_ProductList_String_QuestWindowConfig_Boolean_GameDateTime_Int32_GameDateTime_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000E61FC File Offset: 0x000E43FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 115330, RefRangeEnd = 115336, XrefRangeStart = 115308, XrefRangeEnd = 115330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQuestAction(string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendQuestAction_Public_Void_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000E624C File Offset: 0x000E444C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 115380, RefRangeEnd = 115383, XrefRangeStart = 115336, XrefRangeEnd = 115380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQuestAction(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ReceiveQuestAction_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000E62B0 File Offset: 0x000E44B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115383, XrefRangeEnd = 115405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQuestState(string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendQuestState_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000E6300 File Offset: 0x000E4500
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 115449, RefRangeEnd = 115454, XrefRangeStart = 115405, XrefRangeEnd = 115449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ReceiveQuestState_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000E6364 File Offset: 0x000E4564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115465, RefRangeEnd = 115466, XrefRangeStart = 115454, XrefRangeEnd = 115465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuestTracked(NetworkConnection conn, string guid, bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SetQuestTracked_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000E63C8 File Offset: 0x000E45C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115490, RefRangeEnd = 115491, XrefRangeStart = 115466, XrefRangeEnd = 115490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQuestEntryState(string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendQuestEntryState_Public_Void_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000E6428 File Offset: 0x000E4628
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 115539, RefRangeEnd = 115544, XrefRangeStart = 115491, XrefRangeEnd = 115539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ReceiveQuestEntryState_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000E6498 File Offset: 0x000E4698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115544, XrefRangeEnd = 115568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintQuestStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_PrintQuestStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000E64CC File Offset: 0x000E46CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115612, RefRangeEnd = 115614, XrefRangeStart = 115568, XrefRangeEnd = 115612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000E6534 File Offset: 0x000E4734
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 115661, RefRangeEnd = 115666, XrefRangeStart = 115614, XrefRangeEnd = 115661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_DeaddropQuest_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeaddropQuest>(intPtr3) : null;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000E6598 File Offset: 0x000E4798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115666, XrefRangeEnd = 115669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCompleteQuestSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_PlayCompleteQuestSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000E65CC File Offset: 0x000E47CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115669, XrefRangeEnd = 115670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCompleteQuestEntrySound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_PlayCompleteQuestEntrySound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x000E6600 File Offset: 0x000E4800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115670, XrefRangeEnd = 115672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x000E6644 File Offset: 0x000E4844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115672, XrefRangeEnd = 115759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000E66A0 File Offset: 0x000E48A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115759, XrefRangeEnd = 115777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000E66F0 File Offset: 0x000E48F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115777, XrefRangeEnd = 115811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x000E672C File Offset: 0x000E492C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115811, XrefRangeEnd = 115906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000E6768 File Offset: 0x000E4968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115906, XrefRangeEnd = 115909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000E67A4 File Offset: 0x000E49A4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000E67E0 File Offset: 0x000E49E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115221, RefRangeEnd = 115222, XrefRangeStart = 115221, XrefRangeEnd = 115222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendContractAccepted_1030683829(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref track;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_1030683829_Private_Void_NetworkObject_ContractInfo_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000E6858 File Offset: 0x000E4A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115936, RefRangeEnd = 115937, XrefRangeStart = 115909, XrefRangeEnd = 115936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendContractAccepted_1030683829(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref track;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_1030683829_Public_Void_NetworkObject_ContractInfo_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000E68D0 File Offset: 0x000E4AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115937, XrefRangeEnd = 115942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendContractAccepted_1030683829(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_1030683829_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000E6934 File Offset: 0x000E4B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115942, XrefRangeEnd = 115967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateContract_Networked_1113640585_Private_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000E69EC File Offset: 0x000E4BEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116027, RefRangeEnd = 116030, XrefRangeStart = 115967, XrefRangeEnd = 116027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___CreateContract_Networked_1113640585_Public_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000E6AA4 File Offset: 0x000E4CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116030, XrefRangeEnd = 116039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateContract_Networked_1113640585(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateContract_Networked_1113640585_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000E6AF4 File Offset: 0x000E4CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116039, XrefRangeEnd = 116055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateContract_Networked_1113640585_Private_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000E6BAC File Offset: 0x000E4DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116055, XrefRangeEnd = 116064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateContract_Networked_1113640585(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateContract_Networked_1113640585_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000E6BFC File Offset: 0x000E4DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116064, XrefRangeEnd = 116084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestAction_2848227116_Private_Void_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x000E6C4C File Offset: 0x000E4E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116084, XrefRangeEnd = 116085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestAction_2848227116_Public_Void_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000E6C9C File Offset: 0x000E4E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116085, XrefRangeEnd = 116090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestAction_2848227116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000E6D00 File Offset: 0x000E4F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116090, XrefRangeEnd = 116110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000E6D64 File Offset: 0x000E4F64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116123, RefRangeEnd = 116126, XrefRangeStart = 116110, XrefRangeEnd = 116123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000E6DC8 File Offset: 0x000E4FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116126, XrefRangeEnd = 116131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000E6E18 File Offset: 0x000E5018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116131, XrefRangeEnd = 116142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000E6E7C File Offset: 0x000E507C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116142, XrefRangeEnd = 116147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x000E6ECC File Offset: 0x000E50CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116147, XrefRangeEnd = 116167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestState_4117703421_Private_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000E6F1C File Offset: 0x000E511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116167, XrefRangeEnd = 116168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestState_4117703421_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000E6F6C File Offset: 0x000E516C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116168, XrefRangeEnd = 116173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestState_4117703421_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000E6FD0 File Offset: 0x000E51D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116173, XrefRangeEnd = 116193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000E7034 File Offset: 0x000E5234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116206, RefRangeEnd = 116209, XrefRangeStart = 116193, XrefRangeEnd = 116206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000E7098 File Offset: 0x000E5298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116209, XrefRangeEnd = 116214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000E70E8 File Offset: 0x000E52E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116214, XrefRangeEnd = 116225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000E714C File Offset: 0x000E534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116225, XrefRangeEnd = 116230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000E719C File Offset: 0x000E539C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115465, RefRangeEnd = 115466, XrefRangeStart = 115465, XrefRangeEnd = 115466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000E7200 File Offset: 0x000E5400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116230, XrefRangeEnd = 116243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000E7264 File Offset: 0x000E5464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116243, XrefRangeEnd = 116259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_SetQuestTracked_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000E72B4 File Offset: 0x000E54B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116259, XrefRangeEnd = 116272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestEntryState_375159588_Private_Void_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000E7314 File Offset: 0x000E5514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116272, XrefRangeEnd = 116273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestEntryState_375159588_Public_Void_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000E7374 File Offset: 0x000E5574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116273, XrefRangeEnd = 116280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestEntryState_375159588_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000E73D8 File Offset: 0x000E55D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116280, XrefRangeEnd = 116302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x000E7448 File Offset: 0x000E5648
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116315, RefRangeEnd = 116318, XrefRangeStart = 116302, XrefRangeEnd = 116315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x000E74B8 File Offset: 0x000E56B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116318, XrefRangeEnd = 116325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x000E7508 File Offset: 0x000E5708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116325, XrefRangeEnd = 116338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x000E7578 File Offset: 0x000E5778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116338, XrefRangeEnd = 116345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x000E75C8 File Offset: 0x000E57C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116345, XrefRangeEnd = 116365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x000E7630 File Offset: 0x000E5830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116365, XrefRangeEnd = 116366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___CreateDeaddropCollectionQuest_3895153758_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000E7698 File Offset: 0x000E5898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116366, XrefRangeEnd = 116371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000E76E8 File Offset: 0x000E58E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116371, XrefRangeEnd = 116382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x000E7750 File Offset: 0x000E5950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116382, XrefRangeEnd = 116387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x000E77A0 File Offset: 0x000E59A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116387, XrefRangeEnd = 116406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00014FF8 File Offset: 0x000131F8
		public QuestManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000E77DC File Offset: 0x000E59DC
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x00015001 File Offset: 0x00013201
		public unsafe static EQuestState DEFAULT_QUEST_STATE
		{
			get
			{
				EQuestState result;
				IL2CPP.il2cpp_field_static_get_value(QuestManager.NativeFieldInfoPtr_DEFAULT_QUEST_STATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QuestManager.NativeFieldInfoPtr_DEFAULT_QUEST_STATE, (void*)(&value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x000E77F8 File Offset: 0x000E59F8
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x0001500F File Offset: 0x0001320F
		public unsafe Il2CppReferenceArray<Quest> DefaultQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DefaultQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DefaultQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x000E7828 File Offset: 0x000E5A28
		// (set) Token: 0x060025DE RID: 9694 RVA: 0x0001502E File Offset: 0x0001322E
		public unsafe Transform QuestContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000E7858 File Offset: 0x000E5A58
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x0001504D File Offset: 0x0001324D
		public unsafe Transform ContractContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000E7888 File Offset: 0x000E5A88
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x0001506C File Offset: 0x0001326C
		public unsafe AudioSourceController QuestCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestCompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000E78B8 File Offset: 0x000E5AB8
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x0001508B File Offset: 0x0001328B
		public unsafe AudioSourceController QuestEntryCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestEntryCompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestEntryCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x000E78E8 File Offset: 0x000E5AE8
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x000150AA File Offset: 0x000132AA
		public unsafe Contract ContractPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000E7918 File Offset: 0x000E5B18
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x000150C9 File Offset: 0x000132C9
		public unsafe DeaddropQuest DeaddropCollectionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DeaddropCollectionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeaddropQuest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DeaddropCollectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000E7948 File Offset: 0x000E5B48
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x000150E8 File Offset: 0x000132E8
		public unsafe QuestsLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestsLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x000E7978 File Offset: 0x000E5B78
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x00015107 File Offset: 0x00013307
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x000E79A8 File Offset: 0x000E5BA8
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x00015126 File Offset: 0x00013326
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000E79D8 File Offset: 0x000E5BD8
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x00015145 File Offset: 0x00013345
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000E7A00 File Offset: 0x000E5C00
		// (set) Token: 0x060025F2 RID: 9714 RVA: 0x00015160 File Offset: 0x00013360
		public unsafe List<string> writtenContractFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_writtenContractFiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_writtenContractFiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000E7A30 File Offset: 0x000E5C30
		// (set) Token: 0x060025F4 RID: 9716 RVA: 0x0001517F File Offset: 0x0001337F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000E7A58 File Offset: 0x000E5C58
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0001519A File Offset: 0x0001339A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_QUEST_STATE;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQuests;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeFieldInfoPtr_QuestContainer;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeFieldInfoPtr_ContractContainer;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeFieldInfoPtr_QuestCompleteSound;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryCompleteSound;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeFieldInfoPtr_ContractPrefab;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropCollectionPrefab;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeFieldInfoPtr_writtenContractFiles;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_SendContractAccepted_Public_Void_NetworkObject_ContractInfo_Boolean_String_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_CreateContract_Networked_Public_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_CreateContract_Local_Public_Contract_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Boolean_NetworkObject_Single_ProductList_String_QuestWindowConfig_Boolean_GameDateTime_Int32_GameDateTime_Dealer_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_SendQuestAction_Public_Void_String_EQuestAction_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQuestAction_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_SendQuestState_Public_Void_String_EQuestState_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQuestState_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestTracked_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_SendQuestEntryState_Public_Void_String_Int32_EQuestState_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQuestEntryState_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_PrintQuestStates_Public_Void_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_DeaddropQuest_String_String_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_PlayCompleteQuestSound_Public_Void_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_PlayCompleteQuestEntrySound_Public_Void_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_1030683829_Private_Void_NetworkObject_ContractInfo_Boolean_String_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendContractAccepted_1030683829_Public_Void_NetworkObject_ContractInfo_Boolean_String_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_1030683829_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateContract_Networked_1113640585_Private_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateContract_Networked_1113640585_Public_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateContract_Networked_1113640585_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateContract_Networked_1113640585_Private_Void_NetworkConnection_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateContract_Networked_1113640585_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQuestAction_2848227116_Private_Void_String_EQuestAction_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQuestAction_2848227116_Public_Void_String_EQuestAction_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQuestAction_2848227116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQuestState_4117703421_Private_Void_String_EQuestState_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQuestState_4117703421_Public_Void_String_EQuestState_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQuestState_4117703421_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetQuestTracked_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQuestEntryState_375159588_Private_Void_String_Int32_EQuestState_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQuestEntryState_375159588_Public_Void_String_Int32_EQuestState_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQuestEntryState_375159588_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateDeaddropCollectionQuest_3895153758_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020008CF RID: 2255
		[OriginalName("Assembly-CSharp.dll", "", "EQuestAction")]
		public enum EQuestAction
		{
			// Token: 0x040084D6 RID: 34006
			Begin,
			// Token: 0x040084D7 RID: 34007
			Success,
			// Token: 0x040084D8 RID: 34008
			Fail,
			// Token: 0x040084D9 RID: 34009
			Expire,
			// Token: 0x040084DA RID: 34010
			Cancel
		}

		// Token: 0x020008D0 RID: 2256
		[ObfuscatedName("ScheduleOne.Quests.QuestManager+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C402 RID: 50178 RVA: 0x002FC438 File Offset: 0x002FA638
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr);
				QuestManager.__c__DisplayClass34_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr, "connection");
				QuestManager.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				QuestManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr, 100667535);
				QuestManager.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr, 100667536);
				QuestManager.__c__DisplayClass34_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr, 100667537);
			}

			// Token: 0x0600C403 RID: 50179 RVA: 0x002FC4C8 File Offset: 0x002FA6C8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C404 RID: 50180 RVA: 0x002FC504 File Offset: 0x002FA704
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115124, RefRangeEnd = 115125, XrefRangeStart = 115119, XrefRangeEnd = 115124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C405 RID: 50181 RVA: 0x002FC544 File Offset: 0x002FA744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115125, XrefRangeEnd = 115133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnSpawnServer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C406 RID: 50182 RVA: 0x0005F683 File Offset: 0x0005D883
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2F RID: 15663
			// (get) Token: 0x0600C407 RID: 50183 RVA: 0x002FC580 File Offset: 0x002FA780
			// (set) Token: 0x0600C408 RID: 50184 RVA: 0x0005F68C File Offset: 0x0005D88C
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D30 RID: 15664
			// (get) Token: 0x0600C409 RID: 50185 RVA: 0x002FC5B0 File Offset: 0x002FA7B0
			// (set) Token: 0x0600C40A RID: 50186 RVA: 0x0005F6AB File Offset: 0x0005D8AB
			public unsafe QuestManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084DB RID: 34011
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x040084DC RID: 34012
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084DD RID: 34013
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084DE RID: 34014
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040084DF RID: 34015
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0;

			// Token: 0x02000C32 RID: 3122
			[ObfuscatedName("ScheduleOne.Quests.QuestManager+<>c__DisplayClass34_0+<<OnSpawnServer>g__SendQuestStuff|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E14B RID: 57675 RVA: 0x0034F4EC File Offset: 0x0034D6EC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0>.NativeClassPtr, "<<OnSpawnServer>g__SendQuestStuff|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667538);
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667539);
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667540);
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667541);
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667542);
					QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667543);
				}

				// Token: 0x0600E14C RID: 57676 RVA: 0x0034F5CC File Offset: 0x0034D7CC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E14D RID: 57677 RVA: 0x0034F614 File Offset: 0x0034D814
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E14E RID: 57678 RVA: 0x0034F648 File Offset: 0x0034D848
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115022, XrefRangeEnd = 115114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045CF RID: 17871
				// (get) Token: 0x0600E14F RID: 57679 RVA: 0x0034F684 File Offset: 0x0034D884
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E150 RID: 57680 RVA: 0x0034F6C4 File Offset: 0x0034D8C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115114, XrefRangeEnd = 115119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045D0 RID: 17872
				// (get) Token: 0x0600E151 RID: 57681 RVA: 0x0034F6F8 File Offset: 0x0034D8F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E152 RID: 57682 RVA: 0x0006DD7C File Offset: 0x0006BF7C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045CC RID: 17868
				// (get) Token: 0x0600E153 RID: 57683 RVA: 0x0034F738 File Offset: 0x0034D938
				// (set) Token: 0x0600E154 RID: 57684 RVA: 0x0006DD85 File Offset: 0x0006BF85
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045CD RID: 17869
				// (get) Token: 0x0600E155 RID: 57685 RVA: 0x0034F760 File Offset: 0x0034D960
				// (set) Token: 0x0600E156 RID: 57686 RVA: 0x0006DDA0 File Offset: 0x0006BFA0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045CE RID: 17870
				// (get) Token: 0x0600E157 RID: 57687 RVA: 0x0034F790 File Offset: 0x0034D990
				// (set) Token: 0x0600E158 RID: 57688 RVA: 0x0006DDBF File Offset: 0x0006BFBF
				public unsafe QuestManager.__c__DisplayClass34_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestManager.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096D9 RID: 38617
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096DA RID: 38618
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096DB RID: 38619
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096DC RID: 38620
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096DD RID: 38621
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096DE RID: 38622
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096DF RID: 38623
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096E0 RID: 38624
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096E1 RID: 38625
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
