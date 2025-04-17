﻿using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
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
	// Token: 0x020007A0 RID: 1952
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedReaders___Internal : Object
	{
		// Token: 0x0600B8B9 RID: 47289 RVA: 0x002DD9D0 File Offset: 0x002DBBD0
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedReaders___Internal()
		{
			Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedReaders___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr);
			GeneratedReaders___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686045);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds_Public_Static_VisionEventReceipt_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686046);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EVisualState_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686047);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EEventLevel_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686048);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds_Public_Static_ContractInfo_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686049);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds_Public_Static_ProductList_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686050);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Entry_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686051);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds_Public_Static_EQuality_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686052);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_Entry_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686053);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds_Public_Static_QuestWindowConfig_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686054);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds_Public_Static_GameDateTime_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686055);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EQuestAction_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686056);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds_Public_Static_EQuestState_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686057);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds_Public_Static_Impact_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686058);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds_Public_Static_EImpactType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686059);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds_Public_Static_LandVehicle_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686060);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECheckpointLocation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686061);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds_Public_Static_Player_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686062);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generateds_Public_Static_List_1_String_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686063);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds_Public_Static_StringIntPair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686064);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686065);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds_Public_Static_Message_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686066);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESenderType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686067);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds_Public_Static_MessageChain_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686068);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds_Public_Static_MSGConversationData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686069);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds_Public_Static_TextMessageData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686070);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686071);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds_Public_Static_TextResponseData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686072);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686073);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds_Public_Static_Response_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686074);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generateds_Public_Static_List_1_Response_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686075);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generateds_Public_Static_List_1_NetworkObject_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686076);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds_Public_Static_AdvancedTransitRouteData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686077);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EMode_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686078);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686079);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds_Public_Static_ERank_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686080);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds_Public_Static_FullRank_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686081);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds_Public_Static_PlayerData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686082);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds_Public_Static_VariableData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686083);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686084);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds_Public_Static_AvatarSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686085);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EyeLidConfiguration_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686086);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_LayerSetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686087);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_LayerSetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686088);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_AccessorySetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686089);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686090);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds_Public_Static_BasicAvatarSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686091);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EPursuitLevel_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686092);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds_Public_Static_Property_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686093);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds_Public_Static_EEmployeeType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686094);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds_Public_Static_EDealWindow_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686095);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EHandoverOutcome_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686096);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generateds_Public_Static_List_1_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686097);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds_Public_Static_CustomerData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686098);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686099);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Single_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686100);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds_Public_Static_EDrugType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686101);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds_Public_Static_GameData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686102);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds_Public_Static_GameSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686103);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds_Public_Static_DeliveryInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686104);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds_Public_Static_EDeliveryStatus_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686105);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds_Public_Static_ExplosionData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686106);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardSuit_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686107);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardValue_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686108);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686109);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EStage_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686110);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESymbol_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686111);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686112);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds_Public_Static_EDoorSide_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686113);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds_Public_Static_EVehicleColor_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686114);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds_Public_Static_ParkData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686115);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds_Public_Static_EParkingAlignment_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686116);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds_Public_Static_TrashContentData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686117);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686118);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds_Public_Static_Coordinate_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686119);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_WeedAppearanceSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686120);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_CocaineAppearanceSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686121);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_MethAppearanceSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686122);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds_Public_Static_NewMixOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686123);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EState_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686124);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds_Public_Static_CoordinateProceduralTilePair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686125);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generateds_Public_Static_List_1_CoordinateProceduralTilePair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686126);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds_Public_Static_ChemistryCookOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686127);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds_Public_Static_DryingOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686128);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds_Public_Static_OvenCookOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686129);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds_Public_Static_MixOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686130);
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x002DE0B8 File Offset: 0x002DC2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315412, XrefRangeEnd = 316309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BB RID: 47291 RVA: 0x002DE0E0 File Offset: 0x002DC2E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316317, RefRangeEnd = 316319, XrefRangeStart = 316309, XrefRangeEnd = 316317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisionEventReceipt Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds_Public_Static_VisionEventReceipt_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEventReceipt>(intPtr3) : null;
		}

		// Token: 0x0600B8BC RID: 47292 RVA: 0x002DE124 File Offset: 0x002DC324
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316319, XrefRangeEnd = 316322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerVisualState.EVisualState Method_Public_Static_EVisualState_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EVisualState_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8BD RID: 47293 RVA: 0x002DE168 File Offset: 0x002DC368
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisionCone.EEventLevel Method_Public_Static_EEventLevel_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EEventLevel_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8BE RID: 47294 RVA: 0x002DE1AC File Offset: 0x002DC3AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 316404, RefRangeEnd = 316409, XrefRangeStart = 316374, XrefRangeEnd = 316404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContractInfo Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds_Public_Static_ContractInfo_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x0600B8BF RID: 47295 RVA: 0x002DE1F0 File Offset: 0x002DC3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316417, RefRangeEnd = 316418, XrefRangeStart = 316409, XrefRangeEnd = 316417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductList Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds_Public_Static_ProductList_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr3) : null;
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x002DE234 File Offset: 0x002DC434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316418, XrefRangeEnd = 316428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductList.Entry Method_Public_Static_Entry_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Entry_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr3) : null;
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x002DE278 File Offset: 0x002DC478
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds_Public_Static_EQuality_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x002DE2BC File Offset: 0x002DC4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316428, XrefRangeEnd = 316432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductList.Entry> Method_Public_Static_List_1_Entry_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_Entry_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductList.Entry>>(intPtr3) : null;
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x002DE300 File Offset: 0x002DC500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316432, XrefRangeEnd = 316440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QuestWindowConfig Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds_Public_Static_QuestWindowConfig_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr3) : null;
		}

		// Token: 0x0600B8C4 RID: 47300 RVA: 0x002DE344 File Offset: 0x002DC544
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 316444, RefRangeEnd = 316451, XrefRangeStart = 316440, XrefRangeEnd = 316444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDateTime Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds_Public_Static_GameDateTime_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x002DE388 File Offset: 0x002DC588
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QuestManager.EQuestAction Method_Public_Static_EQuestAction_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EQuestAction_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x002DE3CC File Offset: 0x002DC5CC
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuestState Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds_Public_Static_EQuestState_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x002DE410 File Offset: 0x002DC610
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 316469, RefRangeEnd = 316473, XrefRangeStart = 316451, XrefRangeEnd = 316469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Impact Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds_Public_Static_Impact_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Impact>(intPtr3) : null;
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x002DE454 File Offset: 0x002DC654
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EImpactType Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds_Public_Static_EImpactType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x002DE498 File Offset: 0x002DC698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316476, RefRangeEnd = 316478, XrefRangeStart = 316473, XrefRangeEnd = 316476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LandVehicle Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds_Public_Static_LandVehicle_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x002DE4DC File Offset: 0x002DC6DC
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CheckpointManager.ECheckpointLocation Method_Public_Static_ECheckpointLocation_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECheckpointLocation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x002DE520 File Offset: 0x002DC720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316481, RefRangeEnd = 316482, XrefRangeStart = 316478, XrefRangeEnd = 316481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds_Public_Static_Player_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x0600B8CC RID: 47308 RVA: 0x002DE564 File Offset: 0x002DC764
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 316486, RefRangeEnd = 316496, XrefRangeStart = 316482, XrefRangeEnd = 316486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generateds_Public_Static_List_1_String_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x002DE5A8 File Offset: 0x002DC7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316496, XrefRangeEnd = 316504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringIntPair Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds_Public_Static_StringIntPair_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr3) : null;
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x002DE5EC File Offset: 0x002DC7EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316508, RefRangeEnd = 316509, XrefRangeStart = 316504, XrefRangeEnd = 316508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<StringIntPair> Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr3) : null;
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x002DE630 File Offset: 0x002DC830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316519, RefRangeEnd = 316521, XrefRangeStart = 316509, XrefRangeEnd = 316519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds_Public_Static_Message_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Message>(intPtr3) : null;
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x002DE674 File Offset: 0x002DC874
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message.ESenderType Method_Public_Static_ESenderType_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESenderType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x002DE6B8 File Offset: 0x002DC8B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316531, RefRangeEnd = 316533, XrefRangeStart = 316521, XrefRangeEnd = 316531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MessageChain Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds_Public_Static_MessageChain_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x002DE6FC File Offset: 0x002DC8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316555, RefRangeEnd = 316556, XrefRangeStart = 316533, XrefRangeEnd = 316555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MSGConversationData Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds_Public_Static_MSGConversationData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversationData>(intPtr3) : null;
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x002DE740 File Offset: 0x002DC940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316556, XrefRangeEnd = 316566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextMessageData Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds_Public_Static_TextMessageData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMessageData>(intPtr3) : null;
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x002DE784 File Offset: 0x002DC984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316566, XrefRangeEnd = 316570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TextMessageData> Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMessageData>>(intPtr3) : null;
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x002DE7C8 File Offset: 0x002DC9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316570, XrefRangeEnd = 316578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextResponseData Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds_Public_Static_TextResponseData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextResponseData>(intPtr3) : null;
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x002DE80C File Offset: 0x002DCA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316578, XrefRangeEnd = 316582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TextResponseData> Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextResponseData>>(intPtr3) : null;
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x002DE850 File Offset: 0x002DCA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316582, XrefRangeEnd = 316590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Response Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds_Public_Static_Response_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Response>(intPtr3) : null;
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x002DE894 File Offset: 0x002DCA94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316594, RefRangeEnd = 316596, XrefRangeStart = 316590, XrefRangeEnd = 316594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Response> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generateds_Public_Static_List_1_Response_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Response>>(intPtr3) : null;
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x002DE8D8 File Offset: 0x002DCAD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316600, RefRangeEnd = 316602, XrefRangeStart = 316596, XrefRangeEnd = 316600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<NetworkObject> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generateds_Public_Static_List_1_NetworkObject_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x0600B8DA RID: 47322 RVA: 0x002DE91C File Offset: 0x002DCB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316602, XrefRangeEnd = 316616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AdvancedTransitRouteData Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds_Public_Static_AdvancedTransitRouteData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
		}

		// Token: 0x0600B8DB RID: 47323 RVA: 0x002DE960 File Offset: 0x002DCB60
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ManagementItemFilter.EMode Method_Public_Static_EMode_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EMode_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x002DE9A4 File Offset: 0x002DCBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316620, RefRangeEnd = 316622, XrefRangeStart = 316616, XrefRangeEnd = 316620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<AdvancedTransitRouteData> Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AdvancedTransitRouteData>>(intPtr3) : null;
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x002DE9E8 File Offset: 0x002DCBE8
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERank Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds_Public_Static_ERank_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DE RID: 47326 RVA: 0x002DEA2C File Offset: 0x002DCC2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 316444, RefRangeEnd = 316451, XrefRangeStart = 316444, XrefRangeEnd = 316451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FullRank Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds_Public_Static_FullRank_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DF RID: 47327 RVA: 0x002DEA70 File Offset: 0x002DCC70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316638, RefRangeEnd = 316640, XrefRangeStart = 316622, XrefRangeEnd = 316638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerData Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds_Public_Static_PlayerData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr3) : null;
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x002DEAB4 File Offset: 0x002DCCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316640, XrefRangeEnd = 316654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VariableData Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds_Public_Static_VariableData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VariableData>(intPtr3) : null;
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x002DEAF8 File Offset: 0x002DCCF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316658, RefRangeEnd = 316660, XrefRangeStart = 316654, XrefRangeEnd = 316658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<VariableData> Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableData>>(intPtr3) : null;
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x002DEB3C File Offset: 0x002DCD3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316698, RefRangeEnd = 316700, XrefRangeStart = 316660, XrefRangeEnd = 316698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarSettings Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds_Public_Static_AvatarSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
		}

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x002DEB80 File Offset: 0x002DCD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316700, XrefRangeEnd = 316702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Eye.EyeLidConfiguration Method_Public_Static_EyeLidConfiguration_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EyeLidConfiguration_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x002DEBC4 File Offset: 0x002DCDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316702, XrefRangeEnd = 316705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarSettings.LayerSetting Method_Public_Static_LayerSetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_LayerSetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new AvatarSettings.LayerSetting(pointer);
		}

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x002DEC00 File Offset: 0x002DCE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316705, XrefRangeEnd = 316709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<AvatarSettings.LayerSetting> Method_Public_Static_List_1_LayerSetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_LayerSetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr3) : null;
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x002DEC44 File Offset: 0x002DCE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316709, XrefRangeEnd = 316716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarSettings.AccessorySetting Method_Public_Static_AccessorySetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_AccessorySetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings.AccessorySetting>(intPtr3) : null;
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x002DEC88 File Offset: 0x002DCE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316716, XrefRangeEnd = 316720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<AvatarSettings.AccessorySetting> Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.AccessorySetting>>(intPtr3) : null;
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x002DECCC File Offset: 0x002DCECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316764, RefRangeEnd = 316767, XrefRangeStart = 316720, XrefRangeEnd = 316764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BasicAvatarSettings Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds_Public_Static_BasicAvatarSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr3) : null;
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x002DED10 File Offset: 0x002DCF10
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerCrimeData.EPursuitLevel Method_Public_Static_EPursuitLevel_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EPursuitLevel_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x002DED54 File Offset: 0x002DCF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316770, RefRangeEnd = 316771, XrefRangeStart = 316767, XrefRangeEnd = 316770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Property Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds_Public_Static_Property_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x002DED98 File Offset: 0x002DCF98
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EEmployeeType Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds_Public_Static_EEmployeeType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x002DEDDC File Offset: 0x002DCFDC
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDealWindow Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds_Public_Static_EDealWindow_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x002DEE20 File Offset: 0x002DD020
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HandoverScreen.EHandoverOutcome Method_Public_Static_EHandoverOutcome_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EHandoverOutcome_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x002DEE64 File Offset: 0x002DD064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316775, RefRangeEnd = 316777, XrefRangeStart = 316771, XrefRangeEnd = 316775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ItemInstance> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generateds_Public_Static_List_1_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x002DEEA8 File Offset: 0x002DD0A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316813, RefRangeEnd = 316814, XrefRangeStart = 316777, XrefRangeEnd = 316813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppScheduleOne.Persistence.Datas.CustomerData Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds_Public_Static_CustomerData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Persistence.Datas.CustomerData>(intPtr3) : null;
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x002DEEEC File Offset: 0x002DD0EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316818, RefRangeEnd = 316820, XrefRangeStart = 316814, XrefRangeEnd = 316818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Method_Public_Static_Il2CppStringArray_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x002DEF30 File Offset: 0x002DD130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316836, RefRangeEnd = 316837, XrefRangeStart = 316820, XrefRangeEnd = 316836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> Method_Public_Static_Il2CppStructArray_1_Single_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Single_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x002DEF74 File Offset: 0x002DD174
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDrugType Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds_Public_Static_EDrugType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x002DEFB8 File Offset: 0x002DD1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316857, RefRangeEnd = 316858, XrefRangeStart = 316837, XrefRangeEnd = 316857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameData Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds_Public_Static_GameData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameData>(intPtr3) : null;
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x002DEFFC File Offset: 0x002DD1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316858, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSettings Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds_Public_Static_GameSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr3) : null;
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x002DF040 File Offset: 0x002DD240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316883, RefRangeEnd = 316886, XrefRangeStart = 316862, XrefRangeEnd = 316883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeliveryInstance Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds_Public_Static_DeliveryInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x002DF084 File Offset: 0x002DD284
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDeliveryStatus Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds_Public_Static_EDeliveryStatus_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x002DF0C8 File Offset: 0x002DD2C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316890, RefRangeEnd = 316892, XrefRangeStart = 316886, XrefRangeEnd = 316890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExplosionData Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds_Public_Static_ExplosionData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x002DF10C File Offset: 0x002DD30C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayingCard.ECardSuit Method_Public_Static_ECardSuit_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardSuit_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x002DF150 File Offset: 0x002DD350
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayingCard.ECardValue Method_Public_Static_ECardValue_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardValue_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x002DF194 File Offset: 0x002DD394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316896, RefRangeEnd = 316898, XrefRangeStart = 316892, XrefRangeEnd = 316896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<NetworkObject> Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x002DF1D8 File Offset: 0x002DD3D8
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTBGameController.EStage Method_Public_Static_EStage_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EStage_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x002DF21C File Offset: 0x002DD41C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SlotMachine.ESymbol Method_Public_Static_ESymbol_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESymbol_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8FD RID: 47357 RVA: 0x002DF260 File Offset: 0x002DD460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316914, RefRangeEnd = 316915, XrefRangeStart = 316898, XrefRangeEnd = 316914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<SlotMachine.ESymbol> Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SlotMachine.ESymbol>>(intPtr3) : null;
		}

		// Token: 0x0600B8FE RID: 47358 RVA: 0x002DF2A4 File Offset: 0x002DD4A4
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDoorSide Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds_Public_Static_EDoorSide_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8FF RID: 47359 RVA: 0x002DF2E8 File Offset: 0x002DD4E8
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EVehicleColor Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds_Public_Static_EVehicleColor_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B900 RID: 47360 RVA: 0x002DF32C File Offset: 0x002DD52C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316932, RefRangeEnd = 316934, XrefRangeStart = 316915, XrefRangeEnd = 316932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParkData Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds_Public_Static_ParkData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkData>(intPtr3) : null;
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x002DF370 File Offset: 0x002DD570
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EParkingAlignment Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds_Public_Static_EParkingAlignment_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x002DF3B4 File Offset: 0x002DD5B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 316945, RefRangeEnd = 316949, XrefRangeStart = 316934, XrefRangeEnd = 316945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashContentData Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds_Public_Static_TrashContentData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr3) : null;
		}

		// Token: 0x0600B903 RID: 47363 RVA: 0x002DF3F8 File Offset: 0x002DD5F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316965, RefRangeEnd = 316966, XrefRangeStart = 316949, XrefRangeEnd = 316965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x002DF43C File Offset: 0x002DD63C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 316974, RefRangeEnd = 316980, XrefRangeStart = 316966, XrefRangeEnd = 316974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds_Public_Static_Coordinate_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x002DF480 File Offset: 0x002DD680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316988, RefRangeEnd = 316991, XrefRangeStart = 316980, XrefRangeEnd = 316988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedAppearanceSettings Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_WeedAppearanceSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x002DF4C4 File Offset: 0x002DD6C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316997, RefRangeEnd = 317000, XrefRangeStart = 316991, XrefRangeEnd = 316997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineAppearanceSettings Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_CocaineAppearanceSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x002DF508 File Offset: 0x002DD708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317006, RefRangeEnd = 317009, XrefRangeStart = 317000, XrefRangeEnd = 317006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethAppearanceSettings Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_MethAppearanceSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x002DF54C File Offset: 0x002DD74C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317017, RefRangeEnd = 317019, XrefRangeStart = 317009, XrefRangeEnd = 317017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NewMixOperation Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds_Public_Static_NewMixOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr3) : null;
		}

		// Token: 0x0600B909 RID: 47369 RVA: 0x002DF590 File Offset: 0x002DD790
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316322, RefRangeEnd = 316374, XrefRangeStart = 316322, XrefRangeEnd = 316374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Recycler.EState Method_Public_Static_EState_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EState_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x002DF5D4 File Offset: 0x002DD7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317019, XrefRangeEnd = 317033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CoordinateProceduralTilePair Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds_Public_Static_CoordinateProceduralTilePair_Reader_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CoordinateProceduralTilePair(pointer);
		}

		// Token: 0x0600B90B RID: 47371 RVA: 0x002DF610 File Offset: 0x002DD810
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317037, RefRangeEnd = 317041, XrefRangeStart = 317033, XrefRangeEnd = 317037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CoordinateProceduralTilePair> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generateds_Public_Static_List_1_CoordinateProceduralTilePair_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr3) : null;
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x002DF654 File Offset: 0x002DD854
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317053, RefRangeEnd = 317056, XrefRangeStart = 317041, XrefRangeEnd = 317053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChemistryCookOperation Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds_Public_Static_ChemistryCookOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryCookOperation>(intPtr3) : null;
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x002DF698 File Offset: 0x002DD898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317068, RefRangeEnd = 317071, XrefRangeStart = 317056, XrefRangeEnd = 317068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DryingOperation Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds_Public_Static_DryingOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr3) : null;
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x002DF6DC File Offset: 0x002DD8DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317085, RefRangeEnd = 317088, XrefRangeStart = 317071, XrefRangeEnd = 317085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OvenCookOperation Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds_Public_Static_OvenCookOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OvenCookOperation>(intPtr3) : null;
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x002DF720 File Offset: 0x002DD920
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 317100, RefRangeEnd = 317105, XrefRangeStart = 317088, XrefRangeEnd = 317100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MixOperation Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds_Public_Static_MixOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixOperation>(intPtr3) : null;
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x0005A7E8 File Offset: 0x000589E8
		public GeneratedReaders___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007C8A RID: 31882
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;

		// Token: 0x04007C8B RID: 31883
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds_Public_Static_VisionEventReceipt_Reader_0;

		// Token: 0x04007C8C RID: 31884
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EVisualState_Reader_0;

		// Token: 0x04007C8D RID: 31885
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EEventLevel_Reader_0;

		// Token: 0x04007C8E RID: 31886
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds_Public_Static_ContractInfo_Reader_0;

		// Token: 0x04007C8F RID: 31887
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds_Public_Static_ProductList_Reader_0;

		// Token: 0x04007C90 RID: 31888
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Entry_Reader_PDM_0;

		// Token: 0x04007C91 RID: 31889
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds_Public_Static_EQuality_Reader_0;

		// Token: 0x04007C92 RID: 31890
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_List_1_Entry_Reader_PDM_0;

		// Token: 0x04007C93 RID: 31891
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds_Public_Static_QuestWindowConfig_Reader_0;

		// Token: 0x04007C94 RID: 31892
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds_Public_Static_GameDateTime_Reader_0;

		// Token: 0x04007C95 RID: 31893
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EQuestAction_Reader_0;

		// Token: 0x04007C96 RID: 31894
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds_Public_Static_EQuestState_Reader_0;

		// Token: 0x04007C97 RID: 31895
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds_Public_Static_Impact_Reader_0;

		// Token: 0x04007C98 RID: 31896
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds_Public_Static_EImpactType_Reader_0;

		// Token: 0x04007C99 RID: 31897
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds_Public_Static_LandVehicle_Reader_0;

		// Token: 0x04007C9A RID: 31898
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ECheckpointLocation_Reader_0;

		// Token: 0x04007C9B RID: 31899
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds_Public_Static_Player_Reader_0;

		// Token: 0x04007C9C RID: 31900
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007C9D RID: 31901
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds_Public_Static_StringIntPair_Reader_0;

		// Token: 0x04007C9E RID: 31902
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0;

		// Token: 0x04007C9F RID: 31903
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds_Public_Static_Message_Reader_0;

		// Token: 0x04007CA0 RID: 31904
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ESenderType_Reader_0;

		// Token: 0x04007CA1 RID: 31905
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds_Public_Static_MessageChain_Reader_0;

		// Token: 0x04007CA2 RID: 31906
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds_Public_Static_MSGConversationData_Reader_0;

		// Token: 0x04007CA3 RID: 31907
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds_Public_Static_TextMessageData_Reader_0;

		// Token: 0x04007CA4 RID: 31908
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0;

		// Token: 0x04007CA5 RID: 31909
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds_Public_Static_TextResponseData_Reader_0;

		// Token: 0x04007CA6 RID: 31910
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0;

		// Token: 0x04007CA7 RID: 31911
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds_Public_Static_Response_Reader_0;

		// Token: 0x04007CA8 RID: 31912
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CA9 RID: 31913
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CAA RID: 31914
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds_Public_Static_AdvancedTransitRouteData_Reader_0;

		// Token: 0x04007CAB RID: 31915
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EMode_Reader_0;

		// Token: 0x04007CAC RID: 31916
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0;

		// Token: 0x04007CAD RID: 31917
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds_Public_Static_ERank_Reader_0;

		// Token: 0x04007CAE RID: 31918
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds_Public_Static_FullRank_Reader_0;

		// Token: 0x04007CAF RID: 31919
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds_Public_Static_PlayerData_Reader_0;

		// Token: 0x04007CB0 RID: 31920
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds_Public_Static_VariableData_Reader_0;

		// Token: 0x04007CB1 RID: 31921
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0;

		// Token: 0x04007CB2 RID: 31922
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds_Public_Static_AvatarSettings_Reader_0;

		// Token: 0x04007CB3 RID: 31923
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EyeLidConfiguration_Reader_PDM_0;

		// Token: 0x04007CB4 RID: 31924
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_LayerSetting_Reader_PDM_0;

		// Token: 0x04007CB5 RID: 31925
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_List_1_LayerSetting_Reader_PDM_0;

		// Token: 0x04007CB6 RID: 31926
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_AccessorySetting_Reader_PDM_0;

		// Token: 0x04007CB7 RID: 31927
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0;

		// Token: 0x04007CB8 RID: 31928
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds_Public_Static_BasicAvatarSettings_Reader_0;

		// Token: 0x04007CB9 RID: 31929
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EPursuitLevel_Reader_0;

		// Token: 0x04007CBA RID: 31930
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds_Public_Static_Property_Reader_0;

		// Token: 0x04007CBB RID: 31931
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds_Public_Static_EEmployeeType_Reader_0;

		// Token: 0x04007CBC RID: 31932
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds_Public_Static_EDealWindow_Reader_0;

		// Token: 0x04007CBD RID: 31933
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EHandoverOutcome_Reader_0;

		// Token: 0x04007CBE RID: 31934
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CBF RID: 31935
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds_Public_Static_CustomerData_Reader_0;

		// Token: 0x04007CC0 RID: 31936
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_Reader_0;

		// Token: 0x04007CC1 RID: 31937
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Single_Reader_0;

		// Token: 0x04007CC2 RID: 31938
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds_Public_Static_EDrugType_Reader_0;

		// Token: 0x04007CC3 RID: 31939
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds_Public_Static_GameData_Reader_0;

		// Token: 0x04007CC4 RID: 31940
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds_Public_Static_GameSettings_Reader_0;

		// Token: 0x04007CC5 RID: 31941
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds_Public_Static_DeliveryInstance_Reader_0;

		// Token: 0x04007CC6 RID: 31942
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds_Public_Static_EDeliveryStatus_Reader_0;

		// Token: 0x04007CC7 RID: 31943
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds_Public_Static_ExplosionData_Reader_0;

		// Token: 0x04007CC8 RID: 31944
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ECardSuit_Reader_0;

		// Token: 0x04007CC9 RID: 31945
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ECardValue_Reader_0;

		// Token: 0x04007CCA RID: 31946
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0;

		// Token: 0x04007CCB RID: 31947
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EStage_Reader_0;

		// Token: 0x04007CCC RID: 31948
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ESymbol_Reader_0;

		// Token: 0x04007CCD RID: 31949
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0;

		// Token: 0x04007CCE RID: 31950
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds_Public_Static_EDoorSide_Reader_0;

		// Token: 0x04007CCF RID: 31951
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds_Public_Static_EVehicleColor_Reader_0;

		// Token: 0x04007CD0 RID: 31952
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds_Public_Static_ParkData_Reader_0;

		// Token: 0x04007CD1 RID: 31953
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds_Public_Static_EParkingAlignment_Reader_0;

		// Token: 0x04007CD2 RID: 31954
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds_Public_Static_TrashContentData_Reader_0;

		// Token: 0x04007CD3 RID: 31955
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0;

		// Token: 0x04007CD4 RID: 31956
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds_Public_Static_Coordinate_Reader_0;

		// Token: 0x04007CD5 RID: 31957
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_WeedAppearanceSettings_Reader_0;

		// Token: 0x04007CD6 RID: 31958
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_CocaineAppearanceSettings_Reader_0;

		// Token: 0x04007CD7 RID: 31959
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_MethAppearanceSettings_Reader_0;

		// Token: 0x04007CD8 RID: 31960
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds_Public_Static_NewMixOperation_Reader_0;

		// Token: 0x04007CD9 RID: 31961
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EState_Reader_0;

		// Token: 0x04007CDA RID: 31962
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds_Public_Static_CoordinateProceduralTilePair_Reader_0;

		// Token: 0x04007CDB RID: 31963
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CDC RID: 31964
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds_Public_Static_ChemistryCookOperation_Reader_0;

		// Token: 0x04007CDD RID: 31965
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds_Public_Static_DryingOperation_Reader_0;

		// Token: 0x04007CDE RID: 31966
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds_Public_Static_OvenCookOperation_Reader_0;

		// Token: 0x04007CDF RID: 31967
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds_Public_Static_MixOperation_Reader_0;
	}
}
