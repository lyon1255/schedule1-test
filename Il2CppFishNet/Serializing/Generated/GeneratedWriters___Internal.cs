using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Casino;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Handover;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishNet.Serializing.Generated
{
	// Token: 0x0200079F RID: 1951
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedWriters___Internal : Object
	{
		// Token: 0x0600B861 RID: 47201 RVA: 0x002DBB38 File Offset: 0x002D9D38
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedWriters___Internal()
		{
			Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedWriters___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr);
			GeneratedWriters___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685959);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated_Public_Static_Void_Writer_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685960);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685961);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685962);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated_Public_Static_Void_Writer_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685963);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated_Public_Static_Void_Writer_ProductList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685964);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Entry_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685965);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685966);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_Entry_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685967);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated_Public_Static_Void_Writer_QuestWindowConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685968);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated_Public_Static_Void_Writer_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685969);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685970);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685971);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated_Public_Static_Void_Writer_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685972);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685973);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated_Public_Static_Void_Writer_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685974);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685975);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated_Public_Static_Void_Writer_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685976);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685977);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated_Public_Static_Void_Writer_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685978);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685979);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated_Public_Static_Void_Writer_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685980);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685981);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated_Public_Static_Void_Writer_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685982);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated_Public_Static_Void_Writer_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685983);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685984);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685985);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextResponseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685986);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685987);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated_Public_Static_Void_Writer_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685988);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685989);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685990);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated_Public_Static_Void_Writer_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685991);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685992);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685993);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated_Public_Static_Void_Writer_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685994);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated_Public_Static_Void_Writer_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685995);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685996);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated_Public_Static_Void_Writer_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685997);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685998);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685999);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686000);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_LayerSetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686001);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686002);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_AccessorySetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686003);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686004);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686005);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686006);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated_Public_Static_Void_Writer_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686007);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686008);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated_Public_Static_Void_Writer_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686009);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686010);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686011);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686012);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686013);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686014);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686015);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated_Public_Static_Void_Writer_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686016);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686017);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated_Public_Static_Void_Writer_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686018);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated_Public_Static_Void_Writer_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686019);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686020);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686021);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686022);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686023);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686024);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686025);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686026);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated_Public_Static_Void_Writer_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686027);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated_Public_Static_Void_Writer_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686028);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686029);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated_Public_Static_Void_Writer_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686030);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686031);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686032);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated_Public_Static_Void_Writer_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686033);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686034);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686035);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686036);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_NewMixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686037);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686038);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated_Public_Static_Void_Writer_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686039);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686040);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_ChemistryCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686041);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686042);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686043);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_MixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686044);
		}

		// Token: 0x0600B862 RID: 47202 RVA: 0x002DC220 File Offset: 0x002DA420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313641, XrefRangeEnd = 314538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B863 RID: 47203 RVA: 0x002DC248 File Offset: 0x002DA448
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314544, RefRangeEnd = 314548, XrefRangeStart = 314538, XrefRangeEnd = 314544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated(this Writer writer, VisionEventReceipt value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated_Public_Static_Void_Writer_VisionEventReceipt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x002DC290 File Offset: 0x002DA490
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314548, XrefRangeEnd = 314551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EVisualState_0(this Writer writer, PlayerVisualState.EVisualState value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EVisualState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B865 RID: 47205 RVA: 0x002DC2D4 File Offset: 0x002DA4D4
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EEventLevel_0(this Writer writer, VisionCone.EEventLevel value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EEventLevel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B866 RID: 47206 RVA: 0x002DC318 File Offset: 0x002DA518
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 314689, RefRangeEnd = 314699, XrefRangeStart = 314659, XrefRangeEnd = 314689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated(this Writer writer, ContractInfo value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated_Public_Static_Void_Writer_ContractInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x002DC360 File Offset: 0x002DA560
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314704, RefRangeEnd = 314707, XrefRangeStart = 314699, XrefRangeEnd = 314704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated(this Writer writer, ProductList value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated_Public_Static_Void_Writer_ProductList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B868 RID: 47208 RVA: 0x002DC3A8 File Offset: 0x002DA5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314707, XrefRangeEnd = 314715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Entry_PDM_0(this Writer writer, ProductList.Entry value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Entry_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B869 RID: 47209 RVA: 0x002DC3F0 File Offset: 0x002DA5F0
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated(this Writer writer, EQuality value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86A RID: 47210 RVA: 0x002DC434 File Offset: 0x002DA634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314715, XrefRangeEnd = 314719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_List_1_Entry_PDM_0(this Writer writer, List<ProductList.Entry> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_Entry_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x002DC47C File Offset: 0x002DA67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314719, XrefRangeEnd = 314727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated(this Writer writer, QuestWindowConfig value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated_Public_Static_Void_Writer_QuestWindowConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x002DC4C4 File Offset: 0x002DA6C4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 314732, RefRangeEnd = 314749, XrefRangeStart = 314727, XrefRangeEnd = 314732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated(this Writer writer, GameDateTime value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated_Public_Static_Void_Writer_GameDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x002DC508 File Offset: 0x002DA708
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EQuestAction_0(this Writer writer, QuestManager.EQuestAction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EQuestAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x002DC54C File Offset: 0x002DA74C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated(this Writer writer, EQuestState value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuestState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x002DC590 File Offset: 0x002DA790
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 314765, RefRangeEnd = 314773, XrefRangeStart = 314749, XrefRangeEnd = 314765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated(this Writer writer, Impact value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated_Public_Static_Void_Writer_Impact_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B870 RID: 47216 RVA: 0x002DC5D8 File Offset: 0x002DA7D8
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated(this Writer writer, EImpactType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EImpactType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x002DC61C File Offset: 0x002DA81C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314775, RefRangeEnd = 314782, XrefRangeStart = 314773, XrefRangeEnd = 314775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated(this Writer writer, LandVehicle value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated_Public_Static_Void_Writer_LandVehicle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x002DC664 File Offset: 0x002DA864
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ECheckpointLocation_0(this Writer writer, CheckpointManager.ECheckpointLocation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECheckpointLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x002DC6A8 File Offset: 0x002DA8A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314775, RefRangeEnd = 314782, XrefRangeStart = 314775, XrefRangeEnd = 314782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated(this Writer writer, Player value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated_Public_Static_Void_Writer_Player_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x002DC6F0 File Offset: 0x002DA8F0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 314786, RefRangeEnd = 314804, XrefRangeStart = 314782, XrefRangeEnd = 314786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<string> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x002DC738 File Offset: 0x002DA938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314804, XrefRangeEnd = 314810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated(this Writer writer, StringIntPair value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated_Public_Static_Void_Writer_StringIntPair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x002DC780 File Offset: 0x002DA980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314814, RefRangeEnd = 314816, XrefRangeStart = 314810, XrefRangeEnd = 314814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0(this Writer writer, Il2CppReferenceArray<StringIntPair> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x002DC7C8 File Offset: 0x002DA9C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314825, RefRangeEnd = 314830, XrefRangeStart = 314816, XrefRangeEnd = 314825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated(this Writer writer, Message value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated_Public_Static_Void_Writer_Message_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x002DC810 File Offset: 0x002DAA10
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ESenderType_0(this Writer writer, Message.ESenderType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESenderType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x002DC854 File Offset: 0x002DAA54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314843, RefRangeEnd = 314848, XrefRangeStart = 314830, XrefRangeEnd = 314843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated(this Writer writer, MessageChain value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated_Public_Static_Void_Writer_MessageChain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x002DC89C File Offset: 0x002DAA9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314875, RefRangeEnd = 314877, XrefRangeStart = 314848, XrefRangeEnd = 314875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated(this Writer writer, MSGConversationData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated_Public_Static_Void_Writer_MSGConversationData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x002DC8E4 File Offset: 0x002DAAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314877, XrefRangeEnd = 314886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated(this Writer writer, TextMessageData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextMessageData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x002DC92C File Offset: 0x002DAB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314886, XrefRangeEnd = 314890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0(this Writer writer, Il2CppReferenceArray<TextMessageData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x002DC974 File Offset: 0x002DAB74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314895, RefRangeEnd = 314899, XrefRangeStart = 314890, XrefRangeEnd = 314895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated(this Writer writer, TextResponseData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextResponseData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x002DC9BC File Offset: 0x002DABBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314899, XrefRangeEnd = 314903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0(this Writer writer, Il2CppReferenceArray<TextResponseData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x002DCA04 File Offset: 0x002DAC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314903, XrefRangeEnd = 314909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated(this Writer writer, Response value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated_Public_Static_Void_Writer_Response_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x002DCA4C File Offset: 0x002DAC4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314913, RefRangeEnd = 314918, XrefRangeStart = 314909, XrefRangeEnd = 314913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<Response> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_Response_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x002DCA94 File Offset: 0x002DAC94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314922, RefRangeEnd = 314929, XrefRangeStart = 314918, XrefRangeEnd = 314922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<NetworkObject> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_NetworkObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x002DCADC File Offset: 0x002DACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314929, XrefRangeEnd = 314938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated(this Writer writer, AdvancedTransitRouteData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated_Public_Static_Void_Writer_AdvancedTransitRouteData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x002DCB24 File Offset: 0x002DAD24
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EMode_0(this Writer writer, ManagementItemFilter.EMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x002DCB68 File Offset: 0x002DAD68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314942, RefRangeEnd = 314949, XrefRangeStart = 314938, XrefRangeEnd = 314942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0(this Writer writer, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x002DCBB0 File Offset: 0x002DADB0
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated(this Writer writer, ERank value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated_Public_Static_Void_Writer_ERank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x002DCBF4 File Offset: 0x002DADF4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 314732, RefRangeEnd = 314749, XrefRangeStart = 314732, XrefRangeEnd = 314749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated(this Writer writer, FullRank value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated_Public_Static_Void_Writer_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x002DCC38 File Offset: 0x002DAE38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314962, RefRangeEnd = 314966, XrefRangeStart = 314949, XrefRangeEnd = 314962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated(this Writer writer, PlayerData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_PlayerData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x002DCC80 File Offset: 0x002DAE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314966, XrefRangeEnd = 314975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated(this Writer writer, VariableData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated_Public_Static_Void_Writer_VariableData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B889 RID: 47241 RVA: 0x002DCCC8 File Offset: 0x002DAEC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314979, RefRangeEnd = 314983, XrefRangeStart = 314975, XrefRangeEnd = 314979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0(this Writer writer, Il2CppReferenceArray<VariableData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x002DCD10 File Offset: 0x002DAF10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 315031, RefRangeEnd = 315036, XrefRangeStart = 314983, XrefRangeEnd = 315031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated(this Writer writer, AvatarSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_AvatarSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88B RID: 47243 RVA: 0x002DCD58 File Offset: 0x002DAF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315036, XrefRangeEnd = 315039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EyeLidConfiguration_0(this Writer writer, Eye.EyeLidConfiguration value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EyeLidConfiguration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88C RID: 47244 RVA: 0x002DCD9C File Offset: 0x002DAF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315039, XrefRangeEnd = 315041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_LayerSetting_PDM_0(this Writer writer, AvatarSettings.LayerSetting value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_LayerSetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x002DCDEC File Offset: 0x002DAFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315041, XrefRangeEnd = 315045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0(this Writer writer, List<AvatarSettings.LayerSetting> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x002DCE34 File Offset: 0x002DB034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315045, XrefRangeEnd = 315048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_AccessorySetting_PDM_0(this Writer writer, AvatarSettings.AccessorySetting value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_AccessorySetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x002DCE7C File Offset: 0x002DB07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315048, XrefRangeEnd = 315052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0(this Writer writer, List<AvatarSettings.AccessorySetting> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x002DCEC4 File Offset: 0x002DB0C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315085, RefRangeEnd = 315091, XrefRangeStart = 315052, XrefRangeEnd = 315085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated(this Writer writer, BasicAvatarSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_BasicAvatarSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x002DCF0C File Offset: 0x002DB10C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EPursuitLevel_0(this Writer writer, PlayerCrimeData.EPursuitLevel value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EPursuitLevel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x002DCF50 File Offset: 0x002DB150
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314775, RefRangeEnd = 314782, XrefRangeStart = 314775, XrefRangeEnd = 314782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated(this Writer writer, Property value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated_Public_Static_Void_Writer_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x002DCF98 File Offset: 0x002DB198
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated(this Writer writer, EEmployeeType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EEmployeeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x002DCFDC File Offset: 0x002DB1DC
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated(this Writer writer, EDealWindow value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated_Public_Static_Void_Writer_EDealWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x002DD020 File Offset: 0x002DB220
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EHandoverOutcome_0(this Writer writer, HandoverScreen.EHandoverOutcome value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EHandoverOutcome_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x002DD064 File Offset: 0x002DB264
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315095, RefRangeEnd = 315101, XrefRangeStart = 315091, XrefRangeEnd = 315095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<ItemInstance> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x002DD0AC File Offset: 0x002DB2AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315144, RefRangeEnd = 315147, XrefRangeStart = 315101, XrefRangeEnd = 315144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated(this Writer writer, Il2CppScheduleOne.Persistence.Datas.CustomerData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_CustomerData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x002DD0F4 File Offset: 0x002DB2F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315151, RefRangeEnd = 315155, XrefRangeStart = 315147, XrefRangeEnd = 315151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStringArray_0(this Writer writer, Il2CppStringArray value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x002DD13C File Offset: 0x002DB33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315155, XrefRangeEnd = 315159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0(this Writer writer, Il2CppStructArray<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x002DD184 File Offset: 0x002DB384
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated(this Writer writer, EDrugType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x002DD1C8 File Offset: 0x002DB3C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315172, RefRangeEnd = 315175, XrefRangeStart = 315159, XrefRangeEnd = 315172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated(this Writer writer, GameData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated_Public_Static_Void_Writer_GameData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x002DD210 File Offset: 0x002DB410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315175, XrefRangeEnd = 315179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated(this Writer writer, GameSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_GameSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x002DD258 File Offset: 0x002DB458
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315199, RefRangeEnd = 315206, XrefRangeStart = 315179, XrefRangeEnd = 315199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated(this Writer writer, DeliveryInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated_Public_Static_Void_Writer_DeliveryInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x002DD2A0 File Offset: 0x002DB4A0
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated(this Writer writer, EDeliveryStatus value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated_Public_Static_Void_Writer_EDeliveryStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x002DD2E4 File Offset: 0x002DB4E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315211, RefRangeEnd = 315215, XrefRangeStart = 315206, XrefRangeEnd = 315211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated(this Writer writer, ExplosionData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ExplosionData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x002DD328 File Offset: 0x002DB528
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ECardSuit_0(this Writer writer, PlayingCard.ECardSuit value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardSuit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x002DD36C File Offset: 0x002DB56C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ECardValue_0(this Writer writer, PlayingCard.ECardValue value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x002DD3B0 File Offset: 0x002DB5B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315219, RefRangeEnd = 315223, XrefRangeStart = 315215, XrefRangeEnd = 315219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0(this Writer writer, Il2CppReferenceArray<NetworkObject> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x002DD3F8 File Offset: 0x002DB5F8
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EStage_0(this Writer writer, RTBGameController.EStage value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EStage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x002DD43C File Offset: 0x002DB63C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ESymbol_0(this Writer writer, SlotMachine.ESymbol value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x002DD480 File Offset: 0x002DB680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315227, RefRangeEnd = 315230, XrefRangeStart = 315223, XrefRangeEnd = 315227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0(this Writer writer, Il2CppStructArray<SlotMachine.ESymbol> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A6 RID: 47270 RVA: 0x002DD4C8 File Offset: 0x002DB6C8
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated(this Writer writer, EDoorSide value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated_Public_Static_Void_Writer_EDoorSide_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x002DD50C File Offset: 0x002DB70C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated(this Writer writer, EVehicleColor value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated_Public_Static_Void_Writer_EVehicleColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x002DD550 File Offset: 0x002DB750
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315237, RefRangeEnd = 315241, XrefRangeStart = 315230, XrefRangeEnd = 315237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated(this Writer writer, ParkData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ParkData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x002DD598 File Offset: 0x002DB798
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated(this Writer writer, EParkingAlignment value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated_Public_Static_Void_Writer_EParkingAlignment_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x002DD5DC File Offset: 0x002DB7DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315254, RefRangeEnd = 315260, XrefRangeStart = 315241, XrefRangeEnd = 315254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated(this Writer writer, TrashContentData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TrashContentData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AB RID: 47275 RVA: 0x002DD624 File Offset: 0x002DB824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315260, XrefRangeEnd = 315264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0(this Writer writer, Il2CppStructArray<int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AC RID: 47276 RVA: 0x002DD66C File Offset: 0x002DB86C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 315271, RefRangeEnd = 315292, XrefRangeStart = 315264, XrefRangeEnd = 315271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated(this Writer writer, Coordinate value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated_Public_Static_Void_Writer_Coordinate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x002DD6B4 File Offset: 0x002DB8B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315299, RefRangeEnd = 315305, XrefRangeStart = 315292, XrefRangeEnd = 315299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated(this Writer writer, WeedAppearanceSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_WeedAppearanceSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AE RID: 47278 RVA: 0x002DD6FC File Offset: 0x002DB8FC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 315310, RefRangeEnd = 315322, XrefRangeStart = 315305, XrefRangeEnd = 315310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated(this Writer writer, CocaineAppearanceSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_CocaineAppearanceSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x002DD744 File Offset: 0x002DB944
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 315310, RefRangeEnd = 315322, XrefRangeStart = 315310, XrefRangeEnd = 315322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated(this Writer writer, MethAppearanceSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_MethAppearanceSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x002DD78C File Offset: 0x002DB98C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314895, RefRangeEnd = 314899, XrefRangeStart = 314895, XrefRangeEnd = 314899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated(this Writer writer, NewMixOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_NewMixOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x002DD7D4 File Offset: 0x002DB9D4
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 314551, RefRangeEnd = 314659, XrefRangeStart = 314551, XrefRangeEnd = 314659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EState_0(this Writer writer, Recycler.EState value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x002DD818 File Offset: 0x002DBA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315322, XrefRangeEnd = 315333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated(this Writer writer, CoordinateProceduralTilePair value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated_Public_Static_Void_Writer_CoordinateProceduralTilePair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x002DD868 File Offset: 0x002DBA68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315337, RefRangeEnd = 315343, XrefRangeStart = 315333, XrefRangeEnd = 315337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<CoordinateProceduralTilePair> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_CoordinateProceduralTilePair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x002DD8B0 File Offset: 0x002DBAB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315353, RefRangeEnd = 315359, XrefRangeStart = 315343, XrefRangeEnd = 315353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated(this Writer writer, ChemistryCookOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_ChemistryCookOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x002DD8F8 File Offset: 0x002DBAF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315369, RefRangeEnd = 315376, XrefRangeStart = 315359, XrefRangeEnd = 315369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated(this Writer writer, DryingOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_DryingOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x002DD940 File Offset: 0x002DBB40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315387, RefRangeEnd = 315393, XrefRangeStart = 315376, XrefRangeEnd = 315387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated(this Writer writer, OvenCookOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_OvenCookOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x002DD988 File Offset: 0x002DBB88
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 315402, RefRangeEnd = 315412, XrefRangeStart = 315393, XrefRangeEnd = 315402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated(this Writer writer, MixOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_MixOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x0005A7DF File Offset: 0x000589DF
		public GeneratedWriters___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007C34 RID: 31796
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;

		// Token: 0x04007C35 RID: 31797
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated_Public_Static_Void_Writer_VisionEventReceipt_0;

		// Token: 0x04007C36 RID: 31798
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EVisualState_0;

		// Token: 0x04007C37 RID: 31799
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EEventLevel_0;

		// Token: 0x04007C38 RID: 31800
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated_Public_Static_Void_Writer_ContractInfo_0;

		// Token: 0x04007C39 RID: 31801
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated_Public_Static_Void_Writer_ProductList_0;

		// Token: 0x04007C3A RID: 31802
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Entry_PDM_0;

		// Token: 0x04007C3B RID: 31803
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuality_0;

		// Token: 0x04007C3C RID: 31804
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_Entry_PDM_0;

		// Token: 0x04007C3D RID: 31805
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated_Public_Static_Void_Writer_QuestWindowConfig_0;

		// Token: 0x04007C3E RID: 31806
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated_Public_Static_Void_Writer_GameDateTime_0;

		// Token: 0x04007C3F RID: 31807
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EQuestAction_0;

		// Token: 0x04007C40 RID: 31808
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuestState_0;

		// Token: 0x04007C41 RID: 31809
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated_Public_Static_Void_Writer_Impact_0;

		// Token: 0x04007C42 RID: 31810
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EImpactType_0;

		// Token: 0x04007C43 RID: 31811
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated_Public_Static_Void_Writer_LandVehicle_0;

		// Token: 0x04007C44 RID: 31812
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECheckpointLocation_0;

		// Token: 0x04007C45 RID: 31813
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated_Public_Static_Void_Writer_Player_0;

		// Token: 0x04007C46 RID: 31814
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C47 RID: 31815
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated_Public_Static_Void_Writer_StringIntPair_0;

		// Token: 0x04007C48 RID: 31816
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0;

		// Token: 0x04007C49 RID: 31817
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated_Public_Static_Void_Writer_Message_0;

		// Token: 0x04007C4A RID: 31818
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESenderType_0;

		// Token: 0x04007C4B RID: 31819
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated_Public_Static_Void_Writer_MessageChain_0;

		// Token: 0x04007C4C RID: 31820
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated_Public_Static_Void_Writer_MSGConversationData_0;

		// Token: 0x04007C4D RID: 31821
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextMessageData_0;

		// Token: 0x04007C4E RID: 31822
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0;

		// Token: 0x04007C4F RID: 31823
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextResponseData_0;

		// Token: 0x04007C50 RID: 31824
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0;

		// Token: 0x04007C51 RID: 31825
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated_Public_Static_Void_Writer_Response_0;

		// Token: 0x04007C52 RID: 31826
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C53 RID: 31827
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C54 RID: 31828
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated_Public_Static_Void_Writer_AdvancedTransitRouteData_0;

		// Token: 0x04007C55 RID: 31829
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EMode_0;

		// Token: 0x04007C56 RID: 31830
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04007C57 RID: 31831
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated_Public_Static_Void_Writer_ERank_0;

		// Token: 0x04007C58 RID: 31832
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated_Public_Static_Void_Writer_FullRank_0;

		// Token: 0x04007C59 RID: 31833
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_PlayerData_0;

		// Token: 0x04007C5A RID: 31834
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated_Public_Static_Void_Writer_VariableData_0;

		// Token: 0x04007C5B RID: 31835
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x04007C5C RID: 31836
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_AvatarSettings_0;

		// Token: 0x04007C5D RID: 31837
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EyeLidConfiguration_0;

		// Token: 0x04007C5E RID: 31838
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_LayerSetting_PDM_0;

		// Token: 0x04007C5F RID: 31839
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0;

		// Token: 0x04007C60 RID: 31840
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_AccessorySetting_PDM_0;

		// Token: 0x04007C61 RID: 31841
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0;

		// Token: 0x04007C62 RID: 31842
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_BasicAvatarSettings_0;

		// Token: 0x04007C63 RID: 31843
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EPursuitLevel_0;

		// Token: 0x04007C64 RID: 31844
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated_Public_Static_Void_Writer_Property_0;

		// Token: 0x04007C65 RID: 31845
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EEmployeeType_0;

		// Token: 0x04007C66 RID: 31846
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated_Public_Static_Void_Writer_EDealWindow_0;

		// Token: 0x04007C67 RID: 31847
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EHandoverOutcome_0;

		// Token: 0x04007C68 RID: 31848
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C69 RID: 31849
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_CustomerData_0;

		// Token: 0x04007C6A RID: 31850
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStringArray_0;

		// Token: 0x04007C6B RID: 31851
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0;

		// Token: 0x04007C6C RID: 31852
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EDrugType_0;

		// Token: 0x04007C6D RID: 31853
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated_Public_Static_Void_Writer_GameData_0;

		// Token: 0x04007C6E RID: 31854
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_GameSettings_0;

		// Token: 0x04007C6F RID: 31855
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated_Public_Static_Void_Writer_DeliveryInstance_0;

		// Token: 0x04007C70 RID: 31856
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated_Public_Static_Void_Writer_EDeliveryStatus_0;

		// Token: 0x04007C71 RID: 31857
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ExplosionData_0;

		// Token: 0x04007C72 RID: 31858
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardSuit_0;

		// Token: 0x04007C73 RID: 31859
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardValue_0;

		// Token: 0x04007C74 RID: 31860
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04007C75 RID: 31861
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EStage_0;

		// Token: 0x04007C76 RID: 31862
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESymbol_0;

		// Token: 0x04007C77 RID: 31863
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x04007C78 RID: 31864
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated_Public_Static_Void_Writer_EDoorSide_0;

		// Token: 0x04007C79 RID: 31865
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated_Public_Static_Void_Writer_EVehicleColor_0;

		// Token: 0x04007C7A RID: 31866
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ParkData_0;

		// Token: 0x04007C7B RID: 31867
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated_Public_Static_Void_Writer_EParkingAlignment_0;

		// Token: 0x04007C7C RID: 31868
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TrashContentData_0;

		// Token: 0x04007C7D RID: 31869
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0;

		// Token: 0x04007C7E RID: 31870
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated_Public_Static_Void_Writer_Coordinate_0;

		// Token: 0x04007C7F RID: 31871
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_WeedAppearanceSettings_0;

		// Token: 0x04007C80 RID: 31872
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_CocaineAppearanceSettings_0;

		// Token: 0x04007C81 RID: 31873
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_MethAppearanceSettings_0;

		// Token: 0x04007C82 RID: 31874
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_NewMixOperation_0;

		// Token: 0x04007C83 RID: 31875
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EState_0;

		// Token: 0x04007C84 RID: 31876
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated_Public_Static_Void_Writer_CoordinateProceduralTilePair_0;

		// Token: 0x04007C85 RID: 31877
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C86 RID: 31878
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_ChemistryCookOperation_0;

		// Token: 0x04007C87 RID: 31879
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_DryingOperation_0;

		// Token: 0x04007C88 RID: 31880
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_OvenCookOperation_0;

		// Token: 0x04007C89 RID: 31881
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_MixOperation_0;
	}
}
